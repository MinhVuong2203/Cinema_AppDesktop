using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBLL
    {
        private DAL.EmployeeDAL _employeeDAL;
        public EmployeeBLL()
        {
            _employeeDAL = new DAL.EmployeeDAL();
        }
        public List<DTO.Employee> GetAllEmployees()
        {
            return _employeeDAL.GetAllEmployees();
        }

        public List<DTO.Employee> GetAllEmployeesIsDelete()
        {
            return _employeeDAL.GetAllEmployeesIsDelete();
        }

        public List<DTO.Employee> FilterEmployees(string name, string roleName, bool includeDeleted = false)
        {
            return _employeeDAL.FilterEmployees(name, roleName, includeDeleted);
        }

        public List<DTO.Employee> GetEmployeeBy(string Name, string Role, string Gender, bool isDelete)
        {
            return _employeeDAL.GetEmployeeBy(Name, Role, Gender, isDelete);
        }

        public bool AddEmployee(DTO.Employee employee) { 
            return _employeeDAL.AddEmployee(employee);
        }
        public bool UpdateEmployee(DTO.Employee employee)
        {
            return _employeeDAL.UpdateEmployee(employee);
        }

        public Employee GetEmployeeById(Guid id)
        {
            return _employeeDAL.GetEmployeeById(id);
        }

        public List<DTO.Employee> GetEmployeesByRole(string roleName)
        {
            return _employeeDAL.GetEmployeesByRole(roleName);
        }

        public List<DTO.Employee> GetAvailableEmployees(DateTime startTime, DateTime endTime)
        {
            return _employeeDAL.GetAvailableEmployees(startTime, endTime);
        }

        public int GetActiveEmployeeCount()
        {
              return _employeeDAL.GetActiveEmployeeCount();
        }

        public bool DeleteSoftwareById(Guid employeeId)
        {
            return _employeeDAL.DeleteEmployeeById(employeeId);
        }

        public bool RestoreEmployeeById(Guid employeeId)
        {
            return _employeeDAL.RestoreEmployeeById(employeeId);
        }

        public Dictionary<string, int> GetEmployeeCountByRole()
        {
            return _employeeDAL.GetEmployeeCountByRole();
        }

        // Cung cấp cho chức năng quên mật khẩu
        public Employee GetByEmailAndCCCD(string email, string cccd)
        {
            try
            {
                return _employeeDAL.GetByEmailAndCCCD(email, cccd);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
