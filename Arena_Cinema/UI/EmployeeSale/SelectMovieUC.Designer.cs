namespace UI.EmployeeSale
{
    partial class SelectMovieUC
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpEmployeeInfo;
        private System.Windows.Forms.PictureBox picAVT;
        private System.Windows.Forms.Label lb_EmName;
        private System.Windows.Forms.Label lb_EmpIDText;
        private System.Windows.Forms.Label lb_BranchText;
        private System.Windows.Forms.Label lb_EmailText;
        private System.Windows.Forms.Label lb_PhoneText;
        private System.Windows.Forms.Label lb_BthDayText;
        private System.Windows.Forms.Label lb_SalaryText;
        private System.Windows.Forms.Label lb_workDateText;
        private System.Windows.Forms.Label lbMovieListTitle;
        private System.Windows.Forms.FlowLayoutPanel flpMovies;

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
            this.grpEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.picAVT = new System.Windows.Forms.PictureBox();
            this.lb_EmName = new System.Windows.Forms.Label();
            this.lb_EmpIDText = new System.Windows.Forms.Label();
            this.lb_BranchText = new System.Windows.Forms.Label();
            this.lb_EmailText = new System.Windows.Forms.Label();
            this.lb_PhoneText = new System.Windows.Forms.Label();
            this.lb_BthDayText = new System.Windows.Forms.Label();
            this.lb_SalaryText = new System.Windows.Forms.Label();
            this.lb_workDateText = new System.Windows.Forms.Label();
            this.lbMovieListTitle = new System.Windows.Forms.Label();
            this.flpMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_back = new ReaLTaiizor.Controls.ParrotButton();
            this.grpEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAVT)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmployeeInfo
            // 
            this.grpEmployeeInfo.Controls.Add(this.picAVT);
            this.grpEmployeeInfo.Controls.Add(this.lb_EmName);
            this.grpEmployeeInfo.Controls.Add(this.lb_EmpIDText);
            this.grpEmployeeInfo.Controls.Add(this.lb_BranchText);
            this.grpEmployeeInfo.Controls.Add(this.lb_EmailText);
            this.grpEmployeeInfo.Controls.Add(this.lb_PhoneText);
            this.grpEmployeeInfo.Controls.Add(this.lb_BthDayText);
            this.grpEmployeeInfo.Controls.Add(this.lb_SalaryText);
            this.grpEmployeeInfo.Controls.Add(this.lb_workDateText);
            this.grpEmployeeInfo.Location = new System.Drawing.Point(20, 96);
            this.grpEmployeeInfo.Name = "grpEmployeeInfo";
            this.grpEmployeeInfo.Size = new System.Drawing.Size(593, 353);
            this.grpEmployeeInfo.TabIndex = 0;
            this.grpEmployeeInfo.TabStop = false;
            this.grpEmployeeInfo.Text = "Thông tin nhân viên";
            // 
            // picAVT
            // 
            this.picAVT.Location = new System.Drawing.Point(20, 30);
            this.picAVT.Name = "picAVT";
            this.picAVT.Size = new System.Drawing.Size(80, 115);
            this.picAVT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAVT.TabIndex = 0;
            this.picAVT.TabStop = false;
            // 
            // lb_EmName
            // 
            this.lb_EmName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmName.Location = new System.Drawing.Point(120, 30);
            this.lb_EmName.Name = "lb_EmName";
            this.lb_EmName.Size = new System.Drawing.Size(448, 31);
            this.lb_EmName.TabIndex = 1;
            this.lb_EmName.Text = "Tên nhân viên";
            // 
            // lb_EmpIDText
            // 
            this.lb_EmpIDText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmpIDText.Location = new System.Drawing.Point(120, 61);
            this.lb_EmpIDText.Name = "lb_EmpIDText";
            this.lb_EmpIDText.Size = new System.Drawing.Size(448, 26);
            this.lb_EmpIDText.TabIndex = 2;
            //this.lb_EmpIDText.Text = "Mã NV";
            this.lb_EmpIDText.Text = global::UI.Resources.Lang.MaNV;
            // 
            // lb_BranchText
            // 
            this.lb_BranchText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BranchText.Location = new System.Drawing.Point(120, 93);
            this.lb_BranchText.Name = "lb_BranchText";
            this.lb_BranchText.Size = new System.Drawing.Size(448, 30);
            this.lb_BranchText.TabIndex = 3;
            this.lb_BranchText.Text = "Chi nhánh";
            // 
            // lb_EmailText
            // 
            this.lb_EmailText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EmailText.Location = new System.Drawing.Point(120, 130);
            this.lb_EmailText.Name = "lb_EmailText";
            this.lb_EmailText.Size = new System.Drawing.Size(448, 28);
            this.lb_EmailText.TabIndex = 4;
            this.lb_EmailText.Text = "Email";
            // 
            // lb_PhoneText
            // 
            this.lb_PhoneText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhoneText.Location = new System.Drawing.Point(120, 166);
            this.lb_PhoneText.Name = "lb_PhoneText";
            this.lb_PhoneText.Size = new System.Drawing.Size(448, 29);
            this.lb_PhoneText.TabIndex = 5;
            this.lb_PhoneText.Text = "SĐT";
            // 
            // lb_BthDayText
            // 
            this.lb_BthDayText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BthDayText.Location = new System.Drawing.Point(120, 201);
            this.lb_BthDayText.Name = "lb_BthDayText";
            this.lb_BthDayText.Size = new System.Drawing.Size(448, 26);
            this.lb_BthDayText.TabIndex = 6;
            this.lb_BthDayText.Text = "Ngày sinh";
            // 
            // lb_SalaryText
            // 
            this.lb_SalaryText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SalaryText.Location = new System.Drawing.Point(120, 237);
            this.lb_SalaryText.Name = "lb_SalaryText";
            this.lb_SalaryText.Size = new System.Drawing.Size(448, 27);
            this.lb_SalaryText.TabIndex = 7;
            this.lb_SalaryText.Text = "Lương";
            // 
            // lb_workDateText
            // 
            this.lb_workDateText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_workDateText.Location = new System.Drawing.Point(120, 274);
            this.lb_workDateText.Name = "lb_workDateText";
            this.lb_workDateText.Size = new System.Drawing.Size(448, 27);
            this.lb_workDateText.TabIndex = 8;
            this.lb_workDateText.Text = "Ngày vào làm";
            // 
            // lbMovieListTitle
            // 
            this.lbMovieListTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbMovieListTitle.Location = new System.Drawing.Point(664, 20);
            this.lbMovieListTitle.Name = "lbMovieListTitle";
            this.lbMovieListTitle.Size = new System.Drawing.Size(400, 30);
            this.lbMovieListTitle.TabIndex = 1;
            this.lbMovieListTitle.Text = "Danh sách phim đang chiếu ";
            // 
            // flpMovies
            // 
            this.flpMovies.AutoScroll = true;
            this.flpMovies.Location = new System.Drawing.Point(636, 60);
            this.flpMovies.Name = "flpMovies";
            this.flpMovies.Size = new System.Drawing.Size(981, 700);
            this.flpMovies.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_back.ButtonImage = global::UI.Properties.Resources.chevrons;
            this.btn_back.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btn_back.ButtonText = "";
            this.btn_back.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_back.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.CornerRadius = 5;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_back.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_back.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btn_back.Location = new System.Drawing.Point(40, 20);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(57, 50);
            this.btn_back.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_back.TabIndex = 3;
            this.btn_back.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_back.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SelectMovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.grpEmployeeInfo);
            this.Controls.Add(this.lbMovieListTitle);
            this.Controls.Add(this.flpMovies);
            this.Name = "SelectMovieUC";
            this.Size = new System.Drawing.Size(1630, 800);
            this.grpEmployeeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAVT)).EndInit();
            this.ResumeLayout(false);

        }

        private ReaLTaiizor.Controls.ParrotButton btn_back;
    }
}
