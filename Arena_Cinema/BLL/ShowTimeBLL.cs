using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using DAL;

namespace BLL
{
    public class ShowTimeBLL : IDisposable
    {
        private readonly ShowTimeDAL _showTimeDAL;
        private readonly MovieBLL _movieBLL;
        private readonly RoomBLL _roomBLL;

        public ShowTimeBLL()
        {
            _showTimeDAL = new ShowTimeDAL();
            _movieBLL = new MovieBLL();
            _roomBLL = new RoomBLL();
        }

        // ========== THÊM SUẤT CHIẾU ==========
        public (bool success, string message) AddShowTime(ShowTime showTime)
        {
            try
            {
                // Validate dữ liệu
                var validation = ValidateShowTime(showTime);
                if (!validation.isValid)
                    return (false, validation.message);

                // Kiểm tra phim có tồn tại không
                var movie = _movieBLL.GetMovieById(showTime.MovieID);
                if (movie == null)
                    return (false, "Phim không tồn tại!");

                // Kiểm tra phòng có tồn tại không
                var room = _roomBLL.GetRoomById(showTime.RoomID);
                if (room == null)
                    return (false, "Phòng chiếu không tồn tại!");

                // Kiểm tra trùng lịch (truyền thời lượng phim vào)
                if (_showTimeDAL.CheckScheduleConflict(showTime.RoomID, showTime.StartTime, movie.DurationMinutes))
                {
                    return (false, $"Phòng {room.RoomName} đã có lịch chiếu trong khung giờ này!\n" +
                                   $"Vui lòng chọn thời gian khác.");
                }

                // Thêm suất chiếu
                bool result = _showTimeDAL.AddShowTime(showTime);
                if (result)
                    return (true, "✓ Thêm suất chiếu thành công!");
                else
                    return (false, "✗ Không thể thêm suất chiếu!");
            }
            catch (Exception ex)
            {
                return (false, "✗ Lỗi: " + ex.Message);
            }
        }

        // ========== CẬP NHẬT SUẤT CHIẾU ==========
        public (bool success, string message) UpdateShowTime(ShowTime showTime)
        {
            try
            {
                // Validate dữ liệu
                var validation = ValidateShowTime(showTime);
                if (!validation.isValid)
                    return (false, validation.message);

                // Kiểm tra suất chiếu có tồn tại không
                var existingShowTime = _showTimeDAL.GetShowTimeById(showTime.ShowTimeID);
                if (existingShowTime == null)
                    return (false, "✗ Suất chiếu không tồn tại!");

                // Kiểm tra đã có vé bán ra chưa
                int ticketsSold = _showTimeDAL.CountTicketsSold(showTime.ShowTimeID);
                if (ticketsSold > 0)
                {
                    return (false, $"✗ Không thể cập nhật!\nĐã có {ticketsSold} vé được bán cho suất chiếu này.");
                }

                // Kiểm tra phim có tồn tại không
                var movie = _movieBLL.GetMovieById(showTime.MovieID);
                if (movie == null)
                    return (false, "✗ Phim không tồn tại!");

                // Kiểm tra phòng có tồn tại không
                var room = _roomBLL.GetRoomById(showTime.RoomID);
                if (room == null)
                    return (false, "✗ Phòng chiếu không tồn tại!");

                // Kiểm tra trùng lịch (trừ suất chiếu hiện tại)
                if (_showTimeDAL.CheckScheduleConflict(showTime.RoomID, showTime.StartTime, movie.DurationMinutes, showTime.ShowTimeID))
                {
                    return (false, $"✗ Phòng {room.RoomName} đã có lịch chiếu trong khung giờ này!\n" +
                                   $"Vui lòng chọn thời gian khác.");
                }

                // Cập nhật
                bool result = _showTimeDAL.UpdateShowTime(showTime);
                if (result)
                    return (true, "✓ Cập nhật suất chiếu thành công!");
                else
                    return (false, "✗ Không thể cập nhật suất chiếu!");
            }
            catch (Exception ex)
            {
                return (false, "✗ Lỗi: " + ex.Message);
            }
        }

        // ========== XÓA SUẤT CHIẾU ==========
        public (bool success, string message) DeleteShowTime(Guid showTimeId)
        {
            try
            {
                // Kiểm tra suất chiếu có tồn tại không
                var showTime = _showTimeDAL.GetShowTimeById(showTimeId);
                if (showTime == null)
                    return (false, "✗ Suất chiếu không tồn tại!");

                // Kiểm tra có thể xóa không
                if (!_showTimeDAL.CanDeleteShowTime(showTimeId))
                {
                    int ticketsSold = _showTimeDAL.CountTicketsSold(showTimeId);
                    return (false, $"✗ Không thể xóa!\nĐã có {ticketsSold} vé được bán cho suất chiếu này.");
                }

                // Xóa
                bool result = _showTimeDAL.DeleteShowTime(showTimeId);
                if (result)
                    return (true, "✓ Xóa suất chiếu thành công!");
                else
                    return (false, "✗ Không thể xóa suất chiếu!");
            }
            catch (Exception ex)
            {
                return (false, "✗ Lỗi: " + ex.Message);
            }
        }

        // ========== LẤY TẤT CẢ SUẤT CHIẾU ==========
        public List<ShowTime> GetAllShowTimes()
        {
            try
            {
                return _showTimeDAL.GetAllShowTimes();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách suất chiếu: " + ex.Message);
            }
        }

        // ========== LẤY SUẤT CHIẾU THEO ID ==========
        public ShowTime GetShowTimeById(Guid showTimeId)
        {
            try
            {
                return _showTimeDAL.GetShowTimeById(showTimeId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin suất chiếu: " + ex.Message);
            }
        }

        // ========== LẤY SUẤT CHIẾU THEO PHIM ==========
        public List<ShowTime> GetShowTimesByMovie(int movieId)
        {
            try
            {
                return _showTimeDAL.GetShowTimesByMovie(movieId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // ========== LẤY SUẤT CHIẾU THEO PHÒNG ==========
        public List<ShowTime> GetShowTimesByRoom(int roomId)
        {
            try
            {
                return _showTimeDAL.GetShowTimesByRoom(roomId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // ========== LẤY SUẤT CHIẾU CÓ LỌC VÀ PHÂN TRANG ==========
        public (List<ShowTime> items, int totalCount, int totalPages) GetShowTimesFiltered(
            int? movieId = null,
            int? roomId = null,
            DateTime? startDate = null,
            DateTime? endDate = null,
            int pageNumber = 1,
            int pageSize = 10)
        {
            try
            {
                var result = _showTimeDAL.GetShowTimesFiltered(movieId, roomId, startDate, endDate, pageNumber, pageSize);
                int totalPages = (int)Math.Ceiling((double)result.totalCount / pageSize);
                return (result.items, result.totalCount, totalPages);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // ========== TÍNH THỜI GIAN KẾT THÚC ==========
        public DateTime CalculateEndTime(ShowTime showTime)
        {
            try
            {
                if (showTime == null || showTime.Movie == null)
                    return showTime?.StartTime ?? DateTime.Now;

                return showTime.StartTime.AddMinutes(showTime.Movie.DurationMinutes);
            }
            catch
            {
                return showTime?.StartTime ?? DateTime.Now;
            }
        }

        // ========== TÍNH THỜI GIAN KẾT THÚC (THEO MOVIE ID) ==========
        public DateTime CalculateEndTime(int movieId, DateTime startTime)
        {
            try
            {
                var movie = _movieBLL.GetMovieById(movieId);
                if (movie == null)
                    return startTime.AddHours(2); // Mặc định 2 tiếng nếu không tìm thấy phim

                return startTime.AddMinutes(movie.DurationMinutes);
            }
            catch
            {
                return startTime.AddHours(2);
            }
        }

        // ========== LẤY TRẠNG THÁI SUẤT CHIẾU ==========
        public string GetShowTimeStatus(ShowTime showTime)
        {
            if (showTime == null)
                return "Không xác định";

            try
            {
                DateTime now = DateTime.Now;
                DateTime endTime = CalculateEndTime(showTime);

                if (now < showTime.StartTime)
                    return "Sắp chiếu";
                else if (now >= showTime.StartTime && now <= endTime)
                    return "Đang chiếu";
                else
                    return "Đã chiếu";
            }
            catch
            {
                return "Không xác định";
            }
        }

        // ========== LẤY THÔNG TIN THỜI GIAN CHI TIẾT ==========
        public (DateTime startTime, DateTime endTime, int durationMinutes, string displayDuration) GetShowTimeDetails(ShowTime showTime)
        {
            if (showTime == null || showTime.Movie == null)
                return (DateTime.Now, DateTime.Now, 0, "0 phút");

            int duration = showTime.Movie.DurationMinutes;
            DateTime endTime = showTime.StartTime.AddMinutes(duration);

            int hours = duration / 60;
            int minutes = duration % 60;
            string displayDuration = hours > 0
                ? $"{hours}h {minutes}phút"
                : $"{minutes} phút";

            return (showTime.StartTime, endTime, duration, displayDuration);
        }

        // ========== LẤY SUẤT CHIẾU SẮP DIỄN RA ==========
        public List<ShowTime> GetUpcomingShowTimes(int limit = 10)
        {
            try
            {
                return _showTimeDAL.GetUpcomingShowTimes(limit);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // ========== LẤY SUẤT CHIẾU HÔM NAY ==========
        public List<ShowTime> GetTodayShowTimes()
        {
            try
            {
                return _showTimeDAL.GetTodayShowTimes();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // ========== VALIDATE DỮ LIỆU ==========
        private (bool isValid, string message) ValidateShowTime(ShowTime showTime)
        {
            if (showTime == null)
                return (false, "✗ Dữ liệu suất chiếu không hợp lệ!");

            if (showTime.MovieID <= 0)
                return (false, "✗ Vui lòng chọn phim!");

            if (showTime.RoomID <= 0)
                return (false, "✗ Vui lòng chọn phòng chiếu!");

            if (showTime.Price < 0)
                return (false, "✗ Giá vé không hợp lệ!");

            if (showTime.Price > 1000000)
                return (false, "✗ Giá vé quá cao! (Tối đa 1,000,000 VNĐ)");

            // Cho phép thêm suất chiếu trong quá khứ nhưng cảnh báo nếu quá xa
            if (showTime.StartTime < DateTime.Now.AddDays(-1))
                return (false, "✗ Thời gian bắt đầu quá xa trong quá khứ!");

            return (true, string.Empty);
        }

        // ========== ĐẾM SỐ VÉ ĐÃ BÁN ==========
        public int CountTicketsSold(Guid showTimeId)
        {
            try
            {
                return _showTimeDAL.CountTicketsSold(showTimeId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // ========== KIỂM TRA CÓ THỂ XÓA/SỬA HAY KHÔNG ==========
        public bool CanModifyShowTime(Guid showTimeId)
        {
            try
            {
                return _showTimeDAL.CanDeleteShowTime(showTimeId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Dispose()
        {
            _showTimeDAL?.Dispose();
        }
    }
}