using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PassChange : Form
    {
        public EmployeeBLL employeeBLL = new EmployeeBLL();
        public AccountBLL accountBLL = new AccountBLL();
        private DTO.Employee employee;
        public PassChange(DTO.Employee employee) 
        {
            this.employee = employee;
            InitializeComponent();
            this.lbUsername.Text = this.employee.Account.Username;
        }

        private void skyOk_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();  
            string confirm = txtReenterPassword.Text.Trim();
            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtOTP.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã OTP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool verifyResetOtp = accountBLL.VerifyResetOtp(employee.Account.Username, txtOTP.Text.Trim());
            if (!verifyResetOtp)
            {
                int ResetOtpAttemptCount = accountBLL.getResetOtpAttemptCount(employee.Account.Username);
                if ((5 - ResetOtpAttemptCount) < 0)
                {
                    MessageBox.Show("Đã quá số lần nhập OTP!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Mã OTP không hợp lệ hoặc đã hết hạn!\nBạn còn " + (5 - ResetOtpAttemptCount) + " lần nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = accountBLL.ResetPasswordByOtp(employee.Account.Username, txtOTP.Text.Trim(), password);
            if (result )
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Login().Show();
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void skyButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtOTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtOTP_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (char.IsControl(e.KeyChar))
                return;
             if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string pwd = txtPassword.Text;
            bool lengthOk = pwd.Length >= 6;
            bool hasUpper = pwd.Any(char.IsUpper);
            bool hasLower = pwd.Any(char.IsLower);
            bool hasSpecial = pwd.Any(ch => !char.IsLetterOrDigit(ch)); 
            bool ok = lengthOk && hasUpper && hasLower && hasSpecial;
            // Ví dụ: hiển thị trạng thái
            lblPasswordRule.Text = ok
                ? "Mật khẩu hợp lệ"
                : "Tối thiểu 6 ký tự, gồm chữ hoa, chữ thường và ký tự đặc biệt.";
            lblPasswordRule.ForeColor = ok ? Color.Green : Color.Red;     
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forgot forgot = new Forgot(this.employee.Email, this.employee.CCCD);
            forgot.Show();
        }
    }
}
