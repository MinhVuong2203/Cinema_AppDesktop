namespace UI.Voucher
{
    partial class VoucherUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabVoucherList = new System.Windows.Forms.TabPage();
            this.dgvVouchers = new System.Windows.Forms.DataGridView();
            this.pnlVoucherActions = new System.Windows.Forms.Panel();
            this.btnRefresh = new ReaLTaiizor.Controls.MaterialButton();
            this.btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            this.btnEdit = new ReaLTaiizor.Controls.MaterialButton();
            this.btnAdd = new ReaLTaiizor.Controls.MaterialButton();
            this.pnlVoucherFilter = new System.Windows.Forms.Panel();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tabCreateVoucher = new System.Windows.Forms.TabPage();
            this.pnlCreateVoucher = new System.Windows.Forms.Panel();
            this.grpVoucherDetails = new System.Windows.Forms.GroupBox();
            this.picVoucherImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new ReaLTaiizor.Controls.MaterialButton();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.lblImageUrl = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.cboApplicableFor = new System.Windows.Forms.ComboBox();
            this.lblApplicableFor = new System.Windows.Forms.Label();
            this.cboVoucherCategory = new System.Windows.Forms.ComboBox();
            this.lblVoucherCategory = new System.Windows.Forms.Label();
            this.numMaxUsagePerCustomer = new System.Windows.Forms.NumericUpDown();
            this.lblMaxUsagePerCustomer = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.numTotalQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.numPointRequired = new System.Windows.Forms.NumericUpDown();
            this.lblPointRequired = new System.Windows.Forms.Label();
            this.numMinOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.lblMinOrderAmount = new System.Windows.Forms.Label();
            this.numMaxDiscountAmount = new System.Windows.Forms.NumericUpDown();
            this.lblMaxDiscountAmount = new System.Windows.Forms.Label();
            this.numDiscountValue = new System.Windows.Forms.NumericUpDown();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.cboDiscountType = new System.Windows.Forms.ComboBox();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtVoucherName = new System.Windows.Forms.TextBox();
            this.lblVoucherName = new System.Windows.Forms.Label();
            this.txtVoucherCode = new System.Windows.Forms.TextBox();
            this.lblVoucherCode = new System.Windows.Forms.Label();
            this.pnlCreateActions = new System.Windows.Forms.Panel();
            this.btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSave = new ReaLTaiizor.Controls.MaterialButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabVoucherList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).BeginInit();
            this.pnlVoucherActions.SuspendLayout();
            this.pnlVoucherFilter.SuspendLayout();
            this.tabCreateVoucher.SuspendLayout();
            this.pnlCreateVoucher.SuspendLayout();
            this.grpVoucherDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoucherImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUsagePerCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointRequired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinOrderAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDiscountAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscountValue)).BeginInit();
            this.pnlCreateActions.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(1600, 930);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(20, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1560, 830);
            this.pnlContent.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVoucherList);
            this.tabControl.Controls.Add(this.tabCreateVoucher);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1560, 830);
            this.tabControl.TabIndex = 0;
            // 
            // tabVoucherList
            // 
            this.tabVoucherList.BackColor = System.Drawing.Color.White;
            this.tabVoucherList.Controls.Add(this.dgvVouchers);
            this.tabVoucherList.Controls.Add(this.pnlVoucherActions);
            this.tabVoucherList.Controls.Add(this.pnlVoucherFilter);
            this.tabVoucherList.Location = new System.Drawing.Point(4, 32);
            this.tabVoucherList.Name = "tabVoucherList";
            this.tabVoucherList.Padding = new System.Windows.Forms.Padding(10);
            this.tabVoucherList.Size = new System.Drawing.Size(1552, 794);
            this.tabVoucherList.TabIndex = 0;
            this.tabVoucherList.Text = "Danh sách Voucher";
            // 
            // dgvVouchers
            // 
            this.dgvVouchers.AllowUserToAddRows = false;
            this.dgvVouchers.AllowUserToDeleteRows = false;
            this.dgvVouchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVouchers.BackgroundColor = System.Drawing.Color.White;
            this.dgvVouchers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVouchers.Location = new System.Drawing.Point(10, 90);
            this.dgvVouchers.MultiSelect = false;
            this.dgvVouchers.Name = "dgvVouchers";
            this.dgvVouchers.ReadOnly = true;
            this.dgvVouchers.RowHeadersWidth = 51;
            this.dgvVouchers.RowTemplate.Height = 35;
            this.dgvVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVouchers.Size = new System.Drawing.Size(1532, 624);
            this.dgvVouchers.TabIndex = 2;
            // 
            // pnlVoucherActions
            // 
            this.pnlVoucherActions.Controls.Add(this.btnRefresh);
            this.pnlVoucherActions.Controls.Add(this.btnDelete);
            this.pnlVoucherActions.Controls.Add(this.btnEdit);
            this.pnlVoucherActions.Controls.Add(this.btnAdd);
            this.pnlVoucherActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlVoucherActions.Location = new System.Drawing.Point(10, 714);
            this.pnlVoucherActions.Name = "pnlVoucherActions";
            this.pnlVoucherActions.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlVoucherActions.Size = new System.Drawing.Size(1532, 70);
            this.pnlVoucherActions.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1372, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 60);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "🔄 Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(320, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 60);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "🗑️ Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(160, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 60);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "✏️ Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "➕ Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // pnlVoucherFilter
            // 
            this.pnlVoucherFilter.Controls.Add(this.cboFilterStatus);
            this.pnlVoucherFilter.Controls.Add(this.lblFilterStatus);
            this.pnlVoucherFilter.Controls.Add(this.txtSearch);
            this.pnlVoucherFilter.Controls.Add(this.lblSearch);
            this.pnlVoucherFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVoucherFilter.Location = new System.Drawing.Point(10, 10);
            this.pnlVoucherFilter.Name = "pnlVoucherFilter";
            this.pnlVoucherFilter.Size = new System.Drawing.Size(1532, 80);
            this.pnlVoucherFilter.TabIndex = 0;
            // 
            // cboFilterStatus
            // 
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Đang hoạt động",
            "Không hoạt động"});
            this.cboFilterStatus.Location = new System.Drawing.Point(600, 30);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(250, 31);
            this.cboFilterStatus.TabIndex = 3;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.Location = new System.Drawing.Point(600, 5);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(100, 23);
            this.lblFilterStatus.TabIndex = 2;
            this.lblFilterStatus.Text = "Trạng thái:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(10, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(550, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(10, 5);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(87, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // tabCreateVoucher
            // 
            this.tabCreateVoucher.AutoScroll = true;
            this.tabCreateVoucher.BackColor = System.Drawing.Color.White;
            this.tabCreateVoucher.Controls.Add(this.pnlCreateVoucher);
            this.tabCreateVoucher.Location = new System.Drawing.Point(4, 32);
            this.tabCreateVoucher.Name = "tabCreateVoucher";
            this.tabCreateVoucher.Padding = new System.Windows.Forms.Padding(10);
            this.tabCreateVoucher.Size = new System.Drawing.Size(1552, 794);
            this.tabCreateVoucher.TabIndex = 1;
            this.tabCreateVoucher.Text = "Tạo / Chỉnh sửa Voucher";
            // 
            // pnlCreateVoucher
            // 
            this.pnlCreateVoucher.AutoScroll = true;
            this.pnlCreateVoucher.Controls.Add(this.grpVoucherDetails);
            this.pnlCreateVoucher.Controls.Add(this.pnlCreateActions);
            this.pnlCreateVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreateVoucher.Location = new System.Drawing.Point(10, 10);
            this.pnlCreateVoucher.Name = "pnlCreateVoucher";
            this.pnlCreateVoucher.Size = new System.Drawing.Size(1532, 774);
            this.pnlCreateVoucher.TabIndex = 0;
            // 
            // grpVoucherDetails
            // 
            this.grpVoucherDetails.AutoSize = true;
            this.grpVoucherDetails.Controls.Add(this.picVoucherImage);
            this.grpVoucherDetails.Controls.Add(this.btnBrowseImage);
            this.grpVoucherDetails.Controls.Add(this.txtImageUrl);
            this.grpVoucherDetails.Controls.Add(this.lblImageUrl);
            this.grpVoucherDetails.Controls.Add(this.chkIsActive);
            this.grpVoucherDetails.Controls.Add(this.cboApplicableFor);
            this.grpVoucherDetails.Controls.Add(this.lblApplicableFor);
            this.grpVoucherDetails.Controls.Add(this.cboVoucherCategory);
            this.grpVoucherDetails.Controls.Add(this.lblVoucherCategory);
            this.grpVoucherDetails.Controls.Add(this.numMaxUsagePerCustomer);
            this.grpVoucherDetails.Controls.Add(this.lblMaxUsagePerCustomer);
            this.grpVoucherDetails.Controls.Add(this.dtpEndDate);
            this.grpVoucherDetails.Controls.Add(this.lblEndDate);
            this.grpVoucherDetails.Controls.Add(this.dtpStartDate);
            this.grpVoucherDetails.Controls.Add(this.lblStartDate);
            this.grpVoucherDetails.Controls.Add(this.numTotalQuantity);
            this.grpVoucherDetails.Controls.Add(this.lblTotalQuantity);
            this.grpVoucherDetails.Controls.Add(this.numPointRequired);
            this.grpVoucherDetails.Controls.Add(this.lblPointRequired);
            this.grpVoucherDetails.Controls.Add(this.numMinOrderAmount);
            this.grpVoucherDetails.Controls.Add(this.lblMinOrderAmount);
            this.grpVoucherDetails.Controls.Add(this.numMaxDiscountAmount);
            this.grpVoucherDetails.Controls.Add(this.lblMaxDiscountAmount);
            this.grpVoucherDetails.Controls.Add(this.numDiscountValue);
            this.grpVoucherDetails.Controls.Add(this.lblDiscountValue);
            this.grpVoucherDetails.Controls.Add(this.cboDiscountType);
            this.grpVoucherDetails.Controls.Add(this.lblDiscountType);
            this.grpVoucherDetails.Controls.Add(this.txtDescription);
            this.grpVoucherDetails.Controls.Add(this.lblDescription);
            this.grpVoucherDetails.Controls.Add(this.txtVoucherName);
            this.grpVoucherDetails.Controls.Add(this.lblVoucherName);
            this.grpVoucherDetails.Controls.Add(this.txtVoucherCode);
            this.grpVoucherDetails.Controls.Add(this.lblVoucherCode);
            this.grpVoucherDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVoucherDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpVoucherDetails.Location = new System.Drawing.Point(0, 0);
            this.grpVoucherDetails.Name = "grpVoucherDetails";
            this.grpVoucherDetails.Padding = new System.Windows.Forms.Padding(20);
            this.grpVoucherDetails.Size = new System.Drawing.Size(1532, 704);
            this.grpVoucherDetails.TabIndex = 1;
            this.grpVoucherDetails.TabStop = false;
            this.grpVoucherDetails.Text = "Thông tin Voucher";
            // 
            // picVoucherImage
            // 
            this.picVoucherImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVoucherImage.Location = new System.Drawing.Point(1100, 80);
            this.picVoucherImage.Name = "picVoucherImage";
            this.picVoucherImage.Size = new System.Drawing.Size(400, 250);
            this.picVoucherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVoucherImage.TabIndex = 33;
            this.picVoucherImage.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseImage.FlatAppearance.BorderSize = 0;
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowseImage.ForeColor = System.Drawing.Color.White;
            this.btnBrowseImage.Location = new System.Drawing.Point(930, 600);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(120, 40);
            this.btnBrowseImage.TabIndex = 32;
            this.btnBrowseImage.Text = "📁 Chọn ảnh";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtImageUrl.Location = new System.Drawing.Point(30, 605);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(880, 30);
            this.txtImageUrl.TabIndex = 31;
            // 
            // lblImageUrl
            // 
            this.lblImageUrl.AutoSize = true;
            this.lblImageUrl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblImageUrl.Location = new System.Drawing.Point(30, 575);
            this.lblImageUrl.Name = "lblImageUrl";
            this.lblImageUrl.Size = new System.Drawing.Size(161, 23);
            this.lblImageUrl.TabIndex = 30;
            this.lblImageUrl.Text = "Đường dẫn hình:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkIsActive.Location = new System.Drawing.Point(560, 530);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(129, 27);
            this.chkIsActive.TabIndex = 29;
            this.chkIsActive.Text = "Hoạt động";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cboApplicableFor
            // 
            this.cboApplicableFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApplicableFor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboApplicableFor.FormattingEnabled = true;
            this.cboApplicableFor.Items.AddRange(new object[] {
            "Tất cả",
            "Vé xem phim",
            "Sản phẩm",
            "Combo"});
            this.cboApplicableFor.Location = new System.Drawing.Point(560, 475);
            this.cboApplicableFor.Name = "cboApplicableFor";
            this.cboApplicableFor.Size = new System.Drawing.Size(490, 31);
            this.cboApplicableFor.TabIndex = 28;
            // 
            // lblApplicableFor
            // 
            this.lblApplicableFor.AutoSize = true;
            this.lblApplicableFor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicableFor.Location = new System.Drawing.Point(560, 445);
            this.lblApplicableFor.Name = "lblApplicableFor";
            this.lblApplicableFor.Size = new System.Drawing.Size(139, 23);
            this.lblApplicableFor.TabIndex = 27;
            this.lblApplicableFor.Text = "Áp dụng cho:";
            // 
            // cboVoucherCategory
            // 
            this.cboVoucherCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoucherCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboVoucherCategory.FormattingEnabled = true;
            this.cboVoucherCategory.Items.AddRange(new object[] {
            "Giảm giá chung",
            "Ưu đãi VIP",
            "Khuyến mãi đặc biệt",
            "Sinh nhật",
            "Sự kiện"});
            this.cboVoucherCategory.Location = new System.Drawing.Point(30, 475);
            this.cboVoucherCategory.Name = "cboVoucherCategory";
            this.cboVoucherCategory.Size = new System.Drawing.Size(490, 31);
            this.cboVoucherCategory.TabIndex = 26;
            // 
            // lblVoucherCategory
            // 
            this.lblVoucherCategory.AutoSize = true;
            this.lblVoucherCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVoucherCategory.Location = new System.Drawing.Point(30, 445);
            this.lblVoucherCategory.Name = "lblVoucherCategory";
            this.lblVoucherCategory.Size = new System.Drawing.Size(96, 23);
            this.lblVoucherCategory.TabIndex = 25;
            this.lblVoucherCategory.Text = "Danh mục:";
            // 
            // numMaxUsagePerCustomer
            // 
            this.numMaxUsagePerCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numMaxUsagePerCustomer.Location = new System.Drawing.Point(800, 405);
            this.numMaxUsagePerCustomer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxUsagePerCustomer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxUsagePerCustomer.Name = "numMaxUsagePerCustomer";
            this.numMaxUsagePerCustomer.Size = new System.Drawing.Size(250, 30);
            this.numMaxUsagePerCustomer.TabIndex = 24;
            this.numMaxUsagePerCustomer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaxUsagePerCustomer
            // 
            this.lblMaxUsagePerCustomer.AutoSize = true;
            this.lblMaxUsagePerCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaxUsagePerCustomer.Location = new System.Drawing.Point(800, 375);
            this.lblMaxUsagePerCustomer.Name = "lblMaxUsagePerCustomer";
            this.lblMaxUsagePerCustomer.Size = new System.Drawing.Size(234, 23);
            this.lblMaxUsagePerCustomer.TabIndex = 23;
            this.lblMaxUsagePerCustomer.Text = "Số lần dùng tối đa/người:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(540, 405);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(240, 30);
            this.dtpEndDate.TabIndex = 22;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.Location = new System.Drawing.Point(540, 375);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(125, 23);
            this.lblEndDate.TabIndex = 21;
            this.lblEndDate.Text = "Ngày kết thúc:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(280, 405);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(240, 30);
            this.dtpStartDate.TabIndex = 20;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.Location = new System.Drawing.Point(280, 375);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(124, 23);
            this.lblStartDate.TabIndex = 19;
            this.lblStartDate.Text = "Ngày bắt đầu:";
            // 
            // numTotalQuantity
            // 
            this.numTotalQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numTotalQuantity.Location = new System.Drawing.Point(30, 405);
            this.numTotalQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTotalQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalQuantity.Name = "numTotalQuantity";
            this.numTotalQuantity.Size = new System.Drawing.Size(230, 30);
            this.numTotalQuantity.TabIndex = 18;
            this.numTotalQuantity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalQuantity.Location = new System.Drawing.Point(30, 375);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(104, 23);
            this.lblTotalQuantity.TabIndex = 17;
            this.lblTotalQuantity.Text = "Số lượng:";
            // 
            // numPointRequired
            // 
            this.numPointRequired.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numPointRequired.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPointRequired.Location = new System.Drawing.Point(800, 335);
            this.numPointRequired.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPointRequired.Name = "numPointRequired";
            this.numPointRequired.Size = new System.Drawing.Size(250, 30);
            this.numPointRequired.TabIndex = 16;
            // 
            // lblPointRequired
            // 
            this.lblPointRequired.AutoSize = true;
            this.lblPointRequired.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPointRequired.Location = new System.Drawing.Point(800, 305);
            this.lblPointRequired.Name = "lblPointRequired";
            this.lblPointRequired.Size = new System.Drawing.Size(140, 23);
            this.lblPointRequired.TabIndex = 15;
            this.lblPointRequired.Text = "Điểm yêu cầu:";
            // 
            // numMinOrderAmount
            // 
            this.numMinOrderAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numMinOrderAmount.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinOrderAmount.Location = new System.Drawing.Point(540, 335);
            this.numMinOrderAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMinOrderAmount.Name = "numMinOrderAmount";
            this.numMinOrderAmount.Size = new System.Drawing.Size(240, 30);
            this.numMinOrderAmount.TabIndex = 14;
            // 
            // lblMinOrderAmount
            // 
            this.lblMinOrderAmount.AutoSize = true;
            this.lblMinOrderAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMinOrderAmount.Location = new System.Drawing.Point(540, 305);
            this.lblMinOrderAmount.Name = "lblMinOrderAmount";
            this.lblMinOrderAmount.Size = new System.Drawing.Size(174, 23);
            this.lblMinOrderAmount.TabIndex = 13;
            this.lblMinOrderAmount.Text = "Giá trị đơn tối thiểu:";
            // 
            // numMaxDiscountAmount
            // 
            this.numMaxDiscountAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numMaxDiscountAmount.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxDiscountAmount.Location = new System.Drawing.Point(280, 335);
            this.numMaxDiscountAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMaxDiscountAmount.Name = "numMaxDiscountAmount";
            this.numMaxDiscountAmount.Size = new System.Drawing.Size(240, 30);
            this.numMaxDiscountAmount.TabIndex = 12;
            // 
            // lblMaxDiscountAmount
            // 
            this.lblMaxDiscountAmount.AutoSize = true;
            this.lblMaxDiscountAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaxDiscountAmount.Location = new System.Drawing.Point(280, 305);
            this.lblMaxDiscountAmount.Name = "lblMaxDiscountAmount";
            this.lblMaxDiscountAmount.Size = new System.Drawing.Size(188, 23);
            this.lblMaxDiscountAmount.TabIndex = 11;
            this.lblMaxDiscountAmount.Text = "Giảm tối đa (nếu có):";
            // 
            // numDiscountValue
            // 
            this.numDiscountValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numDiscountValue.Location = new System.Drawing.Point(30, 335);
            this.numDiscountValue.Maximum = new decimal(new int[] {
                                                        10000000,
                                                        0,
                                                        0,
                                                        0});
            this.numDiscountValue.Name = "numDiscountValue";
            this.numDiscountValue.Size = new System.Drawing.Size(230, 30);
            this.numDiscountValue.TabIndex = 10;
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.AutoSize = true;
            this.lblDiscountValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiscountValue.Location = new System.Drawing.Point(30, 305);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(109, 23);
            this.lblDiscountValue.TabIndex = 9;
            this.lblDiscountValue.Text = "Giá trị giảm:";
            // 
            // cboDiscountType
            // 
            this.cboDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiscountType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDiscountType.FormattingEnabled = true;
            this.cboDiscountType.Items.AddRange(new object[] {
                                                "Phần trăm",
                                                "Số tiền"});
            this.cboDiscountType.Location = new System.Drawing.Point(560, 265);
            this.cboDiscountType.Name = "cboDiscountType";
            this.cboDiscountType.Size = new System.Drawing.Size(490, 31);
            this.cboDiscountType.TabIndex = 8;
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiscountType.Location = new System.Drawing.Point(560, 235);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(138, 23);
            this.lblDiscountType.TabIndex = 7;
            this.lblDiscountType.Text = "Loại giảm giá:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(30, 195);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(1020, 100);
            this.txtDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(30, 165);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(68, 23);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Mô tả:";
            // 
            // txtVoucherName
            // 
            this.txtVoucherName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVoucherName.Location = new System.Drawing.Point(30, 125);
            this.txtVoucherName.MaxLength = 200;
            this.txtVoucherName.Name = "txtVoucherName";
            this.txtVoucherName.Size = new System.Drawing.Size(1020, 30);
            this.txtVoucherName.TabIndex = 4;
            // 
            // lblVoucherName
            // 
            this.lblVoucherName.AutoSize = true;
            this.lblVoucherName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVoucherName.Location = new System.Drawing.Point(30, 95);
            this.lblVoucherName.Name = "lblVoucherName";
            this.lblVoucherName.Size = new System.Drawing.Size(128, 23);
            this.lblVoucherName.TabIndex = 3;
            this.lblVoucherName.Text = "Tên Voucher:";
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVoucherCode.Location = new System.Drawing.Point(30, 55);
            this.txtVoucherCode.MaxLength = 50;
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(1020, 30);
            this.txtVoucherCode.TabIndex = 2;
            // 
            // lblVoucherCode
            // 
            this.lblVoucherCode.AutoSize = true;
            this.lblVoucherCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVoucherCode.Location = new System.Drawing.Point(30, 25);
            this.lblVoucherCode.Name = "lblVoucherCode";
            this.lblVoucherCode.Size = new System.Drawing.Size(128, 23);
            this.lblVoucherCode.TabIndex = 1;
            this.lblVoucherCode.Text = "Mã Voucher:";
            // 
            // pnlCreateActions
            // 
            this.pnlCreateActions.Controls.Add(this.btnCancel);
            this.pnlCreateActions.Controls.Add(this.btnSave);
            this.pnlCreateActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCreateActions.Location = new System.Drawing.Point(0, 704);
            this.pnlCreateActions.Name = "pnlCreateActions";
            this.pnlCreateActions.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlCreateActions.Size = new System.Drawing.Size(1532, 70);
            this.pnlCreateActions.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(160, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 60);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "❌ Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 60);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "💾 Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1560, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1560, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎫 QUẢN LÝ VOUCHER";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VoucherUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "VoucherUC";
            this.Size = new System.Drawing.Size(1600, 930);
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabVoucherList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVouchers)).EndInit();
            this.pnlVoucherActions.ResumeLayout(false);
            this.pnlVoucherFilter.ResumeLayout(false);
            this.pnlVoucherFilter.PerformLayout();
            this.tabCreateVoucher.ResumeLayout(false);
            this.pnlCreateVoucher.ResumeLayout(false);
            this.pnlCreateVoucher.PerformLayout();
            this.grpVoucherDetails.ResumeLayout(false);
            this.grpVoucherDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoucherImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUsagePerCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointRequired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinOrderAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDiscountAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscountValue)).EndInit();
            this.pnlCreateActions.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabVoucherList;
        private System.Windows.Forms.TabPage tabCreateVoucher;
        private System.Windows.Forms.Panel pnlVoucherFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.DataGridView dgvVouchers;
        private System.Windows.Forms.Panel pnlVoucherActions;
        private ReaLTaiizor.Controls.MaterialButton btnAdd;
        private ReaLTaiizor.Controls.MaterialButton btnEdit;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
        private ReaLTaiizor.Controls.MaterialButton btnRefresh;
        private System.Windows.Forms.Panel pnlCreateVoucher;
        private System.Windows.Forms.GroupBox grpVoucherDetails;
        private System.Windows.Forms.Label lblVoucherCode;
        private System.Windows.Forms.TextBox txtVoucherCode;
        private System.Windows.Forms.TextBox txtVoucherName;
        private System.Windows.Forms.Label lblVoucherName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cboDiscountType;
        private System.Windows.Forms.Label lblDiscountType;
        private System.Windows.Forms.NumericUpDown numDiscountValue;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.NumericUpDown numMaxDiscountAmount;
        private System.Windows.Forms.Label lblMaxDiscountAmount;
        private System.Windows.Forms.NumericUpDown numMinOrderAmount;
        private System.Windows.Forms.Label lblMinOrderAmount;
        private System.Windows.Forms.NumericUpDown numPointRequired;
        private System.Windows.Forms.Label lblPointRequired;
        private System.Windows.Forms.NumericUpDown numTotalQuantity;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.NumericUpDown numMaxUsagePerCustomer;
        private System.Windows.Forms.Label lblMaxUsagePerCustomer;
        private System.Windows.Forms.ComboBox cboVoucherCategory;
        private System.Windows.Forms.Label lblVoucherCategory;
        private System.Windows.Forms.ComboBox cboApplicableFor;
        private System.Windows.Forms.Label lblApplicableFor;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Label lblImageUrl;
        private ReaLTaiizor.Controls.MaterialButton btnBrowseImage;
        private System.Windows.Forms.PictureBox picVoucherImage;
        private System.Windows.Forms.Panel pnlCreateActions;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
        private ReaLTaiizor.Controls.MaterialButton btnCancel;
    }
}
