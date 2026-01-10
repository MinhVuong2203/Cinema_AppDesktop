using Common.Licensing; // nơi có AppLicenseManager, LicenseState
using DAL;
using System;
using System.Windows.Forms;

namespace UI
{
    internal static class Program
    {
        static CinemaDBContext db = new CinemaDBContext();
        // TODO: connection string của rạp A (bạn set sẵn)
        //private const string ConnStr = "Data Source=100.102.199.72;Initial Catalog=arenaapp;User ID=sa;Password=123456789;TrustServerCertificate=True";
        private static string ConnStr = db.getConnection();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var lic = AppLicenseManager.CheckAccessAndRegisterSeat(ConnStr, trialDays: 3);

            if (lic.State == LicenseState.Activated)
            {
                Application.Run(new Login());
                return;
            }

            if (lic.State == LicenseState.Trial)
            {
                var result = MessageBox.Show(
                    $"Đang dùng thử. Còn lại: {lic.TrialDaysLeft} ngày.\nBạn có muốn tiếp tục không?",
                    "Trial",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Application.Run(new Login());

                return;
            }

            if (lic.State == LicenseState.SeatLimitReached)
            {
                MessageBox.Show(
                    $"Vượt số máy theo gói.\nĐang dùng: {lic.UsedSeats}/{lic.MaxSeats}\nVui lòng nâng gói hoặc gỡ bớt máy.",
                    "Giới hạn số máy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (lic.State == LicenseState.Expired)
            {
                Application.Run(new ActivateForm(ConnStr, lic.TenantId));
                return;
            }

            MessageBox.Show("Lỗi license: " + lic.Message);
        }
    }
}
