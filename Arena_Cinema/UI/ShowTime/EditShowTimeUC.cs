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
using UI.Employee;
using UI.Movie;

namespace UI.ShowTime
{
  
    public partial class EditShowTimeUC : UserControl
    {
        // Constructor mặc định (BẮT BUỘC cho Designer)
        public EditShowTimeUC()
        {
            InitializeComponent();
        }

    
        public EditShowTimeUC(Home home, DTO.Employee employee, DTO.ShowTime showTime) : this()
        {
            InitializeData(home, employee, showTime);
            LoadInitialData();
        }
    }
}