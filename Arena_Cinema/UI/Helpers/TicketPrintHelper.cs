using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using DTO;
using ShowTimeDTO = DTO.ShowTime;
using MovieDTO = DTO.Movie;

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

            // Lấy invoice liên quan
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

                // Thiết lập kích thước giấy cho vé (80mm x 200mm)
                PaperSize paperSize = new PaperSize("Ticket", 315, 787); // 1/100 inch
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

        private void PrintTicketPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float leftMargin = 20;
            float centerX = e.PageBounds.Width / 2;
            float yPos = 20;

            // Fonts
            Font titleFont = new Font("Segoe UI", 16, FontStyle.Bold);
            Font headerFont = new Font("Segoe UI", 11, FontStyle.Bold);
            Font normalFont = new Font("Segoe UI", 9);
            Font smallFont = new Font("Segoe UI", 7);
            Font largeFont = new Font("Segoe UI", 14, FontStyle.Bold);

            // ========== HEADER ==========
            string header = "ARENA CINESTAR";
            SizeF headerSize = g.MeasureString(header, titleFont);
            g.DrawString(header, titleFont, Brushes.Black,
                centerX - headerSize.Width / 2, yPos);
            yPos += 30;

            // ========== VÉ XEM PHIM ==========
            string ticketTitle = "VÉ XEM PHIM";
            SizeF titleSize = g.MeasureString(ticketTitle, headerFont);
            g.DrawString(ticketTitle, headerFont, Brushes.Black,
                centerX - titleSize.Width / 2, yPos);
            yPos += 25;

            DrawLine(g, leftMargin, yPos, e.PageBounds.Width - leftMargin * 2);
            yPos += 15;

            // ========== THÔNG TIN PHIM ==========
            g.DrawString("PHIM:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;

            // Tên phim (có thể xuống dòng nếu dài)
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

            // ========== THÔNG TIN SUẤT CHIẾU ==========
            DrawLine(g, leftMargin, yPos, e.PageBounds.Width - leftMargin * 2);
            yPos += 15;

            // Ngày chiếu
            g.DrawString("NGÀY CHIẾU:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            g.DrawString(_showTime.StartTime.ToString("dddd, dd/MM/yyyy"),
                largeFont, Brushes.Red, leftMargin, yPos);
            yPos += 25;

            // Giờ chiếu
            g.DrawString("GIỜ CHIẾU:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            g.DrawString(_showTime.StartTime.ToString("HH:mm"),
                largeFont, Brushes.Red, leftMargin, yPos);
            yPos += 25;

            // Phòng chiếu
            g.DrawString("PHÒNG:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            g.DrawString(_room?.RoomName ?? $"Phòng {_showTime.RoomID}",
                largeFont, Brushes.Red, leftMargin, yPos);
            yPos += 25;

            // ========== THÔNG TIN GHẾ ==========
            DrawLine(g, leftMargin, yPos, e.PageBounds.Width - leftMargin * 2);
            yPos += 15;

            g.DrawString("GHẾ:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            g.DrawString(_seat.SeatName, new Font("Segoe UI", 20, FontStyle.Bold),
                Brushes.Red, leftMargin, yPos);
            yPos += 30;

            g.DrawString($"Loại ghế: {_seat.SeatType}", normalFont,
                Brushes.Black, leftMargin, yPos);
            yPos += 20;

            // ========== THÔNG TIN VÉ ==========
            DrawLine(g, leftMargin, yPos, e.PageBounds.Width - leftMargin * 2);
            yPos += 15;

            g.DrawString($"Loại vé: {_ticket.TicketType}", normalFont,
                Brushes.Black, leftMargin, yPos);
            yPos += 18;

            g.DrawString($"Giá vé: {(_ticket.Price ?? 0).ToString("#,##0")} ₫",
                headerFont, Brushes.Green, leftMargin, yPos);
            yPos += 25;

            // Mã vé
            string ticketCode = _ticket.TicketID.ToString().Substring(0, 13).ToUpper();
            g.DrawString($"Mã vé: {ticketCode}", smallFont,
                Brushes.Gray, leftMargin, yPos);
            yPos += 15;

            // ========== BARCODE PLACEHOLDER ==========
            DrawLine(g, leftMargin, yPos, e.PageBounds.Width - leftMargin * 2);
            yPos += 10;

            // Vẽ barcode giả lập (có thể thay bằng thư viện barcode thực)
            DrawSimpleBarcode(g, ticketCode, leftMargin + 10, yPos,
                e.PageBounds.Width - leftMargin * 2 - 20, 40);
            yPos += 50;

            // ========== FOOTER ==========
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

        private void DrawWrappedText(Graphics g, string text, Font font,
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
            // Vẽ barcode đơn giản (các thanh đen trắng xen kẽ)
            float barWidth = width / code.Length;

            for (int i = 0; i < code.Length; i++)
            {
                // Tạo pattern dựa trên mã ASCII
                if ((code[i] - '0') % 2 == 0 || char.IsLetter(code[i]))
                {
                    g.FillRectangle(Brushes.Black,
                        x + i * barWidth, y, barWidth * 0.8f, height);
                }
            }

            // Vẽ text mã dưới barcode
            Font barcodeFont = new Font("Courier New", 6);
            SizeF codeSize = g.MeasureString(code, barcodeFont);
            g.DrawString(code, barcodeFont, Brushes.Black,
                x + (width - codeSize.Width) / 2, y + height + 2);
        }
    }
}