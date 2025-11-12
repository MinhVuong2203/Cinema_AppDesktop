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
        
        public List<DTO.Employee> GetEmployeeBy(string Name, string Role, string Gender, bool isDelete)
        {
            return _employeeDAL.GetEmployeeBy(Name, Role, Gender, isDelete);
        }

    }
}
