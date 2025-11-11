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
            this.PanelTop = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.btnMenu = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPhim = new ReaLTaiizor.Controls.ParrotButton();
            this.btnSuatChieu = new ReaLTaiizor.Controls.ParrotButton();
            this.btnTrangChu = new ReaLTaiizor.Controls.ParrotButton();
            this.btnNhanSu = new ReaLTaiizor.Controls.ParrotButton();
            this.PanelMain = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.pnMenuBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCaiDat = new ReaLTaiizor.Controls.ParrotButton();
            this.btnCaNhan = new ReaLTaiizor.Controls.ParrotButton();
            this.pnMenuTop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPhong = new ReaLTaiizor.Controls.ParrotButton();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.PanelTop.SuspendLayout();
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
            this.PanelTop.Controls.Add(this.btnMenu);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.PanelTop.PrimerColor = System.Drawing.Color.White;
            this.PanelTop.Size = new System.Drawing.Size(1315, 70);
            this.PanelTop.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.PanelTop.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.PanelTop.TabIndex = 0;
            this.PanelTop.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PanelTop.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.PanelTop.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnMenu.ButtonImage = global::UI.Properties.Resources.Menu;
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
            // btnPhim
            // 
            this.btnPhim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnPhim.ButtonImage = global::UI.Properties.Resources.Home;
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
            this.btnPhim.Location = new System.Drawing.Point(3, 239);
            this.btnPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Size = new System.Drawing.Size(282, 75);
            this.btnPhim.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPhim.TabIndex = 13;
            this.btnPhim.TextColor = System.Drawing.Color.White;
            this.btnPhim.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPhim.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnSuatChieu
            // 
            this.btnSuatChieu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnSuatChieu.ButtonImage = global::UI.Properties.Resources.Home;
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
            this.btnSuatChieu.Location = new System.Drawing.Point(3, 160);
            this.btnSuatChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuatChieu.Name = "btnSuatChieu";
            this.btnSuatChieu.Size = new System.Drawing.Size(282, 75);
            this.btnSuatChieu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSuatChieu.TabIndex = 12;
            this.btnSuatChieu.TextColor = System.Drawing.Color.White;
            this.btnSuatChieu.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSuatChieu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnTrangChu.ButtonImage = global::UI.Properties.Resources.Home;
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
            this.btnTrangChu.Size = new System.Drawing.Size(282, 75);
            this.btnTrangChu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnTrangChu.TabIndex = 11;
            this.btnTrangChu.TextColor = System.Drawing.Color.White;
            this.btnTrangChu.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnTrangChu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnNhanSu
            // 
            this.btnNhanSu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnNhanSu.ButtonImage = global::UI.Properties.Resources.Home;
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
            this.btnNhanSu.Location = new System.Drawing.Point(3, 81);
            this.btnNhanSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanSu.Name = "btnNhanSu";
            this.btnNhanSu.Size = new System.Drawing.Size(282, 75);
            this.btnNhanSu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnNhanSu.TabIndex = 10;
            this.btnNhanSu.TextColor = System.Drawing.Color.White;
            this.btnNhanSu.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnNhanSu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.PanelMain.Size = new System.Drawing.Size(1015, 847);
            this.PanelMain.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.PanelMain.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.PanelMain.TabIndex = 2;
            this.PanelMain.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PanelMain.TopLeft = System.Drawing.Color.Transparent;
            this.PanelMain.TopRight = System.Drawing.Color.Transparent;
            this.PanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMain_Paint);
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
            this.btnCaiDat.ButtonImage = global::UI.Properties.Resources.Home;
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
            this.btnCaiDat.Size = new System.Drawing.Size(282, 75);
            this.btnCaiDat.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCaiDat.TabIndex = 11;
            this.btnCaiDat.TextColor = System.Drawing.Color.White;
            this.btnCaiDat.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCaiDat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCaiDat.Click += new System.EventHandler(this.parrotButton2_Click);
            // 
            // btnCaNhan
            // 
            this.btnCaNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnCaNhan.ButtonImage = global::UI.Properties.Resources.Home;
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
            this.btnCaNhan.Location = new System.Drawing.Point(3, 81);
            this.btnCaNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCaNhan.Name = "btnCaNhan";
            this.btnCaNhan.Size = new System.Drawing.Size(282, 75);
            this.btnCaNhan.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCaNhan.TabIndex = 10;
            this.btnCaNhan.TextColor = System.Drawing.Color.White;
            this.btnCaNhan.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCaNhan.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // pnMenuTop
            // 
            this.pnMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.pnMenuTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMenuTop.Controls.Add(this.btnTrangChu);
            this.pnMenuTop.Controls.Add(this.btnNhanSu);
            this.pnMenuTop.Controls.Add(this.btnSuatChieu);
            this.pnMenuTop.Controls.Add(this.btnPhim);
            this.pnMenuTop.Controls.Add(this.btnPhong);
            this.pnMenuTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenuTop.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnMenuTop.Location = new System.Drawing.Point(0, 0);
            this.pnMenuTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenuTop.Name = "pnMenuTop";
            this.pnMenuTop.Size = new System.Drawing.Size(300, 674);
            this.pnMenuTop.TabIndex = 0;
            // 
            // btnPhong
            // 
            this.btnPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnPhong.ButtonImage = global::UI.Properties.Resources.Home;
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
            this.btnPhong.Location = new System.Drawing.Point(3, 318);
            this.btnPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(282, 75);
            this.btnPhong.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPhong.TabIndex = 14;
            this.btnPhong.TextColor = System.Drawing.Color.White;
            this.btnPhong.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPhong.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.ClientSize = new System.Drawing.Size(1315, 917);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.PanelTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.PanelTop.ResumeLayout(false);
            this.pnMenuBottom.ResumeLayout(false);
            this.pnMenuTop.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Panel pnMenu;
        private FlowLayoutPanel pnMenuBottom;
        private ReaLTaiizor.Controls.ParrotButton btnCaiDat;
        private ReaLTaiizor.Controls.ParrotButton btnCaNhan;
    }
}