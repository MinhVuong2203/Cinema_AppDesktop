using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DAL;
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

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

        public string SaveToPDF(string folderPath)
        {
            if (_invoice == null)
            {
                throw new Exception("Không tìm thấy hóa đơn!");
            }

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string invoiceCode = _invoice.InvoiceID.ToString().Substring(0, 8).ToUpper();
                string dateStr = _invoice.IssueDate.ToString("yyyyMMdd-HHmmss");
                string fileName = $"HD-{invoiceCode}-{dateStr}.pdf";
                string fullPath = Path.Combine(folderPath, fileName);

                Document document = new Document(PageSize.A4, 50, 50, 50, 50);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fullPath, FileMode.Create));
                document.Open();

                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(baseFont, 20, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font normalFont = new iTextSharp.text.Font(baseFont, 10);
                iTextSharp.text.Font smallFont = new iTextSharp.text.Font(baseFont, 9);

                // ========== HEADER ==========
                Paragraph header = new Paragraph("ARENA CINESTAR", titleFont);
                header.Alignment = Element.ALIGN_CENTER;
                document.Add(header);

                Paragraph subHeader = new Paragraph("Rạp chiếu phim hiện đại", smallFont);
                subHeader.Alignment = Element.ALIGN_CENTER;
                document.Add(subHeader);

                document.Add(new Paragraph("Địa chỉ: 123 Đường ABC, TP.HCM", smallFont));
                document.Add(new Paragraph("Hotline: 1900-xxxx", smallFont));
                document.Add(new Paragraph(" "));

                document.Add(new LineSeparator());
                document.Add(new Paragraph(" "));

                // ========== HÓA ĐƠN TITLE ==========
                Paragraph invoiceTitle = new Paragraph("HÓA ĐƠN BÁN HÀNG", titleFont);
                invoiceTitle.Alignment = Element.ALIGN_CENTER;
                document.Add(invoiceTitle);
                document.Add(new Paragraph(" "));

                // ========== THÔNG TIN HÓA ĐƠN ==========
                document.Add(new Paragraph($"Mã hóa đơn: {invoiceCode}", normalFont));
                document.Add(new Paragraph($"Ngày tạo: {_invoice.IssueDate:dd/MM/yyyy HH:mm:ss}", normalFont));

                var employee = _context.Employees.FirstOrDefault(emp => emp.EmployeeID == _invoice.EmployeeID);
                document.Add(new Paragraph($"Nhân viên: {employee?.FullName ?? "N/A"}", normalFont));

                var customer = _context.Customers.FirstOrDefault(c => c.CustomerID == _invoice.CustomerID);
                if (customer != null)
                {
                    document.Add(new Paragraph($"Khách hàng: {customer.FullName}", normalFont));
                    document.Add(new Paragraph($"SĐT: {customer.Phone}", normalFont));
                }

                document.Add(new Paragraph(" "));
                document.Add(new LineSeparator());
                document.Add(new Paragraph(" "));

                // ========== CHI TIẾT VÉ ==========
                var invoiceTickets = _context.InvoiceTickets
                    .Where(it => it.InvoiceID == _invoiceID)
                    .ToList();

                decimal ticketTotal = 0;

                if (invoiceTickets.Any())
                {
                    document.Add(new Paragraph("CHI TIẾT VÉ XEM PHIM", headerFont));
                    document.Add(new Paragraph(" "));

                    PdfPTable ticketTable = new PdfPTable(4);
                    ticketTable.WidthPercentage = 100;
                    ticketTable.SetWidths(new float[] { 3f, 1.5f, 1.5f, 2f });

                    AddTableCell(ticketTable, "Phim", headerFont, Element.ALIGN_LEFT);
                    AddTableCell(ticketTable, "Ghế", headerFont, Element.ALIGN_CENTER);
                    AddTableCell(ticketTable, "Loại", headerFont, Element.ALIGN_CENTER);
                    AddTableCell(ticketTable, "Giá", headerFont, Element.ALIGN_RIGHT);

                    foreach (var it in invoiceTickets)
                    {
                        var ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == it.TicketID);
                        if (ticket != null)
                        {
                            var seat = _context.Seats.FirstOrDefault(s => s.SeatID == ticket.SeatID);
                            var showTime = _context.ShowTimes.FirstOrDefault(st => st.ShowTimeID == ticket.ShowTimeID);
                            var movie = showTime != null ? _context.Movies.FirstOrDefault(m => m.MovieID == showTime.MovieID) : null;

                            AddTableCell(ticketTable, movie?.Title ?? "N/A", normalFont, Element.ALIGN_LEFT);
                            AddTableCell(ticketTable, seat?.SeatName ?? "N/A", normalFont, Element.ALIGN_CENTER);
                            AddTableCell(ticketTable, ticket.TicketType ?? "N/A", normalFont, Element.ALIGN_CENTER);
                            AddTableCell(ticketTable, $"{(ticket.Price ?? 0):N0} ₫", normalFont, Element.ALIGN_RIGHT);

                            ticketTotal += ticket.Price ?? 0;
                        }
                    }

                    document.Add(ticketTable);
                    document.Add(new Paragraph(" "));

                    Paragraph ticketSum = new Paragraph($"Tạm tính vé: {ticketTotal:N0} ₫", normalFont);
                    ticketSum.Alignment = Element.ALIGN_RIGHT;
                    document.Add(ticketSum);
                    document.Add(new Paragraph(" "));
                }

                // ========== CHI TIẾT SẢN PHẨM ==========
                var invoiceProducts = _context.InvoiceProducts
                    .Where(ip => ip.InvoiceID == _invoiceID)
                    .ToList();

                decimal productTotal = 0;

                if (invoiceProducts.Any())
                {
                    document.Add(new Paragraph("CHI TIẾT SẢN PHẨM", headerFont));
                    document.Add(new Paragraph(" "));

                    PdfPTable productTable = new PdfPTable(4);
                    productTable.WidthPercentage = 100;
                    productTable.SetWidths(new float[] { 3f, 1f, 2f, 2f });

                    AddTableCell(productTable, "Sản phẩm", headerFont, Element.ALIGN_LEFT);
                    AddTableCell(productTable, "SL", headerFont, Element.ALIGN_CENTER);
                    AddTableCell(productTable, "Đơn giá", headerFont, Element.ALIGN_RIGHT);
                    AddTableCell(productTable, "Thành tiền", headerFont, Element.ALIGN_RIGHT);

                    foreach (var ip in invoiceProducts)
                    {
                        var product = _context.Products.FirstOrDefault(p => p.ProductID == ip.ProductID);
                        if (product != null)
                        {
                            decimal unitPrice = ip.UnitPrice ?? 0;
                            int quantity = ip.Quantity ?? 0;
                            decimal total = unitPrice * quantity;

                            AddTableCell(productTable, product.ProductName, normalFont, Element.ALIGN_LEFT);
                            AddTableCell(productTable, quantity.ToString(), normalFont, Element.ALIGN_CENTER);
                            AddTableCell(productTable, $"{unitPrice:N0} ₫", normalFont, Element.ALIGN_RIGHT);
                            AddTableCell(productTable, $"{total:N0} ₫", normalFont, Element.ALIGN_RIGHT);

                            productTotal += total;
                        }
                    }

                    document.Add(productTable);
                    document.Add(new Paragraph(" "));

                    Paragraph productSum = new Paragraph($"Tạm tính sản phẩm: {productTotal:N0} ₫", normalFont);
                    productSum.Alignment = Element.ALIGN_RIGHT;
                    document.Add(productSum);
                    document.Add(new Paragraph(" "));
                }

                // ========== TỔNG KẾT ==========
                document.Add(new LineSeparator());
                document.Add(new Paragraph(" "));

                //Tính toán
                decimal subtotal = ticketTotal + productTotal;
                decimal discount = _invoice.Discount ?? 0;
                decimal grandTotal = _invoice.TotalAmount ?? 0;

                // Hiển thị tạm tính
                //Paragraph subtotalParagraph = new Paragraph($"Tạm tính: {subtotal:N0} ₫", normalFont);
                //subtotalParagraph.Alignment = Element.ALIGN_RIGHT;
                //document.Add(subtotalParagraph);
                //document.Add(new Paragraph(" ", smallFont));

                //Hiển thị giảm giá (nếu có)
                if (discount > 0)
                {
                    iTextSharp.text.Font discountFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);
                    Paragraph discountParagraph = new Paragraph($"Giảm giá: -{discount:N0} ₫", discountFont);
                    discountParagraph.Alignment = Element.ALIGN_RIGHT;
                    document.Add(discountParagraph);
                    document.Add(new Paragraph(" ", smallFont));
                }

                // Hiển thị TỔNG CỘNG
                iTextSharp.text.Font totalFont = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD);
                Paragraph grandTotalParagraph = new Paragraph($"TỔNG CỘNG: {grandTotal:N0} ₫", totalFont);
                grandTotalParagraph.Alignment = Element.ALIGN_RIGHT;
                document.Add(grandTotalParagraph);
                document.Add(new Paragraph(" "));

                // ========== FOOTER ==========
                document.Add(new LineSeparator());
                document.Add(new Paragraph(" "));

                Paragraph thanks = new Paragraph("Cảm ơn quý khách đã sử dụng dịch vụ!", headerFont);
                thanks.Alignment = Element.ALIGN_CENTER;
                document.Add(thanks);

                Paragraph seeYou = new Paragraph("Hẹn gặp lại!", normalFont);
                seeYou.Alignment = Element.ALIGN_CENTER;
                document.Add(seeYou);

                document.Close();
                writer.Close();

                return fullPath;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lưu PDF: {ex.Message}", ex);
            }
        }

        private void AddTableCell(PdfPTable table, string text, iTextSharp.text.Font font, int alignment)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.HorizontalAlignment = alignment;
            cell.Padding = 5;
            cell.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
            table.AddCell(cell);
        }

        public string SaveToFile(string folderPath)
        {
            if (_invoice == null)
            {
                throw new Exception("Không tìm thấy hóa đơn!");
            }

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string invoiceCode = _invoice.InvoiceID.ToString().Substring(0, 8).ToUpper();
                string dateStr = _invoice.IssueDate.ToString("yyyyMMdd-HHmmss");
                string fileName = $"{invoiceCode}-{dateStr}.png";
                string fullPath = Path.Combine(folderPath, fileName);

                Bitmap bitmap = RenderInvoiceToBitmap();
                bitmap.Save(fullPath, ImageFormat.Png);
                bitmap.Dispose();

                return fullPath;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lưu hóa đơn: {ex.Message}");
            }
        }

        private Bitmap RenderInvoiceToBitmap()
        {
            int width = 800;
            int height = 1100;

            Bitmap bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            PrintPageEventArgs args = new PrintPageEventArgs(
                g,
                new System.Drawing.Rectangle(0, 0, width, height),
                new System.Drawing.Rectangle(0, 0, width, height),
                null
            );

            PrintPage(null, args);
            g.Dispose();
            return bitmap;
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float leftMargin = 50;
            float yPos = 50;
            float lineHeight = 25;

            System.Drawing.Font titleFont = new System.Drawing.Font("Segoe UI", 20, FontStyle.Bold);
            System.Drawing.Font headerFont = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            System.Drawing.Font normalFont = new System.Drawing.Font("Segoe UI", 10);
            System.Drawing.Font smallFont = new System.Drawing.Font("Segoe UI", 9);

            // ========== HEADER ==========
            g.DrawString("ARENA CINESTAR", titleFont, Brushes.Black, leftMargin, yPos);
            yPos += 35;

            g.DrawString("Rạp chiếu phim hiện đại", smallFont, Brushes.Gray, leftMargin, yPos);
            yPos += 20;
            g.DrawString("Địa chỉ: 123 Đường ABC, TP.HCM", smallFont, Brushes.Gray, leftMargin, yPos);
            yPos += 20;
            g.DrawString("Hotline: 1900-xxxx", smallFont, Brushes.Gray, leftMargin, yPos);
            yPos += 35;

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

            decimal ticketTotal = 0; // ✅ Khai báo NGOÀI if

            if (invoiceTickets.Any())
            {
                g.DrawString("CHI TIẾT VÉ XEM PHIM", headerFont, Brushes.Black, leftMargin, yPos);
                yPos += 30;

                g.DrawString("Phim", headerFont, Brushes.Black, leftMargin, yPos);
                g.DrawString("Ghế", headerFont, Brushes.Black, leftMargin + 250, yPos);
                g.DrawString("Loại", headerFont, Brushes.Black, leftMargin + 350, yPos);
                g.DrawString("Giá", headerFont, Brushes.Black, leftMargin + 500, yPos);
                yPos += 25;

                g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 700, yPos);
                yPos += 10;

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

            decimal productTotal = 0; // ✅ Khai báo NGOÀI if

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

            // ✅ Tính toán
            decimal subtotal = ticketTotal + productTotal;
            decimal discount = _invoice.Discount ?? 0;
            decimal grandTotal = _invoice.TotalAmount ?? 0;

            // Tạm tính
            g.DrawString("Tạm tính:", normalFont, Brushes.Black, leftMargin + 450, yPos);
            g.DrawString($"{subtotal:N0} ₫", normalFont, Brushes.Black, leftMargin + 580, yPos);
            yPos += 25;

            // ✅ Giảm giá (nếu có)
            if (discount > 0)
            {
                g.DrawString("Giảm giá:", normalFont, Brushes.Black, leftMargin + 450, yPos);
                g.DrawString($"{discount:N0} ₫", normalFont, Brushes.Red, leftMargin + 580, yPos);
                yPos += 30;
            }

            // TỔNG CỘNG
            g.DrawString("TỔNG CỘNG:", headerFont, Brushes.Black, leftMargin + 450, yPos);
            g.DrawString($"{grandTotal:N0} ₫", headerFont, Brushes.Red, leftMargin + 580, yPos);
            yPos += 35;

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