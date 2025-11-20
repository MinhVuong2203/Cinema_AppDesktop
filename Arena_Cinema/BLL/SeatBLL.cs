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

        // Thêm ghế mới với validation
        public string AddSeat(Seat seat)
        {
            if (string.IsNullOrWhiteSpace(seat.SeatName))
                return "Tên ghế không được để trống.";

            if (seat.RoomID <= 0)
                return "Phòng không hợp lệ.";

            // Kiểm tra tên ghế trùng
            if (_seatDAL.IsSeatNameExists(seat.RoomID, seat.SeatName))
                return $"Tên ghế '{seat.SeatName}' đã tồn tại trong phòng!";

            // Kiểm tra loại ghế hợp lệ
            if (seat.SeatType != "Ghế thường" && seat.SeatType != "Ghế VIP" && seat.SeatType != "Ghế đôi")
                return "Loại ghế không hợp lệ.";

            return _seatDAL.AddSeat(seat) ? "Thêm ghế thành công!" : "Thêm thất bại!";
        }

        // Cập nhật ghế với validation
        public string UpdateSeat(Seat seat)
        {
            if (seat.SeatID <= 0)
                return "ID ghế không hợp lệ.";

            if (string.IsNullOrWhiteSpace(seat.SeatName))
                return "Tên ghế không được để trống.";

            // Kiểm tra tên ghế trùng (trừ chính nó)
            if (_seatDAL.IsSeatNameExists(seat.RoomID, seat.SeatName, seat.SeatID))
                return $"Tên ghế '{seat.SeatName}' đã tồn tại trong phòng!";

            // Kiểm tra loại ghế hợp lệ
            if (seat.SeatType != "Ghế thường" && seat.SeatType != "Ghế VIP" && seat.SeatType != "Ghế đôi")
                return "Loại ghế không hợp lệ.";

            try
            {
                return _seatDAL.UpdateSeat(seat) ? "Cập nhật thành công!" : "Cập nhật thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        // Xóa mềm ghế
        public string SoftDeleteSeat(int seatId)
        {
            var seat = _seatDAL.GetSeatByIdIncludeDeleted(seatId);
            if (seat == null)
                return "Không tìm thấy ghế.";

            // Không cho phép xóa ghế đôi
            if (seat.SeatType == "Ghế đôi")
                return "Không thể xóa ghế đôi!";

            return _seatDAL.SoftDeleteSeat(seatId) ? "Xóa ghế thành công!" : "Xóa thất bại!";
        }

        public string RestoreSeat(int seatId)
        {
            return _seatDAL.RestoreSeat(seatId) ? "Khôi phục thành công!" : "Không thể khôi phục.";
        }

        public string DeleteSeatPermanently(int seatId)
        {
            return _seatDAL.DeleteSeatPermanently(seatId) ? "Xóa vĩnh viễn thành công!" : "Xóa thất bại!";
        }

        // Kiểm tra có thể chỉnh sửa ghế không
        public bool CanEditSeat(int seatId)
        {
            var seat = _seatDAL.GetSeatById(seatId);
            if (seat == null) return false;

            // Chỉ cho phép chỉnh sửa ghế thường và VIP
            return seat.SeatType == "Ghế thường" || seat.SeatType == "Ghế VIP";
        }

        // Kiểm tra có thể xóa ghế không
        public bool CanDeleteSeat(int seatId)
        {
            var seat = _seatDAL.GetSeatById(seatId);
            if (seat == null) return false;

            // Chỉ cho phép xóa ghế thường và VIP
            return seat.SeatType == "Ghế thường" || seat.SeatType == "Ghế VIP";
        }

        // Tạo ghế tự động
        public void CreateDefaultSeats(int roomId, int totalSeatCount = 250)
        {
            var seats = new List<Seat>();
            int count = 0;
            int rowIndex = 0;
            char currentRow = 'A';

            while (count < totalSeatCount && currentRow <= 'Z')
            {
                int seatsPerRow = (currentRow >= 'G') ? 17 : 15;

                if (count + seatsPerRow > totalSeatCount)
                    seatsPerRow = totalSeatCount - count;

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

            if (seats.Any())
            {
                int maxPY = seats.Max(s => s.pY);
                char actualLastRow = (char)('A' + maxPY);
                int startColLast = (actualLastRow < 'G') ? 1 : 0;

                var lastRowSeats = seats.Where(s => s.pY == maxPY).OrderBy(s => s.pX).ToList();
                int lastRowCount = lastRowSeats.Count;

                if (lastRowCount > 8)
                {
                    int extraSeats = lastRowCount - 8;

                    seats.RemoveAll(s => s.pY == maxPY);

                    for (int i = 0; i < extraSeats; i++)
                    {
                        int col = startColLast + i;
                        seats.Add(new Seat
                        {
                            SeatName = $"{actualLastRow}{col:D2}",
                            SeatType = "temp",
                            RoomID = roomId,
                            IsDeleted = false,
                            pX = col,
                            pY = maxPY
                        });
                    }

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

                    maxPY = newRowPY;
                }
                else
                {
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

                    seats.RemoveAll(s => s.pY == maxPY);
                    seats.AddRange(coupleSeats);
                }

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

        // Cập nhật tọa độ ghế
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

                List<Seat> occupiedSeats = new List<Seat>();

                if (isCoupleSeat)
                {
                    occupiedSeats = allSeats.Where(s =>
                        s.SeatID != seatId &&
                        s.pY == newPY &&
                        (s.pX == newPX || s.pX == newPX + 1)
                    ).ToList();
                }
                else
                {
                    var seat = allSeats.FirstOrDefault(s =>
                        s.pX == newPX && s.pY == newPY && s.SeatID != seatId);
                    if (seat != null) occupiedSeats.Add(seat);
                }

                int oldPX = movingSeat.pX;
                int oldPY = movingSeat.pY;

                if (occupiedSeats.Any())
                {
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

                    for (int i = 0; i < occupiedSeats.Count; i++)
                    {
                        var seat = occupiedSeats[i];
                        seat.pX = availablePositions[i].x;
                        seat.pY = availablePositions[i].y;
                        _seatDAL.UpdateSeat(seat);
                    }
                }

                movingSeat.pX = newPX;
                movingSeat.pY = newPY;
                bool success = _seatDAL.UpdateSeat(movingSeat);

                return success;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private List<(int x, int y)> FindAvailablePositions(
            List<Seat> allSeats,
            List<Seat> seatsToMove,
            int startX,
            int startY,
            int movingSeatId,
            int roomId)
        {
            var positions = new List<(int x, int y)>();

            int currentX = startX;
            int currentY = startY;

            foreach (var seat in seatsToMove)
            {
                bool isCouple = seat.SeatType == "Ghế đôi";

                while (true)
                {
                    bool isOccupied = allSeats.Any(s =>
                        s.SeatID != movingSeatId &&
                        s.SeatID != seat.SeatID &&
                        !seatsToMove.Any(m => m.SeatID == s.SeatID) &&
                        s.pX == currentX &&
                        s.pY == currentY
                    );

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

                    if (!isOccupied && !positions.Contains((currentX, currentY)))
                    {
                        positions.Add((currentX, currentY));
                        currentX += isCouple ? 2 : 1;
                        break;
                    }

                    currentX++;

                    if (currentX >= 17)
                    {
                        return new List<(int x, int y)>();
                    }
                }
            }

            return positions;
        }
    }
}