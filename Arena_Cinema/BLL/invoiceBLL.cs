using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class InvoiceBLL
    {
        private InvoiceDAL _invoiceDAL;

        public InvoiceBLL()
        {
            _invoiceDAL = new InvoiceDAL();
        }

        // Lấy tất cả hóa đơn
        public List<Invoice> GetAllInvoices()
        {
            return _invoiceDAL.GetAllInvoices();
        }

        // Lấy hóa đơn theo ID
        public Invoice GetInvoiceByID(Guid invoiceID)
        {
            return _invoiceDAL.GetInvoiceByID(invoiceID);
        }

        // Lấy doanh thu tháng hiện tại
        public decimal GetCurrentMonthRevenue()
        {
            DateTime now = DateTime.Now;
            return _invoiceDAL.GetMonthlyRevenue(now.Month, now.Year);
        }

        // Lấy doanh thu theo tháng
        public decimal GetMonthlyRevenue(int month, int year)
        {
            return _invoiceDAL.GetMonthlyRevenue(month, year);
        }

        // Lấy doanh thu năm hiện tại
        public decimal GetCurrentYearRevenue()
        {
            return _invoiceDAL.GetYearlyRevenue(DateTime.Now.Year);
        }

        // Tính phần trăm tăng trưởng so với tháng trước
        public decimal CalculateRevenueGrowth()
        {
            DateTime now = DateTime.Now;

            // Doanh thu tháng hiện tại
            decimal currentMonthRevenue = _invoiceDAL.GetMonthlyRevenue(now.Month, now.Year);

            // Doanh thu tháng trước
            DateTime lastMonth = now.AddMonths(-1);
            decimal lastMonthRevenue = _invoiceDAL.GetMonthlyRevenue(lastMonth.Month, lastMonth.Year);

            // Nếu tháng trước không có doanh thu
            if (lastMonthRevenue == 0)
            {
                return currentMonthRevenue > 0 ? 100 : 0;
            }

            // Tính phần trăm tăng trưởng
            decimal growth = ((currentMonthRevenue - lastMonthRevenue) / lastMonthRevenue) * 100;
            return Math.Round(growth, 2);
        }

        // Lấy số lượng hóa đơn tháng hiện tại
        public int GetCurrentMonthInvoiceCount()
        {
            DateTime now = DateTime.Now;
            return _invoiceDAL.GetMonthlyInvoiceCount(now.Month, now.Year);
        }

        // Lấy doanh thu hôm nay
        public decimal GetTodayRevenue()
        {
            return _invoiceDAL.GetTodayRevenue();
        }

        // Lấy trung bình giá trị hóa đơn tháng hiện tại
        public decimal GetCurrentMonthAverageInvoiceValue()
        {
            DateTime now = DateTime.Now;
            return _invoiceDAL.GetAverageInvoiceValue(now.Month, now.Year);
        }

        // Format tiền tệ
        public string FormatCurrency(decimal amount)
        {
            return amount.ToString("#,##0") + " ₫";
        }

        // Format phần trăm
        public string FormatPercentage(decimal percentage)
        {
            string sign = percentage >= 0 ? "+" : "";
            return sign + percentage.ToString("0.00") + "%";
        }

        // Lấy dữ liệu thống kê tổng hợp
        public Dictionary<string, object> GetDashboardStatistics()
        {
            DateTime now = DateTime.Now;

            var stats = new Dictionary<string, object>
            {
                ["MonthlyRevenue"] = GetCurrentMonthRevenue(),
                ["RevenueGrowth"] = CalculateRevenueGrowth(),
                ["InvoiceCount"] = GetCurrentMonthInvoiceCount(),
                ["TodayRevenue"] = GetTodayRevenue(),
                ["AverageInvoiceValue"] = GetCurrentMonthAverageInvoiceValue(),
                ["YearlyRevenue"] = GetCurrentYearRevenue(),
                ["CurrentMonth"] = now.ToString("MM/yyyy"),
                ["CurrentDate"] = now.ToString("dd/MM/yyyy")
            };

            return stats;
        }

        // Lấy doanh thu theo từng tháng trong năm
        public Dictionary<int, decimal> GetMonthlyRevenueByYear(int year)
        {
            return _invoiceDAL.GetMonthlyRevenueByYear(year);
        }

        // Lấy top khách hàng
        public List<dynamic> GetTopCustomersByRevenue(int topCount = 10)
        {
            return _invoiceDAL.GetTopCustomersByRevenue(topCount);
        }

        // Kiểm tra xu hướng tăng trưởng
        public string GetGrowthTrend()
        {
            decimal growth = CalculateRevenueGrowth();

            if (growth > 0)
                return "Tăng";
            else if (growth < 0)
                return "Giảm";
            else
                return "Không đổi";
        }

        // Lấy màu sắc cho hiển thị tăng trưởng (trả về string hex color)
        public string GetGrowthColorHex()
        {
            decimal growth = CalculateRevenueGrowth();

            if (growth > 0)
                return "#008000"; // Green
            else if (growth < 0)
                return "#FF0000"; // Red
            else
                return "#808080"; // Gray
        }

        // Lấy màu sắc cho hiển thị tăng trưởng (trả về Color object)
        public System.Drawing.Color GetGrowthColor()
        {
            decimal growth = CalculateRevenueGrowth();

            if (growth > 0)
                return System.Drawing.Color.Green;
            else if (growth < 0)
                return System.Drawing.Color.Red;
            else
                return System.Drawing.Color.Gray;
        }
    }
}