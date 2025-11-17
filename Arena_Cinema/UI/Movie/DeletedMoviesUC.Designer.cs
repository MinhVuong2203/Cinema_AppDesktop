namespace UI.Movie
{
    partial class DeletedMoviesUC
    {
        private System.ComponentModel.IContainer components = null;

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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new ReaLTaiizor.Controls.ParrotButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel_movie = new System.Windows.Forms.Panel();
            this.moviesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.right_Panel = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel_movie.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.right_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.panelHeader.Controls.Add(this.right_Panel);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1360, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.btnBack.ButtonImage = null;
            this.btnBack.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnBack.ButtonText = "← Quay lại";
            this.btnBack.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btnBack.ClickTextColor = System.Drawing.Color.White;
            this.btnBack.CornerRadius = 5;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.HoverTextColor = System.Drawing.Color.White;
            this.btnBack.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnBack.Location = new System.Drawing.Point(45, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 36);
            this.btnBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnBack.TabIndex = 1;
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🗑️ Phim Đã Xóa";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.panel_movie);
            this.panelMain.Controls.Add(this.infoPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(25);
            this.panelMain.Size = new System.Drawing.Size(1360, 740);
            this.panelMain.TabIndex = 1;
            // 
            // panel_movie
            // 
            this.panel_movie.AutoScroll = true;
            this.panel_movie.Controls.Add(this.moviesContainer);
            this.panel_movie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_movie.Location = new System.Drawing.Point(25, 85);
            this.panel_movie.Name = "panel_movie";
            this.panel_movie.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel_movie.Size = new System.Drawing.Size(1310, 630);
            this.panel_movie.TabIndex = 1;
            // 
            // moviesContainer
            // 
            this.moviesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.moviesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesContainer.Location = new System.Drawing.Point(0, 10);
            this.moviesContainer.Name = "moviesContainer";
            this.moviesContainer.Size = new System.Drawing.Size(1310, 610);
            this.moviesContainer.TabIndex = 0;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.White;
            this.infoPanel.Controls.Add(this.lblInfo);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(25, 25);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(10);
            this.infoPanel.Size = new System.Drawing.Size(1310, 60);
            this.infoPanel.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblInfo.Location = new System.Drawing.Point(10, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(1290, 40);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "🗑️ Tổng số phim đã xóa: 0";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // right_Panel
            // 
            this.right_Panel.Controls.Add(this.btnBack);
            this.right_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_Panel.Location = new System.Drawing.Point(1160, 0);
            this.right_Panel.Name = "right_Panel";
            this.right_Panel.Size = new System.Drawing.Size(200, 60);
            this.right_Panel.TabIndex = 2;
            // 
            // DeletedMoviesUC
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "DeletedMoviesUC";
            this.Size = new System.Drawing.Size(1360, 800);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panel_movie.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.right_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private ReaLTaiizor.Controls.ParrotButton btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel_movie;
        private System.Windows.Forms.FlowLayoutPanel moviesContainer;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel right_Panel;
    }
}