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
                    .Count(t => t.ShowTimeID == showTimeId && !t.IsDeleted);
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

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}