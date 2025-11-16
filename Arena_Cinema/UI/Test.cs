using DAL;
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
    public partial class Test : Form
    {
        private SeatDAL seatDAL = new SeatDAL();
        public Test()
        {
            InitializeComponent();
        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            Seat s = seatDAL.getAllSeatById(1);
            MessageBox.Show(s.pX + " " + s.pY );
        }
    }
}
