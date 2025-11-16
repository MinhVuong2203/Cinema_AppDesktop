
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

namespace UI.Movie
{
    public partial class AddMovieUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;

        public AddMovieUC(Home home, DTO.Employee employee)
        {
            _home = home;
            _employee = employee;
            InitializeComponent();
            grb_Movie.Left = (panelMain.Width - grb_Movie.Width) / 2;
            this.Resize += (s, e) => grb_Movie.Left = (panelMain.Width - grb_Movie.Width) / 2;
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Movie_MainUC movieMain = new Movie_MainUC(_home, _employee);
            _home.LoadControl(movieMain);
        }
    }
}