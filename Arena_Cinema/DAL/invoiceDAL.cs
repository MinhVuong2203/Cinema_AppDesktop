using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class InvoiceDAL
    {
        private CinemaDBContext _db;

        public InvoiceDAL()
        {
            _db = new CinemaDBContext();
        }

        // Lấy tất cả hóa đơn
        public List<Invoice> GetAllInvoices()
        {
            return _db.Invoices.Where(i => !i.IsDeleted).ToList();
        }

        // Lấy hóa đơn theo ID
        public Invoice GetInvoiceByID(Guid invoiceID)
        {
            return _db.Invoices.FirstOrDefault(i => i.InvoiceID == invoiceID && !i.IsDeleted);
        }

        // Lấy tổng doanh thu theo tháng
        public decimal GetMonthlyRevenue(int month, int year)
        {
            return _db.Invoices
                .Where(i => !i.IsDeleted
                    && i.Status == "Đã thanh toán"
                    && i.IssueDate.Month == month
                    && i.IssueDate.Year == year)
                .Sum(i => (decimal?)i.TotalAmount) ?? 0;
        }

        // Lấy tổng doanh thu theo năm
        public decimal GetYearlyRevenue(int year)
        {
            return _db.Invoices
                .Where(i => !i.IsDeleted
                    && i.Status == "Đã thanh toán"
                    && i.IssueDate.Year == year)
                .Sum(i => (decimal?)i.TotalAmount) ?? 0;
        }

        // Lấy số lượng hóa đơn theo tháng
        public int GetMonthlyInvoiceCount(int month, int year)
        {
            return _db.Invoices
                .Count(i => !i.IsDeleted
                    && i.Status == "Đã thanh toán"
                    && i.IssueDate.Month == month
                    && i.IssueDate.Year == year);
        }

        // Lấy doanh thu theo khoảng thời gian
        public decimal GetRevenueByDateRange(DateTime startDate, DateTime endDate)
        {
            return _db.Invoices
                .Where(i => !i.IsDeleted
                    && i.Status == "Đã thanh toán"
                    && i.IssueDate >= startDate
                    && i.IssueDate <= endDate)
                .Sum(i => (decimal?)i.TotalAmount) ?? 0;
        }

        // Lấy danh sách hóa đơn theo tháng
        public List<Invoice> GetInvoicesByMonth(int month, int year)
        {
            return _db.Invoices
                .Where(i => !i.IsDeleted
                    && i.Status == "Đã thanh toán"
                    && i.IssueDate.Month == month
                    && i.IssueDate.Year == year)
                .OrderByDescending(i => i.IssueDate)
                .ToList();
        }

        // Lấy doanh thu theo từng tháng trong năm
        public Dictionary<int, decimal> GetMonthlyRevenueByYear(int year)
        {
            var result = new Dictionary<int, decimal>();

            for (int month = 1; month <= 12; month++)
            {
                var revenue = GetMonthlyRevenue(month, year);
                result.Add(month, revenue);
            }

            return result;
        }

        // Lấy top khách hàng theo doanh thu
        public List<dynamic> GetTopCustomersByRevenue(int topCount)
        {
            return _db.Invoices
                .Where(i => !i.IsDeleted && i.Status == "Đã thanh toán" && i.CustomerID.HasValue)
                .GroupBy(i => i.CustomerID)
                .Select(g => new
                {
                    CustomerID = g.Key,
                    TotalRevenue = g.Sum(i => i.TotalAmount),
                    InvoiceCount = g.Count()
                })
                .OrderByDescending(x => x.TotalRevenue)
                .Take(topCount)
                .ToList<dynamic>();
        }

        // Lấy doanh thu hôm nay - FIXED
        public decimal GetTodayRevenue()
        {
            // Tính toán ngày bên ngoài query
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            return _db.Invoices
                .Where(i => !i.IsDeleted
                    && i.Status == "Đã thanh toán"
                    && i.IssueDate >= today
                    && i.IssueDate < tomorrow)
                .Sum(i => (decimal?)i.TotalAmount) ?? 0;
        }

        // Lấy trung bình giá trị hóa đơn theo tháng
        public decimal GetAverageInvoiceValue(int month, int year)
        {
            var invoices = _db.Invoices
                .Where(i => !i.IsDeleted
                    && i.Status == "Đã thanh toán"
                    && i.IssueDate.Month == month
                    && i.IssueDate.Year == year)
                .ToList();

            if (invoices.Count == 0)
                return 0;

            return invoices.Average(i => i.TotalAmount ?? 0);
        }
    }
}