using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDAL
    {
        private readonly CinemaDBContext _context;
        public EmployeeDAL()
        {
            _context = new CinemaDBContext();
        }

        public List<Employee> GetAllEmployees()
        {
            try
            {
                using (var context = new CinemaDBContext())
                {
                    return context.Employees
                        .Include(e => e.Setting)
                        .Include(e => e.Role)
                        .Include(e => e.Operations)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetAllEmployees: {ex.Message}");
                return new List<Employee>();
            }
        }

        public Employee GetEmployeeById(Guid employeeId)
        {
            try
            {
                return _context.Employees
                    .Include(e => e.Account)
                    .Include(e => e.Role)
                    .FirstOrDefault(e => e.EmployeeID == employeeId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin nhân viên: {ex.Message}");
            }
        }

        public void UpdateEmployeeSettingById(Guid employeeId, Setting newSetting)
        {
            var existingEmployee = _context.Employees
                .Include(e => e.Setting)
                .FirstOrDefault(e => e.EmployeeID == employeeId);

            if (existingEmployee?.Setting != null)
            {
                existingEmployee.Setting.LanguageCode = newSetting.LanguageCode;
                existingEmployee.Setting.FontText = newSetting.FontText;
                existingEmployee.Setting.SizeText = newSetting.SizeText;
                existingEmployee.Setting.MainColor = newSetting.MainColor;

                _context.SaveChanges();  // ✅ EF hiểu là UPDATE, không INSERT
            }
        }



        public List<Employee> GetEmployeeBy(string name, string role, string gender, bool isDelete)
        {
            var query = _context.Employees.AsQueryable();

            query = query.Where(e => e.IsDeleted == isDelete);
            if (!string.IsNullOrWhiteSpace(name))
            {
                string lowerName = name.ToLower();
                query = query.Where(e => e.FullName.ToLower().Contains(lowerName));
            }
            if (!string.IsNullOrWhiteSpace(gender) && gender != "Tất cả")
                query = query.Where(e => e.Gender == gender);
            if (!string.IsNullOrWhiteSpace(role) && role != "Tất cả")
                query = query.Where(e => e.Role != null && e.Role.RoleName == role);
            return query.Include("Role").OrderBy(e => e.FullName).ToList();
        }


        public bool AddEmployee(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return true;
            }
            catch(DbUpdateException ex)
            {
                string errorMessage = GetFriendlyErrorMessage(ex);
                throw new Exception(errorMessage);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }

        }

        public bool UpdateEmployee(Employee input)
        {
            try
            {
                Employee existing = _context.Employees.Find(input.EmployeeID);
                if (existing == null)
                return false;

                existing.FullName = input.FullName;
                existing.CCCD = input.CCCD;
                existing.Phone = input.Phone;
                existing.Email = input.Email;
                existing.Address = input.Address;
                existing.BirthDate = input.BirthDate;
                existing.HourWage = input.HourWage;
                existing.Gender = input.Gender;
                existing.ImageUrl = input.ImageUrl;
                existing.RoleId = input.RoleId;
                existing.Account.Username = input.Account.Username;
                existing.Account.PasswordHash = input.Account.PasswordHash;
                existing.Account.RoleId = input.Account.RoleId;
                _context.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                string errorMessage = GetFriendlyErrorMessage(ex);
                throw new Exception(errorMessage);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }


        // để kiểm tra trùng
        private string GetFriendlyErrorMessage(DbUpdateException ex)
        {
            string innerMessage = ex.InnerException?.InnerException?.Message
                                  ?? ex.InnerException?.Message
                                  ?? ex.Message;

            // Kiểm tra lỗi UNIQUE constraint (không phân biệt hoa thường)
            if (innerMessage.IndexOf("UNIQUE KEY constraint", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                if (innerMessage.IndexOf("UQ__Employee__A955A0AA3FE40B90", StringComparison.OrdinalIgnoreCase) >= 0)
                    return "Số CCCD đã tồn tại trong hệ thống!";

                if (innerMessage.IndexOf("UQ__Employee__A9D10534488B0752", StringComparison.OrdinalIgnoreCase) >= 0)
                    return "Email đã tồn tại trong hệ thống!";

                if (innerMessage.IndexOf("UQ__Employee__5C7E359E0518E096", StringComparison.OrdinalIgnoreCase) >= 0)
                    return "Số điện thoại đã tồn tại trong hệ thống!";
            }

            // Nếu không khớp với trường hợp nào, trả về message chi tiết
            return "Lỗi cơ sở dữ liệu: " + innerMessage;
        }

        public bool DeleteEmployeeById(Guid employeeId)
        {
            try
            {
                Employee employee = _context.Employees.Find(employeeId);
                employee.IsDeleted = true;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public bool RestoreEmployeeById(Guid employeeId)
        {
            try
            {
                Employee employee = _context.Employees.Find(employeeId);
                employee.IsDeleted = false;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public List<Employee> GetAllEmployeesIsDelete()
        {
            try
            {
                return _context.Employees
                    .Include(e => e.Role)
                    .Where(e => !e.IsDeleted)
                    .OrderBy(e => e.FullName)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách nhân viên: {ex.Message}");
            }
        }

        public List<Employee> FilterEmployees(string name, string roleName, bool includeDeleted)
        {
            try
            {
                var query = _context.Employees.Include(e => e.Role).Where(e => e.Role.RoleName != "Admin").AsQueryable();
                if (!includeDeleted)
                {
                    query = query.Where(e => !e.IsDeleted);
                }
                if (!string.IsNullOrWhiteSpace(name))
                {
                    name = name.ToLower().Trim();
                    query = query.Where(e => e.FullName.ToLower().Contains(name));
                }
                if (!string.IsNullOrWhiteSpace(roleName) && roleName != "-- Tất cả --")
                {
                    query = query.Where(e => e.Role != null && e.Role.RoleName == roleName);
                }
                return query.OrderBy(e => e.FullName).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lọc nhân viên: {ex.Message}");
            }
        }

        public List<Employee> GetEmployeesByRole(string roleName)
        {
            try
            {
                return _context.Employees
                    .Include(e => e.Role)
                    .Where(e => !e.IsDeleted && e.Role != null && e.Role.RoleName == roleName)
                    .OrderBy(e => e.FullName)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy nhân viên theo chức vụ: {ex.Message}");
            }
        }

        public List<Employee> GetAvailableEmployees(DateTime startTime, DateTime endTime)
        {
            try
            {
                // Get all employees
                var allEmployees = _context.Employees
                    .Include(e => e.Role)
                    .Where(e => !e.IsDeleted)
                    .ToList();

                var busyEmployeeIds = _context.WorkShifts
                    .Where(ws => ws.StartTime < endTime && ws.EndTime > startTime)
                    .Select(ws => ws.EmployeeID)
                    .Distinct()
                    .ToList();

                return allEmployees
                    .Where(e => !busyEmployeeIds.Contains(e.EmployeeID))
                    .OrderBy(e => e.FullName)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy nhân viên khả dụng: {ex.Message}");
            }
        }

        public int GetActiveEmployeeCount()
        {
            try
            {
                return _context.Employees.Count(e => !e.IsDeleted);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đếm số nhân viên: {ex.Message}");
            }
        }

        public Dictionary<string, int> GetEmployeeCountByRole()
        {
            try
            {
                return _context.Employees
                    .Where(e => !e.IsDeleted && e.Role != null)
                    .GroupBy(e => e.Role.RoleName)
                    .ToDictionary(g => g.Key, g => g.Count());
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đếm nhân viên theo chức vụ: {ex.Message}");
            }
        }
    
    }
}
