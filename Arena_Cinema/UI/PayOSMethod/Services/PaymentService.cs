using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using DAL;
using DTO;
using PayOS;
using PayOS.Models.V2.PaymentRequests;

namespace UI.PayOSMethod.Services
{
    public class PaymentService
    {
        //private readonly PayOSClient _client;
        private readonly BLL.PayOS _payOS;
        private readonly CinemaDBContext _context;

        private const decimal POINTS_RATE = 100000m;

        public PaymentService()
        {
            _payOS = new BLL.PayOS(
                clientId: "fbfb511c-099a-4a58-b147-9149e5554475",
                apiKey: "0436f5b4-f241-4862-8df9-53f80d89d826",
                checksumKey: "3771898fb26288d7d994ea962f229c3ce279580006278858d244047697b9a9cf"  // <-- THAY BẰNG CHECKSUM KEY THẬT
            );
            _context = new CinemaDBContext();
        }

        public async Task<string> CreatePaymentLink(long orderCode, int amount, string description, string returnUrl, string cancelUrl)
        {
            var items = new List<PaymentItem>
            {
                new PaymentItem()
                {
                    name = description,
                    price = amount,
                    quantity = 1
                }
            };

            PaymentData paymentData = new PaymentData()
            {
                orderCode = orderCode,
                amount = amount,
                description = description,
                returnUrl = returnUrl,
                cancelUrl = cancelUrl,
                items = items
            };

            // Trả về URL thay vì tự mở trình duyệt
            string paymentLink = await _payOS.CreatePaymentUrl(paymentData);
            return paymentLink;
        }
        /// <summary>
        /// ✅ Tạo payment link - Truyền InvoiceID
        /// </summary>
        public async Task<string> CreatePaymentLink(Guid invoiceID, long orderCode, int amount,
            string description, string returnUrl, string cancelUrl)
        {
            try
            {
                // ✅ 1. LƯU MAPPING vào memory
                PaymentMappingManager.Instance.AddMapping(orderCode, invoiceID, amount);

                var items = new List<PaymentItem>
                {
                    new PaymentItem()
                    {
                        name = description,
                        price = amount,
                        quantity = 1
                    }
                };

                PaymentData paymentData = new PaymentData()
                {
                    orderCode = orderCode,
                    amount = amount,
                    description = description, // Giữ ngắn gọn
                    returnUrl = returnUrl,
                    cancelUrl = cancelUrl,
                    items = items
                };

                // ✅ Truyền InvoiceID vào hàm CreatePaymentUrl
                string paymentLink = await _payOS.CreatePaymentUrl(paymentData, invoiceID);

                Console.WriteLine($"✅ Created payment link for Invoice: {invoiceID}");
                return paymentLink;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error creating payment link: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// ✅ QUERY và xử lý - Lấy InvoiceID từ memory mapping
        /// </summary>
        public async Task<PaymentCheckResult> CheckAndProcessPayment(long orderCode)
        {
            try
            {
                // ✅ 1. LẤY InvoiceID từ memory mapping
                Guid? invoiceID = PaymentMappingManager.Instance.GetInvoiceID(orderCode);

                if (!invoiceID.HasValue)
                {
                    Console.WriteLine($"❌ No mapping found for OrderCode: {orderCode}");
                    return new PaymentCheckResult
                    {
                        Status = "ERROR",
                        Message = "Không tìm thấy thông tin giao dịch trong bộ nhớ"
                    };
                }

                Console.WriteLine($"✅ Found mapping: OrderCode {orderCode} → InvoiceID {invoiceID.Value}");

                // 2. Query PayOS API
                var queryResult = await _payOS.GetPaymentStatus(orderCode);

                if (!queryResult.Success)
                {
                    Console.WriteLine($"⚠️ Query failed: {queryResult.ErrorMessage}");
                    return new PaymentCheckResult
                    {
                        Status = "ERROR",
                        Message = queryResult.ErrorMessage
                    };
                }

                Console.WriteLine($"📊 Payment status: {queryResult.Status}");

                // 3. Xử lý theo status
                if (queryResult.Status == "PAID")
                {
                    bool success = ProcessSuccessPayment(invoiceID.Value, orderCode, "PayOS");

                    // ✅ XÓA mapping sau khi xử lý xong
                    if (success)
                    {
                        PaymentMappingManager.Instance.RemoveMapping(orderCode);
                    }

                    return new PaymentCheckResult
                    {
                        Status = "PAID",
                        InvoiceID = invoiceID.Value,
                        Success = success,
                        Message = success ? "Thanh toán thành công" : "Lỗi xử lý thanh toán"
                    };
                }
                else if (queryResult.Status == "CANCELLED")
                {
                    ProcessCancelPayment(invoiceID.Value, "Đã hủy trên PayOS");

                    // ✅ XÓA mapping
                    PaymentMappingManager.Instance.RemoveMapping(orderCode);

                    return new PaymentCheckResult
                    {
                        Status = "CANCELLED",
                        InvoiceID = invoiceID.Value,
                        Message = "Thanh toán đã bị hủy"
                    };
                }
                else if (queryResult.Status == "PENDING" || queryResult.Status == "PROCESSING")
                {
                    return new PaymentCheckResult
                    {
                        Status = queryResult.Status,
                        InvoiceID = invoiceID.Value,
                        Message = "Đang chờ thanh toán"
                    };
                }

                return new PaymentCheckResult
                {
                    Status = "UNKNOWN",
                    Message = $"Unknown status: {queryResult.Status}"
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error checking payment: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                return new PaymentCheckResult
                {
                    Status = "ERROR",
                    Message = ex.Message
                };
            }
        }

        ///Tính điểm thưởng: 100,000 VND = 1 điểm
        private decimal CalculatePoints(decimal amount)
        {
            return Math.Floor(amount / POINTS_RATE);
        }

        ///Cộng điểm cho khách hàng
        private bool AddPointsToCustomer(Guid? customerID, decimal points)
        {
            try
            {
                if (!customerID.HasValue || customerID.Value == Guid.Empty)
                {
                    Console.WriteLine("⚠️ No CustomerID provided, skipping points");
                    return true; // Không có khách hàng thì bỏ qua, không phải lỗi
                }

                var customer = _context.Customers.FirstOrDefault(c => c.CustomerID == customerID.Value);
                if (customer == null)
                {
                    Console.WriteLine($"⚠️ Customer not found: {customerID.Value}");
                    return false;
                }

                // Cộng điểm (nếu Point là NULL thì khởi tạo = 0)
                customer.Point = (customer.Point ?? 0) + points;

                _context.SaveChanges();

                Console.WriteLine($"✅ Added {points} points to Customer {customerID.Value}. Total: {customer.Point}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error adding points: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Xử lý thanh toán thành công - Cập nhật Invoice và tạo Payment record
        /// </summary>
        public bool ProcessSuccessPayment(Guid invoiceID, long orderCode, string method = "PayOS")
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == invoiceID);
                    if (invoice == null)
                    {
                        Console.WriteLine($"❌ Invoice not found: {invoiceID}");
                        return false;
                    }

                    // Kiểm tra đã thanh toán chưa
                    if (invoice.Status == "Đã thanh toán")
                    {
                        Console.WriteLine($"⚠️ Invoice {invoiceID} already paid");
                        return true;
                    }

                    // Kiểm tra duplicate payment
                    var existingPayment = _context.Payments
                        .FirstOrDefault(p => p.InvoiceID == invoiceID);

                    if (existingPayment != null)
                    {
                        Console.WriteLine($"⚠️ Payment already exists for Invoice: {invoiceID}");
                        return true;
                    }

                    // 1. Cập nhật hóa đơn
                    invoice.Status = "Đã thanh toán";

                    // 2. ✅ TẠO PAYMENT
                    var payment = new Payment
                    {
                        PaymentID = Guid.NewGuid(),
                        InvoiceID = invoiceID,
                        Method = method,
                        Amount = invoice.TotalAmount ?? 0,
                        PaymentTime = DateTime.Now,
                    };
                    _context.Payments.Add(payment);

                    // 3. Cập nhật vé
                    var invoiceTickets = _context.InvoiceTickets
                        .Where(it => it.InvoiceID == invoiceID)
                        .ToList();

                    if (invoiceTickets.Any())
                    {
                        var ticketIds = invoiceTickets.Select(it => it.TicketID).ToList();
                        var tickets = _context.Tickets.Where(t => ticketIds.Contains(t.TicketID)).ToList();

                        foreach (var ticket in tickets)
                        {
                            ticket.Status = "Đã bán";
                        }
                    }

                    //Cộng điểm cho khách hàng nếu có
                    if (invoice.CustomerID.HasValue && invoice.CustomerID.Value != Guid.Empty)
                    {
                        decimal amount = invoice.TotalAmount ?? 0;
                        decimal points = CalculatePoints(amount);

                        bool pointsAdded = AddPointsToCustomer(invoice.CustomerID, points);
                        if (!pointsAdded)
                        {
                            Console.WriteLine($"⚠️ Failed to add points, but continuing with payment");
                        }
                    }

                    // 4. Lưu
                    _context.SaveChanges();
                    transaction.Commit();

                    Console.WriteLine($"✅ Payment processed - Invoice: {invoiceID}, Payment: {payment.PaymentID}");
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine($"❌ Error processing payment: {ex.Message}");
                    return false;
                }
            }
        }

        /// <summary>
        /// Xử lý thanh toán tiền mặt
        /// </summary>
        public bool ProcessCashPayment(Guid invoiceID)
        {
            return ProcessSuccessPayment(invoiceID, 0, "Tiền mặt");
        }

        /// <summary>
        /// Xử lý hủy thanh toán
        /// </summary>
        public bool ProcessCancelPayment(Guid invoiceID, string reason = "Khách hàng hủy")
        {
            try
            {
                var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == invoiceID);
                if (invoice == null)
                {
                    return false;
                }

                // Cập nhật trạng thái hóa đơn
                invoice.Status = "Đã hủy";

                // Có thể tạo record Payment với status failed để tracking
                //var payment = new Payment
                //{
                //    PaymentID = Guid.NewGuid(),
                //    InvoiceID = invoiceID,
                //    Method = "PayOS",
                //    Amount = 0,
                //    PaymentTime = DateTime.Now,
                //};
                //_context.Payments.Add(payment);

                _context.SaveChanges();

                Console.WriteLine($"✅ Payment cancelled for Invoice: {invoiceID}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error cancelling payment: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra trạng thái thanh toán
        /// </summary>
        public string GetPaymentStatus(Guid invoiceID)
        {
            var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == invoiceID);
            return invoice?.Status ?? "Unknown";
        }

        /// <summary>
        /// Lấy thông tin Payment để in hóa đơn
        /// </summary>
        public Payment GetPaymentInfo(Guid invoiceID)
        {
            return _context.Payments
                .Where(p => p.InvoiceID == invoiceID)
                .OrderByDescending(p => p.PaymentTime)
                .FirstOrDefault();
        }

        //public async Task CreatePaymentLink(int orderCode, int amount, string description, string returnUrl, string cancelUrl)
        //{
        //    var item = new List<PaymentItem>
        //    {
        //        new PaymentItem()
        //        {
        //            name = description,
        //            price = amount,
        //            quantity = 1
        //        }
        //    };
        //    PaymentData paymentData = new PaymentData()
        //    {
        //        orderCode = orderCode,
        //        amount = amount,
        //        description = description,
        //        returnUrl = returnUrl,
        //        cancelUrl = cancelUrl,
        //        items = item
        //    };

        //    string paymentLink = await _payOS.CreatePaymentUrl(paymentData);
        //    System.Diagnostics.Process.Start(paymentLink);
        //}

        //public async Task<string> CreatePaymentLinkAsync(int orderCode, int amount, string description, string returnUrl, string cancelUrl)
        //{
        //    try
        //    {
        //        Console.WriteLine($"=== Creating Payment ===");
        //        Console.WriteLine($"OrderCode: {orderCode}");
        //        Console.WriteLine($"Amount: {amount}");
        //        Console.WriteLine($"Description: {description}");

        //        var request = new CreatePaymentLinkRequest
        //        {
        //            OrderCode = orderCode,
        //            Amount = amount,
        //            Description = description ?? "Thanh toán",
        //            ReturnUrl = returnUrl ?? "https://example.com/success",
        //            CancelUrl = cancelUrl ?? "https://example.com/cancel"
        //        };


        //    }
        //    catch (PayOS.Exceptions.InvalidSignatureException sigEx)
        //    {
        //        Console.WriteLine($"❌ Signature Error: {sigEx.Message}");

        //        throw new Exception(
        //            "❌ LỖI XÁC THỰC CHỮ KÝ PAYOS\n\n" +
        //            "Tài khoản PayOS chưa được kích hoạt đầy đủ.\n\n" +
        //            "Giải pháp:\n" +
        //            "- Liên hệ support@payos.vn\n" +
        //            "- Gửi Client ID: fbfb511c-099a-4a58-b147-9149e5554475\n" +
        //            "- Yêu cầu kích hoạt API credentials\n\n" +
        //            $"Chi tiết: {sigEx.Message}",
        //            sigEx);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"❌ Error: {ex.Message}");
        //        throw new Exception($"Lỗi: {ex.Message}", ex);
        //    }
        //}

        //public async Task<string> GetPaymentStatusAsync(int orderCode)
        //{
        //    try
        //    {
        //        // GetAsync nhận string orderCode
        //        var response = await _client.PaymentRequests.GetAsync(orderCode.ToString());
        //        return response?.Status.ToString().ToUpper() ?? "UNKNOWN";
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi lấy trạng thái: {ex.Message}", ex);
        //    }
        //}

        //public async Task<bool> CancelPaymentAsync(int orderCode, string reason = "Hủy thanh toán")
        //{
        //    try
        //    {
        //        // CancelAsync nhận (string orderCode, string? reason)
        //        var response = await _client.PaymentRequests.CancelAsync(
        //            orderCode.ToString(),
        //            reason);
        //        return response != null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi hủy thanh toán: {ex.Message}", ex);
        //    }
        //}
    }
    /// <summary>
    /// ✅ DTO cho kết quả check payment
    /// </summary>
    public class PaymentCheckResult
    {
        public string Status { get; set; } // PENDING, PROCESSING, PAID, CANCELLED, ERROR
        public Guid InvoiceID { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}