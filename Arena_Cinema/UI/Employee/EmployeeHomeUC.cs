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
        public EmployeeHomeUC(DTO.Employee employee)
        {
            InitializeComponent();
        }

        private void lblNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
             this.Parent.Controls.Clear();
             this.Parent.Controls.Add(new ListEmployeeUC());
        }
    }
}
