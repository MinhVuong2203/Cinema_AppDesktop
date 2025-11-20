namespace UI.Movie
{
    partial class AddMovieUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovieUC));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new ReaLTaiizor.Controls.ParrotButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.grb_Movie = new ReaLTaiizor.Controls.GroupBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.cbotype = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTrailer = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cboGenre = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.chkSubtitle = new System.Windows.Forms.CheckBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnCancel = new ReaLTaiizor.Controls.ParrotButton();
            this.btnSave = new ReaLTaiizor.Controls.ParrotButton();
            this.lblPoster = new System.Windows.Forms.Label();
            this.btnUploadImage = new ReaLTaiizor.Controls.ParrotButton();
            this.txtPreview = new ReaLTaiizor.Controls.MaterialTextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.txtCategory = new ReaLTaiizor.Controls.MaterialTextBox();
            this.txtMovieName = new ReaLTaiizor.Controls.MaterialTextBox();
            this.cboLanguage = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtDescription = new ReaLTaiizor.Controls.MaterialTextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtTrailer = new ReaLTaiizor.Controls.MaterialTextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtDuration = new ReaLTaiizor.Controls.MaterialTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.grb_Movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelHeader.Size = new System.Drawing.Size(1360, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBack.ButtonImage = null;
            this.btnBack.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnBack.ButtonText = "← Quay lại";
            this.btnBack.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnBack.ClickTextColor = System.Drawing.Color.White;
            this.btnBack.CornerRadius = 5;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnBack.HoverTextColor = System.Drawing.Color.White;
            this.btnBack.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnBack.Location = new System.Drawing.Point(1203, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 40);
            this.btnBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnBack.TabIndex = 1;
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⊕ Thêm Phim Mới";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.grb_Movie);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(50, 30, 50, 30);
            this.panelMain.Size = new System.Drawing.Size(1360, 720);
            this.panelMain.TabIndex = 1;
            // 
            // grb_Movie
            // 
            this.grb_Movie.BackColor = System.Drawing.Color.Transparent;
            this.grb_Movie.BackGColor = System.Drawing.Color.CornflowerBlue;
            this.grb_Movie.BaseColor = System.Drawing.Color.Transparent;
            this.grb_Movie.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.grb_Movie.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.grb_Movie.Controls.Add(this.lblDuration);
            this.grb_Movie.Controls.Add(this.cbotype);
            this.grb_Movie.Controls.Add(this.lblType);
            this.grb_Movie.Controls.Add(this.lblTrailer);
            this.grb_Movie.Controls.Add(this.lblGenre);
            this.grb_Movie.Controls.Add(this.dtpEndDate);
            this.grb_Movie.Controls.Add(this.cboGenre);
            this.grb_Movie.Controls.Add(this.lblEndDate);
            this.grb_Movie.Controls.Add(this.lblSubtitle);
            this.grb_Movie.Controls.Add(this.dtpStartDate);
            this.grb_Movie.Controls.Add(this.chkSubtitle);
            this.grb_Movie.Controls.Add(this.lblStartDate);
            this.grb_Movie.Controls.Add(this.btnCancel);
            this.grb_Movie.Controls.Add(this.btnSave);
            this.grb_Movie.Controls.Add(this.lblPoster);
            this.grb_Movie.Controls.Add(this.btnUploadImage);
            this.grb_Movie.Controls.Add(this.txtPreview);
            this.grb_Movie.Controls.Add(this.picImage);
            this.grb_Movie.Controls.Add(this.lblPreview);
            this.grb_Movie.Controls.Add(this.txtCategory);
            this.grb_Movie.Controls.Add(this.txtMovieName);
            this.grb_Movie.Controls.Add(this.cboLanguage);
            this.grb_Movie.Controls.Add(this.txtDescription);
            this.grb_Movie.Controls.Add(this.lblMovieName);
            this.grb_Movie.Controls.Add(this.lblDescription);
            this.grb_Movie.Controls.Add(this.lblLanguage);
            this.grb_Movie.Controls.Add(this.txtTrailer);
            this.grb_Movie.Controls.Add(this.lblCategory);
            this.grb_Movie.Controls.Add(this.txtDuration);
            this.grb_Movie.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Movie.ForeColor = System.Drawing.Color.Navy;
            this.grb_Movie.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grb_Movie.Location = new System.Drawing.Point(89, 53);
            this.grb_Movie.MinimumSize = new System.Drawing.Size(136, 50);
            this.grb_Movie.Name = "grb_Movie";
            this.grb_Movie.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.grb_Movie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grb_Movie.Size = new System.Drawing.Size(1123, 780);
            this.grb_Movie.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.grb_Movie.TabIndex = 25;
            this.grb_Movie.Text = "Thông tin phim";
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblDuration.Location = new System.Drawing.Point(57, 145);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(197, 20);
            this.lblDuration.TabIndex = 36;
            this.lblDuration.Text = "⏱️ Thời Lượng (phút)";
            // 
            // cbotype
            // 
            this.cbotype.AutoResize = false;
            this.cbotype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbotype.Depth = 0;
            this.cbotype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbotype.DropDownHeight = 174;
            this.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotype.DropDownWidth = 121;
            this.cbotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbotype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Hint = "-- Chọn loại phim --";
            this.cbotype.IntegralHeight = false;
            this.cbotype.ItemHeight = 43;
            this.cbotype.Items.AddRange(new object[] {
            "2D",
            "3D",
            "4D",
            "IMax"});
            this.cbotype.Location = new System.Drawing.Point(590, 276);
            this.cbotype.MaxDropDownItems = 4;
            this.cbotype.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(162, 49);
            this.cbotype.StartIndex = 0;
            this.cbotype.TabIndex = 35;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblType.Location = new System.Drawing.Point(590, 253);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(104, 20);
            this.lblType.TabIndex = 34;
            this.lblType.Text = "🎬 Loại phim";
            // 
            // lblTrailer
            // 
            this.lblTrailer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrailer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTrailer.Location = new System.Drawing.Point(54, 438);
            this.lblTrailer.Name = "lblTrailer";
            this.lblTrailer.Size = new System.Drawing.Size(132, 20);
            this.lblTrailer.TabIndex = 33;
            this.lblTrailer.Text = "🎬 Link Trailer";
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblGenre.Location = new System.Drawing.Point(57, 253);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(151, 20);
            this.lblGenre.TabIndex = 25;
            this.lblGenre.Text = "🎭 Giới Hạn Tuổi";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(412, 393);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(340, 30);
            this.dtpEndDate.TabIndex = 32;
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
            this.cboGenre.Hint = "-- Chọn giới hạn tuổi --";
            this.cboGenre.IntegralHeight = false;
            this.cboGenre.ItemHeight = 43;
            this.cboGenre.Items.AddRange(new object[] {
            "P - Mọi lứa tuổi",
            "K - Dưới 13 tuổi",
            "T13 - Từ 13 tuổi",
            "T16 - Từ 16 tuổi",
            "T18 - Từ 18 tuổi",
            "C - Cấm chiếu"});
            this.cboGenre.Location = new System.Drawing.Point(57, 276);
            this.cboGenre.MaxDropDownItems = 4;
            this.cboGenre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(310, 49);
            this.cboGenre.StartIndex = 0;
            this.cboGenre.TabIndex = 26;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblEndDate.Location = new System.Drawing.Point(412, 352);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(160, 20);
            this.lblEndDate.TabIndex = 31;
            this.lblEndDate.Text = "🗓️ Ngày Kết Thúc";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblSubtitle.Location = new System.Drawing.Point(416, 253);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(113, 20);
            this.lblSubtitle.TabIndex = 27;
            this.lblSubtitle.Text = "🔊 Lồng Tiếng";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(57, 393);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(310, 30);
            this.dtpStartDate.TabIndex = 30;
            // 
            // chkSubtitle
            // 
            this.chkSubtitle.AutoSize = true;
            this.chkSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkSubtitle.Location = new System.Drawing.Point(416, 292);
            this.chkSubtitle.Name = "chkSubtitle";
            this.chkSubtitle.Size = new System.Drawing.Size(156, 24);
            this.chkSubtitle.TabIndex = 28;
            this.chkSubtitle.Text = "Phim có lồng tiếng";
            this.chkSubtitle.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblStartDate.Location = new System.Drawing.Point(57, 352);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(181, 20);
            this.lblStartDate.TabIndex = 29;
            this.lblStartDate.Text = "🗓️ Ngày Khởi Chiếu";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancel.ButtonImage = null;
            this.btnCancel.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnCancel.ButtonText = "Hủy Bỏ";
            this.btnCancel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnCancel.ClickTextColor = System.Drawing.Color.White;
            this.btnCancel.CornerRadius = 5;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.White;
            this.btnCancel.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnCancel.Location = new System.Drawing.Point(940, 457);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.ButtonImage = null;
            this.btnSave.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnSave.ButtonText = "Lưu Phim";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(137)))), ((int)(((byte)(55)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.White;
            this.btnSave.CornerRadius = 5;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(187)))), ((int)(((byte)(80)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.White;
            this.btnSave.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(773, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 40);
            this.btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSave.TabIndex = 0;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblPoster
            // 
            this.lblPoster.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblPoster.Location = new System.Drawing.Point(829, 44);
            this.lblPoster.Name = "lblPoster";
            this.lblPoster.Size = new System.Drawing.Size(213, 20);
            this.lblPoster.TabIndex = 22;
            this.lblPoster.Text = "📷 Hình Ảnh Poster Phim";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnUploadImage.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnUploadImage.ButtonImage")));
            this.btnUploadImage.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Dark;
            this.btnUploadImage.ButtonText = "Tải ảnh lên";
            this.btnUploadImage.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnUploadImage.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnUploadImage.CornerRadius = 5;
            this.btnUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadImage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUploadImage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnUploadImage.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnUploadImage.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnUploadImage.Location = new System.Drawing.Point(858, 322);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(128, 33);
            this.btnUploadImage.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnUploadImage.TabIndex = 11;
            this.btnUploadImage.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnUploadImage.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnUploadImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // txtPreview
            // 
            this.txtPreview.AnimateReadOnly = false;
            this.txtPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreview.Depth = 0;
            this.txtPreview.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPreview.Hint = "Nhập nội dung phim.";
            this.txtPreview.LeadingIcon = null;
            this.txtPreview.Location = new System.Drawing.Point(56, 707);
            this.txtPreview.MaxLength = 32767;
            this.txtPreview.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPreview.Multiline = false;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(696, 50);
            this.txtPreview.TabIndex = 24;
            this.txtPreview.Text = "";
            this.txtPreview.TrailingIcon = null;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(833, 76);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(180, 240);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 10;
            this.picImage.TabStop = false;
            // 
            // lblPreview
            // 
            this.lblPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblPreview.Location = new System.Drawing.Point(56, 664);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(152, 20);
            this.lblPreview.TabIndex = 23;
            this.lblPreview.Text = "📝 Nội Dung";
            // 
            // txtCategory
            // 
            this.txtCategory.AnimateReadOnly = false;
            this.txtCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.Depth = 0;
            this.txtCategory.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCategory.Hint = "VD: Hành động, Kinh dị, Phiêu lưu";
            this.txtCategory.LeadingIcon = null;
            this.txtCategory.Location = new System.Drawing.Point(416, 76);
            this.txtCategory.MaxLength = 32767;
            this.txtCategory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCategory.Multiline = false;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(336, 50);
            this.txtCategory.TabIndex = 4;
            this.txtCategory.Text = "";
            this.txtCategory.TrailingIcon = null;
            // 
            // txtMovieName
            // 
            this.txtMovieName.AnimateReadOnly = false;
            this.txtMovieName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMovieName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovieName.Depth = 0;
            this.txtMovieName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMovieName.Hint = "Nhập tên phim...";
            this.txtMovieName.LeadingIcon = null;
            this.txtMovieName.Location = new System.Drawing.Point(57, 76);
            this.txtMovieName.MaxLength = 32767;
            this.txtMovieName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtMovieName.Multiline = false;
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(310, 50);
            this.txtMovieName.TabIndex = 0;
            this.txtMovieName.Text = "";
            this.txtMovieName.TrailingIcon = null;
            // 
            // cboLanguage
            // 
            this.cboLanguage.AutoResize = false;
            this.cboLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboLanguage.Depth = 0;
            this.cboLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboLanguage.DropDownHeight = 174;
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.DropDownWidth = 121;
            this.cboLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Hint = "-- Chọn ngôn ngữ --";
            this.cboLanguage.IntegralHeight = false;
            this.cboLanguage.ItemHeight = 43;
            this.cboLanguage.Items.AddRange(new object[] {
            "Tiếng Việt",
            "Tiếng Anh",
            "Tiếng Nhật",
            "Tiếng Hàn",
            "Tiếng Trung",
            "Tiếng Thái",
            "Tiếng Pháp",
            "Tiếng Tây Ban Nha"});
            this.cboLanguage.Location = new System.Drawing.Point(416, 182);
            this.cboLanguage.MaxDropDownItems = 4;
            this.cboLanguage.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(336, 49);
            this.cboLanguage.StartIndex = 0;
            this.cboLanguage.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.AnimateReadOnly = false;
            this.txtDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Depth = 0;
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescription.Hint = "Nhập mô tả chi tiết về phim: diễn viên, đạo diễn...";
            this.txtDescription.LeadingIcon = null;
            this.txtDescription.Location = new System.Drawing.Point(57, 591);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(695, 50);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.Text = "";
            this.txtDescription.TrailingIcon = null;
            // 
            // lblMovieName
            // 
            this.lblMovieName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblMovieName.Location = new System.Drawing.Point(66, 44);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(120, 20);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "🎬 Tên Phim";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblDescription.Location = new System.Drawing.Point(57, 550);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(151, 20);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "📝 Mô Tả Phim";
            // 
            // lblLanguage
            // 
            this.lblLanguage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblLanguage.Location = new System.Drawing.Point(412, 145);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(138, 20);
            this.lblLanguage.TabIndex = 5;
            this.lblLanguage.Text = "🗣️ Ngôn Ngữ";
            // 
            // txtTrailer
            // 
            this.txtTrailer.AnimateReadOnly = false;
            this.txtTrailer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTrailer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrailer.Depth = 0;
            this.txtTrailer.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTrailer.Hint = "https://youtube.com/watch?v=...";
            this.txtTrailer.LeadingIcon = null;
            this.txtTrailer.Location = new System.Drawing.Point(57, 475);
            this.txtTrailer.MaxLength = 32767;
            this.txtTrailer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtTrailer.Multiline = false;
            this.txtTrailer.Name = "txtTrailer";
            this.txtTrailer.Size = new System.Drawing.Size(695, 50);
            this.txtTrailer.TabIndex = 16;
            this.txtTrailer.Text = "";
            this.txtTrailer.TrailingIcon = null;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblCategory.Location = new System.Drawing.Point(416, 44);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(122, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "🎭 Thể Loại";
            // 
            // txtDuration
            // 
            this.txtDuration.AnimateReadOnly = false;
            this.txtDuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuration.Depth = 0;
            this.txtDuration.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDuration.Hint = "VD: 120";
            this.txtDuration.LeadingIcon = null;
            this.txtDuration.Location = new System.Drawing.Point(57, 181);
            this.txtDuration.MaxLength = 32767;
            this.txtDuration.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDuration.Multiline = false;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(310, 50);
            this.txtDuration.TabIndex = 2;
            this.txtDuration.Text = "";
            this.txtDuration.TrailingIcon = null;
            // 
            // AddMovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "AddMovieUC";
            this.Size = new System.Drawing.Size(1360, 780);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.grb_Movie.ResumeLayout(false);
            this.grb_Movie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private ReaLTaiizor.Controls.ParrotButton btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ReaLTaiizor.Controls.GroupBox grb_Movie;
        private System.Windows.Forms.Label lblTrailer;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private ReaLTaiizor.Controls.MaterialComboBox cboGenre;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.CheckBox chkSubtitle;
        private System.Windows.Forms.Label lblStartDate;
        private ReaLTaiizor.Controls.ParrotButton btnCancel;
        private ReaLTaiizor.Controls.ParrotButton btnSave;
        private System.Windows.Forms.Label lblPoster;
        private ReaLTaiizor.Controls.ParrotButton btnUploadImage;
        private ReaLTaiizor.Controls.MaterialTextBox txtPreview;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblPreview;
        private ReaLTaiizor.Controls.MaterialTextBox txtCategory;
        private ReaLTaiizor.Controls.MaterialTextBox txtMovieName;
        private ReaLTaiizor.Controls.MaterialComboBox cboLanguage;
        private ReaLTaiizor.Controls.MaterialTextBox txtDescription;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLanguage;
        private ReaLTaiizor.Controls.MaterialTextBox txtTrailer;
        private System.Windows.Forms.Label lblCategory;
        private ReaLTaiizor.Controls.MaterialTextBox txtDuration;
        private ReaLTaiizor.Controls.MaterialComboBox cbotype;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDuration;
    }
}