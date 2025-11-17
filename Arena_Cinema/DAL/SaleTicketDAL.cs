using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SaleTicketDAL
    {
        private readonly CinemaDBContext _context;
        public SaleTicketDAL()
        {
            _context = new CinemaDBContext();
        }

        //load showtime theo movieID được chiếu trong ngày hôm nay
        public List<ShowTime> GetShowTimesByMovieID(int movieID)
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);

            var showTimes = _context.ShowTimes
                .Where(st => st.MovieID == movieID
                             && st.StartTime >= today
                             && st.StartTime < tomorrow
                             && !st.IsDeleted)
                .ToList();
            return showTimes;
        }

        public List<DTO.Ticket> GetAllTickets()
        {
            var tickets = _context.Tickets
                .Where(t => !t.IsDeleted)
                .ToList();
            return tickets;
        }

        //lấy danh sách vé theo showtimeID
        public List<Ticket> GetTicketsByShowTimeID(Guid showTimeID)
        {
            var tickets = _context.Tickets
                .Where(t => t.ShowTimeID == showTimeID && !t.IsDeleted)
                .ToList();
            return tickets;
        }

        //lấy danh sách loại, số lượng vé theo showtimeID
        public Dictionary<string, int> GetTicketTypesByShowTimeID(Guid showTimeID)
        {
            var ticketTypes = _context.Tickets
                .Where(t => t.ShowTimeID == showTimeID && !t.IsDeleted)
                .GroupBy(t => t.TicketType)
                .ToDictionary(g => g.Key, g => g.Count());
            return ticketTypes;
        }

        //lấy danh sách các sản phẩm
        public List<Product> GetAllProducts()
        {
            var products = _context.Products
                .Where(p => !p.IsDeleted)
                .ToList();
            return products;
        }

        //cập nhật trạng thái vé
        public void UpdateTicketStatus(List<Guid> ticketIDs, string status)
        {
            var tickets = _context.Tickets.Where(t => ticketIDs.Contains(t.TicketID)).ToList();
            foreach (var ticket in tickets)
            {
                ticket.Status = status;
            }
            _context.SaveChanges();
        }

        //add payment nếu thanh toán thành công
        public void AddPayment(Payment payment, List<Guid> ticketIDs)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        //load danh sách ghế của phòng chiếu
        public List<Seat> GetSeatsByRoomID(int roomID)
        {
            return _context.Seats
                .Where(s => s.RoomID == roomID && !s.IsDeleted)
                .ToList();
        }
    }
}
