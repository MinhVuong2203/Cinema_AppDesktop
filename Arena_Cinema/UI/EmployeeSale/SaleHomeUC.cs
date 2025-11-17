using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace UI.EmployeeSale
{
    public partial class SaleHomeUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        public SaleHomeUC(Home home, DTO.Employee employee)
        {
            InitializeComponent();
            _home = home;
            _employee = employee;

            //load dữ liệu nhân viên
            LoadEmployeeData(employee);
        }

        //Load dữ liệu nhân viên
        public void LoadEmployeeData(DTO.Employee employee)
        {
            picAVT.ImageLocation = employee.ImageUrl;
            lb_EmName.Text = employee.FullName;
            lb_EmpIDText.Text = employee.EmployeeID.ToString();
            lb_BranchText.Text = employee.Address;
            lb_EmailText.Text = employee.Email;
            lb_PhoneText.Text = employee.Phone;
            lb_BthDayText.Text = employee.BirthDate?.ToString("dd/MM/yyyy") ?? "N/A";
            lb_SalaryText.Text = employee.HourWage?.ToString("C") ?? "N/A";
            lb_workDateText.Text = employee.RegisterDate?.ToString("dd/MM/yyyy") ?? "N/A";
        }

        private void btn_SaleTicket_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new SelectMovieUC(_home, this._employee));
        }
    }
}
