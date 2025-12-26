//namespace UI
//{
//    partial class LicenseManagementForm
//    {
//        /// <summary> 
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary> 
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            this.materialTabControl = new ReaLTaiizor.Controls.MaterialTabControl();
//            this.tabLicenseInfo = new System.Windows.Forms.TabPage();
//            this.tabActivations = new System.Windows.Forms.TabPage();
//            this.panelLicenseHeader = new ReaLTaiizor.Controls.PoisonPanel();
//            this.lblLicenseTitle = new ReaLTaiizor.Controls.BigLabel();
//            this.picLicenseIcon = new System.Windows.Forms.PictureBox();
//            this.panelLicenseStatus = new ReaLTaiizor.Controls.PoisonPanel();
//            this.lblStatusTitle = new ReaLTaiizor.Controls.DungeonHeaderLabel();
//            this.lblStatus = new ReaLTaiizor.Controls.MaterialLabel();
//            this.lblExpiryDate = new ReaLTaiizor.Controls.MaterialLabel();
//            this.lblDaysRemaining = new ReaLTaiizor.Controls.MaterialLabel();
//            this.progressExpiry = new ReaLTaiizor.Controls.SkyProgressBar();
//            this.panelLicenseDetails = new ReaLTaiizor.Controls.PoisonPanel();
//            this.lblDetailsTitle = new ReaLTaiizor.Controls.DungeonHeaderLabel();
//            this.lblPlanCode = new ReaLTaiizor.Controls.MaterialLabel();
//            this.lblMaxSeats = new ReaLTaiizor.Controls.MaterialLabel();
//            this.lblActiveSeats = new ReaLTaiizor.Controls.MaterialLabel();
//            this.lblActivatedDate = new ReaLTaiizor.Controls.MaterialLabel();
//            this.lblTenantId = new ReaLTaiizor.Controls.MaterialLabel();
//            this.panelActivationsHeader = new ReaLTaiizor.Controls.PoisonPanel();
//            this.lblActivationsTitle = new ReaLTaiizor.Controls.BigLabel();
//            this.btnRefresh = new ReaLTaiizor.Controls.MaterialButton();
//            this.dgvActivations = new System.Windows.Forms.DataGridView();
//            this.colInstallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colMachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colActivatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colLastSeen = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.colActions = new System.Windows.Forms.DataGridViewButtonColumn();
//            this.materialTabControl.SuspendLayout();
//            this.tabLicenseInfo.SuspendLayout();
//            this.tabActivations.SuspendLayout();
//            this.panelLicenseHeader.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.picLicenseIcon)).BeginInit();
//            this.panelLicenseStatus.SuspendLayout();
//            this.panelLicenseDetails.SuspendLayout();
//            this.panelActivationsHeader.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvActivations)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // materialTabControl
//            // 
//            this.materialTabControl.Controls.Add(this.tabLicenseInfo);
//            this.materialTabControl.Controls.Add(this.tabActivations);
//            this.materialTabControl.Depth = 0;
//            this.materialTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.materialTabControl.Location = new System.Drawing.Point(3, 64);
//            this.materialTabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
//            this.materialTabControl.Multiline = true;
//            this.materialTabControl.Name = "materialTabControl";
//            this.materialTabControl.SelectedIndex = 0;
//            this.materialTabControl.Size = new System.Drawing.Size(1194, 683);
//            this.materialTabControl.TabIndex = 0;
//            // 
//            // tabLicenseInfo
//            // 
//            this.tabLicenseInfo.BackColor = System.Drawing.Color.White;
//            this.tabLicenseInfo.Controls.Add(this.panelLicenseDetails);
//            this.tabLicenseInfo.Controls.Add(this.panelLicenseStatus);
//            this.tabLicenseInfo.Controls.Add(this.panelLicenseHeader);
//            this.tabLicenseInfo.Location = new System.Drawing.Point(4, 24);
//            this.tabLicenseInfo.Name = "tabLicenseInfo";
//            this.tabLicenseInfo.Padding = new System.Windows.Forms.Padding(20);
//            this.tabLicenseInfo.Size = new System.Drawing.Size(1186, 655);
//            this.tabLicenseInfo.TabIndex = 0;
//            this.tabLicenseInfo.Text = "Thông tin License";
//            // 
//            // tabActivations
//            // 
//            this.tabActivations.BackColor = System.Drawing.Color.White;
//            this.tabActivations.Controls.Add(this.dgvActivations);
//            this.tabActivations.Controls.Add(this.panelActivationsHeader);
//            this.tabActivations.Location = new System.Drawing.Point(4, 24);
//            this.tabActivations.Name = "tabActivations";
//            this.tabActivations.Padding = new System.Windows.Forms.Padding(20);
//            this.tabActivations.Size = new System.Drawing.Size(1186, 655);
//            this.tabActivations.TabIndex = 1;
//            this.tabActivations.Text = "Máy đã cài đặt";
//            // 
//            // panelLicenseHeader
//            // 
//            this.panelLicenseHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
//            this.panelLicenseHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
//            this.panelLicenseHeader.Controls.Add(this.picLicenseIcon);
//            this.panelLicenseHeader.Controls.Add(this.lblLicenseTitle);
//            this.panelLicenseHeader.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panelLicenseHeader.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
//            this.panelLicenseHeader.Location = new System.Drawing.Point(20, 20);
//            this.panelLicenseHeader.Name = "panelLicenseHeader";
//            this.panelLicenseHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
//            this.panelLicenseHeader.Size = new System.Drawing.Size(1146, 80);
//            this.panelLicenseHeader.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
//            this.panelLicenseHeader.TabIndex = 0;
//            // 
//            // lblLicenseTitle
//            // 
//            this.lblLicenseTitle.AutoSize = true;
//            this.lblLicenseTitle.BackColor = System.Drawing.Color.Transparent;
//            this.lblLicenseTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
//            this.lblLicenseTitle.ForeColor = System.Drawing.Color.White;
//            this.lblLicenseTitle.Location = new System.Drawing.Point(80, 20);
//            this.lblLicenseTitle.Name = "lblLicenseTitle";
//            this.lblLicenseTitle.Size = new System.Drawing.Size(319, 45);
//            this.lblLicenseTitle.TabIndex = 0;
//            this.lblLicenseTitle.Text = "Thông tin License";
//            // 
//            // picLicenseIcon
//            // 
//            this.picLicenseIcon.BackColor = System.Drawing.Color.Transparent;
//            this.picLicenseIcon.Location = new System.Drawing.Point(23, 15);
//            this.picLicenseIcon.Name = "picLicenseIcon";
//            this.picLicenseIcon.Size = new System.Drawing.Size(50, 50);
//            this.picLicenseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
//            this.picLicenseIcon.TabIndex = 1;
//            this.picLicenseIcon.TabStop = false;
//            // 
//            // panelLicenseStatus
//            // 
//            this.panelLicenseStatus.BackColor = System.Drawing.Color.White;
//            this.panelLicenseStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
//            this.panelLicenseStatus.Controls.Add(this.progressExpiry);
//            this.panelLicenseStatus.Controls.Add(this.lblDaysRemaining);
//            this.panelLicenseStatus.Controls.Add(this.lblExpiryDate);
//            this.panelLicenseStatus.Controls.Add(this.lblStatus);
//            this.panelLicenseStatus.Controls.Add(this.lblStatusTitle);
//            this.panelLicenseStatus.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panelLicenseStatus.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
//            this.panelLicenseStatus.Location = new System.Drawing.Point(20, 100);
//            this.panelLicenseStatus.Name = "panelLicenseStatus";
//            this.panelLicenseStatus.Padding = new System.Windows.Forms.Padding(20);
//            this.panelLicenseStatus.Size = new System.Drawing.Size(1146, 250);
//            this.panelLicenseStatus.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
//            this.panelLicenseStatus.TabIndex = 1;
//            // 
//            // lblStatusTitle
//            // 
//            this.lblStatusTitle.AutoSize = true;
//            this.lblStatusTitle.BackColor = System.Drawing.Color.Transparent;
//            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
//            this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
//            this.lblStatusTitle.Location = new System.Drawing.Point(23, 23);
//            this.lblStatusTitle.Name = "lblStatusTitle";
//            this.lblStatusTitle.Size = new System.Drawing.Size(148, 25);
//            this.lblStatusTitle.TabIndex = 0;
//            this.lblStatusTitle.Text = "Trạng thái";
//            // 
//            // lblStatus
//            // 
//            this.lblStatus.AutoSize = true;
//            this.lblStatus.Depth = 0;
//            this.lblStatus.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
//            this.lblStatus.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle1;
//            this.lblStatus.Location = new System.Drawing.Point(23, 60);
//            this.lblStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
//            this.lblStatus.Name = "lblStatus";
//            this.lblStatus.Size = new System.Drawing.Size(146, 19);
//            this.lblStatus.TabIndex = 1;
//            this.lblStatus.Text = "Trạng thái: Đang hoạt động";
//            // 
//            // lblExpiryDate
//            // 
//            this.lblExpiryDate.AutoSize = true;
//            this.lblExpiryDate.Depth = 0;
//            this.lblExpiryDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
//            this.lblExpiryDate.Location = new System.Drawing.Point(23, 90);
//            this.lblExpiryDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
//            this.lblExpiryDate.Name = "lblExpiryDate";
//            this.lblExpiryDate.Size = new System.Drawing.Size(94, 19);
//            this.lblExpiryDate.TabIndex = 2;
//            this.lblExpiryDate.Text = "Hết hạn: 31/12/2025";
//            // 
//            // lblDaysRemaining
//            // 
//            this.lblDaysRemaining.AutoSize = true;
//            this.lblDaysRemaining.Depth = 0;
//            this.lblDaysRemaining.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
//            this.lblDaysRemaining.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
//            this.lblDaysRemaining.Location = new System.Drawing.Point(23, 130);
//            this.lblDaysRemaining.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
//            this.lblDaysRemaining.Name = "lblDaysRemaining";
//            this.lblDaysRemaining.Size = new System.Drawing.Size(182, 29);
//            this.lblDaysRemaining.TabIndex = 3;
//            this.lblDaysRemaining.Text = "Còn lại: 365 ngày";
//            // 
//            // progressExpiry
//            // 
//            this.progressExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.progressExpiry.BackColor = System.Drawing.Color.Transparent;
//            this.progressExpiry.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
//            this.progressExpiry.BarStyle = ReaLTaiizor.Controls.SkyProgressBar.Style.Continuous;
//            this.progressExpiry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
//            this.progressExpiry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
//            this.progressExpiry.Location = new System.Drawing.Point(23, 180);
//            this.progressExpiry.Maximum = 100;
//            this.progressExpiry.Minimum = 0;
//            this.progressExpiry.Name = "progressExpiry";
//            this.progressExpiry.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
//            this.progressExpiry.SecondProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
//            this.progressExpiry.Size = new System.Drawing.Size(1100, 30);
//            this.progressExpiry.Style = ReaLTaiizor.Controls.SkyProgressBar.DrawStyle.Normal;
//            this.progressExpiry.TabIndex = 4;
//            this.progressExpiry.Text = "skyProgressBar1";
//            this.progressExpiry.Value = 75;
//            // 
//            // panelLicenseDetails
//            // 
//            this.panelLicenseDetails.BackColor = System.Drawing.Color.White;
//            this.panelLicenseDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
//            this.panelLicenseDetails.Controls.Add(this.lblTenantId);
//            this.panelLicenseDetails.Controls.Add(this.lblActivatedDate);
//            this.panelLicenseDetails.Controls.Add(this.lblActiveSeats);
//            this.panelLicenseDetails.Controls.Add(this.lblMaxSeats);
//            this.panelLicenseDetails.Controls.Add(this.lblPlanCode);
//            this.panelLicenseDetails.Controls.Add(this.lblDetailsTitle);
//            this.panelLicenseDetails.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.panelLicenseDetails.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
//            this.panelLicenseDetails.Location = new System.Drawing.Point(20, 350);
//            this.panelLicenseDetails.Name = "panelLicenseDetails";
//            this.panelLicenseDetails.Padding = new System.Windows.Forms.Padding(20);
//            this.panelLicenseDetails.Size = new System.Drawing.Size(1146, 285);
//            this.panelLicenseDetails.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
//            this.panelLicenseDetails.TabIndex = 2;
//            // 
//            // lblDetailsTitle
//            // 
//            this.lblDetailsTitle.AutoSize = true;
//            this.lblDetailsTitle.BackColor = System.Drawing.Color.Transparent;
//            this.lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
//            this.lblDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
//            this.lblDetailsTitle.Location = new System.Drawing.Point(23, 23);
//            this.lblDetailsTitle.Name = "lblDetailsTitle";
//            this.lblDetailsTitle.Size = new System.Drawing.Size(148, 25);
//            this.lblDetailsTitle.TabIndex = 0;
//            this.lblDetailsTitle.Text = "Chi tiết License";
//            // 
//            // lblPlanCode
//            // 
//            this.lblPlanCode.AutoSize = true;
//            this.lblPlanCode.Depth = 0;
//            this.lblPlanCode.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
//            this.lblPlanCode.Location = new System.Drawing.Point(23, 60);
//            this.lblPlanCode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
//            this.lblPlanCode.Name = "lblPlanCode";
//            this.lblPlanCode.Size = new System.Drawing.Size(94, 19);
//            this.lblPlanCode.TabIndex = 1;
//            this.lblPlanCode.Text = "Gói: Enterprise";
//            // 
//            // lblMaxSeats
//            // 
//            this.lblMaxSeats.AutoSize = true;
//            this.lblMaxSeats.Depth = 0;
//            this.lblMaxSeats.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
//            this.lblMaxSeats.Location = new System.Drawing.Point(23, 90);
//            this.lblMaxSeats.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
//            this.lblMaxSeats.Name = "lblMaxSeats";
//            this.lblMaxSeats.Size = new System.Drawing.Size(150, 19);
//            this.lblMaxSeats.TabIndex = 2;
//            this.lblMaxSeats.Text = "Số máy tối đa: 10";
//            // 
//            // lblActiveSeats
//            // 
//            this.lblActiveSeats.AutoSize = true;
//            this.lblActiveSeats.Depth = 0;
//            this.lblActiveSeats.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
//            this.lblActiveSeats.Location = new System.Drawing.Point(23, 120);
//            this.lblActiveSeats.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
//            this.lblActiveSeats.Name = "lblActiveSeats";
//            this.lblActiveSeats.Size = new System.Drawing.Size(150, 19);
//            this.lblActiveSeats.TabIndex = 3;
//            this.lblActiveSeats.Text = "Số máy đã kích hoạt: 5";
//            // 
//            // lblActivatedDate
//            // 
//            this.lblActivatedDate.AutoSize = true;
//            this.lblActivatedDate.Depth = 0;
//            this.lblActivatedDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
//            this.lblActivatedDate.Location = new System.Drawing.Point(23, 150);
//            this.lblActivatedDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
//            this.lblActivatedDate.Name = "lblActivatedDate";
//            this.lblActivatedDate.Size = new System.Drawing.Size(180, 19);
//            this.lblActivatedDate.TabIndex = 4;
//            this.lblActivatedDate.Text = "Ngày kích hoạt: 01/01/2025";
//            // 
//            // lblTenantId
//            // 
//            this.lblTenantId.AutoSize = true;
//            this.lblTenantId.Depth = 0;
//            this.lblTenantId.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
//            this.lblTenantId.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Caption;
//            this.lblTenantId.Location = new System.Drawing.Point(23, 180);
//            this.lblTenantId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
//            this.lblTenantId.Name = "lblTenantId";
//            this.lblTenantId.Size = new System.Drawing.Size(160, 14);
//            this.lblTenantId.TabIndex = 5;
//            this.lblTenantId.Text = "Tenant ID: xxxxxxxx-xxxx-xxxx";
//            // 
//            // panelActivationsHeader
//            // 
//            this.panelActivationsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
//            this.panelActivationsHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
//            this.panelActivationsHeader.Controls.Add(this.btnRefresh);
//            this.panelActivationsHeader.Controls.Add(this.lblActivationsTitle);
//            this.panelActivationsHeader.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panelActivationsHeader.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
//            this.panelActivationsHeader.Location = new System.Drawing.Point(20, 20);
//            this.panelActivationsHeader.Name = "panelActivationsHeader";
//            this.panelActivationsHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
//            this.panelActivationsHeader.Size = new System.Drawing.Size(1146, 80);
//            this.panelActivationsHeader.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
//            this.panelActivationsHeader.TabIndex = 0;
//            // 
//            // lblActivationsTitle
//            // 
//            this.lblActivationsTitle.AutoSize = true;
//            this.lblActivationsTitle.BackColor = System.Drawing.Color.Transparent;
//            this.lblActivationsTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
//            this.lblActivationsTitle.ForeColor = System.Drawing.Color.White;
//            this.lblActivationsTitle.Location = new System.Drawing.Point(23, 20);
//            this.lblActivationsTitle.Name = "lblActivationsTitle";
//            this.lblActivationsTitle.Size = new System.Drawing.Size(318, 45);
//            this.lblActivationsTitle.TabIndex = 0;
//            this.lblActivationsTitle.Text = "Máy đã cài đặt";
//            // 
//            // btnRefresh
//            // 
//            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.btnRefresh.AutoSize = false;
//            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
//            this.btnRefresh.Depth = 0;
//            this.btnRefresh.DrawShadows = true;
//            this.btnRefresh.HighEmphasis = true;
//            this.btnRefresh.Icon = null;
//            this.btnRefresh.Location = new System.Drawing.Point(1000, 20);
//            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
//            this.btnRefresh.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
//            this.btnRefresh.Name = "btnRefresh";
//            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
//            this.btnRefresh.TabIndex = 1;
//            this.btnRefresh.Text = "Làm mới";
//            this.btnRefresh.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
//            this.btnRefresh.UseAccentColor = false;
//            this.btnRefresh.UseVisualStyleBackColor = true;
//            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
//            // 
//            // dgvActivations
//            // 
//            this.dgvActivations.AllowUserToAddRows = false;
//            this.dgvActivations.AllowUserToDeleteRows = false;
//            this.dgvActivations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dgvActivations.BackgroundColor = System.Drawing.Color.White;
//            this.dgvActivations.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.dgvActivations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgvActivations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.colInstallId,
//            this.colMachineName,
//            this.colActivatedAt,
//            this.colLastSeen,
//            this.colStatus,
//            this.colActions});
//            this.dgvActivations.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.dgvActivations.Location = new System.Drawing.Point(20, 100);
//            this.dgvActivations.Name = "dgvActivations";
//            this.dgvActivations.ReadOnly = true;
//            this.dgvActivations.RowHeadersVisible = false;
//            this.dgvActivations.RowTemplate.Height = 40;
//            this.dgvActivations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.dgvActivations.Size = new System.Drawing.Size(1146, 535);
//            this.dgvActivations.TabIndex = 1;
//            this.dgvActivations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivations_CellContentClick);
//            // 
//            // colInstallId
//            // 
//            this.colInstallId.DataPropertyName = "InstallId";
//            this.colInstallId.HeaderText = "Install ID";
//            this.colInstallId.Name = "colInstallId";
//            this.colInstallId.ReadOnly = true;
//            // 
//            // colMachineName
//            // 
//            this.colMachineName.DataPropertyName = "MachineName";
//            this.colMachineName.HeaderText = "Tên máy";
//            this.colMachineName.Name = "colMachineName";
//            this.colMachineName.ReadOnly = true;
//            // 
//            // colActivatedAt
//            // 
//            this.colActivatedAt.DataPropertyName = "ActivatedAtUtc";
//            this.colActivatedAt.HeaderText = "Ngày kích hoạt";
//            this.colActivatedAt.Name = "colActivatedAt";
//            this.colActivatedAt.ReadOnly = true;
//            // 
//            // colLastSeen
//            // 
//            this.colLastSeen.DataPropertyName = "LastSeenAtUtc";
//            this.colLastSeen.HeaderText = "Lần cuối hoạt động";
//            this.colLastSeen.Name = "colLastSeen";
//            this.colLastSeen.ReadOnly = true;
//            // 
//            // colStatus
//            // 
//            this.colStatus.DataPropertyName = "IsBlocked";
//            this.colStatus.HeaderText = "Trạng thái";
//            this.colStatus.Name = "colStatus";
//            this.colStatus.ReadOnly = true;
//            // 
//            // colActions
//            // 
//            this.colActions.FillWeight = 80F;
//            this.colActions.HeaderText = "Thao tác";
//            this.colActions.Name = "colActions";
//            this.colActions.ReadOnly = true;
//            this.colActions.Text = "Xóa";
//            this.colActions.UseColumnTextForButtonValue = true;
//            // 
//            // LicenseManagementForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1200, 750);
//            this.Controls.Add(this.materialTabControl);
//            this.MaximizeBox = false;
//            this.Name = "LicenseManagementForm";
//            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
//            this.Sizable = false;
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Quản lý License";
//            this.materialTabControl.ResumeLayout(false);
//            this.tabLicenseInfo.ResumeLayout(false);
//            this.tabActivations.ResumeLayout(false);
//            this.panelLicenseHeader.ResumeLayout(false);
//            this.panelLicenseHeader.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.picLicenseIcon)).EndInit();
//            this.panelLicenseStatus.ResumeLayout(false);
//            this.panelLicenseStatus.PerformLayout();
//            this.panelLicenseDetails.ResumeLayout(false);
//            this.panelLicenseDetails.PerformLayout();
//            this.panelActivationsHeader.ResumeLayout(false);
//            this.panelActivationsHeader.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dgvActivations)).EndInit();
//            this.ResumeLayout(false);
//        }

//        #region Controls
//        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl;
//        private System.Windows.Forms.TabPage tabLicenseInfo;
//        private System.Windows.Forms.TabPage tabActivations;
//        private ReaLTaiizor.Controls.PoisonPanel panelLicenseHeader;
//        private ReaLTaiizor.Controls.BigLabel lblLicenseTitle;
//        private System.Windows.Forms.PictureBox picLicenseIcon;
//        private ReaLTaiizor.Controls.PoisonPanel panelLicenseStatus;
//        private ReaLTaiizor.Controls.DungeonHeaderLabel lblStatusTitle;
//        private ReaLTaiizor.Controls.MaterialLabel lblStatus;
//        private ReaLTaiizor.Controls.MaterialLabel lblExpiryDate;
//        private ReaLTaiizor.Controls.MaterialLabel lblDaysRemaining;
//        private ReaLTaiizor.Controls.SkyProgressBar progressExpiry;
//        private ReaLTaiizor.Controls.PoisonPanel panelLicenseDetails;
//        private ReaLTaiizor.Controls.DungeonHeaderLabel lblDetailsTitle;
//        private ReaLTaiizor.Controls.MaterialLabel lblPlanCode;
//        private ReaLTaiizor.Controls.MaterialLabel lblMaxSeats;
//        private ReaLTaiizor.Controls.MaterialLabel lblActiveSeats;
//        private ReaLTaiizor.Controls.MaterialLabel lblActivatedDate;
//        private ReaLTaiizor.Controls.MaterialLabel lblTenantId;
//        private ReaLTaiizor.Controls.PoisonPanel panelActivationsHeader;
//        private ReaLTaiizor.Controls.BigLabel lblActivationsTitle;
//        private ReaLTaiizor.Controls.MaterialButton btnRefresh;
//        private System.Windows.Forms.DataGridView dgvActivations;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colInstallId;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colMachineName;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colActivatedAt;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colLastSeen;
//        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
//        private System.Windows.Forms.DataGridViewButtonColumn colActions;
//        #endregion

//        #region Component Designer generated code

//        /// <summary> 
//        /// Required method for Designer support - do not modify 
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            components = new System.ComponentModel.Container();
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//        }

//        #endregion
//    }
//}
