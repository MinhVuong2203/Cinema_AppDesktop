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

        public bool SaveResetOtp(string username, string otpPlain, int expireMinutes = 10)
        {
            return _accountDAL.SaveResetOtp(username, otpPlain, expireMinutes);
        }

        public bool VerifyResetOtp(string username, string otpInput, int maxAttempts = 5)
        {
            return _accountDAL.VerifyResetOtp(username, otpInput, maxAttempts);
        }

        public bool ResetPasswordByOtp(string username, string otpInput, string newPassword, int maxAttempts = 5)
        {
            return _accountDAL.ResetPasswordByOtp(username, otpInput, newPassword, maxAttempts);
        }

        public int getResetOtpAttemptCount(string username) => _accountDAL.getResetOtpAttemptCount(username);
    }
}
