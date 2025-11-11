using Common;
using DTO;
using ReaLTaiizor.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using UI.Setting;

namespace UI
{
    public partial class Home : Form
    {
        private bool isCollapsed = false;
        private Timer sidebarTimer;
        private int sidebarExpandedWidth = 220;
        private int sidebarCollapsedWidth = 80;
        public string lang = "vi-VN";
        private PictureBox btnToggle;

        public Home(Employee employee)
        {
            //LanguageHelper.ChangeLanguage(lang);
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

        private void parrotButton2_Click(object sender, EventArgs e)
        {
            SettingControl settingControl = new SettingControl();
            LoadControl(settingControl);
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
