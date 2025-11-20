namespace UI.Employee
{
    partial class ProfileUC
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileUC));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new ReaLTaiizor.Controls.Panel();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardAddress = new ReaLTaiizor.Controls.NightPanel();
            this.lblAddressContent = new System.Windows.Forms.Label();
            this.lblAddressTitle = new System.Windows.Forms.Label();
            this.cardWork = new ReaLTaiizor.Controls.NightPanel();
            this.panelWorkContent = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblRegisterLabel = new System.Windows.Forms.Label();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblWageLabel = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRoleLabel = new System.Windows.Forms.Label();
            this.lblWorkTitle = new System.Windows.Forms.Label();
            this.cardPersonal = new ReaLTaiizor.Controls.NightPanel();
            this.panelPersonalContent = new System.Windows.Forms.Panel();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblCCCDLabel = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblBirthLabel = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblGenderLabel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.lblPersonalTitle = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelCover = new ReaLTaiizor.Controls.NightPanel();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.picImg = new UI.Controls.CircularPictureBox();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.cardAddress.SuspendLayout();
            this.cardWork.SuspendLayout();
            this.panelWorkContent.SuspendLayout();
            this.cardPersonal.SuspendLayout();
            this.panelPersonalContent.SuspendLayout();
            this.panelCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panelMain.Size = new System.Drawing.Size(1333, 862);
            this.panelMain.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.picImg);
            this.panelContent.Controls.Add(this.panelCards);
            this.panelContent.Controls.Add(this.lblPosition);
            this.panelContent.Controls.Add(this.lblName);
            this.panelContent.Controls.Add(this.panelCover);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContent.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelContent.Location = new System.Drawing.Point(27, 25);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(5);
            this.panelContent.Size = new System.Drawing.Size(1258, 1231);
            this.panelContent.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelContent.TabIndex = 0;
            this.panelContent.Text = "panel1";
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Controls.Add(this.cardAddress);
            this.panelCards.Controls.Add(this.cardWork);
            this.panelCards.Controls.Add(this.cardPersonal);
            this.panelCards.Location = new System.Drawing.Point(53, 505);
            this.panelCards.Margin = new System.Windows.Forms.Padding(4);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(1173, 633);
            this.panelCards.TabIndex = 4;
            // 
            // cardAddress
            // 
            this.cardAddress.Controls.Add(this.lblAddressContent);
            this.cardAddress.Controls.Add(this.lblAddressTitle);
            this.cardAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cardAddress.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.cardAddress.Location = new System.Drawing.Point(0, 502);
            this.cardAddress.Margin = new System.Windows.Forms.Padding(4);
            this.cardAddress.Name = "cardAddress";
            this.cardAddress.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cardAddress.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.cardAddress.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.cardAddress.Size = new System.Drawing.Size(1173, 114);
            this.cardAddress.TabIndex = 2;
            this.cardAddress.Text = "nightPanel4";
            // 
            // lblAddressContent
            // 
            this.lblAddressContent.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressContent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblAddressContent.Location = new System.Drawing.Point(33, 74);
            this.lblAddressContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressContent.Name = "lblAddressContent";
            this.lblAddressContent.Size = new System.Drawing.Size(1107, 34);
            this.lblAddressContent.TabIndex = 1;
            this.lblAddressContent.Text = "123 Đường Nguyễn Văn Linh, Phường Tân Phú, Quận 7, Thành phố Hồ Chí Minh";
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblAddressTitle.Location = new System.Drawing.Point(27, 25);
            this.lblAddressTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(133, 32);
            this.lblAddressTitle.TabIndex = 0;
            this.lblAddressTitle.Text = "📍 Địa chỉ";
            // 
            // cardWork
            // 
            this.cardWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardWork.Controls.Add(this.panelWorkContent);
            this.cardWork.Controls.Add(this.lblWorkTitle);
            this.cardWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cardWork.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.cardWork.Location = new System.Drawing.Point(613, 0);
            this.cardWork.Margin = new System.Windows.Forms.Padding(4);
            this.cardWork.Name = "cardWork";
            this.cardWork.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cardWork.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.cardWork.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.cardWork.Size = new System.Drawing.Size(560, 468);
            this.cardWork.TabIndex = 1;
            this.cardWork.Text = "nightPanel3";
            // 
            // panelWorkContent
            // 
            this.panelWorkContent.BackColor = System.Drawing.Color.Transparent;
            this.panelWorkContent.Controls.Add(this.lblRegister);
            this.panelWorkContent.Controls.Add(this.lblRegisterLabel);
            this.panelWorkContent.Controls.Add(this.lblWage);
            this.panelWorkContent.Controls.Add(this.lblWageLabel);
            this.panelWorkContent.Controls.Add(this.lblRole);
            this.panelWorkContent.Controls.Add(this.lblRoleLabel);
            this.panelWorkContent.Location = new System.Drawing.Point(0, 74);
            this.panelWorkContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelWorkContent.Name = "panelWorkContent";
            this.panelWorkContent.Size = new System.Drawing.Size(560, 388);
            this.panelWorkContent.TabIndex = 1;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblRegister.Location = new System.Drawing.Point(33, 183);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(116, 25);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.Text = "01/01/2020";
            // 
            // lblRegisterLabel
            // 
            this.lblRegisterLabel.AutoSize = true;
            this.lblRegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblRegisterLabel.Location = new System.Drawing.Point(33, 148);
            this.lblRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterLabel.Name = "lblRegisterLabel";
            this.lblRegisterLabel.Size = new System.Drawing.Size(137, 28);
            this.lblRegisterLabel.TabIndex = 4;
            this.lblRegisterLabel.Text = "Ngày vào làm:";
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.BackColor = System.Drawing.Color.Transparent;
            this.lblWage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblWage.Location = new System.Drawing.Point(33, 116);
            this.lblWage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(156, 25);
            this.lblWage.TabIndex = 3;
            this.lblWage.Text = "50,000 VNĐ/giờ";
            // 
            // lblWageLabel
            // 
            this.lblWageLabel.AutoSize = true;
            this.lblWageLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblWageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblWageLabel.Location = new System.Drawing.Point(33, 80);
            this.lblWageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWageLabel.Name = "lblWageLabel";
            this.lblWageLabel.Size = new System.Drawing.Size(151, 28);
            this.lblWageLabel.TabIndex = 2;
            this.lblWageLabel.Text = "Lương theo giờ:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblRole.Location = new System.Drawing.Point(33, 48);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(173, 25);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Nhân viên thiết kế";
            // 
            // lblRoleLabel
            // 
            this.lblRoleLabel.AutoSize = true;
            this.lblRoleLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblRoleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblRoleLabel.Location = new System.Drawing.Point(33, 12);
            this.lblRoleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoleLabel.Name = "lblRoleLabel";
            this.lblRoleLabel.Size = new System.Drawing.Size(73, 28);
            this.lblRoleLabel.TabIndex = 0;
            this.lblRoleLabel.Text = "Vai trò:";
            // 
            // lblWorkTitle
            // 
            this.lblWorkTitle.AutoSize = true;
            this.lblWorkTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblWorkTitle.Location = new System.Drawing.Point(27, 25);
            this.lblWorkTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkTitle.Name = "lblWorkTitle";
            this.lblWorkTitle.Size = new System.Drawing.Size(282, 32);
            this.lblWorkTitle.TabIndex = 0;
            this.lblWorkTitle.Text = "💼 Thông tin công việc";
            // 
            // cardPersonal
            // 
            this.cardPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPersonal.Controls.Add(this.panelPersonalContent);
            this.cardPersonal.Controls.Add(this.lblPersonalTitle);
            this.cardPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cardPersonal.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cardPersonal.Location = new System.Drawing.Point(0, 0);
            this.cardPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.cardPersonal.Name = "cardPersonal";
            this.cardPersonal.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cardPersonal.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cardPersonal.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.cardPersonal.Size = new System.Drawing.Size(560, 468);
            this.cardPersonal.TabIndex = 0;
            this.cardPersonal.Text = "nightPanel2";
            // 
            // panelPersonalContent
            // 
            this.panelPersonalContent.BackColor = System.Drawing.Color.Transparent;
            this.panelPersonalContent.Controls.Add(this.lblCCCD);
            this.panelPersonalContent.Controls.Add(this.lblCCCDLabel);
            this.panelPersonalContent.Controls.Add(this.lblBirth);
            this.panelPersonalContent.Controls.Add(this.lblBirthLabel);
            this.panelPersonalContent.Controls.Add(this.lblGender);
            this.panelPersonalContent.Controls.Add(this.lblGenderLabel);
            this.panelPersonalContent.Controls.Add(this.lblEmail);
            this.panelPersonalContent.Controls.Add(this.lblEmailLabel);
            this.panelPersonalContent.Controls.Add(this.lblPhone);
            this.panelPersonalContent.Controls.Add(this.lblPhoneLabel);
            this.panelPersonalContent.Location = new System.Drawing.Point(0, 74);
            this.panelPersonalContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelPersonalContent.Name = "panelPersonalContent";
            this.panelPersonalContent.Size = new System.Drawing.Size(560, 388);
            this.panelPersonalContent.TabIndex = 1;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.BackColor = System.Drawing.Color.Transparent;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblCCCD.Location = new System.Drawing.Point(33, 319);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(144, 25);
            this.lblCCCD.TabIndex = 9;
            this.lblCCCD.Text = "001234567890";
            // 
            // lblCCCDLabel
            // 
            this.lblCCCDLabel.AutoSize = true;
            this.lblCCCDLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblCCCDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblCCCDLabel.Location = new System.Drawing.Point(33, 283);
            this.lblCCCDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCCDLabel.Name = "lblCCCDLabel";
            this.lblCCCDLabel.Size = new System.Drawing.Size(64, 28);
            this.lblCCCDLabel.TabIndex = 8;
            this.lblCCCDLabel.Text = "CCCD:";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblBirth.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblBirth.Location = new System.Drawing.Point(33, 251);
            this.lblBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(116, 25);
            this.lblBirth.TabIndex = 7;
            this.lblBirth.Text = "15/08/1995";
            // 
            // lblBirthLabel
            // 
            this.lblBirthLabel.AutoSize = true;
            this.lblBirthLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblBirthLabel.Location = new System.Drawing.Point(33, 215);
            this.lblBirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthLabel.Name = "lblBirthLabel";
            this.lblBirthLabel.Size = new System.Drawing.Size(103, 28);
            this.lblBirthLabel.TabIndex = 6;
            this.lblBirthLabel.Text = "Ngày sinh:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblGender.Location = new System.Drawing.Point(33, 183);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(40, 25);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Nữ";
            // 
            // lblGenderLabel
            // 
            this.lblGenderLabel.AutoSize = true;
            this.lblGenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblGenderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblGenderLabel.Location = new System.Drawing.Point(33, 148);
            this.lblGenderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenderLabel.Name = "lblGenderLabel";
            this.lblGenderLabel.Size = new System.Drawing.Size(91, 28);
            this.lblGenderLabel.TabIndex = 4;
            this.lblGenderLabel.Text = "Giới tính:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblEmail.Location = new System.Drawing.Point(33, 116);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(219, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "ngocanhtu@gmail.com";
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblEmailLabel.Location = new System.Drawing.Point(33, 80);
            this.lblEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(63, 28);
            this.lblEmailLabel.TabIndex = 2;
            this.lblEmailLabel.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblPhone.Location = new System.Drawing.Point(33, 48);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(132, 25);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "0123 456 789";
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblPhoneLabel.Location = new System.Drawing.Point(33, 12);
            this.lblPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(132, 28);
            this.lblPhoneLabel.TabIndex = 0;
            this.lblPhoneLabel.Text = "Số điện thoại:";
            // 
            // lblPersonalTitle
            // 
            this.lblPersonalTitle.AutoSize = true;
            this.lblPersonalTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.lblPersonalTitle.Location = new System.Drawing.Point(27, 25);
            this.lblPersonalTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonalTitle.Name = "lblPersonalTitle";
            this.lblPersonalTitle.Size = new System.Drawing.Size(262, 32);
            this.lblPersonalTitle.TabIndex = 0;
            this.lblPersonalTitle.Text = "📋 Thông tin cá nhân";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblPosition.Location = new System.Drawing.Point(327, 437);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(547, 28);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "B-0012 - Nhân viên thiết kế - Khối đồi mối - Văn phòng MISA";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblName.Location = new System.Drawing.Point(320, 369);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(313, 62);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ngọc Anh Tú";
            // 
            // panelCover
            // 
            this.panelCover.Controls.Add(this.picCover);
            this.panelCover.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelCover.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.panelCover.Location = new System.Drawing.Point(5, 5);
            this.panelCover.Margin = new System.Windows.Forms.Padding(4);
            this.panelCover.Name = "panelCover";
            this.panelCover.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.panelCover.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.panelCover.Size = new System.Drawing.Size(1248, 345);
            this.panelCover.TabIndex = 0;
            this.panelCover.Text = "nightPanel1";
            // 
            // picCover
            // 
            this.picCover.BackColor = System.Drawing.Color.Transparent;
            this.picCover.BackgroundImage = global::UI.Properties.Resources.bg21;
            this.picCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCover.Location = new System.Drawing.Point(0, 0);
            this.picCover.Margin = new System.Windows.Forms.Padding(4);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(1248, 345);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCover.TabIndex = 0;
            this.picCover.TabStop = false;
            // 
            // picImg
            // 
            this.picImg.BackColor = System.Drawing.Color.Transparent;
            this.picImg.BorderColor = System.Drawing.Color.White;
            this.picImg.BorderColor2 = System.Drawing.Color.SpringGreen;
            this.picImg.BorderSize = 5;
            this.picImg.GradientBorder = true;
            this.picImg.Image = ((System.Drawing.Image)(resources.GetObject("picImg.Image")));
            this.picImg.Location = new System.Drawing.Point(70, 258);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(181, 181);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 10;
            this.picImg.TabStop = false;
            // 
            // ProfileUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfileUC";
            this.Size = new System.Drawing.Size(1333, 862);
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.cardAddress.ResumeLayout(false);
            this.cardAddress.PerformLayout();
            this.cardWork.ResumeLayout(false);
            this.cardWork.PerformLayout();
            this.panelWorkContent.ResumeLayout(false);
            this.panelWorkContent.PerformLayout();
            this.cardPersonal.ResumeLayout(false);
            this.cardPersonal.PerformLayout();
            this.panelPersonalContent.ResumeLayout(false);
            this.panelPersonalContent.PerformLayout();
            this.panelCover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private ReaLTaiizor.Controls.Panel panelContent;
        private ReaLTaiizor.Controls.NightPanel panelCover;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel panelCards;

        // Card Personal Info
        private ReaLTaiizor.Controls.NightPanel cardPersonal;
        private System.Windows.Forms.Label lblPersonalTitle;
        private System.Windows.Forms.Panel panelPersonalContent;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGenderLabel;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthLabel;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblCCCDLabel;
        private System.Windows.Forms.Label lblCCCD;

        // Card Work Info
        private ReaLTaiizor.Controls.NightPanel cardWork;
        private System.Windows.Forms.Label lblWorkTitle;
        private System.Windows.Forms.Panel panelWorkContent;
        private System.Windows.Forms.Label lblRoleLabel;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblWageLabel;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lblRegisterLabel;
        private System.Windows.Forms.Label lblRegister;

        // Card Address
        private ReaLTaiizor.Controls.NightPanel cardAddress;
        private System.Windows.Forms.Label lblAddressTitle;
        private System.Windows.Forms.Label lblAddressContent;
        private Controls.CircularPictureBox picImg;
    }
}