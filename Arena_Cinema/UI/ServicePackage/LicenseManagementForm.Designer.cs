using BLL;
using System;

namespace UI
{
    partial class LicenseManagementForm
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

            private void InitializeComponent()
            {
            this.materialTabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabLicenseInfo = new System.Windows.Forms.TabPage();
            this.panelLicenseDetails = new System.Windows.Forms.Panel();
            this.lblTenantId = new ReaLTaiizor.Controls.DungeonLabel();
            this.lblActivatedDate = new ReaLTaiizor.Controls.DungeonLabel();
            this.lblActiveSeats = new ReaLTaiizor.Controls.DungeonLabel();
            this.lblMaxSeats = new ReaLTaiizor.Controls.DungeonLabel();
            this.lblPlanCode = new ReaLTaiizor.Controls.DungeonLabel();
            this.lblDetailsTitle = new ReaLTaiizor.Controls.HeaderLabel();
            this.panelLicenseStatus = new System.Windows.Forms.Panel();
            this.progressExpiry = new System.Windows.Forms.ProgressBar();
            this.lblDaysRemaining = new ReaLTaiizor.Controls.BigLabel();
            this.lblExpiryDate = new ReaLTaiizor.Controls.DungeonLabel();
            this.lblStatus = new ReaLTaiizor.Controls.DungeonLabel();
            this.lblStatusTitle = new ReaLTaiizor.Controls.HeaderLabel();
            this.panelLicenseHeader = new System.Windows.Forms.Panel();
            this.lblLicenseTitle = new ReaLTaiizor.Controls.BigLabel();
            this.tabActivations = new System.Windows.Forms.TabPage();
            this.dgvActivations = new System.Windows.Forms.DataGridView();
            this.colInstallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastSeen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelActivationsHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new ReaLTaiizor.Controls.MaterialButton();
            this.lblActivationsTitle = new ReaLTaiizor.Controls.BigLabel();
            this.picLicenseIcon = new System.Windows.Forms.PictureBox();
            this.materialTabControl.SuspendLayout();
            this.tabLicenseInfo.SuspendLayout();
            this.panelLicenseDetails.SuspendLayout();
            this.panelLicenseStatus.SuspendLayout();
            this.panelLicenseHeader.SuspendLayout();
            this.tabActivations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivations)).BeginInit();
            this.panelActivationsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicenseIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.tabLicenseInfo);
            this.materialTabControl.Controls.Add(this.tabActivations);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(1600, 862);
            this.materialTabControl.TabIndex = 0;
            // 
            // tabLicenseInfo
            // 
            this.tabLicenseInfo.BackColor = System.Drawing.Color.White;
            this.tabLicenseInfo.Controls.Add(this.panelLicenseDetails);
            this.tabLicenseInfo.Controls.Add(this.panelLicenseStatus);
            this.tabLicenseInfo.Controls.Add(this.panelLicenseHeader);
            this.tabLicenseInfo.Location = new System.Drawing.Point(4, 25);
            this.tabLicenseInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabLicenseInfo.Name = "tabLicenseInfo";
            this.tabLicenseInfo.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.tabLicenseInfo.Size = new System.Drawing.Size(1592, 833);
            this.tabLicenseInfo.TabIndex = 0;
            this.tabLicenseInfo.Text = "Thông tin License";
            // 
            // panelLicenseDetails
            // 
            this.panelLicenseDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelLicenseDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLicenseDetails.Controls.Add(this.lblTenantId);
            this.panelLicenseDetails.Controls.Add(this.lblActivatedDate);
            this.panelLicenseDetails.Controls.Add(this.lblActiveSeats);
            this.panelLicenseDetails.Controls.Add(this.lblMaxSeats);
            this.panelLicenseDetails.Controls.Add(this.lblPlanCode);
            this.panelLicenseDetails.Controls.Add(this.lblDetailsTitle);
            this.panelLicenseDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLicenseDetails.Location = new System.Drawing.Point(27, 443);
            this.panelLicenseDetails.Margin = new System.Windows.Forms.Padding(4);
            this.panelLicenseDetails.Name = "panelLicenseDetails";
            this.panelLicenseDetails.Padding = new System.Windows.Forms.Padding(33, 25, 33, 25);
            this.panelLicenseDetails.Size = new System.Drawing.Size(1538, 365);
            this.panelLicenseDetails.TabIndex = 2;
            this.panelLicenseDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLicenseDetails_Paint);
            // 
            // lblTenantId
            // 
            this.lblTenantId.AutoSize = true;
            this.lblTenantId.BackColor = System.Drawing.Color.Transparent;
            this.lblTenantId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenantId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblTenantId.Location = new System.Drawing.Point(32, 256);
            this.lblTenantId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenantId.Name = "lblTenantId";
            this.lblTenantId.Size = new System.Drawing.Size(271, 20);
            this.lblTenantId.TabIndex = 5;
            this.lblTenantId.Text = "Tenant ID: xxxxxxxx-xxxx-xxxx-xxxx-xxxx";
            // 
            // lblActivatedDate
            // 
            this.lblActivatedDate.AutoSize = true;
            this.lblActivatedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblActivatedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblActivatedDate.Location = new System.Drawing.Point(31, 209);
            this.lblActivatedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivatedDate.Name = "lblActivatedDate";
            this.lblActivatedDate.Size = new System.Drawing.Size(257, 28);
            this.lblActivatedDate.TabIndex = 4;
            this.lblActivatedDate.Text = "Ngày kích hoạt: 01/01/2025";
            // 
            // lblActiveSeats
            // 
            this.lblActiveSeats.AutoSize = true;
            this.lblActiveSeats.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblActiveSeats.Location = new System.Drawing.Point(31, 166);
            this.lblActiveSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveSeats.Name = "lblActiveSeats";
            this.lblActiveSeats.Size = new System.Drawing.Size(228, 28);
            this.lblActiveSeats.TabIndex = 3;
            this.lblActiveSeats.Text = "Số máy đã kích hoạt: 5";
            // 
            // lblMaxSeats
            // 
            this.lblMaxSeats.AutoSize = true;
            this.lblMaxSeats.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblMaxSeats.Location = new System.Drawing.Point(31, 123);
            this.lblMaxSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxSeats.Name = "lblMaxSeats";
            this.lblMaxSeats.Size = new System.Drawing.Size(164, 28);
            this.lblMaxSeats.TabIndex = 2;
            this.lblMaxSeats.Text = "Số máy tối đa: 10";
            // 
            // lblPlanCode
            // 
            this.lblPlanCode.AutoSize = true;
            this.lblPlanCode.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblPlanCode.Location = new System.Drawing.Point(31, 80);
            this.lblPlanCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanCode.Name = "lblPlanCode";
            this.lblPlanCode.Size = new System.Drawing.Size(139, 28);
            this.lblPlanCode.TabIndex = 1;
            this.lblPlanCode.Text = "Gói: Enterprise";
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblDetailsTitle.Location = new System.Drawing.Point(31, 25);
            this.lblDetailsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(161, 37);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "Chi tiết Gói";
            // 
            // panelLicenseStatus
            // 
            this.panelLicenseStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelLicenseStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLicenseStatus.Controls.Add(this.progressExpiry);
            this.panelLicenseStatus.Controls.Add(this.lblDaysRemaining);
            this.panelLicenseStatus.Controls.Add(this.lblExpiryDate);
            this.panelLicenseStatus.Controls.Add(this.lblStatus);
            this.panelLicenseStatus.Controls.Add(this.lblStatusTitle);
            this.panelLicenseStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLicenseStatus.Location = new System.Drawing.Point(27, 136);
            this.panelLicenseStatus.Margin = new System.Windows.Forms.Padding(4);
            this.panelLicenseStatus.Name = "panelLicenseStatus";
            this.panelLicenseStatus.Padding = new System.Windows.Forms.Padding(33, 25, 33, 25);
            this.panelLicenseStatus.Size = new System.Drawing.Size(1538, 307);
            this.panelLicenseStatus.TabIndex = 1;
            // 
            // progressExpiry
            // 
            this.progressExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressExpiry.Location = new System.Drawing.Point(31, 234);
            this.progressExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.progressExpiry.Name = "progressExpiry";
            this.progressExpiry.Size = new System.Drawing.Size(1470, 37);
            this.progressExpiry.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressExpiry.TabIndex = 4;
            this.progressExpiry.Value = 75;
            // 
            // lblDaysRemaining
            // 
            this.lblDaysRemaining.AutoSize = true;
            this.lblDaysRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblDaysRemaining.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblDaysRemaining.Location = new System.Drawing.Point(31, 160);
            this.lblDaysRemaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDaysRemaining.Name = "lblDaysRemaining";
            this.lblDaysRemaining.Size = new System.Drawing.Size(346, 54);
            this.lblDaysRemaining.TabIndex = 3;
            this.lblDaysRemaining.Text = "Còn lại: 365 ngày";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpiryDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblExpiryDate.Location = new System.Drawing.Point(31, 117);
            this.lblExpiryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(246, 28);
            this.lblExpiryDate.TabIndex = 2;
            this.lblExpiryDate.Text = "Hết hạn: 31/12/2025 23:59";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblStatus.Location = new System.Drawing.Point(31, 74);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(226, 32);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "✓ Đang hoạt động";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblStatusTitle.Location = new System.Drawing.Point(31, 25);
            this.lblStatusTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(147, 37);
            this.lblStatusTitle.TabIndex = 0;
            this.lblStatusTitle.Text = "Trạng thái";
            // 
            // panelLicenseHeader
            // 
            this.panelLicenseHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelLicenseHeader.Controls.Add(this.picLicenseIcon);
            this.panelLicenseHeader.Controls.Add(this.lblLicenseTitle);
            this.panelLicenseHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLicenseHeader.Location = new System.Drawing.Point(27, 25);
            this.panelLicenseHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelLicenseHeader.Name = "panelLicenseHeader";
            this.panelLicenseHeader.Padding = new System.Windows.Forms.Padding(27, 18, 27, 18);
            this.panelLicenseHeader.Size = new System.Drawing.Size(1538, 111);
            this.panelLicenseHeader.TabIndex = 0;
            // 
            // lblLicenseTitle
            // 
            this.lblLicenseTitle.AutoSize = true;
            this.lblLicenseTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblLicenseTitle.ForeColor = System.Drawing.Color.White;
            this.lblLicenseTitle.Location = new System.Drawing.Point(107, 27);
            this.lblLicenseTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseTitle.Name = "lblLicenseTitle";
            this.lblLicenseTitle.Size = new System.Drawing.Size(426, 54);
            this.lblLicenseTitle.TabIndex = 0;
            this.lblLicenseTitle.Text = "Thông tin Gói dịch vụ";
            // 
            // tabActivations
            // 
            this.tabActivations.BackColor = System.Drawing.Color.White;
            this.tabActivations.Controls.Add(this.dgvActivations);
            this.tabActivations.Controls.Add(this.panelActivationsHeader);
            this.tabActivations.Location = new System.Drawing.Point(4, 25);
            this.tabActivations.Margin = new System.Windows.Forms.Padding(4);
            this.tabActivations.Name = "tabActivations";
            this.tabActivations.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.tabActivations.Size = new System.Drawing.Size(1592, 833);
            this.tabActivations.TabIndex = 1;
            this.tabActivations.Text = "Máy đã cài đặt";
            // 
            // dgvActivations
            // 
            this.dgvActivations.AllowUserToAddRows = false;
            this.dgvActivations.AllowUserToDeleteRows = false;
            this.dgvActivations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivations.BackgroundColor = System.Drawing.Color.White;
            this.dgvActivations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActivations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActivations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActivations.ColumnHeadersHeight = 45;
            this.dgvActivations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvActivations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInstallId,
            this.colMachineName,
            this.colActivatedAt,
            this.colLastSeen,
            this.colStatus,
            this.colActions});
            this.dgvActivations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivations.EnableHeadersVisualStyles = false;
            this.dgvActivations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvActivations.Location = new System.Drawing.Point(27, 136);
            this.dgvActivations.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActivations.Name = "dgvActivations";
            this.dgvActivations.ReadOnly = true;
            this.dgvActivations.RowHeadersVisible = false;
            this.dgvActivations.RowHeadersWidth = 51;
            this.dgvActivations.RowTemplate.Height = 50;
            this.dgvActivations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivations.Size = new System.Drawing.Size(1538, 672);
            this.dgvActivations.TabIndex = 1;
            this.dgvActivations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivations_CellContentClick);
            // 
            // colInstallId
            // 
            this.colInstallId.DataPropertyName = "InstallId";
            this.colInstallId.HeaderText = "Install ID";
            this.colInstallId.MinimumWidth = 6;
            this.colInstallId.Name = "colInstallId";
            this.colInstallId.ReadOnly = true;
            // 
            // colMachineName
            // 
            this.colMachineName.DataPropertyName = "MachineName";
            this.colMachineName.HeaderText = "Tên máy";
            this.colMachineName.MinimumWidth = 6;
            this.colMachineName.Name = "colMachineName";
            this.colMachineName.ReadOnly = true;
            // 
            // colActivatedAt
            // 
            this.colActivatedAt.DataPropertyName = "ActivatedAtUtc";
            this.colActivatedAt.HeaderText = "Ngày kích hoạt";
            this.colActivatedAt.MinimumWidth = 6;
            this.colActivatedAt.Name = "colActivatedAt";
            this.colActivatedAt.ReadOnly = true;
            // 
            // colLastSeen
            // 
            this.colLastSeen.DataPropertyName = "LastSeenAtUtc";
            this.colLastSeen.HeaderText = "Lần cuối hoạt động";
            this.colLastSeen.MinimumWidth = 6;
            this.colLastSeen.Name = "colLastSeen";
            this.colLastSeen.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "IsBlocked";
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colActions
            // 
            this.colActions.FillWeight = 80F;
            this.colActions.HeaderText = "Thao tác";
            this.colActions.MinimumWidth = 6;
            this.colActions.Name = "colActions";
            this.colActions.ReadOnly = true;
            this.colActions.Text = "Xóa";
            this.colActions.UseColumnTextForButtonValue = true;
            // 
            // panelActivationsHeader
            // 
            this.panelActivationsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panelActivationsHeader.Controls.Add(this.btnRefresh);
            this.panelActivationsHeader.Controls.Add(this.lblActivationsTitle);
            this.panelActivationsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActivationsHeader.Location = new System.Drawing.Point(27, 25);
            this.panelActivationsHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelActivationsHeader.Name = "panelActivationsHeader";
            this.panelActivationsHeader.Padding = new System.Windows.Forms.Padding(27, 18, 27, 18);
            this.panelActivationsHeader.Size = new System.Drawing.Size(1538, 111);
            this.panelActivationsHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnRefresh.Location = new System.Drawing.Point(1342, 31);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRefresh.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefresh.Size = new System.Drawing.Size(160, 49);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblActivationsTitle
            // 
            this.lblActivationsTitle.AutoSize = true;
            this.lblActivationsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblActivationsTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblActivationsTitle.ForeColor = System.Drawing.Color.White;
            this.lblActivationsTitle.Location = new System.Drawing.Point(31, 27);
            this.lblActivationsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivationsTitle.Name = "lblActivationsTitle";
            this.lblActivationsTitle.Size = new System.Drawing.Size(300, 54);
            this.lblActivationsTitle.TabIndex = 0;
            this.lblActivationsTitle.Text = "Máy đã cài đặt";
            // 
            // picLicenseIcon
            // 
            this.picLicenseIcon.BackColor = System.Drawing.Color.Transparent;
            this.picLicenseIcon.BackgroundImage = global::UI.Properties.Resources.package;
            this.picLicenseIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLicenseIcon.InitialImage = null;
            this.picLicenseIcon.Location = new System.Drawing.Point(31, 25);
            this.picLicenseIcon.Margin = new System.Windows.Forms.Padding(4);
            this.picLicenseIcon.Name = "picLicenseIcon";
            this.picLicenseIcon.Size = new System.Drawing.Size(67, 62);
            this.picLicenseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLicenseIcon.TabIndex = 1;
            this.picLicenseIcon.TabStop = false;
            // 
            // LicenseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LicenseManagementForm";
            this.Size = new System.Drawing.Size(1600, 862);
            this.materialTabControl.ResumeLayout(false);
            this.tabLicenseInfo.ResumeLayout(false);
            this.panelLicenseDetails.ResumeLayout(false);
            this.panelLicenseDetails.PerformLayout();
            this.panelLicenseStatus.ResumeLayout(false);
            this.panelLicenseStatus.PerformLayout();
            this.panelLicenseHeader.ResumeLayout(false);
            this.panelLicenseHeader.PerformLayout();
            this.tabActivations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivations)).EndInit();
            this.panelActivationsHeader.ResumeLayout(false);
            this.panelActivationsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicenseIcon)).EndInit();
            this.ResumeLayout(false);

            }


        #region Controls
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabLicenseInfo;
        private System.Windows.Forms.TabPage tabActivations;
        private System.Windows.Forms.Panel panelLicenseHeader;
        private ReaLTaiizor.Controls.BigLabel lblLicenseTitle;
        private System.Windows.Forms.PictureBox picLicenseIcon;
        private System.Windows.Forms.Panel panelLicenseStatus;
        private ReaLTaiizor.Controls.HeaderLabel lblStatusTitle;
        private ReaLTaiizor.Controls.DungeonLabel lblStatus;
        private ReaLTaiizor.Controls.DungeonLabel lblExpiryDate;
        private ReaLTaiizor.Controls.BigLabel lblDaysRemaining;
        private System.Windows.Forms.ProgressBar progressExpiry;
        private System.Windows.Forms.Panel panelLicenseDetails;
        private ReaLTaiizor.Controls.HeaderLabel lblDetailsTitle;
        private ReaLTaiizor.Controls.DungeonLabel lblPlanCode;
        private ReaLTaiizor.Controls.DungeonLabel lblMaxSeats;
        private ReaLTaiizor.Controls.DungeonLabel lblActiveSeats;
        private ReaLTaiizor.Controls.DungeonLabel lblActivatedDate;
        private ReaLTaiizor.Controls.DungeonLabel lblTenantId;
        private System.Windows.Forms.Panel panelActivationsHeader;
        private ReaLTaiizor.Controls.BigLabel lblActivationsTitle;
        private ReaLTaiizor.Controls.MaterialButton btnRefresh;
        private System.Windows.Forms.DataGridView dgvActivations;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastSeen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colActions;

            #endregion

            #region Component Designer generated code

            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>

            #endregion
        }
    }
