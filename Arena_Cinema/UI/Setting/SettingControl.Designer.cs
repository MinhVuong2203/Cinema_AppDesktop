namespace UI.Setting
{
    partial class SettingControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbLang = new ReaLTaiizor.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChonMau = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.btnOk = new ReaLTaiizor.Controls.SkyButton();
            this.cyberColorPicker1 = new ReaLTaiizor.Controls.CyberColorPicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngôn ngữ:";
            // 
            // cbLang
            // 
            this.cbLang.AutoResize = false;
            this.cbLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbLang.Depth = 0;
            this.cbLang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbLang.DropDownHeight = 174;
            this.cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLang.DropDownWidth = 121;
            this.cbLang.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbLang.FormattingEnabled = true;
            this.cbLang.IntegralHeight = false;
            this.cbLang.ItemHeight = 43;
            this.cbLang.Items.AddRange(new object[] {
            "Tiếng Việt",
            "Tiếng Anh"});
            this.cbLang.Location = new System.Drawing.Point(285, 85);
            this.cbLang.MaxDropDownItems = 4;
            this.cbLang.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(301, 49);
            this.cbLang.StartIndex = 0;
            this.cbLang.TabIndex = 2;
            this.cbLang.SelectedIndexChanged += new System.EventHandler(this.cbLang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kiểu chữ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(285, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 37);
            this.textBox1.TabIndex = 4;
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(547, 179);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(35, 30);
            this.btnFont.TabIndex = 5;
            this.btnFont.Text = "...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Màu sắc:";
            // 
            // btnChonMau
            // 
            this.btnChonMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonMau.Location = new System.Drawing.Point(95, 460);
            this.btnChonMau.Name = "btnChonMau";
            this.btnChonMau.Size = new System.Drawing.Size(171, 30);
            this.btnChonMau.TabIndex = 7;
            this.btnChonMau.Text = "Chọn màu";
            this.btnChonMau.UseVisualStyleBackColor = true;
            this.btnChonMau.Click += new System.EventHandler(this.btnChonMau_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.Location = new System.Drawing.Point(467, 278);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(97, 30);
            this.lblPreview.TabIndex = 8;
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
            this.btnOk.Location = new System.Drawing.Point(311, 503);
            this.btnOk.Name = "btnOk";
            this.btnOk.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnOk.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnOk.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnOk.NormalForeColor = System.Drawing.Color.White;
            this.btnOk.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.Size = new System.Drawing.Size(175, 44);
            this.btnOk.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cyberColorPicker1
            // 
            this.cyberColorPicker1.BackColor = System.Drawing.Color.Transparent;
            this.cyberColorPicker1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cyberColorPicker1.Location = new System.Drawing.Point(322, 262);
            this.cyberColorPicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cyberColorPicker1.Name = "cyberColorPicker1";
            this.cyberColorPicker1.SelectedColor = System.Drawing.Color.Empty;
            this.cyberColorPicker1.Size = new System.Drawing.Size(260, 206);
            this.cyberColorPicker1.TabIndex = 10;
            this.cyberColorPicker1.Tag = "Cyber";
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cyberColorPicker1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.btnChonMau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(916, 796);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.MaterialComboBox cbLang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChonMau;
        private System.Windows.Forms.Label lblPreview;
        private ReaLTaiizor.Controls.SkyButton btnOk;
        private ReaLTaiizor.Controls.CyberColorPicker cyberColorPicker1;
    }
}
