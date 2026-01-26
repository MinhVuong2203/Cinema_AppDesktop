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
using MovieDTO = DTO.Movie;
using ShowTimeDTO = DTO.ShowTime;

namespace UI.Helpers
{
    /// <summary>
    /// Helper class để in vé xem phim riêng lẻ
    /// </summary>
    public class TicketPrintHelper
    {
        private readonly CinemaDBContext _context;
        private Ticket _ticket;
        private ShowTimeDTO _showTime;
        private MovieDTO _movie;
        private Seat _seat;
        private Room _room;
        private Invoice _invoice;

        public TicketPrintHelper(Guid ticketID, CinemaDBContext context = null)
        {
            _context = context ?? new CinemaDBContext();
            LoadTicketData(ticketID);
        }

        private void LoadTicketData(Guid ticketID)
        {
            _ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == ticketID);
            if (_ticket == null) return;

            _showTime = _context.ShowTimes.FirstOrDefault(st => st.ShowTimeID == _ticket.ShowTimeID);
            _seat = _context.Seats.FirstOrDefault(s => s.SeatID == _ticket.SeatID);

            if (_showTime != null)
            {
                _movie = _context.Movies.FirstOrDefault(m => m.MovieID == _showTime.MovieID);
                _room = _context.Rooms.FirstOrDefault(r => r.RoomID == _showTime.RoomID);
            }

            var invoiceTicket = _context.InvoiceTickets
                .FirstOrDefault(it => it.TicketID == ticketID);
            if (invoiceTicket != null)
            {
                _invoice = _context.Invoices
                    .FirstOrDefault(i => i.InvoiceID == invoiceTicket.InvoiceID);
            }
        }

        public void Print()
        {
            if (_ticket == null || _movie == null)
            {
                MessageBox.Show("Không tìm thấy thông tin vé!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += PrintTicketPage;

                PaperSize paperSize = new PaperSize("Ticket", 315, 787);
                printDoc.DefaultPageSettings.PaperSize = paperSize;

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi in vé: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ✅ THÊM: Lưu vé dưới dạng PDF
        /// </summary>
        public string SaveToPDF(string folderPath)
        {
            if (_ticket == null || _movie == null || _seat == null)
            {
                throw new Exception("Không tìm thấy thông tin vé!");
            }

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string invoiceCode = "UNKNOWN";
                if (_invoice != null)
                {
                    invoiceCode = _invoice.InvoiceID.ToString().Substring(0, 8).ToUpper();
                }

                string fileName = $"VE-{invoiceCode}-{_seat.SeatName}.pdf";
                string fullPath = Path.Combine(folderPath, fileName);

                // Tạo document PDF (80mm x 200mm)
                iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(226, 566); // 80x200mm in points
                Document document = new Document(pageSize, 15, 15, 15, 15);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fullPath, FileMode.Create));
                document.Open();

                // Font chữ
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                
                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font normalFont = new iTextSharp.text.Font(baseFont, 8);
                iTextSharp.text.Font smallFont = new iTextSharp.text.Font(baseFont, 7);
                iTextSharp.text.Font largeFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);

                // ========== HEADER ==========
                Paragraph header = new Paragraph("ARENA CINESTAR", titleFont);
                header.Alignment = Element.ALIGN_CENTER;
                document.Add(header);

                Paragraph ticketTitle = new Paragraph("VÉ XEM PHIM", headerFont);
                ticketTitle.Alignment = Element.ALIGN_CENTER;
                ticketTitle.SpacingBefore = 5f;
                document.Add(ticketTitle);

                document.Add(new Paragraph(" ", smallFont));
                document.Add(new iTextSharp.text.pdf.draw.LineSeparator());
                document.Add(new Paragraph(" ", smallFont));

                // ========== THÔNG TIN PHIM ==========
                document.Add(new Paragraph("PHIM:", headerFont));
                
                Paragraph movieTitle = new Paragraph(_movie.Title, largeFont);
                movieTitle.SpacingBefore = 3f;
                document.Add(movieTitle);

                document.Add(new Paragraph($"Thể loại: {_movie.Genre}", normalFont));
                document.Add(new Paragraph($"Thời lượng: {_movie.DurationMinutes} phút", normalFont));
                document.Add(new Paragraph($"Giới hạn độ tuổi: {_movie.AgeLimit}", normalFont));
                
                document.Add(new Paragraph(" ", smallFont));
                document.Add(new iTextSharp.text.pdf.draw.LineSeparator());
                document.Add(new Paragraph(" ", smallFont));

                // ========== THÔNG TIN SUẤT CHIẾU ==========
                document.Add(new Paragraph("NGÀY CHIẾU:", headerFont));
                Paragraph showDate = new Paragraph(_showTime.StartTime.ToString("dddd, dd/MM/yyyy"), largeFont);
                showDate.SpacingBefore = 3f;
                document.Add(showDate);

                document.Add(new Paragraph(" ", smallFont));
                document.Add(new Paragraph("GIỜ CHIẾU:", headerFont));
                Paragraph showHour = new Paragraph(_showTime.StartTime.ToString("HH:mm"), largeFont);
                showHour.SpacingBefore = 3f;
                document.Add(showHour);

                document.Add(new Paragraph(" ", smallFont));
                document.Add(new Paragraph("PHÒNG:", headerFont));
                Paragraph roomInfo = new Paragraph(_room?.RoomName ?? $"Phòng {_showTime.RoomID}", largeFont);
                roomInfo.SpacingBefore = 3f;
                document.Add(roomInfo);

                document.Add(new Paragraph(" ", smallFont));
                document.Add(new iTextSharp.text.pdf.draw.LineSeparator());
                document.Add(new Paragraph(" ", smallFont));

                // ========== THÔNG TIN GHẾ ==========
                document.Add(new Paragraph("GHẾ:", headerFont));
                iTextSharp.text.Font seatFont = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD);
                Paragraph seatName = new Paragraph(_seat.SeatName, seatFont);
                seatName.SpacingBefore = 3f;
                document.Add(seatName);

                document.Add(new Paragraph($"Loại ghế: {_seat.SeatType}", normalFont));

                document.Add(new Paragraph(" ", smallFont));
                document.Add(new iTextSharp.text.pdf.draw.LineSeparator());
                document.Add(new Paragraph(" ", smallFont));

                // ========== THÔNG TIN VÉ ==========
                document.Add(new Paragraph($"Loại vé: {_ticket.TicketType}", normalFont));
                
                Paragraph priceInfo = new Paragraph($"Giá vé: {(_ticket.Price ?? 0):N0} ₫", headerFont);
                priceInfo.SpacingBefore = 3f;
                document.Add(priceInfo);

                document.Add(new Paragraph(" ", smallFont));
                
                string ticketCode = _ticket.TicketID.ToString().Substring(0, 13).ToUpper();
                document.Add(new Paragraph($"Mã vé: {ticketCode}", smallFont));

                document.Add(new Paragraph(" ", smallFont));
                document.Add(new iTextSharp.text.pdf.draw.LineSeparator());
                document.Add(new Paragraph(" ", smallFont));

                // ========== FOOTER ==========
                Paragraph footer1 = new Paragraph("Vui lòng đến trước giờ chiếu 15 phút", smallFont);
                footer1.Alignment = Element.ALIGN_CENTER;
                document.Add(footer1);

                Paragraph footer2 = new Paragraph("Cảm ơn quý khách!", normalFont);
                footer2.Alignment = Element.ALIGN_CENTER;
                footer2.SpacingBefore = 5f;
                document.Add(footer2);

                document.Close();
                writer.Close();

                return fullPath;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lưu vé PDF: {ex.Message}", ex);
            }
        }

        // Giữ nguyên phương thức PNG cũ
        public string SaveToFile(string folderPath)
        {
            if (_ticket == null || _movie == null || _seat == null)
            {
                throw new Exception("Không tìm thấy thông tin vé!");
            }

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string invoiceCode = "UNKNOWN";
                if (_invoice != null)
                {
                    invoiceCode = _invoice.InvoiceID.ToString().Substring(0, 8).ToUpper();
                }

                string fileName = $"{invoiceCode}-{_seat.SeatName}.png";
                string fullPath = Path.Combine(folderPath, fileName);

                Bitmap bitmap = RenderTicketToBitmap();
                bitmap.Save(fullPath, ImageFormat.Png);
                bitmap.Dispose();

                return fullPath;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lưu vé: {ex.Message}");
            }
        }

        private Bitmap RenderTicketToBitmap()
        {
            int width = 315;
            int height = 787;

            Bitmap bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            PrintPageEventArgs args = new PrintPageEventArgs(
                g,
                new System.Drawing.Rectangle(0, 0, width, height),
                new System.Drawing.Rectangle(0, 0, width, height),
                null
            );

            PrintTicketPage(null, args);
            g.Dispose();
            return bitmap;
        }

        private void PrintTicketPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float leftMargin = 20;
            float centerX = e.PageBounds.Width / 2;
            float yPos = 20;

            System.Drawing.Font titleFont = new System.Drawing.Font("Segoe UI", 16, FontStyle.Bold);
            System.Drawing.Font headerFont = new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold);
            System.Drawing.Font normalFont = new System.Drawing.Font("Segoe UI", 9);
            System.Drawing.Font smallFont = new System.Drawing.Font("Segoe UI", 7);
            System.Drawing.Font largeFont = new System.Drawing.Font("Segoe UI", 14, FontStyle.Bold);

            string header = "ARENA CINESTAR";
            SizeF headerSize = g.MeasureString(header, titleFont);
            g.DrawString(header, titleFont, Brushes.Black,
                centerX - headerSize.Width / 2, yPos);
            yPos += 30;

            string ticketTitle = "VÉ XEM PHIM";
            SizeF titleSize = g.MeasureString(ticketTitle, headerFont);
            g.DrawString(ticketTitle, headerFont, Brushes.Black,
                centerX - titleSize.Width / 2, yPos);
            yPos += 25;

            DrawLine(g, leftMargin, yPos, e.PageBounds.Width - leftMargin * 2);
            yPos += 15;

            g.DrawString("PHIM:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;

            DrawWrappedText(g, _movie.Title, largeFont, Brushes.Black,
                leftMargin, ref yPos, e.PageBounds.Width - leftMargin * 2, 22);
            yPos += 5;

            g.DrawString($"Thể loại: {_movie.Genre}", normalFont, Brushes.Black, leftMargin, yPos);
            yPos += 18;

            g.DrawString($"Thời lượng: {_movie.DurationMinutes} phút",
                normalFont, Brushes.Black, leftMargin, yPos);
            yPos += 18;

            g.DrawString($"Giới hạn độ tuổi: {_movie.AgeLimit}",
                normalFont, Brushes.Black, leftMargin, yPos);
            yPos += 25;

            DrawLine(g, leftMargin, yPos, e.PageBounds.Width - leftMargin * 2);
            yPos += 15;

            g.DrawString("NGÀY CHIẾU:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            g.DrawString(_showTime.StartTime.ToString("dddd, dd/MM/yyyy"),
                largeFont, Brushes.Red, leftMargin, yPos);
            yPos += 25;

            g.DrawString("GIỜ CHIẾU:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            g.DrawString(_showTime.StartTime.ToString("HH:mm"),
                largeFont, Brushes.Red, leftMargin, yPos);
            yPos += 25;

            g.DrawString("PHÒNG:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            g.DrawString(_room?.RoomName ?? $"Phòng {_showTime.RoomID}",
                largeFont, Brushes.Red, leftMargin, yPos);
            yPos += 25;

            DrawLine(g, leftMargin, yPos, e.PageBounds.Width - leftMargin * 2);
            yPos += 15;

            g.DrawString("GHẾ:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            g.DrawString(_seat.SeatName, new System.Drawing.Font("Segoe UI", 20, FontStyle.Bold),
                Brushes.Red, leftMargin, yPos);
            yPos += 30;

            g.DrawString($"Loại ghế: {_seat.SeatType}", normalFont,
                Brushes.Black, leftMargin, yPos);
            yPos += 20;

            DrawLine(g, leftMargin, yPos, e.PageBounds.Width - leftMargin * 2);
            yPos += 15;

            g.DrawString($"Loại vé: {_ticket.TicketType}", normalFont,
                Brushes.Black, leftMargin, yPos);
            yPos += 18;

            g.DrawString($"Giá vé: {(_ticket.Price ?? 0).ToString("#,##0")} ₫",
                headerFont, Brushes.Green, leftMargin, yPos);
            yPos += 25;

            string ticketCode = _ticket.TicketID.ToString().Substring(0, 13).ToUpper();
            g.DrawString($"Mã vé: {ticketCode}", smallFont,
                Brushes.Gray, leftMargin, yPos);
            yPos += 15;

            DrawLine(g, leftMargin, yPos, e.PageBounds.Width - leftMargin * 2);
            yPos += 10;

            DrawSimpleBarcode(g, ticketCode, leftMargin + 10, yPos,
                e.PageBounds.Width - leftMargin * 2 - 20, 40);
            yPos += 50;

            DrawLine(g, leftMargin, yPos, e.PageBounds.Width - leftMargin * 2);
            yPos += 10;

            string footer = "Vui lòng đến trước giờ chiếu 15 phút";
            SizeF footerSize = g.MeasureString(footer, smallFont);
            g.DrawString(footer, smallFont, Brushes.Gray,
                centerX - footerSize.Width / 2, yPos);
            yPos += 12;

            string thankYou = "Cảm ơn quý khách!";
            SizeF thankYouSize = g.MeasureString(thankYou, normalFont);
            g.DrawString(thankYou, normalFont, Brushes.Black,
                centerX - thankYouSize.Width / 2, yPos);
        }

        private void DrawLine(Graphics g, float x, float y, float width)
        {
            g.DrawLine(Pens.Black, x, y, x + width, y);
        }

        private void DrawWrappedText(Graphics g, string text, System.Drawing.Font font,
            Brush brush, float x, ref float y, float maxWidth, float lineHeight)
        {
            string[] words = text.Split(' ');
            string line = "";

            foreach (string word in words)
            {
                string testLine = line + word + " ";
                SizeF size = g.MeasureString(testLine, font);

                if (size.Width > maxWidth && line != "")
                {
                    g.DrawString(line, font, brush, x, y);
                    y += lineHeight;
                    line = word + " ";
                }
                else
                {
                    line = testLine;
                }
            }

            if (line != "")
            {
                g.DrawString(line, font, brush, x, y);
                y += lineHeight;
            }
        }

        private void DrawSimpleBarcode(Graphics g, string code, float x, float y,
            float width, float height)
        {
            float barWidth = width / code.Length;

            for (int i = 0; i < code.Length; i++)
            {
                if ((code[i] - '0') % 2 == 0 || char.IsLetter(code[i]))
                {
                    g.FillRectangle(Brushes.Black,
                        x + i * barWidth, y, barWidth * 0.8f, height);
                }
            }

            System.Drawing.Font barcodeFont = new System.Drawing.Font("Courier New", 6);
            SizeF codeSize = g.MeasureString(code, barcodeFont);
            g.DrawString(code, barcodeFont, Brushes.Black,
                x + (width - codeSize.Width) / 2, y + height + 2);
        }
    }
}