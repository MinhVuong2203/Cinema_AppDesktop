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
    public partial class ChooseMonth : Form
    {
        private DateTimePicker _start;
        private DateTimePicker _end;
        public ChooseMonth(DateTimePicker start, DateTimePicker end)
        {
            _start = start;
            _end = end;
            InitializeComponent();
        }

        private void skyButton1_Click(object sender, EventArgs e)
        {
            if (sender is Control btn && int.TryParse(btn.Text.Trim(), out int month))
            {
                var t = new DateTime(DateTime.Today.Year, month, 1);
                _start.Value = t;

                // chuẩn tháng: đến ngày cuối tháng
                _end.Value = t.AddMonths(1).AddDays(-1);
            }
        }

    }
}
