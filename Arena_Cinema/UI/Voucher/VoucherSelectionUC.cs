using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL; 

namespace UI.Voucher
{
    public partial class VoucherSelectionUC : UserControl
    {
        private CinemaDBContext _context;
        private decimal _currentTotal;
        private int? _selectedVoucherID;
        private Guid? _customerID;
        private Guid _employeeID;

        // Event khi chọn voucher áp dụng
        public event EventHandler<VoucherSelectedEventArgs> VoucherSelected;

        public VoucherSelectionUC()
        {
            InitializeComponent();
            _context = new CinemaDBContext();

            // Đăng ký sự kiện chuyển tab
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
        }

        public void LoadVouchers(decimal currentTotal, Guid? customerID, Guid employeeID)
        {
            _currentTotal = currentTotal;
            _customerID = customerID;
            _employeeID = employeeID;
            _selectedVoucherID = null;

            // Hiển thị thông tin header
            lblOrderTotal.Text = $"Tổng đơn hàng: {currentTotal:N0} ₫";

            if (customerID.HasValue)
            {
                var customer = _context.Customers.FirstOrDefault(c => c.CustomerID == customerID.Value);
                if (customer != null)
                {
                    lblCustomerInfo.Text = $"👤 {customer.FullName} - ⭐ {customer.Point:N0} điểm";
                    lblCustomerInfo.Visible = true;
                }
            }
            else
            {
                lblCustomerInfo.Text = "⚠️ Khách vãng lai";
                lblCustomerInfo.Visible = true;
            }

            // Mặc định load tab đang chọn
            if (tabControl.SelectedIndex == 0)
                LoadSelectVoucherTab();
            else
                LoadRedeemVoucherTab();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
                LoadSelectVoucherTab();
            else
                LoadRedeemVoucherTab();
        }

        #region TAB 1: CHỌN VOUCHER (Logic cũ - Áp dụng voucher vào đơn)
        private void LoadSelectVoucherTab()
        {
            flpSelectVouchers.Controls.Clear();

            try
            {
                if (!_customerID.HasValue)
                {
                    ShowMessage(flpSelectVouchers, "⚠️ Cần chọn khách hàng thành viên", "Voucher chỉ áp dụng cho thành viên.");
                    return;
                }

                // Lấy voucher khách hàng đang sở hữu (Status = 'Chưa sử dụng')
                var customerVouchers = _context.CustomerVouchers
                    .Where(cv => cv.CustomerID == _customerID.Value
                        && cv.Status == "Chưa sử dụng"
                        && !cv.IsDeleted
                        && cv.ExpiryDate >= DateTime.Now)
                    .Select(cv => new
                    {
                        cv.CustomerVoucherID,
                        cv.VoucherID,
                        Voucher = cv.Voucher, // Include Voucher info
                        cv.ExpiryDate,
                        cv.PointsUsed
                    })
                    .ToList();

                if (!customerVouchers.Any())
                {
                    ShowMessage(flpSelectVouchers, "🎫 Khách chưa có voucher nào", "Hãy sang tab 'Đổi Voucher' để đổi điểm lấy voucher.");
                    return;
                }

                int eligibleCount = 0;
                foreach (var cv in customerVouchers)
                {
                    bool isEligible = _currentTotal >= cv.Voucher.MinOrderAmount;
                    if (isEligible) eligibleCount++;

                    var card = CreateSelectVoucherCard(cv, isEligible);
                    flpSelectVouchers.Controls.Add(card);
                }

                lblSelectVoucherCount.Text = $"{eligibleCount} voucher khả dụng / {customerVouchers.Count} tổng";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        // Tạo Card cho Tab 1 (Chọn áp dụng)
        private Panel CreateSelectVoucherCard(dynamic cv, bool isEligible)
        {
            var voucher = (DTO.Voucher)cv.Voucher;
            var card = new Panel
            {
                Width = 740,
                Height = 130,
                Margin = new Padding(5),
                BackColor = isEligible ? Color.White : Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.FixedSingle
            };

            // ... (Code vẽ giao diện card như cũ của bạn, tôi tóm tắt logic chính) ...

            // Nút ÁP DỤNG
            if (isEligible)
            {
                Button btnSelect = new Button
                {
                    Text = "Áp dụng",
                    BackColor = Color.DodgerBlue,
                    ForeColor = Color.White,
                    Location = new Point(600, 40),
                    Size = new Size(100, 40),
                    Tag = new { cv.CustomerVoucherID, Voucher = voucher }
                };
                btnSelect.Click += BtnSelectCustomerVoucher_Click;
                card.Controls.Add(btnSelect);
            }
            else
            {
                Label lblReason = new Label
                {
                    Text = $"Cần đơn tối thiểu:\n{voucher.MinOrderAmount:N0}đ",
                    ForeColor = Color.Red,
                    Location = new Point(600, 40),
                    AutoSize = true
                };
                card.Controls.Add(lblReason);
            }

            // Tên voucher, giảm giá...
            Label lblName = new Label { Text = voucher.VoucherName, Font = new Font("Arial", 12, FontStyle.Bold), Location = new Point(20, 20), AutoSize = true };
            Label lblDiscount = new Label { Text = voucher.DiscountType == "Phần trăm" ? $"-{voucher.DiscountValue}%" : $"-{voucher.DiscountValue:N0}đ", ForeColor = Color.Red, Font = new Font("Arial", 14, FontStyle.Bold), Location = new Point(20, 50), AutoSize = true };
            card.Controls.Add(lblName);
            card.Controls.Add(lblDiscount);

            return card;
        }

        private void BtnSelectCustomerVoucher_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            dynamic data = btn.Tag;
            var voucher = (DTO.Voucher)data.Voucher;

            // Tính toán giảm giá
            decimal discount = voucher.DiscountType == "Phần trăm"
                ? (_currentTotal * voucher.DiscountValue / 100)
                : voucher.DiscountValue;

            if (voucher.MaxDiscountAmount.HasValue && voucher.DiscountType == "Phần trăm" && discount > voucher.MaxDiscountAmount.Value)
                discount = voucher.MaxDiscountAmount.Value;

            if (discount > _currentTotal) discount = _currentTotal;

            // Gọi Event ra bên ngoài form cha
            VoucherSelected?.Invoke(this, new VoucherSelectedEventArgs
            {
                CustomerVoucherID = data.CustomerVoucherID,
                DiscountAmount = discount,
                FinalTotal = _currentTotal - discount,
                VoucherName = voucher.VoucherName
            });

            // Đóng form (Form cha xử lý DialogResult)
            ((Form)this.TopLevelControl).DialogResult = DialogResult.OK;
        }
        #endregion

        #region TAB 2: ĐỔI VOUCHER (Logic Mới - Dùng điểm đổi voucher)
        private void LoadRedeemVoucherTab()
        {
            flpRedeemVouchers.Controls.Clear();

            if (!_customerID.HasValue)
            {
                ShowMessage(flpRedeemVouchers, "⚠️ Cần chọn khách hàng", "Vui lòng chọn khách hàng để xem điểm và đổi quà.");
                return;
            }

            var customer = _context.Customers.Find(_customerID.Value);
            if (customer == null) return;

            // 1. Lấy tất cả Voucher mẫu đang hoạt động
            var availableVouchers = _context.Vouchers
                .Where(v => !v.IsDeleted && v.IsActive
                         && v.StartDate <= DateTime.Now && v.EndDate >= DateTime.Now
                         && v.RemainingQuantity > 0) // Kiểm tra còn hàng
                .OrderBy(v => v.PointRequired)
                .ToList();

            if (!availableVouchers.Any())
            {
                ShowMessage(flpRedeemVouchers, "📭 Không có voucher nào để đổi", "Hiện tại hệ thống chưa có chương trình đổi điểm.");
                return;
            }

            int redeemableCount = 0;
            foreach (var v in availableVouchers)
            {
                // Logic kiểm tra điều kiện đổi
                bool enoughPoints = customer.Point >= v.PointRequired;

                // Kiểm tra giới hạn số lần đổi của khách (nếu cần thiết theo Business Rule của bạn)
                int timesRedeemed = _context.CustomerVouchers.Count(cv => cv.CustomerID == customer.CustomerID && cv.VoucherID == v.VoucherID);
                bool underLimit = timesRedeemed < v.MaxUsagePerCustomer;

                bool canRedeem = enoughPoints && underLimit;

                if (canRedeem) redeemableCount++;

                var card = CreateRedeemVoucherCard(v, canRedeem, customer.Point, timesRedeemed);
                flpRedeemVouchers.Controls.Add(card);
            }

            lblRedeemVoucherCount.Text = $"Bạn có thể đổi {redeemableCount} voucher / Tổng {availableVouchers.Count} loại";
        }

        // Tạo Card cho Tab 2 (Đổi điểm)
        private Panel CreateRedeemVoucherCard(DTO.Voucher v, bool canRedeem, decimal? userPoints, int timesRedeemed)
        {
            var card = new Panel
            {
                Width = 740,
                Height = 140,
                Margin = new Padding(5),
                BackColor = canRedeem ? Color.White : Color.FromArgb(240, 240, 240),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Tên và mô tả
            Label lblName = new Label { Text = v.VoucherName, Font = new Font("Segoe UI", 12, FontStyle.Bold), Location = new Point(20, 15), AutoSize = true, ForeColor = Color.DarkSlateBlue };
            Label lblDesc = new Label { Text = $"Đơn tối thiểu: {v.MinOrderAmount:N0}đ • HSD: {v.EndDate:dd/MM/yyyy}", Location = new Point(20, 45), AutoSize = true, ForeColor = Color.Gray };
            Label lblUsage = new Label { Text = $"Đã đổi: {timesRedeemed}/{v.MaxUsagePerCustomer}", Location = new Point(20, 70), AutoSize = true, Font = new Font("Segoe UI", 8, FontStyle.Italic) };

            // Hiển thị Điểm cần đổi
            Label lblPoint = new Label
            {
                Text = $"{v.PointRequired:N0} điểm",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = canRedeem ? Color.OrangeRed : Color.Gray,
                Location = new Point(20, 95),
                AutoSize = true
            };

            // Nút ĐỔI NGAY
            if (canRedeem)
            {
                Button btnRedeem = new Button
                {
                    Text = "🎁 Đổi ngay",
                    BackColor = Color.OrangeRed,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(600, 45),
                    Size = new Size(120, 50),
                    Tag = v // Lưu object voucher vào tag
                };
                btnRedeem.Click += BtnRedeem_Click;
                card.Controls.Add(btnRedeem);
            }
            else
            {
                // Hiển thị lý do không đổi được
                string reason = userPoints < v.PointRequired ? $"Thiếu {(v.PointRequired - userPoints):N0} điểm" : "Đã đạt giới hạn";
                Label lblReason = new Label
                {
                    Text = reason,
                    ForeColor = Color.DimGray,
                    Location = new Point(600, 55),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Italic)
                };
                card.Controls.Add(lblReason);
            }

            // Decoration
            Panel stripe = new Panel { Width = 5, Dock = DockStyle.Left, BackColor = canRedeem ? Color.OrangeRed : Color.Gray };

            card.Controls.Add(stripe);
            card.Controls.Add(lblName);
            card.Controls.Add(lblDesc);
            card.Controls.Add(lblUsage);
            card.Controls.Add(lblPoint);

            return card;
        }

        private void BtnRedeem_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var voucher = (DTO.Voucher)btn.Tag;

            if (MessageBox.Show($"Bạn có chắc muốn dùng {voucher.PointRequired:N0} điểm để đổi voucher '{voucher.VoucherName}'?",
                "Xác nhận đổi điểm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PerformRedemption(voucher);
            }
        }

        private void PerformRedemption(DTO.Voucher voucher)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // 1. Reload lại customer để đảm bảo điểm mới nhất (tránh concurrency)
                    var customer = _context.Customers.Find(_customerID.Value);

                    if (customer.Point < voucher.PointRequired)
                    {
                        MessageBox.Show("Điểm của khách hàng không đủ (có thể vừa thay đổi). Vui lòng tải lại.");
                        return;
                    }

                    // 2. Trừ điểm khách hàng
                    customer.Point -= voucher.PointRequired;

                    // 3. Tạo CustomerVoucher mới
                    var newCV = new DTO.CustomerVoucher
                    {
                        CustomerVoucherID = Guid.NewGuid(),
                        VoucherID = voucher.VoucherID,
                        CustomerID = customer.CustomerID,
                        RedeemedBy = _employeeID,
                        RedeemedDate = DateTime.Now,
                        PointsUsed = voucher.PointRequired,
                        Status = "Chưa sử dụng",
                        ExpiryDate = voucher.EndDate,
                        IsDeleted = false
                    };
                    _context.CustomerVouchers.Add(newCV);

                    // 4. Lưu database
                    _context.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Đổi voucher thành công! 🎉", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Cập nhật UI
                    // Cập nhật text điểm khách hàng trên header
                    lblCustomerInfo.Text = $"👤 {customer.FullName} - ⭐ {customer.Point:N0} điểm";

                    // Reload lại tab Đổi voucher (để cập nhật trạng thái các nút)
                    LoadRedeemVoucherTab();

                    // Reload lại tab Chọn voucher (để voucher mới xuất hiện bên kia nếu muốn dùng ngay)
                    // (Tùy chọn: có thể tự động chuyển sang tab 1)
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Lỗi đổi điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        // Helper hiển thị thông báo trống
        private void ShowMessage(FlowLayoutPanel panel, string title, string sub)
        {
            Label lbl = new Label
            {
                Text = $"{title}\n{sub}",
                AutoSize = false,
                Width = panel.Width - 20,
                Height = 100,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Gray
            };
            panel.Controls.Add(lbl);
        }

        //private void btnClearVoucher_Click(object sender, EventArgs e)
        //{

        //}
    }

    // Class gửi dữ liệu ra form cha
    public class VoucherSelectedEventArgs : EventArgs
    {
        public Guid? CustomerVoucherID { get; set; }
        public string VoucherName { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FinalTotal { get; set; }
    }
}