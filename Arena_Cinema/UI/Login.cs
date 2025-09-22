using BLL;
using DTO;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using UI.Properties;



namespace UI
{
    public partial class Login : Form
    { 
        public TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        private string currentLang = "vi";

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

        private void ApplyLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentLang);
            //this.label1.Text = Properties.Resources.LblUsername_Text;
            //label2.Text = Properties.Resources.LblPassword_Text;
            //btnLogin.Text = Properties.Resources.BtnLogin_Text;
            //btnExit.Text = Properties.Resources.BtnCancel_Text;
            //this.Text = Properties.Resources.Login_Title;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeLang_Click(object sender, EventArgs e)
        {

        }
    }
}
