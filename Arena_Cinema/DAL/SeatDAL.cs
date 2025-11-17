using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SeatDAL
    {
        private readonly CinemaDBContext _context;
        public SeatDAL()
        {
            _context = new CinemaDBContext();
        }

        public Seat getAllSeatById(int id)
        {
            return _context.Seats.Find(id); 
        }

        public List<Seat> GetSeatsByRoomId(int roomId)
        {
            return _context.Seats
                           .Where(s => s.RoomID == roomId && !s.IsDeleted)
                           .Include(s => s.Room)
                           .ToList();
        }

        public List<Seat> GetAllSeatsIncludeDeleted(int roomId)
        {
            return _context.Seats
                           .Where(s => s.RoomID == roomId)
                           .Include(s => s.Room)
                           .ToList();
        }

        public Seat GetSeatById(int seatId)
        {
            return _context.Seats
                           .Include(s => s.Room)
                           .FirstOrDefault(s => s.SeatID == seatId && !s.IsDeleted);
        }

        public Seat GetSeatByIdIncludeDeleted(int seatId)
        {
            return _context.Seats
                           .Include(s => s.Room)
                           .FirstOrDefault(s => s.SeatID == seatId);
        }

        // Thêm ghế mới
        public bool AddSeat(Seat seat)
        {
            _context.Seats.Add(seat);
            return _context.SaveChanges() > 0;
        }

        // Cập nhật ghế (sửa tên, loại, vị trí, IsDeleted, v.v.)
        public bool UpdateSeat(Seat seat)
        {
            _context.Entry(seat).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        // Xóa mềm ghế
        public bool SoftDeleteSeat(int seatId)
        {
            var seat = GetSeatByIdIncludeDeleted(seatId);
            if (seat == null) return false;

            seat.IsDeleted = true;
            return UpdateSeat(seat);
        }

        // Khôi phục ghế đã xóa mềm
        public bool RestoreSeat(int seatId)
        {
            var seat = GetSeatByIdIncludeDeleted(seatId);
            if (seat == null || !seat.IsDeleted) return false;

            seat.IsDeleted = false;
            return UpdateSeat(seat);
        }

        // Xóa vĩnh viễn (nếu cần)
        public bool DeleteSeatPermanently(int seatId)
        {
            var seat = GetSeatByIdIncludeDeleted(seatId);
            if (seat == null) return false;

            _context.Seats.Remove(seat);
            return _context.SaveChanges() > 0;
        }

        // Lấy danh sách ghế theo loại (VIP, Standard, v.v.)
        public List<Seat> GetSeatsByType(int roomId, string seatType)
        {
            return _context.Seats
                           .Where(s => s.RoomID == roomId && !s.IsDeleted && s.SeatType == seatType)
                           .ToList();
        }
        public bool AddRangeSeats(List<Seat> seats)
        {
            try
            {
                _context.Seats.AddRange(seats);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
