using System;

namespace UI.Employee
{
    partial class AddEmployeeUC
    {
        private ReaLTaiizor.Controls.MaterialTextBox txtFullName;
        private ReaLTaiizor.Controls.MaterialTextBox txtPhone;
        private ReaLTaiizor.Controls.MaterialTextBox txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBox txtAddress;
        private ReaLTaiizor.Controls.MaterialTextBox txtCCCD;
        private ReaLTaiizor.Controls.MaterialTextBox txtHourWage;
        private ReaLTaiizor.Controls.MaterialComboBox cboGender;
        private ReaLTaiizor.Controls.MaterialComboBox cboRole;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.PictureBox picImage;
        private ReaLTaiizor.Controls.ParrotButton btnUploadImage;
        private ReaLTaiizor.Controls.ParrotButton btnSave;
        private ReaLTaiizor.Controls.ParrotButton btnCancel;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeUC));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFullName = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtPhone = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtEmail = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtAddress = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtCCCD = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtHourWage = new ReaLTaiizor.Controls.MaterialTextBox();
            this.cboGender = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboRole = new ReaLTaiizor.Controls.MaterialComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new ReaLTaiizor.Controls.GroupBox();
            this.btnShowPass = new ReaLTaiizor.Controls.ParrotButton();
            this.lbCheckPassword = new System.Windows.Forms.Label();
            this.lbCheckUsername = new System.Windows.Forms.Label();
            this.lbCheckLuong = new System.Windows.Forms.Label();
            this.lbCheckEmail = new System.Windows.Forms.Label();
            this.lbCheckPhone = new System.Windows.Forms.Label();
            this.lbCheckCCCD = new System.Windows.Forms.Label();
            this.lbCheckName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtUsername = new ReaLTaiizor.Controls.MaterialTextBox();
            this.parrotButton2 = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton1 = new ReaLTaiizor.Controls.ParrotButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new ReaLTaiizor.Controls.ParrotButton();
            this.btnSave = new ReaLTaiizor.Controls.ParrotButton();
            this.btnUploadImage = new ReaLTaiizor.Controls.ParrotButton();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnPrev = new ReaLTaiizor.Controls.ParrotButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.lblTitle.Location = new System.Drawing.Point(53, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM NHÂN SỰ";
            // 
            // txtFullName
            // 
            this.txtFullName.AnimateReadOnly = false;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Depth = 0;
            this.txtFullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullName.Hint = "Họ và tên";
            this.txtFullName.LeadingIcon = null;
            this.txtFullName.Location = new System.Drawing.Point(53, 66);
            this.txtFullName.MaxLength = 50;
            this.txtFullName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(350, 50);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.Text = "";
            this.txtFullName.TrailingIcon = null;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.AnimateReadOnly = false;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Depth = 0;
            this.txtPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.Hint = "Số điện thoại";
            this.txtPhone.LeadingIcon = null;
            this.txtPhone.Location = new System.Drawing.Point(53, 147);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(350, 50);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Text = "";
            this.txtPhone.TrailingIcon = null;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(53, 231);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 50);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.Hint = "Địa chỉ";
            this.txtAddress.LeadingIcon = null;
            this.txtAddress.Location = new System.Drawing.Point(53, 384);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(350, 50);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Text = "";
            this.txtAddress.TrailingIcon = null;
            // 
            // txtCCCD
            // 
            this.txtCCCD.AnimateReadOnly = false;
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCD.Depth = 0;
            this.txtCCCD.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCCCD.Hint = "CCCD";
            this.txtCCCD.LeadingIcon = null;
            this.txtCCCD.Location = new System.Drawing.Point(433, 66);
            this.txtCCCD.MaxLength = 50;
            this.txtCCCD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCCCD.Multiline = false;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(350, 50);
            this.txtCCCD.TabIndex = 7;
            this.txtCCCD.Text = "";
            this.txtCCCD.TrailingIcon = null;
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            // 
            // txtHourWage
            // 
            this.txtHourWage.AnimateReadOnly = false;
            this.txtHourWage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHourWage.Depth = 0;
            this.txtHourWage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHourWage.Hint = "Lương giờ";
            this.txtHourWage.LeadingIcon = null;
            this.txtHourWage.Location = new System.Drawing.Point(500, 225);
            this.txtHourWage.MaxLength = 50;
            this.txtHourWage.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtHourWage.Multiline = false;
            this.txtHourWage.Name = "txtHourWage";
            this.txtHourWage.Size = new System.Drawing.Size(166, 50);
            this.txtHourWage.TabIndex = 8;
            this.txtHourWage.Text = "";
            this.txtHourWage.TrailingIcon = null;
            this.txtHourWage.TextChanged += new System.EventHandler(this.txtHourWage_TextChanged);
            this.txtHourWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHourWage_KeyPress);
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
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboGender.IntegralHeight = false;
            this.cboGender.ItemHeight = 43;
            this.cboGender.Items.AddRange(new object[] {
            "--- Chọn giới tính ---",
            "Nam",
            "Nữ"});
            this.cboGender.Location = new System.Drawing.Point(433, 145);
            this.cboGender.MaxDropDownItems = 4;
            this.cboGender.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(350, 49);
            this.cboGender.StartIndex = 0;
            this.cboGender.TabIndex = 6;
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
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboRole.IntegralHeight = false;
            this.cboRole.ItemHeight = 43;
            this.cboRole.Location = new System.Drawing.Point(433, 306);
            this.cboRole.MaxDropDownItems = 4;
            this.cboRole.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(350, 49);
            this.cboRole.StartIndex = 0;
            this.cboRole.TabIndex = 9;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "dd-MM-yyyy";
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(166, 481);
            this.dtpBirthDate.MaxDate = new System.DateTime(2007, 11, 13, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(237, 31);
            this.dtpBirthDate.TabIndex = 5;
            this.dtpBirthDate.Value = new System.DateTime(2007, 11, 13, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackGColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.groupBox1.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.groupBox1.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.groupBox1.Controls.Add(this.btnShowPass);
            this.groupBox1.Controls.Add(this.lbCheckPassword);
            this.groupBox1.Controls.Add(this.lbCheckUsername);
            this.groupBox1.Controls.Add(this.lbCheckLuong);
            this.groupBox1.Controls.Add(this.lbCheckEmail);
            this.groupBox1.Controls.Add(this.lbCheckPhone);
            this.groupBox1.Controls.Add(this.lbCheckCCCD);
            this.groupBox1.Controls.Add(this.lbCheckName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.parrotButton2);
            this.groupBox1.Controls.Add(this.parrotButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.btnUploadImage);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.picImage);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.cboRole);
            this.groupBox1.Controls.Add(this.dtpBirthDate);
            this.groupBox1.Controls.Add(this.txtHourWage);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(119, 52);
            this.groupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(1069, 637);
            this.groupBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.groupBox1.TabIndex = 16;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackgroundColor = System.Drawing.Color.White;
            this.btnShowPass.ButtonImage = global::UI.Properties.Resources.OpenEyes1;
            this.btnShowPass.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnShowPass.ButtonText = "";
            this.btnShowPass.ClickBackColor = System.Drawing.Color.White;
            this.btnShowPass.ClickTextColor = System.Drawing.Color.White;
            this.btnShowPass.CornerRadius = 5;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowPass.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnShowPass.HoverTextColor = System.Drawing.Color.White;
            this.btnShowPass.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnShowPass.Location = new System.Drawing.Point(784, 484);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(33, 30);
            this.btnShowPass.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnShowPass.TabIndex = 29;
            this.btnShowPass.TextColor = System.Drawing.Color.Black;
            this.btnShowPass.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnShowPass.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // lbCheckPassword
            // 
            this.lbCheckPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckPassword.ForeColor = System.Drawing.Color.Red;
            this.lbCheckPassword.Location = new System.Drawing.Point(435, 437);
            this.lbCheckPassword.Name = "lbCheckPassword";
            this.lbCheckPassword.Size = new System.Drawing.Size(626, 23);
            this.lbCheckPassword.TabIndex = 28;
            // 
            // lbCheckUsername
            // 
            this.lbCheckUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckUsername.ForeColor = System.Drawing.Color.Red;
            this.lbCheckUsername.Location = new System.Drawing.Point(435, 358);
            this.lbCheckUsername.Name = "lbCheckUsername";
            this.lbCheckUsername.Size = new System.Drawing.Size(626, 23);
            this.lbCheckUsername.TabIndex = 27;
            // 
            // lbCheckLuong
            // 
            this.lbCheckLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckLuong.ForeColor = System.Drawing.Color.Red;
            this.lbCheckLuong.Location = new System.Drawing.Point(435, 199);
            this.lbCheckLuong.Name = "lbCheckLuong";
            this.lbCheckLuong.Size = new System.Drawing.Size(362, 20);
            this.lbCheckLuong.TabIndex = 26;
            this.lbCheckLuong.Text = "Lương không được để trống";
            // 
            // lbCheckEmail
            // 
            this.lbCheckEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckEmail.ForeColor = System.Drawing.Color.Red;
            this.lbCheckEmail.Location = new System.Drawing.Point(55, 208);
            this.lbCheckEmail.Name = "lbCheckEmail";
            this.lbCheckEmail.Size = new System.Drawing.Size(362, 20);
            this.lbCheckEmail.TabIndex = 25;
            this.lbCheckEmail.Text = "Email không được để trống";
            // 
            // lbCheckPhone
            // 
            this.lbCheckPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckPhone.ForeColor = System.Drawing.Color.Red;
            this.lbCheckPhone.Location = new System.Drawing.Point(55, 124);
            this.lbCheckPhone.Name = "lbCheckPhone";
            this.lbCheckPhone.Size = new System.Drawing.Size(362, 20);
            this.lbCheckPhone.TabIndex = 24;
            this.lbCheckPhone.Text = "Số điện thoại không được để trống";
            // 
            // lbCheckCCCD
            // 
            this.lbCheckCCCD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckCCCD.ForeColor = System.Drawing.Color.Red;
            this.lbCheckCCCD.Location = new System.Drawing.Point(433, 42);
            this.lbCheckCCCD.Name = "lbCheckCCCD";
            this.lbCheckCCCD.Size = new System.Drawing.Size(362, 20);
            this.lbCheckCCCD.TabIndex = 23;
            this.lbCheckCCCD.Text = "CCCD không được để trống";
            // 
            // lbCheckName
            // 
            this.lbCheckName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckName.ForeColor = System.Drawing.Color.Red;
            this.lbCheckName.Location = new System.Drawing.Point(55, 42);
            this.lbCheckName.Name = "lbCheckName";
            this.lbCheckName.Size = new System.Drawing.Size(372, 24);
            this.lbCheckName.TabIndex = 22;
            this.lbCheckName.Text = "Họ và tên không được để trống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(669, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "/h";
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
           
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(433, 462);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(350, 50);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "Tên đăng nhập";
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(433, 384);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 50);
            this.txtUsername.TabIndex = 19;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // parrotButton2
            // 
            this.parrotButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.parrotButton2.ButtonImage = global::UI.Properties.Resources.minus;
            this.parrotButton2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton2.ButtonText = "";
            this.parrotButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.parrotButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton2.CornerRadius = 5;
            this.parrotButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.parrotButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton2.Location = new System.Drawing.Point(712, 231);
            this.parrotButton2.Name = "parrotButton2";
            this.parrotButton2.Size = new System.Drawing.Size(44, 38);
            this.parrotButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton2.TabIndex = 18;
            this.parrotButton2.TextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton2.Click += new System.EventHandler(this.parrotButton2_Click);
            // 
            // parrotButton1
            // 
            this.parrotButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.parrotButton1.ButtonImage = global::UI.Properties.Resources.sign;
            this.parrotButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton1.ButtonText = "";
            this.parrotButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.parrotButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton1.CornerRadius = 5;
            this.parrotButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.parrotButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton1.Location = new System.Drawing.Point(456, 231);
            this.parrotButton1.Name = "parrotButton1";
            this.parrotButton1.Size = new System.Drawing.Size(44, 38);
            this.parrotButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton1.TabIndex = 17;
            this.parrotButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton1.Click += new System.EventHandler(this.parrotButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ngày sinh:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnCancel.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ButtonImage")));
            this.btnCancel.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnCancel.ButtonText = "Đặt lại";
            this.btnCancel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnCancel.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.CornerRadius = 5;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnCancel.Location = new System.Drawing.Point(580, 566);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 38);
            this.btnCancel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCancel.TabIndex = 13;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.ButtonImage = global::UI.Properties.Resources.diskette;
            this.btnSave.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnSave.ButtonText = "Lưu";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.CornerRadius = 5;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(374, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 38);
            this.btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSave.TabIndex = 12;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnUploadImage.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnUploadImage.ButtonImage")));
            this.btnUploadImage.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Dark;
            this.btnUploadImage.ButtonText = "Tải ảnh lên";
            this.btnUploadImage.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnUploadImage.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnUploadImage.CornerRadius = 5;
            this.btnUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadImage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUploadImage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnUploadImage.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnUploadImage.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnUploadImage.Location = new System.Drawing.Point(858, 322);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(128, 33);
            this.btnUploadImage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnUploadImage.TabIndex = 11;
            this.btnUploadImage.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnUploadImage.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnUploadImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // picImage
            // 
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(833, 76);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(180, 240);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 10;
            this.picImage.TabStop = false;
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
            this.btnPrev.Location = new System.Drawing.Point(3, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(44, 38);
            this.btnPrev.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPrev.TabIndex = 14;
            this.btnPrev.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnPrev.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPrev.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // AddEmployeeUC
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddEmployeeUC";
            this.Size = new System.Drawing.Size(1332, 745);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ReaLTaiizor.Controls.ParrotButton btnPrev;
        private ReaLTaiizor.Controls.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton2;
        private ReaLTaiizor.Controls.MaterialTextBox txtPassword;
        private ReaLTaiizor.Controls.MaterialTextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCheckEmail;
        private System.Windows.Forms.Label lbCheckPhone;
        private System.Windows.Forms.Label lbCheckCCCD;
        private System.Windows.Forms.Label lbCheckName;
        private System.Windows.Forms.Label lbCheckLuong;
        private System.Windows.Forms.Label lbCheckPassword;
        private System.Windows.Forms.Label lbCheckUsername;
        private ReaLTaiizor.Controls.ParrotButton btnShowPass;
    }
}
