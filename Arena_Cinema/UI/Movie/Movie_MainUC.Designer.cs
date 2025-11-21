namespace UI.Movie
{
    partial class Movie_MainUC
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.right_panel = new System.Windows.Forms.Panel();
            this.btnDeletedMovies = new ReaLTaiizor.Controls.ParrotButton();
            this.btnAddMovie = new ReaLTaiizor.Controls.ParrotButton();
            this.lbl_MovieTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel_movie = new System.Windows.Forms.Panel();
            this.moviesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.movieCardTemplate = new ReaLTaiizor.Controls.MaterialCard();
            this.btnDeleteTemplate = new ReaLTaiizor.Controls.ParrotButton();
            this.btnEditTemplate = new ReaLTaiizor.Controls.ParrotButton();
            this.btnViewTemplate = new ReaLTaiizor.Controls.ParrotButton();
            this.lblDatesTemplate = new System.Windows.Forms.Label();
            this.lblSubtitleTemplate = new System.Windows.Forms.Label();
            this.lblLanguageTemplate = new System.Windows.Forms.Label();
            this.lblDurationTemplate = new System.Windows.Forms.Label();
            this.lblTitleTemplate = new System.Windows.Forms.Label();
            this.posterTemplate = new System.Windows.Forms.Panel();
            this.badgeTemplate = new System.Windows.Forms.Label();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.btnPageNumberTemplate = new ReaLTaiizor.Controls.ParrotButton();
            this.btnNavTemplate = new ReaLTaiizor.Controls.ParrotButton();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panelinfo_right = new System.Windows.Forms.Panel();
            this.btnRP = new ReaLTaiizor.Controls.ParrotButton();
            this.cboAgeLimit = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboGenre = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboFilter = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnReset = new ReaLTaiizor.Controls.ParrotButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtSearch = new ReaLTaiizor.Controls.MaterialTextBox();
            this.panelHeader.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel_movie.SuspendLayout();
            this.moviesContainer.SuspendLayout();
            this.movieCardTemplate.SuspendLayout();
            this.paginationPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panelinfo_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.right_panel);
            this.panelHeader.Controls.Add(this.lbl_MovieTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1360, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // right_panel
            // 
            this.right_panel.Controls.Add(this.btnDeletedMovies);
            this.right_panel.Controls.Add(this.btnAddMovie);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_panel.Location = new System.Drawing.Point(996, 0);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(364, 60);
            this.right_panel.TabIndex = 3;
            // 
            // btnDeletedMovies
            // 
            this.btnDeletedMovies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnDeletedMovies.ButtonImage = null;
            this.btnDeletedMovies.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnDeletedMovies.ButtonText = global::UI.Resources.Lang.PhimDaXoa;
            this.btnDeletedMovies.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDeletedMovies.ClickTextColor = System.Drawing.Color.White;
            this.btnDeletedMovies.CornerRadius = 5;
            this.btnDeletedMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletedMovies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeletedMovies.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeletedMovies.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btnDeletedMovies.HoverTextColor = System.Drawing.Color.White;
            this.btnDeletedMovies.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnDeletedMovies.Location = new System.Drawing.Point(210, 14);
            this.btnDeletedMovies.Name = "btnDeletedMovies";
            this.btnDeletedMovies.Size = new System.Drawing.Size(145, 36);
            this.btnDeletedMovies.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDeletedMovies.TabIndex = 3;
            this.btnDeletedMovies.TextColor = System.Drawing.Color.White;
            this.btnDeletedMovies.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDeletedMovies.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeletedMovies.Click += new System.EventHandler(this.btnDeletedMovies_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnAddMovie.ButtonImage = null;
            this.btnAddMovie.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnAddMovie.ButtonText = global::UI.Resources.Lang.ThemPhim;
            this.btnAddMovie.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddMovie.ClickTextColor = System.Drawing.Color.White;
            this.btnAddMovie.CornerRadius = 5;
            this.btnAddMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddMovie.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddMovie.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnAddMovie.HoverTextColor = System.Drawing.Color.White;
            this.btnAddMovie.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnAddMovie.Location = new System.Drawing.Point(15, 14);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(170, 36);
            this.btnAddMovie.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnAddMovie.TabIndex = 2;
            this.btnAddMovie.TextColor = System.Drawing.Color.White;
            this.btnAddMovie.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAddMovie.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // lbl_MovieTitle
            // 
            this.lbl_MovieTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_MovieTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_MovieTitle.Location = new System.Drawing.Point(50, 14);
            this.lbl_MovieTitle.Name = "lbl_MovieTitle";
            this.lbl_MovieTitle.Size = new System.Drawing.Size(267, 32);
            this.lbl_MovieTitle.TabIndex = 1;
            this.lbl_MovieTitle.Text = global::UI.Resources.Lang.QuanLyPhim;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.panel_movie);
            this.panelMain.Controls.Add(this.paginationPanel);
            this.panelMain.Controls.Add(this.searchPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(1360, 740);
            this.panelMain.TabIndex = 1;
            // 
            // panel_movie
            // 
            this.panel_movie.AutoScroll = true;
            this.panel_movie.Controls.Add(this.moviesContainer);
            this.panel_movie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_movie.Location = new System.Drawing.Point(25, 146);
            this.panel_movie.Name = "panel_movie";
            this.panel_movie.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel_movie.Size = new System.Drawing.Size(1310, 519);
            this.panel_movie.TabIndex = 5;
            // 
            // moviesContainer
            // 
            this.moviesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.moviesContainer.Controls.Add(this.movieCardTemplate);
            this.moviesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesContainer.Location = new System.Drawing.Point(0, 10);
            this.moviesContainer.Name = "moviesContainer";
            this.moviesContainer.Size = new System.Drawing.Size(1310, 499);
            this.moviesContainer.TabIndex = 2;
            // 
            // movieCardTemplate
            // 
            this.movieCardTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movieCardTemplate.Controls.Add(this.btnDeleteTemplate);
            this.movieCardTemplate.Controls.Add(this.btnEditTemplate);
            this.movieCardTemplate.Controls.Add(this.btnViewTemplate);
            this.movieCardTemplate.Controls.Add(this.lblDatesTemplate);
            this.movieCardTemplate.Controls.Add(this.lblSubtitleTemplate);
            this.movieCardTemplate.Controls.Add(this.lblLanguageTemplate);
            this.movieCardTemplate.Controls.Add(this.lblDurationTemplate);
            this.movieCardTemplate.Controls.Add(this.lblTitleTemplate);
            this.movieCardTemplate.Controls.Add(this.posterTemplate);
            this.movieCardTemplate.Controls.Add(this.badgeTemplate);
            this.movieCardTemplate.Depth = 0;
            this.movieCardTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieCardTemplate.Location = new System.Drawing.Point(6, 6);
            this.movieCardTemplate.Margin = new System.Windows.Forms.Padding(6);
            this.movieCardTemplate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.movieCardTemplate.Name = "movieCardTemplate";
            this.movieCardTemplate.Padding = new System.Windows.Forms.Padding(5);
            this.movieCardTemplate.Size = new System.Drawing.Size(296, 407);
            this.movieCardTemplate.TabIndex = 0;
            this.movieCardTemplate.Visible = false;
            // 
            // btnDeleteTemplate
            // 
            this.btnDeleteTemplate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteTemplate.ButtonImage = null;
            this.btnDeleteTemplate.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnDeleteTemplate.ButtonText = global::UI.Resources.Lang.Xoa;
            this.btnDeleteTemplate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDeleteTemplate.ClickTextColor = System.Drawing.Color.White;
            this.btnDeleteTemplate.CornerRadius = 3;
            this.btnDeleteTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTemplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTemplate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteTemplate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnDeleteTemplate.HoverTextColor = System.Drawing.Color.White;
            this.btnDeleteTemplate.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnDeleteTemplate.Location = new System.Drawing.Point(223, 374);
            this.btnDeleteTemplate.Name = "btnDeleteTemplate";
            this.btnDeleteTemplate.Size = new System.Drawing.Size(65, 25);
            this.btnDeleteTemplate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDeleteTemplate.TabIndex = 9;
            this.btnDeleteTemplate.TextColor = System.Drawing.Color.White;
            this.btnDeleteTemplate.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDeleteTemplate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnEditTemplate
            // 
            this.btnEditTemplate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditTemplate.ButtonImage = null;
            this.btnEditTemplate.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnEditTemplate.ButtonText = global::UI.Resources.Lang.Sua;
            this.btnEditTemplate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnEditTemplate.ClickTextColor = System.Drawing.Color.White;
            this.btnEditTemplate.CornerRadius = 3;
            this.btnEditTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTemplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditTemplate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEditTemplate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.btnEditTemplate.HoverTextColor = System.Drawing.Color.White;
            this.btnEditTemplate.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnEditTemplate.Location = new System.Drawing.Point(131, 374);
            this.btnEditTemplate.Name = "btnEditTemplate";
            this.btnEditTemplate.Size = new System.Drawing.Size(65, 25);
            this.btnEditTemplate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEditTemplate.TabIndex = 8;
            this.btnEditTemplate.TextColor = System.Drawing.Color.White;
            this.btnEditTemplate.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEditTemplate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnViewTemplate
            // 
            this.btnViewTemplate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnViewTemplate.ButtonImage = null;
            this.btnViewTemplate.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnViewTemplate.ButtonText = global::UI.Resources.Lang.ChiTiet;
            this.btnViewTemplate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnViewTemplate.ClickTextColor = System.Drawing.Color.White;
            this.btnViewTemplate.CornerRadius = 3;
            this.btnViewTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewTemplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewTemplate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnViewTemplate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnViewTemplate.HoverTextColor = System.Drawing.Color.White;
            this.btnViewTemplate.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnViewTemplate.Location = new System.Drawing.Point(12, 374);
            this.btnViewTemplate.Name = "btnViewTemplate";
            this.btnViewTemplate.Size = new System.Drawing.Size(89, 25);
            this.btnViewTemplate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnViewTemplate.TabIndex = 7;
            this.btnViewTemplate.TextColor = System.Drawing.Color.White;
            this.btnViewTemplate.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnViewTemplate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDatesTemplate
            // 
            this.lblDatesTemplate.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblDatesTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDatesTemplate.Location = new System.Drawing.Point(12, 320);
            this.lblDatesTemplate.Name = "lblDatesTemplate";
            this.lblDatesTemplate.Size = new System.Drawing.Size(275, 39);
            this.lblDatesTemplate.TabIndex = 6;
            this.lblDatesTemplate.Text = global::UI.Resources.Lang.thoigianchieu;
            // 
            // lblSubtitleTemplate
            // 
            this.lblSubtitleTemplate.AutoSize = true;
            this.lblSubtitleTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblSubtitleTemplate.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSubtitleTemplate.ForeColor = System.Drawing.Color.White;
            this.lblSubtitleTemplate.Location = new System.Drawing.Point(12, 292);
            this.lblSubtitleTemplate.Name = "lblSubtitleTemplate";
            this.lblSubtitleTemplate.Padding = new System.Windows.Forms.Padding(4);
            this.lblSubtitleTemplate.Size = new System.Drawing.Size(86, 23);
            this.lblSubtitleTemplate.TabIndex = 5;
            this.lblSubtitleTemplate.Text = global::UI.Resources.Lang.NgonNgu;
            // 
            // lblLanguageTemplate
            // 
            this.lblLanguageTemplate.AutoSize = true;
            this.lblLanguageTemplate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLanguageTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLanguageTemplate.Location = new System.Drawing.Point(12, 270);
            this.lblLanguageTemplate.Name = "lblLanguageTemplate";
            this.lblLanguageTemplate.Size = new System.Drawing.Size(79, 19);
            this.lblLanguageTemplate.TabIndex = 4;
            this.lblLanguageTemplate.Text = global::UI.Resources.Lang.TheLoaiPhim;
            // 
            // lblDurationTemplate
            // 
            this.lblDurationTemplate.AutoSize = true;
            this.lblDurationTemplate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDurationTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDurationTemplate.Location = new System.Drawing.Point(12, 250);
            this.lblDurationTemplate.Name = "lblDurationTemplate";
            this.lblDurationTemplate.Size = new System.Drawing.Size(97, 19);
            this.lblDurationTemplate.TabIndex = 3;
            this.lblDurationTemplate.Text = global::UI.Resources.Lang.ThoiLuong;
            // 
            // lblTitleTemplate
            // 
            this.lblTitleTemplate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTitleTemplate.Location = new System.Drawing.Point(10, 200);
            this.lblTitleTemplate.Name = "lblTitleTemplate";
            this.lblTitleTemplate.Size = new System.Drawing.Size(276, 45);
            this.lblTitleTemplate.TabIndex = 2;
            this.lblTitleTemplate.Text = global::UI.Resources.Lang.TenPhim;
            // 
            // posterTemplate
            // 
            this.posterTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.posterTemplate.Location = new System.Drawing.Point(10, 10);
            this.posterTemplate.Name = "posterTemplate";
            this.posterTemplate.Size = new System.Drawing.Size(276, 180);
            this.posterTemplate.TabIndex = 1;
            // 
            // badgeTemplate
            // 
            this.badgeTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.badgeTemplate.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.badgeTemplate.ForeColor = System.Drawing.Color.Black;
            this.badgeTemplate.Location = new System.Drawing.Point(8, 8);
            this.badgeTemplate.Name = "badgeTemplate";
            this.badgeTemplate.Size = new System.Drawing.Size(75, 18);
            this.badgeTemplate.TabIndex = 0;
            this.badgeTemplate.Text = global::UI.Resources.Lang.TrangThai;
            this.badgeTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paginationPanel
            // 
            this.paginationPanel.BackColor = System.Drawing.Color.Transparent;
            this.paginationPanel.Controls.Add(this.btnPageNumberTemplate);
            this.paginationPanel.Controls.Add(this.btnNavTemplate);
            this.paginationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginationPanel.Location = new System.Drawing.Point(25, 665);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.Size = new System.Drawing.Size(1310, 50);
            this.paginationPanel.TabIndex = 4;
            // 
            // btnPageNumberTemplate
            // 
            this.btnPageNumberTemplate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnPageNumberTemplate.ButtonImage = null;
            this.btnPageNumberTemplate.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnPageNumberTemplate.ButtonText = "1";
            this.btnPageNumberTemplate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnPageNumberTemplate.ClickTextColor = System.Drawing.Color.White;
            this.btnPageNumberTemplate.CornerRadius = 3;
            this.btnPageNumberTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageNumberTemplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPageNumberTemplate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPageNumberTemplate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnPageNumberTemplate.HoverTextColor = System.Drawing.Color.White;
            this.btnPageNumberTemplate.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnPageNumberTemplate.Location = new System.Drawing.Point(10, 10);
            this.btnPageNumberTemplate.Name = "btnPageNumberTemplate";
            this.btnPageNumberTemplate.Size = new System.Drawing.Size(35, 30);
            this.btnPageNumberTemplate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPageNumberTemplate.TabIndex = 0;
            this.btnPageNumberTemplate.TextColor = System.Drawing.Color.White;
            this.btnPageNumberTemplate.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPageNumberTemplate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPageNumberTemplate.Visible = false;
            // 
            // btnNavTemplate
            // 
            this.btnNavTemplate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnNavTemplate.ButtonImage = null;
            this.btnNavTemplate.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnNavTemplate.ButtonText = "‹";
            this.btnNavTemplate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.btnNavTemplate.ClickTextColor = System.Drawing.Color.White;
            this.btnNavTemplate.CornerRadius = 3;
            this.btnNavTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTemplate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNavTemplate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNavTemplate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.btnNavTemplate.HoverTextColor = System.Drawing.Color.White;
            this.btnNavTemplate.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnNavTemplate.Location = new System.Drawing.Point(55, 10);
            this.btnNavTemplate.Name = "btnNavTemplate";
            this.btnNavTemplate.Size = new System.Drawing.Size(35, 30);
            this.btnNavTemplate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnNavTemplate.TabIndex = 1;
            this.btnNavTemplate.TextColor = System.Drawing.Color.White;
            this.btnNavTemplate.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnNavTemplate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNavTemplate.Visible = false;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.panelinfo_right);
            this.searchPanel.Controls.Add(this.lblInfo);
            this.searchPanel.Controls.Add(this.txtSearch);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(25, 25);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(10);
            this.searchPanel.Size = new System.Drawing.Size(1310, 121);
            this.searchPanel.TabIndex = 0;
            // 
            // panelinfo_right
            // 
            this.panelinfo_right.Controls.Add(this.btnRP);
            this.panelinfo_right.Controls.Add(this.cboAgeLimit);
            this.panelinfo_right.Controls.Add(this.cboGenre);
            this.panelinfo_right.Controls.Add(this.cboFilter);
            this.panelinfo_right.Controls.Add(this.btnReset);
            this.panelinfo_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelinfo_right.Location = new System.Drawing.Point(580, 10);
            this.panelinfo_right.Name = "panelinfo_right";
            this.panelinfo_right.Size = new System.Drawing.Size(720, 101);
            this.panelinfo_right.TabIndex = 3;
            // 
            // btnRP
            // 
            this.btnRP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRP.ButtonImage = null;
            this.btnRP.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnRP.ButtonText = global::UI.Resources.Lang.ThongKePhim;
            this.btnRP.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            this.btnRP.ClickTextColor = System.Drawing.Color.White;
            this.btnRP.CornerRadius = 5;
            this.btnRP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRP.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRP.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnRP.HoverTextColor = System.Drawing.Color.White;
            this.btnRP.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnRP.Location = new System.Drawing.Point(597, 60);
            this.btnRP.Name = "btnRP";
            this.btnRP.Size = new System.Drawing.Size(120, 38);
            this.btnRP.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnRP.TabIndex = 6;
            this.btnRP.TextColor = System.Drawing.Color.White;
            this.btnRP.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnRP.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRP.Click += new System.EventHandler(this.btnRP_Click);
            // 
            // cboAgeLimit
            // 
            this.cboAgeLimit.AutoResize = false;
            this.cboAgeLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboAgeLimit.Depth = 0;
            this.cboAgeLimit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboAgeLimit.DropDownHeight = 174;
            this.cboAgeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgeLimit.DropDownWidth = 121;
            this.cboAgeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboAgeLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboAgeLimit.FormattingEnabled = true;
            this.cboAgeLimit.Hint = global::UI.Resources.Lang.DoTuoi;
            this.cboAgeLimit.IntegralHeight = false;
            this.cboAgeLimit.ItemHeight = 43;
            this.cboAgeLimit.Location = new System.Drawing.Point(390, 5);
            this.cboAgeLimit.MaxDropDownItems = 4;
            this.cboAgeLimit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboAgeLimit.Name = "cboAgeLimit";
            this.cboAgeLimit.Size = new System.Drawing.Size(180, 49);
            this.cboAgeLimit.StartIndex = 0;
            this.cboAgeLimit.TabIndex = 4;
            this.cboAgeLimit.SelectedIndexChanged += new System.EventHandler(this.cboAgeLimit_SelectedIndexChanged);
            // 
            // cboGenre
            // 
            this.cboGenre.AutoResize = false;
            this.cboGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGenre.Depth = 0;
            this.cboGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboGenre.DropDownHeight = 174;
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.DropDownWidth = 121;
            this.cboGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Hint = global::UI.Resources.Lang.TheLOAI;
            this.cboGenre.IntegralHeight = false;
            this.cboGenre.ItemHeight = 43;
            this.cboGenre.Location = new System.Drawing.Point(200, 5);
            this.cboGenre.MaxDropDownItems = 4;
            this.cboGenre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(180, 49);
            this.cboGenre.StartIndex = 0;
            this.cboGenre.TabIndex = 3;
            this.cboGenre.SelectedIndexChanged += new System.EventHandler(this.cboGenre_SelectedIndexChanged);
            // 
            // cboFilter
            // 
            this.cboFilter.AutoResize = false;
            this.cboFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboFilter.Depth = 0;
            this.cboFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboFilter.DropDownHeight = 174;
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.DropDownWidth = 121;
            this.cboFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Hint = global::UI.Resources.Lang.TrangThai;
            this.cboFilter.IntegralHeight = false;
            this.cboFilter.ItemHeight = 43;
            this.cboFilter.Items.AddRange(new object[] {
            "Tất cả phim",
            "Đang chiếu",
            "Sắp chiếu",
            "Đã kết thúc"});
            this.cboFilter.Location = new System.Drawing.Point(10, 5);
            this.cboFilter.MaxDropDownItems = 4;
            this.cboFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(180, 49);
            this.cboFilter.StartIndex = 0;
            this.cboFilter.TabIndex = 1;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnReset.ButtonImage = null;
            this.btnReset.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnReset.ButtonText = global::UI.Resources.Lang.DatLai;
            this.btnReset.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            this.btnReset.ClickTextColor = System.Drawing.Color.White;
            this.btnReset.CornerRadius = 5;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReset.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnReset.HoverTextColor = System.Drawing.Color.White;
            this.btnReset.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnReset.Location = new System.Drawing.Point(597, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 49);
            this.btnReset.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnReset.TabIndex = 5;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnReset.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblInfo.Location = new System.Drawing.Point(10, 91);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(540, 20);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Tìm thấy: 0 phim | Trang 1 / 1";
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Hint = global::UI.Resources.Lang.timkiemtheoten;
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(15, 15);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(550, 50);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TabStop = false;
            this.txtSearch.Text = "";
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Movie_MainUC
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "Movie_MainUC";
            this.Size = new System.Drawing.Size(1360, 800);
            this.panelHeader.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel_movie.ResumeLayout(false);
            this.moviesContainer.ResumeLayout(false);
            this.movieCardTemplate.ResumeLayout(false);
            this.movieCardTemplate.PerformLayout();
            this.paginationPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.panelinfo_right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbl_MovieTitle;
        private ReaLTaiizor.Controls.ParrotButton btnAddMovie;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel searchPanel;
        private ReaLTaiizor.Controls.MaterialTextBox txtSearch;
        private ReaLTaiizor.Controls.MaterialComboBox cboFilter;
        private ReaLTaiizor.Controls.MaterialComboBox cboGenre;
        private ReaLTaiizor.Controls.MaterialComboBox cboAgeLimit;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.FlowLayoutPanel moviesContainer;
        private System.Windows.Forms.Panel right_panel;
        private System.Windows.Forms.Panel paginationPanel;
        private System.Windows.Forms.Panel panel_movie;
        private System.Windows.Forms.Panel panelinfo_right;
        private ReaLTaiizor.Controls.ParrotButton btnDeletedMovies;
        private ReaLTaiizor.Controls.ParrotButton btnReset;

        // Template card
        private ReaLTaiizor.Controls.MaterialCard movieCardTemplate;
        private System.Windows.Forms.Label badgeTemplate;
        private System.Windows.Forms.Panel posterTemplate;
        private System.Windows.Forms.Label lblTitleTemplate;
        private System.Windows.Forms.Label lblDurationTemplate;
        private System.Windows.Forms.Label lblLanguageTemplate;
        private System.Windows.Forms.Label lblSubtitleTemplate;
        private System.Windows.Forms.Label lblDatesTemplate;
        private ReaLTaiizor.Controls.ParrotButton btnViewTemplate;
        private ReaLTaiizor.Controls.ParrotButton btnEditTemplate;
        private ReaLTaiizor.Controls.ParrotButton btnDeleteTemplate;
        private ReaLTaiizor.Controls.ParrotButton btnPageNumberTemplate;
        private ReaLTaiizor.Controls.ParrotButton btnNavTemplate;
        private ReaLTaiizor.Controls.ParrotButton btnRP;
    }
}