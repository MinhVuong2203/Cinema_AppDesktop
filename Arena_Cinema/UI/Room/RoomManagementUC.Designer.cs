namespace UI.Room
{
    partial class RoomManagementUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomManagementUC));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddRoom = new ReaLTaiizor.Controls.ParrotButton();
            this.cmbBranch = new ReaLTaiizor.Controls.HopeComboBox();
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
            this.badge4 = new System.Windows.Forms.Label();
            this.poster4 = new System.Windows.Forms.Panel();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.lblDuration4 = new System.Windows.Forms.Label();
            this.lblLanguage4 = new System.Windows.Forms.Label();
            this.lblSubtitle4 = new System.Windows.Forms.Label();
            this.lblDates4 = new System.Windows.Forms.Label();
            this.btnView4 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnEdit4 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnDelete4 = new ReaLTaiizor.Controls.ParrotButton();
            this.movieCard4 = new ReaLTaiizor.Controls.MaterialCard();
            this.badge3 = new System.Windows.Forms.Label();
            this.poster3 = new System.Windows.Forms.Panel();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblDuration3 = new System.Windows.Forms.Label();
            this.lblLanguage3 = new System.Windows.Forms.Label();
            this.lblSubtitle3 = new System.Windows.Forms.Label();
            this.lblDates3 = new System.Windows.Forms.Label();
            this.btnView3 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnEdit3 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnDelete3 = new ReaLTaiizor.Controls.ParrotButton();
            this.movieCard3 = new ReaLTaiizor.Controls.MaterialCard();
            this.badge2 = new System.Windows.Forms.Label();
            this.poster2 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblDuration2 = new System.Windows.Forms.Label();
            this.lblLanguage2 = new System.Windows.Forms.Label();
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.lblDates2 = new System.Windows.Forms.Label();
            this.btnView2 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnEdit2 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnDelete2 = new ReaLTaiizor.Controls.ParrotButton();
            this.movieCard2 = new ReaLTaiizor.Controls.MaterialCard();
            this.panelHeader.SuspendLayout();
            this.moviesContainer.SuspendLayout();
            this.movieCard1.SuspendLayout();
            this.movieCard4.SuspendLayout();
            this.movieCard3.SuspendLayout();
            this.movieCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnAddRoom);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1337, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "📽 Quản Lý Phòng chiếu";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnAddRoom.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.ButtonImage")));
            this.btnAddRoom.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnAddRoom.ButtonText = "+ Thêm Phòng Mới";
            this.btnAddRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddRoom.ClickTextColor = System.Drawing.Color.White;
            this.btnAddRoom.CornerRadius = 5;
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnAddRoom.HoverTextColor = System.Drawing.Color.White;
            this.btnAddRoom.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnAddRoom.Location = new System.Drawing.Point(1170, 12);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(170, 36);
            this.btnAddRoom.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnAddRoom.TabIndex = 2;
            this.btnAddRoom.TextColor = System.Drawing.Color.White;
            this.btnAddRoom.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAddRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // cmbBranch
            // 
            this.cmbBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBranch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.ItemHeight = 30;
            this.cmbBranch.Location = new System.Drawing.Point(994, 66);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(340, 36);
            this.cmbBranch.TabIndex = 2;
            // 
            // moviesContainer
            // 
            this.moviesContainer.AutoScroll = true;
            this.moviesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.moviesContainer.Controls.Add(this.movieCard1);
            this.moviesContainer.Controls.Add(this.movieCard2);
            this.moviesContainer.Controls.Add(this.movieCard3);
            this.moviesContainer.Controls.Add(this.movieCard4);
            this.moviesContainer.Location = new System.Drawing.Point(13, 119);
            this.moviesContainer.Name = "moviesContainer";
            this.moviesContainer.Padding = new System.Windows.Forms.Padding(5);
            this.moviesContainer.Size = new System.Drawing.Size(1310, 576);
            this.moviesContainer.TabIndex = 3;
            this.moviesContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.moviesContainer_Paint);
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
            this.movieCard1.Size = new System.Drawing.Size(300, 401);
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
            this.btnDelete1.Location = new System.Drawing.Point(245, 351);
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
            this.btnEdit1.Location = new System.Drawing.Point(125, 351);
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
            this.btnView1.Location = new System.Drawing.Point(12, 351);
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
            // poster4
            // 
            this.poster4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.poster4.Location = new System.Drawing.Point(10, 10);
            this.poster4.Name = "poster4";
            this.poster4.Size = new System.Drawing.Size(280, 180);
            this.poster4.TabIndex = 1;
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
            // lblLanguage4
            // 
            this.lblLanguage4.AutoSize = true;
            this.lblLanguage4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLanguage4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLanguage4.Location = new System.Drawing.Point(12, 270);
            this.lblLanguage4.Name = "lblLanguage4";
            this.lblLanguage4.Size = new System.Drawing.Size(133, 19);
            this.lblLanguage4.TabIndex = 4;
            this.lblLanguage4.Text = "❤️ Hài Hớp, Tâm Lý";
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
            this.lblSubtitle4.Size = new System.Drawing.Size(80, 23);
            this.lblSubtitle4.TabIndex = 5;
            this.lblSubtitle4.Text = "🎬 Tiếng Hàn";
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
            this.btnView4.Location = new System.Drawing.Point(12, 351);
            this.btnView4.Name = "btnView4";
            this.btnView4.Size = new System.Drawing.Size(40, 25);
            this.btnView4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnView4.TabIndex = 7;
            this.btnView4.TextColor = System.Drawing.Color.White;
            this.btnView4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnView4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnEdit4.Location = new System.Drawing.Point(125, 351);
            this.btnEdit4.Name = "btnEdit4";
            this.btnEdit4.Size = new System.Drawing.Size(40, 25);
            this.btnEdit4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit4.TabIndex = 8;
            this.btnEdit4.TextColor = System.Drawing.Color.White;
            this.btnEdit4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnDelete4.Location = new System.Drawing.Point(245, 351);
            this.btnDelete4.Name = "btnDelete4";
            this.btnDelete4.Size = new System.Drawing.Size(40, 25);
            this.btnDelete4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDelete4.TabIndex = 9;
            this.btnDelete4.TextColor = System.Drawing.Color.White;
            this.btnDelete4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDelete4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.movieCard4.Size = new System.Drawing.Size(300, 401);
            this.movieCard4.TabIndex = 3;
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
            // poster3
            // 
            this.poster3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.poster3.Location = new System.Drawing.Point(10, 10);
            this.poster3.Name = "poster3";
            this.poster3.Size = new System.Drawing.Size(280, 180);
            this.poster3.TabIndex = 1;
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
            // lblSubtitle3
            // 
            this.lblSubtitle3.AutoSize = true;
            this.lblSubtitle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblSubtitle3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle3.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle3.Location = new System.Drawing.Point(12, 292);
            this.lblSubtitle3.Name = "lblSubtitle3";
            this.lblSubtitle3.Padding = new System.Windows.Forms.Padding(4);
            this.lblSubtitle3.Size = new System.Drawing.Size(82, 23);
            this.lblSubtitle3.TabIndex = 5;
            this.lblSubtitle3.Text = "🎬 Tiếng Thái";
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
            this.btnView3.Location = new System.Drawing.Point(12, 351);
            this.btnView3.Name = "btnView3";
            this.btnView3.Size = new System.Drawing.Size(40, 25);
            this.btnView3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnView3.TabIndex = 7;
            this.btnView3.TextColor = System.Drawing.Color.White;
            this.btnView3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnView3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnEdit3.Location = new System.Drawing.Point(125, 351);
            this.btnEdit3.Name = "btnEdit3";
            this.btnEdit3.Size = new System.Drawing.Size(40, 25);
            this.btnEdit3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit3.TabIndex = 8;
            this.btnEdit3.TextColor = System.Drawing.Color.White;
            this.btnEdit3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnDelete3.Location = new System.Drawing.Point(245, 351);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(40, 25);
            this.btnDelete3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDelete3.TabIndex = 9;
            this.btnDelete3.TextColor = System.Drawing.Color.White;
            this.btnDelete3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDelete3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.movieCard3.Size = new System.Drawing.Size(300, 401);
            this.movieCard3.TabIndex = 2;
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
            // poster2
            // 
            this.poster2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.poster2.Location = new System.Drawing.Point(10, 10);
            this.poster2.Name = "poster2";
            this.poster2.Size = new System.Drawing.Size(280, 180);
            this.poster2.TabIndex = 1;
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
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblSubtitle2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle2.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle2.Location = new System.Drawing.Point(12, 292);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Padding = new System.Windows.Forms.Padding(4);
            this.lblSubtitle2.Size = new System.Drawing.Size(81, 23);
            this.lblSubtitle2.TabIndex = 5;
            this.lblSubtitle2.Text = "🎬 Tiếng Việt";
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
            this.btnView2.Location = new System.Drawing.Point(12, 351);
            this.btnView2.Name = "btnView2";
            this.btnView2.Size = new System.Drawing.Size(40, 25);
            this.btnView2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnView2.TabIndex = 7;
            this.btnView2.TextColor = System.Drawing.Color.White;
            this.btnView2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnView2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnEdit2.Location = new System.Drawing.Point(125, 351);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(40, 25);
            this.btnEdit2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit2.TabIndex = 8;
            this.btnEdit2.TextColor = System.Drawing.Color.White;
            this.btnEdit2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnDelete2.Location = new System.Drawing.Point(245, 351);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(40, 25);
            this.btnDelete2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnDelete2.TabIndex = 9;
            this.btnDelete2.TextColor = System.Drawing.Color.White;
            this.btnDelete2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDelete2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.movieCard2.Size = new System.Drawing.Size(300, 401);
            this.movieCard2.TabIndex = 1;
            // 
            // RoomManagementUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moviesContainer);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.panelHeader);
            this.Name = "RoomManagementUC";
            this.Size = new System.Drawing.Size(1337, 792);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.moviesContainer.ResumeLayout(false);
            this.movieCard1.ResumeLayout(false);
            this.movieCard1.PerformLayout();
            this.movieCard4.ResumeLayout(false);
            this.movieCard4.PerformLayout();
            this.movieCard3.ResumeLayout(false);
            this.movieCard3.PerformLayout();
            this.movieCard2.ResumeLayout(false);
            this.movieCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private ReaLTaiizor.Controls.ParrotButton btnAddRoom;
        private ReaLTaiizor.Controls.HopeComboBox cmbBranch;
        private System.Windows.Forms.FlowLayoutPanel moviesContainer;
        private ReaLTaiizor.Controls.MaterialCard movieCard1;
        private ReaLTaiizor.Controls.ParrotButton btnDelete1;
        private ReaLTaiizor.Controls.ParrotButton btnEdit1;
        private ReaLTaiizor.Controls.ParrotButton btnView1;
        private System.Windows.Forms.Label lblDates1;
        private System.Windows.Forms.Label lblSubtitle1;
        private System.Windows.Forms.Label lblLanguage1;
        private System.Windows.Forms.Label lblDuration1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Panel poster1;
        private System.Windows.Forms.Label badge1;
        private ReaLTaiizor.Controls.MaterialCard movieCard2;
        private ReaLTaiizor.Controls.ParrotButton btnDelete2;
        private ReaLTaiizor.Controls.ParrotButton btnEdit2;
        private ReaLTaiizor.Controls.ParrotButton btnView2;
        private System.Windows.Forms.Label lblDates2;
        private System.Windows.Forms.Label lblSubtitle2;
        private System.Windows.Forms.Label lblLanguage2;
        private System.Windows.Forms.Label lblDuration2;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Panel poster2;
        private System.Windows.Forms.Label badge2;
        private ReaLTaiizor.Controls.MaterialCard movieCard3;
        private ReaLTaiizor.Controls.ParrotButton btnDelete3;
        private ReaLTaiizor.Controls.ParrotButton btnEdit3;
        private ReaLTaiizor.Controls.ParrotButton btnView3;
        private System.Windows.Forms.Label lblDates3;
        private System.Windows.Forms.Label lblSubtitle3;
        private System.Windows.Forms.Label lblLanguage3;
        private System.Windows.Forms.Label lblDuration3;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Panel poster3;
        private System.Windows.Forms.Label badge3;
        private ReaLTaiizor.Controls.MaterialCard movieCard4;
        private ReaLTaiizor.Controls.ParrotButton btnDelete4;
        private ReaLTaiizor.Controls.ParrotButton btnEdit4;
        private ReaLTaiizor.Controls.ParrotButton btnView4;
        private System.Windows.Forms.Label lblDates4;
        private System.Windows.Forms.Label lblSubtitle4;
        private System.Windows.Forms.Label lblLanguage4;
        private System.Windows.Forms.Label lblDuration4;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.Panel poster4;
        private System.Windows.Forms.Label badge4;
    }
}
