using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DAL;
using DTO;

namespace UI.Helpers
{
    /// <summary>
    /// Quản lý việc in hóa đơn tổng và các vé riêng lẻ
    /// </summary>
    public class PrintManager
    {
        private readonly CinemaDBContext _context;
        private readonly Guid _invoiceID;

        public PrintManager(Guid invoiceID)
        {
            _context = new CinemaDBContext();
            _invoiceID = invoiceID;
        }

        /// <summary>
        /// In cả hóa đơn tổng và tất cả các vé riêng lẻ
        /// </summary>
        public void PrintAll()
        {
            try
            {
                var result = MessageBox.Show(
                    "Bạn muốn in:\n\n" +
                    "• Hóa đơn tổng\n" +
                    "• Tất cả các vé xem phim\n\n" +
                    "Tiếp tục?",
                    "Xác nhận in",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                // 1. In hóa đơn tổng
                PrintInvoice();

                // 2. In từng vé
                PrintAllTickets();

                MessageBox.Show(
                    "Đã in xong hóa đơn và vé!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi khi in: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// In chỉ hóa đơn tổng
        /// </summary>
        public void PrintInvoice()
        {
            var printHelper = new InvoicePrintHelper(_invoiceID);
            printHelper.Print();
        }

        /// <summary>
        /// In tất cả các vé trong hóa đơn
        /// </summary>
        public void PrintAllTickets()
        {
            var invoiceTickets = _context.InvoiceTickets
                .Where(it => it.InvoiceID == _invoiceID)
                .ToList();

            if (!invoiceTickets.Any())
            {
                MessageBox.Show(
                    "Hóa đơn này không có vé xem phim!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int count = 1;
            foreach (var it in invoiceTickets)
            {
                var result = MessageBox.Show(
                    $"In vé {count}/{invoiceTickets.Count}?",
                    "In vé",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                    break;

                if (result == DialogResult.Yes)
                {
                    var ticketPrinter = new TicketPrintHelper(it.TicketID, _context);
                    ticketPrinter.Print();
                }

                count++;
            }
        }

        /// <summary>
        /// In một vé cụ thể
        /// </summary>
        public void PrintSingleTicket(Guid ticketID)
        {
            var ticketPrinter = new TicketPrintHelper(ticketID, _context);
            ticketPrinter.Print();
        }

        /// <summary>
        /// Lấy danh sách vé trong hóa đơn để hiển thị cho người dùng chọn
        /// </summary>
        public List<TicketInfo> GetTicketsList()
        {
            var result = new List<TicketInfo>();

            var invoiceTickets = _context.InvoiceTickets
                .Where(it => it.InvoiceID == _invoiceID)
                .ToList();

            foreach (var it in invoiceTickets)
            {
                var ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == it.TicketID);
                if (ticket == null) continue;

                var seat = _context.Seats.FirstOrDefault(s => s.SeatID == ticket.SeatID);
                var showTime = _context.ShowTimes.FirstOrDefault(st => st.ShowTimeID == ticket.ShowTimeID);
                var movie = showTime != null ?
                    _context.Movies.FirstOrDefault(m => m.MovieID == showTime.MovieID) : null;

                result.Add(new TicketInfo
                {
                    TicketID = ticket.TicketID,

                    MovieTitle = movie?.Title ?? "N/A",
                    SeatName = seat?.SeatName ?? "N/A",
                    ShowTime = showTime?.StartTime ?? DateTime.MinValue,
                    Price = ticket.Price ?? 0,
                    TicketType = ticket.TicketType
                });
            }

            return result;
        }

        /// <summary>
        /// Class chứa thông tin vé để hiển thị
        /// </summary>
        public class TicketInfo
        {
            public Guid TicketID { get; set; }
            public string MovieTitle { get; set; }
            public string SeatName { get; set; }
            public DateTime ShowTime { get; set; }
            public decimal Price { get; set; }
            public string TicketType { get; set; }

            public override string ToString()
            {
                return $"{MovieTitle} - Ghế {SeatName} - {ShowTime:dd/MM HH:mm}";
            }
        }
    }
}