namespace UI.EmployeeSale
{
    partial class SaleTicketUC
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpMovieInfo;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbShowTime;
        private System.Windows.Forms.ComboBox cboShowTime;
        private System.Windows.Forms.Label lbTickets;
        private System.Windows.Forms.FlowLayoutPanel flpTickets;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Button btnPayment;

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
            this.grpMovieInfo = new System.Windows.Forms.GroupBox();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbShowTime = new System.Windows.Forms.Label();
            this.cboShowTime = new System.Windows.Forms.ComboBox();
            this.lbTickets = new System.Windows.Forms.Label();
            this.flpTickets = new System.Windows.Forms.FlowLayoutPanel();
            this.lbProducts = new System.Windows.Forms.Label();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMovieInfo
            // 
            this.grpMovieInfo.Controls.Add(this.picPoster);
            this.grpMovieInfo.Controls.Add(this.lbTitle);
            this.grpMovieInfo.Controls.Add(this.lbInfo);
            this.grpMovieInfo.Location = new System.Drawing.Point(30, 30);
            this.grpMovieInfo.Name = "grpMovieInfo";
            this.grpMovieInfo.Size = new System.Drawing.Size(400, 220);
            this.grpMovieInfo.TabIndex = 0;
            this.grpMovieInfo.TabStop = false;
            this.grpMovieInfo.Text = "Thông tin phim";
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(20, 30);
            this.picPoster.Size = new System.Drawing.Size(120, 160);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // lbTitle
            // 
            this.lbTitle.Location = new System.Drawing.Point(160, 30);
            this.lbTitle.Size = new System.Drawing.Size(220, 30);
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Text = "Tên phim";
            // 
            // lbInfo
            // 
            this.lbInfo.Location = new System.Drawing.Point(160, 70);
            this.lbInfo.Size = new System.Drawing.Size(220, 60);
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbInfo.Text = "Thể loại, thời lượng, tuổi";
            // 
            // lbShowTime
            // 
            this.lbShowTime.Location = new System.Drawing.Point(30, 270);
            this.lbShowTime.Size = new System.Drawing.Size(120, 25);
            this.lbShowTime.Text = "Chọn suất chiếu:";
            // 
            // cboShowTime
            // 
            this.cboShowTime.Location = new System.Drawing.Point(160, 270);
            this.cboShowTime.Size = new System.Drawing.Size(270, 25);
            // 
            // lbTickets
            // 
            this.lbTickets.Location = new System.Drawing.Point(30, 310);
            this.lbTickets.Size = new System.Drawing.Size(120, 25);
            this.lbTickets.Text = "Chọn ghế:";
            // 
            // flpTickets
            // 
            this.flpTickets.Location = new System.Drawing.Point(160, 310);
            this.flpTickets.Size = new System.Drawing.Size(800, 120);
            this.flpTickets.AutoScroll = true;
            // 
            // lbProducts
            // 
            this.lbProducts.Location = new System.Drawing.Point(30, 450);
            this.lbProducts.Size = new System.Drawing.Size(120, 25);
            this.lbProducts.Text = "Chọn sản phẩm:";
            // 
            // flpProducts
            // 
            this.flpProducts.Location = new System.Drawing.Point(160, 450);
            this.flpProducts.Size = new System.Drawing.Size(800, 120);
            this.flpProducts.AutoScroll = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(30, 600);
            this.btnPayment.Size = new System.Drawing.Size(930, 50);
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(184, 28, 45);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // SaleTicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SaleTicketUC";
            this.Size = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.grpMovieInfo);
            this.Controls.Add(this.lbShowTime);
            this.Controls.Add(this.cboShowTime);
            this.Controls.Add(this.lbTickets);
            this.Controls.Add(this.flpTickets);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.btnPayment);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
