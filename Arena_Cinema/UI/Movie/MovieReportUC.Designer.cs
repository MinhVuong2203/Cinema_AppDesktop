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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel_bot = new System.Windows.Forms.Panel();
            this.chartGenreDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAgeRatingDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.panel_top = new System.Windows.Forms.Panel();
            this.chartMovieStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilterGenre = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.lblFilterAge = new System.Windows.Forms.Label();
            this.cboAgeLimit = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblTotalMovies = new System.Windows.Forms.Label();
            this.lblShowingMovies = new System.Windows.Forms.Label();
            this.lblComingMovies = new System.Windows.Forms.Label();
            this.lblEndedMovies = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.panel_bot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAgeRatingDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovieStats)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Controls.Add(this.panel_bot);
            this.pnlMain.Controls.Add(this.panel_top);
            this.pnlMain.Controls.Add(this.pnlFilter);
            this.pnlMain.Controls.Add(this.pnlStats);
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1600, 1108);
            this.pnlMain.TabIndex = 0;
            // 
            // panel_bot
            // 
            this.panel_bot.Controls.Add(this.chartGenreDistribution);
            this.panel_bot.Controls.Add(this.chartAgeRatingDistribution);
            this.panel_bot.Controls.Add(this.dgvMovies);
            this.panel_bot.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_bot.Location = new System.Drawing.Point(683, 295);
            this.panel_bot.Name = "panel_bot";
            this.panel_bot.Size = new System.Drawing.Size(917, 813);
            this.panel_bot.TabIndex = 8;
            // 
            // chartGenreDistribution
            // 
            this.chartGenreDistribution.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartGenreDistribution.Location = new System.Drawing.Point(498, 357);
            this.chartGenreDistribution.Margin = new System.Windows.Forms.Padding(4);
            this.chartGenreDistribution.Name = "chartGenreDistribution";
            this.chartGenreDistribution.Size = new System.Drawing.Size(419, 456);
            this.chartGenreDistribution.TabIndex = 2;
            // 
            // chartAgeRatingDistribution
            // 
            this.chartAgeRatingDistribution.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartAgeRatingDistribution.Location = new System.Drawing.Point(0, 357);
            this.chartAgeRatingDistribution.Margin = new System.Windows.Forms.Padding(4);
            this.chartAgeRatingDistribution.Name = "chartAgeRatingDistribution";
            this.chartAgeRatingDistribution.Size = new System.Drawing.Size(438, 456);
            this.chartAgeRatingDistribution.TabIndex = 1;
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMovies.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovies.ColumnHeadersHeight = 29;
            this.dgvMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMovies.Location = new System.Drawing.Point(0, 0);
            this.dgvMovies.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowHeadersVisible = false;
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.Size = new System.Drawing.Size(917, 357);
            this.dgvMovies.TabIndex = 0;
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.chartMovieStats);
            this.panel_top.Location = new System.Drawing.Point(0, 295);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(652, 722);
            this.panel_top.TabIndex = 7;
            // 
            // chartMovieStats
            // 
            this.chartMovieStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMovieStats.Location = new System.Drawing.Point(0, 0);
            this.chartMovieStats.Margin = new System.Windows.Forms.Padding(4);
            this.chartMovieStats.Name = "chartMovieStats";
            this.chartMovieStats.Size = new System.Drawing.Size(652, 722);
            this.chartMovieStats.TabIndex = 3;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlFilter.Controls.Add(this.lblFilterGenre);
            this.pnlFilter.Controls.Add(this.cboGenre);
            this.pnlFilter.Controls.Add(this.lblFilterAge);
            this.pnlFilter.Controls.Add(this.cboAgeLimit);
            this.pnlFilter.Controls.Add(this.lblFilterStatus);
            this.pnlFilter.Controls.Add(this.cboStatus);
            this.pnlFilter.Controls.Add(this.btnApplyFilter);
            this.pnlFilter.Controls.Add(this.btnResetFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 197);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlFilter.Size = new System.Drawing.Size(1600, 98);
            this.pnlFilter.TabIndex = 4;
            // 
            // lblFilterGenre
            // 
            this.lblFilterGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFilterGenre.Location = new System.Drawing.Point(27, 25);
            this.lblFilterGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterGenre.Name = "lblFilterGenre";
            this.lblFilterGenre.Size = new System.Drawing.Size(107, 31);
            this.lblFilterGenre.TabIndex = 0;
            this.lblFilterGenre.Text = global::UI.Resources.Lang.TheLOAI;
            // 
            // cboGenre
            // 
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.Location = new System.Drawing.Point(133, 25);
            this.cboGenre.Margin = new System.Windows.Forms.Padding(4);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(199, 24);
            this.cboGenre.TabIndex = 1;
            // 
            // lblFilterAge
            // 
            this.lblFilterAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFilterAge.Location = new System.Drawing.Point(347, 25);
            this.lblFilterAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterAge.Name = "lblFilterAge";
            this.lblFilterAge.Size = new System.Drawing.Size(107, 31);
            this.lblFilterAge.TabIndex = 2;
            this.lblFilterAge.Text = global::UI.Resources.Lang.DoTuoi;
            // 
            // cboAgeLimit
            // 
            this.cboAgeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgeLimit.Location = new System.Drawing.Point(453, 25);
            this.cboAgeLimit.Margin = new System.Windows.Forms.Padding(4);
            this.cboAgeLimit.Name = "cboAgeLimit";
            this.cboAgeLimit.Size = new System.Drawing.Size(199, 24);
            this.cboAgeLimit.TabIndex = 3;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFilterStatus.Location = new System.Drawing.Point(667, 25);
            this.lblFilterStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(135, 31);
            this.lblFilterStatus.TabIndex = 4;
            this.lblFilterStatus.Text = global::UI.Resources.Lang.TrangThai;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Items.AddRange(new object[] {
            "Tất cả phim",
            "Đang chiếu",
            "Sắp chiếu",
            "Đã kết thúc"});
            this.cboStatus.Location = new System.Drawing.Point(810, 25);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(199, 24);
            this.cboStatus.TabIndex = 5;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Location = new System.Drawing.Point(1029, 25);
            this.btnApplyFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(120, 31);
            this.btnApplyFilter.TabIndex = 6;
            this.btnApplyFilter.Text = global::UI.Resources.Lang.ApDung;
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Location = new System.Drawing.Point(1181, 25);
            this.btnResetFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(120, 31);
            this.btnResetFilter.TabIndex = 7;
            this.btnResetFilter.Text = global::UI.Resources.Lang.DatLai;
            this.btnResetFilter.UseVisualStyleBackColor = false;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.White;
            this.pnlStats.Controls.Add(this.lblTotalMovies);
            this.pnlStats.Controls.Add(this.lblShowingMovies);
            this.pnlStats.Controls.Add(this.lblComingMovies);
            this.pnlStats.Controls.Add(this.lblEndedMovies);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(0, 62);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlStats.Size = new System.Drawing.Size(1600, 135);
            this.pnlStats.TabIndex = 5;
            // 
            // lblTotalMovies
            // 
            this.lblTotalMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTotalMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalMovies.ForeColor = System.Drawing.Color.White;
            this.lblTotalMovies.Location = new System.Drawing.Point(27, 12);
            this.lblTotalMovies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMovies.Name = "lblTotalMovies";
            this.lblTotalMovies.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.lblTotalMovies.Size = new System.Drawing.Size(213, 98);
            this.lblTotalMovies.TabIndex = 0;
            this.lblTotalMovies.Text = "Tổng Phim: 0";
            this.lblTotalMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowingMovies
            // 
            this.lblShowingMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblShowingMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblShowingMovies.ForeColor = System.Drawing.Color.White;
            this.lblShowingMovies.Location = new System.Drawing.Point(253, 12);
            this.lblShowingMovies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowingMovies.Name = "lblShowingMovies";
            this.lblShowingMovies.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.lblShowingMovies.Size = new System.Drawing.Size(213, 98);
            this.lblShowingMovies.TabIndex = 1;
            this.lblShowingMovies.Text = "Đang Chiếu: 0";
            this.lblShowingMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComingMovies
            // 
            this.lblComingMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblComingMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblComingMovies.ForeColor = System.Drawing.Color.White;
            this.lblComingMovies.Location = new System.Drawing.Point(480, 12);
            this.lblComingMovies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComingMovies.Name = "lblComingMovies";
            this.lblComingMovies.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.lblComingMovies.Size = new System.Drawing.Size(213, 98);
            this.lblComingMovies.TabIndex = 2;
            this.lblComingMovies.Text = "Sắp Chiếu: 0";
            this.lblComingMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndedMovies
            // 
            this.lblEndedMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblEndedMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEndedMovies.ForeColor = System.Drawing.Color.White;
            this.lblEndedMovies.Location = new System.Drawing.Point(707, 12);
            this.lblEndedMovies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndedMovies.Name = "lblEndedMovies";
            this.lblEndedMovies.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.lblEndedMovies.Size = new System.Drawing.Size(213, 98);
            this.lblEndedMovies.TabIndex = 3;
            this.lblEndedMovies.Text = "Đã Kết Thúc: 0";
            this.lblEndedMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1600, 62);
            this.pnlTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1600, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = global::UI.Resources.Lang.bangthongkephim;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MovieReportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovieReportUC";
            this.Size = new System.Drawing.Size(1600, 1108);
            this.Load += new System.EventHandler(this.MovieReportUC_Load);
            this.pnlMain.ResumeLayout(false);
            this.panel_bot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAgeRatingDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMovieStats)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_bot;
    }
}