namespace UI
{
    partial class PassChange
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
            this.pnForgot = new UI.Controls.RoundedPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPasswordRule = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOTP = new ReaLTaiizor.Controls.ForeverTextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtReenterPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btnOk = new ReaLTaiizor.Controls.SkyButton();
            this.roundedPanel2 = new UI.Controls.RoundedPanel();
            this.pnForgot.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForgot
            // 
            this.pnForgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.pnForgot.BorderColor = System.Drawing.Color.LightGray;
            this.pnForgot.BorderRadius = 20;
            this.pnForgot.BorderThickness = 3F;
            this.pnForgot.Controls.Add(this.groupBox1);
            this.pnForgot.Controls.Add(this.roundedPanel2);
            this.pnForgot.Location = new System.Drawing.Point(102, 90);
            this.pnForgot.Name = "pnForgot";
            this.pnForgot.Size = new System.Drawing.Size(909, 428);
            this.pnForgot.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPasswordRule);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOTP);
            this.groupBox1.Controls.Add(this.lbUsername);
            this.groupBox1.Controls.Add(this.txtReenterPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(386, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 384);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHANGE YOUR PASSWORD";
            // 
            // lblPasswordRule
            // 
            this.lblPasswordRule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRule.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordRule.Location = new System.Drawing.Point(47, 84);
            this.lblPasswordRule.Name = "lblPasswordRule";
            this.lblPasswordRule.Size = new System.Drawing.Size(392, 31);
            this.lblPasswordRule.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã OTP";
            // 
            // txtOTP
            // 
            this.txtOTP.BackColor = System.Drawing.Color.Transparent;
            this.txtOTP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtOTP.FocusOnHover = false;
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.ForeColor = System.Drawing.Color.GreenYellow;
            this.txtOTP.Location = new System.Drawing.Point(133, 279);
            this.txtOTP.MaxLength = 32767;
            this.txtOTP.Multiline = false;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.ReadOnly = false;
            this.txtOTP.Size = new System.Drawing.Size(163, 45);
            this.txtOTP.TabIndex = 25;
            this.txtOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTP.UseSystemPasswordChar = false;
            this.txtOTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOTP_KeyPress);
            this.txtOTP.TextChanged += new System.EventHandler(this.txtOTP_TextChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.ForeColor = System.Drawing.Color.Red;
            this.lbUsername.Location = new System.Drawing.Point(153, 54);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(65, 28);
            this.lbUsername.TabIndex = 9;
            this.lbUsername.Text = "label1";
            this.lbUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // txtReenterPassword
            // 
            this.txtReenterPassword.AnimateReadOnly = false;
            this.txtReenterPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtReenterPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtReenterPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtReenterPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReenterPassword.Depth = 0;
            this.txtReenterPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReenterPassword.HideSelection = true;
            this.txtReenterPassword.Hint = "Re-enter the password";
            this.txtReenterPassword.LeadingIcon = null;
            this.txtReenterPassword.Location = new System.Drawing.Point(48, 198);
            this.txtReenterPassword.MaxLength = 32767;
            this.txtReenterPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtReenterPassword.Name = "txtReenterPassword";
            this.txtReenterPassword.PasswordChar = '●';
            this.txtReenterPassword.PrefixSuffixText = null;
            this.txtReenterPassword.ReadOnly = false;
            this.txtReenterPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReenterPassword.SelectedText = "";
            this.txtReenterPassword.SelectionLength = 0;
            this.txtReenterPassword.SelectionStart = 0;
            this.txtReenterPassword.ShortcutsEnabled = true;
            this.txtReenterPassword.Size = new System.Drawing.Size(391, 48);
            this.txtReenterPassword.TabIndex = 8;
            this.txtReenterPassword.TabStop = false;
            this.txtReenterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReenterPassword.TrailingIcon = null;
            this.txtReenterPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HideSelection = true;
            this.txtPassword.Hint = "Password new";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(49, 120);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(390, 48);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
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
            this.btnOk.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.HoverBGColorA = System.Drawing.Color.WhiteSmoke;
            this.btnOk.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOk.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.HoverForeColor = System.Drawing.Color.Black;
            this.btnOk.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.Location = new System.Drawing.Point(302, 279);
            this.btnOk.Name = "btnOk";
            this.btnOk.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.NormalForeColor = System.Drawing.Color.White;
            this.btnOk.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.Size = new System.Drawing.Size(137, 38);
            this.btnOk.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.skyOk_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackgroundImage = global::UI.Properties.Resources.bg1;
            this.roundedPanel2.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanel2.BorderRadius = 16;
            this.roundedPanel2.BorderThickness = 3F;
            this.roundedPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.roundedPanel2.Location = new System.Drawing.Point(27, 24);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(338, 384);
            this.roundedPanel2.TabIndex = 1;
            // 
            // PassChange
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::UI.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 613);
            this.Controls.Add(this.pnForgot);
            this.MaximizeBox = false;
            this.Name = "PassChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change password";
            this.pnForgot.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedPanel pnForgot;
        private ReaLTaiizor.Controls.SkyButton btnOk;
        private Controls.RoundedPanel roundedPanel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtReenterPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbUsername;
        private ReaLTaiizor.Controls.ForeverTextBox txtOTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPasswordRule;
    }
}