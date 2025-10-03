using DAL;
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
        public EmployeeDAL EmployeeDAL = new EmployeeDAL();
        public EmployeeBLL(){}
        public Employee Login(string username, string password)
        {            
            return EmployeeDAL.getAccount(username, password);
        } 
    }
}
