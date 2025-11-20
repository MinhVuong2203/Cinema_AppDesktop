namespace UI.Movie
{
    partial class MovieReportUC
    {
        private System.ComponentModel.IContainer components = null;

        // Member fields
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblTotalMovies;
        private System.Windows.Forms.Label lblShowingMovies;
        private System.Windows.Forms.Label lblComingMovies;
        private System.Windows.Forms.Label lblEndedMovies;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilterGenre;
        private System.Windows.Forms.Label lblFilterAge;
        private System.Windows.Forms.Label lblFilterStatus;
        public System.Windows.Forms.ComboBox cboGenre;
        public System.Windows.Forms.ComboBox cboAgeLimit;
        public System.Windows.Forms.ComboBox cboStatus;
        public System.Windows.Forms.Button btnApplyFilter;
        public System.Windows.Forms.Button btnResetFilter;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartMovieStats;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartGenreDistribution;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartAgeRatingDistribution;
        public System.Windows.Forms.DataGridView dgvMovies;

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
            this.components = new System.ComponentModel.Container();

            // Panel chính
            pnlMain = new System.Windows.Forms.Panel();

            // Panel tiêu đề
            pnlTitle = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();

            // Panel thống kê
            pnlStats = new System.Windows.Forms.Panel();
            lblTotalMovies = new System.Windows.Forms.Label();
            lblShowingMovies = new System.Windows.Forms.Label();
            lblComingMovies = new System.Windows.Forms.Label();
            lblEndedMovies = new System.Windows.Forms.Label();

            // Panel bộ lọc
            pnlFilter = new System.Windows.Forms.Panel();
            lblFilterGenre = new System.Windows.Forms.Label();
            lblFilterAge = new System.Windows.Forms.Label();
            lblFilterStatus = new System.Windows.Forms.Label();
            cboGenre = new System.Windows.Forms.ComboBox();
            cboAgeLimit = new System.Windows.Forms.ComboBox();
            cboStatus = new System.Windows.Forms.ComboBox();
            btnApplyFilter = new System.Windows.Forms.Button();
            btnResetFilter = new System.Windows.Forms.Button();

            // Chart
            chartMovieStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartGenreDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartAgeRatingDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();

            // DataGridView
            dgvMovies = new System.Windows.Forms.DataGridView();

            pnlMain.SuspendLayout();
            pnlTitle.SuspendLayout();
            pnlStats.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(chartMovieStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(chartGenreDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(chartAgeRatingDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dgvMovies)).BeginInit();
            this.SuspendLayout();

            // ========== pnlTitle ==========
            pnlTitle.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTitle.Height = 50;
            pnlTitle.Name = "pnlTitle";

            lblTitle.AutoSize = false;
            lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Text = "📊 BÁNG THỐNG KÊ PHIM";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            lblTitle.Name = "lblTitle";

            // ========== pnlStats ==========
            pnlStats.BackColor = System.Drawing.Color.White;
            pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            pnlStats.Height = 110;
            pnlStats.Padding = new System.Windows.Forms.Padding(20);
            pnlStats.Name = "pnlStats";

            // Các nhãn thống kê
            lblTotalMovies.Text = "Tổng Phim: 0";
            lblTotalMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            lblTotalMovies.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            lblTotalMovies.ForeColor = System.Drawing.Color.White;
            lblTotalMovies.Padding = new System.Windows.Forms.Padding(15);
            lblTotalMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTotalMovies.Width = 160;
            lblTotalMovies.Height = 80;
            lblTotalMovies.Location = new System.Drawing.Point(20, 10);
            lblTotalMovies.Name = "lblTotalMovies";
            lblTotalMovies.AutoSize = false;

            lblShowingMovies.Text = "Đang Chiếu: 0";
            lblShowingMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            lblShowingMovies.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            lblShowingMovies.ForeColor = System.Drawing.Color.White;
            lblShowingMovies.Padding = new System.Windows.Forms.Padding(15);
            lblShowingMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblShowingMovies.Width = 160;
            lblShowingMovies.Height = 80;
            lblShowingMovies.Location = new System.Drawing.Point(190, 10);
            lblShowingMovies.Name = "lblShowingMovies";
            lblShowingMovies.AutoSize = false;

            lblComingMovies.Text = "Sắp Chiếu: 0";
            lblComingMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            lblComingMovies.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            lblComingMovies.ForeColor = System.Drawing.Color.White;
            lblComingMovies.Padding = new System.Windows.Forms.Padding(15);
            lblComingMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblComingMovies.Width = 160;
            lblComingMovies.Height = 80;
            lblComingMovies.Location = new System.Drawing.Point(360, 10);
            lblComingMovies.Name = "lblComingMovies";

            lblEndedMovies.Text = "Đã Kết Thúc: 0";
            lblEndedMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            lblEndedMovies.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            lblEndedMovies.ForeColor = System.Drawing.Color.White;
            lblEndedMovies.Padding = new System.Windows.Forms.Padding(15);
            lblEndedMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblEndedMovies.Width = 160;
            lblEndedMovies.Height = 80;
            lblEndedMovies.Location = new System.Drawing.Point(530, 10);
            lblEndedMovies.Name = "lblEndedMovies";

            pnlStats.Controls.Add(lblTotalMovies);
            pnlStats.Controls.Add(lblShowingMovies);
            pnlStats.Controls.Add(lblComingMovies);
            pnlStats.Controls.Add(lblEndedMovies);

            // ========== pnlFilter ==========
            pnlFilter.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFilter.Height = 80;
            pnlFilter.Padding = new System.Windows.Forms.Padding(20);
            pnlFilter.Name = "pnlFilter";

            lblFilterGenre.Text = "Thể Loại:";
            lblFilterGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblFilterGenre.Location = new System.Drawing.Point(20, 20);
            lblFilterGenre.Size = new System.Drawing.Size(80, 25);
            lblFilterGenre.Name = "lblFilterGenre";

            cboGenre.Location = new System.Drawing.Point(100, 20);
            cboGenre.Size = new System.Drawing.Size(150, 25);
            cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboGenre.Name = "cboGenre";

            lblFilterAge.Text = "Độ Tuổi:";
            lblFilterAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblFilterAge.Location = new System.Drawing.Point(260, 20);
            lblFilterAge.Size = new System.Drawing.Size(80, 25);
            lblFilterAge.Name = "lblFilterAge";

            cboAgeLimit.Location = new System.Drawing.Point(340, 20);
            cboAgeLimit.Size = new System.Drawing.Size(150, 25);
            cboAgeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboAgeLimit.Name = "cboAgeLimit";

            lblFilterStatus.Text = "Trạng Thái:";
            lblFilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblFilterStatus.Location = new System.Drawing.Point(500, 20);
            lblFilterStatus.Size = new System.Drawing.Size(80, 25);
            lblFilterStatus.Name = "lblFilterStatus";

            cboStatus.Location = new System.Drawing.Point(580, 20);
            cboStatus.Size = new System.Drawing.Size(150, 25);
            cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboStatus.Items.AddRange(new object[] { "Tất cả phim", "Đang chiếu", "Sắp chiếu", "Đã kết thúc" });
            cboStatus.SelectedIndex = 0;
            cboStatus.Name = "cboStatus";

            btnApplyFilter.Text = "Áp Dụng";
            btnApplyFilter.Location = new System.Drawing.Point(740, 20);
            btnApplyFilter.Size = new System.Drawing.Size(90, 25);
            btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnApplyFilter.ForeColor = System.Drawing.Color.White;
            btnApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            btnApplyFilter.Name = "btnApplyFilter";

            btnResetFilter.Text = "Đặt Lại";
            btnResetFilter.Location = new System.Drawing.Point(840, 20);
            btnResetFilter.Size = new System.Drawing.Size(90, 25);
            btnResetFilter.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnResetFilter.ForeColor = System.Drawing.Color.White;
            btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            btnResetFilter.Name = "btnResetFilter";

            pnlFilter.Controls.Add(lblFilterGenre);
            pnlFilter.Controls.Add(cboGenre);
            pnlFilter.Controls.Add(lblFilterAge);
            pnlFilter.Controls.Add(cboAgeLimit);
            pnlFilter.Controls.Add(lblFilterStatus);
            pnlFilter.Controls.Add(cboStatus);
            pnlFilter.Controls.Add(btnApplyFilter);
            pnlFilter.Controls.Add(btnResetFilter);

            // ========== chartMovieStats ==========
            chartMovieStats.BackColor = System.Drawing.Color.White;
            chartMovieStats.Dock = System.Windows.Forms.DockStyle.Top;
            chartMovieStats.Height = 300;
            chartMovieStats.Name = "chartMovieStats";

            // ========== chartGenreDistribution ==========
            chartGenreDistribution.BackColor = System.Drawing.Color.White;
            chartGenreDistribution.Dock = System.Windows.Forms.DockStyle.Left;
            chartGenreDistribution.Width = 400;
            chartGenreDistribution.Height = 300;
            chartGenreDistribution.Name = "chartGenreDistribution";

            // ========== chartAgeRatingDistribution ==========
            chartAgeRatingDistribution.BackColor = System.Drawing.Color.White;
            chartAgeRatingDistribution.Dock = System.Windows.Forms.DockStyle.Right;
            chartAgeRatingDistribution.Width = 400;
            chartAgeRatingDistribution.Height = 300;
            chartAgeRatingDistribution.Name = "chartAgeRatingDistribution";

            // ========== dgvMovies ==========
            dgvMovies.BackgroundColor = System.Drawing.Color.White;
            dgvMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMovies.ReadOnly = true;
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.AllowUserToDeleteRows = false;
            dgvMovies.RowHeadersVisible = false;
            dgvMovies.Name = "dgvMovies";

            // ========== pnlMain ==========
            pnlMain.Controls.Add(dgvMovies);
            pnlMain.Controls.Add(chartAgeRatingDistribution);
            pnlMain.Controls.Add(chartGenreDistribution);
            pnlMain.Controls.Add(chartMovieStats);
            pnlMain.Controls.Add(pnlFilter);
            pnlMain.Controls.Add(pnlStats);
            pnlMain.Controls.Add(pnlTitle);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Name = "pnlMain";

            // ========== MovieReportUC ==========
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(pnlMain);
            this.Name = "MovieReportUC";
            this.Size = new System.Drawing.Size(1200, 900);
            this.Load += new System.EventHandler(this.MovieReportUC_Load);

            pnlMain.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlStats.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(chartMovieStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(chartGenreDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(chartAgeRatingDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dgvMovies)).EndInit();
            this.ResumeLayout(false);
        }
    }
}