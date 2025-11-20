namespace UI.PayOSMethod
{
    partial class PaymentSuccessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentSuccessForm));
            this.lb_successTitle = new System.Windows.Forms.Label();
            this.parrotButton_print = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_home = new ReaLTaiizor.Controls.ParrotButton();
            this.SuspendLayout();
            // 
            // lb_successTitle
            // 
            this.lb_successTitle.AutoSize = true;
            this.lb_successTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_successTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_successTitle.Location = new System.Drawing.Point(206, 90);
            this.lb_successTitle.Name = "lb_successTitle";
            this.lb_successTitle.Size = new System.Drawing.Size(390, 46);
            this.lb_successTitle.TabIndex = 0;
            this.lb_successTitle.Text = "Thanh toán thành công";
            // 
            // parrotButton_print
            // 
            this.parrotButton_print.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.parrotButton_print.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_print.ButtonImage")));
            this.parrotButton_print.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_print.ButtonText = "In hóa đơn";
            this.parrotButton_print.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.parrotButton_print.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton_print.CornerRadius = 5;
            this.parrotButton_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_print.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_print.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_print.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.parrotButton_print.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton_print.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_print.Location = new System.Drawing.Point(174, 193);
            this.parrotButton_print.Name = "parrotButton_print";
            this.parrotButton_print.Size = new System.Drawing.Size(200, 50);
            this.parrotButton_print.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_print.TabIndex = 1;
            this.parrotButton_print.TextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton_print.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_print.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotButton_home
            // 
            this.parrotButton_home.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.parrotButton_home.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_home.ButtonImage")));
            this.parrotButton_home.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_home.ButtonText = "Home";
            this.parrotButton_home.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.parrotButton_home.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton_home.CornerRadius = 5;
            this.parrotButton_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_home.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_home.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.parrotButton_home.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton_home.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_home.Location = new System.Drawing.Point(465, 193);
            this.parrotButton_home.Name = "parrotButton_home";
            this.parrotButton_home.Size = new System.Drawing.Size(200, 50);
            this.parrotButton_home.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_home.TabIndex = 1;
            this.parrotButton_home.TextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton_home.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_home.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_home.Click += new System.EventHandler(this.parrotButton_home_Click);
            // 
            // PaymentSuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.parrotButton_home);
            this.Controls.Add(this.parrotButton_print);
            this.Controls.Add(this.lb_successTitle);
            this.Name = "PaymentSuccessForm";
            this.Text = "PaymentSuccessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_successTitle;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_print;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_home;
    }
}