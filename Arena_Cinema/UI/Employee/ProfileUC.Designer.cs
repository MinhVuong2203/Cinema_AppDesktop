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
            this.picImg = new UI.Controls.CircularPictureBox();
            this.panelCards = new System.Windows.Forms.Panel();
            this.nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            this.roundedPanel1 = new UI.Controls.RoundedPanel();
            this.skyButton1 = new ReaLTaiizor.Controls.SkyButton();
            this.btnOk = new ReaLTaiizor.Controls.SkyButton();
            this.cardAppearance = new UI.Controls.RoundedPanel();
            this.lblColor = new System.Windows.Forms.Label();
            this.colorPicker = new ReaLTaiizor.Controls.CyberColorPicker();
            this.lblPreview = new System.Windows.Forms.Label();
            this.cardLang = new UI.Controls.RoundedPanel();
            this.lblLang = new System.Windows.Forms.Label();
            this.cbLang = new ReaLTaiizor.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.panelCards.SuspendLayout();
            this.nightPanel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.cardAppearance.SuspendLayout();
            this.cardLang.SuspendLayout();
            this.cardAddress.SuspendLayout();
            this.cardWork.SuspendLayout();
            this.panelWorkContent.SuspendLayout();
            this.cardPersonal.SuspendLayout();
            this.panelPersonalContent.SuspendLayout();
            this.panelCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
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
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1630, 1000);
            this.panelMain.TabIndex = 0;
            //this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.picImg);
            this.panelContent.Controls.Add(this.panelCards);
            this.panelContent.Controls.Add(this.lblPosition);
            this.panelContent.Controls.Add(this.lblName);
            this.panelContent.Controls.Add(this.panelCover);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelContent.Location = new System.Drawing.Point(20, 20);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(4);
            this.panelContent.Size = new System.Drawing.Size(1590, 960);
            this.panelContent.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelContent.TabIndex = 0;
            this.panelContent.Text = "panel1";
            //this.panelContent.Click += new System.EventHandler(this.panelContent_Click);
            // 
            // picImg
            // 
            this.picImg.BackColor = System.Drawing.Color.Transparent;
            this.picImg.BorderColor = System.Drawing.Color.White;
            this.picImg.BorderColor2 = System.Drawing.Color.SpringGreen;
            this.picImg.BorderSize = 5;
            this.picImg.GradientBorder = true;
            this.picImg.Image = ((System.Drawing.Image)(resources.GetObject("picImg.Image")));
            this.picImg.Location = new System.Drawing.Point(52, 210);
            this.picImg.Margin = new System.Windows.Forms.Padding(2);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(147, 147);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 10;
            this.picImg.TabStop = false;
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Controls.Add(this.nightPanel1);
            this.panelCards.Controls.Add(this.cardAddress);
            this.panelCards.Controls.Add(this.cardWork);
            this.panelCards.Controls.Add(this.cardPersonal);
            this.panelCards.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCards.Location = new System.Drawing.Point(4, 397);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(1582, 559);
            this.panelCards.TabIndex = 4;
            //this.panelCards.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCards_Paint);
            // 
            // nightPanel1
            // 
            this.nightPanel1.Controls.Add(this.roundedPanel1);
            this.nightPanel1.Controls.Add(this.cardAppearance);
            this.nightPanel1.Controls.Add(this.cardLang);
            this.nightPanel1.Controls.Add(this.label2);
            this.nightPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.nightPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightPanel1.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nightPanel1.Location = new System.Drawing.Point(1081, 0);
            this.nightPanel1.Name = "nightPanel1";
            this.nightPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.nightPanel1.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.nightPanel1.Size = new System.Drawing.Size(501, 559);
            this.nightPanel1.TabIndex = 11;
            this.nightPanel1.Text = "nightPanel4";
            //this.nightPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.nightPanel1_Paint);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roundedPanel1.BorderThickness = 2F;
            this.roundedPanel1.Controls.Add(this.skyButton1);
            this.roundedPanel1.Controls.Add(this.btnOk);
            this.roundedPanel1.Location = new System.Drawing.Point(23, 445);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(461, 65);
            this.roundedPanel1.TabIndex = 5;
            //this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // skyButton1
            // 
            this.skyButton1.BackColor = System.Drawing.Color.Transparent;
            this.skyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skyButton1.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.DownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skyButton1.DownShadowForeColor = System.Drawing.Color.White;
            this.skyButton1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyButton1.ForeColor = System.Drawing.Color.White;
            this.skyButton1.HoverBGColorA = System.Drawing.Color.WhiteSmoke;
            this.skyButton1.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.skyButton1.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.HoverForeColor = System.Drawing.Color.Black;
            this.skyButton1.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.skyButton1.Location = new System.Drawing.Point(260, 9);
            this.skyButton1.Margin = new System.Windows.Forms.Padding(2);
            this.skyButton1.Name = "skyButton1";
            this.skyButton1.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.NormalForeColor = System.Drawing.Color.White;
            this.skyButton1.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skyButton1.Size = new System.Drawing.Size(162, 43);
            this.skyButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.skyButton1.TabIndex = 4;
            this.skyButton1.Text = global::UI.Resources.Lang.DangXuat;
            this.skyButton1.Click += new System.EventHandler(this.skyButton1_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.DownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOk.DownShadowForeColor = System.Drawing.Color.White;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.HoverBGColorA = System.Drawing.Color.WhiteSmoke;
            this.btnOk.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOk.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.HoverForeColor = System.Drawing.Color.Black;
            this.btnOk.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.Location = new System.Drawing.Point(51, 10);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.NormalForeColor = System.Drawing.Color.White;
            this.btnOk.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.Size = new System.Drawing.Size(171, 43);
            this.btnOk.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = global::UI.Resources.Lang.LuuThayDoi;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cardAppearance
            // 
            this.cardAppearance.BackColor = System.Drawing.Color.White;
            this.cardAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cardAppearance.BorderRadius = 20;
            this.cardAppearance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardAppearance.BorderThickness = 2F;
            this.cardAppearance.Controls.Add(this.lblColor);
            this.cardAppearance.Controls.Add(this.colorPicker);
            this.cardAppearance.Controls.Add(this.lblPreview);
            this.cardAppearance.Location = new System.Drawing.Point(23, 65);
            this.cardAppearance.Margin = new System.Windows.Forms.Padding(2);
            this.cardAppearance.Name = "cardAppearance";
            this.cardAppearance.Size = new System.Drawing.Size(461, 221);
            this.cardAppearance.TabIndex = 3;
            //this.cardAppearance.Paint += new System.Windows.Forms.PaintEventHandler(this.cardAppearance_Paint);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblColor.ForeColor = System.Drawing.Color.Black;
            this.lblColor.Location = new System.Drawing.Point(16, 12);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(82, 25);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = global::UI.Resources.Lang.MauSac;
            //this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Transparent;
            this.colorPicker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.colorPicker.Location = new System.Drawing.Point(98, 29);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.SelectedColor = System.Drawing.Color.Empty;
            this.colorPicker.Size = new System.Drawing.Size(191, 159);
            this.colorPicker.TabIndex = 4;
            this.colorPicker.Tag = "Cyber";
            this.colorPicker.ColorChanged += new ReaLTaiizor.Controls.CyberColorPicker.EventHandler(this.colorPicker_ColorChanged);
            //this.colorPicker.Load += new System.EventHandler(this.colorPicker_Load);
            // 
            // lblPreview
            // 
            this.lblPreview.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPreview.Location = new System.Drawing.Point(328, 68);
            this.lblPreview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(103, 56);
            this.lblPreview.TabIndex = 5;
            // 
            // cardLang
            // 
            this.cardLang.BackColor = System.Drawing.Color.White;
            this.cardLang.BorderColor = System.Drawing.Color.LightGray;
            this.cardLang.BorderRadius = 20;
            this.cardLang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardLang.BorderThickness = 2F;
            this.cardLang.Controls.Add(this.lblLang);
            this.cardLang.Controls.Add(this.cbLang);
            this.cardLang.Location = new System.Drawing.Point(23, 327);
            this.cardLang.Margin = new System.Windows.Forms.Padding(2);
            this.cardLang.Name = "cardLang";
            this.cardLang.Size = new System.Drawing.Size(461, 65);
            this.cardLang.TabIndex = 2;
            //this.cardLang.Paint += new System.Windows.Forms.PaintEventHandler(this.cardLang_Paint);
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblLang.ForeColor = System.Drawing.Color.Black;
            this.lblLang.Location = new System.Drawing.Point(63, 19);
            this.lblLang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(97, 25);
            this.lblLang.TabIndex = 0;
            this.lblLang.Text = global::UI.Resources.Lang.NgonNgu;
            //this.lblLang.Click += new System.EventHandler(this.lblLang_Click);
            // 
            // cbLang
            // 
            this.cbLang.AutoResize = false;
            this.cbLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbLang.Depth = 0;
            this.cbLang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbLang.DropDownHeight = 174;
            this.cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLang.DropDownWidth = 121;
            this.cbLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbLang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbLang.IntegralHeight = false;
            this.cbLang.ItemHeight = 43;
            this.cbLang.Items.AddRange(new object[] {
            "Tiếng Việt",
            "Tiếng Anh"});
            this.cbLang.Location = new System.Drawing.Point(164, 7);
            this.cbLang.Margin = new System.Windows.Forms.Padding(2);
            this.cbLang.MaxDropDownItems = 4;
            this.cbLang.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(230, 49);
            this.cbLang.StartIndex = 0;
            this.cbLang.TabIndex = 1;
            this.cbLang.SelectedIndexChanged += new System.EventHandler(this.cbLang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = global::UI.Resources.Lang.IconCaiDatHeThong;
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cardAddress
            // 
            this.cardAddress.Controls.Add(this.lblAddressContent);
            this.cardAddress.Controls.Add(this.lblAddressTitle);
            this.cardAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cardAddress.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cardAddress.Location = new System.Drawing.Point(0, 408);
            this.cardAddress.Name = "cardAddress";
            this.cardAddress.Padding = new System.Windows.Forms.Padding(5);
            this.cardAddress.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.cardAddress.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.cardAddress.Size = new System.Drawing.Size(706, 93);
            this.cardAddress.TabIndex = 2;
            this.cardAddress.Text = "nightPanel4";
            //this.cardAddress.Paint += new System.Windows.Forms.PaintEventHandler(this.cardAddress_Paint);
            // 
            // lblAddressContent
            // 
            this.lblAddressContent.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressContent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblAddressContent.Location = new System.Drawing.Point(25, 60);
            this.lblAddressContent.Name = "lblAddressContent";
            this.lblAddressContent.Size = new System.Drawing.Size(830, 28);
            this.lblAddressContent.TabIndex = 1;
            this.lblAddressContent.Text = "123 Đường Nguyễn Văn Linh, Phường Tân Phú, Quận 7, Thành phố Hồ Chí Minh";
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblAddressTitle.Location = new System.Drawing.Point(20, 20);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(98, 25);
            this.lblAddressTitle.TabIndex = 0;
            this.lblAddressTitle.Text = global::UI.Resources.Lang.IconDiaChi;
            // 
            // cardWork
            // 
            this.cardWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardWork.Controls.Add(this.panelWorkContent);
            this.cardWork.Controls.Add(this.lblWorkTitle);
            this.cardWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cardWork.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cardWork.Location = new System.Drawing.Point(354, 0);
            this.cardWork.Name = "cardWork";
            this.cardWork.Padding = new System.Windows.Forms.Padding(5);
            this.cardWork.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cardWork.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.cardWork.Size = new System.Drawing.Size(352, 381);
            this.cardWork.TabIndex = 1;
            this.cardWork.Text = "nightPanel3";
            //this.cardWork.Paint += new System.Windows.Forms.PaintEventHandler(this.cardWork_Paint);
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
            this.panelWorkContent.Location = new System.Drawing.Point(0, 60);
            this.panelWorkContent.Name = "panelWorkContent";
            this.panelWorkContent.Size = new System.Drawing.Size(420, 315);
            this.panelWorkContent.TabIndex = 1;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblRegister.Location = new System.Drawing.Point(25, 149);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(95, 20);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.Text = "01/01/2020";
            // 
            // lblRegisterLabel
            // 
            this.lblRegisterLabel.AutoSize = true;
            this.lblRegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblRegisterLabel.Location = new System.Drawing.Point(25, 120);
            this.lblRegisterLabel.Name = "lblRegisterLabel";
            this.lblRegisterLabel.Size = new System.Drawing.Size(109, 21);
            this.lblRegisterLabel.TabIndex = 4;
            this.lblRegisterLabel.Text = global::UI.Resources.Lang.NGAYVAOLAM;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.BackColor = System.Drawing.Color.Transparent;
            this.lblWage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblWage.Location = new System.Drawing.Point(25, 94);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(124, 20);
            this.lblWage.TabIndex = 3;
            this.lblWage.Text = "50,000 VNĐ/giờ";
            // 
            // lblWageLabel
            // 
            this.lblWageLabel.AutoSize = true;
            this.lblWageLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblWageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblWageLabel.Location = new System.Drawing.Point(25, 65);
            this.lblWageLabel.Name = "lblWageLabel";
            this.lblWageLabel.Size = new System.Drawing.Size(120, 21);
            this.lblWageLabel.TabIndex = 2;
            this.lblWageLabel.Text = global::UI.Resources.Lang.LuongGio;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblRole.Location = new System.Drawing.Point(25, 39);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(137, 20);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Nhân viên thiết kế";
            // 
            // lblRoleLabel
            // 
            this.lblRoleLabel.AutoSize = true;
            this.lblRoleLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblRoleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblRoleLabel.Location = new System.Drawing.Point(25, 10);
            this.lblRoleLabel.Name = "lblRoleLabel";
            this.lblRoleLabel.Size = new System.Drawing.Size(58, 21);
            this.lblRoleLabel.TabIndex = 0;
            this.lblRoleLabel.Text = global::UI.Resources.Lang.ChucVu;
            // 
            // lblWorkTitle
            // 
            this.lblWorkTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblWorkTitle.Location = new System.Drawing.Point(20, 20);
            this.lblWorkTitle.Name = "lblWorkTitle";
            this.lblWorkTitle.Size = new System.Drawing.Size(374, 26);
            this.lblWorkTitle.TabIndex = 0;
            this.lblWorkTitle.Text = global::UI.Resources.Lang.ThongTinCongViec;
            //this.lblWorkTitle.Click += new System.EventHandler(this.lblWorkTitle_Click);
            // 
            // cardPersonal
            // 
            this.cardPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPersonal.Controls.Add(this.panelPersonalContent);
            this.cardPersonal.Controls.Add(this.lblPersonalTitle);
            this.cardPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cardPersonal.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cardPersonal.Location = new System.Drawing.Point(0, 0);
            this.cardPersonal.Name = "cardPersonal";
            this.cardPersonal.Padding = new System.Windows.Forms.Padding(5);
            this.cardPersonal.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cardPersonal.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.cardPersonal.Size = new System.Drawing.Size(308, 381);
            this.cardPersonal.TabIndex = 0;
            this.cardPersonal.Text = "nightPanel2";
            //this.cardPersonal.Paint += new System.Windows.Forms.PaintEventHandler(this.cardPersonal_Paint);
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
            this.panelPersonalContent.Location = new System.Drawing.Point(0, 60);
            this.panelPersonalContent.Name = "panelPersonalContent";
            this.panelPersonalContent.Size = new System.Drawing.Size(420, 315);
            this.panelPersonalContent.TabIndex = 1;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.BackColor = System.Drawing.Color.Transparent;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblCCCD.Location = new System.Drawing.Point(25, 259);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(117, 20);
            this.lblCCCD.TabIndex = 9;
            this.lblCCCD.Text = "001234567890";
            // 
            // lblCCCDLabel
            // 
            this.lblCCCDLabel.AutoSize = true;
            this.lblCCCDLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblCCCDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblCCCDLabel.Location = new System.Drawing.Point(25, 230);
            this.lblCCCDLabel.Name = "lblCCCDLabel";
            this.lblCCCDLabel.Size = new System.Drawing.Size(54, 21);
            this.lblCCCDLabel.TabIndex = 8;
            this.lblCCCDLabel.Text = "CCCD:";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblBirth.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblBirth.Location = new System.Drawing.Point(25, 204);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(95, 20);
            this.lblBirth.TabIndex = 7;
            this.lblBirth.Text = "15/08/1995";
            // 
            // lblBirthLabel
            // 
            this.lblBirthLabel.AutoSize = true;
            this.lblBirthLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblBirthLabel.Location = new System.Drawing.Point(25, 175);
            this.lblBirthLabel.Name = "lblBirthLabel";
            this.lblBirthLabel.Size = new System.Drawing.Size(83, 21);
            this.lblBirthLabel.TabIndex = 6;
            this.lblBirthLabel.Text = global::UI.Resources.Lang.NgaySinh;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblGender.Location = new System.Drawing.Point(25, 149);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(31, 20);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Nữ";
            // 
            // lblGenderLabel
            // 
            this.lblGenderLabel.AutoSize = true;
            this.lblGenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblGenderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblGenderLabel.Location = new System.Drawing.Point(25, 120);
            this.lblGenderLabel.Name = "lblGenderLabel";
            this.lblGenderLabel.Size = new System.Drawing.Size(73, 21);
            this.lblGenderLabel.TabIndex = 4;
            this.lblGenderLabel.Text = global::UI.Resources.Lang.GioiTinh;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblEmail.Location = new System.Drawing.Point(25, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(171, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "ngocanhtu@gmail.com";
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblEmailLabel.Location = new System.Drawing.Point(25, 65);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(51, 21);
            this.lblEmailLabel.TabIndex = 2;
            this.lblEmailLabel.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblPhone.Location = new System.Drawing.Point(25, 39);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(107, 20);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "0123 456 789";
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblPhoneLabel.Location = new System.Drawing.Point(25, 10);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(104, 21);
            this.lblPhoneLabel.TabIndex = 0;
            this.lblPhoneLabel.Text = global::UI.Resources.Lang.SoDienThoai;
            // 
            // lblPersonalTitle
            // 
            this.lblPersonalTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.lblPersonalTitle.Location = new System.Drawing.Point(20, 20);
            this.lblPersonalTitle.Name = "lblPersonalTitle";
            this.lblPersonalTitle.Size = new System.Drawing.Size(364, 26);
            this.lblPersonalTitle.TabIndex = 0;
            this.lblPersonalTitle.Text = global::UI.Resources.Lang.IconThongTinCaNhan;
            //this.lblPersonalTitle.Click += new System.EventHandler(this.lblPersonalTitle_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblPosition.Location = new System.Drawing.Point(245, 343);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(433, 21);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "B-0012 - Nhân viên thiết kế - Khối đồi mối - Văn phòng MISA";
            //this.lblPosition.Click += new System.EventHandler(this.lblPosition_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblName.Location = new System.Drawing.Point(240, 286);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(252, 51);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ngọc Anh Tú";
            //this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // panelCover
            // 
            this.panelCover.Controls.Add(this.picCover);
            this.panelCover.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelCover.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.panelCover.Location = new System.Drawing.Point(4, 4);
            this.panelCover.Name = "panelCover";
            this.panelCover.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.panelCover.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.panelCover.Size = new System.Drawing.Size(1582, 280);
            this.panelCover.TabIndex = 0;
            this.panelCover.Text = "nightPanel1";
            // 
            // picCover
            // 
            this.picCover.BackColor = System.Drawing.Color.Transparent;
            this.picCover.BackgroundImage = global::UI.Properties.Resources.bg2;
            this.picCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCover.Location = new System.Drawing.Point(0, 0);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(1582, 280);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCover.TabIndex = 0;
            this.picCover.TabStop = false;
            //this.picCover.Click += new System.EventHandler(this.picCover_Click);
            // 
            // ProfileUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panelMain);
            this.Name = "ProfileUC";
            this.Size = new System.Drawing.Size(1630, 1000);
            //this.Load += new System.EventHandler(this.ProfileUC_Load);
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.panelCards.ResumeLayout(false);
            this.nightPanel1.ResumeLayout(false);
            this.nightPanel1.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.cardAppearance.ResumeLayout(false);
            this.cardAppearance.PerformLayout();
            this.cardLang.ResumeLayout(false);
            this.cardLang.PerformLayout();
            this.cardAddress.ResumeLayout(false);
            this.cardAddress.PerformLayout();
            this.cardWork.ResumeLayout(false);
            this.panelWorkContent.ResumeLayout(false);
            this.panelWorkContent.PerformLayout();
            this.cardPersonal.ResumeLayout(false);
            this.panelPersonalContent.ResumeLayout(false);
            this.panelPersonalContent.PerformLayout();
            this.panelCover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
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
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private System.Windows.Forms.Label label2;
        private Controls.RoundedPanel cardLang;
        private System.Windows.Forms.Label lblLang;
        private ReaLTaiizor.Controls.MaterialComboBox cbLang;
        private Controls.RoundedPanel cardAppearance;
        private System.Windows.Forms.Label lblColor;
        private ReaLTaiizor.Controls.CyberColorPicker colorPicker;
        private System.Windows.Forms.Label lblPreview;
        private ReaLTaiizor.Controls.SkyButton skyButton1;
        private ReaLTaiizor.Controls.SkyButton btnOk;
        private Controls.RoundedPanel roundedPanel1;
    }
}