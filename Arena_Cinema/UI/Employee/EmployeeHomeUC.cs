using Common;
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

namespace UI.Employee
{
    public partial class EmployeeHomeUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;

        public EmployeeHomeUC(Home form, DTO.Employee employee)
        {
            this._home = form;
            this._employee = employee;
            
            InitializeComponent();
            LoadThem();
        }

        private void LoadThem()
        {
            Color c = ColorHelper.Parse(_employee.Setting.MainColor);
            this.panelMain.BackColor = c;  
        }

        private void lblNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new ListEmployeeUC(_home, this._employee));    
        }

        private void btnWorkShift_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new WorkShiftUC(_home, this._employee));
        }

        private void parrotButton3_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new SalaryReportUC());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new OperationUC());
        }
    }
}
