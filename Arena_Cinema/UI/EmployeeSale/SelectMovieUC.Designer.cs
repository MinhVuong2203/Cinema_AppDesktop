namespace UI.EmployeeSale
{
    partial class SelectMovieUC
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flpMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblMovieCount = new System.Windows.Forms.Label();
            this.lbMovieListTitle = new System.Windows.Forms.Label();
            this.btn_back = new ReaLTaiizor.Controls.ParrotButton();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panelMain.Controls.Add(this.flpMovies);
            this.panelMain.Controls.Add(this.panelFilter);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1630, 800);
            this.panelMain.TabIndex = 0;
            // 
            // flpMovies
            // 
            this.flpMovies.AutoScroll = true;
            this.flpMovies.BackColor = System.Drawing.Color.Transparent;
            this.flpMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMovies.Location = new System.Drawing.Point(20, 200);
            this.flpMovies.Name = "flpMovies";
            this.flpMovies.Padding = new System.Windows.Forms.Padding(10);
            this.flpMovies.Size = new System.Drawing.Size(1590, 580);
            this.flpMovies.TabIndex = 2;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.cboGenre);
            this.panelFilter.Controls.Add(this.lblGenre);
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.lblSearch);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(20, 120);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelFilter.Size = new System.Drawing.Size(1590, 80);
            this.panelFilter.TabIndex = 1;
            // 
            // cboGenre
            // 
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Items.AddRange(new object[] {
            "Tất cả",
            "Hành động",
            "Hài",
            "Kinh dị",
            "Tình cảm",
            "Hoạt hình"});
            this.cboGenre.Location = new System.Drawing.Point(611, 20);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(200, 33);
            this.cboGenre.TabIndex = 3;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblGenre.Location = new System.Drawing.Point(508, 23);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(86, 25);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Thể loại:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.txtSearch.Location = new System.Drawing.Point(150, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Nhập tên phim...";
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblSearch.Location = new System.Drawing.Point(20, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(98, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblDateTime);
            this.panelHeader.Controls.Add(this.lblMovieCount);
            this.panelHeader.Controls.Add(this.lbMovieListTitle);
            this.panelHeader.Controls.Add(this.btn_back);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(20, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1590, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDateTime.Location = new System.Drawing.Point(1200, 20);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(370, 25);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "Thứ Hai, 27/01/2026 - 14:30:00";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMovieCount
            // 
            this.lblMovieCount.AutoSize = true;
            this.lblMovieCount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMovieCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblMovieCount.Location = new System.Drawing.Point(120, 60);
            this.lblMovieCount.Name = "lblMovieCount";
            this.lblMovieCount.Size = new System.Drawing.Size(171, 25);
            this.lblMovieCount.TabIndex = 2;
            this.lblMovieCount.Text = "Đang chiếu 0 phim";
            // 
            // lbMovieListTitle
            // 
            this.lbMovieListTitle.AutoSize = true;
            this.lbMovieListTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbMovieListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbMovieListTitle.Location = new System.Drawing.Point(115, 15);
            this.lbMovieListTitle.Name = "lbMovieListTitle";
            this.lbMovieListTitle.Size = new System.Drawing.Size(277, 46);
            this.lbMovieListTitle.TabIndex = 1;
            this.lbMovieListTitle.Text = global::UI.Resources.Lang.MovieListTitle;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundColor = System.Drawing.Color.White;
            this.btn_back.ButtonImage = global::UI.Properties.Resources.chevrons;
            this.btn_back.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btn_back.ButtonText = "";
            this.btn_back.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btn_back.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btn_back.CornerRadius = 10;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_back.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btn_back.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btn_back.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Center;
            this.btn_back.Location = new System.Drawing.Point(20, 25);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(60, 60);
            this.btn_back.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_back.TabIndex = 0;
            this.btn_back.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btn_back.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_back.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
            // 
            // SelectMovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.panelMain);
            this.Name = "SelectMovieUC";
            this.Size = new System.Drawing.Size(1630, 800);
            this.panelMain.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #region Component Designer generated code

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbMovieListTitle;
        private System.Windows.Forms.Label lblMovieCount;
        private System.Windows.Forms.Label lblDateTime;
        private ReaLTaiizor.Controls.ParrotButton btn_back;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.FlowLayoutPanel flpMovies;
        private System.Windows.Forms.Timer timerClock;

        #endregion
    }
}
