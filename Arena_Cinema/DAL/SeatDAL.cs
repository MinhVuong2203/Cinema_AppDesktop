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
        // Không dùng field _context nữa để tránh tracking conflict

        public Seat getAllSeatById(int id)
        {
            using (var context = new CinemaDBContext())
            {
                return context.Seats.Find(id);
            }
        }

        public List<Seat> GetSeatsByRoomId(int roomId)
        {
            using (var context = new CinemaDBContext())
            {
                return context.Seats
                               .Where(s => s.RoomID == roomId && !s.IsDeleted)
                               .Include(s => s.Room)
                               .ToList();
            }
        }

        public List<Seat> GetAllSeatsIncludeDeleted(int roomId)
        {
            using (var context = new CinemaDBContext())
            {
                return context.Seats
                               .Where(s => s.RoomID == roomId)
                               .Include(s => s.Room)
                               .ToList();
            }
        }

        public Seat GetSeatById(int seatId)
        {
            using (var context = new CinemaDBContext())
            {
                return context.Seats
                               .Include(s => s.Room)
                               .FirstOrDefault(s => s.SeatID == seatId && !s.IsDeleted);
            }
        }

        public Seat GetSeatByIdIncludeDeleted(int seatId)
        {
            using (var context = new CinemaDBContext())
            {
                return context.Seats
                               .Include(s => s.Room)
                               .FirstOrDefault(s => s.SeatID == seatId);
            }
        }

        // Kiểm tra tên ghế có tồn tại không
        public bool IsSeatNameExists(int roomId, string seatName, int? excludeSeatId = null)
        {
            using (var context = new CinemaDBContext())
            {
                var query = context.Seats.Where(s => s.RoomID == roomId &&
                                                       s.SeatName == seatName &&
                                                       !s.IsDeleted);

                if (excludeSeatId.HasValue)
                {
                    query = query.Where(s => s.SeatID != excludeSeatId.Value);
                }

                return query.Any();
            }
        }

        // Thêm ghế mới
        public bool AddSeat(Seat seat)
        {
            using (var context = new CinemaDBContext())
            {
                context.Seats.Add(seat);
                return context.SaveChanges() > 0;
            }
        }

        // Cập nhật ghế (sửa tên, loại, vị trí, IsDeleted, v.v.)
        public bool UpdateSeat(Seat seat)
        {
            try
            {
                using (var context = new CinemaDBContext())
                {
                    // Tìm entity trong context mới
                    var existingSeat = context.Seats.Find(seat.SeatID);

                    if (existingSeat != null)
                    {
                        // Cập nhật các thuộc tính
                        existingSeat.SeatName = seat.SeatName;
                        existingSeat.SeatType = seat.SeatType;
                        existingSeat.pX = seat.pX;
                        existingSeat.pY = seat.pY;
                        existingSeat.IsDeleted = seat.IsDeleted;
                        existingSeat.RoomID = seat.RoomID;

                        return context.SaveChanges() > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateSeat: {ex.Message}");
                return false;
            }
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
            using (var context = new CinemaDBContext())
            {
                var seat = context.Seats.Find(seatId);
                if (seat == null) return false;

                context.Seats.Remove(seat);
                return context.SaveChanges() > 0;
            }
        }

        // Lấy danh sách ghế theo loại (VIP, Standard, v.v.)
        public List<Seat> GetSeatsByType(int roomId, string seatType)
        {
            using (var context = new CinemaDBContext())
            {
                return context.Seats
                               .Where(s => s.RoomID == roomId && !s.IsDeleted && s.SeatType == seatType)
                               .ToList();
            }
        }

        public bool AddRangeSeats(List<Seat> seats)
        {
            try
            {
                using (var context = new CinemaDBContext())
                {
                    context.Seats.AddRange(seats);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}