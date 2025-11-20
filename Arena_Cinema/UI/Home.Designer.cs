using System;
using System.Drawing;
using System.Windows.Forms;
using UI.Resources;

namespace UI
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.PanelTop = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new ReaLTaiizor.Controls.ParrotButton();
            this.PanelMain = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.pnMenuBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCaiDat = new ReaLTaiizor.Controls.ParrotButton();
            this.btnCaNhan = new ReaLTaiizor.Controls.ParrotButton();
            this.pnMenuTop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTrangChu = new ReaLTaiizor.Controls.ParrotButton();
            this.btnBanVe = new ReaLTaiizor.Controls.ParrotButton();
            this.btnNhanSu = new ReaLTaiizor.Controls.ParrotButton();
            this.btnSuatChieu = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPhim = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPhong = new ReaLTaiizor.Controls.ParrotButton();
            this.btnSanPham = new ReaLTaiizor.Controls.ParrotButton();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.PanelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnMenuBottom.SuspendLayout();
            this.pnMenuTop.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.PanelTop.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PanelTop.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.PanelTop.Controls.Add(this.panel1);
            this.PanelTop.Controls.Add(this.btnMenu);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.PanelTop.PrimerColor = System.Drawing.Color.White;
            this.PanelTop.Size = new System.Drawing.Size(1612, 70);
            this.PanelTop.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.PanelTop.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.PanelTop.TabIndex = 0;
            this.PanelTop.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PanelTop.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.PanelTop.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1386, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 70);
            this.panel1.TabIndex = 19;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(68, 11);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(55, 21);
            this.lbTime.TabIndex = 17;
            this.lbTime.Text = "label1";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(69, 42);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(55, 21);
            this.lbDate.TabIndex = 18;
            this.lbDate.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::UI.Properties.Resources.imgClock;
            this.pictureBox1.Location = new System.Drawing.Point(11, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::UI.Properties.Resources.imgCalender;
            this.pictureBox2.Location = new System.Drawing.Point(21, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnMenu.ButtonImage = global::UI.Properties.Resources.list_symbol_of_three_items_with_dots;
            this.btnMenu.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnMenu.ButtonText = "";
            this.btnMenu.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnMenu.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnMenu.CornerRadius = 5;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMenu.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMenu.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnMenu.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnMenu.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnMenu.Location = new System.Drawing.Point(3, -1);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(69, 70);
            this.btnMenu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnMenu.TabIndex = 14;
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnMenu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PanelMain.BottomRight = System.Drawing.Color.White;
            this.PanelMain.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.PanelMain.Location = new System.Drawing.Point(300, 70);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.PanelMain.PrimerColor = System.Drawing.Color.White;
            this.PanelMain.Size = new System.Drawing.Size(1312, 847);
            this.PanelMain.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.PanelMain.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.PanelMain.TabIndex = 2;
            this.PanelMain.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PanelMain.TopLeft = System.Drawing.Color.Transparent;
            this.PanelMain.TopRight = System.Drawing.Color.Transparent;
            // 
            // pnMenuBottom
            // 
            this.pnMenuBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.pnMenuBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMenuBottom.Controls.Add(this.btnCaiDat);
            this.pnMenuBottom.Controls.Add(this.btnCaNhan);
            this.pnMenuBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnMenuBottom.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnMenuBottom.Location = new System.Drawing.Point(0, 674);
            this.pnMenuBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenuBottom.Name = "pnMenuBottom";
            this.pnMenuBottom.Size = new System.Drawing.Size(300, 173);
            this.pnMenuBottom.TabIndex = 2;
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnCaiDat.ButtonImage = global::UI.Properties.Resources.gear;
            this.btnCaiDat.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnCaiDat.ButtonText = global::UI.Resources.Lang.CAIDAT;
            this.btnCaiDat.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnCaiDat.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnCaiDat.CornerRadius = 5;
            this.btnCaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaiDat.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCaiDat.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnCaiDat.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnCaiDat.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnCaiDat.Location = new System.Drawing.Point(3, 2);
            this.btnCaiDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(282, 65);
            this.btnCaiDat.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCaiDat.TabIndex = 11;
            this.btnCaiDat.TextColor = System.Drawing.Color.White;
            this.btnCaiDat.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCaiDat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCaiDat.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnCaNhan
            // 
            this.btnCaNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnCaNhan.ButtonImage = global::UI.Properties.Resources.profile__1_;
            this.btnCaNhan.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnCaNhan.ButtonText = global::UI.Resources.Lang.CANHAN;
            this.btnCaNhan.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnCaNhan.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnCaNhan.CornerRadius = 5;
            this.btnCaNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaNhan.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaNhan.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCaNhan.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnCaNhan.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnCaNhan.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnCaNhan.Location = new System.Drawing.Point(3, 71);
            this.btnCaNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCaNhan.Name = "btnCaNhan";
            this.btnCaNhan.Size = new System.Drawing.Size(282, 65);
            this.btnCaNhan.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCaNhan.TabIndex = 10;
            this.btnCaNhan.TextColor = System.Drawing.Color.White;
            this.btnCaNhan.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCaNhan.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCaNhan.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // pnMenuTop
            // 
            this.pnMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.pnMenuTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMenuTop.Controls.Add(this.btnTrangChu);
            this.pnMenuTop.Controls.Add(this.btnBanVe);
            this.pnMenuTop.Controls.Add(this.btnNhanSu);
            this.pnMenuTop.Controls.Add(this.btnSuatChieu);
            this.pnMenuTop.Controls.Add(this.btnPhim);
            this.pnMenuTop.Controls.Add(this.btnPhong);
            this.pnMenuTop.Controls.Add(this.btnSanPham);
            this.pnMenuTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenuTop.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnMenuTop.Location = new System.Drawing.Point(0, 0);
            this.pnMenuTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenuTop.Name = "pnMenuTop";
            this.pnMenuTop.Size = new System.Drawing.Size(300, 674);
            this.pnMenuTop.TabIndex = 0;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnTrangChu.ButtonImage = global::UI.Properties.Resources.home__1_;
            this.btnTrangChu.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnTrangChu.ButtonText = global::UI.Resources.Lang.TRANGCHU;
            this.btnTrangChu.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnTrangChu.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnTrangChu.CornerRadius = 5;
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTrangChu.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnTrangChu.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnTrangChu.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnTrangChu.Location = new System.Drawing.Point(3, 2);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(282, 65);
            this.btnTrangChu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnTrangChu.TabIndex = 11;
            this.btnTrangChu.TextColor = System.Drawing.Color.White;
            this.btnTrangChu.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnTrangChu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTrangChu.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnBanVe
            // 
            this.btnBanVe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnBanVe.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnBanVe.ButtonImage")));
            this.btnBanVe.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnBanVe.ButtonText = global::UI.Resources.Lang.BanVe;
            this.btnBanVe.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnBanVe.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnBanVe.CornerRadius = 5;
            this.btnBanVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanVe.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanVe.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBanVe.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnBanVe.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnBanVe.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnBanVe.Location = new System.Drawing.Point(3, 71);
            this.btnBanVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.Size = new System.Drawing.Size(282, 65);
            this.btnBanVe.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnBanVe.TabIndex = 16;
            this.btnBanVe.TextColor = System.Drawing.Color.White;
            this.btnBanVe.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnBanVe.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBanVe.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnNhanSu
            // 
            this.btnNhanSu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnNhanSu.ButtonImage = global::UI.Properties.Resources.employee;
            this.btnNhanSu.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnNhanSu.ButtonText = global::UI.Resources.Lang.NHANSU;
            this.btnNhanSu.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnNhanSu.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnNhanSu.CornerRadius = 5;
            this.btnNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanSu.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanSu.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNhanSu.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnNhanSu.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnNhanSu.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnNhanSu.Location = new System.Drawing.Point(3, 140);
            this.btnNhanSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanSu.Name = "btnNhanSu";
            this.btnNhanSu.Size = new System.Drawing.Size(282, 65);
            this.btnNhanSu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnNhanSu.TabIndex = 10;
            this.btnNhanSu.TextColor = System.Drawing.Color.White;
            this.btnNhanSu.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnNhanSu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNhanSu.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnSuatChieu
            // 
            this.btnSuatChieu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnSuatChieu.ButtonImage = global::UI.Properties.Resources.showtime__1_;
            this.btnSuatChieu.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnSuatChieu.ButtonText = global::UI.Resources.Lang.SUATCHIEU;
            this.btnSuatChieu.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnSuatChieu.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnSuatChieu.CornerRadius = 5;
            this.btnSuatChieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuatChieu.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuatChieu.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSuatChieu.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnSuatChieu.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnSuatChieu.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnSuatChieu.Location = new System.Drawing.Point(3, 209);
            this.btnSuatChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuatChieu.Name = "btnSuatChieu";
            this.btnSuatChieu.Size = new System.Drawing.Size(282, 65);
            this.btnSuatChieu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSuatChieu.TabIndex = 12;
            this.btnSuatChieu.TextColor = System.Drawing.Color.White;
            this.btnSuatChieu.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSuatChieu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSuatChieu.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnPhim
            // 
            this.btnPhim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnPhim.ButtonImage = global::UI.Properties.Resources.clapperboard;
            this.btnPhim.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnPhim.ButtonText = global::UI.Resources.Lang.PHIM;
            this.btnPhim.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnPhim.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnPhim.CornerRadius = 5;
            this.btnPhim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhim.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhim.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPhim.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnPhim.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnPhim.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnPhim.Location = new System.Drawing.Point(3, 278);
            this.btnPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Size = new System.Drawing.Size(282, 65);
            this.btnPhim.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPhim.TabIndex = 13;
            this.btnPhim.TextColor = System.Drawing.Color.White;
            this.btnPhim.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPhim.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPhim.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnPhong.ButtonImage = global::UI.Properties.Resources.cinema;
            this.btnPhong.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnPhong.ButtonText = global::UI.Resources.Lang.PHONGCHIEU;
            this.btnPhong.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnPhong.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnPhong.CornerRadius = 5;
            this.btnPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhong.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPhong.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnPhong.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnPhong.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnPhong.Location = new System.Drawing.Point(3, 347);
            this.btnPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(282, 65);
            this.btnPhong.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPhong.TabIndex = 14;
            this.btnPhong.TextColor = System.Drawing.Color.White;
            this.btnPhong.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPhong.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPhong.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnSanPham.ButtonImage = global::UI.Properties.Resources.popcorn;
            this.btnSanPham.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnSanPham.ButtonText = global::UI.Resources.Lang.SANPHAM;
            this.btnSanPham.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnSanPham.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnSanPham.CornerRadius = 5;
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSanPham.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnSanPham.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnSanPham.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnSanPham.Location = new System.Drawing.Point(3, 416);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(10);
            this.btnSanPham.Size = new System.Drawing.Size(282, 65);
            this.btnSanPham.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSanPham.TabIndex = 18;
            this.btnSanPham.TextColor = System.Drawing.Color.White;
            this.btnSanPham.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSanPham.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSanPham.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.IndianRed;
            this.pnMenu.Controls.Add(this.pnMenuTop);
            this.pnMenu.Controls.Add(this.pnMenuBottom);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 70);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(300, 847);
            this.pnMenu.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 917);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.PanelTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.PanelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnMenuBottom.ResumeLayout(false);
            this.pnMenuTop.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void StartClock()
        {
            // Khởi tạo Timer
            timerClock = new System.Windows.Forms.Timer();
            timerClock.Interval = 1000; // cập nhật mỗi 1 giây
            // Gán sự kiện Tick
            timerClock.Tick += (s, e) =>
            {
                this.lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
                this.lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            };
            timerClock.Start(); // Bắt đầu chạy
        }
        public void LoadControl(UserControl uc)
        {
            this.PanelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            this.PanelMain.Controls.Add(uc);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel PanelTop;
        private ReaLTaiizor.Controls.ParrotGradientPanel PanelMain;
        private ReaLTaiizor.Controls.ParrotButton btnPhim;
        private ReaLTaiizor.Controls.ParrotButton btnSuatChieu;
        private ReaLTaiizor.Controls.ParrotButton btnTrangChu;
        private ReaLTaiizor.Controls.ParrotButton btnNhanSu;
        private ReaLTaiizor.Controls.ParrotButton btnMenu;
        private ReaLTaiizor.Controls.ParrotButton btnPhong;
        private FlowLayoutPanel pnMenuTop;
        public Panel pnMenu;
        private FlowLayoutPanel pnMenuBottom;
        private ReaLTaiizor.Controls.ParrotButton btnCaiDat;
        private ReaLTaiizor.Controls.ParrotButton btnCaNhan;
        private ReaLTaiizor.Controls.ParrotButton btnBanVe;
        private ReaLTaiizor.Controls.ParrotButton btnSanPham;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbDate;
        private Label lbTime;
        private System.Windows.Forms.Timer timerClock;
        private Panel panel1;
    }
}