using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using DTO;

namespace UI.Helpers
{
    public class InvoicePrintHelper
    {
        private readonly CinemaDBContext _context;
        private Guid _invoiceID;
        private Invoice _invoice;
        private Payment _payment;

        public InvoicePrintHelper(Guid invoiceID)
        {
            _context = new CinemaDBContext();
            _invoiceID = invoiceID;
            LoadInvoiceData();
        }

        private void LoadInvoiceData()
        {
            _invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID);
            _payment = _context.Payments
                .Where(p => p.InvoiceID == _invoiceID)
                .OrderByDescending(p => p.PaymentTime)
                .FirstOrDefault();
        }

        public void Print()
        {
            if (_invoice == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += PrintPage;

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                    MessageBox.Show("In hóa đơn thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi in: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float leftMargin = 50;
            float yPos = 50;
            float lineHeight = 25;

            // Fonts
            Font titleFont = new Font("Segoe UI", 20, FontStyle.Bold);
            Font headerFont = new Font("Segoe UI", 12, FontStyle.Bold);
            Font normalFont = new Font("Segoe UI", 10);
            Font smallFont = new Font("Segoe UI", 9);

            // ========== HEADER ==========
            g.DrawString("ARENA CINESTAR", titleFont, Brushes.Black, leftMargin, yPos);
            yPos += 35;

            g.DrawString("Rạp chiếu phim hiện đại", smallFont, Brushes.Gray, leftMargin, yPos);
            yPos += 20;
            g.DrawString("Địa chỉ: 123 Đường ABC, TP.HCM", smallFont, Brushes.Gray, leftMargin, yPos);
            yPos += 20;
            g.DrawString("Hotline: 1900-xxxx", smallFont, Brushes.Gray, leftMargin, yPos);
            yPos += 35;

            // Line separator
            g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 700, yPos);
            yPos += 20;

            // ========== HÓA ĐƠN TITLE ==========
            g.DrawString("HÓA ĐƠN BÁN HÀNG", titleFont, Brushes.Black, leftMargin + 200, yPos);
            yPos += 40;

            // ========== THÔNG TIN HÓA ĐƠN ==========
            g.DrawString($"Mã hóa đơn: {_invoice.InvoiceID.ToString().Substring(0, 8).ToUpper()}",
                normalFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            g.DrawString($"Ngày tạo: {_invoice.IssueDate:dd/MM/yyyy HH:mm:ss}",
                normalFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            var employee = _context.Employees.FirstOrDefault(emp => emp.EmployeeID == _invoice.EmployeeID);
            g.DrawString($"Nhân viên: {employee?.FullName ?? "N/A"}",
                normalFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            var customer = _context.Customers.FirstOrDefault(c => c.CustomerID == _invoice.CustomerID);
            if (customer != null)
            {
                g.DrawString($"Khách hàng: {customer.FullName}", normalFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;
                g.DrawString($"SĐT: {customer.Phone}", normalFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;
            }

            yPos += 10;
            g.DrawLine(Pens.Gray, leftMargin, yPos, leftMargin + 700, yPos);
            yPos += 20;

            // ========== CHI TIẾT VÉ ==========
            var invoiceTickets = _context.InvoiceTickets
                .Where(it => it.InvoiceID == _invoiceID)
                .ToList();

            if (invoiceTickets.Any())
            {
                g.DrawString("CHI TIẾT VÉ XEM PHIM", headerFont, Brushes.Black, leftMargin, yPos);
                yPos += 30;

                // Header table
                g.DrawString("Phim", headerFont, Brushes.Black, leftMargin, yPos);
                g.DrawString("Ghế", headerFont, Brushes.Black, leftMargin + 250, yPos);
                g.DrawString("Loại", headerFont, Brushes.Black, leftMargin + 350, yPos);
                g.DrawString("Giá", headerFont, Brushes.Black, leftMargin + 500, yPos);
                yPos += 25;

                g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 700, yPos);
                yPos += 10;

                decimal ticketTotal = 0;
                foreach (var it in invoiceTickets)
                {
                    var ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == it.TicketID);
                    if (ticket != null)
                    {
                        var seat = _context.Seats.FirstOrDefault(s => s.SeatID == ticket.SeatID);
                        var showTime = _context.ShowTimes.FirstOrDefault(st => st.ShowTimeID == ticket.ShowTimeID);
                        var movie = showTime != null ? _context.Movies.FirstOrDefault(m => m.MovieID == showTime.MovieID) : null;

                        g.DrawString(movie?.Title ?? "N/A", normalFont, Brushes.Black, leftMargin, yPos);
                        g.DrawString(seat?.SeatName ?? "N/A", normalFont, Brushes.Black, leftMargin + 250, yPos);
                        g.DrawString(ticket.TicketType ?? "N/A", normalFont, Brushes.Black, leftMargin + 350, yPos);
                        g.DrawString($"{(ticket.Price ?? 0).ToString("#,##0")} ₫",
                            normalFont, Brushes.Black, leftMargin + 500, yPos);

                        ticketTotal += ticket.Price ?? 0;
                        yPos += lineHeight;
                    }
                }

                yPos += 5;
                g.DrawLine(Pens.Gray, leftMargin, yPos, leftMargin + 700, yPos);
                yPos += 15;
                g.DrawString($"Tạm tính vé: {ticketTotal.ToString("#,##0")} ₫",
                    normalFont, Brushes.Black, leftMargin + 450, yPos);
                yPos += 30;
            }

            // ========== CHI TIẾT SẢN PHẨM ==========
            var invoiceProducts = _context.InvoiceProducts
                .Where(ip => ip.InvoiceID == _invoiceID)
                .ToList();

            if (invoiceProducts.Any())
            {
                g.DrawString("CHI TIẾT SẢN PHẨM", headerFont, Brushes.Black, leftMargin, yPos);
                yPos += 30;

                g.DrawString("Sản phẩm", headerFont, Brushes.Black, leftMargin, yPos);
                g.DrawString("SL", headerFont, Brushes.Black, leftMargin + 300, yPos);
                g.DrawString("Đơn giá", headerFont, Brushes.Black, leftMargin + 380, yPos);
                g.DrawString("Thành tiền", headerFont, Brushes.Black, leftMargin + 500, yPos);
                yPos += 25;

                g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 700, yPos);
                yPos += 10;

                decimal productTotal = 0;
                foreach (var ip in invoiceProducts)
                {
                    var product = _context.Products.FirstOrDefault(p => p.ProductID == ip.ProductID);
                    if (product != null)
                    {
                        decimal unitPrice = ip.UnitPrice ?? 0;
                        int quantity = ip.Quantity ?? 0;
                        decimal total = unitPrice * quantity;

                        g.DrawString(product.ProductName, normalFont, Brushes.Black, leftMargin, yPos);
                        g.DrawString(quantity.ToString(), normalFont, Brushes.Black, leftMargin + 300, yPos);
                        g.DrawString($"{unitPrice.ToString("#,##0")} ₫",
                            normalFont, Brushes.Black, leftMargin + 380, yPos);
                        g.DrawString($"{total.ToString("#,##0")} ₫",
                            normalFont, Brushes.Black, leftMargin + 500, yPos);

                        productTotal += total;
                        yPos += lineHeight;
                    }
                }

                yPos += 5;
                g.DrawLine(Pens.Gray, leftMargin, yPos, leftMargin + 700, yPos);
                yPos += 15;
                g.DrawString($"Tạm tính sản phẩm: {productTotal.ToString("#,##0")} ₫",
                    normalFont, Brushes.Black, leftMargin + 450, yPos);
                yPos += 30;
            }

            // ========== TỔNG KẾT ==========
            g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 700, yPos);
            yPos += 20;

            decimal subtotal = (_invoice.TotalAmount ?? 0) + (_invoice.Discount ?? 0);
            g.DrawString($"Tạm tính:", normalFont, Brushes.Black, leftMargin + 450, yPos);
            g.DrawString($"{subtotal.ToString("#,##0")} ₫", normalFont, Brushes.Black, leftMargin + 580, yPos);
            yPos += lineHeight;

            g.DrawString($"Giảm giá:", normalFont, Brushes.Black, leftMargin + 450, yPos);
            g.DrawString($"{(_invoice.Discount ?? 0).ToString("#,##0")} ₫",
                normalFont, Brushes.Black, leftMargin + 580, yPos);
            yPos += lineHeight;

            g.DrawString("TỔNG CỘNG:", headerFont, Brushes.Black, leftMargin + 450, yPos);
            g.DrawString($"{(_invoice.TotalAmount ?? 0).ToString("#,##0")} ₫",
                headerFont, Brushes.Red, leftMargin + 580, yPos);
            yPos += 35;

            // ========== THÔNG TIN THANH TOÁN ==========
            if (_payment != null)
            {
                g.DrawLine(Pens.Gray, leftMargin, yPos, leftMargin + 700, yPos);
                yPos += 20;

                g.DrawString("THÔNG TIN THANH TOÁN", headerFont, Brushes.Black, leftMargin, yPos);
                yPos += 30;

                g.DrawString($"Phương thức: {_payment.Method}", normalFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;

                g.DrawString($"Thời gian: {_payment.PaymentTime:dd/MM/yyyy HH:mm:ss}",
                    normalFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;


                g.DrawString($"Số tiền: {(_payment.Amount ?? 0).ToString("#,##0")} ₫",
                    normalFont, Brushes.Black, leftMargin, yPos);
                yPos += lineHeight;

                g.DrawString($"Trạng thái: {_invoice.Status}", normalFont, Brushes.Green, leftMargin, yPos);
                yPos += 35;
            }

            // ========== FOOTER ==========
            g.DrawLine(Pens.Gray, leftMargin, yPos, leftMargin + 700, yPos);
            yPos += 20;

            g.DrawString("Cảm ơn quý khách đã sử dụng dịch vụ!",
                headerFont, Brushes.Black, leftMargin + 150, yPos);
            yPos += 25;
            g.DrawString("Hẹn gặp lại!", normalFont, Brushes.Gray, leftMargin + 300, yPos);
        }
    }
}