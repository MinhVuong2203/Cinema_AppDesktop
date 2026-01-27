using BLL;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class LicenseManagementForm : UserControl
    {
        private readonly LicenseBLL _bll;
        private Guid _currentTenantId;

        public LicenseManagementForm(Guid tenantId)
        {
            _bll = new LicenseBLL();
            _currentTenantId = tenantId;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var info = _bll.GetLicenseInfo(_currentTenantId);

                if (!info.IsValid)
                {
                    MessageBox.Show(info.ErrorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UpdateLicenseInfo(info);
                LoadActivations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLicenseInfo(LicenseInfoViewModel info)
        {
            var license = info.License;

            // Cập nhật trạng thái
            if (info.IsExpired)
            {
                lblStatus.Text = global::UI.Resources.Lang.TrangThaiDaHetHan;
                lblStatus.ForeColor = Color.Red;
                panelLicenseHeader.BackColor = Color.FromArgb(211, 47, 47);
            }
            else if (info.IsRevoked)
            {
                lblStatus.Text = global::UI.Resources.Lang.TrangThaiDaBiThuHoi;
                lblStatus.ForeColor = Color.Red;
                panelLicenseHeader.BackColor = Color.FromArgb(211, 47, 47);
            }
            else if (info.IsNearExpiry)
            {
                lblStatus.Text = global::UI.Resources.Lang.TrangThaiSapHetHan;
                lblStatus.ForeColor = Color.Orange;
                panelLicenseHeader.BackColor = Color.FromArgb(255, 152, 0);
            }
            else
            {
                lblStatus.Text = global::UI.Resources.Lang.TrangThaiDangHoatDong;
                lblStatus.ForeColor = Color.Green;
                panelLicenseHeader.BackColor = Color.FromArgb(0, 150, 136);
            }

            // Ngày hết hạn
            lblExpiryDate.Text = global::UI.Resources.Lang.HetHan + $"{license.ExpiresAtUtc.ToLocalTime():dd/MM/yyyy HH:mm}";

            // Số ngày còn lại
            lblDaysRemaining.Text = info.DaysRemaining > 0
                ? (global::UI.Resources.Lang.ConLai + $" {info.DaysRemaining} " + global::UI.Resources.Lang.Ngay)
                : global::UI.Resources.Lang.DaHetHan;
            lblDaysRemaining.ForeColor = info.IsNearExpiry ? Color.Orange : Color.Black;

            // Progress bar (ProgressBar không có ProgressColor trong WinForms standard)
            var totalDays = (license.ExpiresAtUtc - license.ActivatedAtUtc).Days;
            var remainingPercent = totalDays > 0 ? (info.DaysRemaining * 100) / totalDays : 0;
            progressExpiry.Value = Math.Max(0, Math.Min(100, remainingPercent));

            // Đổi màu progress bar nếu sắp hết hạn
            if (info.IsNearExpiry)
            {
                progressExpiry.ForeColor = Color.Orange;
            }
            else
            {
                progressExpiry.ForeColor = Color.FromArgb(0, 150, 136);
            }

            // Chi tiết
            lblPlanCode.Text = global::UI.Resources.Lang.Goi + $" {license.PlanCode ?? "N/A"}";
            lblMaxSeats.Text = global::UI.Resources.Lang.SoMayToiDa + $" {license.MaxSeats}";
            lblActiveSeats.Text = global::UI.Resources.Lang.SoMayDaKichHoat + $" {info.ActiveInstallations}";
            lblActiveSeats.ForeColor = info.CanActivateMore ? Color.Green : Color.Red;
            lblActivatedDate.Text = global::UI.Resources.Lang.NgayKichHoat + $" {license.ActivatedAtUtc.ToLocalTime():dd/MM/yyyy HH:mm}";
            lblTenantId.Text = $"Tenant ID: {license.TenantId}";
        }

        private void LoadActivations()
        {
            try
            {
                var activations = _bll.GetActivations(_currentTenantId);
                dgvActivations.DataSource = null;
                dgvActivations.Rows.Clear();

                foreach (var act in activations)
                {
                    int rowIndex = dgvActivations.Rows.Add();
                    var row = dgvActivations.Rows[rowIndex];

                    row.Cells["colInstallId"].Value = act.InstallId;
                    row.Cells["colMachineName"].Value = act.MachineName ?? "N/A";
                    row.Cells["colActivatedAt"].Value = act.ActivatedAtUtc.ToLocalTime().ToString("dd/MM/yyyy HH:mm");
                    row.Cells["colLastSeen"].Value = act.LastSeenAtUtc.ToLocalTime().ToString("dd/MM/yyyy HH:mm");
                    row.Cells["colStatus"].Value = act.IsBlocked ? "❌ Đã chặn" : "✓ Hoạt động";
                    row.Tag = act.ActivationId;

                    // Màu sắc theo trạng thái
                    if (act.IsBlocked)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238);
                    }
                    else
                    {
                        var daysSinceLastSeen = (DateTime.UtcNow - act.LastSeenAtUtc).Days;
                        if (daysSinceLastSeen > 30)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 224);
                        }
                    }
                }

                dgvActivations.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách máy: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvActivations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvActivations.Columns[e.ColumnIndex].Name == "colActions")
            {
                var activationId = (int)dgvActivations.Rows[e.RowIndex].Tag;
                var machineName = dgvActivations.Rows[e.RowIndex].Cells["colMachineName"].Value.ToString();

                var result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa máy '{machineName}'?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    if (_bll.RemoveActivation(activationId))
                    {
                        MessageBox.Show("Đã xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadActivations();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

      
    }
}