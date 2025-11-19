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
        public async Task<string> CreatePaymentLink(Guid invoiceID, long orderCode, int amount,
            string description, string returnUrl, string cancelUrl)
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


            // Tạo URL thanh toán
            string paymentLink = await _payOS.CreatePaymentUrl(paymentData);
            return paymentLink;
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

                    // Kiểm tra xem đã thanh toán chưa
                    if (invoice.Status == "Đã thanh toán")
                    {
                        Console.WriteLine($"⚠️ Invoice already paid: {invoiceID}");
                        return true; // Đã xử lý rồi
                    }

                    // 1. Cập nhật trạng thái hóa đơn
                    invoice.Status = "Đã thanh toán";

                    // 2. Tạo record Payment
                    var payment = new Payment
                    {
                        PaymentID = Guid.NewGuid(),
                        InvoiceID = invoiceID,
                        Method = method,
                        Amount = invoice.TotalAmount ?? 0,
                        PaymentTime = DateTime.Now,
                    };
                    _context.Payments.Add(payment);

                    // 3. Nếu là hóa đơn bán vé, cập nhật trạng thái vé
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

                        Console.WriteLine($"✅ Updated {tickets.Count} tickets to 'Đã bán'");
                    }

                    // 4. Lưu tất cả thay đổi
                    _context.SaveChanges();
                    transaction.Commit();

                    Console.WriteLine($"✅ Payment processed successfully for Invoice: {invoiceID}");
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
}