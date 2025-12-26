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

        // Phục vụ cho gửi mã OTP khi quên mật khẩu
        public bool SaveResetOtp(string username, string otpPlain, int expireMinutes = 10)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.Username == username);
            if (account == null) return false;
            account.ResetOtpHash = BCrypt.Net.BCrypt.HashPassword(otpPlain, workFactor: 10);
            account.ResetOtpExpiresAt = DateTime.UtcNow.AddMinutes(expireMinutes);
            account.ResetOtpAttemptCount = 0;
            _context.SaveChanges();
            return true;
        }
        // Hàm verify OTP + tăng AttemptCount khi sai
        public bool VerifyResetOtp(string username, string otpInput, int maxAttempts = 5)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.Username == username);
            if (account == null) return false;
            if (string.IsNullOrEmpty(account.ResetOtpHash) || account.ResetOtpExpiresAt == null)
                return false;
            if (DateTime.UtcNow > account.ResetOtpExpiresAt.Value)
                return false;

            if (account.ResetOtpAttemptCount >= maxAttempts)
                return false;
            bool ok = BCrypt.Net.BCrypt.Verify(otpInput, account.ResetOtpHash);
            if (!ok)
            {
                account.ResetOtpAttemptCount += 1;
                _context.SaveChanges();
                return false;
            }
            return true;
        }
        // Hàm reset mật khẩu bằng OTP + clear OTP
        public bool ResetPasswordByOtp(string username, string otpInput, string newPassword, int maxAttempts = 5)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.Username == username);
            if (account == null) return false;

            if (string.IsNullOrEmpty(account.ResetOtpHash) || account.ResetOtpExpiresAt == null)
                return false;

            if (DateTime.UtcNow > account.ResetOtpExpiresAt.Value)
                return false;

            if (account.ResetOtpAttemptCount >= maxAttempts)
                return false;

            bool ok = BCrypt.Net.BCrypt.Verify(otpInput, account.ResetOtpHash);
            if (!ok)
            {
                account.ResetOtpAttemptCount += 1;
                _context.SaveChanges();
                return false;
            }

            // OTP đúng -> update mật khẩu
            account.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            // clear OTP
            account.ResetOtpHash = null;
            account.ResetOtpExpiresAt = null;
            account.ResetOtpAttemptCount = 0;

            _context.SaveChanges();
            return true;
        }

        // lấy số lần sai OTP
        public int getResetOtpAttemptCount(string username)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.Username == username);
            if (account == null) return -1;
            return account.ResetOtpAttemptCount;
        }
    }
}
