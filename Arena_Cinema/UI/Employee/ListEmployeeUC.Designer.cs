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
            this.btnAddEmployee = new ReaLTaiizor.Controls.MaterialButton();
            this.txtSearch = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboRole = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboStatus = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboDepartment = new ReaLTaiizor.Controls.MaterialComboBox();
            this.panelEmployeeList = new System.Windows.Forms.FlowLayoutPanel();
            this.cardEmployeeSample = new ReaLTaiizor.Controls.MaterialCard();
            this.panelCardContent = new System.Windows.Forms.Panel();
            this.btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            this.btnEdit = new ReaLTaiizor.Controls.MaterialButton();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.lblEmployeeRole = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelEmployeeList.SuspendLayout();
            this.cardEmployeeSample.SuspendLayout();
            this.panelCardContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelHeader.Size = new System.Drawing.Size(1630, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Danh sách nhân viên";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.btnAddEmployee);
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.cboRole);
            this.panelFilter.Controls.Add(this.cboStatus);
            this.panelFilter.Controls.Add(this.cboDepartment);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 60);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelFilter.Size = new System.Drawing.Size(1630, 90);
            this.panelFilter.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.AutoSize = false;
            this.btnAddEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddEmployee.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddEmployee.Depth = 0;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddEmployee.HighEmphasis = true;
            this.btnAddEmployee.Icon = null;
            this.btnAddEmployee.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnAddEmployee.Location = new System.Drawing.Point(1331, 18);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddEmployee.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddEmployee.Size = new System.Drawing.Size(275, 50);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "+ Thêm nhân viên";
            this.btnAddEmployee.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddEmployee.UseAccentColor = false;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
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
            this.txtSearch.Size = new System.Drawing.Size(380, 48);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.UseSystemPasswordChar = false;
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
            this.cboRole.Location = new System.Drawing.Point(1039, 20);
            this.cboRole.MaxDropDownItems = 4;
            this.cboRole.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(265, 49);
            this.cboRole.StartIndex = 0;
            this.cboRole.TabIndex = 3;
            // 
            // cboStatus
            // 
            this.cboStatus.AutoResize = false;
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStatus.Depth = 0;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboStatus.DropDownHeight = 174;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.DropDownWidth = 121;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Hint = "Trạng thái";
            this.cboStatus.IntegralHeight = false;
            this.cboStatus.ItemHeight = 43;
            this.cboStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Đang làm việc",
            "Nghỉ phép",
            "Đã nghỉ việc"});
            this.cboStatus.Location = new System.Drawing.Point(737, 19);
            this.cboStatus.MaxDropDownItems = 4;
            this.cboStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(265, 49);
            this.cboStatus.StartIndex = 0;
            this.cboStatus.TabIndex = 2;
            // 
            // cboDepartment
            // 
            this.cboDepartment.AutoResize = false;
            this.cboDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboDepartment.Depth = 0;
            this.cboDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboDepartment.DropDownHeight = 174;
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.DropDownWidth = 121;
            this.cboDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Hint = "Phòng ban";
            this.cboDepartment.IntegralHeight = false;
            this.cboDepartment.ItemHeight = 43;
            this.cboDepartment.Items.AddRange(new object[] {
            "Tất cả",
            "Kinh doanh",
            "Kỹ thuật",
            "Nhân sự",
            "Marketing"});
            this.cboDepartment.Location = new System.Drawing.Point(433, 18);
            this.cboDepartment.MaxDropDownItems = 4;
            this.cboDepartment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(272, 49);
            this.cboDepartment.StartIndex = 0;
            this.cboDepartment.TabIndex = 1;
            // 
            // panelEmployeeList
            // 
            this.panelEmployeeList.AutoScroll = true;
            this.panelEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelEmployeeList.Controls.Add(this.cardEmployeeSample);
            this.panelEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmployeeList.Location = new System.Drawing.Point(0, 150);
            this.panelEmployeeList.Name = "panelEmployeeList";
            this.panelEmployeeList.Padding = new System.Windows.Forms.Padding(20);
            this.panelEmployeeList.Size = new System.Drawing.Size(1630, 550);
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
            this.cardEmployeeSample.Size = new System.Drawing.Size(508, 194);
            this.cardEmployeeSample.TabIndex = 0;
            // 
            // panelCardContent
            // 
            this.panelCardContent.Controls.Add(this.btnDelete);
            this.panelCardContent.Controls.Add(this.btnEdit);
            this.panelCardContent.Controls.Add(this.lblEmployeePhone);
            this.panelCardContent.Controls.Add(this.lblEmployeeEmail);
            this.panelCardContent.Controls.Add(this.lblEmployeeRole);
            this.panelCardContent.Controls.Add(this.lblEmployeeName);
            this.panelCardContent.Controls.Add(this.lblEmployeeId);
            this.panelCardContent.Controls.Add(this.pictureBoxEmployee);
            this.panelCardContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardContent.Location = new System.Drawing.Point(15, 15);
            this.panelCardContent.Name = "panelCardContent";
            this.panelCardContent.Size = new System.Drawing.Size(478, 164);
            this.panelCardContent.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnDelete.Location = new System.Drawing.Point(395, 122);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(70, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEdit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnEdit.Location = new System.Drawing.Point(305, 122);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(80, 36);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmployeePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblEmployeePhone.Location = new System.Drawing.Point(135, 95);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(123, 20);
            this.lblEmployeePhone.TabIndex = 5;
            this.lblEmployeePhone.Text = "SĐT: 0123456789";
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmployeeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblEmployeeEmail.Location = new System.Drawing.Point(135, 75);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(187, 20);
            this.lblEmployeeEmail.TabIndex = 4;
            this.lblEmployeeEmail.Text = "Email: nhanvien@mail.com";
            // 
            // lblEmployeeRole
            // 
            this.lblEmployeeRole.AutoSize = true;
            this.lblEmployeeRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblEmployeeRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeRole.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeRole.Location = new System.Drawing.Point(135, 50);
            this.lblEmployeeRole.Name = "lblEmployeeRole";
            this.lblEmployeeRole.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.lblEmployeeRole.Size = new System.Drawing.Size(92, 25);
            this.lblEmployeeRole.TabIndex = 3;
            this.lblEmployeeRole.Text = "Nhân viên";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblEmployeeName.Location = new System.Drawing.Point(135, 18);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(147, 28);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "Nguyễn Văn A";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEmployeeId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblEmployeeId.Location = new System.Drawing.Point(135, 2);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(73, 19);
            this.lblEmployeeId.TabIndex = 1;
            this.lblEmployeeId.Text = "ID: NV001";
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxEmployee.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmployee.TabIndex = 0;
            this.pictureBoxEmployee.TabStop = false;
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
            this.panelEmployeeList.ResumeLayout(false);
            this.cardEmployeeSample.ResumeLayout(false);
            this.panelCardContent.ResumeLayout(false);
            this.panelCardContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #region Component Designer generated code - Fields
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private ReaLTaiizor.Controls.MaterialButton btnAddEmployee;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSearch;
        private ReaLTaiizor.Controls.MaterialComboBox cboRole;
        private ReaLTaiizor.Controls.MaterialComboBox cboStatus;
        private ReaLTaiizor.Controls.MaterialComboBox cboDepartment;
        private System.Windows.Forms.FlowLayoutPanel panelEmployeeList;
        private ReaLTaiizor.Controls.MaterialCard cardEmployeeSample;
        private System.Windows.Forms.Panel panelCardContent;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
        private ReaLTaiizor.Controls.MaterialButton btnEdit;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeeRole;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        #endregion

        #endregion
    }
}
