using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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
            return _context.Employees.FirstOrDefault(e => e.EmployeeID == employeeId);
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


    }
}
