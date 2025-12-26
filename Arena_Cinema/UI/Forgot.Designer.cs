namespace UI
{
    partial class Forgot
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
            this.txtCCCD = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.skyButton2 = new ReaLTaiizor.Controls.SkyButton();
            this.skyButton3 = new ReaLTaiizor.Controls.SkyButton();
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
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.skyButton2);
            this.groupBox1.Controls.Add(this.skyButton3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(386, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 384);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FORGOT PASSWORD";
            // 
            // txtCCCD
            // 
            this.txtCCCD.AnimateReadOnly = false;
            this.txtCCCD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCCCD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCCCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCCCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCCCD.Depth = 0;
            this.txtCCCD.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCCCD.HideSelection = true;
            this.txtCCCD.Hint = "CCCD";
            this.txtCCCD.LeadingIcon = null;
            this.txtCCCD.Location = new System.Drawing.Point(50, 173);
            this.txtCCCD.MaxLength = 32767;
            this.txtCCCD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PasswordChar = '\0';
            this.txtCCCD.PrefixSuffixText = null;
            this.txtCCCD.ReadOnly = false;
            this.txtCCCD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.SelectionLength = 0;
            this.txtCCCD.SelectionStart = 0;
            this.txtCCCD.ShortcutsEnabled = true;
            this.txtCCCD.Size = new System.Drawing.Size(391, 48);
            this.txtCCCD.TabIndex = 8;
            this.txtCCCD.TabStop = false;
            this.txtCCCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCCCD.TrailingIcon = null;
            this.txtCCCD.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HideSelection = true;
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(51, 86);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(390, 48);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // skyButton2
            // 
            this.skyButton2.BackColor = System.Drawing.Color.Transparent;
            this.skyButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skyButton2.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton2.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton2.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton2.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton2.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton2.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton2.DownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skyButton2.DownShadowForeColor = System.Drawing.Color.White;
            this.skyButton2.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold);
            this.skyButton2.ForeColor = System.Drawing.Color.White;
            this.skyButton2.HoverBGColorA = System.Drawing.Color.WhiteSmoke;
            this.skyButton2.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.skyButton2.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton2.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton2.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton2.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton2.HoverForeColor = System.Drawing.Color.Black;
            this.skyButton2.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.skyButton2.Location = new System.Drawing.Point(62, 284);
            this.skyButton2.Name = "skyButton2";
            this.skyButton2.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton2.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton2.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton2.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton2.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton2.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton2.NormalForeColor = System.Drawing.Color.White;
            this.skyButton2.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skyButton2.Size = new System.Drawing.Size(175, 44);
            this.skyButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.skyButton2.TabIndex = 2;
            this.skyButton2.Text = "Send";
            this.skyButton2.Click += new System.EventHandler(this.skyButton2_Click);
            // 
            // skyButton3
            // 
            this.skyButton3.BackColor = System.Drawing.Color.Transparent;
            this.skyButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skyButton3.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton3.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton3.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton3.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton3.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton3.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton3.DownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skyButton3.DownShadowForeColor = System.Drawing.Color.White;
            this.skyButton3.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold);
            this.skyButton3.ForeColor = System.Drawing.Color.Black;
            this.skyButton3.HoverBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton3.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton3.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton3.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton3.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.skyButton3.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.skyButton3.HoverForeColor = System.Drawing.Color.White;
            this.skyButton3.HoverShadowForeColor = System.Drawing.Color.DimGray;
            this.skyButton3.Location = new System.Drawing.Point(258, 284);
            this.skyButton3.Name = "skyButton3";
            this.skyButton3.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.skyButton3.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.skyButton3.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.skyButton3.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.skyButton3.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton3.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.skyButton3.NormalForeColor = System.Drawing.Color.Black;
            this.skyButton3.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skyButton3.Size = new System.Drawing.Size(175, 44);
            this.skyButton3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.skyButton3.TabIndex = 3;
            this.skyButton3.Text = "Back";
            this.skyButton3.Click += new System.EventHandler(this.skyButton3_Click);
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
            // Forgot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::UI.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 613);
            this.Controls.Add(this.pnForgot);
            this.MaximizeBox = false;
            this.Name = "Forgot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot";
            this.pnForgot.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedPanel pnForgot;
        private ReaLTaiizor.Controls.SkyButton skyButton2;
        private ReaLTaiizor.Controls.SkyButton skyButton3;
        private Controls.RoundedPanel roundedPanel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCCCD;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}