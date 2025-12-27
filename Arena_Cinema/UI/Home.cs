using Common;
using DTO;
using Microsoft.VisualBasic;
using ReaLTaiizor.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using UI.Employee;
using UI.EmployeeSale;
using UI.Movie;
using UI.PayOSMethod;
using UI.Products;
using UI.ScreeningRoom;
using UI.Setting;
using UI.ShowTime;
using System.Linq;
using BLL;


using UI.Helpers;
using UI.Dashboard;
using UI.Revenue;
using UI.Voucher;


namespace UI
{
    public partial class Home : Form
    {
        private bool isCollapsed = false;
        private Timer sidebarTimer;
        private int sidebarExpandedWidth = 220;
        private int sidebarCollapsedWidth = 80;
        private ParrotButton selectedButton = null;

        //Bminh thêm
        private Timer _cleanupTimer;


        public DTO.Employee _employee { get; set; }
        public DTO.Room _room { get; set; }

        public Home(DTO.Employee employee)
        {
            _employee = employee;
            LanguageHelper.ChangeLanguage(employee.Setting.LanguageCode);
            InitializeComponent();
            Decentralization();
            InitializeSidebarAnimation();
            StartClock();
            StartCleanupTimer();
            StartSeatLockService();
        }

      
        private void Decentralization()
        {
            btnBanVe.Visible = false;
            btnNhanSu.Visible = false;
            btnPhim.Visible = false;
            btnPhong.Visible = false;
            btnSuatChieu.Visible = false;
            btnSanPham.Visible = false;
            btnDoanhThu.Visible = false;
            btnVoucher.Visible = false;

            if (_employee.Operations.Any(op => op.OperationCode == "SALE"))
            {
                btnBanVe.Visible = true;
            }

            if (_employee.Operations.Any(op => op.OperationCode == "EMPLOYEE"))
            {
                btnNhanSu.Visible = true;
            }

            if (_employee.Operations.Any(op => op.OperationCode == "SHOWTIME"))
            {
                btnSuatChieu.Visible = true;
            }

            if (_employee.Operations.Any(op => op.OperationCode == "MOVIE"))
            {
                btnPhim.Visible = true;
            }

            if (_employee.Operations.Any(op => op.OperationCode == "ROOM"))
            {
                btnPhong.Visible = true;
            }

            if (_employee.Operations.Any(op => op.OperationCode == "PRODUCT"))
            {
                btnSanPham.Visible = true;
            }

            if (_employee.Operations.Any(op => op.OperationCode == "REVENUE"))
            {
                btnDoanhThu.Visible = true;
            }

            if (_employee.Operations.Any(op => op.OperationCode == "VOUCHER"))
            {
                btnVoucher.Visible = true;
            }

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
                pnMenu.Width += 20;
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
                pnMenu.Width -= 20;
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
                    DashboardUC dashboardUC = new DashboardUC(this, _employee);
                    dashboardUC.LoadUpcomingMovies();
                    LoadControl(dashboardUC);
                    break;
                case "btnNhanSu":
                  
                    EmployeeHomeUC em = new EmployeeHomeUC(this, _employee);
                    LoadControl(em);
                    break;
                case "btnSuatChieu":
                    
                    MNShowTimeUC st=new MNShowTimeUC(this,_employee);
                    LoadControl(st);
                    break;
                case "btnPhim":
                   
                    Movie_MainUC movieMain = new Movie_MainUC(this, _employee);
                    LoadControl(movieMain);
                    break;
                case "btnPhong":
                    Room_homeUC room = new Room_homeUC(this, _room);
                    LoadControl(room);
                    break;
                case "btnGhe":
                    MessageBox.Show("Chức năng ghế đang chờ bạn code");

                    break;
                case "btnBanVe":
                    //MessageBox.Show("Chức năng bán vé đang chờ bạn code");
                    SaleHomeUC saleHomeUC = new SaleHomeUC(this, _employee);
                    LoadControl(saleHomeUC);
                    break;
                case "btnSanPham":
                    ProductMainUC productMainUC = new ProductMainUC(this, _employee);
                    LoadControl(productMainUC);
                    break;
                case "btnThongKe":
                    MessageBox.Show("Chức năng thống đanng chờ bạn code");

                    break;
                case "btnGoiDichVu":
                    LicenseBLL bll = new LicenseBLL();
                    
                    LicenseManagementForm settingControl = new LicenseManagementForm(bll.getTenantId());
                    LoadControl(settingControl);
                    break;
                case "btnCaNhan":
                    ProfileUC profileUC = new ProfileUC(this._employee);
                    LoadControl(profileUC);
                    break;
                case "btnDoanhThu":
                    Main_RevenueUC revenueUC = new Main_RevenueUC(this, _employee);
                    LoadControl(revenueUC);
                    break;
                case "btnVoucher":
                    VoucherUC voucherUC = new VoucherUC(this, _employee);
                    LoadControl(voucherUC);
                    break;
                default:
                    break;

            }
            
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            Movie_MainUC movieMain = new Movie_MainUC(this,_employee);
            LoadControl(movieMain);
        }
        private void btnPhong_Click(object sender, EventArgs e)
        {
            Room_homeUC room = new Room_homeUC(this, _room);
            LoadControl(room);
        }

        //Bminh thêm
        private void StartCleanupTimer()
        {
            _cleanupTimer = new Timer();
            _cleanupTimer.Interval = 1800000; // 30 phút
            _cleanupTimer.Tick += (s, e) =>
            {
                Console.WriteLine("🧹 Running cleanup for old payment mappings...");
                PaymentMappingManager.Instance.CleanupOldMappings();
            };
            _cleanupTimer.Start();
        }

        /// <summary>
        /// Khởi động service tự động unlock ghế hết hạn
        /// Service chạy nền, tự động unlock ghế sau 10 phút
        /// </summary>
        private void StartSeatLockService()
        {
            try
            {
                // Khởi động singleton service
                var service = SeatLockService.Instance;
                Console.WriteLine("🔓 SeatLockService started - Auto-unlock expired seats every 1 minute");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Failed to start SeatLockService: {ex.Message}");
                MessageBox.Show(
                    $"Không thể khởi động dịch vụ tự động mở khóa ghế.\n{ex.Message}",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }



        /// <summary>
        /// Dọn dẹp khi đóng form Home
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            try
            {
                // Dừng cleanup timer
                if (_cleanupTimer != null)
                {
                    _cleanupTimer.Stop();
                    _cleanupTimer.Dispose();
                }

                // Dừng seat lock service
                SeatLockService.Instance.Stop();
                Console.WriteLine("✅ All services stopped");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error stopping services: {ex.Message}");
            }
        }

       
    }
}
