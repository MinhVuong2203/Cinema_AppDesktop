namespace UI.Employee
{
    partial class ListEmployeeUC
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.btnWorking = new ReaLTaiizor.Controls.DungeonToggleButton();
            this.txtSearch = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboRole = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboGender = new ReaLTaiizor.Controls.MaterialComboBox();
            this.panelEmployeeList = new System.Windows.Forms.FlowLayoutPanel();
            this.cardEmployeeSample = new ReaLTaiizor.Controls.MaterialCard();
            this.panelCardContent = new System.Windows.Forms.Panel();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.lblEmployeeRole = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.btnSua = new ReaLTaiizor.Controls.MaterialButton();
            this.btnXoa = new ReaLTaiizor.Controls.MaterialButton();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.btnAddEmployee = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPrev = new ReaLTaiizor.Controls.ParrotButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.parrotGroupBox1.SuspendLayout();
            this.panelEmployeeList.SuspendLayout();
            this.cardEmployeeSample.SuspendLayout();
            this.panelCardContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnPrev);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelHeader.Size = new System.Drawing.Size(1630, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblTitle.Location = new System.Drawing.Point(56, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Danh sách nhân viên";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.Beige;
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFilter.Controls.Add(this.parrotGroupBox1);
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.cboRole);
            this.panelFilter.Controls.Add(this.cboGender);
            this.panelFilter.Controls.Add(this.panel1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 50);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(10);
            this.panelFilter.Size = new System.Drawing.Size(1630, 90);
            this.panelFilter.TabIndex = 1;
            // 
            // parrotGroupBox1
            // 
            this.parrotGroupBox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox1.BorderWidth = 1;
            this.parrotGroupBox1.Controls.Add(this.btnWorking);
            this.parrotGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotGroupBox1.Location = new System.Drawing.Point(1305, 5);
            this.parrotGroupBox1.Name = "parrotGroupBox1";
            this.parrotGroupBox1.ShowText = true;
            this.parrotGroupBox1.Size = new System.Drawing.Size(140, 72);
            this.parrotGroupBox1.TabIndex = 1;
            this.parrotGroupBox1.TabStop = false;
            this.parrotGroupBox1.Text = "Đã nghỉ việc";
            this.parrotGroupBox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // btnWorking
            // 
            this.btnWorking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorking.Location = new System.Drawing.Point(27, 33);
            this.btnWorking.Name = "btnWorking";
            this.btnWorking.Size = new System.Drawing.Size(79, 27);
            this.btnWorking.TabIndex = 5;
            this.btnWorking.Text = "dungeonToggleButton1";
            this.btnWorking.Toggled = false;
            this.btnWorking.ToggledBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnWorking.ToggledBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.btnWorking.ToggledBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(89)))), ((int)(((byte)(55)))));
            this.btnWorking.ToggledBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(89)))), ((int)(((byte)(55)))));
            this.btnWorking.ToggledBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnWorking.ToggledBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnWorking.ToggledColorA = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(58)))));
            this.btnWorking.ToggledColorB = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(113)))), ((int)(((byte)(63)))));
            this.btnWorking.ToggledColorC = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnWorking.ToggledColorD = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnWorking.ToggledIOColorA = System.Drawing.Color.WhiteSmoke;
            this.btnWorking.ToggledIOColorB = System.Drawing.Color.DimGray;
            this.btnWorking.ToggledOnOffColorA = System.Drawing.Color.WhiteSmoke;
            this.btnWorking.ToggledOnOffColorB = System.Drawing.Color.DimGray;
            this.btnWorking.ToggledYesNoColorA = System.Drawing.Color.WhiteSmoke;
            this.btnWorking.ToggledYesNoColorB = System.Drawing.Color.DimGray;
            this.btnWorking.Type = ReaLTaiizor.Controls.DungeonToggleButton._Type.OnOff;
            this.btnWorking.ToggledChanged += new ReaLTaiizor.Controls.DungeonToggleButton.ToggledChangedEventHandler(this.btnWorking_ToggledChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.HideSelection = true;
            this.txtSearch.Hint = "Tìm kiếm nhân viên...";
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PrefixSuffixText = null;
            this.txtSearch.ReadOnly = false;
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(497, 48);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboRole
            // 
            this.cboRole.AutoResize = false;
            this.cboRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboRole.Depth = 0;
            this.cboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboRole.DropDownHeight = 174;
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.DropDownWidth = 121;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Hint = "Chức vụ";
            this.cboRole.IntegralHeight = false;
            this.cboRole.ItemHeight = 43;
            this.cboRole.Items.AddRange(new object[] {
            "Tất cả",
            "Quản lý",
            "Nhân viên",
            "Thu ngân"});
            this.cboRole.Location = new System.Drawing.Point(523, 18);
            this.cboRole.MaxDropDownItems = 4;
            this.cboRole.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(373, 49);
            this.cboRole.StartIndex = 0;
            this.cboRole.TabIndex = 3;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // cboGender
            // 
            this.cboGender.AutoResize = false;
            this.cboGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGender.Depth = 0;
            this.cboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboGender.DropDownHeight = 174;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.DropDownWidth = 121;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Hint = "Giới tính";
            this.cboGender.IntegralHeight = false;
            this.cboGender.ItemHeight = 43;
            this.cboGender.Items.AddRange(new object[] {
            "Tất cả",
            "Nam",
            "Nữ"});
            this.cboGender.Location = new System.Drawing.Point(902, 18);
            this.cboGender.MaxDropDownItems = 4;
            this.cboGender.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(385, 49);
            this.cboGender.StartIndex = 0;
            this.cboGender.TabIndex = 2;
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            // 
            // panelEmployeeList
            // 
            this.panelEmployeeList.AutoScroll = true;
            this.panelEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelEmployeeList.Controls.Add(this.cardEmployeeSample);
            this.panelEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmployeeList.Location = new System.Drawing.Point(0, 140);
            this.panelEmployeeList.Name = "panelEmployeeList";
            this.panelEmployeeList.Padding = new System.Windows.Forms.Padding(20);
            this.panelEmployeeList.Size = new System.Drawing.Size(1630, 560);
            this.panelEmployeeList.TabIndex = 2;
            // 
            // cardEmployeeSample
            // 
            this.cardEmployeeSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardEmployeeSample.Controls.Add(this.panelCardContent);
            this.cardEmployeeSample.Depth = 0;
            this.cardEmployeeSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardEmployeeSample.Location = new System.Drawing.Point(23, 23);
            this.cardEmployeeSample.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.cardEmployeeSample.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cardEmployeeSample.Name = "cardEmployeeSample";
            this.cardEmployeeSample.Padding = new System.Windows.Forms.Padding(15);
            this.cardEmployeeSample.Size = new System.Drawing.Size(462, 244);
            this.cardEmployeeSample.TabIndex = 0;
            // 
            // panelCardContent
            // 
            this.panelCardContent.Controls.Add(this.btnSua);
            this.panelCardContent.Controls.Add(this.lblEmployeePhone);
            this.panelCardContent.Controls.Add(this.lblEmployeeEmail);
            this.panelCardContent.Controls.Add(this.btnXoa);
            this.panelCardContent.Controls.Add(this.lblEmployeeRole);
            this.panelCardContent.Controls.Add(this.lblEmployeeName);
            this.panelCardContent.Controls.Add(this.lblEmployeeId);
            this.panelCardContent.Controls.Add(this.pictureBoxEmployee);
            this.panelCardContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardContent.Location = new System.Drawing.Point(15, 15);
            this.panelCardContent.Name = "panelCardContent";
            this.panelCardContent.Size = new System.Drawing.Size(432, 214);
            this.panelCardContent.TabIndex = 0;
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblEmployeePhone.Location = new System.Drawing.Point(135, 132);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(166, 28);
            this.lblEmployeePhone.TabIndex = 5;
            this.lblEmployeePhone.Text = "SĐT: 0123456789";
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblEmployeeEmail.Location = new System.Drawing.Point(135, 102);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(245, 28);
            this.lblEmployeeEmail.TabIndex = 4;
            this.lblEmployeeEmail.Text = "Email: nhanvien@mail.com";
            // 
            // lblEmployeeRole
            // 
            this.lblEmployeeRole.AutoSize = true;
            this.lblEmployeeRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblEmployeeRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeRole.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeRole.Location = new System.Drawing.Point(138, 71);
            this.lblEmployeeRole.Name = "lblEmployeeRole";
            this.lblEmployeeRole.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.lblEmployeeRole.Size = new System.Drawing.Size(106, 29);
            this.lblEmployeeRole.TabIndex = 3;
            this.lblEmployeeRole.Text = "Nhân viên";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblEmployeeName.Location = new System.Drawing.Point(136, 35);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(160, 30);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "Nguyễn Văn A";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.ForeColor = System.Drawing.Color.Brown;
            this.lblEmployeeId.Location = new System.Drawing.Point(139, 13);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(92, 23);
            this.lblEmployeeId.TabIndex = 1;
            this.lblEmployeeId.Text = "ID: NV001";
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = false;
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = global::UI.Properties.Resources.edit;
            this.btnSua.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSua.Location = new System.Drawing.Point(223, 164);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(100, 42);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = global::UI.Properties.Resources.trash;
            this.btnXoa.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(327, 163);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(100, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = true;
            this.btnXoa.UseMnemonic = false;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxEmployee.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(120, 160);
            this.pictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmployee.TabIndex = 0;
            this.pictureBoxEmployee.TabStop = false;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.ButtonImage = global::UI.Properties.Resources.user;
            this.btnAddEmployee.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnAddEmployee.ButtonText = "";
            this.btnAddEmployee.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnAddEmployee.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddEmployee.CornerRadius = 5;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddEmployee.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddEmployee.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnAddEmployee.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddEmployee.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(67, 62);
            this.btnAddEmployee.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnAddEmployee.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAddEmployee.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPrev.ButtonImage = global::UI.Properties.Resources.chevrons;
            this.btnPrev.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnPrev.ButtonText = "";
            this.btnPrev.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnPrev.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPrev.CornerRadius = 5;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrev.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPrev.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPrev.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnPrev.Location = new System.Drawing.Point(8, 6);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(44, 38);
            this.btnPrev.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPrev.TabIndex = 1;
            this.btnPrev.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnPrev.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPrev.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAddEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1545, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 66);
            this.panel1.TabIndex = 4;
            // 
            // ListEmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelEmployeeList);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelHeader);
            this.Name = "ListEmployeeUC";
            this.Size = new System.Drawing.Size(1630, 700);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.parrotGroupBox1.ResumeLayout(false);
            this.parrotGroupBox1.PerformLayout();
            this.panelEmployeeList.ResumeLayout(false);
            this.cardEmployeeSample.ResumeLayout(false);
            this.panelCardContent.ResumeLayout(false);
            this.panelCardContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region Component Designer generated code - Fields
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSearch;
        private ReaLTaiizor.Controls.MaterialComboBox cboRole;
        private ReaLTaiizor.Controls.MaterialComboBox cboGender;
        private System.Windows.Forms.FlowLayoutPanel panelEmployeeList;
        private ReaLTaiizor.Controls.MaterialCard cardEmployeeSample;
        private System.Windows.Forms.Panel panelCardContent;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeeRole;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        #endregion

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnPrev;
        private ReaLTaiizor.Controls.MaterialButton btnXoa;
        private ReaLTaiizor.Controls.MaterialButton btnSua;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.DungeonToggleButton btnWorking;
        private ReaLTaiizor.Controls.ParrotButton btnAddEmployee;
        private System.Windows.Forms.Panel panel1;
    }
}
