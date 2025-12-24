using System;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BLL
{
    public class RevenueBLL
    {
        private RevenueDAL _revenueDAL;

        public RevenueBLL()
        {
            _revenueDAL = new RevenueDAL();
        }

        #region Top phim theo thời gian

        // Lấy top phim theo doanh thu hôm nay
        public List<MovieRevenueDTO> GetTopMovieRevenueToday(int topCount = 10)
        {
            return _revenueDAL.GetTopMovieRevenueByDate(DateTime.Today, topCount);
        }

        // Lấy top phim theo doanh thu hôm qua
        public List<MovieRevenueDTO> GetTopMovieRevenueYesterday(int topCount = 10)
        {
            return _revenueDAL.GetTopMovieRevenueByDate(DateTime.Today.AddDays(-1), topCount);
        }

        // Lấy top phim theo doanh thu ngày bất kỳ
        public List<MovieRevenueDTO> GetTopMovieRevenueByDate(DateTime date, int topCount = 10)
        {
            return _revenueDAL.GetTopMovieRevenueByDate(date, topCount);
        }

        // Lấy top phim theo doanh thu tuần này
        public List<MovieRevenueDTO> GetTopMovieRevenueThisWeek(int topCount = 10)
        {
            return _revenueDAL.GetTopMovieRevenueByWeek(DateTime.Today, topCount);
        }

        // Lấy top phim theo doanh thu tuần trước
        public List<MovieRevenueDTO> GetTopMovieRevenueLastWeek(int topCount = 10)
        {
            return _revenueDAL.GetTopMovieRevenueByWeek(DateTime.Today.AddDays(-7), topCount);
        }

        // Lấy top phim theo doanh thu tuần bất kỳ
        public List<MovieRevenueDTO> GetTopMovieRevenueByWeek(DateTime date, int topCount = 10)
        {
            return _revenueDAL.GetTopMovieRevenueByWeek(date, topCount);
        }

        // Lấy top phim theo doanh thu tháng hiện tại
        public List<MovieRevenueDTO> GetTopMovieRevenueThisMonth(int topCount = 10)
        {
            DateTime now = DateTime.Now;
            return _revenueDAL.GetTopMovieRevenueByMonth(now.Month, now.Year, topCount);
        }

        // Lấy top phim theo doanh thu tháng trước
        public List<MovieRevenueDTO> GetTopMovieRevenueLastMonth(int topCount = 10)
        {
            DateTime lastMonth = DateTime.Now.AddMonths(-1);
            return _revenueDAL.GetTopMovieRevenueByMonth(lastMonth.Month, lastMonth.Year, topCount);
        }

        // Lấy top phim theo doanh thu tháng bất kỳ
        public List<MovieRevenueDTO> GetTopMovieRevenueByMonth(int month, int year, int topCount = 10)
        {
            if (month < 1 || month > 12)
                throw new ArgumentException("Tháng phải từ 1 đến 12");

            return _revenueDAL.GetTopMovieRevenueByMonth(month, year, topCount);
        }

        // Lấy top phim theo doanh thu quý hiện tại
        public List<MovieRevenueDTO> GetTopMovieRevenueThisQuarter(int topCount = 10)
        {
            DateTime now = DateTime.Now;
            int quarter = (now.Month - 1) / 3 + 1;
            return _revenueDAL.GetTopMovieRevenueByQuarter(quarter, now.Year, topCount);
        }

        // Lấy top phim theo doanh thu quý bất kỳ
        public List<MovieRevenueDTO> GetTopMovieRevenueByQuarter(int quarter, int year, int topCount = 10)
        {
            if (quarter < 1 || quarter > 4)
                throw new ArgumentException("Quý phải từ 1 đến 4");

            return _revenueDAL.GetTopMovieRevenueByQuarter(quarter, year, topCount);
        }

        // Lấy top phim theo doanh thu năm hiện tại
        public List<MovieRevenueDTO> GetTopMovieRevenueThisYear(int topCount = 10)
        {
            return _revenueDAL.GetTopMovieRevenueByYear(DateTime.Now.Year, topCount);
        }

        // Lấy top phim theo doanh thu năm bất kỳ
        public List<MovieRevenueDTO> GetTopMovieRevenueByYear(int year, int topCount = 10)
        {
            return _revenueDAL.GetTopMovieRevenueByYear(year, topCount);
        }

        // Lấy top phim theo doanh thu khoảng thời gian tùy chỉnh
        public List<MovieRevenueDTO> GetTopMovieRevenueByDateRange(DateTime startDate, DateTime endDate, int topCount = 10)
        {
            if (startDate > endDate)
                throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc");

            return _revenueDAL.GetTopMovieRevenueByDateRange(startDate, endDate, topCount);
        }

        #endregion

        #region Chi tiết doanh thu phim

        // Lấy chi tiết doanh thu của một phim
        public MovieRevenueDetailDTO GetMovieRevenueDetail(int movieId, int month, int year)
        {
            return _revenueDAL.GetMovieRevenueDetail(movieId, month, year);
        }
        public MovieRevenueDetailDTO GetMovieRevenueDetailByYear(int movieId, int year)
        {
            return _revenueDAL.GetMovieRevenueDetailByYear(movieId, year);
        }
        #endregion

        #region Format dữ liệu

        // Format tiền tệ (VNĐ)
        public string FormatCurrency(decimal amount)
        {
            return amount.ToString("#,##0") + " ₫";
        }

        // Format số lượng vé
        public string FormatTicketCount(int count)
        {
            return count.ToString("#,##0") + " vé";
        }

        // Tính phần trăm đóng góp doanh thu
        public decimal CalculateRevenuePercentage(decimal movieRevenue, decimal totalRevenue)
        {
            if (totalRevenue == 0) return 0;
            return Math.Round((movieRevenue / totalRevenue) * 100, 2);
        }

        #endregion

        #region So sánh và phân tích

        // So sánh doanh thu phim giữa 2 kỳ
        public MovieRevenueComparisonDTO CompareMovieRevenue(int movieId, int month1, int year1, int month2, int year2)
        {
            var period1 = _revenueDAL.GetMovieRevenueDetail(movieId, month1, year1);
            var period2 = _revenueDAL.GetMovieRevenueDetail(movieId, month2, year2);

            if (period1 == null || period2 == null)
                return null;

            decimal growthRate = 0;
            if (period2.TotalRevenue != 0)
            {
                growthRate = ((period1.TotalRevenue - period2.TotalRevenue) / period2.TotalRevenue) * 100;
            }

            return new MovieRevenueComparisonDTO
            {
                MovieID = movieId,
                MovieTitle = period1.MovieTitle,
                Period1Revenue = period1.TotalRevenue,
                Period1Tickets = period1.TicketsSold,
                Period2Revenue = period2.TotalRevenue,
                Period2Tickets = period2.TicketsSold,
                RevenueGrowthRate = Math.Round(growthRate, 2),
                Period1 = period1.Period,
                Period2 = period2.Period
            };
        }

        // Tính tổng doanh thu của danh sách phim
        public decimal CalculateTotalRevenue(List<MovieRevenueDTO> movies)
        {
            return movies?.Sum(m => m.TotalRevenue) ?? 0;
        }

        // Tính tổng số vé bán được
        public int CalculateTotalTickets(List<MovieRevenueDTO> movies)
        {
            return movies?.Sum(m => m.TicketsSold) ?? 0;
        }

        // Lấy thống kê tổng hợp
        public MovieRevenueSummaryDTO GetRevenueSummary(List<MovieRevenueDTO> movies)
        {
            if (movies == null || !movies.Any())
            {
                return new MovieRevenueSummaryDTO();
            }

            return new MovieRevenueSummaryDTO
            {
                TotalRevenue = movies.Sum(m => m.TotalRevenue),
                TotalTickets = movies.Sum(m => m.TicketsSold),
                TotalMovies = movies.Count,
                AverageRevenuePerMovie = movies.Average(m => m.TotalRevenue),
                AverageTicketsPerMovie = (int)movies.Average(m => m.TicketsSold),
                TopMovie = movies.OrderByDescending(m => m.TotalRevenue).FirstOrDefault(),
                LowestMovie = movies.OrderBy(m => m.TotalRevenue).FirstOrDefault()
            };
        }

        #endregion

        #region Validation

        // Kiểm tra năm hợp lệ
        public bool IsValidYear(int year)
        {
            return year >= 2000 && year <= DateTime.Now.Year;
        }

        // Kiểm tra tháng hợp lệ
        public bool IsValidMonth(int month)
        {
            return month >= 1 && month <= 12;
        }

        // Kiểm tra quý hợp lệ
        public bool IsValidQuarter(int quarter)
        {
            return quarter >= 1 && quarter <= 4;
        }

        #endregion
    }

    #region DTO Classes cho BLL

    // DTO so sánh doanh thu
    public class MovieRevenueComparisonDTO
    {
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public decimal Period1Revenue { get; set; }
        public int Period1Tickets { get; set; }
        public decimal Period2Revenue { get; set; }
        public int Period2Tickets { get; set; }
        public decimal RevenueGrowthRate { get; set; }
        public string Period1 { get; set; }
        public string Period2 { get; set; }
    }

    // DTO tổng hợp doanh thu
    public class MovieRevenueSummaryDTO
    {
        public decimal TotalRevenue { get; set; }
        public int TotalTickets { get; set; }
        public int TotalMovies { get; set; }
        public decimal AverageRevenuePerMovie { get; set; }
        public int AverageTicketsPerMovie { get; set; }
        public MovieRevenueDTO TopMovie { get; set; }
        public MovieRevenueDTO LowestMovie { get; set; }
    }

    #endregion
}