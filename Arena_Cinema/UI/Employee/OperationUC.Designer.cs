namespace UI.Employee
{
    partial class OperationUC
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
        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private ReaLTaiizor.Controls.ParrotGradientPanel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private ReaLTaiizor.Controls.HopeTextBox txtSearch;
        private System.Windows.Forms.Label lblRole;
        private ReaLTaiizor.Controls.HopeComboBox cboRole;
        private System.Windows.Forms.DataGridView dgvPermissions;

        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colOpSample;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.hopeButton1 = new ReaLTaiizor.Controls.HopeButton();
            this.cboRole = new ReaLTaiizor.Controls.HopeComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtSearch = new ReaLTaiizor.Controls.HopeTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPermissions = new System.Windows.Forms.DataGridView();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpSample = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tlpRoot.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.pnlTop, 0, 0);
            this.tlpRoot.Controls.Add(this.dgvPermissions, 0, 1);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 3;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpRoot.Size = new System.Drawing.Size(1261, 469);
            this.tlpRoot.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BottomLeft = System.Drawing.Color.DimGray;
            this.pnlTop.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlTop.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.pnlTop.Controls.Add(this.hopeButton1);
            this.pnlTop.Controls.Add(this.cboRole);
            this.pnlTop.Controls.Add(this.lblRole);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.pnlTop.Location = new System.Drawing.Point(12, 12);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(12, 12, 12, 8);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.pnlTop.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.pnlTop.PrimerColor = System.Drawing.Color.White;
            this.pnlTop.Size = new System.Drawing.Size(1237, 58);
            this.pnlTop.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlTop.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.pnlTop.TabIndex = 0;
            this.pnlTop.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pnlTop.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.pnlTop.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // hopeButton1
            // 
            this.hopeButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButton1.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButton1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.hopeButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButton1.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButton1.Location = new System.Drawing.Point(1100, 12);
            this.hopeButton1.Name = "hopeButton1";
            this.hopeButton1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButton1.Size = new System.Drawing.Size(123, 34);
            this.hopeButton1.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButton1.TabIndex = 5;
            this.hopeButton1.Text = "Lưu";
            this.hopeButton1.TextColor = System.Drawing.Color.White;
            this.hopeButton1.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButton1.Click += new System.EventHandler(this.hopeButton1_Click);
            // 
            // cboRole
            // 
            this.cboRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.ItemHeight = 24;
            this.cboRole.Location = new System.Drawing.Point(780, 15);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(189, 30);
            this.cboRole.TabIndex = 4;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.lblRole.Location = new System.Drawing.Point(695, 16);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(81, 25);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Chức vụ";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(235)))));
            this.txtSearch.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(235)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(378, 10);
            this.txtSearch.MaxLength = 200;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(272, 40);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.lblSearch.Location = new System.Drawing.Point(286, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(90, 25);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Tìm kiếm";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHÂN QUYỀN THAO TÁC";
            // 
            // dgvPermissions
            // 
            this.dgvPermissions.AllowUserToAddRows = false;
            this.dgvPermissions.AllowUserToDeleteRows = false;
            this.dgvPermissions.AllowUserToResizeRows = false;
            this.dgvPermissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPermissions.BackgroundColor = System.Drawing.Color.White;
            this.dgvPermissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPermissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPermissions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.dgvPermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPermissions.ColumnHeadersHeight = 40;
            this.dgvPermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeId,
            this.colFullName,
            this.colRoleName,
            this.colOpSample});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermissions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPermissions.EnableHeadersVisualStyles = false;
            this.dgvPermissions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.dgvPermissions.Location = new System.Drawing.Point(12, 86);
            this.dgvPermissions.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.dgvPermissions.MultiSelect = false;
            this.dgvPermissions.Name = "dgvPermissions";
            this.dgvPermissions.RowHeadersVisible = false;
            this.dgvPermissions.RowHeadersWidth = 51;
            this.dgvPermissions.RowTemplate.Height = 30;
            this.dgvPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermissions.Size = new System.Drawing.Size(1237, 345);
            this.dgvPermissions.TabIndex = 1;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.DataPropertyName = "EmployeeID";
            this.colEmployeeId.HeaderText = "EmployeeID";
            this.colEmployeeId.MinimumWidth = 6;
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.Visible = false;
            this.colEmployeeId.Width = 138;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "Nhân viên";
            this.colFullName.MinimumWidth = 180;
            this.colFullName.Name = "colFullName";
            this.colFullName.Width = 180;
            // 
            // colRoleName
            // 
            this.colRoleName.HeaderText = "Role";
            this.colRoleName.MinimumWidth = 100;
            this.colRoleName.Name = "colRoleName";
            // 
            // colOpSample
            // 
            this.colOpSample.HeaderText = "OP_SAMPLE";
            this.colOpSample.MinimumWidth = 110;
            this.colOpSample.Name = "colOpSample";
            this.colOpSample.Width = 113;
            // 
            // OperationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.tlpRoot);
            this.Name = "OperationUC";
            this.Size = new System.Drawing.Size(1261, 469);
            this.tlpRoot.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private ReaLTaiizor.Controls.HopeButton hopeButton1;
    }
}
