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
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "" || tbUsername.Text == "") return;
            EmployeeBLL employeeBLL = new EmployeeBLL();
            Employee employee = employeeBLL.Login(tbUsername.Text, tbPassword.Text);
            if (employee != null)
            {
                MessageBox.Show(
                "Đăng nhập thành công với tư cách " + employee.Role,
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
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
    }
}
