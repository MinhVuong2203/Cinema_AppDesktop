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

namespace UI.Revenue
{
    public partial class Main_RevenueUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        public Main_RevenueUC(Home home, DTO.Employee employee)
        {
            InitializeComponent();
            _home = home;
            _employee = employee;
        }

        private void Main_RevenueUC_Load(object sender, EventArgs e)
        {

        }
    }
}
