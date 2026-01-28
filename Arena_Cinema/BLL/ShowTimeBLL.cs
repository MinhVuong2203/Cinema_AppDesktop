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

                string status = GetShowTimeStatus(existingShowTime);
                if (status == "Đang chiếu" || status == "Đã chiếu")
                {
                    return (false, $"✗ Không thể cập nhật!\nSuất chiếu này {status.ToLower()}.");
                }

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

                // Kiểm tra trạng thái suất chiếu
                string status = GetShowTimeStatus(showTime);

                // Nếu là "Đang chiếu" hoặc "Đã chiếu" -> không được xóa
                if (status == "Đang chiếu" || status == "Đã chiếu")
                {
                    return (false, $"✗ Không thể xóa suất chiếu!\n" +
                                  $"Suất chiếu này đang ở trạng thái '{status}'.\n" +
                                  $"Chỉ có thể xóa suất chiếu 'Sắp chiếu' mà chưa bán vé.");
                }

                // Kiểm tra số vé đã bán
                int ticketsSold = _showTimeDAL.CountTicketsSold(showTimeId);
                if (ticketsSold > 0)
                {
                    return (false, $"✗ Không thể xóa!\n" +
                                  $"Đã có {ticketsSold} vé được bán cho suất chiếu này.\n" +
                                  $"Vui lòng kiểm tra lại hoặc liên hệ quản trị viên.");
                }

                // Xóa thành công nếu là "Sắp chiếu" và không có vé bán
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
            if(showTime.Price % 1000 !=0)
                return(false, "✗ Giá vé phải là bội số của 1,000 VNĐ!");

            if (showTime.Price > 1000000)
                return (false, "✗ Giá vé quá cao! (Tối đa 1,000,000 VNĐ)");

            // Cho phép thêm suất chiếu trong quá khứ nhưng cảnh báo nếu quá xa
            if (showTime.StartTime < DateTime.Now.AddDays(-1))
                return (false, "✗ Thời gian bắt đầu quá xa trong quá khứ!");

            // ========== Kiểm tra khung giờ chiếu 8:00 - 23:00 ==========
            TimeSpan startTimeOfDay = showTime.StartTime.TimeOfDay;
            if (startTimeOfDay < new TimeSpan(8, 0, 0) || startTimeOfDay >= new TimeSpan(23, 0, 0))
            {
                return (false, "✗ Suất chiếu phải trong khung giờ 8:00 - 23:00!");
            }
            // ========== Kiểm tra ngày khởi chiếu của phim ==========
            var movie = _movieBLL.GetMovieById(showTime.MovieID);
            if (movie != null && movie.StartTime.HasValue)
            {
                // Chỉ so sánh ngày, bỏ qua giờ
                DateTime movieStartDate = movie.StartTime.Value.Date;
                DateTime showTimeDate = showTime.StartTime.Date;

                if (showTimeDate < movieStartDate)
                {
                    return (false, $"✗ Suất chiếu không thể trước ngày khởi chiếu của phim!\n" +
                                  $"Phim \"{movie.Title}\" khởi chiếu từ ngày {movieStartDate:dd/MM/yyyy}");
                }
            }
            // ========== Kiểm tra giờ kết thúc không vượt quá 23:00 ==========

            if (movie != null)
            {
                DateTime endTime = showTime.StartTime.AddMinutes(movie.DurationMinutes);
                TimeSpan endTimeOfDay = endTime.TimeOfDay;

                if (endTimeOfDay > new TimeSpan(23, 0, 0) || endTimeOfDay < new TimeSpan(8, 0, 0))
                {
                    return (false, $"✗ Suất chiếu không hợp lệ!\n" +
                                  $"Phim có thời lượng là {movie.DurationMinutes} phút và sẽ kết thúc lúc {endTime:HH:mm}.\n" +
                                  $"Giờ kết thúc phải trước 23:00!");
                }
            }
            // ========== Kiểm tra ngày kết chiếu của phim ==========
            if (movie != null && movie.EndTime.HasValue)
            {
                // Chỉ so sánh ngày, bỏ qua giờ
                DateTime movieEndDate = movie.EndTime.Value.Date;
                DateTime showTimeDate = showTime.StartTime.Date;

                if (showTimeDate > movieEndDate)
                {
                    return (false, $"✗ Suất chiếu không thể sau ngày kết chiếu của phim!\n" +
                                  $"Phim \"{movie.Title}\" kết chiếu vào ngày {movieEndDate:dd/MM/yyyy}");
                }
            }

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
        // ========== LẤY SUẤT CHIẾU PHÂN TRANG BẰNG STORED PROCEDURE ==========
        public (List<ShowTime> items, int totalCount, int totalPages, int currentPage) GetShowTimesPaginated(
         int pageNumber = 1,
         int pageSize = 10,
         int? movieId = null,
         int? roomId = null,
         DateTime? startDate = null,
         DateTime? endDate = null,
         decimal? minPrice = null,
         decimal? maxPrice = null,
         string sortBy = "StartTime",
         string sortOrder = "ASC")
        {
            try
            {
                // THÊM LOG ĐỂ DEBUG
                System.Diagnostics.Debug.WriteLine($"BLL - Calling GetShowTimesPaginated");
                System.Diagnostics.Debug.WriteLine($"PageNumber: {pageNumber}, PageSize: {pageSize}");
                System.Diagnostics.Debug.WriteLine($"MovieId: {movieId}, RoomId: {roomId}");

                var result = _showTimeDAL.GetShowTimesPaginated(
                    pageNumber,
                    pageSize,
                    movieId,
                    roomId,
                    startDate,
                    endDate,
                    minPrice,
                    maxPrice,
                    false, // isDeleted = false
                    sortBy,
                    sortOrder
                );

                System.Diagnostics.Debug.WriteLine($"BLL - Result count: {result.items?.Count ?? 0}");

                return result;
            }
            catch (Exception ex)
            {
                // LOG CHI TIẾT LỖI
                System.Diagnostics.Debug.WriteLine($"BLL Error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"BLL StackTrace: {ex.StackTrace}");

                throw new Exception("Lỗi khi gọi stored procedure GetShowTimesPaginated: " + ex.Message, ex);
            }
        }

        public string DeleteFutureShowTimesForMaintenance(int roomId, out int deletedCount)
        {
            deletedCount = 0;

            if (roomId <= 0)
                return "ID phòng không hợp lệ.";

            int futureCount = _showTimeDAL.CountFutureShowTimesByRoom(roomId);

            if (futureCount == 0)
            {
                return "Phòng không có xuất chiếu nào trong tương lai.";
            }

            string errorMessage;
            deletedCount = _showTimeDAL.DeleteFutureShowTimesByRoom(roomId, out errorMessage);

            if (deletedCount > 0)
            {
                return errorMessage; 
            }
            else
            {
                return $"Xóa xuất chiếu thất bại.\n{errorMessage}";
            }
        }

        public (int count, List<ShowTime> showTimes) GetFutureShowTimesInfo(int roomId)
        {
            var showTimes = _showTimeDAL.GetFutureShowTimesByRoom(roomId);
            return (showTimes.Count, showTimes);
        }
        public void Dispose()
        {
            _showTimeDAL?.Dispose();
        }
    }
}