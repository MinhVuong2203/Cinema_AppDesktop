using System.Drawing;
using System.Windows.Forms;

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
            this.parrotButton3 = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton4 = new ReaLTaiizor.Controls.ParrotButton();
            this.btnTrangChu = new ReaLTaiizor.Controls.ParrotButton();
            this.btnNhanSu = new ReaLTaiizor.Controls.ParrotButton();
            this.PanelMain = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnMenuBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.parrotButton2 = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton5 = new ReaLTaiizor.Controls.ParrotButton();
            this.pnMenuTop = new System.Windows.Forms.FlowLayoutPanel();
            this.parrotButton1 = new ReaLTaiizor.Controls.ParrotButton();
            this.PanelTop.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnMenuBottom.SuspendLayout();
            this.pnMenuTop.SuspendLayout();
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
            this.PanelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.PanelTop.PrimerColor = System.Drawing.Color.White;
            this.PanelTop.Size = new System.Drawing.Size(986, 57);
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
            this.btnMenu.Location = new System.Drawing.Point(2, -1);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(52, 57);
            this.btnMenu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnMenu.TabIndex = 14;
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnMenu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // parrotButton3
            // 
            this.parrotButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.parrotButton3.ButtonImage = global::UI.Properties.Resources.Home;
            this.parrotButton3.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton3.ButtonText = "PHIM";
            this.parrotButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.parrotButton3.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.parrotButton3.CornerRadius = 5;
            this.parrotButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.parrotButton3.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.parrotButton3.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton3.Location = new System.Drawing.Point(2, 197);
            this.parrotButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parrotButton3.Name = "parrotButton3";
            this.parrotButton3.Size = new System.Drawing.Size(219, 61);
            this.parrotButton3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton3.TabIndex = 13;
            this.parrotButton3.TextColor = System.Drawing.Color.White;
            this.parrotButton3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotButton4
            // 
            this.parrotButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.parrotButton4.ButtonImage = global::UI.Properties.Resources.Home;
            this.parrotButton4.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton4.ButtonText = "SUẤT CHIẾU";
            this.parrotButton4.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.parrotButton4.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.parrotButton4.CornerRadius = 5;
            this.parrotButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton4.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton4.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.parrotButton4.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.parrotButton4.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton4.Location = new System.Drawing.Point(2, 132);
            this.parrotButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parrotButton4.Name = "parrotButton4";
            this.parrotButton4.Size = new System.Drawing.Size(219, 61);
            this.parrotButton4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton4.TabIndex = 12;
            this.parrotButton4.TextColor = System.Drawing.Color.White;
            this.parrotButton4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnTrangChu.ButtonImage = global::UI.Properties.Resources.Home;
            this.btnTrangChu.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.btnTrangChu.ButtonText = "TRANG CHỦ";
            this.btnTrangChu.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnTrangChu.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnTrangChu.CornerRadius = 5;
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTrangChu.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnTrangChu.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnTrangChu.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnTrangChu.Location = new System.Drawing.Point(2, 2);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(219, 61);
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
            this.btnNhanSu.ButtonText = "NHÂN SỰ";
            this.btnNhanSu.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnNhanSu.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnNhanSu.CornerRadius = 5;
            this.btnNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanSu.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanSu.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNhanSu.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnNhanSu.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnNhanSu.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnNhanSu.Location = new System.Drawing.Point(2, 67);
            this.btnNhanSu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhanSu.Name = "btnNhanSu";
            this.btnNhanSu.Size = new System.Drawing.Size(219, 61);
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
            this.PanelMain.Controls.Add(this.pnMenu);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.PanelMain.Location = new System.Drawing.Point(0, 57);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.PanelMain.PrimerColor = System.Drawing.Color.White;
            this.PanelMain.Size = new System.Drawing.Size(986, 688);
            this.PanelMain.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.PanelMain.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.PanelMain.TabIndex = 2;
            this.PanelMain.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PanelMain.TopLeft = System.Drawing.Color.Transparent;
            this.PanelMain.TopRight = System.Drawing.Color.Transparent;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.pnMenuBottom);
            this.pnMenu.Controls.Add(this.pnMenuTop);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(226, 688);
            this.pnMenu.TabIndex = 1;
            // 
            // pnMenuBottom
            // 
            this.pnMenuBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.pnMenuBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMenuBottom.Controls.Add(this.parrotButton2);
            this.pnMenuBottom.Controls.Add(this.parrotButton5);
            this.pnMenuBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnMenuBottom.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnMenuBottom.Location = new System.Drawing.Point(0, 551);
            this.pnMenuBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenuBottom.Name = "pnMenuBottom";
            this.pnMenuBottom.Size = new System.Drawing.Size(226, 137);
            this.pnMenuBottom.TabIndex = 2;
            // 
            // parrotButton2
            // 
            this.parrotButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.parrotButton2.ButtonImage = global::UI.Properties.Resources.Home;
            this.parrotButton2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton2.ButtonText = "CÀI ĐẶT";
            this.parrotButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.parrotButton2.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.parrotButton2.CornerRadius = 5;
            this.parrotButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.parrotButton2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.parrotButton2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton2.Location = new System.Drawing.Point(2, 2);
            this.parrotButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parrotButton2.Name = "parrotButton2";
            this.parrotButton2.Size = new System.Drawing.Size(219, 61);
            this.parrotButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton2.TabIndex = 11;
            this.parrotButton2.TextColor = System.Drawing.Color.White;
            this.parrotButton2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotButton5
            // 
            this.parrotButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.parrotButton5.ButtonImage = global::UI.Properties.Resources.Home;
            this.parrotButton5.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton5.ButtonText = "CÁ NHÂN";
            this.parrotButton5.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.parrotButton5.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.parrotButton5.CornerRadius = 5;
            this.parrotButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton5.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton5.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.parrotButton5.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.parrotButton5.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton5.Location = new System.Drawing.Point(2, 67);
            this.parrotButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parrotButton5.Name = "parrotButton5";
            this.parrotButton5.Size = new System.Drawing.Size(219, 61);
            this.parrotButton5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton5.TabIndex = 10;
            this.parrotButton5.TextColor = System.Drawing.Color.White;
            this.parrotButton5.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // pnMenuTop
            // 
            this.pnMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.pnMenuTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMenuTop.Controls.Add(this.btnTrangChu);
            this.pnMenuTop.Controls.Add(this.btnNhanSu);
            this.pnMenuTop.Controls.Add(this.parrotButton4);
            this.pnMenuTop.Controls.Add(this.parrotButton3);
            this.pnMenuTop.Controls.Add(this.parrotButton1);
            this.pnMenuTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenuTop.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnMenuTop.Location = new System.Drawing.Point(0, 0);
            this.pnMenuTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenuTop.Name = "pnMenuTop";
            this.pnMenuTop.Size = new System.Drawing.Size(226, 688);
            this.pnMenuTop.TabIndex = 0;
            // 
            // parrotButton1
            // 
            this.parrotButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.parrotButton1.ButtonImage = global::UI.Properties.Resources.Home;
            this.parrotButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            this.parrotButton1.ButtonText = "PHÒNG CHIẾU";
            this.parrotButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.parrotButton1.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.parrotButton1.CornerRadius = 5;
            this.parrotButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.parrotButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.parrotButton1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton1.Location = new System.Drawing.Point(2, 262);
            this.parrotButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parrotButton1.Name = "parrotButton1";
            this.parrotButton1.Size = new System.Drawing.Size(219, 61);
            this.parrotButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton1.TabIndex = 14;
            this.parrotButton1.TextColor = System.Drawing.Color.White;
            this.parrotButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 745);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.PanelTop.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenuBottom.ResumeLayout(false);
            this.pnMenuTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel PanelTop;
        private ReaLTaiizor.Controls.ParrotGradientPanel PanelMain;
        private ReaLTaiizor.Controls.ParrotButton parrotButton3;
        private ReaLTaiizor.Controls.ParrotButton parrotButton4;
        private ReaLTaiizor.Controls.ParrotButton btnTrangChu;
        private ReaLTaiizor.Controls.ParrotButton btnNhanSu;
        private ReaLTaiizor.Controls.ParrotButton btnMenu;
        private ReaLTaiizor.Controls.ParrotButton parrotButton1;
        private FlowLayoutPanel pnMenuTop;
        private Panel pnMenu;
        private FlowLayoutPanel pnMenuBottom;
        private ReaLTaiizor.Controls.ParrotButton parrotButton2;
        private ReaLTaiizor.Controls.ParrotButton parrotButton5;
    }
}