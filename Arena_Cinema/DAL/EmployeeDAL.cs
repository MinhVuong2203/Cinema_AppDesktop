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

        public List<DTO.Employee> GetAllEmployees()
        {
            return _context.Employees
                .Include(e => e.Setting)
                .Include(e => e.Role)
                .ToList();
        }

        public Employee GetEmployeeById(Guid employeeId)
        {
            return _context.Employees
                .Include(e => e.Account)
                .Include(e => e.Role)
                .FirstOrDefault(e => e.EmployeeID == employeeId);
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



    }
}
