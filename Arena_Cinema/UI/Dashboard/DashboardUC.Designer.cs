namespace UI.Dashboard
{
    partial class DashboardUC
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.flowPanelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoData = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.pnlMainRevenue = new System.Windows.Forms.Panel();
            this.lblGrowth = new System.Windows.Forms.Label();
            this.lblGrowthIcon = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblMonthYear = new System.Windows.Forms.Label();
            this.pnlAdditionalStats = new System.Windows.Forms.Panel();
            this.lblYearRevenue = new System.Windows.Forms.Label();
            this.lblAvgInvoice = new System.Windows.Forms.Label();
            this.lblTodayRevenue = new System.Windows.Forms.Label();
            this.lblInvoiceCount = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            this.pnlMainRevenue.SuspendLayout();
            this.pnlAdditionalStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LightGray;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(10);
            this.pnlHeader.Size = new System.Drawing.Size(1360, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1340, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = global::UI.Resources.Lang.phimsapchieu;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1290, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(1210, 15);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(70, 30);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "◀ Trước";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // flowPanelMovies
            // 
            this.flowPanelMovies.BackColor = System.Drawing.Color.White;
            this.flowPanelMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelMovies.Location = new System.Drawing.Point(0, 210);
            this.flowPanelMovies.Name = "flowPanelMovies";
            this.flowPanelMovies.Padding = new System.Windows.Forms.Padding(40, 30, 40, 30);
            this.flowPanelMovies.Size = new System.Drawing.Size(1360, 510);
            this.flowPanelMovies.TabIndex = 1;
            this.flowPanelMovies.WrapContents = false;
            // 
            // lblNoData
            // 
            this.lblNoData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoData.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblNoData.ForeColor = System.Drawing.Color.Gray;
            this.lblNoData.Location = new System.Drawing.Point(0, 210);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(1360, 510);
            this.lblNoData.TabIndex = 2;
            this.lblNoData.Text = "Không có phim sắp chiếu";
            this.lblNoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoData.Visible = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnNext);
            this.pnlFooter.Controls.Add(this.btnPrev);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 720);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFooter.Size = new System.Drawing.Size(1360, 60);
            this.pnlFooter.TabIndex = 3;
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.BackColor = System.Drawing.Color.White;
            this.pnlStatistics.Controls.Add(this.pnlMainRevenue);
            this.pnlStatistics.Controls.Add(this.pnlAdditionalStats);
            this.pnlStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatistics.Location = new System.Drawing.Point(0, 50);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Padding = new System.Windows.Forms.Padding(20);
            this.pnlStatistics.Size = new System.Drawing.Size(1360, 160);
            this.pnlStatistics.TabIndex = 4;
            // 
            // pnlMainRevenue
            // 
            this.pnlMainRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlMainRevenue.Controls.Add(this.lblGrowth);
            this.pnlMainRevenue.Controls.Add(this.lblGrowthIcon);
            this.pnlMainRevenue.Controls.Add(this.lblRevenue);
            this.pnlMainRevenue.Controls.Add(this.lblMonthYear);
            this.pnlMainRevenue.Location = new System.Drawing.Point(20, 20);
            this.pnlMainRevenue.Name = "pnlMainRevenue";
            this.pnlMainRevenue.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainRevenue.Size = new System.Drawing.Size(400, 120);
            this.pnlMainRevenue.TabIndex = 0;
            // 
            // lblGrowth
            // 
            this.lblGrowth.AutoSize = true;
            this.lblGrowth.Font = new System.Drawing.Font("Arial", 10F);
            this.lblGrowth.ForeColor = System.Drawing.Color.White;
            this.lblGrowth.Location = new System.Drawing.Point(60, 90);
            this.lblGrowth.Name = "lblGrowth";
            this.lblGrowth.Size = new System.Drawing.Size(206, 19);
            this.lblGrowth.TabIndex = 3;
            this.lblGrowth.Text = "+0.00% so với tháng trước";
            // 
            // lblGrowthIcon
            // 
            this.lblGrowthIcon.AutoSize = true;
            this.lblGrowthIcon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblGrowthIcon.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGrowthIcon.Location = new System.Drawing.Point(20, 88);
            this.lblGrowthIcon.Name = "lblGrowthIcon";
            this.lblGrowthIcon.Size = new System.Drawing.Size(30, 24);
            this.lblGrowthIcon.TabIndex = 2;
            this.lblGrowthIcon.Text = "▲";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.White;
            this.lblRevenue.Location = new System.Drawing.Point(20, 45);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(74, 46);
            this.lblRevenue.TabIndex = 1;
            this.lblRevenue.Text = "0 ₫";
            // 
            // lblMonthYear
            // 
            this.lblMonthYear.AutoSize = true;
            this.lblMonthYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonthYear.ForeColor = System.Drawing.Color.White;
            this.lblMonthYear.Location = new System.Drawing.Point(20, 15);
            this.lblMonthYear.Name = "lblMonthYear";
            this.lblMonthYear.Size = new System.Drawing.Size(258, 24);
            this.lblMonthYear.TabIndex = 0;
            this.lblMonthYear.Text = "Doanh Thu Tháng 01/2025";
            // 
            // pnlAdditionalStats
            // 
            this.pnlAdditionalStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlAdditionalStats.Controls.Add(this.lblYearRevenue);
            this.pnlAdditionalStats.Controls.Add(this.lblAvgInvoice);
            this.pnlAdditionalStats.Controls.Add(this.lblTodayRevenue);
            this.pnlAdditionalStats.Controls.Add(this.lblInvoiceCount);
            this.pnlAdditionalStats.Location = new System.Drawing.Point(440, 20);
            this.pnlAdditionalStats.Name = "pnlAdditionalStats";
            this.pnlAdditionalStats.Padding = new System.Windows.Forms.Padding(20);
            this.pnlAdditionalStats.Size = new System.Drawing.Size(900, 120);
            this.pnlAdditionalStats.TabIndex = 1;
            // 
            // lblYearRevenue
            // 
            this.lblYearRevenue.AutoSize = true;
            this.lblYearRevenue.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblYearRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblYearRevenue.Location = new System.Drawing.Point(460, 60);
            this.lblYearRevenue.Name = "lblYearRevenue";
            this.lblYearRevenue.Size = new System.Drawing.Size(238, 22);
            this.lblYearRevenue.TabIndex = 3;
            this.lblYearRevenue.Text = "Doanh thu năm 2025: 0 ₫";
            // 
            // lblAvgInvoice
            // 
            this.lblAvgInvoice.AutoSize = true;
            this.lblAvgInvoice.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblAvgInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblAvgInvoice.Location = new System.Drawing.Point(460, 25);
            this.lblAvgInvoice.Name = "lblAvgInvoice";
            this.lblAvgInvoice.Size = new System.Drawing.Size(167, 22);
            this.lblAvgInvoice.TabIndex = 2;
            this.lblAvgInvoice.Text = "Giá trị TB/HĐ: 0 ₫";
            // 
            // lblTodayRevenue
            // 
            this.lblTodayRevenue.AutoSize = true;
            this.lblTodayRevenue.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTodayRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTodayRevenue.Location = new System.Drawing.Point(20, 60);
            this.lblTodayRevenue.Name = "lblTodayRevenue";
            this.lblTodayRevenue.Size = new System.Drawing.Size(229, 22);
            this.lblTodayRevenue.TabIndex = 1;
            this.lblTodayRevenue.Text = "Doanh thu hôm nay: 0 ₫";
            // 
            // lblInvoiceCount
            // 
            this.lblInvoiceCount.AutoSize = true;
            this.lblInvoiceCount.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblInvoiceCount.Location = new System.Drawing.Point(20, 25);
            this.lblInvoiceCount.Name = "lblInvoiceCount";
            this.lblInvoiceCount.Size = new System.Drawing.Size(141, 22);
            this.lblInvoiceCount.TabIndex = 0;
            this.lblInvoiceCount.Text = "Số hóa đơn: 0";
            // 
            // DashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.flowPanelMovies);
            this.Controls.Add(this.pnlStatistics);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "DashboardUC";
            this.Size = new System.Drawing.Size(1360, 780);
            this.Load += new System.EventHandler(this.DashboardUC_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlStatistics.ResumeLayout(false);
            this.pnlMainRevenue.ResumeLayout(false);
            this.pnlMainRevenue.PerformLayout();
            this.pnlAdditionalStats.ResumeLayout(false);
            this.pnlAdditionalStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.FlowLayoutPanel flowPanelMovies;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.Panel pnlMainRevenue;
        private System.Windows.Forms.Label lblMonthYear;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblGrowth;
        private System.Windows.Forms.Label lblGrowthIcon;
        private System.Windows.Forms.Panel pnlAdditionalStats;
        private System.Windows.Forms.Label lblInvoiceCount;
        private System.Windows.Forms.Label lblTodayRevenue;
        private System.Windows.Forms.Label lblAvgInvoice;
        private System.Windows.Forms.Label lblYearRevenue;
    }
}