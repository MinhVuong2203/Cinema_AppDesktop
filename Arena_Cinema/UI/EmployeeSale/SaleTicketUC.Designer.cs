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
        private System.Windows.Forms.FlowLayoutPanel flpShowTimes;
        private System.Windows.Forms.Label lbTickets;
        private System.Windows.Forms.FlowLayoutPanel flpTicketTypes; // Panel chọn loại vé
        private System.Windows.Forms.Label lbSeats;
        private System.Windows.Forms.FlowLayoutPanel flpTickets;     // Panel chọn ghế
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Button btnPayment;

        // Hóa đơn
        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.Label lbInvoiceTitle;
        private System.Windows.Forms.Label lbInvoiceMovie;
        private System.Windows.Forms.Label lbInvoiceShowTime;
        private System.Windows.Forms.Label lbInvoiceTickets;
        private System.Windows.Forms.Label lbInvoiceTicketTypes;
        private System.Windows.Forms.Label lbInvoiceProducts;
        private System.Windows.Forms.Label lbInvoiceTotal;

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
            this.flpShowTimes = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTickets = new System.Windows.Forms.Label();
            this.flpTicketTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSeats = new System.Windows.Forms.Label();
            this.flpTickets = new System.Windows.Forms.FlowLayoutPanel();
            this.lbProducts = new System.Windows.Forms.Label();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.lbInvoiceTitle = new System.Windows.Forms.Label();
            this.lbInvoiceMovie = new System.Windows.Forms.Label();
            this.lbInvoiceShowTime = new System.Windows.Forms.Label();
            this.lbInvoiceTickets = new System.Windows.Forms.Label();
            this.lbInvoiceTicketTypes = new System.Windows.Forms.Label();
            this.lbInvoiceProducts = new System.Windows.Forms.Label();
            this.lbInvoiceTotal = new System.Windows.Forms.Label();
            this.grpMovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.grpInvoice.SuspendLayout();
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
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(120, 160);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Location = new System.Drawing.Point(160, 30);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(220, 30);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Tên phim";
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbInfo.Location = new System.Drawing.Point(160, 70);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(220, 60);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "Thể loại, thời lượng, tuổi";
            // 
            // lbShowTime
            // 
            this.lbShowTime.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbShowTime.Location = new System.Drawing.Point(30, 280);
            this.lbShowTime.Name = "lbShowTime";
            this.lbShowTime.Size = new System.Drawing.Size(139, 25);
            this.lbShowTime.TabIndex = 1;
            this.lbShowTime.Text = "Chọn suất chiếu:";
            // 
            // flpShowTimes
            // 
            this.flpShowTimes.AutoScroll = true;
            this.flpShowTimes.Location = new System.Drawing.Point(241, 256);
            this.flpShowTimes.Name = "flpShowTimes";
            this.flpShowTimes.Size = new System.Drawing.Size(800, 64);
            this.flpShowTimes.TabIndex = 2;
            // 
            // lbTickets
            // 
            this.lbTickets.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbTickets.Location = new System.Drawing.Point(30, 355);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(120, 25);
            this.lbTickets.TabIndex = 3;
            this.lbTickets.Text = "Chọn loại vé:";
            // 
            // flpTicketTypes
            // 
            this.flpTicketTypes.AutoScroll = true;
            this.flpTicketTypes.Location = new System.Drawing.Point(241, 334);
            this.flpTicketTypes.Name = "flpTicketTypes";
            this.flpTicketTypes.Size = new System.Drawing.Size(800, 65);
            this.flpTicketTypes.TabIndex = 4;
            // 
            // lbSeats
            // 
            this.lbSeats.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbSeats.Location = new System.Drawing.Point(30, 430);
            this.lbSeats.Name = "lbSeats";
            this.lbSeats.Size = new System.Drawing.Size(120, 25);
            this.lbSeats.TabIndex = 5;
            this.lbSeats.Text = "Chọn ghế:";
            // 
            // flpTickets
            // 
            this.flpTickets.AutoScroll = true;
            this.flpTickets.Location = new System.Drawing.Point(241, 410);
            this.flpTickets.Name = "flpTickets";
            this.flpTickets.Size = new System.Drawing.Size(800, 120);
            this.flpTickets.TabIndex = 6;
            // 
            // lbProducts
            // 
            this.lbProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbProducts.Location = new System.Drawing.Point(30, 560);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(147, 25);
            this.lbProducts.TabIndex = 7;
            this.lbProducts.Text = "Chọn sản phẩm:";
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.Location = new System.Drawing.Point(241, 540);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(800, 120);
            this.flpProducts.TabIndex = 8;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(241, 680);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(800, 50);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.lbInvoiceTitle);
            this.grpInvoice.Controls.Add(this.lbInvoiceMovie);
            this.grpInvoice.Controls.Add(this.lbInvoiceShowTime);
            this.grpInvoice.Controls.Add(this.lbInvoiceTickets);
            this.grpInvoice.Controls.Add(this.lbInvoiceTicketTypes);
            this.grpInvoice.Controls.Add(this.lbInvoiceProducts);
            this.grpInvoice.Controls.Add(this.lbInvoiceTotal);
            this.grpInvoice.Location = new System.Drawing.Point(1101, 30);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(600, 400);
            this.grpInvoice.TabIndex = 10;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "Hóa đơn thanh toán";
            // 
            // lbInvoiceTitle
            // 
            this.lbInvoiceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceTitle.Location = new System.Drawing.Point(20, 30);
            this.lbInvoiceTitle.Name = "lbInvoiceTitle";
            this.lbInvoiceTitle.Size = new System.Drawing.Size(560, 30);
            this.lbInvoiceTitle.TabIndex = 0;
            this.lbInvoiceTitle.Text = "Thông tin hóa đơn";
            // 
            // lbInvoiceMovie
            // 
            this.lbInvoiceMovie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceMovie.Location = new System.Drawing.Point(20, 65);
            this.lbInvoiceMovie.Name = "lbInvoiceMovie";
            this.lbInvoiceMovie.Size = new System.Drawing.Size(560, 25);
            this.lbInvoiceMovie.TabIndex = 1;
            this.lbInvoiceMovie.Text = "Phim:";
            // 
            // lbInvoiceShowTime
            // 
            this.lbInvoiceShowTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceShowTime.Location = new System.Drawing.Point(20, 95);
            this.lbInvoiceShowTime.Name = "lbInvoiceShowTime";
            this.lbInvoiceShowTime.Size = new System.Drawing.Size(560, 25);
            this.lbInvoiceShowTime.TabIndex = 2;
            this.lbInvoiceShowTime.Text = "Suất chiếu:";
            // 
            // lbInvoiceTickets
            // 
            this.lbInvoiceTickets.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbInvoiceTickets.Location = new System.Drawing.Point(20, 125);
            this.lbInvoiceTickets.Name = "lbInvoiceTickets";
            this.lbInvoiceTickets.Size = new System.Drawing.Size(560, 60);
            this.lbInvoiceTickets.TabIndex = 3;
            this.lbInvoiceTickets.Text = "Ghế đã chọn:";
            // 
            // lbInvoiceTicketTypes
            // 
            this.lbInvoiceTicketTypes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceTicketTypes.Location = new System.Drawing.Point(20, 190);
            this.lbInvoiceTicketTypes.Name = "lbInvoiceTicketTypes";
            this.lbInvoiceTicketTypes.Size = new System.Drawing.Size(560, 30);
            this.lbInvoiceTicketTypes.TabIndex = 4;
            this.lbInvoiceTicketTypes.Text = "Số lượng từng loại vé:";
            // 
            // lbInvoiceProducts
            // 
            this.lbInvoiceProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbInvoiceProducts.Location = new System.Drawing.Point(20, 230);
            this.lbInvoiceProducts.Name = "lbInvoiceProducts";
            this.lbInvoiceProducts.Size = new System.Drawing.Size(560, 60);
            this.lbInvoiceProducts.TabIndex = 5;
            this.lbInvoiceProducts.Text = "Sản phẩm đã chọn:";
            // 
            // lbInvoiceTotal
            // 
            this.lbInvoiceTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceTotal.Location = new System.Drawing.Point(20, 310);
            this.lbInvoiceTotal.Name = "lbInvoiceTotal";
            this.lbInvoiceTotal.Size = new System.Drawing.Size(560, 30);
            this.lbInvoiceTotal.TabIndex = 6;
            this.lbInvoiceTotal.Text = "Tổng tiền: 0đ";
            // 
            // SaleTicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpMovieInfo);
            this.Controls.Add(this.lbShowTime);
            this.Controls.Add(this.flpShowTimes);
            this.Controls.Add(this.lbTickets);
            this.Controls.Add(this.flpTicketTypes);
            this.Controls.Add(this.lbSeats);
            this.Controls.Add(this.flpTickets);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.grpInvoice);
            this.Name = "SaleTicketUC";
            this.Size = new System.Drawing.Size(1764, 800);
            this.grpMovieInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.grpInvoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
