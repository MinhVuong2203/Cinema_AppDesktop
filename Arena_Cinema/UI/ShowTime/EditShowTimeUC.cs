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
      
        public EditShowTimeUC()
        {
            InitializeComponent();
        }

    
        public EditShowTimeUC(Home home, DTO.Employee employee, DTO.ShowTime showTime) : this()
        {
            InitializeData(home, employee, showTime);
            LoadInitialData();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            ReaLTaiizor.Controls.MaterialTextBox txt = sender as ReaLTaiizor.Controls.MaterialTextBox;
            if (txt == null) return;

            string text = txt.Text;
            string filteredText = "";

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    filteredText += c;
                }
            }

          
            if (text != filteredText)
            {
                txt.Text = filteredText;
              
                txt.SelectionStart = filteredText.Length;
            }
        }
    }
}