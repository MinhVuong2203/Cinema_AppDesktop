namespace UI.Revenue
{
    partial class Main_RevenueUC
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnQuarter = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.dtpSelectDate = new System.Windows.Forms.DateTimePicker();
            this.lblTopCount = new System.Windows.Forms.Label();
            this.cboTopCount = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalRevenueValue = new System.Windows.Forms.Label();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.lblTotalTicketsValue = new System.Windows.Forms.Label();
            this.lblTotalMovies = new System.Windows.Forms.Label();
            this.lblTotalMoviesValue = new System.Windows.Forms.Label();
            this.lblAverageRevenue = new System.Windows.Forms.Label();
            this.lblAverageRevenueValue = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvMovieRevenue = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1360, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DOANH THU CÁC PHIM";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.btnRefresh);
            this.pnlFilter.Controls.Add(this.cboTopCount);
            this.pnlFilter.Controls.Add(this.lblTopCount);
            this.pnlFilter.Controls.Add(this.dtpSelectDate);
            this.pnlFilter.Controls.Add(this.lblSelectDate);
            this.pnlFilter.Controls.Add(this.btnYear);
            this.pnlFilter.Controls.Add(this.btnQuarter);
            this.pnlFilter.Controls.Add(this.btnMonth);
            this.pnlFilter.Controls.Add(this.btnWeek);
            this.pnlFilter.Controls.Add(this.btnDay);
            this.pnlFilter.Controls.Add(this.lblFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 60);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(15);
            this.pnlFilter.Size = new System.Drawing.Size(1360, 100);
            this.pnlFilter.TabIndex = 1;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilter.Location = new System.Drawing.Point(20, 20);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(106, 19);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Lọc theo thời gian:";
            // 
            // btnDay
            // 
            this.btnDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDay.ForeColor = System.Drawing.Color.White;
            this.btnDay.Location = new System.Drawing.Point(24, 50);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(80, 35);
            this.btnDay.TabIndex = 1;
            this.btnDay.Text = "Ngày";
            this.btnDay.UseVisualStyleBackColor = false;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeek.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWeek.ForeColor = System.Drawing.Color.White;
            this.btnWeek.Location = new System.Drawing.Point(110, 50);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(80, 35);
            this.btnWeek.TabIndex = 2;
            this.btnWeek.Text = "Tuần";
            this.btnWeek.UseVisualStyleBackColor = false;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.Location = new System.Drawing.Point(196, 50);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(80, 35);
            this.btnMonth.TabIndex = 3;
            this.btnMonth.Text = "Tháng";
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnQuarter
            // 
            this.btnQuarter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnQuarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuarter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuarter.ForeColor = System.Drawing.Color.White;
            this.btnQuarter.Location = new System.Drawing.Point(282, 50);
            this.btnQuarter.Name = "btnQuarter";
            this.btnQuarter.Size = new System.Drawing.Size(80, 35);
            this.btnQuarter.TabIndex = 4;
            this.btnQuarter.Text = "Quý";
            this.btnQuarter.UseVisualStyleBackColor = false;
            this.btnQuarter.Click += new System.EventHandler(this.btnQuarter_Click);
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.Location = new System.Drawing.Point(368, 50);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(80, 35);
            this.btnYear.TabIndex = 5;
            this.btnYear.Text = "Năm";
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectDate.Location = new System.Drawing.Point(480, 20);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(70, 15);
            this.lblSelectDate.TabIndex = 6;
            this.lblSelectDate.Text = "Chọn ngày:";
            // 
            // dtpSelectDate
            // 
            this.dtpSelectDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSelectDate.Location = new System.Drawing.Point(483, 50);
            this.dtpSelectDate.Name = "dtpSelectDate";
            this.dtpSelectDate.Size = new System.Drawing.Size(150, 23);
            this.dtpSelectDate.TabIndex = 7;
            this.dtpSelectDate.ValueChanged += new System.EventHandler(this.dtpSelectDate_ValueChanged);
            // 
            // lblTopCount
            // 
            this.lblTopCount.AutoSize = true;
            this.lblTopCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTopCount.Location = new System.Drawing.Point(670, 20);
            this.lblTopCount.Name = "lblTopCount";
            this.lblTopCount.Size = new System.Drawing.Size(82, 15);
            this.lblTopCount.TabIndex = 8;
            this.lblTopCount.Text = "Hiển thị Top:";
            // 
            // cboTopCount
            // 
            this.cboTopCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTopCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTopCount.FormattingEnabled = true;
            this.cboTopCount.Location = new System.Drawing.Point(673, 50);
            this.cboTopCount.Name = "cboTopCount";
            this.cboTopCount.Size = new System.Drawing.Size(100, 23);
            this.cboTopCount.TabIndex = 9;
            this.cboTopCount.SelectedIndexChanged += new System.EventHandler(this.cboTopCount_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(810, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.BackColor = System.Drawing.Color.White;
            this.pnlStatistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatistics.Controls.Add(this.lblAverageRevenueValue);
            this.pnlStatistics.Controls.Add(this.lblAverageRevenue);
            this.pnlStatistics.Controls.Add(this.lblTotalMoviesValue);
            this.pnlStatistics.Controls.Add(this.lblTotalMovies);
            this.pnlStatistics.Controls.Add(this.lblTotalTicketsValue);
            this.pnlStatistics.Controls.Add(this.lblTotalTickets);
            this.pnlStatistics.Controls.Add(this.lblTotalRevenueValue);
            this.pnlStatistics.Controls.Add(this.lblTotalRevenue);
            this.pnlStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatistics.Location = new System.Drawing.Point(0, 160);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Padding = new System.Windows.Forms.Padding(15);
            this.pnlStatistics.Size = new System.Drawing.Size(1360, 80);
            this.pnlStatistics.TabIndex = 2;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalRevenue.Location = new System.Drawing.Point(30, 20);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(101, 15);
            this.lblTotalRevenue.TabIndex = 0;
            this.lblTotalRevenue.Text = "Tổng doanh thu:";
            // 
            // lblTotalRevenueValue
            // 
            this.lblTotalRevenueValue.AutoSize = true;
            this.lblTotalRevenueValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTotalRevenueValue.Location = new System.Drawing.Point(28, 40);
            this.lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            this.lblTotalRevenueValue.Size = new System.Drawing.Size(23, 25);
            this.lblTotalRevenueValue.TabIndex = 1;
            this.lblTotalRevenueValue.Text = "0";
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.AutoSize = true;
            this.lblTotalTickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalTickets.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalTickets.Location = new System.Drawing.Point(320, 20);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(86, 15);
            this.lblTotalTickets.TabIndex = 2;
            this.lblTotalTickets.Text = "Tổng số vé:";
            // 
            // lblTotalTicketsValue
            // 
            this.lblTotalTicketsValue.AutoSize = true;
            this.lblTotalTicketsValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalTicketsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTotalTicketsValue.Location = new System.Drawing.Point(318, 40);
            this.lblTotalTicketsValue.Name = "lblTotalTicketsValue";
            this.lblTotalTicketsValue.Size = new System.Drawing.Size(23, 25);
            this.lblTotalTicketsValue.TabIndex = 3;
            this.lblTotalTicketsValue.Text = "0";
            // 
            // lblTotalMovies
            // 
            this.lblTotalMovies.AutoSize = true;
            this.lblTotalMovies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalMovies.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalMovies.Location = new System.Drawing.Point(560, 20);
            this.lblTotalMovies.Name = "lblTotalMovies";
            this.lblTotalMovies.Size = new System.Drawing.Size(89, 15);
            this.lblTotalMovies.TabIndex = 4;
            this.lblTotalMovies.Text = "Số phim:";
            // 
            // lblTotalMoviesValue
            // 
            this.lblTotalMoviesValue.AutoSize = true;
            this.lblTotalMoviesValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalMoviesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblTotalMoviesValue.Location = new System.Drawing.Point(558, 40);
            this.lblTotalMoviesValue.Name = "lblTotalMoviesValue";
            this.lblTotalMoviesValue.Size = new System.Drawing.Size(23, 25);
            this.lblTotalMoviesValue.TabIndex = 5;
            this.lblTotalMoviesValue.Text = "0";
            // 
            // lblAverageRevenue
            // 
            this.lblAverageRevenue.AutoSize = true;
            this.lblAverageRevenue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAverageRevenue.ForeColor = System.Drawing.Color.Gray;
            this.lblAverageRevenue.Location = new System.Drawing.Point(760, 20);
            this.lblAverageRevenue.Name = "lblAverageRevenue";
            this.lblAverageRevenue.Size = new System.Drawing.Size(140, 15);
            this.lblAverageRevenue.TabIndex = 6;
            this.lblAverageRevenue.Text = "Doanh thu TB/phim:";
            // 
            // lblAverageRevenueValue
            // 
            this.lblAverageRevenueValue.AutoSize = true;
            this.lblAverageRevenueValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAverageRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblAverageRevenueValue.Location = new System.Drawing.Point(758, 40);
            this.lblAverageRevenueValue.Name = "lblAverageRevenueValue";
            this.lblAverageRevenueValue.Size = new System.Drawing.Size(23, 25);
            this.lblAverageRevenueValue.TabIndex = 7;
            this.lblAverageRevenueValue.Text = "0";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvMovieRevenue);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 240);
            this.pnlData.Name = "pnlData";
            this.pnlData.Padding = new System.Windows.Forms.Padding(15);
            this.pnlData.Size = new System.Drawing.Size(1360, 560);
            this.pnlData.TabIndex = 3;
            // 
            // dgvMovieRevenue
            // 
            this.dgvMovieRevenue.AllowUserToAddRows = false;
            this.dgvMovieRevenue.AllowUserToDeleteRows = false;
            this.dgvMovieRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovieRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovieRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovieRevenue.Location = new System.Drawing.Point(15, 15);
            this.dgvMovieRevenue.Name = "dgvMovieRevenue";
            this.dgvMovieRevenue.ReadOnly = true;
            this.dgvMovieRevenue.RowHeadersWidth = 51;
            this.dgvMovieRevenue.Size = new System.Drawing.Size(1330, 530);
            this.dgvMovieRevenue.TabIndex = 0;
            this.dgvMovieRevenue.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovieRevenue_CellDoubleClick);
            // 
            // Main_RevenueUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlStatistics);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlTop);
            this.Name = "Main_RevenueUC";
            this.Size = new System.Drawing.Size(1360, 800);
            this.Load += new System.EventHandler(this.Main_RevenueUC_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlStatistics.ResumeLayout(false);
            this.pnlStatistics.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnQuarter;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.DateTimePicker dtpSelectDate;
        private System.Windows.Forms.Label lblTopCount;
        private System.Windows.Forms.ComboBox cboTopCount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalRevenueValue;
        private System.Windows.Forms.Label lblTotalTickets;
        private System.Windows.Forms.Label lblTotalTicketsValue;
        private System.Windows.Forms.Label lblTotalMovies;
        private System.Windows.Forms.Label lblTotalMoviesValue;
        private System.Windows.Forms.Label lblAverageRevenue;
        private System.Windows.Forms.Label lblAverageRevenueValue;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvMovieRevenue;
    }
}