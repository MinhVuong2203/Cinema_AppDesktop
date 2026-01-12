// File: DAL/RoomDAL.cs
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class RoomDAL
    {
        private readonly CinemaDBContext _context;

        public RoomDAL()
        {
            _context = new CinemaDBContext();
        }

        // Lấy tất cả phòng (không bao gồm đã xóa)
        public List<Room> GetAllRooms()
        {
            // Đảm bảo lấy dữ liệu mới nhất từ database
            return _context.Rooms
                           .AsNoTracking()
                           .Where(r => !r.IsDeleted)
                           .Include(r => r.Seats)
                           .Include(r => r.ShowTimes)
                           .ToList();
        }

        // Lấy phòng theo ID
        public Room GetRoomById(int roomId)
        {
            return _context.Rooms
                           .Include(r => r.Seats)
                           .Include(r => r.ShowTimes)
                           .FirstOrDefault(r => r.RoomID == roomId && !r.IsDeleted);
        }

        // Thêm phòng mới
        public bool AddRoom(Room room)
        {
            try
            {
                room.IsDeleted = false;

                // Set statement mặc định khi thêm phòng mới
                if (string.IsNullOrWhiteSpace(room.statement))
                {
                    room.statement = "Bình thường";
                }

                _context.Rooms.Add(room);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Cập nhật phòng
        public bool EditRoom(Room room)
        {
            try
            {
                var existingRoom = _context.Rooms.Find(room.RoomID);
                if (existingRoom == null || existingRoom.IsDeleted) return false;

                _context.Entry(existingRoom).CurrentValues.SetValues(room);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa mềm (soft delete)
        public bool DeleteRoom(int roomId)
        {
            try
            {
                var room = _context.Rooms.Find(roomId);
                if (room == null || room.IsDeleted) return false;

                room.IsDeleted = true;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Kiểm tra tên phòng đã tồn tại chưa (tránh trùng)
        public bool IsRoomNameExists(string roomName, int? excludeRoomId = null)
        {
            return _context.Rooms
                           .Any(r => r.RoomName == roomName
                                  && !r.IsDeleted
                                  && (excludeRoomId == null || r.RoomID != excludeRoomId));
        }

        public List<string> GetAllRoomType()
        {
            return _context.Rooms
                           .Where(r => !r.IsDeleted && !string.IsNullOrEmpty(r.RoomType))
                           .Select(r => r.RoomType)
                           .Distinct()
                           .OrderBy(t => t)
                           .ToList();
        }

        public List<Room> GetDeletedRooms()
        {
            return _context.Rooms
                           .Where(r => r.IsDeleted)
                           .Include(r => r.Seats)
                           .Include(r => r.ShowTimes)
                           .ToList();
        }

        public Room GetRoomByIdIncludeDeleted(int roomId)
        {
            return _context.Rooms
                           .Where(r => r.RoomID == roomId)
                           .Include(r => r.Seats)
                           .Include(r => r.ShowTimes)
                           .FirstOrDefault();
        }

        // ===== THÊM METHOD MỚI: Cập nhật trạng thái phòng =====
        public bool UpdateRoomStatement(int roomId, string statement)
        {
            try
            {
                // Tạo context mới để tránh cache
                using (var freshContext = new CinemaDBContext())
                {
                    var room = freshContext.Rooms.Find(roomId);
                    if (room == null || room.IsDeleted) return false;

                    room.statement = statement;
                    freshContext.SaveChanges();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}