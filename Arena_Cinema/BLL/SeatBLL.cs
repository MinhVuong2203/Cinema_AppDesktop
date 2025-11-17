using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class SeatBLL
    {
        private readonly SeatDAL _seatDAL = new SeatDAL();

        public List<Seat> GetSeatsByRoomId(int roomId) => _seatDAL.GetSeatsByRoomId(roomId);

        public List<Seat> GetAllSeatsIncludeDeleted(int roomId) => _seatDAL.GetAllSeatsIncludeDeleted(roomId);

        public Seat GetSeatById(int seatId) => _seatDAL.GetSeatById(seatId);

        public Seat GetSeatByIdIncludeDeleted(int seatId) => _seatDAL.GetSeatByIdIncludeDeleted(seatId);

        public string AddSeat(Seat seat)
        {
            if (string.IsNullOrWhiteSpace(seat.SeatName)) return "Tên ghế không được để trống.";
            if (seat.RoomID <= 0) return "Phòng không hợp lệ.";

            return _seatDAL.AddSeat(seat) ? "Thêm ghế thành công!" : "Thêm thất bại!";
        }

        public string UpdateSeat(Seat seat)
        {
            if (seat.SeatID <= 0) return "ID ghế không hợp lệ.";
            if (string.IsNullOrWhiteSpace(seat.SeatName)) return "Tên ghế không được để trống.";

            return _seatDAL.UpdateSeat(seat) ? "Cập nhật thành công!" : "Cập nhật thất bại!";
        }

        public string SoftDeleteSeat(int seatId)
        {
            return _seatDAL.SoftDeleteSeat(seatId) ? "Xóa thành công!" : "Không tìm thấy ghế.";
        }

        public string RestoreSeat(int seatId)
        {
            return _seatDAL.RestoreSeat(seatId) ? "Khôi phục thành công!" : "Không thể khôi phục.";
        }

        public string DeleteSeatPermanently(int seatId)
        {
            return _seatDAL.DeleteSeatPermanently(seatId) ? "Xóa vĩnh viễn thành công!" : "Xóa thất bại!";
        }

        // TỰ ĐỘNG TẠO GHẾ KHI THÊM PHÒNG MỚI
        public void CreateDefaultSeats(int roomId, int totalSeatCount = 250)
        {
            var seats = new List<Seat>();
            int count = 0;
            int rowIndex = 1;

            // Bước 1: Tạo ghế trước, lưu row cuối thực tế
            char currentRow = 'A';
            char actualLastRow = 'A'; // Biến lưu hàng cuối thực tế

            while (count < totalSeatCount && currentRow <= 'Z')
            {
                int seatsPerRow = (currentRow >= 'G') ? 17 : 15;
                if (count + seatsPerRow > totalSeatCount)
                    seatsPerRow = totalSeatCount - count;

                for (int col = 1; col <= seatsPerRow && count < totalSeatCount; col++)
                {
                    seats.Add(new Seat
                    {
                        SeatName = $"{currentRow}{col:D2}",
                        SeatType = "temp", // Tạm thời
                        RoomID = roomId,
                        IsDeleted = false,
                        pX = col,
                        pY = rowIndex
                    });
                    count++;
                }

                actualLastRow = currentRow; // Cập nhật hàng cuối
                currentRow++;
                rowIndex++;
            }

            // Bước 2: Gán lại SeatType dựa trên hàng cuối thực tế
            foreach (var seat in seats)
            {
                char row = seat.SeatName[0];
                int col = seat.pX;

                if (row == actualLastRow)
                    seat.SeatType = "Ghế đôi";
                else if ((row >= 'G' && row <= 'L' && col >= 4 && col <= 14) ||
                         (row == 'F' && col >= 3 && col <= 13))
                    seat.SeatType = "Ghế VIP";
                else
                    seat.SeatType = "Ghế thường";
            }

            _seatDAL.AddRangeSeats(seats);
        }

        // CẬP NHẬT VỊ TRÍ GHẾ KHI KÉO THẢ
        public bool UpdateSeatPosition(int seatId, int newPX, int newPY, int roomId, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                var movingSeat = _seatDAL.GetSeatByIdIncludeDeleted(seatId);
                if (movingSeat == null)
                {
                    errorMessage = "Không tìm thấy ghế!";
                    return false;
                }

                // Kiểm tra xem vị trí mới có bị ghế khác chiếm không
                var occupiedSeat = _seatDAL.GetAllSeatsIncludeDeleted(roomId)
                    .FirstOrDefault(s => s.pX == newPX && s.pY == newPY && s.SeatID != seatId);

                if (occupiedSeat != null)
                {
                    // Đẩy ghế đang chiếm chỗ về vị trí cũ của ghế đang kéo (HOÁN ĐỔI VỊ TRÍ)
                    occupiedSeat.pX = movingSeat.pX;
                    occupiedSeat.pY = movingSeat.pY;
                    _seatDAL.UpdateSeat(occupiedSeat);
                }

                // Di chuyển ghế đang kéo đến vị trí mới
                movingSeat.pX = newPX;
                movingSeat.pY = newPY;

                return _seatDAL.UpdateSeat(movingSeat);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}