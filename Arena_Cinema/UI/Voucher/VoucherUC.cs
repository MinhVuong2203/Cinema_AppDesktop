using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace UI.Voucher
{
    public partial class VoucherUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private VoucherDAL _voucherDAL;
        private int? _editingVoucherId = null;
        private List<DTO.Voucher> _allVouchers;

        public VoucherUC(Home home, DTO.Employee employee)
        {
            InitializeComponent();
            _home = home;
            _employee = employee;
            _voucherDAL = new VoucherDAL();

            InitializeEvents();
            InitializeDataGridView();
            LoadVouchers();
            InitializeFilters();
        }


        private void InitializeEvents()
        {
            // Tab List events
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRefresh.Click += BtnRefresh_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            cboFilterStatus.SelectedIndexChanged += CboFilterStatus_SelectedIndexChanged;
            dgvVouchers.CellDoubleClick += DgvVouchers_CellDoubleClick;

            // Tab Create events
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            btnBrowseImage.Click += BtnBrowseImage_Click;
            cboDiscountType.SelectedIndexChanged += CboDiscountType_SelectedIndexChanged;
            txtImageUrl.TextChanged += TxtImageUrl_TextChanged;
        }

        private void InitializeDataGridView()
        {
            dgvVouchers.AutoGenerateColumns = false;
            dgvVouchers.Columns.Clear();

            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "VoucherID",
                HeaderText = "ID",
                DataPropertyName = "VoucherID",
                Width = 60,
                Visible = false
            });

            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "VoucherCode",
                HeaderText = "Mã Voucher",
                DataPropertyName = "VoucherCode",
                Width = 120
            });

            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "VoucherName",
                HeaderText = "Tên Voucher",
                DataPropertyName = "VoucherName",
                Width = 200
            });

            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DiscountType",
                HeaderText = "Loại giảm",
                DataPropertyName = "DiscountType",
                Width = 100
            });

            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DiscountValue",
                HeaderText = "Giá trị",
                DataPropertyName = "DiscountValue",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PointRequired",
                HeaderText = "Điểm cần",
                DataPropertyName = "PointRequired",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RemainingQuantity",
                HeaderText = "Còn lại",
                DataPropertyName = "RemainingQuantity",
                Width = 80
            });

            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StartDate",
                HeaderText = "Ngày bắt đầu",
                DataPropertyName = "StartDate",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EndDate",
                HeaderText = "Ngày kết thúc",
                DataPropertyName = "EndDate",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvVouchers.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "IsActive",
                HeaderText = "Hoạt động",
                DataPropertyName = "IsActive",
                Width = 90
            });

            // Style cho header
            dgvVouchers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 123, 255);
            dgvVouchers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVouchers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvVouchers.ColumnHeadersHeight = 40;
            dgvVouchers.EnableHeadersVisualStyles = false;

            // Style cho rows
            dgvVouchers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgvVouchers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 123, 255);
            dgvVouchers.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void InitializeFilters()
        {
            cboFilterStatus.SelectedIndex = 0;
            cboDiscountType.SelectedIndex = 0;
            cboVoucherCategory.SelectedIndex = 0;
            cboApplicableFor.SelectedIndex = 0;
        }


        private void LoadVouchers()
        {
            try
            {
                _allVouchers = _voucherDAL.GetAll();
                FilterVouchers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách voucher: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterVouchers()
        {
            if (_allVouchers == null) return;

            var filtered = _allVouchers.AsEnumerable();

            // Lọc theo từ khóa tìm kiếm
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var searchText = txtSearch.Text.ToLower();
                filtered = filtered.Where(v =>
                    v.VoucherCode.ToLower().Contains(searchText) ||
                    v.VoucherName.ToLower().Contains(searchText));
            }

            // Lọc theo trạng thái
            if (cboFilterStatus.SelectedIndex > 0)
            {
                bool isActive = cboFilterStatus.SelectedIndex == 1;
                filtered = filtered.Where(v => v.IsActive == isActive);
            }

            dgvVouchers.DataSource = filtered.ToList();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _editingVoucherId = null;
            ClearForm();
            tabControl.SelectedTab = tabCreateVoucher;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVouchers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn voucher cần sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var voucherId = Convert.ToInt32(dgvVouchers.CurrentRow.Cells["VoucherID"].Value);
            LoadVoucherToEdit(voucherId);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVouchers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn voucher cần xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var voucherId = Convert.ToInt32(dgvVouchers.CurrentRow.Cells["VoucherID"].Value);
            var voucherCode = dgvVouchers.CurrentRow.Cells["VoucherCode"].Value.ToString();

            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa voucher '{voucherCode}'?\n\nVoucher sẽ được đánh dấu là đã xóa và không thể khôi phục.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (_voucherDAL.Delete(voucherId))
                {
                    MessageBox.Show("Xóa voucher thành công!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVouchers();
                }
                else
                {
                    MessageBox.Show("Xóa voucher thất bại!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboFilterStatus.SelectedIndex = 0;
            LoadVouchers();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterVouchers();
        }

        private void CboFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterVouchers();
        }

        private void DgvVouchers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BtnEdit_Click(sender, e);
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            var voucher = new DTO.Voucher
            {
                VoucherCode = txtVoucherCode.Text.Trim(),
                VoucherName = txtVoucherName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                DiscountType = cboDiscountType.Text,
                DiscountValue = numDiscountValue.Value,
                MaxDiscountAmount = numMaxDiscountAmount.Value > 0 ? (decimal?)numMaxDiscountAmount.Value : null,
                MinOrderAmount = numMinOrderAmount.Value,
                PointRequired = (int)numPointRequired.Value,
                TotalQuantity = (int)numTotalQuantity.Value,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                MaxUsagePerCustomer = (int)numMaxUsagePerCustomer.Value,
                VoucherCategory = cboVoucherCategory.Text,
                ApplicableFor = cboApplicableFor.Text,
                ImageUrl = txtImageUrl.Text.Trim(),
                IsActive = chkIsActive.Checked,
                CreatedBy = _employee.EmployeeID,
                IsDeleted = false
            };

            bool success;
            string message;

            if (_editingVoucherId.HasValue)
            {
                voucher.VoucherID = _editingVoucherId.Value;
                success = _voucherDAL.Update(voucher);
                message = success ? "Cập nhật voucher thành công!" : "Cập nhật voucher thất bại!";
            }
            else
            {
                success = _voucherDAL.Add(voucher);
                message = success ? "Thêm voucher thành công!" : "Thêm voucher thất bại!";
            }

            if (success)
            {
                MessageBox.Show(message, "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVouchers();
                tabControl.SelectedTab = tabVoucherList;
                ClearForm();
            }
            else
            {
                MessageBox.Show(message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (IsFormModified())
            {
                var result = MessageBox.Show(
                    "Bạn có thay đổi chưa lưu. Bạn có chắc muốn hủy?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
            }

            ClearForm();
            tabControl.SelectedTab = tabVoucherList;
        }

        private void BtnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Chọn hình ảnh voucher";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImageUrl.Text = ofd.FileName;
                    LoadImage(ofd.FileName);
                }
            }
        }

        private void CboDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDiscountType.SelectedIndex == 0) // Phần trăm
            {
                numDiscountValue.Maximum = 100;
                lblDiscountValue.Text = "Giá trị giảm (%):";
                numMaxDiscountAmount.Enabled = true;
            }
            else // Số tiền
            {
                numDiscountValue.Maximum = 10000000;
                lblDiscountValue.Text = "Giá trị giảm (VNĐ):";
                numMaxDiscountAmount.Value = 0;
                numMaxDiscountAmount.Enabled = false;
            }
        }

        private void TxtImageUrl_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtImageUrl.Text) && File.Exists(txtImageUrl.Text))
            {
                LoadImage(txtImageUrl.Text);
            }
        }


        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtVoucherCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã voucher!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVoucherCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVoucherName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên voucher!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVoucherName.Focus();
                return false;
            }

            if (cboDiscountType.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại giảm giá!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDiscountType.Focus();
                return false;
            }

            if (numDiscountValue.Value <= 0)
            {
                MessageBox.Show("Giá trị giảm phải lớn hơn 0!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numDiscountValue.Focus();
                return false;
            }

            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return false;
            }

            if (cboVoucherCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục voucher!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboVoucherCategory.Focus();
                return false;
            }

            if (cboApplicableFor.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn đối tượng áp dụng!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboApplicableFor.Focus();
                return false;
            }

            // Kiểm tra mã voucher trùng (chỉ khi thêm mới hoặc đổi mã)
            if (!_editingVoucherId.HasValue ||
                txtVoucherCode.Text != _voucherDAL.GetById(_editingVoucherId.Value)?.VoucherCode)
            {
                var existingVoucher = _voucherDAL.GetByCode(txtVoucherCode.Text.Trim());
                if (existingVoucher != null)
                {
                    MessageBox.Show("Mã voucher đã tồn tại!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVoucherCode.Focus();
                    return false;
                }
            }

            return true;
        }

        private void LoadVoucherToEdit(int voucherId)
        {
            var voucher = _voucherDAL.GetById(voucherId);
            if (voucher == null)
            {
                MessageBox.Show("Không tìm thấy voucher!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _editingVoucherId = voucherId;

            txtVoucherCode.Text = voucher.VoucherCode;
            txtVoucherName.Text = voucher.VoucherName;
            txtDescription.Text = voucher.Description;
            cboDiscountType.Text = voucher.DiscountType;
            numDiscountValue.Value = voucher.DiscountValue;
            numMaxDiscountAmount.Value = voucher.MaxDiscountAmount ?? 0;
            numMinOrderAmount.Value = voucher.MinOrderAmount;
            numPointRequired.Value = voucher.PointRequired;
            numTotalQuantity.Value = voucher.TotalQuantity;
            dtpStartDate.Value = voucher.StartDate;
            dtpEndDate.Value = voucher.EndDate;
            numMaxUsagePerCustomer.Value = voucher.MaxUsagePerCustomer;
            cboVoucherCategory.Text = voucher.VoucherCategory;
            cboApplicableFor.Text = voucher.ApplicableFor;
            txtImageUrl.Text = voucher.ImageUrl ?? "";
            chkIsActive.Checked = voucher.IsActive;

            if (!string.IsNullOrWhiteSpace(voucher.ImageUrl) && File.Exists(voucher.ImageUrl))
            {
                LoadImage(voucher.ImageUrl);
            }

            tabControl.SelectedTab = tabCreateVoucher;
        }

        private void ClearForm()
        {
            _editingVoucherId = null;

            txtVoucherCode.Clear();
            txtVoucherName.Clear();
            txtDescription.Clear();
            cboDiscountType.SelectedIndex = 0;
            numDiscountValue.Value = 0;
            numMaxDiscountAmount.Value = 0;
            numMinOrderAmount.Value = 0;
            numPointRequired.Value = 0;
            numTotalQuantity.Value = 100;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddMonths(1);
            numMaxUsagePerCustomer.Value = 1;
            cboVoucherCategory.SelectedIndex = 0;
            cboApplicableFor.SelectedIndex = 0;
            txtImageUrl.Clear();
            chkIsActive.Checked = true;
            picVoucherImage.Image = null;
        }

        private bool IsFormModified()
        {
            return !string.IsNullOrWhiteSpace(txtVoucherCode.Text) ||
                   !string.IsNullOrWhiteSpace(txtVoucherName.Text) ||
                   !string.IsNullOrWhiteSpace(txtDescription.Text);
        }

        private void LoadImage(string imagePath)
        {
            try
            {
                if (picVoucherImage.Image != null)
                {
                    picVoucherImage.Image.Dispose();
                }

                using (var bmpTemp = new Bitmap(imagePath))
                {
                    picVoucherImage.Image = new Bitmap(bmpTemp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải hình ảnh: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                picVoucherImage.Image = null;
            }
        }

        
    }
}
