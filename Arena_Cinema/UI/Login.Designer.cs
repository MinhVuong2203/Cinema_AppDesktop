using UI.Controls;

namespace UI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public string lang = "en"; // ngôn ngữ
        public bool isShow = true; // để show nút ẩn mật khẩu


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel = new UI.Controls.RoundedPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowPass = new ReaLTaiizor.Controls.ParrotButton();
            this.btnForgotPassword = new ReaLTaiizor.Controls.MetroButton();
            this.btnLogin = new ReaLTaiizor.Controls.SkyButton();
            this.skyButton1 = new ReaLTaiizor.Controls.SkyButton();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new UI.Controls.RoundedPanel();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.panel.BorderColor = System.Drawing.Color.LightGray;
            this.panel.BorderRadius = 20;
            this.panel.BorderThickness = 3F;
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.panel1);
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowPass);
            this.groupBox1.Controls.Add(this.btnForgotPassword);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.skyButton1);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackgroundColor = System.Drawing.Color.White;
            this.btnShowPass.ButtonImage = global::UI.Properties.Resources.OpenEyes1;
            this.btnShowPass.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnShowPass.ButtonText = "";
            this.btnShowPass.ClickBackColor = System.Drawing.Color.White;
            this.btnShowPass.ClickTextColor = System.Drawing.Color.White;
            this.btnShowPass.CornerRadius = 5;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnShowPass, "btnShowPass");
            this.btnShowPass.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowPass.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnShowPass.HoverTextColor = System.Drawing.Color.White;
            this.btnShowPass.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnShowPass.TextColor = System.Drawing.Color.Black;
            this.btnShowPass.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnShowPass.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnForgotPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnForgotPassword.DisabledForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnForgotPassword, "btnForgotPassword");
            this.btnForgotPassword.HoverBorderColor = System.Drawing.Color.White;
            this.btnForgotPassword.HoverColor = System.Drawing.Color.White;
            this.btnForgotPassword.HoverTextColor = System.Drawing.Color.IndianRed;
            this.btnForgotPassword.IsDerivedStyle = true;
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.NormalBorderColor = System.Drawing.Color.White;
            this.btnForgotPassword.NormalColor = System.Drawing.Color.White;
            this.btnForgotPassword.NormalTextColor = System.Drawing.Color.Black;
            this.btnForgotPassword.PressBorderColor = System.Drawing.Color.White;
            this.btnForgotPassword.PressColor = System.Drawing.Color.White;
            this.btnForgotPassword.PressTextColor = System.Drawing.Color.Red;
            this.btnForgotPassword.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.btnForgotPassword.StyleManager = null;
            this.btnForgotPassword.ThemeAuthor = "Taiizor";
            this.btnForgotPassword.ThemeName = "MetroLight";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnLogin.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnLogin.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnLogin.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnLogin.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnLogin.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnLogin.DownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.DownShadowForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverBGColorA = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLogin.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnLogin.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnLogin.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnLogin.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnLogin.HoverForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnLogin.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnLogin.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnLogin.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnLogin.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnLogin.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnLogin.NormalForeColor = System.Drawing.Color.White;
            this.btnLogin.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // skyButton1
            // 
            this.skyButton1.BackColor = System.Drawing.Color.Transparent;
            this.skyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skyButton1.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.DownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skyButton1.DownShadowForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.skyButton1, "skyButton1");
            this.skyButton1.ForeColor = System.Drawing.Color.Black;
            this.skyButton1.HoverBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.skyButton1.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.skyButton1.HoverForeColor = System.Drawing.Color.White;
            this.skyButton1.HoverShadowForeColor = System.Drawing.Color.DimGray;
            this.skyButton1.Name = "skyButton1";
            this.skyButton1.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.skyButton1.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.skyButton1.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton1.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton1.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton1.NormalForeColor = System.Drawing.Color.Black;
            this.skyButton1.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skyButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.skyButton1.Click += new System.EventHandler(this.skyButton1_Click);
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbPassword.Name = "tbPassword";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbUsername
            // 
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbUsername.Name = "tbUsername";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UI.Properties.Resources.bg1;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderColor = System.Drawing.Color.LightGray;
            this.panel1.BorderRadius = 16;
            this.panel1.BorderThickness = 3F;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Name = "panel1";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::UI.Properties.Resources.bg2;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedPanel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ReaLTaiizor.Controls.SkyButton btnLogin;
        private ReaLTaiizor.Controls.SkyButton skyButton1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private RoundedPanel panel;
        private ReaLTaiizor.Controls.MetroButton btnForgotPassword;
        private ReaLTaiizor.Controls.ParrotButton btnShowPass;
        
    }
}