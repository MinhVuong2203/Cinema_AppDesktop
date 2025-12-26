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
    public partial class Forgot : Form
    {
        public EmployeeBLL employeeBLL = new EmployeeBLL();
        public AccountBLL accountBLL = new AccountBLL();
        public Forgot()
        {
            InitializeComponent();
        }

        private void skyButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void skyButton2_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string cccd = txtCCCD.Text.Trim();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(cccd))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTO.Employee employee = employeeBLL.GetByEmailAndCCCD(email, cccd);
            if (employee != null)
            {
                DialogResult rs = MessageBox.Show($"Tài khoản: {employee.Account.Username}\nBạn có muốn chúng tôi cung cấp lại mật khẩu cho tài khoản này thông qua email", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {  
                    if (employee.Account.ResetOtpExpiresAt.HasValue && employee.Account.ResetOtpExpiresAt.Value > DateTime.UtcNow)
                    {
                        MessageBox.Show("Mã OTP đặt lại mật khẩu cũ vẫn còn hiệu lực.\nVui lòng kiểm tra email của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PassChange passChange = new PassChange(employee);
                        passChange.Show();
                        this.Hide();
                    }
                    else
                    {
                        try
                        {
                            string otp = Common.ValidateHepler.GenerateRandomNumber(6);
                            accountBLL.SaveResetOtp(employee.Account.Username, otp);
                            string from = "vuonghihihihi@gmail.com";
                            string appPass = "wnar syti nzpy pbbz"; // App Password 16 ký tự (có khoảng trắng cũng được)
                            string to = txtEmail.Text.Trim();
                            string subject = "Mã OTP đặt lại mật khẩu";
                            string body = $"<p>Mã OTP của bạn là: <b>{otp}</b> (hiệu lực 10 phút).</p>";
                            MailHelper.SendGmail(from, appPass, to, subject, body);
                            MessageBox.Show("Đã gửi email OTP.\nVui lòng kiểm tra email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PassChange passChange = new PassChange(employee);
                            passChange.Show();
                            this.Hide();
                            // TODO: lưu ResetOtpHash/ExpiresAt vào DB
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Gửi email thất bại: " + ex.Message);
                        }
                    }
                }
            }   
            else
            {
                MessageBox.Show("Thông tin không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
