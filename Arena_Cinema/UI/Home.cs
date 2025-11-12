using Common;
using DTO;
using Microsoft.VisualBasic;
using ReaLTaiizor.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using UI.Employee;
using UI.Setting;
using UI.Movie;

namespace UI
{
    public partial class Home : Form
    {
        private bool isCollapsed = false;
        private Timer sidebarTimer;
        private int sidebarExpandedWidth = 220;
        private int sidebarCollapsedWidth = 80;
        private ParrotButton selectedButton = null;



        public DTO.Employee _employee { get; set; }

        public Home(DTO.Employee employee)
        {
            _employee = employee;
            LanguageHelper.ChangeLanguage(employee.Setting.LanguageCode);
            InitializeComponent();
            InitializeSidebarAnimation();

        }

        private void InitializeSidebarAnimation()
        {
            sidebarTimer = new Timer();
            sidebarTimer.Interval = 10; // tốc độ animation
            sidebarTimer.Tick += SidebarTimer_Tick;
        }



        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                // mở rộng sidebar
                pnMenu.Width += 52;
                if (pnMenu.Width >= sidebarExpandedWidth)
                {
                    sidebarTimer.Stop();
                    isCollapsed = false;
                    ShowButtonText(true);
                }
            }
            else
            {
                // thu gọn sidebar
                ShowButtonText(false);
                pnMenu.Width -= 52;
                if (pnMenu.Width <= sidebarCollapsedWidth)
                {
                    sidebarTimer.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void ShowButtonText(bool visible)
        {
            foreach (Control ctrl in pnMenu.Controls)
            {
                if (ctrl is CyberButton btn)
                {
                    btn.TextButton = visible ? btn.Tag.ToString() : "";
                    btn.Refresh();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }


        private void MenuItem_Click(object sender, EventArgs e)
        {
            ParrotButton clickedButton = sender as ParrotButton;
            if (clickedButton == null) return;

            // Reset lại button cũ (nếu có)
            if (selectedButton != null && selectedButton != clickedButton)
            {
                selectedButton.BackgroundColor = Color.FromArgb(65, 70, 75);
                selectedButton.TextColor = Color.White;
            }
            clickedButton.BackgroundColor = Color.FromArgb(23, 23, 23);
            clickedButton.TextColor = Color.Red;
            selectedButton = clickedButton;

            string buttonName = clickedButton?.Name;
            switch (buttonName)
            {
                case "btnTrangChu":
                    MessageBox.Show("Trang Chủ");

                    break;
                case "btnNhanSu":
                  
                    EmployeeHomeUC em = new EmployeeHomeUC(_employee);
                    LoadControl(em);
                    break;
                case "btnSuatChieu":
                    MessageBox.Show("Chức năng suất chiếu đanng chờ bạn code");

                    break;
                case "btnPhim":
                   
                    Movie_MainUC movieMain = new Movie_MainUC(_employee);
                    LoadControl(movieMain);

                    break;
                case "btnPhong":
                    MessageBox.Show("Chức năng phòng đang chờ bạn code");

                    break;
                case "btnGhe":
                    MessageBox.Show("Chức năng ghế đang chờ bạn code");

                    break;
                case "btnBanVe":
                    MessageBox.Show("Chức năng bán vé đang chờ bạn code");

                    break;
                case "btnThongKe":
                    MessageBox.Show("Chức năng thống đanng chờ bạn code");

                    break;
                case "btnCaiDat":
                    
                    SettingControl settingControl = new SettingControl(this._employee);
                    LoadControl(settingControl);
                    break;
                case "btnCaNhan":
                    MessageBox.Show("Chức năng cá nhân đanng chờ bạn code");
                    break;
                default:
                    break;

            }


            //private void MenuItem_Click(object sender, EventArgs e)
            //{
            //    Control clickedControl = sender as Control;
            //    ParrotButton clickedButton = clickedControl as ParrotButton;
            //    if (clickedButton == null )
            //    {
            //        clickedButton = clickedControl as ParrotButton;
            //    }

            //    // Reset all buttons to default color
            //    if (this.selectedButton != null)
            //    {
            //        selectedButton.BackgroundColor = Color.FromArgb(31, 30, 255);
            //    }
            //    if (clickedButton != null)
            //    {
            //        clickedButton.BackgroundColor = Color.FromArgb(31, 30, 0);
            //        clickedButton.TextColor = Color.Red;
            //        selectedButton = clickedButton; // Lưu lại button hiện tại
            //    }

            //    string buttonName = clickedButton?.Name;
            //    switch (buttonName)
            //    {
            //        case "btnTrangChu":
            //            this.LoadControl(ucTrangChu);
            //            break;
            //        case "btnHoSo":
            //            this.LoadControl(ucHoSoMain);
            //            break;
            //        case "btnKyThi":
            //            this.LoadControl(ucKythi);
            //            break;
            //        case "btnCapGPLX":
            //            this.LoadControl(ucCapGPLX);
            //            break;
            //        case "btnViPham":
            //            this.LoadControl(ucXuLyViPham);
            //            break;

            //        default:
            //            break;




            //}
            //}
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            Movie_MainUC movieMain = new Movie_MainUC(_employee);
            LoadControl(movieMain);
        }
    }
}
