using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.ShowTime
{
    public partial class MNShowTimeUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private List<ReaLTaiizor.Controls.ParrotButton> pageButtons = new List<ReaLTaiizor.Controls.ParrotButton>();
        private const int MAX_VISIBLE_PAGES = 10;

        public MNShowTimeUC(Home home, DTO.Employee employee)
        {
            InitializeComponent();
            _home = home;
            _employee = employee;
        }

        private void MNShowTimeUC_Load(object sender, EventArgs e)
        {
            LoadInitialData();
        }

        private void btnAddShowtime_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new AddShowTimeUC(_home, _employee));
        }

        private void dgvShowtimes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
        }

    }
}