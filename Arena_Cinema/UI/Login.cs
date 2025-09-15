using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace UI
{
    public partial class Login : Form
    { 
        public TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = tbUsername.Text;
            string pass = tbPassword.Text;
            TaiKhoan taiKhoan = taiKhoanBLL.Login(user, pass);
            if (taiKhoan != null)
            {
                MessageBox.Show("Đăng nhập thành công với thông tin! " + taiKhoan.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
