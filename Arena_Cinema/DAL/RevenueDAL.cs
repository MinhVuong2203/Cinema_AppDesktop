using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class RevenueDAL
    {
        private CinemaDBContext _db;

        public RevenueDAL()
        {
            _db = new CinemaDBContext();
        }

        #region Doanh thu theo ngày

        // Lấy top phim theo doanh thu ngày
        public List<MovieRevenueDTO> GetTopMovieRevenueByDate(DateTime date, int topCount = 10)
        {
            DateTime startDate = date.Date;
            DateTime endDate = startDate.AddDays(1);

            var query = from invoice in _db.Invoices
                        join invoiceTicket in _db.InvoiceTickets on invoice.InvoiceID equals invoiceTicket.InvoiceID
                        join ticket in _db.Tickets on invoiceTicket.TicketID equals ticket.TicketID
                        join showtime in _db.ShowTimes on ticket.ShowTimeID equals showtime.ShowTimeID
                        join movie in _db.Movies on showtime.MovieID equals movie.MovieID
                        where !invoice.IsDeleted
                            && invoice.Status == "Đã thanh toán"
                            && invoice.IssueDate >= startDate
                            && invoice.IssueDate < endDate
                            && !movie.IsDeleted
                        group invoiceTicket by new
                        {
                            movie.MovieID,
                            movie.Title,
                            movie.ImageUrl,
                            movie.Genre
                        } into g
                        select new
                        {
                            MovieID = g.Key.MovieID,
                            MovieTitle = g.Key.Title,
                            ImageUrl = g.Key.ImageUrl,
                            Genre = g.Key.Genre,
                            TotalRevenue = g.Sum(x => (x.UnitPrice ?? 0) * (x.Quantity ?? 1)),
                            TicketsSold = g.Sum(x => x.Quantity ?? 1)
                        };

            var result = query.OrderByDescending(x => x.TotalRevenue)
                             .Take(topCount)
                             .ToList()
                             .Select(x => new MovieRevenueDTO
                             {
                                 MovieID = x.MovieID,
                                 MovieTitle = x.MovieTitle,
                                 ImageUrl = x.ImageUrl,
                                 Genre = x.Genre,
                                 TotalRevenue = x.TotalRevenue,
                                 TicketsSold = x.TicketsSold,
                                 Period = "Ngày " + date.ToString("dd/MM/yyyy")
                             })
                             .ToList();

            return result;

      
        }

        #endregion

        #region Doanh thu theo tuần

        // Lấy top phim theo doanh thu tuần
        public List<MovieRevenueDTO> GetTopMovieRevenueByWeek(DateTime date, int topCount = 10)
        {
            // Tính ngày đầu tuần (Thứ 2) và cuối tuần (Chủ nhật)
            int dayOfWeek = (int)date.DayOfWeek;
            int daysToMonday = dayOfWeek == 0 ? -6 : 1 - dayOfWeek; // 0 = Sunday
            DateTime startDate = date.Date.AddDays(daysToMonday);
            DateTime endDate = startDate.AddDays(7);

            var query = from invoice in _db.Invoices
                        join invoiceTicket in _db.InvoiceTickets on invoice.InvoiceID equals invoiceTicket.InvoiceID
                        join ticket in _db.Tickets on invoiceTicket.TicketID equals ticket.TicketID
                        join showtime in _db.ShowTimes on ticket.ShowTimeID equals showtime.ShowTimeID
                        join movie in _db.Movies on showtime.MovieID equals movie.MovieID
                        where !invoice.IsDeleted
                            && invoice.Status == "Đã thanh toán"
                            && invoice.IssueDate >= startDate
                            && invoice.IssueDate < endDate
                            && !movie.IsDeleted
                        group invoiceTicket by new
                        {
                            movie.MovieID,
                            movie.Title,
                            movie.ImageUrl,
                            movie.Genre
                        } into g
                        select new
                        {
                            MovieID = g.Key.MovieID,
                            MovieTitle = g.Key.Title,
                            ImageUrl = g.Key.ImageUrl,
                            Genre = g.Key.Genre,
                            TotalRevenue = g.Sum(x => (x.UnitPrice ?? 0) * (x.Quantity ?? 1)),
                            TicketsSold = g.Sum(x => x.Quantity ?? 1)
                        };

            var result = query.OrderByDescending(x => x.TotalRevenue)
                             .Take(topCount)
                             .ToList()
                             .Select(x => new MovieRevenueDTO
                             {
                                 MovieID = x.MovieID,
                                 MovieTitle = x.MovieTitle,
                                 ImageUrl = x.ImageUrl,
                                 Genre = x.Genre,
                                 TotalRevenue = x.TotalRevenue,
                                 TicketsSold = x.TicketsSold,
                                 Period = "Tuần " + startDate.ToString("dd/MM") + " - " + endDate.AddDays(-1).ToString("dd/MM/yyyy")
                             })
                             .ToList();

            return result;
        }

        #endregion

        #region Doanh thu theo tháng

        // Lấy top phim theo doanh thu tháng
        public List<MovieRevenueDTO> GetTopMovieRevenueByMonth(int month, int year, int topCount = 10)
        {
            var query = from invoice in _db.Invoices
                        join invoiceTicket in _db.InvoiceTickets on invoice.InvoiceID equals invoiceTicket.InvoiceID
                        join ticket in _db.Tickets on invoiceTicket.TicketID equals ticket.TicketID
                        join showtime in _db.ShowTimes on ticket.ShowTimeID equals showtime.ShowTimeID
                        join movie in _db.Movies on showtime.MovieID equals movie.MovieID
                        where !invoice.IsDeleted
                            && invoice.Status == "Đã thanh toán"
                            && invoice.IssueDate.Month == month
                            && invoice.IssueDate.Year == year
                            && !movie.IsDeleted
                        group invoiceTicket by new
                        {
                            movie.MovieID,
                            movie.Title,
                            movie.ImageUrl,
                            movie.Genre
                        } into g
                        select new
                        {
                            MovieID = g.Key.MovieID,
                            MovieTitle = g.Key.Title,
                            ImageUrl = g.Key.ImageUrl,
                            Genre = g.Key.Genre,
                            TotalRevenue = g.Sum(x => (x.UnitPrice ?? 0) * (x.Quantity ?? 1)),
                            TicketsSold = g.Sum(x => x.Quantity ?? 1)
                        };

            var result = query.OrderByDescending(x => x.TotalRevenue)
                             .Take(topCount)
                             .ToList()
                             .Select(x => new MovieRevenueDTO
                             {
                                 MovieID = x.MovieID,
                                 MovieTitle = x.MovieTitle,
                                 ImageUrl = x.ImageUrl,
                                 Genre = x.Genre,
                                 TotalRevenue = x.TotalRevenue,
                                 TicketsSold = x.TicketsSold,
                                 Period = "Tháng " + month + "/" + year
                             })
                             .ToList();

            return result;
        }

        #endregion

        #region Doanh thu theo quý

        // Lấy top phim theo doanh thu quý
        // Lấy top phim theo doanh thu quý
        public List<MovieRevenueDTO> GetTopMovieRevenueByQuarter(int quarter, int year, int topCount = 10)
        {
            // Xác định tháng bắt đầu và kết thúc của quý
            int startMonth = (quarter - 1) * 3 + 1;
            int endMonth = startMonth + 2; // Tháng cuối của quý (không phải +3)

            DateTime startDate = new DateTime(year, startMonth, 1);
            // Lấy ngày cuối cùng của tháng cuối quý
            DateTime endDate = new DateTime(year, endMonth, DateTime.DaysInMonth(year, endMonth))
                                   .AddDays(1); // Thêm 1 ngày để dùng với toán tử 

            var query = from invoice in _db.Invoices
                        join invoiceTicket in _db.InvoiceTickets on invoice.InvoiceID equals invoiceTicket.InvoiceID
                        join ticket in _db.Tickets on invoiceTicket.TicketID equals ticket.TicketID
                        join showtime in _db.ShowTimes on ticket.ShowTimeID equals showtime.ShowTimeID
                        join movie in _db.Movies on showtime.MovieID equals movie.MovieID
                        where !invoice.IsDeleted
                            && invoice.Status == "Đã thanh toán"
                            && invoice.IssueDate >= startDate
                            && invoice.IssueDate < endDate
                            && !movie.IsDeleted
                        group invoiceTicket by new
                        {
                            movie.MovieID,
                            movie.Title,
                            movie.ImageUrl,
                            movie.Genre
                        } into g
                        select new
                        {
                            MovieID = g.Key.MovieID,
                            MovieTitle = g.Key.Title,
                            ImageUrl = g.Key.ImageUrl,
                            Genre = g.Key.Genre,
                            TotalRevenue = g.Sum(x => (x.UnitPrice ?? 0) * (x.Quantity ?? 1)),
                            TicketsSold = g.Sum(x => x.Quantity ?? 1)
                        };

            var result = query.OrderByDescending(x => x.TotalRevenue)
                             .Take(topCount)
                             .ToList()
                             .Select(x => new MovieRevenueDTO
                             {
                                 MovieID = x.MovieID,
                                 MovieTitle = x.MovieTitle,
                                 ImageUrl = x.ImageUrl,
                                 Genre = x.Genre,
                                 TotalRevenue = x.TotalRevenue,
                                 TicketsSold = x.TicketsSold,
                                 Period = "Quý " + quarter + "/" + year
                             })
                             .ToList();

            return result;
        }
        #endregion

        #region Doanh thu theo năm

        // Lấy top phim theo doanh thu năm
        public List<MovieRevenueDTO> GetTopMovieRevenueByYear(int year, int topCount = 10)
        {
            var query = from invoice in _db.Invoices
                        join invoiceTicket in _db.InvoiceTickets on invoice.InvoiceID equals invoiceTicket.InvoiceID
                        join ticket in _db.Tickets on invoiceTicket.TicketID equals ticket.TicketID
                        join showtime in _db.ShowTimes on ticket.ShowTimeID equals showtime.ShowTimeID
                        join movie in _db.Movies on showtime.MovieID equals movie.MovieID
                        where !invoice.IsDeleted
                            && invoice.Status == "Đã thanh toán"
                            && invoice.IssueDate.Year == year
                            && !movie.IsDeleted
                        group invoiceTicket by new
                        {
                            movie.MovieID,
                            movie.Title,
                            movie.ImageUrl,
                            movie.Genre
                        } into g
                        select new
                        {
                            MovieID = g.Key.MovieID,
                            MovieTitle = g.Key.Title,
                            ImageUrl = g.Key.ImageUrl,
                            Genre = g.Key.Genre,
                            TotalRevenue = g.Sum(x => (x.UnitPrice ?? 0) * (x.Quantity ?? 1)),
                            TicketsSold = g.Sum(x => x.Quantity ?? 1)
                        };

            var result = query.OrderByDescending(x => x.TotalRevenue)
                             .Take(topCount)
                             .ToList()
                             .Select(x => new MovieRevenueDTO
                             {
                                 MovieID = x.MovieID,
                                 MovieTitle = x.MovieTitle,
                                 ImageUrl = x.ImageUrl,
                                 Genre = x.Genre,
                                 TotalRevenue = x.TotalRevenue,
                                 TicketsSold = x.TicketsSold,
                                 Period = "Năm " + year
                             })
                             .ToList();

            return result;
        }

        #endregion

        #region Doanh thu theo khoảng thời gian tùy chỉnh

        // Lấy top phim theo doanh thu khoảng thời gian
        public List<MovieRevenueDTO> GetTopMovieRevenueByDateRange(DateTime startDate, DateTime endDate, int topCount = 10)
        {
            DateTime start = startDate.Date;
            DateTime end = endDate.Date.AddDays(1);

            var query = from invoice in _db.Invoices
                        join invoiceTicket in _db.InvoiceTickets on invoice.InvoiceID equals invoiceTicket.InvoiceID
                        join ticket in _db.Tickets on invoiceTicket.TicketID equals ticket.TicketID
                        join showtime in _db.ShowTimes on ticket.ShowTimeID equals showtime.ShowTimeID
                        join movie in _db.Movies on showtime.MovieID equals movie.MovieID
                        where !invoice.IsDeleted
                            && invoice.Status == "Đã thanh toán"
                            && invoice.IssueDate >= start
                            && invoice.IssueDate < end
                            && !movie.IsDeleted
                        group invoiceTicket by new
                        {
                            movie.MovieID,
                            movie.Title,
                            movie.ImageUrl,
                            movie.Genre
                        } into g
                        select new
                        {
                            MovieID = g.Key.MovieID,
                            MovieTitle = g.Key.Title,
                            ImageUrl = g.Key.ImageUrl,
                            Genre = g.Key.Genre,
                            TotalRevenue = g.Sum(x => (x.UnitPrice ?? 0) * (x.Quantity ?? 1)),
                            TicketsSold = g.Sum(x => x.Quantity ?? 1)
                        };

            var result = query.OrderByDescending(x => x.TotalRevenue)
                             .Take(topCount)
                             .ToList()
                             .Select(x => new MovieRevenueDTO
                             {
                                 MovieID = x.MovieID,
                                 MovieTitle = x.MovieTitle,
                                 ImageUrl = x.ImageUrl,
                                 Genre = x.Genre,
                                 TotalRevenue = x.TotalRevenue,
                                 TicketsSold = x.TicketsSold,
                                 Period = startDate.ToString("dd/MM/yyyy") + " - " + endDate.ToString("dd/MM/yyyy")
                             })
                             .ToList();

            return result;
        }

        #endregion

        #region Chi tiết doanh thu từng phim

        // Lấy chi tiết doanh thu của một phim theo tháng
        public MovieRevenueDetailDTO GetMovieRevenueDetail(int movieId, int month, int year)
        {
            var movie = _db.Movies.FirstOrDefault(m => m.MovieID == movieId && !m.IsDeleted);
            if (movie == null) return null;

            var revenues = from invoice in _db.Invoices
                           join invoiceTicket in _db.InvoiceTickets on invoice.InvoiceID equals invoiceTicket.InvoiceID
                           join ticket in _db.Tickets on invoiceTicket.TicketID equals ticket.TicketID
                           join showtime in _db.ShowTimes on ticket.ShowTimeID equals showtime.ShowTimeID
                           where !invoice.IsDeleted
                               && invoice.Status == "Đã thanh toán"
                               && invoice.IssueDate.Month == month
                               && invoice.IssueDate.Year == year
                               && showtime.MovieID == movieId
                           select new
                           {
                               Revenue = (invoiceTicket.UnitPrice ?? 0) * (invoiceTicket.Quantity ?? 1),
                               Tickets = invoiceTicket.Quantity ?? 1,
                               Date = invoice.IssueDate
                           };

            var revenueList = revenues.ToList();

            return new MovieRevenueDetailDTO
            {
                MovieID = movie.MovieID,
                MovieTitle = movie.Title,
                ImageUrl = movie.ImageUrl,
                Genre = movie.Genre,
                TotalRevenue = revenueList.Sum(x => x.Revenue),
                TicketsSold = revenueList.Sum(x => x.Tickets),
                AverageTicketPrice = revenueList.Sum(x => x.Tickets) > 0
                    ? revenueList.Sum(x => x.Revenue) / revenueList.Sum(x => x.Tickets)
                    : 0,
                Period = $"Tháng {month}/{year}"
            };
        }

        // Lấy chi tiết doanh thu của một phim theo năm
        public MovieRevenueDetailDTO GetMovieRevenueDetailByYear(int movieId, int year)
        {
            var movie = _db.Movies.FirstOrDefault(m => m.MovieID == movieId && !m.IsDeleted);
            if (movie == null) return null;

            var revenues = from invoice in _db.Invoices
                           join invoiceTicket in _db.InvoiceTickets on invoice.InvoiceID equals invoiceTicket.InvoiceID
                           join ticket in _db.Tickets on invoiceTicket.TicketID equals ticket.TicketID
                           join showtime in _db.ShowTimes on ticket.ShowTimeID equals showtime.ShowTimeID
                           where !invoice.IsDeleted
                               && invoice.Status == "Đã thanh toán"
                               && invoice.IssueDate.Year == year
                               && showtime.MovieID == movieId
                           select new
                           {
                               Revenue = (invoiceTicket.UnitPrice ?? 0) * (invoiceTicket.Quantity ?? 1),
                               Tickets = invoiceTicket.Quantity ?? 1
                           };

            var revenueList = revenues.ToList();

            return new MovieRevenueDetailDTO
            {
                MovieID = movie.MovieID,
                MovieTitle = movie.Title,
                ImageUrl = movie.ImageUrl,
                Genre = movie.Genre,
                TotalRevenue = revenueList.Sum(x => x.Revenue),
                TicketsSold = revenueList.Sum(x => x.Tickets),
                AverageTicketPrice = revenueList.Sum(x => x.Tickets) > 0
                    ? revenueList.Sum(x => x.Revenue) / revenueList.Sum(x => x.Tickets)
                    : 0,
                Period = $"Năm {year}"
            };
        }

        // Lấy doanh thu theo từng tháng của một phim trong năm
        public Dictionary<int, decimal> GetMovieMonthlyRevenueByYear(int movieId, int year)
        {
            var result = new Dictionary<int, decimal>();

            var monthlyData = from invoice in _db.Invoices
                              join invoiceTicket in _db.InvoiceTickets on invoice.InvoiceID equals invoiceTicket.InvoiceID
                              join ticket in _db.Tickets on invoiceTicket.TicketID equals ticket.TicketID
                              join showtime in _db.ShowTimes on ticket.ShowTimeID equals showtime.ShowTimeID
                              where !invoice.IsDeleted
                                  && invoice.Status == "Đã thanh toán"
                                  && invoice.IssueDate.Year == year
                                  && showtime.MovieID == movieId
                              group invoiceTicket by invoice.IssueDate.Month into g
                              select new
                              {
                                  Month = g.Key,
                                  Revenue = g.Sum(x => (x.UnitPrice ?? 0) * (x.Quantity ?? 1))
                              };

            var data = monthlyData.ToList();

            // Khởi tạo tất cả 12 tháng với giá trị 0
            for (int month = 1; month <= 12; month++)
            {
                var monthData = data.FirstOrDefault(x => x.Month == month);
                result.Add(month, monthData?.Revenue ?? 0);
            }

            return result;
        }

        #endregion

        #region Thống kê bổ sung

        // Lấy tổng doanh thu của tất cả phim theo tháng
        public decimal GetTotalMovieRevenueByMonth(int month, int year)
        {
            return _db.Invoices
                .Where(i => !i.IsDeleted
                    && i.Status == "Đã thanh toán"
                    && i.IssueDate.Month == month
                    && i.IssueDate.Year == year)
                .Join(_db.InvoiceTickets, i => i.InvoiceID, it => it.InvoiceID, (i, it) => it)
                .Sum(it => (decimal?)((it.UnitPrice ?? 0) * (it.Quantity ?? 1))) ?? 0;
        }

        // Lấy số lượng phim đang có doanh thu trong tháng
        public int GetActiveMovieCountByMonth(int month, int year)
        {
            return (from invoice in _db.Invoices
                    join invoiceTicket in _db.InvoiceTickets on invoice.InvoiceID equals invoiceTicket.InvoiceID
                    join ticket in _db.Tickets on invoiceTicket.TicketID equals ticket.TicketID
                    join showtime in _db.ShowTimes on ticket.ShowTimeID equals showtime.ShowTimeID
                    where !invoice.IsDeleted
                        && invoice.Status == "Đã thanh toán"
                        && invoice.IssueDate.Month == month
                        && invoice.IssueDate.Year == year
                    select showtime.MovieID)
                    .Distinct()
                    .Count();
        }

        #endregion
    }

    #region DTO Classes

    // DTO cho doanh thu phim
    public class MovieRevenueDTO
    {
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
        public decimal TotalRevenue { get; set; }
        public int TicketsSold { get; set; }
        public string Period { get; set; }
    }

    // DTO cho chi tiết doanh thu phim
    public class MovieRevenueDetailDTO
    {
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
        public decimal TotalRevenue { get; set; }
        public int TicketsSold { get; set; }
        public decimal AverageTicketPrice { get; set; }
        public string Period { get; set; }
    }

    #endregion
}