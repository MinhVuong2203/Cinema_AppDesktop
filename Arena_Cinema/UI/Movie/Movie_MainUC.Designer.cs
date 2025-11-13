namespace UI.Movie
{
    partial class Movie_MainUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movie_MainUC));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbl_MovieTitle = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.btnAddMovie = new ReaLTaiizor.Controls.ParrotButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new ReaLTaiizor.Controls.MaterialTextBox();
            this.cboFilter = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnSearch = new ReaLTaiizor.Controls.ParrotButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.moviesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.movieCard1 = new ReaLTaiizor.Controls.MaterialCard();
            this.btnDelete1 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnEdit1 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnView1 = new ReaLTaiizor.Controls.ParrotButton();
            this.lblDates1 = new System.Windows.Forms.Label();
            this.lblSubtitle1 = new System.Windows.Forms.Label();
            this.lblLanguage1 = new System.Windows.Forms.Label();
            this.lblDuration1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.poster1 = new System.Windows.Forms.Panel();
            this.badge1 = new System.Windows.Forms.Label();
            this.movieCard2 = new ReaLTaiizor.Controls.MaterialCard();
            this.btnDelete2 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnEdit2 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnView2 = new ReaLTaiizor.Controls.ParrotButton();
            this.lblDates2 = new System.Windows.Forms.Label();
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.lblLanguage2 = new System.Windows.Forms.Label();
            this.lblDuration2 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.poster2 = new System.Windows.Forms.Panel();
            this.badge2 = new System.Windows.Forms.Label();
            this.movieCard3 = new ReaLTaiizor.Controls.MaterialCard();
            this.btnDelete3 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnEdit3 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnView3 = new ReaLTaiizor.Controls.ParrotButton();
            this.lblDates3 = new System.Windows.Forms.Label();
            this.lblSubtitle3 = new System.Windows.Forms.Label();
            this.lblLanguage3 = new System.Windows.Forms.Label();
            this.lblDuration3 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.poster3 = new System.Windows.Forms.Panel();
            this.badge3 = new System.Windows.Forms.Label();
            this.movieCard4 = new ReaLTaiizor.Controls.MaterialCard();
            this.btnDelete4 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnEdit4 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnView4 = new ReaLTaiizor.Controls.ParrotButton();
            this.lblDates4 = new System.Windows.Forms.Label();
            this.lblSubtitle4 = new System.Windows.Forms.Label();
            this.lblLanguage4 = new System.Windows.Forms.Label();
            this.lblDuration4 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.poster4 = new System.Windows.Forms.Panel();
            this.badge4 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelMain.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.moviesContainer.SuspendLayout();
            this.movieCard1.SuspendLayout();
            this.movieCard2.SuspendLayout();
            this.movieCard3.SuspendLayout();
            this.movieCard4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.lbl_MovieTitle);
            this.panelHeader.Controls.Add(this.pictureBoxIcon);
            this.panelHeader.Controls.Add(this.btnAddMovie);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1360, 60);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lbl_MovieTitle
            // 
            this.lbl_MovieTitle.AutoSize = true;
            this.lbl_MovieTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_MovieTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_MovieTitle.Location = new System.Drawing.Point(50, 14);
            this.lbl_MovieTitle.Name = "lbl_MovieTitle";
            this.lbl_MovieTitle.Size = new System.Drawing.Size(212, 32);
            this.lbl_MovieTitle.TabIndex = 1;
            this.lbl_MovieTitle.Text = "📽 Quản Lý Phim";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.Location = new System.Drawing.Point(15, 15);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnAddMovie.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAddMovie.ButtonImage")));
            this.btnAddMovie.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnAddMovie.ButtonText = "+ Thêm Phim Mới";
            this.btnAddMovie.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddMovie.ClickTextColor = System.Drawing.Color.White;
            this.btnAddMovie.CornerRadius = 5;
            this.btnAddMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddMovie.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddMovie.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnAddMovie.HoverTextColor = System.Drawing.Color.White;
            this.btnAddMovie.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnAddMovie.Location = new System.Drawing.Point(1170, 12);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(170, 36);
            this.btnAddMovie.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnAddMovie.TabIndex = 2;
            this.btnAddMovie.TextColor = System.Drawing.Color.White;
            this.btnAddMovie.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAddMovie.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.searchPanel);
            this.panelMain.Controls.Add(this.lblInfo);
            this.panelMain.Controls.Add(this.moviesContainer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(1360, 740);
            this.panelMain.TabIndex = 1;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.txtSearch);
            this.searchPanel.Controls.Add(this.cboFilter);
            this.searchPanel.Controls.Add(this.btnSearch);
            this.searchPanel.Location = new System.Drawing.Point(25, 25);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(10);
            this.searchPanel.Size = new System.Drawing.Size(1310, 80);
            this.searchPanel.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Hint = "Tìm kiếm phim theo tên...";
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
            this.cboFilter.Hint = "Lọc theo trạng thái";
            this.cboFilter.IntegralHeight = false;
            this.cboFilter.ItemHeight = 43;
            this.cboFilter.Items.AddRange(new object[] {
            "Tất cả phim",
            "Đang chiếu",
            "Sắp chiếu",
            "Đã kết thúc"});
            this.cboFilter.Location = new System.Drawing.Point(980, 15);
            this.cboFilter.MaxDropDownItems = 4;
            this.cboFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(180, 49);
            this.cboFilter.StartIndex = 0;
            this.cboFilter.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSearch.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.ButtonImage")));
            this.btnSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnSearch.ButtonText = "🔍 Tìm kiếm";
            this.btnSearch.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSearch.ClickTextColor = System.Drawing.Color.White;
            this.btnSearch.CornerRadius = 5;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnSearch.HoverTextColor = System.Drawing.Color.White;
            this.btnSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnSearch.Location = new System.Drawing.Point(1180, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 40);
            this.btnSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSearch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblInfo.Location = new System.Drawing.Point(35, 120);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(1290, 20);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Tìm thấy: 4 phim                                                                 " +
    "                                                                                " +
    "             Trang 1 / 1";
            // 
            // moviesContainer
            // 
            this.moviesContainer.AutoScroll = true;
            this.moviesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.moviesContainer.Controls.Add(this.movieCard1);
            this.moviesContainer.Controls.Add(this.movieCard2);
            this.moviesContainer.Controls.Add(this.movieCard3);
            this.moviesContainer.Controls.Add(this.movieCard4);
            this.moviesContainer.Location = new System.Drawing.Point(25, 150);
            this.moviesContainer.Name = "moviesContainer";
            this.moviesContainer.Padding = new System.Windows.Forms.Padding(5);
            this.moviesContainer.Size = new System.Drawing.Size(1310, 560);
            this.moviesContainer.TabIndex = 2;
            // 
            // movieCard1
            // 
            this.movieCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movieCard1.Controls.Add(this.btnDelete1);
            this.movieCard1.Controls.Add(this.btnEdit1);
            this.movieCard1.Controls.Add(this.btnView1);
            this.movieCard1.Controls.Add(this.lblDates1);
            this.movieCard1.Controls.Add(this.lblSubtitle1);
            this.movieCard1.Controls.Add(this.lblLanguage1);
            this.movieCard1.Controls.Add(this.lblDuration1);
            this.movieCard1.Controls.Add(this.lblTitle1);
            this.movieCard1.Controls.Add(this.poster1);
            this.movieCard1.Controls.Add(this.badge1);
            this.movieCard1.Depth = 0;
            this.movieCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieCard1.Location = new System.Drawing.Point(13, 13);
            this.movieCard1.Margin = new System.Windows.Forms.Padding(8);
            this.movieCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.movieCard1.Name = "movieCard1";
            this.movieCard1.Padding = new System.Windows.Forms.Padding(5);
            this.movieCard1.Size = new System.Drawing.Size(300, 380);
            this.movieCard1.TabIndex = 0;
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnDelete1.ButtonImage")));
            this.btnDelete1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnDelete1.ButtonText = "🗑";
            this.btnDelete1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDelete1.ClickTextColor = System.Drawing.Color.White;
            this.btnDelete1.CornerRadius = 3;
            this.btnDelete1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnDelete1.HoverTextColor = System.Drawing.Color.White;
            this.btnDelete1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnDelete1.Location = new System.Drawing.Point(245, 350);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(40, 25);
            this.btnDelete1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDelete1.TabIndex = 9;
            this.btnDelete1.TextColor = System.Drawing.Color.White;
            this.btnDelete1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDelete1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnEdit1
            // 
            this.btnEdit1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnEdit1.ButtonImage")));
            this.btnEdit1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnEdit1.ButtonText = "✏";
            this.btnEdit1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnEdit1.ClickTextColor = System.Drawing.Color.White;
            this.btnEdit1.CornerRadius = 3;
            this.btnEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.btnEdit1.HoverTextColor = System.Drawing.Color.White;
            this.btnEdit1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnEdit1.Location = new System.Drawing.Point(125, 350);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(40, 25);
            this.btnEdit1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit1.TabIndex = 8;
            this.btnEdit1.TextColor = System.Drawing.Color.White;
            this.btnEdit1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnView1
            // 
            this.btnView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnView1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnView1.ButtonImage")));
            this.btnView1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnView1.ButtonText = "👁";
            this.btnView1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnView1.ClickTextColor = System.Drawing.Color.White;
            this.btnView1.CornerRadius = 3;
            this.btnView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnView1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnView1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnView1.HoverTextColor = System.Drawing.Color.White;
            this.btnView1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnView1.Location = new System.Drawing.Point(12, 350);
            this.btnView1.Name = "btnView1";
            this.btnView1.Size = new System.Drawing.Size(40, 25);
            this.btnView1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnView1.TabIndex = 7;
            this.btnView1.TextColor = System.Drawing.Color.White;
            this.btnView1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnView1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDates1
            // 
            this.lblDates1.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblDates1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDates1.Location = new System.Drawing.Point(12, 320);
            this.lblDates1.Name = "lblDates1";
            this.lblDates1.Size = new System.Drawing.Size(275, 30);
            this.lblDates1.TabIndex = 6;
            this.lblDates1.Text = "Khởi chiếu:         28/11/2025\r\nKết thúc:            06/12/2025";
            // 
            // lblSubtitle1
            // 
            this.lblSubtitle1.AutoSize = true;
            this.lblSubtitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblSubtitle1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle1.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle1.Location = new System.Drawing.Point(12, 292);
            this.lblSubtitle1.Name = "lblSubtitle1";
            this.lblSubtitle1.Padding = new System.Windows.Forms.Padding(4);
            this.lblSubtitle1.Size = new System.Drawing.Size(92, 23);
            this.lblSubtitle1.TabIndex = 5;
            this.lblSubtitle1.Text = "🎬 Tiếng Nhật";
            // 
            // lblLanguage1
            // 
            this.lblLanguage1.AutoSize = true;
            this.lblLanguage1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLanguage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLanguage1.Location = new System.Drawing.Point(12, 270);
            this.lblLanguage1.Name = "lblLanguage1";
            this.lblLanguage1.Size = new System.Drawing.Size(103, 19);
            this.lblLanguage1.TabIndex = 4;
            this.lblLanguage1.Text = "❤️ Hành Động";
            // 
            // lblDuration1
            // 
            this.lblDuration1.AutoSize = true;
            this.lblDuration1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDuration1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDuration1.Location = new System.Drawing.Point(12, 250);
            this.lblDuration1.Name = "lblDuration1";
            this.lblDuration1.Size = new System.Drawing.Size(89, 19);
            this.lblDuration1.TabIndex = 3;
            this.lblDuration1.Text = "🔴 126 phút";
            // 
            // lblTitle1
            // 
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTitle1.Location = new System.Drawing.Point(10, 200);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(280, 45);
            this.lblTitle1.TabIndex = 2;
            this.lblTitle1.Text = "GODZILLA MINUS ONE (T13)";
            // 
            // poster1
            // 
            this.poster1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.poster1.Location = new System.Drawing.Point(10, 10);
            this.poster1.Name = "poster1";
            this.poster1.Size = new System.Drawing.Size(280, 180);
            this.poster1.TabIndex = 1;
            // 
            // badge1
            // 
            this.badge1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.badge1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.badge1.ForeColor = System.Drawing.Color.Black;
            this.badge1.Location = new System.Drawing.Point(8, 8);
            this.badge1.Name = "badge1";
            this.badge1.Size = new System.Drawing.Size(65, 18);
            this.badge1.TabIndex = 0;
            this.badge1.Text = "Sắp chiếu";
            this.badge1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieCard2
            // 
            this.movieCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movieCard2.Controls.Add(this.btnDelete2);
            this.movieCard2.Controls.Add(this.btnEdit2);
            this.movieCard2.Controls.Add(this.btnView2);
            this.movieCard2.Controls.Add(this.lblDates2);
            this.movieCard2.Controls.Add(this.lblSubtitle2);
            this.movieCard2.Controls.Add(this.lblLanguage2);
            this.movieCard2.Controls.Add(this.lblDuration2);
            this.movieCard2.Controls.Add(this.lblTitle2);
            this.movieCard2.Controls.Add(this.poster2);
            this.movieCard2.Controls.Add(this.badge2);
            this.movieCard2.Depth = 0;
            this.movieCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieCard2.Location = new System.Drawing.Point(329, 13);
            this.movieCard2.Margin = new System.Windows.Forms.Padding(8);
            this.movieCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.movieCard2.Name = "movieCard2";
            this.movieCard2.Padding = new System.Windows.Forms.Padding(5);
            this.movieCard2.Size = new System.Drawing.Size(300, 380);
            this.movieCard2.TabIndex = 1;
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnDelete2.ButtonImage")));
            this.btnDelete2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnDelete2.ButtonText = "🗑";
            this.btnDelete2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDelete2.ClickTextColor = System.Drawing.Color.White;
            this.btnDelete2.CornerRadius = 3;
            this.btnDelete2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnDelete2.HoverTextColor = System.Drawing.Color.White;
            this.btnDelete2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnDelete2.Location = new System.Drawing.Point(245, 350);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(40, 25);
            this.btnDelete2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDelete2.TabIndex = 9;
            this.btnDelete2.TextColor = System.Drawing.Color.White;
            this.btnDelete2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDelete2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnEdit2
            // 
            this.btnEdit2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnEdit2.ButtonImage")));
            this.btnEdit2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnEdit2.ButtonText = "✏";
            this.btnEdit2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnEdit2.ClickTextColor = System.Drawing.Color.White;
            this.btnEdit2.CornerRadius = 3;
            this.btnEdit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.btnEdit2.HoverTextColor = System.Drawing.Color.White;
            this.btnEdit2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnEdit2.Location = new System.Drawing.Point(125, 350);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(40, 25);
            this.btnEdit2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit2.TabIndex = 8;
            this.btnEdit2.TextColor = System.Drawing.Color.White;
            this.btnEdit2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnView2
            // 
            this.btnView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnView2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnView2.ButtonImage")));
            this.btnView2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnView2.ButtonText = "👁";
            this.btnView2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnView2.ClickTextColor = System.Drawing.Color.White;
            this.btnView2.CornerRadius = 3;
            this.btnView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnView2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnView2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnView2.HoverTextColor = System.Drawing.Color.White;
            this.btnView2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnView2.Location = new System.Drawing.Point(12, 350);
            this.btnView2.Name = "btnView2";
            this.btnView2.Size = new System.Drawing.Size(40, 25);
            this.btnView2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnView2.TabIndex = 7;
            this.btnView2.TextColor = System.Drawing.Color.White;
            this.btnView2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnView2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDates2
            // 
            this.lblDates2.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblDates2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDates2.Location = new System.Drawing.Point(12, 320);
            this.lblDates2.Name = "lblDates2";
            this.lblDates2.Size = new System.Drawing.Size(275, 30);
            this.lblDates2.TabIndex = 6;
            this.lblDates2.Text = "Khởi chiếu:         21/11/2025\r\nKết thúc:            21/12/2025";
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblSubtitle2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle2.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle2.Location = new System.Drawing.Point(12, 292);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Padding = new System.Windows.Forms.Padding(4);
            this.lblSubtitle2.Size = new System.Drawing.Size(88, 23);
            this.lblSubtitle2.TabIndex = 5;
            this.lblSubtitle2.Text = "🎬 Tiếng Việt";
            // 
            // lblLanguage2
            // 
            this.lblLanguage2.AutoSize = true;
            this.lblLanguage2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLanguage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLanguage2.Location = new System.Drawing.Point(12, 270);
            this.lblLanguage2.Name = "lblLanguage2";
            this.lblLanguage2.Size = new System.Drawing.Size(110, 19);
            this.lblLanguage2.TabIndex = 4;
            this.lblLanguage2.Text = "❤️ Hài, Gia đình";
            // 
            // lblDuration2
            // 
            this.lblDuration2.AutoSize = true;
            this.lblDuration2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDuration2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDuration2.Location = new System.Drawing.Point(12, 250);
            this.lblDuration2.Name = "lblDuration2";
            this.lblDuration2.Size = new System.Drawing.Size(81, 19);
            this.lblDuration2.TabIndex = 3;
            this.lblDuration2.Text = "🔴 95 phút";
            // 
            // lblTitle2
            // 
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTitle2.Location = new System.Drawing.Point(10, 200);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(280, 45);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "CƯỚI VỢ CHO CHA";
            // 
            // poster2
            // 
            this.poster2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.poster2.Location = new System.Drawing.Point(10, 10);
            this.poster2.Name = "poster2";
            this.poster2.Size = new System.Drawing.Size(280, 180);
            this.poster2.TabIndex = 1;
            // 
            // badge2
            // 
            this.badge2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.badge2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.badge2.ForeColor = System.Drawing.Color.Black;
            this.badge2.Location = new System.Drawing.Point(8, 8);
            this.badge2.Name = "badge2";
            this.badge2.Size = new System.Drawing.Size(65, 18);
            this.badge2.TabIndex = 0;
            this.badge2.Text = "Sắp chiếu";
            this.badge2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieCard3
            // 
            this.movieCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movieCard3.Controls.Add(this.btnDelete3);
            this.movieCard3.Controls.Add(this.btnEdit3);
            this.movieCard3.Controls.Add(this.btnView3);
            this.movieCard3.Controls.Add(this.lblDates3);
            this.movieCard3.Controls.Add(this.lblSubtitle3);
            this.movieCard3.Controls.Add(this.lblLanguage3);
            this.movieCard3.Controls.Add(this.lblDuration3);
            this.movieCard3.Controls.Add(this.lblTitle3);
            this.movieCard3.Controls.Add(this.poster3);
            this.movieCard3.Controls.Add(this.badge3);
            this.movieCard3.Depth = 0;
            this.movieCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieCard3.Location = new System.Drawing.Point(645, 13);
            this.movieCard3.Margin = new System.Windows.Forms.Padding(8);
            this.movieCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.movieCard3.Name = "movieCard3";
            this.movieCard3.Padding = new System.Windows.Forms.Padding(5);
            this.movieCard3.Size = new System.Drawing.Size(300, 380);
            this.movieCard3.TabIndex = 2;
            // 
            // btnDelete3
            // 
            this.btnDelete3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnDelete3.ButtonImage")));
            this.btnDelete3.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnDelete3.ButtonText = "🗑";
            this.btnDelete3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDelete3.ClickTextColor = System.Drawing.Color.White;
            this.btnDelete3.CornerRadius = 3;
            this.btnDelete3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnDelete3.HoverTextColor = System.Drawing.Color.White;
            this.btnDelete3.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnDelete3.Location = new System.Drawing.Point(245, 350);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(40, 25);
            this.btnDelete3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDelete3.TabIndex = 9;
            this.btnDelete3.TextColor = System.Drawing.Color.White;
            this.btnDelete3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDelete3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnEdit3
            // 
            this.btnEdit3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnEdit3.ButtonImage")));
            this.btnEdit3.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnEdit3.ButtonText = "✏";
            this.btnEdit3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnEdit3.ClickTextColor = System.Drawing.Color.White;
            this.btnEdit3.CornerRadius = 3;
            this.btnEdit3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.btnEdit3.HoverTextColor = System.Drawing.Color.White;
            this.btnEdit3.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnEdit3.Location = new System.Drawing.Point(125, 350);
            this.btnEdit3.Name = "btnEdit3";
            this.btnEdit3.Size = new System.Drawing.Size(40, 25);
            this.btnEdit3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit3.TabIndex = 8;
            this.btnEdit3.TextColor = System.Drawing.Color.White;
            this.btnEdit3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnView3
            // 
            this.btnView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnView3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnView3.ButtonImage")));
            this.btnView3.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnView3.ButtonText = "👁";
            this.btnView3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnView3.ClickTextColor = System.Drawing.Color.White;
            this.btnView3.CornerRadius = 3;
            this.btnView3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnView3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnView3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnView3.HoverTextColor = System.Drawing.Color.White;
            this.btnView3.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnView3.Location = new System.Drawing.Point(12, 350);
            this.btnView3.Name = "btnView3";
            this.btnView3.Size = new System.Drawing.Size(40, 25);
            this.btnView3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnView3.TabIndex = 7;
            this.btnView3.TextColor = System.Drawing.Color.White;
            this.btnView3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnView3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDates3
            // 
            this.lblDates3.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblDates3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDates3.Location = new System.Drawing.Point(12, 320);
            this.lblDates3.Name = "lblDates3";
            this.lblDates3.Size = new System.Drawing.Size(275, 30);
            this.lblDates3.TabIndex = 6;
            this.lblDates3.Text = "Khởi chiếu:         14/11/2025\r\nKết thúc:            ";
            // 
            // lblSubtitle3
            // 
            this.lblSubtitle3.AutoSize = true;
            this.lblSubtitle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblSubtitle3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle3.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle3.Location = new System.Drawing.Point(12, 292);
            this.lblSubtitle3.Name = "lblSubtitle3";
            this.lblSubtitle3.Padding = new System.Windows.Forms.Padding(4);
            this.lblSubtitle3.Size = new System.Drawing.Size(88, 23);
            this.lblSubtitle3.TabIndex = 5;
            this.lblSubtitle3.Text = "🎬 Tiếng Thái";
            // 
            // lblLanguage3
            // 
            this.lblLanguage3.AutoSize = true;
            this.lblLanguage3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLanguage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLanguage3.Location = new System.Drawing.Point(12, 270);
            this.lblLanguage3.Name = "lblLanguage3";
            this.lblLanguage3.Size = new System.Drawing.Size(100, 19);
            this.lblLanguage3.TabIndex = 4;
            this.lblLanguage3.Text = "❤️ Drama, Hài";
            // 
            // lblDuration3
            // 
            this.lblDuration3.AutoSize = true;
            this.lblDuration3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDuration3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDuration3.Location = new System.Drawing.Point(12, 250);
            this.lblDuration3.Name = "lblDuration3";
            this.lblDuration3.Size = new System.Drawing.Size(81, 19);
            this.lblDuration3.TabIndex = 3;
            this.lblDuration3.Text = "🔴 90 phút";
            // 
            // lblTitle3
            // 
            this.lblTitle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTitle3.Location = new System.Drawing.Point(10, 200);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(280, 45);
            this.lblTitle3.TabIndex = 2;
            this.lblTitle3.Text = "SƯ THẦY GẶP SƯ LÃY (T16)";
            // 
            // poster3
            // 
            this.poster3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.poster3.Location = new System.Drawing.Point(10, 10);
            this.poster3.Name = "poster3";
            this.poster3.Size = new System.Drawing.Size(280, 180);
            this.poster3.TabIndex = 1;
            // 
            // badge3
            // 
            this.badge3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.badge3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.badge3.ForeColor = System.Drawing.Color.Black;
            this.badge3.Location = new System.Drawing.Point(8, 8);
            this.badge3.Name = "badge3";
            this.badge3.Size = new System.Drawing.Size(65, 18);
            this.badge3.TabIndex = 0;
            this.badge3.Text = "Sắp chiếu";
            this.badge3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieCard4
            // 
            this.movieCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movieCard4.Controls.Add(this.btnDelete4);
            this.movieCard4.Controls.Add(this.btnEdit4);
            this.movieCard4.Controls.Add(this.btnView4);
            this.movieCard4.Controls.Add(this.lblDates4);
            this.movieCard4.Controls.Add(this.lblSubtitle4);
            this.movieCard4.Controls.Add(this.lblLanguage4);
            this.movieCard4.Controls.Add(this.lblDuration4);
            this.movieCard4.Controls.Add(this.lblTitle4);
            this.movieCard4.Controls.Add(this.poster4);
            this.movieCard4.Controls.Add(this.badge4);
            this.movieCard4.Depth = 0;
            this.movieCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieCard4.Location = new System.Drawing.Point(961, 13);
            this.movieCard4.Margin = new System.Windows.Forms.Padding(8);
            this.movieCard4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.movieCard4.Name = "movieCard4";
            this.movieCard4.Padding = new System.Windows.Forms.Padding(5);
            this.movieCard4.Size = new System.Drawing.Size(300, 380);
            this.movieCard4.TabIndex = 3;
            // 
            // btnDelete4
            // 
            this.btnDelete4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete4.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnDelete4.ButtonImage")));
            this.btnDelete4.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnDelete4.ButtonText = "🗑";
            this.btnDelete4.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDelete4.ClickTextColor = System.Drawing.Color.White;
            this.btnDelete4.CornerRadius = 3;
            this.btnDelete4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDelete4.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnDelete4.HoverTextColor = System.Drawing.Color.White;
            this.btnDelete4.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnDelete4.Location = new System.Drawing.Point(245, 350);
            this.btnDelete4.Name = "btnDelete4";
            this.btnDelete4.Size = new System.Drawing.Size(40, 25);
            this.btnDelete4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDelete4.TabIndex = 9;
            this.btnDelete4.TextColor = System.Drawing.Color.White;
            this.btnDelete4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDelete4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnEdit4
            // 
            this.btnEdit4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit4.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnEdit4.ButtonImage")));
            this.btnEdit4.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnEdit4.ButtonText = "✏";
            this.btnEdit4.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnEdit4.ClickTextColor = System.Drawing.Color.White;
            this.btnEdit4.CornerRadius = 3;
            this.btnEdit4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit4.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.btnEdit4.HoverTextColor = System.Drawing.Color.White;
            this.btnEdit4.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnEdit4.Location = new System.Drawing.Point(125, 350);
            this.btnEdit4.Name = "btnEdit4";
            this.btnEdit4.Size = new System.Drawing.Size(40, 25);
            this.btnEdit4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit4.TabIndex = 8;
            this.btnEdit4.TextColor = System.Drawing.Color.White;
            this.btnEdit4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnView4
            // 
            this.btnView4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnView4.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnView4.ButtonImage")));
            this.btnView4.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnView4.ButtonText = "👁";
            this.btnView4.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnView4.ClickTextColor = System.Drawing.Color.White;
            this.btnView4.CornerRadius = 3;
            this.btnView4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnView4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnView4.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnView4.HoverTextColor = System.Drawing.Color.White;
            this.btnView4.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnView4.Location = new System.Drawing.Point(12, 350);
            this.btnView4.Name = "btnView4";
            this.btnView4.Size = new System.Drawing.Size(40, 25);
            this.btnView4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnView4.TabIndex = 7;
            this.btnView4.TextColor = System.Drawing.Color.White;
            this.btnView4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnView4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDates4
            // 
            this.lblDates4.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblDates4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDates4.Location = new System.Drawing.Point(12, 320);
            this.lblDates4.Name = "lblDates4";
            this.lblDates4.Size = new System.Drawing.Size(275, 30);
            this.lblDates4.TabIndex = 6;
            this.lblDates4.Text = "Khởi chiếu:         14/11/2025\r\nKết thúc:            30/12/2025";
            // 
            // lblSubtitle4
            // 
            this.lblSubtitle4.AutoSize = true;
            this.lblSubtitle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblSubtitle4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle4.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle4.Location = new System.Drawing.Point(12, 292);
            this.lblSubtitle4.Name = "lblSubtitle4";
            this.lblSubtitle4.Padding = new System.Windows.Forms.Padding(4);
            this.lblSubtitle4.Size = new System.Drawing.Size(87, 23);
            this.lblSubtitle4.TabIndex = 5;
            this.lblSubtitle4.Text = "🎬 Tiếng Hàn";
            // 
            // lblLanguage4
            // 
            this.lblLanguage4.AutoSize = true;
            this.lblLanguage4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLanguage4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLanguage4.Location = new System.Drawing.Point(12, 270);
            this.lblLanguage4.Name = "lblLanguage4";
            this.lblLanguage4.Size = new System.Drawing.Size(130, 19);
            this.lblLanguage4.TabIndex = 4;
            this.lblLanguage4.Text = "❤️ Hài Hớp, Tâm Lý";
            // 
            // lblDuration4
            // 
            this.lblDuration4.AutoSize = true;
            this.lblDuration4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDuration4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDuration4.Location = new System.Drawing.Point(12, 250);
            this.lblDuration4.Name = "lblDuration4";
            this.lblDuration4.Size = new System.Drawing.Size(81, 19);
            this.lblDuration4.TabIndex = 3;
            this.lblDuration4.Text = "🔴 95 phút";
            // 
            // lblTitle4
            // 
            this.lblTitle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTitle4.Location = new System.Drawing.Point(10, 200);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(280, 45);
            this.lblTitle4.TabIndex = 2;
            this.lblTitle4.Text = "KHÔNG BÓNG TUYẾT NÀO TRONG SẠCH";
            // 
            // poster4
            // 
            this.poster4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.poster4.Location = new System.Drawing.Point(10, 10);
            this.poster4.Name = "poster4";
            this.poster4.Size = new System.Drawing.Size(280, 180);
            this.poster4.TabIndex = 1;
            // 
            // badge4
            // 
            this.badge4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.badge4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.badge4.ForeColor = System.Drawing.Color.Black;
            this.badge4.Location = new System.Drawing.Point(8, 8);
            this.badge4.Name = "badge4";
            this.badge4.Size = new System.Drawing.Size(65, 18);
            this.badge4.TabIndex = 0;
            this.badge4.Text = "Sắp chiếu";
            this.badge4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Movie_MainUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "Movie_MainUC";
            this.Size = new System.Drawing.Size(1360, 800);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.moviesContainer.ResumeLayout(false);
            this.movieCard1.ResumeLayout(false);
            this.movieCard1.PerformLayout();
            this.movieCard2.ResumeLayout(false);
            this.movieCard2.PerformLayout();
            this.movieCard3.ResumeLayout(false);
            this.movieCard3.PerformLayout();
            this.movieCard4.ResumeLayout(false);
            this.movieCard4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbl_MovieTitle;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private ReaLTaiizor.Controls.ParrotButton btnAddMovie;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel searchPanel;
        private ReaLTaiizor.Controls.MaterialTextBox txtSearch;
        private ReaLTaiizor.Controls.MaterialComboBox cboFilter;
        private ReaLTaiizor.Controls.ParrotButton btnSearch;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.FlowLayoutPanel moviesContainer;
        private ReaLTaiizor.Controls.MaterialCard movieCard1;
        private System.Windows.Forms.Label badge1;
        private System.Windows.Forms.Panel poster1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblDuration1;
        private System.Windows.Forms.Label lblLanguage1;
        private System.Windows.Forms.Label lblSubtitle1;
        private System.Windows.Forms.Label lblDates1;
        private ReaLTaiizor.Controls.ParrotButton btnView1;
        private ReaLTaiizor.Controls.ParrotButton btnEdit1;
        private ReaLTaiizor.Controls.ParrotButton btnDelete1;
        private ReaLTaiizor.Controls.MaterialCard movieCard2;
        private System.Windows.Forms.Label badge2;
        private System.Windows.Forms.Panel poster2;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblDuration2;
        private System.Windows.Forms.Label lblLanguage2;
        private System.Windows.Forms.Label lblSubtitle2;
        private System.Windows.Forms.Label lblDates2;
        private ReaLTaiizor.Controls.ParrotButton btnView2;
        private ReaLTaiizor.Controls.ParrotButton btnEdit2;
        private ReaLTaiizor.Controls.ParrotButton btnDelete2;
        private ReaLTaiizor.Controls.MaterialCard movieCard3;
        private System.Windows.Forms.Label badge3;
        private System.Windows.Forms.Panel poster3;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblDuration3;
        private System.Windows.Forms.Label lblLanguage3;
        private System.Windows.Forms.Label lblSubtitle3;
        private System.Windows.Forms.Label lblDates3;
        private ReaLTaiizor.Controls.ParrotButton btnView3;
        private ReaLTaiizor.Controls.ParrotButton btnEdit3;
        private ReaLTaiizor.Controls.ParrotButton btnDelete3;
        private ReaLTaiizor.Controls.MaterialCard movieCard4;
        private System.Windows.Forms.Label badge4;
        private System.Windows.Forms.Panel poster4;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.Label lblDuration4;
        private System.Windows.Forms.Label lblLanguage4;
        private System.Windows.Forms.Label lblSubtitle4;
        private System.Windows.Forms.Label lblDates4;
        private ReaLTaiizor.Controls.ParrotButton btnView4;
        private ReaLTaiizor.Controls.ParrotButton btnEdit4;
        private ReaLTaiizor.Controls.ParrotButton btnDelete4;
    }
}