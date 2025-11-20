namespace UI.EmployeeSale
{
    partial class SaleTicketUC
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;

        // Back Button
        //private System.Windows.Forms.Button btnBack;

        // Movie Info Section
        private System.Windows.Forms.Panel pnlMovieInfo;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbInfo;

        // Selection Sections
        private System.Windows.Forms.Panel pnlShowTime;
        private System.Windows.Forms.Label lbShowTime;
        private System.Windows.Forms.FlowLayoutPanel flpShowTimes;

        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.Label lbSeats;
        private System.Windows.Forms.FlowLayoutPanel flpTickets;

        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;

        private System.Windows.Forms.Button btnPayment;

        // Invoice Section
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Label lbInvoiceTitle;
        private System.Windows.Forms.Panel pnlInvoiceContent;
        private System.Windows.Forms.Label lbInvoiceMovie;
        private System.Windows.Forms.Label lbInvoiceShowTime;
        private System.Windows.Forms.Label lbInvoiceTickets;
        private System.Windows.Forms.Label lbInvoiceProducts;
        private System.Windows.Forms.Panel pnlInvoiceTotal;
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.btnCheckCustomer = new System.Windows.Forms.Button();
            this.btn_back = new ReaLTaiizor.Controls.ParrotButton();
            this.pnlMovieInfo = new System.Windows.Forms.Panel();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.pnlShowTime = new System.Windows.Forms.Panel();
            this.lbShowTime = new System.Windows.Forms.Label();
            this.flpShowTimes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSeats = new System.Windows.Forms.Panel();
            this.lbSeats = new System.Windows.Forms.Label();
            this.flpTickets = new System.Windows.Forms.FlowLayoutPanel();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.lbProducts = new System.Windows.Forms.Label();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.lbInvoiceTitle = new System.Windows.Forms.Label();
            this.pnlInvoiceContent = new System.Windows.Forms.Panel();
            this.lbInvoiceMovie = new System.Windows.Forms.Label();
            this.lbInvoiceShowTime = new System.Windows.Forms.Label();
            this.lbInvoiceTickets = new System.Windows.Forms.Label();
            this.lbInvoiceProducts = new System.Windows.Forms.Label();
            this.pnlInvoiceTotal = new System.Windows.Forms.Panel();
            this.lbInvoiceTotal = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.pnlShowTime.SuspendLayout();
            this.pnlSeats.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlInvoice.SuspendLayout();
            this.pnlInvoiceContent.SuspendLayout();
            this.pnlInvoiceTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(1800, 2000);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.txt_Phone);
            this.pnlLeft.Controls.Add(this.btnCheckCustomer);
            this.pnlLeft.Controls.Add(this.btn_back);
            this.pnlLeft.Controls.Add(this.pnlMovieInfo);
            this.pnlLeft.Controls.Add(this.lbCustomerName);
            this.pnlLeft.Controls.Add(this.pnlShowTime);
            this.pnlLeft.Controls.Add(this.pnlSeats);
            this.pnlLeft.Controls.Add(this.lbCustomerPhone);
            this.pnlLeft.Controls.Add(this.pnlProducts);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(20, 20);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1200, 1960);
            this.pnlLeft.TabIndex = 0;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(787, 9);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(238, 30);
            this.txt_Phone.TabIndex = 11;
            // 
            // btnCheckCustomer
            // 
            this.btnCheckCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnCheckCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCheckCustomer.Location = new System.Drawing.Point(1036, 9);
            this.btnCheckCustomer.Name = "btnCheckCustomer";
            this.btnCheckCustomer.Size = new System.Drawing.Size(100, 30);
            this.btnCheckCustomer.TabIndex = 12;
            this.btnCheckCustomer.Text = "Kiểm tra";
            this.btnCheckCustomer.UseVisualStyleBackColor = false;
            this.btnCheckCustomer.Click += new System.EventHandler(this.btnCheckCustomer_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_back.ButtonImage = global::UI.Properties.Resources.chevrons;
            this.btn_back.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btn_back.ButtonText = "";
            this.btn_back.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_back.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.CornerRadius = 5;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_back.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_back.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btn_back.Location = new System.Drawing.Point(30, 34);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(60, 50);
            this.btn_back.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_back.TabIndex = 6;
            this.btn_back.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_back.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // pnlMovieInfo
            // 
            this.pnlMovieInfo.BackColor = System.Drawing.Color.White;
            this.pnlMovieInfo.Controls.Add(this.picPoster);
            this.pnlMovieInfo.Controls.Add(this.lbTitle);
            this.pnlMovieInfo.Controls.Add(this.lbInfo);
            this.pnlMovieInfo.Location = new System.Drawing.Point(96, 9);
            this.pnlMovieInfo.Name = "pnlMovieInfo";
            this.pnlMovieInfo.Padding = new System.Windows.Forms.Padding(25);
            this.pnlMovieInfo.Size = new System.Drawing.Size(656, 180);
            this.pnlMovieInfo.TabIndex = 0;
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(25, 25);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(100, 130);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbTitle.Location = new System.Drawing.Point(145, 25);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(483, 40);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Tên phim";
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lbInfo.Location = new System.Drawing.Point(145, 84);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(407, 80);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "Thể loại • Thời lượng • Độ tuổi";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbCustomerName.Location = new System.Drawing.Point(783, 54);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(350, 30);
            this.lbCustomerName.TabIndex = 13;
            this.lbCustomerName.Text = "Tên khách hàng: ";
            // 
            // pnlShowTime
            // 
            this.pnlShowTime.BackColor = System.Drawing.Color.White;
            this.pnlShowTime.Controls.Add(this.lbShowTime);
            this.pnlShowTime.Controls.Add(this.flpShowTimes);
            this.pnlShowTime.Location = new System.Drawing.Point(0, 195);
            this.pnlShowTime.Name = "pnlShowTime";
            this.pnlShowTime.Padding = new System.Windows.Forms.Padding(25, 20, 25, 20);
            this.pnlShowTime.Size = new System.Drawing.Size(1183, 120);
            this.pnlShowTime.TabIndex = 1;
            // 
            // lbShowTime
            // 
            this.lbShowTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbShowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbShowTime.Location = new System.Drawing.Point(25, 20);
            this.lbShowTime.Name = "lbShowTime";
            this.lbShowTime.Size = new System.Drawing.Size(200, 25);
            this.lbShowTime.TabIndex = 0;
            this.lbShowTime.Text = "Chọn suất chiếu";
            // 
            // flpShowTimes
            // 
            this.flpShowTimes.AutoScroll = true;
            this.flpShowTimes.Location = new System.Drawing.Point(25, 50);
            this.flpShowTimes.Name = "flpShowTimes";
            this.flpShowTimes.Size = new System.Drawing.Size(1141, 50);
            this.flpShowTimes.TabIndex = 1;
            // 
            // pnlSeats
            // 
            this.pnlSeats.BackColor = System.Drawing.Color.White;
            this.pnlSeats.Controls.Add(this.lbSeats);
            this.pnlSeats.Controls.Add(this.flpTickets);
            this.pnlSeats.Location = new System.Drawing.Point(0, 321);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Padding = new System.Windows.Forms.Padding(25, 20, 25, 20);
            this.pnlSeats.Size = new System.Drawing.Size(1183, 686);
            this.pnlSeats.TabIndex = 3;
            // 
            // lbSeats
            // 
            this.lbSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbSeats.Location = new System.Drawing.Point(25, 11);
            this.lbSeats.Name = "lbSeats";
            this.lbSeats.Size = new System.Drawing.Size(200, 36);
            this.lbSeats.TabIndex = 0;
            this.lbSeats.Text = "Chọn ghế ngồi";
            // 
            // flpTickets
            // 
            this.flpTickets.AutoScroll = true;
            this.flpTickets.Location = new System.Drawing.Point(25, 50);
            this.flpTickets.Name = "flpTickets";
            this.flpTickets.Size = new System.Drawing.Size(1082, 613);
            this.flpTickets.TabIndex = 1;
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbCustomerPhone.Location = new System.Drawing.Point(783, 95);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(350, 30);
            this.lbCustomerPhone.TabIndex = 14;
            this.lbCustomerPhone.Text = "SĐT: ";
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.Color.White;
            this.pnlProducts.Controls.Add(this.lbProducts);
            this.pnlProducts.Controls.Add(this.flpProducts);
            this.pnlProducts.Location = new System.Drawing.Point(0, 1013);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Padding = new System.Windows.Forms.Padding(25, 20, 25, 20);
            this.pnlProducts.Size = new System.Drawing.Size(1183, 944);
            this.pnlProducts.TabIndex = 4;
            // 
            // lbProducts
            // 
            this.lbProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbProducts.Location = new System.Drawing.Point(25, 9);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(217, 35);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.Text = "Chọn đồ ăn và nước";
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.Location = new System.Drawing.Point(25, 47);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(1141, 884);
            this.flpProducts.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.pnlInvoice);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1220, 20);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(560, 1960);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.AutoScroll = true;
            this.pnlInvoice.BackColor = System.Drawing.Color.White;
            this.pnlInvoice.Controls.Add(this.lbInvoiceTitle);
            this.pnlInvoice.Controls.Add(this.pnlInvoiceContent);
            this.pnlInvoice.Controls.Add(this.pnlInvoiceTotal);
            this.pnlInvoice.Controls.Add(this.btnPayment);
            this.pnlInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoice.Location = new System.Drawing.Point(0, 0);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Padding = new System.Windows.Forms.Padding(25);
            this.pnlInvoice.Size = new System.Drawing.Size(560, 1960);
            this.pnlInvoice.TabIndex = 0;
            // 
            // lbInvoiceTitle
            // 
            this.lbInvoiceTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbInvoiceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInvoiceTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceTitle.ForeColor = System.Drawing.Color.White;
            this.lbInvoiceTitle.Location = new System.Drawing.Point(25, 25);
            this.lbInvoiceTitle.Name = "lbInvoiceTitle";
            this.lbInvoiceTitle.Padding = new System.Windows.Forms.Padding(20);
            this.lbInvoiceTitle.Size = new System.Drawing.Size(510, 70);
            this.lbInvoiceTitle.TabIndex = 0;
            this.lbInvoiceTitle.Text = "HÓA ĐƠN THANH TOÁN";
            this.lbInvoiceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInvoiceContent
            // 
            this.pnlInvoiceContent.AutoScroll = true;
            this.pnlInvoiceContent.Controls.Add(this.lbInvoiceMovie);
            this.pnlInvoiceContent.Controls.Add(this.lbInvoiceShowTime);
            this.pnlInvoiceContent.Controls.Add(this.lbInvoiceTickets);
            this.pnlInvoiceContent.Controls.Add(this.lbInvoiceProducts);
            this.pnlInvoiceContent.Location = new System.Drawing.Point(25, 95);
            this.pnlInvoiceContent.Name = "pnlInvoiceContent";
            this.pnlInvoiceContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlInvoiceContent.Size = new System.Drawing.Size(510, 650);
            this.pnlInvoiceContent.TabIndex = 1;
            // 
            // lbInvoiceMovie
            // 
            this.lbInvoiceMovie.AutoSize = true;
            this.lbInvoiceMovie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbInvoiceMovie.Location = new System.Drawing.Point(20, 20);
            this.lbInvoiceMovie.MaximumSize = new System.Drawing.Size(450, 0);
            this.lbInvoiceMovie.Name = "lbInvoiceMovie";
            this.lbInvoiceMovie.Size = new System.Drawing.Size(56, 23);
            this.lbInvoiceMovie.TabIndex = 0;
            this.lbInvoiceMovie.Text = "Phim:";
            // 
            // lbInvoiceShowTime
            // 
            this.lbInvoiceShowTime.AutoSize = true;
            this.lbInvoiceShowTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbInvoiceShowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lbInvoiceShowTime.Location = new System.Drawing.Point(20, 60);
            this.lbInvoiceShowTime.MaximumSize = new System.Drawing.Size(450, 0);
            this.lbInvoiceShowTime.Name = "lbInvoiceShowTime";
            this.lbInvoiceShowTime.Size = new System.Drawing.Size(94, 23);
            this.lbInvoiceShowTime.TabIndex = 1;
            this.lbInvoiceShowTime.Text = "Suất chiếu:";
            // 
            // lbInvoiceTickets
            // 
            this.lbInvoiceTickets.AutoSize = true;
            this.lbInvoiceTickets.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbInvoiceTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lbInvoiceTickets.Location = new System.Drawing.Point(20, 110);
            this.lbInvoiceTickets.MaximumSize = new System.Drawing.Size(450, 0);
            this.lbInvoiceTickets.Name = "lbInvoiceTickets";
            this.lbInvoiceTickets.Size = new System.Drawing.Size(112, 23);
            this.lbInvoiceTickets.TabIndex = 2;
            this.lbInvoiceTickets.Text = "Ghế đã chọn:";
            // 
            // lbInvoiceProducts
            // 
            this.lbInvoiceProducts.AutoSize = true;
            this.lbInvoiceProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbInvoiceProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lbInvoiceProducts.Location = new System.Drawing.Point(20, 250);
            this.lbInvoiceProducts.MaximumSize = new System.Drawing.Size(450, 0);
            this.lbInvoiceProducts.Name = "lbInvoiceProducts";
            this.lbInvoiceProducts.Size = new System.Drawing.Size(158, 23);
            this.lbInvoiceProducts.TabIndex = 4;
            this.lbInvoiceProducts.Text = "Sản phẩm đã chọn:";
            // 
            // pnlInvoiceTotal
            // 
            this.pnlInvoiceTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.pnlInvoiceTotal.Controls.Add(this.lbInvoiceTotal);
            this.pnlInvoiceTotal.Location = new System.Drawing.Point(25, 750);
            this.pnlInvoiceTotal.Name = "pnlInvoiceTotal";
            this.pnlInvoiceTotal.Size = new System.Drawing.Size(510, 85);
            this.pnlInvoiceTotal.TabIndex = 2;
            // 
            // lbInvoiceTotal
            // 
            this.lbInvoiceTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInvoiceTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lbInvoiceTotal.Location = new System.Drawing.Point(0, 0);
            this.lbInvoiceTotal.Name = "lbInvoiceTotal";
            this.lbInvoiceTotal.Size = new System.Drawing.Size(510, 85);
            this.lbInvoiceTotal.TabIndex = 0;
            this.lbInvoiceTotal.Text = "Tổng tiền: 0đ";
            this.lbInvoiceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(25, 867);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(507, 55);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "THANH TOÁN";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // SaleTicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "SaleTicketUC";
            this.Size = new System.Drawing.Size(1800, 2000);
            this.pnlMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlMovieInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.pnlShowTime.ResumeLayout(false);
            this.pnlSeats.ResumeLayout(false);
            this.pnlProducts.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoiceContent.ResumeLayout(false);
            this.pnlInvoiceContent.PerformLayout();
            this.pnlInvoiceTotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private ReaLTaiizor.Controls.ParrotButton btn_back;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Button btnCheckCustomer;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerPhone;
    }
}