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

            // Đảm bảo có statement mặc định
            if (string.IsNullOrWhiteSpace(room.statement))
            {
                room.statement = "Bình thường";
            }

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

        public string RestoreRoom(int roomId)
        {
            if (roomId <= 0) return "ID không hợp lệ.";

            var room = _roomDAL.GetRoomByIdIncludeDeleted(roomId);
            if (room == null)
                return "Phòng không tồn tại.";

            if (!room.IsDeleted)
                return "Phòng chưa bị xóa.";

            room.IsDeleted = false;
            return _roomDAL.EditRoom(room)
                ? "Khôi phục phòng thành công!"
                : "Khôi phục thất bại!";
        }

        public List<Room> GetDeletedRooms()
        {
            return _roomDAL.GetDeletedRooms();
        }

        public Room GetRoomByIdIncludeDeleted(int roomId)
        {
            return _roomDAL.GetRoomByIdIncludeDeleted(roomId);
        }

        // ===== THÊM METHOD MỚI: Chuyển phòng sang trạng thái bảo trì =====
        public string SetRoomMaintenance(int roomId)
        {
            if (roomId <= 0)
                return "ID phòng không hợp lệ.";

            var room = _roomDAL.GetRoomById(roomId);
            if (room == null)
                return "Phòng không tồn tại hoặc đã bị xóa.";

            // Kiểm tra trạng thái hiện tại
            if (room.statement == "Bảo trì")
                return "Phòng đã ở trạng thái bảo trì.";

            // Cập nhật trạng thái sang "Bảo trì"
            if (_roomDAL.UpdateRoomStatement(roomId, "Bảo trì"))
                return "Đã chuyển phòng sang trạng thái bảo trì!";
            else
                return "Cập nhật trạng thái thất bại.";
        }

        // ===== THÊM METHOD MỚI: Chuyển phòng về trạng thái bình thường =====
        public string SetRoomNormal(int roomId)
        {
            if (roomId <= 0)
                return "ID phòng không hợp lệ.";

            var room = _roomDAL.GetRoomById(roomId);
            if (room == null)
                return "Phòng không tồn tại hoặc đã bị xóa.";

            // Cập nhật trạng thái về "Bình thường"
            if (_roomDAL.UpdateRoomStatement(roomId, "Bình thường"))
                return "Đã chuyển phòng về trạng thái bình thường!";
            else
                return "Cập nhật trạng thái thất bại.";
        }
    }
}