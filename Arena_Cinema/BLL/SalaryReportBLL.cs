using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SalaryReportBLL
    {
        private readonly EmployeeDAL _employeeDAL;
        private readonly WorkShiftBLL _workShiftBLL;

        // Class nội bộ, không cần tạo file DTO riêng
        public class ReportItem
        {
            public Employee Employee { get; set; }
            public int Completed { get; set; }   // Hoàn thành
            public int Working { get; set; }     // Đang làm
            public int Absent { get; set; }      // Vắng
            public int Leave { get; set; }       // Nghỉ phép
            public int Total { get; set; }       // Tổng ca
            public decimal Salary { get; set; }  // Lương
        }

        public SalaryReportBLL()
        {
            _employeeDAL = new EmployeeDAL();
            _workShiftBLL = new WorkShiftBLL();
        }

        /// <summary>
        /// Lấy báo cáo lương + hiệu suất làm việc theo khoảng ngày.
        /// </summary>
        public List<ReportItem> GetSalaryReport(
            DateTime startDate,
            DateTime endDate,
            string roleFilter = null,
            string nameFilter = null)
        {
            startDate = startDate.Date;
            endDate = endDate.Date.AddDays(1).AddTicks(-1); // inclusive

            // Lọc nhân viên (reuse hàm FilterEmployees)
            var employees = _employeeDAL.FilterEmployees(
                nameFilter,
                string.IsNullOrWhiteSpace(roleFilter) || roleFilter == "-- Tất cả --"
                    ? null
                    : roleFilter,
                includeDeleted: false);

            // Lấy toàn bộ WorkShift trong khoảng ngày
            var shifts = _workShiftBLL.GetWorkShiftsByDateRange(startDate, endDate);

            var report = new List<ReportItem>();

            foreach (var emp in employees)
            {
                var empShifts = shifts.Where(ws => ws.EmployeeID == emp.EmployeeID).ToList();

                int completed = empShifts.Count(ws => ws.Status == "Hoàn thành");
                int working = empShifts.Count(ws => ws.Status == "Đang làm");
                int absent = empShifts.Count(ws => ws.Status == "Vắng");
                int leave = empShifts.Count(ws => ws.Status == "Nghỉ phép");
                int total = empShifts.Count;

                // Tính lương: WorkingHours * SalaryPerHour (nếu null thì 0)
                decimal salary = 0;
                foreach (var ws in empShifts)
                {
                    double hours = ws.WorkingHours ?? 0;
                    decimal rate = ws.SalaryPerHour ?? (emp.HourWage ?? 0);
                    salary += (decimal)hours * rate;
                }

                report.Add(new ReportItem
                {
                    Employee = emp,
                    Completed = completed,
                    Working = working,
                    Absent = absent,
                    Leave = leave,
                    Total = total,
                    Salary = salary
                });
            }

            // Sắp xếp theo lương giảm dần
            return report
                .OrderByDescending(r => r.Salary)
                .ThenBy(r => r.Employee.FullName)
                .ToList();
        }
    }
}
