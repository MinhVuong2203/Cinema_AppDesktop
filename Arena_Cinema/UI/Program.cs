using System;
using System.Windows.Forms;
using Common; // nơi có AppLicenseManager, LicenseState

namespace UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var lic = AppLicenseManager.CheckLicense();

            // 1) Đã kích hoạt -> chạy bình thường
            if (lic.State == LicenseState.Activated)
            {
                Application.Run(new Login());
                return;
            }

            // 2) Đang trial -> hỏi có dùng tiếp không
            if (lic.State == LicenseState.Trial)
            {
                var result = MessageBox.Show(
                    $"Phần mềm đang chạy ở chế độ dùng thử. Số ngày dùng thử còn lại: {lic.TrialDaysLeft} ngày.\n" +
                    "Bạn có muốn tiếp tục sử dụng không?",
                    "Chế độ dùng thử",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Application.Run(new Login());
                }
                else
                {
                    Application.Exit();
                }
                return;
            }

            // 3) Hết hạn hoặc bị can thiệp -> bắt kích hoạt
            if (lic.State == LicenseState.Expired || lic.State == LicenseState.Tampered)
            {
                // Mở form kích hoạt (Form này bạn tạo mới)
                Application.Run(new ActivateForm(lic.InstallId, lic.Message));
                return;
            }

            // 4) Trường hợp lạ (phòng hờ)
            MessageBox.Show("Không xác định trạng thái bản quyền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
