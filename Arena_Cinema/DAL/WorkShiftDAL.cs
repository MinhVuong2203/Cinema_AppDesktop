using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BLL
{
    public class WorkShiftDAL
    {
        private CinemaDBContext _context;

        public WorkShiftDAL()
        {
            _context = new CinemaDBContext();
        }

        public List<WorkShift> GetAllWorkShifts()
        {
            try
            {
                return _context.WorkShifts
                    .Include(ws => ws.Employee)
                    .Include(ws => ws.Employee.Role)
                    .OrderByDescending(ws => ws.StartTime)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách ca làm từ database: {ex.Message}");
            }
        }

        public List<WorkShift> GetWorkShiftsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                return _context.WorkShifts
                    .Include(ws => ws.Employee)
                    .Include(ws => ws.Employee.Role)
                    .Where(ws => ws.StartTime >= startDate && ws.StartTime <= endDate)
                    .OrderBy(ws => ws.StartTime)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy ca làm theo ngày từ database: {ex.Message}");
            }
        }

        public List<WorkShift> GetWorkShiftsByEmployee(Guid employeeId)
        {
            try
            {
                return _context.WorkShifts
                    .Include(ws => ws.Employee)
                    .Include(ws => ws.Employee.Role)
                    .Where(ws => ws.EmployeeID == employeeId)
                    .OrderByDescending(ws => ws.StartTime)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy ca làm của nhân viên từ database: {ex.Message}");
            }
        }

        public WorkShift GetWorkShiftById(int shiftId)
        {
            try
            {
                return _context.WorkShifts
                    .Include(ws => ws.Employee)
                    .Include(ws => ws.Employee.Role)
                    .FirstOrDefault(ws => ws.ShiftID == shiftId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin ca làm từ database: {ex.Message}");
            }
        }

        public void AddWorkShift(WorkShift workShift)
        {
            try
            {
                _context.WorkShifts.Add(workShift);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm ca làm vào database: {ex.Message}");
            }
        }

        public void UpdateWorkShift(WorkShift workShift)
        {
            try
            {
                var existing = _context.WorkShifts.Find(workShift.ShiftID);
                if (existing == null)
                {
                    throw new Exception("Không tìm thấy ca làm cần cập nhật");
                }

                existing.EmployeeID = workShift.EmployeeID;
                existing.StartTime = workShift.StartTime;
                existing.EndTime = workShift.EndTime;
                existing.WorkingHours = workShift.WorkingHours;
                existing.SalaryPerHour = workShift.SalaryPerHour;
                existing.Status = workShift.Status;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật ca làm trong database: {ex.Message}");
            }
        }

        public void DeleteWorkShift(int shiftId)
        {
            try
            {
                var workShift = _context.WorkShifts.Find(shiftId);
                if (workShift == null)
                {
                    throw new Exception("Không tìm thấy ca làm cần xóa");
                }

                _context.WorkShifts.Remove(workShift);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa ca làm trong database: {ex.Message}");
            }
        }

        public List<WorkShift> GetWorkShiftsByStatus(string status)
        {
            try
            {
                return _context.WorkShifts
                    .Include(ws => ws.Employee)
                    .Include(ws => ws.Employee.Role)
                    .Where(ws => ws.Status == status)
                    .OrderBy(ws => ws.StartTime)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy ca làm theo trạng thái từ database: {ex.Message}");
            }
        }

        public bool HasShiftConflict(Guid employeeId, DateTime startTime, DateTime endTime, int? excludeShiftId = null)
        {
            try
            {
                var query = _context.WorkShifts
                    .Where(ws => ws.EmployeeID == employeeId &&
                                 ws.StartTime < endTime &&
                                 ws.EndTime > startTime);

                if (excludeShiftId.HasValue)
                {
                    query = query.Where(ws => ws.ShiftID != excludeShiftId.Value);
                }

                return query.Any();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi kiểm tra xung đột ca làm: {ex.Message}");
            }
        }

        public int GetTotalShiftsInMonth(Guid employeeId, int month, int year)
        {
            try
            {
                var startDate = new DateTime(year, month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);

                return _context.WorkShifts
                    .Count(ws => ws.EmployeeID == employeeId &&
                                 ws.StartTime >= startDate &&
                                 ws.StartTime <= endDate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đếm số ca làm trong tháng: {ex.Message}");
            }
        }

        public double GetTotalWorkingHoursInMonth(Guid employeeId, int month, int year)
        {
            try
            {
                var startDate = new DateTime(year, month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);

                return _context.WorkShifts
                    .Where(ws => ws.EmployeeID == employeeId &&
                                 ws.StartTime >= startDate &&
                                 ws.StartTime <= endDate &&
                                 ws.Status == "Hoàn thành")
                    .Sum(ws => (double?)ws.WorkingHours) ?? 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tính tổng giờ làm trong tháng: {ex.Message}");
            }
        }

        public List<WorkShift> GetShiftsNeedingUpdate()
        {
            try
            {
                var now = DateTime.Now;

                // Get shifts that should be "Đang làm" (started but not ended)
                var ongoingShifts = _context.WorkShifts
                    .Where(ws => ws.Status == "Sắp làm" &&
                                 ws.StartTime <= now &&
                                 ws.EndTime > now)
                    .ToList();

                // Get shifts that should be "Hoàn thành" (already ended)
                var completedShifts = _context.WorkShifts
                    .Where(ws => (ws.Status == "Đang làm" || ws.Status == "Sắp làm") &&
                                 ws.EndTime <= now)
                    .ToList();

                return ongoingShifts.Concat(completedShifts).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy ca làm cần cập nhật: {ex.Message}");
            }
        }

        public void AutoUpdateShiftStatuses()
        {
            try
            {
                var now = DateTime.Now;

                // Update to "Đang làm"
                var ongoingShifts = _context.WorkShifts
                    .Where(ws => ws.Status == "Sắp làm" &&
                                 ws.StartTime <= now &&
                                 ws.EndTime > now)
                    .ToList();

                foreach (var shift in ongoingShifts)
                {
                    shift.Status = "Đang làm";
                }

                // Update to "Hoàn thành"
                var completedShifts = _context.WorkShifts
                    .Where(ws => ws.Status == "Đang làm" &&
                                 ws.EndTime <= now)
                    .ToList();

                foreach (var shift in completedShifts)
                {
                    shift.Status = "Hoàn thành";
                }

                if (ongoingShifts.Any() || completedShifts.Any())
                {
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tự động cập nhật trạng thái ca làm: {ex.Message}");
            }
        }
    }
}
