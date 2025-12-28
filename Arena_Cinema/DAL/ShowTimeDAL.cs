using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DTO;

namespace DAL
{
    public class ShowTimeDAL : IDisposable
    {
        private readonly CinemaDBContext _context;

        public ShowTimeDAL()
        {
            _context = new CinemaDBContext();
        }

        // ========== THÊM SUẤT CHIẾU ==========
        public bool AddShowTime(ShowTime showTime)
        {
            try
            {
                showTime.ShowTimeID = Guid.NewGuid();
                showTime.IsDeleted = false;
                _context.ShowTimes.Add(showTime);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm suất chiếu: " + ex.Message);
            }
        }

        // ========== CẬP NHẬT SUẤT CHIẾU ==========
        public bool UpdateShowTime(ShowTime showTime)
        {
            try
            {
                var existingShowTime = _context.ShowTimes.Find(showTime.ShowTimeID);
                if (existingShowTime == null || existingShowTime.IsDeleted)
                    return false;

                existingShowTime.MovieID = showTime.MovieID;
                existingShowTime.RoomID = showTime.RoomID;
                existingShowTime.StartTime = showTime.StartTime;
                existingShowTime.Price = showTime.Price;

                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật suất chiếu: " + ex.Message);
            }
        }

        // ========== XÓA SUẤT CHIẾU (SOFT DELETE) ==========
        public bool DeleteShowTime(Guid showTimeId)
        {
            try
            {
                var showTime = _context.ShowTimes.Find(showTimeId);
                if (showTime == null)
                    return false;

                showTime.IsDeleted = true;
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa suất chiếu: " + ex.Message);
            }
        }

        // ========== LẤY TẤT CẢ SUẤT CHIẾU ==========
        public List<ShowTime> GetAllShowTimes()
        {
            try
            {
                return _context.ShowTimes
                    .Include(s => s.Movie)
                    .Include(s => s.Room)
                    .Where(s => !s.IsDeleted)
                    .OrderByDescending(s => s.StartTime)
                    .ToList();
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
                return _context.ShowTimes
                    .Include(s => s.Movie)
                    .Include(s => s.Room)
                    .FirstOrDefault(s => s.ShowTimeID == showTimeId && !s.IsDeleted);
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
                return _context.ShowTimes
                    .Include(s => s.Movie)
                    .Include(s => s.Room)
                    .Where(s => s.MovieID == movieId && !s.IsDeleted)
                    .OrderBy(s => s.StartTime)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy suất chiếu theo phim: " + ex.Message);
            }
        }

        // ========== LẤY SUẤT CHIẾU THEO PHÒNG ==========
        public List<ShowTime> GetShowTimesByRoom(int roomId)
        {
            try
            {
                return _context.ShowTimes
                    .Include(s => s.Movie)
                    .Include(s => s.Room)
                    .Where(s => s.RoomID == roomId && !s.IsDeleted)
                    .OrderBy(s => s.StartTime)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy suất chiếu theo phòng: " + ex.Message);
            }
        }

        // ========== LẤY SUẤT CHIẾU THEO KHOẢNG THỜI GIAN ==========
        public List<ShowTime> GetShowTimesByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                return _context.ShowTimes
                    .Include(s => s.Movie)
                    .Include(s => s.Room)
                    .Where(s => s.StartTime >= startDate && s.StartTime <= endDate && !s.IsDeleted)
                    .OrderBy(s => s.StartTime)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy suất chiếu theo thời gian: " + ex.Message);
            }
        }

        // ========== KIỂM TRA TRÙNG LỊCH ==========
        public bool CheckScheduleConflict(int roomId, DateTime startTime, int durationMinutes, Guid? excludeShowTimeId = null)
        {
            try
            {
                DateTime endTime = startTime.AddMinutes(durationMinutes);

                var query = _context.ShowTimes
                    .Include(s => s.Movie)
                    .Where(s => s.RoomID == roomId && !s.IsDeleted);

                if (excludeShowTimeId.HasValue)
                {
                    query = query.Where(s => s.ShowTimeID != excludeShowTimeId.Value);
                }

                // Kiểm tra xung đột thời gian
                return query.AsEnumerable().Any(s =>
                {
                    DateTime existingEndTime = s.StartTime.AddMinutes(s.Movie.DurationMinutes);

                    // Trường hợp 1: StartTime mới nằm trong khoảng [existingStart, existingEnd)
                    bool case1 = startTime >= s.StartTime && startTime < existingEndTime;

                    // Trường hợp 2: EndTime mới nằm trong khoảng (existingStart, existingEnd]
                    bool case2 = endTime > s.StartTime && endTime <= existingEndTime;

                    // Trường hợp 3: Suất chiếu mới bao trùm suất chiếu cũ
                    bool case3 = startTime <= s.StartTime && endTime >= existingEndTime;

                    return case1 || case2 || case3;
                });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra trùng lịch: " + ex.Message);
            }
        }

        // ========== LẤY SUẤT CHIẾU CÓ LỌC VÀ PHÂN TRANG ==========
        public (List<ShowTime> items, int totalCount) GetShowTimesFiltered(
            int? movieId = null,
            int? roomId = null,
            DateTime? startDate = null,
            DateTime? endDate = null,
            int pageNumber = 1,
            int pageSize = 10)
        {
            try
            {
                var query = _context.ShowTimes
                    .Include(s => s.Movie)
                    .Include(s => s.Room)
                    .Where(s => !s.IsDeleted);

                // Áp dụng các bộ lọc
                if (movieId.HasValue && movieId.Value > 0)
                    query = query.Where(s => s.MovieID == movieId.Value);

                if (roomId.HasValue && roomId.Value > 0)
                    query = query.Where(s => s.RoomID == roomId.Value);

                if (startDate.HasValue)
                    query = query.Where(s => s.StartTime >= startDate.Value);

                if (endDate.HasValue)
                    query = query.Where(s => s.StartTime <= endDate.Value);

                int totalCount = query.Count();

                var items = query
                    .OrderByDescending(s => s.StartTime)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                return (items, totalCount);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách suất chiếu có lọc: " + ex.Message);
            }
        }

        // ========== ĐẾM SỐ VÉ ĐÃ BÁN ==========
        public int CountTicketsSold(Guid showTimeId)
        {
            try
            {
                return _context.Tickets
                    .Count(t => t.ShowTimeID == showTimeId
                             && !t.IsDeleted
                             && t.Status == "Đã bán");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đếm vé đã bán: " + ex.Message);
            }
        }

        // ========== KIỂM TRA CÓ THỂ XÓA HAY KHÔNG ==========
        public bool CanDeleteShowTime(Guid showTimeId)
        {
            try
            {
                // Không cho xóa nếu đã có vé bán ra
                return CountTicketsSold(showTimeId) == 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra khả năng xóa: " + ex.Message);
            }
        }

        // ========== LẤY SUẤT CHIẾU SẮP DIỄN RA ==========
        public List<ShowTime> GetUpcomingShowTimes(int limit = 10)
        {
            try
            {
                DateTime now = DateTime.Now;
                return _context.ShowTimes
                    .Include(s => s.Movie)
                    .Include(s => s.Room)
                    .Where(s => !s.IsDeleted && s.StartTime > now)
                    .OrderBy(s => s.StartTime)
                    .Take(limit)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy suất chiếu sắp diễn ra: " + ex.Message);
            }
        }

        // ========== LẤY SUẤT CHIẾU TRONG HÔM NAY ==========
        public List<ShowTime> GetTodayShowTimes()
        {
            try
            {
                DateTime today = DateTime.Today;
                DateTime tomorrow = today.AddDays(1);

                return _context.ShowTimes
                    .Include(s => s.Movie)
                    .Include(s => s.Room)
                    .Where(s => !s.IsDeleted && s.StartTime >= today && s.StartTime < tomorrow)
                    .OrderBy(s => s.StartTime)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy suất chiếu hôm nay: " + ex.Message);
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
     bool isDeleted = false,
     string sortBy = "StartTime",
     string sortOrder = "ASC")
        {
            try
            {
                var showtimes = new List<ShowTime>();
                int totalRecords = 0;
                int totalPages = 0;
                int currentPageResult = 0;

                // Đảm bảo connection được mở
                if (_context.Database.Connection.State != System.Data.ConnectionState.Open)
                {
                    _context.Database.Connection.Open();
                }

                using (var command = _context.Database.Connection.CreateCommand())
                {
                    command.CommandText = "sp_GetShowTimesPaginated";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = 60; // Tăng timeout

                    // Thêm parameters với kiểm tra kỹ
                    var paramPageNumber = command.CreateParameter();
                    paramPageNumber.ParameterName = "@PageNumber";
                    paramPageNumber.Value = pageNumber;
                    paramPageNumber.DbType = System.Data.DbType.Int32;
                    command.Parameters.Add(paramPageNumber);

                    var paramPageSize = command.CreateParameter();
                    paramPageSize.ParameterName = "@PageSize";
                    paramPageSize.Value = pageSize;
                    paramPageSize.DbType = System.Data.DbType.Int32;
                    command.Parameters.Add(paramPageSize);

                    var paramMovieID = command.CreateParameter();
                    paramMovieID.ParameterName = "@MovieID";
                    paramMovieID.Value = movieId.HasValue ? (object)movieId.Value : DBNull.Value;
                    paramMovieID.DbType = System.Data.DbType.Int32;
                    command.Parameters.Add(paramMovieID);

                    var paramRoomID = command.CreateParameter();
                    paramRoomID.ParameterName = "@RoomID";
                    paramRoomID.Value = roomId.HasValue ? (object)roomId.Value : DBNull.Value;
                    paramRoomID.DbType = System.Data.DbType.Int32;
                    command.Parameters.Add(paramRoomID);

                    var paramStartDate = command.CreateParameter();
                    paramStartDate.ParameterName = "@StartDate";
                    paramStartDate.Value = startDate.HasValue ? (object)startDate.Value : DBNull.Value;
                    paramStartDate.DbType = System.Data.DbType.DateTime;
                    command.Parameters.Add(paramStartDate);

                    var paramEndDate = command.CreateParameter();
                    paramEndDate.ParameterName = "@EndDate";
                    paramEndDate.Value = endDate.HasValue ? (object)endDate.Value : DBNull.Value;
                    paramEndDate.DbType = System.Data.DbType.DateTime;
                    command.Parameters.Add(paramEndDate);

                    var paramMinPrice = command.CreateParameter();
                    paramMinPrice.ParameterName = "@MinPrice";
                    paramMinPrice.Value = minPrice.HasValue ? (object)minPrice.Value : DBNull.Value;
                    paramMinPrice.DbType = System.Data.DbType.Decimal;
                    command.Parameters.Add(paramMinPrice);

                    var paramMaxPrice = command.CreateParameter();
                    paramMaxPrice.ParameterName = "@MaxPrice";
                    paramMaxPrice.Value = maxPrice.HasValue ? (object)maxPrice.Value : DBNull.Value;
                    paramMaxPrice.DbType = System.Data.DbType.Decimal;
                    command.Parameters.Add(paramMaxPrice);

                    var paramIsDeleted = command.CreateParameter();
                    paramIsDeleted.ParameterName = "@IsDeleted";
                    paramIsDeleted.Value = isDeleted;
                    paramIsDeleted.DbType = System.Data.DbType.Boolean;
                    command.Parameters.Add(paramIsDeleted);

                    var paramSortBy = command.CreateParameter();
                    paramSortBy.ParameterName = "@SortBy";
                    paramSortBy.Value = sortBy ?? "StartTime";
                    paramSortBy.DbType = System.Data.DbType.String;
                    paramSortBy.Size = 50;
                    command.Parameters.Add(paramSortBy);

                    var paramSortOrder = command.CreateParameter();
                    paramSortOrder.ParameterName = "@SortOrder";
                    paramSortOrder.Value = sortOrder ?? "ASC";
                    paramSortOrder.DbType = System.Data.DbType.String;
                    paramSortOrder.Size = 4;
                    command.Parameters.Add(paramSortOrder);

                    // LOG ĐỂ DEBUG
                    System.Diagnostics.Debug.WriteLine($"DAL - Executing stored procedure...");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                var showtime = new ShowTime
                                {
                                    ShowTimeID = reader.GetGuid(reader.GetOrdinal("ShowTimeID")),
                                    StartTime = reader.GetDateTime(reader.GetOrdinal("StartTime")),
                                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                                    MovieID = reader.GetInt32(reader.GetOrdinal("MovieID")),
                                    RoomID = reader.GetInt32(reader.GetOrdinal("RoomID")),
                                    IsDeleted = reader.GetBoolean(reader.GetOrdinal("IsDeleted")),
                                    Movie = new Movie
                                    {
                                        MovieID = reader.GetInt32(reader.GetOrdinal("MovieID")),
                                        Title = reader.GetString(reader.GetOrdinal("MovieTitle")),
                                        DurationMinutes = reader.GetInt32(reader.GetOrdinal("DurationMinutes")),
                                        ImageUrl = reader.IsDBNull(reader.GetOrdinal("MovieImage"))
                                            ? null
                                            : reader.GetString(reader.GetOrdinal("MovieImage"))
                                    },
                                    Room = new Room
                                    {
                                        RoomID = reader.GetInt32(reader.GetOrdinal("RoomID")),
                                        RoomName = reader.GetString(reader.GetOrdinal("RoomName")),
                                        RoomType = reader.GetString(reader.GetOrdinal("RoomType")),
                                        SeatCount = reader.GetInt32(reader.GetOrdinal("SeatCount"))
                                    }
                                };

                                // Lấy thông tin phân trang từ dòng đầu tiên
                                if (showtimes.Count == 0)
                                {
                                    totalRecords = reader.GetInt32(reader.GetOrdinal("TotalRecords"));
                                    totalPages = reader.GetInt32(reader.GetOrdinal("TotalPages"));
                                    currentPageResult = reader.GetInt32(reader.GetOrdinal("CurrentPage"));
                                }

                                showtimes.Add(showtime);
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Debug.WriteLine($"Error reading row: {ex.Message}");
                                throw;
                            }
                        }
                    }

                    System.Diagnostics.Debug.WriteLine($"DAL - Read {showtimes.Count} records");
                }

                return (showtimes, totalRecords, totalPages, currentPageResult);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"DAL Error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"DAL StackTrace: {ex.StackTrace}");

                throw new Exception("Lỗi khi lấy danh sách suất chiếu phân trang: " + ex.Message, ex);
            }
        }

        public int DeleteFutureShowTimesByRoom(int roomId, out string errorMessage)
        {
            errorMessage = string.Empty;
            int deletedCount = 0;

            try
            {
                DateTime now = DateTime.Now;

                var futureShowTimes = _context.ShowTimes
                    .Where(st => st.RoomID == roomId
                              && st.StartTime >= now
                              && !st.IsDeleted)
                    .ToList();

                if (!futureShowTimes.Any())
                {
                    errorMessage = "Không có xuất chiếu nào trong tương lai.";
                    return 0;
                }

                deletedCount = futureShowTimes.Count;

                _context.ShowTimes.RemoveRange(futureShowTimes);
                _context.SaveChanges();

                errorMessage = $"Đã xóa vĩnh viễn {deletedCount} xuất chiếu.";
                return deletedCount;
            }
            catch (Exception ex)
            {
                errorMessage = "Lỗi khi xóa xuất chiếu: " + ex.Message;
                return 0;
            }
        }

        public int CountFutureShowTimesByRoom(int roomId)
        {
            DateTime now = DateTime.Now;

            return _context.ShowTimes
                          .Count(st => st.RoomID == roomId
                                    && st.StartTime >= now
                                    && !st.IsDeleted);
        }

        public List<ShowTime> GetFutureShowTimesByRoom(int roomId)
        {
            DateTime now = DateTime.Now;

            return _context.ShowTimes
                          .Where(st => st.RoomID == roomId
                                    && st.StartTime >= now
                                    && !st.IsDeleted)
                          .Include(st => st.Movie)
                          .OrderBy(st => st.StartTime)
                          .ToList();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}