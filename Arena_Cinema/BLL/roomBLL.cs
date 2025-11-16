using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class RoomBLL
    {
        private readonly RoomDAL _roomDAL;

        public RoomBLL()
        {
            _roomDAL = new RoomDAL();
        }

        // Lấy danh sách phòng
        public List<Room> GetAllRooms()
        {
            return _roomDAL.GetAllRooms();
        }
        public bool IsRoomNameExists(string roomName, int? excludeRoomId = null)
        {
            if (string.IsNullOrWhiteSpace(roomName)) return false;
            return _roomDAL.IsRoomNameExists(roomName.Trim(), excludeRoomId);
        }
        // Lấy phòng theo ID
        public Room GetRoomById(int roomId)
        {
            if (roomId <= 0) return null;
            return _roomDAL.GetRoomById(roomId);
        }
        public List<string> GetAllRoomType()
        {
            return _roomDAL.GetAllRoomType();
        }

        // Thêm phòng mới
        public string AddRoom(Room room)
        {
            if (string.IsNullOrWhiteSpace(room.RoomName))
                return "Tên phòng không được để trống.";

            if (_roomDAL.IsRoomNameExists(room.RoomName))
                return "Tên phòng đã tồn tại.";

            if (room.SeatCount <= 0)
                return "Số ghế phải lớn hơn 0.";

            if (_roomDAL.AddRoom(room))
                return "Thêm phòng thành công!";
            else
                return "Thêm phòng thất bại. Vui lòng thử lại.";
        }

        // Cập nhật phòng
        public string UpdateRoom(Room room)
        {
            if (room.RoomID <= 0)
                return "ID phòng không hợp lệ.";

            if (string.IsNullOrWhiteSpace(room.RoomName))
                return "Tên phòng không được để trống.";

            if (_roomDAL.IsRoomNameExists(room.RoomName, room.RoomID))
                return "Tên phòng đã tồn tại.";

            if (_roomDAL.EditRoom(room))
                return "Cập nhật phòng thành công!";
            else
                return "Cập nhật thất bại. Phòng không tồn tại hoặc đã bị xóa.";
        }

        // Xóa phòng (soft delete)
        public string DeleteRoom(int roomId)
        {
            if (roomId <= 0)
                return "ID phòng không hợp lệ.";

            if (_roomDAL.DeleteRoom(roomId))
                return "Xóa phòng thành công!";
            else
                return "Xóa thất bại. Phòng không tồn tại hoặc đã bị xóa.";
        }

        //// Kiểm tra phòng có đang được sử dụng trong lịch chiếu không
        //public bool IsRoomInUse(int roomId)
        //{
        //    var room = _roomDAL.GetRoomById(roomId);
        //    return room?.ShowTimes?.Any(st => st.EndTime > DateTime.Now) == true;
        //}
    }
}