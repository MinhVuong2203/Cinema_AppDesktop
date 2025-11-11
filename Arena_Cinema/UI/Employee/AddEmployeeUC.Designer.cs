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
        private ReaLTaiizor.Controls.MaterialComboBox cbGender;
        private ReaLTaiizor.Controls.MaterialComboBox cbRole;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.PictureBox picImage;
        private ReaLTaiizor.Controls.ParrotButton btnUploadImage;
        private ReaLTaiizor.Controls.ParrotButton btnSave;
        private ReaLTaiizor.Controls.ParrotButton btnCancel;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFullName = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtPhone = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtEmail = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtAddress = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtCCCD = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtHourWage = new ReaLTaiizor.Controls.MaterialTextBox();
            this.cbGender = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cbRole = new ReaLTaiizor.Controls.MaterialComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new ReaLTaiizor.Controls.ParrotButton();
            this.btnSave = new ReaLTaiizor.Controls.ParrotButton();
            this.btnCancel = new ReaLTaiizor.Controls.ParrotButton();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(181, 18, 27);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 41);
            this.lblTitle.Text = "THÊM NHÂN VIÊN";
            // 
            // txtFullName
            // 
            this.txtFullName.Hint = "Họ và tên";
            this.txtFullName.Location = new System.Drawing.Point(40, 90);
            this.txtFullName.Size = new System.Drawing.Size(350, 48);
            // 
            // txtPhone
            // 
            this.txtPhone.Hint = "Số điện thoại";
            this.txtPhone.Location = new System.Drawing.Point(40, 160);
            this.txtPhone.Size = new System.Drawing.Size(350, 48);
            // 
            // txtEmail
            // 
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(40, 230);
            this.txtEmail.Size = new System.Drawing.Size(350, 48);
            // 
            // txtAddress
            // 
            this.txtAddress.Hint = "Địa chỉ";
            this.txtAddress.Location = new System.Drawing.Point(40, 300);
            this.txtAddress.Size = new System.Drawing.Size(350, 48);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpBirthDate.Location = new System.Drawing.Point(40, 370);
            this.dtpBirthDate.Size = new System.Drawing.Size(350, 34);
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            this.cbGender.Location = new System.Drawing.Point(40, 430);
            this.cbGender.Size = new System.Drawing.Size(350, 49);
            this.cbGender.StartIndex = 0;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Hint = "CCCD";
            this.txtCCCD.Location = new System.Drawing.Point(420, 90);
            this.txtCCCD.Size = new System.Drawing.Size(350, 48);
            // 
            // txtHourWage
            // 
            this.txtHourWage.Hint = "Lương giờ";
            this.txtHourWage.Location = new System.Drawing.Point(420, 160);
            this.txtHourWage.Size = new System.Drawing.Size(350, 48);
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbRole.Location = new System.Drawing.Point(420, 230);
            this.cbRole.Size = new System.Drawing.Size(350, 49);
            this.cbRole.StartIndex = 0;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(820, 100);
            this.picImage.Size = new System.Drawing.Size(180, 180);
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Text = "Tải ảnh lên";
            this.btnUploadImage.Location = new System.Drawing.Point(820, 290);
            this.btnUploadImage.Size = new System.Drawing.Size(180, 45);
            this.btnUploadImage.BackgroundColor = System.Drawing.Color.FromArgb(65, 70, 75);
            this.btnUploadImage.HoverBackgroundColor = System.Drawing.Color.FromArgb(181, 18, 27);
            this.btnUploadImage.TextColor = System.Drawing.Color.White;
            this.btnUploadImage.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            // 
            // btnSave
            // 
            this.btnSave.Text = "Lưu";
            this.btnSave.Location = new System.Drawing.Point(720, 450);
            this.btnSave.Size = new System.Drawing.Size(130, 50);
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(0, 200, 180);
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            // 
            // btnCancel
            // 
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Location = new System.Drawing.Point(880, 450);
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(181, 18, 27);
            this.btnCancel.HoverBackgroundColor = System.Drawing.Color.FromArgb(210, 30, 40);
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            // 
            // AddEmployeeUC
            // 
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtHourWage);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Size = new System.Drawing.Size(1050, 550);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
