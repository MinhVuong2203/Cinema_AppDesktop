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

        // Tạo ghế tự động
        public void CreateDefaultSeats(int roomId, int totalSeatCount = 250)
        {
            var seats = new List<Seat>();
            int count = 0;
            int rowIndex = 0;
            char currentRow = 'A';

            // Tạo ghế
            while (count < totalSeatCount && currentRow <= 'Z')
            {
                int seatsPerRow = (currentRow >= 'G') ? 17 : 15;

                if (count + seatsPerRow > totalSeatCount)
                    seatsPerRow = totalSeatCount - count;

                // Xác định cột bắt đầu: A-F bắt đầu từ 1, G trở đi bắt đầu từ 0
                int startCol = (currentRow < 'G') ? 1 : 0;

                for (int i = 0; i < seatsPerRow && count < totalSeatCount; i++)
                {
                    int col = startCol + i;

                    seats.Add(new Seat
                    {
                        SeatName = $"{currentRow}{col:D2}",
                        SeatType = "temp",
                        RoomID = roomId,
                        IsDeleted = false,
                        pX = col,
                        pY = rowIndex
                    });
                    count++;
                }

                currentRow++;
                rowIndex++;
            }

            // Tìm hàng cuối thực tế (hàng có pY lớn nhất)
            if (seats.Any())
            {
                int maxPY = seats.Max(s => s.pY);
                char actualLastRow = (char)('A' + maxPY);
                int startColLast = (actualLastRow < 'G') ? 1 : 0;

                // Lấy tất cả ghế ở hàng cuối
                var lastRowSeats = seats.Where(s => s.pY == maxPY).OrderBy(s => s.pX).ToList();
                int lastRowCount = lastRowSeats.Count;

                // Nếu hàng cuối có > 8 ghế, tách ra
                if (lastRowCount > 8)
                {
                    // Số ghế dư (sẽ thành ghế thường ở hàng trước)
                    int extraSeats = lastRowCount - 8;
                    
                    // Xóa hàng cuối hiện tại
                    seats.RemoveAll(s => s.pY == maxPY);

                    // Thêm ghế dư vào hàng trước (hàng maxPY, ghế thường)
                    for (int i = 0; i < extraSeats; i++)
                    {
                        int col = startColLast + i;
                        seats.Add(new Seat
                        {
                            SeatName = $"{actualLastRow}{col:D2}",
                            SeatType = "temp", // Sẽ được set sau
                            RoomID = roomId,
                            IsDeleted = false,
                            pX = col,
                            pY = maxPY
                        });
                    }

                    // Tạo hàng mới cho 8 ghế đôi (maxPY + 1)
                    int newRowPY = maxPY + 1;
                    char newLastRow = (char)('A' + newRowPY);
                    int startColNew = (newLastRow < 'G') ? 1 : 0;

                    for (int i = 0; i < 8; i++)
                    {
                        int col = startColNew + (i * 2);
                        seats.Add(new Seat
                        {
                            SeatName = $"{newLastRow}{col:D2}",
                            SeatType = "Ghế đôi",
                            RoomID = roomId,
                            IsDeleted = false,
                            pX = col,
                            pY = newRowPY
                        });
                    }

                    // Update maxPY để set loại ghế đúng
                    maxPY = newRowPY;
                }
                else
                {
                    // Nếu <= 8 ghế, chuyển hàng cuối thành ghế đôi bình thường
                    var coupleSeats = new List<Seat>();

                    for (int i = 0; i < lastRowCount; i++)
                    {
                        int newCol = startColLast + (i * 2);

                        coupleSeats.Add(new Seat
                        {
                            SeatName = $"{actualLastRow}{newCol:D2}",
                            SeatType = "Ghế đôi",
                            RoomID = roomId,
                            IsDeleted = false,
                            pX = newCol,
                            pY = maxPY
                        });
                    }

                    // Xóa hàng cuối cũ và thêm ghế đôi mới
                    seats.RemoveAll(s => s.pY == maxPY);
                    seats.AddRange(coupleSeats);
                }

                // Set loại cho các ghế còn lại (không phải hàng cuối)
                foreach (var seat in seats.Where(s => s.pY != maxPY && s.SeatType == "temp"))
                {
                    char row = seat.SeatName[0];
                    int col = seat.pX;

                    if ((row >= 'G' && row <= 'L' && col >= 3 && col <= 13) ||
                        (row == 'F' && col >= 3 && col <= 13))
                        seat.SeatType = "Ghế VIP";
                    else
                        seat.SeatType = "Ghế thường";
                }
            }

            _seatDAL.AddRangeSeats(seats);
        }


        // cập nhật tọa độ ghế
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

                bool isCoupleSeat = movingSeat.SeatType == "Ghế đôi";
                var allSeats = _seatDAL.GetAllSeatsIncludeDeleted(roomId).ToList();

                // Tìm các ghế bị chiếm chỗ ở vị trí MỚI
                List<Seat> occupiedSeats = new List<Seat>();

                if (isCoupleSeat)
                {
                    // Ghế đôi chiếm 2 vị trí: (newPX, newPY) và (newPX+1, newPY)
                    occupiedSeats = allSeats.Where(s =>
                        s.SeatID != seatId &&
                        s.pY == newPY &&
                        (s.pX == newPX || s.pX == newPX + 1)
                    ).ToList();
                }
                else
                {
                    // Ghế thường chỉ kiểm tra 1 vị trí
                    var seat = allSeats.FirstOrDefault(s =>
                        s.pX == newPX && s.pY == newPY && s.SeatID != seatId);
                    if (seat != null) occupiedSeats.Add(seat);
                }

                // Lưu vị trí cũ của ghế đang kéo
                int oldPX = movingSeat.pX;
                int oldPY = movingSeat.pY;

                // SWAP: Đổi chỗ các ghế bị chiếm
                if (occupiedSeats.Any())
                {
                    // Tìm vị trí trống để xếp các ghế bị đẩy
                    List<(int x, int y)> availablePositions = FindAvailablePositions(
                        allSeats,
                        occupiedSeats,
                        oldPX,
                        oldPY,
                        movingSeat.SeatID,
                        roomId
                    );

                    if (availablePositions.Count < occupiedSeats.Count)
                    {
                        errorMessage = "Không đủ chỗ trống để di chuyển ghế bị đẩy!";
                        return false;
                    }

                    // Cập nhật vị trí cho các ghế bị đẩy
                    for (int i = 0; i < occupiedSeats.Count; i++)
                    {
                        var seat = occupiedSeats[i];
                        seat.pX = availablePositions[i].x;
                        seat.pY = availablePositions[i].y;
                        _seatDAL.UpdateSeat(seat);
                    }
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

        // Tìm vị trí trống để xếp các ghế bị đẩy
        private List<(int x, int y)> FindAvailablePositions(
            List<Seat> allSeats,
            List<Seat> seatsToMove,
            int startX,
            int startY,
            int movingSeatId,
            int roomId)
        {
            var positions = new List<(int x, int y)>();

            // Bắt đầu từ vị trí cũ của ghế đang kéo
            int currentX = startX;
            int currentY = startY;

            foreach (var seat in seatsToMove)
            {
                bool isCouple = seat.SeatType == "Ghế đôi";

                // Tìm vị trí trống
                while (true)
                {
                    // Kiểm tra vị trí có trống không
                    bool isOccupied = allSeats.Any(s =>
                        s.SeatID != movingSeatId &&
                        s.SeatID != seat.SeatID &&
                        !seatsToMove.Any(m => m.SeatID == s.SeatID) &&
                        s.pX == currentX &&
                        s.pY == currentY
                    );

                    // Nếu là ghế đôi, kiểm tra cả ô bên cạnh
                    if (isCouple && !isOccupied)
                    {
                        isOccupied = allSeats.Any(s =>
                            s.SeatID != movingSeatId &&
                            s.SeatID != seat.SeatID &&
                            !seatsToMove.Any(m => m.SeatID == s.SeatID) &&
                            s.pX == currentX + 1 &&
                            s.pY == currentY
                        );
                    }

                    // Kiểm tra vị trí đã được gán chưa
                    if (!isOccupied && !positions.Contains((currentX, currentY)))
                    {
                        positions.Add((currentX, currentY));

                        // Nếu là ghế đôi, nhảy 2 ô
                        currentX += isCouple ? 2 : 1;
                        break;
                    }

                    // Chuyển sang ô tiếp theo
                    currentX++;

                    // Giới hạn không vượt quá 17 cột
                    if (currentX >= 17)
                    {
                        return new List<(int x, int y)>(); // Không tìm được chỗ trống
                    }
                }
            }

            return positions;
        }
    }
}