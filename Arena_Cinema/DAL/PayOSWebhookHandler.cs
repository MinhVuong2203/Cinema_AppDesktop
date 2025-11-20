using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Newtonsoft.Json;

namespace DAL
{
    public class PayOSWebhookHandler
    {
        private readonly CinemaDBContext _context;
        private readonly string _checksumKey;

        public PayOSWebhookHandler(string checksumKey)
        {
            _context = new CinemaDBContext();
            _checksumKey = checksumKey;
        }

        /// <summary>
        /// Xử lý webhook từ PayOS
        /// </summary>
        public bool ProcessWebhook(string webhookData, string signature)
        {
            try
            {
                // 1. Verify signature
                if (!VerifySignature(webhookData, signature))
                {
                    Console.WriteLine("❌ Invalid webhook signature");
                    return false;
                }

                // 2. Parse webhook data
                dynamic data = JsonConvert.DeserializeObject(webhookData);
                string code = data.code?.ToString();

                if (code != "00") // Không thành công
                {
                    Console.WriteLine($"❌ Payment failed with code: {code}");
                    return false;
                }

                // 3. Lấy thông tin thanh toán
                long orderCode = long.Parse(data.data.orderCode.ToString());
                string status = data.data.status?.ToString(); // PAID, CANCELLED, PENDING
                decimal amount = decimal.Parse(data.data.amount.ToString());
                string description = data.data.description?.ToString() ?? "";
                //Guid? invoiceID = data.data.invoiceID != null ? Guid.Parse(data.data.invoiceID.ToString()) : (Guid?)null;
                string buyerName = data.data.buyerName?.ToString() ?? "";

                Console.WriteLine($"✅ Webhook received - OrderCode: {orderCode}, Status: {status}");

                // 4. Xử lý theo trạng thái
                if (status == "PAID")
                {
                    return HandleSuccessfulPayment(orderCode, amount, description, buyerName);
                }
                else if (status == "CANCELLED")
                {
                    return HandleCancelledPayment(orderCode);
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Webhook processing error: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Xử lý thanh toán thành công
        /// </summary>
        private bool HandleSuccessfulPayment(long orderCode, decimal amount)
        {
            try
            {
                // Tìm hóa đơn theo orderCode (cần thêm field PaymentOrderCode vào Invoice)
                // Tạm thời dùng cách tìm theo TotalAmount và thời gian gần nhất
                var invoice = _context.Invoices
                    .Where(i => i.Status == "Chờ thanh toán" &&
                               !i.IsDeleted &&
                               i.TotalAmount == amount)
                    .OrderByDescending(i => i.IssueDate)
                    .FirstOrDefault();

                if (invoice == null)
                {
                    Console.WriteLine($"❌ Invoice not found for orderCode: {orderCode}");
                    return false;
                }

                // Cập nhật trạng thái hóa đơn
                invoice.Status = "Đã thanh toán";
                //invoice.PaymentMethod = "PayOS";
                //invoice.PaymentDate = DateTime.Now;


                // Kiểm tra xem có phải hóa đơn bán vé không
                var invoiceTickets = _context.InvoiceTickets
                    .Where(it => it.InvoiceID == invoice.InvoiceID)
                    .ToList();

                if (invoiceTickets.Any())
                {
                    // Cập nhật trạng thái vé
                    var ticketIds = invoiceTickets.Select(it => it.TicketID).ToList();
                    var tickets = _context.Tickets.Where(t => ticketIds.Contains(t.TicketID)).ToList();

                    foreach (var ticket in tickets)
                    {
                        ticket.Status = "Đã bán";
                    }

                    Console.WriteLine($"✅ Updated {tickets.Count} tickets to 'Đã bán'");
                }

                _context.SaveChanges();
                Console.WriteLine($"✅ Invoice {invoice.InvoiceID} marked as paid");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error handling successful payment: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Xử lý thanh toán thành công - Tìm theo InvoiceID
        /// </summary>
        private bool HandleSuccessfulPayment(long orderCode, decimal amount, string description, string buyerName)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // ✅ PARSE InvoiceID từ buyerName
                    Guid invoiceID;
                    if (!Guid.TryParse(buyerName, out invoiceID))
                    {
                        Console.WriteLine($"❌ Invalid InvoiceID in buyerName: {buyerName}");
                        return false;
                    }

                    Console.WriteLine($"✅ Parsed InvoiceID: {invoiceID}");

                    // ✅ TÌM Invoice theo InvoiceID
                    var invoice = _context.Invoices
                        .FirstOrDefault(i => i.InvoiceID == invoiceID && !i.IsDeleted);

                    if (invoice == null)
                    {
                        Console.WriteLine($"❌ Invoice not found: {invoiceID}");
                        return false;
                    }

                    Console.WriteLine($"✅ Found invoice: {invoice.InvoiceID}");

                    // Kiểm tra đã thanh toán
                    if (invoice.Status == "Đã thanh toán")
                    {
                        Console.WriteLine($"⚠️ Invoice already paid");
                        return true;
                    }

                    // Kiểm tra duplicate payment
                    var existingPayment = _context.Payments
                        .FirstOrDefault(p => p.InvoiceID == invoice.InvoiceID);

                    if (existingPayment != null)
                    {
                        Console.WriteLine($"⚠️ Payment already exists");
                        return true;
                    }

                    // 1. Update invoice
                    invoice.Status = "Đã thanh toán";

                    // 2. ✅ CREATE PAYMENT
                    var payment = new Payment
                    {
                        PaymentID = Guid.NewGuid(),
                        InvoiceID = invoice.InvoiceID,
                        Method = "PayOS",
                        Amount = amount,
                        PaymentTime = DateTime.Now
                    };
                    _context.Payments.Add(payment);

                    Console.WriteLine($"✅ Created payment: {payment.PaymentID}");

                    // 3. Update tickets
                    var invoiceTickets = _context.InvoiceTickets
                        .Where(it => it.InvoiceID == invoice.InvoiceID)
                        .ToList();

                    if (invoiceTickets.Any())
                    {
                        var ticketIds = invoiceTickets.Select(it => it.TicketID).ToList();
                        var tickets = _context.Tickets
                            .Where(t => ticketIds.Contains(t.TicketID))
                            .ToList();

                        foreach (var ticket in tickets)
                        {
                            ticket.Status = "Đã bán";
                        }

                        Console.WriteLine($"✅ Updated {tickets.Count} tickets to 'Đã bán'");
                    }

                    // 4. Save
                    _context.SaveChanges();
                    transaction.Commit();

                    Console.WriteLine($"✅ Payment completed successfully");
                    Console.WriteLine($"   Invoice: {invoice.InvoiceID}");
                    Console.WriteLine($"   Payment: {payment.PaymentID}");
                    Console.WriteLine($"   Amount: {amount}");

                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine($"❌ Error handling payment: {ex.Message}");
                    Console.WriteLine($"Stack trace: {ex.StackTrace}");
                    return false;
                }
            }
        }

        /// <summary>
        /// ✅ Hàm extract InvoiceID từ description
        /// Format: "HD XXXXXXXX|INV:guid"
        /// </summary>
        private Guid? ExtractInvoiceIDFromDescription(string description)
        {
            try
            {
                if (string.IsNullOrEmpty(description))
                    return null;

                // Tìm pattern "INV:guid"
                int invIndex = description.IndexOf("|INV:");
                if (invIndex == -1)
                    return null;

                string guidString = description.Substring(invIndex + 5); // Skip "|INV:"

                if (Guid.TryParse(guidString, out Guid invoiceID))
                {
                    Console.WriteLine($"✅ Extracted InvoiceID: {invoiceID}");
                    return invoiceID;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error extracting InvoiceID: {ex.Message}");
                return null;
            }
        }

        //private bool HandleSuccessfulPayment(long orderCode, decimal amount)
        //{
        //    try
        //    {
        //        // Tìm hóa đơn theo orderCode
        //        var invoice = _context.Invoices
        //            .Where(i => i.Status == "Chờ thanh toán"
        //                        && !i.IsDeleted
        //                        && i.InvoiceID == orderCode)
        //            .OrderByDescending(i => i.IssueDate)
        //            .FirstOrDefault();

        //        if (invoice == null)
        //        {
        //            Console.WriteLine($"❌ Invoice not found for orderCode: {orderCode}");
        //            return false;
        //        }

        //        // Cập nhật trạng thái hóa đơn
        //        invoice.Status = "Đã thanh toán";

        //        // Nếu là hóa đơn bán vé, cập nhật trạng thái vé
        //        var invoiceTickets = _context.InvoiceTickets
        //            .Where(it => it.InvoiceID == invoice.InvoiceID)
        //            .ToList();

        //        if (invoiceTickets.Any())
        //        {
        //            var ticketIds = invoiceTickets.Select(it => it.TicketID).ToList();
        //            var tickets = _context.Tickets.Where(t => ticketIds.Contains(t.TicketID)).ToList();

        //            foreach (var ticket in tickets)
        //            {
        //                ticket.Status = "Đã bán";
        //            }

        //            Console.WriteLine($"✅ Updated {tickets.Count} tickets to 'Đã bán'");
        //        }

        //        _context.SaveChanges();
        //        Console.WriteLine($"✅ Invoice {invoice.InvoiceID} marked as paid");

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"❌ Error handling successful payment: {ex.Message}");
        //        return false;
        //    }
        //}

        /// <summary>
        /// Xử lý hủy thanh toán
        /// </summary>
        private bool HandleCancelledPayment(long orderCode)
        {
            try
            {
                // Tìm hóa đơn
                var invoice = _context.Invoices
                    .Where(i => i.Status == "Chờ thanh toán" && !i.IsDeleted)
                    .OrderByDescending(i => i.IssueDate)
                    .FirstOrDefault();

                if (invoice == null)
                {
                    return false;
                }

                // Cập nhật trạng thái
                invoice.Status = "Đã hủy";
                _context.SaveChanges();

                Console.WriteLine($"✅ Invoice {invoice.InvoiceID} cancelled");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error handling cancelled payment: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Xử lý hủy thanh toán
        /// </summary>
        private bool HandleCancelledPayment(long orderCode, string buyerName)
        {
            try
            {
                // Parse InvoiceID
                Guid invoiceID;
                if (!Guid.TryParse(buyerName, out invoiceID))
                {
                    Console.WriteLine($"❌ Invalid InvoiceID in buyerName: {buyerName}");
                    return false;
                }

                var invoice = _context.Invoices
                    .FirstOrDefault(i => i.InvoiceID == invoiceID && !i.IsDeleted);

                if (invoice == null)
                {
                    Console.WriteLine($"❌ Invoice not found: {invoiceID}");
                    return false;
                }

                invoice.Status = "Đã hủy";
                _context.SaveChanges();

                Console.WriteLine($"✅ Invoice {invoice.InvoiceID} cancelled");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error handling cancellation: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Verify chữ ký webhook
        /// </summary>
        private bool VerifySignature(string data, string signature)
        {
            try
            {
                var keyBytes = Encoding.UTF8.GetBytes(_checksumKey);
                var dataBytes = Encoding.UTF8.GetBytes(data);

                using (var hmac = new HMACSHA256(keyBytes))
                {
                    var hash = hmac.ComputeHash(dataBytes);
                    var computedSignature = BitConverter.ToString(hash).Replace("-", "").ToLower();
                    return computedSignature == signature.ToLower();
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
