using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class SeatBLL
    {
        private readonly SeatDAL _seatDAL;
        public SeatBLL()
        {
            _seatDAL = new SeatDAL();
        }

        public List<Seat> GetSeatsByRoomId(int roomId)
        {
            return _seatDAL.GetSeatsByRoomId(roomId);
        }

        public List<Seat> GetAllSeatsIncludeDeleted(int roomId)
        {
            return _seatDAL.GetAllSeatsIncludeDeleted(roomId);
        }

        public Seat GetSeatById(int seatId)
        {
            return _seatDAL.GetSeatById(seatId);
        }

        public Seat GetSeatByIdIncludeDeleted(int seatId)
        {
            return _seatDAL.GetSeatByIdIncludeDeleted(seatId);
        }

        // Thêm ghế mới
        public string AddSeat(Seat seat)
        {
            if (string.IsNullOrWhiteSpace(seat.SeatName))
                return "Tên ghế không được để trống.";

            if (seat.RoomID <= 0)
                return "Phòng không hợp lệ.";

            return _seatDAL.AddSeat(seat)
                ? "Thêm ghế thành công!"
                : "Thêm ghế thất bại!";
        }

        // Cập nhật ghế
        public string UpdateSeat(Seat seat)
        {
            if (seat.SeatID <= 0) return "ID ghế không hợp lệ.";
            if (string.IsNullOrWhiteSpace(seat.SeatName)) return "Tên ghế không được để trống.";

            return _seatDAL.UpdateSeat(seat)
                ? "Cập nhật ghế thành công!"
                : "Cập nhật thất bại!";
        }

        // Xóa mềm ghế
        public string SoftDeleteSeat(int seatId)
        {
            return _seatDAL.SoftDeleteSeat(seatId)
                ? "Xóa ghế thành công!"
                : "Không tìm thấy ghế để xóa.";
        }

        // Khôi phục ghế
        public string RestoreSeat(int seatId)
        {
            return _seatDAL.RestoreSeat(seatId)
                ? "Khôi phục ghế thành công!"
                : "Không thể khôi phục ghế (có thể chưa bị xóa).";
        }

        // Xóa vĩnh viễn
        public string DeleteSeatPermanently(int seatId)
        {
            return _seatDAL.DeleteSeatPermanently(seatId)
                ? "Xóa vĩnh viễn ghế thành công!"
                : "Xóa thất bại!";
        }

        // Lấy ghế theo loại
        public List<Seat> GetSeatsByType(int roomId, string seatType)
        {
            return _seatDAL.GetSeatsByType(roomId, seatType);
        }

        public void CreateDefaultSeats(int roomId, int totalSeatCount = 250)
        {
            var seats = new List<Seat>();
            int count = 0;

            var rowList = new List<char>();
            for (char r = 'A'; count < totalSeatCount && r <= 'Z'; r++)
                rowList.Add(r);

            char coupleRow = rowList.Last(); // hàng cuối là ghế đôi

            int rowIndex = 1;
            foreach (char row in rowList)
            {
                int seatsPerRow = (row >= 'G') ? 17 : 15;
                if (count + seatsPerRow > totalSeatCount)
                    seatsPerRow = totalSeatCount - count;

                for (int col = 1; col <= seatsPerRow && count < totalSeatCount; col++)
                {
                    string seatType = "Ghế thường";

                    if (row == coupleRow)
                        seatType = "Ghế đôi";
                    else if ((row >= 'G' && row <= 'L' && col >= 4 && col <= 14) ||
                             (row == 'F' && col >= 3 && col <= 13))
                        seatType = "Ghế VIP";

                    seats.Add(new Seat
                    {
                        SeatName = $"{row}{col:D2}",
                        SeatType = seatType,
                        RoomID = roomId,
                        IsDeleted = false,
                        pX = col,
                        pY = rowIndex
                    });

                    count++;
                }
                rowIndex++;
            }

            // Nếu vẫn chưa đủ → thêm hàng tiếp theo
            char nextRow = (char)(rowList.Last() + 1);
            while (count < totalSeatCount && nextRow <= 'Z')
            {
                for (int col = 1; col <= 17 && count < totalSeatCount; col++)
                {
                    seats.Add(new Seat
                    {
                        SeatName = $"{nextRow}{col:D2}",
                        SeatType = "Ghế thường",
                        RoomID = roomId,
                        IsDeleted = false,
                        pX = col,
                        pY = rowIndex
                    });
                    count++;
                }
                nextRow++;
                rowIndex++;
            }

            // Gọi DAL để thêm hàng loạt
            new SeatDAL().AddRangeSeats(seats); // bạn thêm method này dưới đây
        }
    }
}
