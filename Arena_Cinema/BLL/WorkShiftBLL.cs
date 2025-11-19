using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WorkShiftBLL
    {
        private WorkShiftDAL _workShiftDAL;

        public WorkShiftBLL()
        {
            _workShiftDAL = new WorkShiftDAL();
        }

        public List<WorkShift> GetAllWorkShifts()
        {
            try
            {
                return _workShiftDAL.GetAllWorkShifts();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách ca làm: {ex.Message}");
            }
        }

        public List<WorkShift> GetWorkShiftsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                if (startDate > endDate)
                {
                    throw new Exception("Ngày bắt đầu không thể lớn hơn ngày kết thúc");
                }

                return _workShiftDAL.GetWorkShiftsByDateRange(startDate, endDate.AddDays(1).AddSeconds(-1));
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy ca làm theo ngày: {ex.Message}");
            }
        }

        public List<WorkShift> GetWorkShiftsByEmployee(Guid employeeId)
        {
            try
            {
                return _workShiftDAL.GetWorkShiftsByEmployee(employeeId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy ca làm của nhân viên: {ex.Message}");
            }
        }

        public List<WorkShift> GetWorkShiftsByEmployee(Guid employeeId, DateTime startDate, DateTime endDate)
        {
            try
            {
                return _workShiftDAL.GetWorkShiftsByEmployee(employeeId)
                    .Where(ws => ws.StartTime >= startDate && ws.StartTime <= endDate.AddDays(1).AddSeconds(-1))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy ca làm của nhân viên theo ngày: {ex.Message}");
            }
        }

        public WorkShift GetWorkShiftById(int shiftId)
        {
            try
            {
                return _workShiftDAL.GetWorkShiftById(shiftId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin ca làm: {ex.Message}");
            }
        }

        public void AddWorkShift(WorkShift workShift)
        {
            try
            {
                // Validate
                ValidateWorkShift(workShift);

                // Check conflict
                if (HasConflict(workShift))
                {
                    throw new Exception("Nhân viên đã có ca làm trong khoảng thời gian này");
                }

                _workShiftDAL.AddWorkShift(workShift);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm ca làm: {ex.Message}");
            }
        }

        public void UpdateWorkShift(WorkShift workShift)
        {
            try
            {
                // Validate
                ValidateWorkShift(workShift);

                // Check conflict (exclude current shift)
                if (HasConflict(workShift, workShift.ShiftID))
                {
                    throw new Exception("Nhân viên đã có ca làm trong khoảng thời gian này");
                }

                _workShiftDAL.UpdateWorkShift(workShift);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật ca làm: {ex.Message}");
            }
        }

        public void DeleteWorkShift(int shiftId)
        {
            try
            {
                var workShift = _workShiftDAL.GetWorkShiftById(shiftId);
                if (workShift == null)
                {
                    throw new Exception("Không tìm thấy ca làm");
                }

                // Chỉ cho phép xóa ca có trạng thái "Sắp làm"
                if (workShift.Status != "Sắp làm")
                {
                    throw new Exception("Chỉ có thể xóa ca làm có trạng thái 'Sắp làm'");
                }

                _workShiftDAL.DeleteWorkShift(shiftId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa ca làm: {ex.Message}");
            }
        }

        public void UpdateShiftStatus(int shiftId, string status)
        {
            try
            {
                var workShift = _workShiftDAL.GetWorkShiftById(shiftId);
                if (workShift == null)
                {
                    throw new Exception("Không tìm thấy ca làm");
                }

                // Validate status
                var validStatuses = new[] { "Đang làm", "Sắp làm", "Hoàn thành", "Vắng", "Nghỉ phép" };
                if (!validStatuses.Contains(status))
                {
                    throw new Exception("Trạng thái không hợp lệ");
                }

                workShift.Status = status;
                _workShiftDAL.UpdateWorkShift(workShift);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật trạng thái: {ex.Message}");
            }
        }

        public Dictionary<Guid, double> CalculateMonthlyWorkingHours(int month, int year)
        {
            try
            {
                var startDate = new DateTime(year, month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);

                var shifts = _workShiftDAL.GetWorkShiftsByDateRange(startDate, endDate)
                    .Where(ws => ws.Status == "Hoàn thành")
                    .GroupBy(ws => ws.EmployeeID)
                    .ToDictionary(
                        g => g.Key,
                        g => g.Sum(ws => ws.WorkingHours ?? 0)
                    );

                return shifts;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tính giờ làm: {ex.Message}");
            }
        }

        public Dictionary<Guid, decimal> CalculateMonthlySalary(int month, int year)
        {
            try
            {
                var startDate = new DateTime(year, month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);

                var salaries = _workShiftDAL.GetWorkShiftsByDateRange(startDate, endDate)
                    .Where(ws => ws.Status == "Hoàn thành")
                    .GroupBy(ws => ws.EmployeeID)
                    .ToDictionary(
                        g => g.Key,
                        g => g.Sum(ws => (ws.WorkingHours ?? 0) * (double)(ws.SalaryPerHour ?? 0))
                    );

                return salaries.ToDictionary(kvp => kvp.Key, kvp => (decimal)kvp.Value);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tính lương: {ex.Message}");
            }
        }

        private void ValidateWorkShift(WorkShift workShift)
        {
            if (workShift.EmployeeID == Guid.Empty)
            {
                throw new Exception("Nhân viên không hợp lệ");
            }

            if (workShift.StartTime >= workShift.EndTime)
            {
                throw new Exception("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc");
            }

            if (workShift.StartTime < DateTime.Now.AddDays(-30))
            {
                throw new Exception("Không thể tạo ca làm quá 30 ngày trong quá khứ");
            }

            // Calculate working hours
            workShift.WorkingHours = (workShift.EndTime - workShift.StartTime).TotalHours;

            if (workShift.WorkingHours > 12)
            {
                throw new Exception("Ca làm không được vượt quá 12 giờ");
            }

            // Validate status
            var validStatuses = new[] { "Đang làm", "Sắp làm", "Hoàn thành", "Vắng", "Nghỉ phép" };
            if (!string.IsNullOrEmpty(workShift.Status) && !validStatuses.Contains(workShift.Status))
            {
                throw new Exception("Trạng thái không hợp lệ");
            }

            // Set default status if empty
            if (string.IsNullOrEmpty(workShift.Status))
            {
                workShift.Status = "Sắp làm";
            }
        }

        private bool HasConflict(WorkShift workShift, int? excludeShiftId = null)
        {
            var existingShifts = _workShiftDAL.GetWorkShiftsByEmployee(workShift.EmployeeID);

            foreach (var shift in existingShifts)
            {
                // Skip the current shift when updating
                if (excludeShiftId.HasValue && shift.ShiftID == excludeShiftId.Value)
                    continue;

                // Check for time overlap
                if (workShift.StartTime < shift.EndTime && workShift.EndTime > shift.StartTime)
                {
                    return true;
                }
            }

            return false;
        }

        public List<WorkShift> GetUpcomingShifts(Guid employeeId, int days = 7)
        {
            try
            {
                var startDate = DateTime.Now;
                var endDate = DateTime.Now.AddDays(days);

                return _workShiftDAL.GetWorkShiftsByEmployee(employeeId)
                    .Where(ws => ws.StartTime >= startDate && ws.StartTime <= endDate && ws.Status == "Sắp làm")
                    .OrderBy(ws => ws.StartTime)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy ca làm sắp tới: {ex.Message}");
            }
        }

        public List<WorkShift> GetTodayShifts()
        {
            try
            {
                var today = DateTime.Today;
                return _workShiftDAL.GetWorkShiftsByDateRange(today, today.AddDays(1).AddSeconds(-1))
                    .Where(ws => ws.Status == "Đang làm" || ws.Status == "Sắp làm")
                    .OrderBy(ws => ws.StartTime)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy ca làm hôm nay: {ex.Message}");
            }
        }
    }
}
