using System.Drawing;

namespace UI.Setting
{
    partial class SettingControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel mainPanel;

        private System.Windows.Forms.Label lblTitle;

        private UI.Controls.RoundedPanel cardLang;
        private UI.Controls.RoundedPanel cardAppearance;
        private UI.Controls.RoundedPanel cardAccount;

        private System.Windows.Forms.Label lblLang;
        private ReaLTaiizor.Controls.MaterialComboBox cbLang;

        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.TextBox textFont;
        private System.Windows.Forms.Button btnFont;

        private ReaLTaiizor.Controls.CyberColorPicker colorPicker;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPreview;

        private System.Windows.Forms.FontDialog fontDialog1;


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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cardLang = new UI.Controls.RoundedPanel();
            this.lblLang = new System.Windows.Forms.Label();
            this.cbLang = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cardAppearance = new UI.Controls.RoundedPanel();
            this.lblFont = new System.Windows.Forms.Label();
            this.textFont = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.colorPicker = new ReaLTaiizor.Controls.CyberColorPicker();
            this.lblPreview = new System.Windows.Forms.Label();
            this.cardAccount = new UI.Controls.RoundedPanel();
            this.skyButton1 = new ReaLTaiizor.Controls.SkyButton();
            this.btnOk = new ReaLTaiizor.Controls.SkyButton();
            this.mainPanel.SuspendLayout();
            this.cardLang.SuspendLayout();
            this.cardAppearance.SuspendLayout();
            this.cardAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Controls.Add(this.cardLang);
            this.mainPanel.Controls.Add(this.cardAppearance);
            this.mainPanel.Controls.Add(this.cardAccount);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(916, 860);
            this.mainPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(359, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cài đặt hệ thống";
            // 
            // cardLang
            // 
            this.cardLang.BackColor = System.Drawing.Color.White;
            this.cardLang.BorderColor = System.Drawing.Color.LightGray;
            this.cardLang.BorderRadius = 20;
            this.cardLang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardLang.BorderThickness = 2F;
            this.cardLang.Controls.Add(this.lblLang);
            this.cardLang.Controls.Add(this.cbLang);
            this.cardLang.Location = new System.Drawing.Point(100, 120);
            this.cardLang.Name = "cardLang";
            this.cardLang.Size = new System.Drawing.Size(720, 95);
            this.cardLang.TabIndex = 1;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblLang.Location = new System.Drawing.Point(30, 26);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(123, 32);
            this.lblLang.TabIndex = 0;
            this.lblLang.Text = "Ngôn ngữ";
            // 
            // cbLang
            // 
            this.cbLang.AutoResize = false;
            this.cbLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbLang.Depth = 0;
            this.cbLang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbLang.DropDownHeight = 174;
            this.cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLang.DropDownWidth = 121;
            this.cbLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbLang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbLang.IntegralHeight = false;
            this.cbLang.ItemHeight = 43;
            this.cbLang.Items.AddRange(new object[] {
            "Tiếng Việt",
            "Tiếng Anh"});
            this.cbLang.Location = new System.Drawing.Point(190, 18);
            this.cbLang.MaxDropDownItems = 4;
            this.cbLang.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(350, 49);
            this.cbLang.StartIndex = 0;
            this.cbLang.TabIndex = 1;
            this.cbLang.SelectedIndexChanged += new System.EventHandler(this.cbLang_SelectedIndexChanged);
            // 
            // cardAppearance
            // 
            this.cardAppearance.BackColor = System.Drawing.Color.White;
            this.cardAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cardAppearance.BorderRadius = 20;
            this.cardAppearance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardAppearance.BorderThickness = 2F;
            this.cardAppearance.Controls.Add(this.lblFont);
            this.cardAppearance.Controls.Add(this.textFont);
            this.cardAppearance.Controls.Add(this.btnFont);
            this.cardAppearance.Controls.Add(this.lblColor);
            this.cardAppearance.Controls.Add(this.colorPicker);
            this.cardAppearance.Controls.Add(this.lblPreview);
            this.cardAppearance.Location = new System.Drawing.Point(100, 231);
            this.cardAppearance.Name = "cardAppearance";
            this.cardAppearance.Size = new System.Drawing.Size(720, 336);
            this.cardAppearance.TabIndex = 2;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblFont.Location = new System.Drawing.Point(30, 30);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(107, 32);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Kiểu chữ";
            // 
            // textFont
            // 
            this.textFont.BackColor = System.Drawing.Color.Silver;
            this.textFont.Enabled = false;
            this.textFont.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textFont.Location = new System.Drawing.Point(150, 30);
            this.textFont.Name = "textFont";
            this.textFont.Size = new System.Drawing.Size(330, 34);
            this.textFont.TabIndex = 1;
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFont.Location = new System.Drawing.Point(500, 30);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(40, 34);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "...";
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblColor.Location = new System.Drawing.Point(30, 100);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(102, 32);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Màu sắc";
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Transparent;
            this.colorPicker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.colorPicker.Location = new System.Drawing.Point(168, 120);
            this.colorPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.SelectedColor = System.Drawing.Color.Empty;
            this.colorPicker.Size = new System.Drawing.Size(300, 196);
            this.colorPicker.TabIndex = 4;
            this.colorPicker.Tag = "Cyber";
            this.colorPicker.ColorChanged += new ReaLTaiizor.Controls.CyberColorPicker.EventHandler(this.colorPicker_ColorChanged);
            // 
            // lblPreview
            // 
            this.lblPreview.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPreview.Location = new System.Drawing.Point(494, 160);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(137, 69);
            this.lblPreview.TabIndex = 5;
            // 
            // cardAccount
            // 
            this.cardAccount.BackColor = System.Drawing.Color.White;
            this.cardAccount.BorderColor = System.Drawing.Color.LightGray;
            this.cardAccount.BorderRadius = 20;
            this.cardAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardAccount.BorderThickness = 2F;
            this.cardAccount.Controls.Add(this.skyButton1);
            this.cardAccount.Controls.Add(this.btnOk);
            this.cardAccount.Location = new System.Drawing.Point(100, 591);
            this.cardAccount.Name = "cardAccount";
            this.cardAccount.Size = new System.Drawing.Size(720, 101);
            this.cardAccount.TabIndex = 3;
            // 
            // skyButton1
            // 
            this.skyButton1.BackColor = System.Drawing.Color.Transparent;
            this.skyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skyButton1.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.DownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skyButton1.DownShadowForeColor = System.Drawing.Color.White;
            this.skyButton1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyButton1.ForeColor = System.Drawing.Color.White;
            this.skyButton1.HoverBGColorA = System.Drawing.Color.WhiteSmoke;
            this.skyButton1.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.skyButton1.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.HoverForeColor = System.Drawing.Color.Black;
            this.skyButton1.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.skyButton1.Location = new System.Drawing.Point(391, 21);
            this.skyButton1.Name = "skyButton1";
            this.skyButton1.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.NormalForeColor = System.Drawing.Color.White;
            this.skyButton1.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skyButton1.Size = new System.Drawing.Size(240, 53);
            this.skyButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.skyButton1.TabIndex = 4;
            this.skyButton1.Text = "Đăng xuất";
            this.skyButton1.Click += new System.EventHandler(this.skyButton1_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.DownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOk.DownShadowForeColor = System.Drawing.Color.White;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.HoverBGColorA = System.Drawing.Color.WhiteSmoke;
            this.btnOk.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOk.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.HoverForeColor = System.Drawing.Color.Black;
            this.btnOk.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.Location = new System.Drawing.Point(98, 21);
            this.btnOk.Name = "btnOk";
            this.btnOk.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.NormalForeColor = System.Drawing.Color.White;
            this.btnOk.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.Size = new System.Drawing.Size(240, 53);
            this.btnOk.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Lưu thay đổi";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // SettingControl
            // 
            this.Controls.Add(this.mainPanel);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(916, 860);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.cardLang.ResumeLayout(false);
            this.cardLang.PerformLayout();
            this.cardAppearance.ResumeLayout(false);
            this.cardAppearance.PerformLayout();
            this.cardAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private ReaLTaiizor.Controls.SkyButton skyButton1;
        private ReaLTaiizor.Controls.SkyButton btnOk;
    }
}
