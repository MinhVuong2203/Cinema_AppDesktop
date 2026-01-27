using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using DTO;
using Microsoft.VisualBasic.Devices;

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

            // Khởi tạo giao diện
            InitializeUI();
            
            // Bắt đầu đồng hồ
            StartClock();
        }

        private void InitializeUI()
        {
            // Cập nhật thông điệp chào mừng với tên nhân viên
            lblWelcomeMessage.Text = $"Xin chào, {_employee.FullName}! 👋";
            
            // Thêm hiệu ứng hover cho các panel
            AddHoverEffect(panel_SaleTicket, Color.FromArgb(59, 130, 246));
            AddHoverEffect(panel_SaleProduct, Color.FromArgb(34, 197, 94));
        }

        /// <summary>
        /// Thêm hiệu ứng hover cho panel
        /// </summary>
        private void AddHoverEffect(Panel panel, Color accentColor)
        {
            Color originalColor = panel.BackColor;
            Color hoverColor = Color.FromArgb(248, 250, 252);

            panel.MouseEnter += (s, e) =>
            {
                panel.BackColor = hoverColor;
                panel.Cursor = Cursors.Hand;
            };

            panel.MouseLeave += (s, e) =>
            {
                panel.BackColor = originalColor;
            };

            // Thêm click event cho cả panel
            panel.Click += (s, e) =>
            {
                if (panel == panel_SaleTicket)
                    btn_SaleTicket_Click(s, e);
                else if (panel == panel_SaleProduct)
                    btn_SaleProduct_Click(s, e);
            };
        }

        /// <summary>
        /// Bắt đầu đồng hồ hiển thị thời gian
        /// </summary>
        private void StartClock()
        {
            UpdateDateTime();
            timerClock.Start();
        }

        /// <summary>
        /// Cập nhật ngày giờ
        /// </summary>
        private void TimerClock_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        /// <summary>
        /// Cập nhật hiển thị ngày giờ
        /// </summary>
        private void UpdateDateTime()
        {
            DateTime now = DateTime.Now;
            string dayOfWeek = now.ToString("dddd", new System.Globalization.CultureInfo("vi-VN"));
            
            // Viết hoa chữ cái đầu
            dayOfWeek = char.ToUpper(dayOfWeek[0]) + dayOfWeek.Substring(1);
            
            lblDateTime.Text = $"{dayOfWeek}, {now:dd/MM/yyyy} - {now:HH:mm:ss}";
        }

        private void btn_SaleTicket_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new SelectMovieUC(_home, _employee));
        }

        private void btn_SaleProduct_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new SaleProductUC(_home, _employee));
        }
    }
}
