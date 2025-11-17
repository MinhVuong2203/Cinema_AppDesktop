namespace UI.SeatManagement
{
    partial class SeatManagementUC
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new ReaLTaiizor.Controls.ParrotButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.picScreen = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1692, 90);
            this.panelHeader.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnBack.ButtonImage = null;
            this.btnBack.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnBack.ButtonText = "Quay lại";
            this.btnBack.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnBack.ClickTextColor = System.Drawing.Color.White;
            this.btnBack.CornerRadius = 5;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnBack.HoverTextColor = System.Drawing.Color.White;
            this.btnBack.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnBack.Location = new System.Drawing.Point(1522, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 60);
            this.btnBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnBack.TabIndex = 3;
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quản lý ghế của:";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.pnlCanvas);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 90);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(1692, 855);
            this.panelMain.TabIndex = 6;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Controls.Add(this.pnlLegend);
            this.pnlCanvas.Controls.Add(this.picScreen);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(25, 25);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1642, 805);
            this.pnlCanvas.TabIndex = 0;
            // 
            // pnlLegend
            // 
            this.pnlLegend.BackColor = System.Drawing.Color.Black;
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLegend.Location = new System.Drawing.Point(0, 703);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(1640, 100);
            this.pnlLegend.TabIndex = 1;
            // 
            // picScreen
            // 
            this.picScreen.BackColor = System.Drawing.Color.Black;
            this.picScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.picScreen.Location = new System.Drawing.Point(0, 0);
            this.picScreen.Name = "picScreen";
            this.picScreen.Size = new System.Drawing.Size(1640, 100);
            this.picScreen.TabIndex = 0;
            // 
            // SeatManagementUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "SeatManagementUC";
            this.Size = new System.Drawing.Size(1692, 945);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.pnlCanvas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private ReaLTaiizor.Controls.ParrotButton btnBack;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Panel picScreen;
    }
}
