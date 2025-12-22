using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class AccountDAL
    {
        private readonly CinemaDBContext _context;
        public AccountDAL()
        {
            _context = new CinemaDBContext();
        }
        public bool Login(string username, string password)
        {
                var account = _context.Accounts.FirstOrDefault(a => a.Username == username);
                if (account == null || string.IsNullOrEmpty(account.PasswordHash)) return false;
                return BCrypt.Net.BCrypt.Verify(password, account.PasswordHash);
        }

        public Employee GetEmployeeByUsername(string username)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.Username == username);
            if (account == null)
                return null;

            Guid employeeId = account.EmployeeID;

            return _context.Employees
                           .Include(e => e.Role)        // load role
                           .Include(e => e.Setting)    // load cấu hình
                           .Include(e => e.Operations)
                           .FirstOrDefault(e => e.EmployeeID == employeeId && !e.IsDeleted);
        }


    }
}
