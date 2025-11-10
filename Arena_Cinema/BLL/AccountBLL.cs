using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        private AccountDAL _accountDAL;
        
        public AccountBLL() { 
            _accountDAL = new AccountDAL();
        }

        public Employee Login(string username, string password)
        {
            if(_accountDAL.Login(username, password))
            {
                return _accountDAL.GetEmployeeByUsername(username);
            } 
            else
            {
                return null;
            }
        }
    }
}
