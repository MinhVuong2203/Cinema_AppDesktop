using BLL;
using Common;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        private AccountBLL _accountBLL = new AccountBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "" || tbUsername.Text == "") return;
            DTO.Employee em = _accountBLL.Login(tbUsername.Text, tbPassword.Text.Trim());

            if (em != null)
            {
                if (em.Role.RoleName == "Admin")
                {
                    // Set ngôn ngữ
                    //Thread.CurrentThread.CurrentCulture = new CultureInfo(em.Settings.Language);
                    // Mở form Home
                    this.Hide();
                    Home homeForm = new Home(em);
                    homeForm.FormClosed += (s, args) => this.Close(); // Đóng form Login khi form Home đóng
                    homeForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập");

            }
        }

        private void skyButton1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (this.isShow)
            {
                this.btnShowPass.ButtonImage = global::UI.Properties.Resources.CloseEyes;
                this.tbPassword.UseSystemPasswordChar = true;
                isShow = false;
            }
            else
            {
                this.btnShowPass.ButtonImage = global::UI.Properties.Resources.OpenEyes1;
                this.tbPassword.UseSystemPasswordChar = false;
                isShow = true;
            }
                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbForgot_MouseEnter(object sender, EventArgs e)
        {
            this.lbForgot.ForeColor = Color.Red;
        }

        private void lbForgot_MouseLeave(object sender, EventArgs e)
        {
            this.lbForgot.ForeColor = Color.Black;
        }

        private void lbForgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot f = new Forgot();
            f.Show();   
        }
    }
}
