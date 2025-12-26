using BLL;
using DTO;
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
    public partial class InputOTP : Form
    {
        private DTO.Employee _employee;

        private EmployeeBLL employeeBLL;

        public InputOTP(DTO.Employee employee)
        {
            this._employee = employee;
            InitializeComponent();
        }

        private void skyButton_Click(object sender, EventArgs e)
        {
            string text = txtOTP.Text.Trim();
            string btnText = (sender as Control).Text;
            if (btnText == "❌")
            {
                if (text.Length > 0)
                {
                    text = text.Substring(0, text.Length - 1);
                }
                txtOTP.Text = text;  
            }
            else if (btnText == "✓")
            {
                this.employeeBLL = new EmployeeBLL();
                DTO.Employee emp = employeeBLL.GetEmployeeById(_employee.EmployeeID);
                if (BCrypt.Net.BCrypt.Verify(text, emp.Account.ResetOtpHash))
                {
                    PassChange pc = new PassChange(emp);
                    pc.Show();
                }                    
                else
                    MessageBox.Show("Sai mã OTP!\nBạn còn " + (5-_employee.Account.ResetOtpAttemptCount) + " lượt nhập!");
            }
            else
            {
                text += btnText;
                txtOTP.Text = text;
            }
        }
    }
}
