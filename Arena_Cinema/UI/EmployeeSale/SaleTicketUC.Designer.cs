namespace UI.EmployeeSale
{
    partial class SaleTicketUC
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;

        // Back Button
        private ReaLTaiizor.Controls.ParrotButton btn_back;

        // Movie Info Section
        private System.Windows.Forms.Panel pnlMovieInfo;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbInfo;

        // Customer Info
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Button btnCheckCustomer;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerPhone;

        // Selection Sections
        private System.Windows.Forms.Panel pnlShowTime;
        private System.Windows.Forms.Label lbShowTime;
        private System.Windows.Forms.FlowLayoutPanel flpShowTimes;

        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.Label lbSeats;
        private System.Windows.Forms.Panel flpTickets;

        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;

        // Invoice Section
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Button btnToggleInvoice;
        private System.Windows.Forms.Panel pnlInvoiceContent;
        private System.Windows.Forms.Label lbInvoiceTitle;
        private System.Windows.Forms.Panel pnlInvoiceDetails;
        private System.Windows.Forms.Label lbInvoiceMovie;
        private System.Windows.Forms.Label lbInvoiceShowTime;
        private System.Windows.Forms.Label lbInvoiceTickets;
        private System.Windows.Forms.Label lbInvoiceProducts;
        private System.Windows.Forms.Panel pnlInvoiceTotal;
        private System.Windows.Forms.Label lbInvoiceTotal;
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.lbProducts = new System.Windows.Forms.Label();
            this.pnlSeats = new System.Windows.Forms.Panel();
            this.flpTickets = new System.Windows.Forms.Panel();
            this.lbSeats = new System.Windows.Forms.Label();
            this.pnlShowTime = new System.Windows.Forms.Panel();
            this.flpShowTimes = new System.Windows.Forms.FlowLayoutPanel();
            this.lbShowTime = new System.Windows.Forms.Label();
            this.pnlMovieInfo = new System.Windows.Forms.Panel();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.btnCheckCustomer = new System.Windows.Forms.Button();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.btn_back = new ReaLTaiizor.Controls.ParrotButton();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.pnlInvoiceContent = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnlInvoiceTotal = new System.Windows.Forms.Panel();
            this.lbInvoiceTotal = new System.Windows.Forms.Label();
            this.pnlInvoiceDetails = new System.Windows.Forms.Panel();
            this.lbInvoiceProducts = new System.Windows.Forms.Label();
            this.lbInvoiceTickets = new System.Windows.Forms.Label();
            this.lbInvoiceShowTime = new System.Windows.Forms.Label();
            this.lbInvoiceMovie = new System.Windows.Forms.Label();
            this.lbInvoiceTitle = new System.Windows.Forms.Label();
            this.btnToggleInvoice = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.pnlSeats.SuspendLayout();
            this.pnlShowTime.SuspendLayout();
            this.pnlMovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlInvoice.SuspendLayout();
            this.pnlInvoiceContent.SuspendLayout();
            this.pnlInvoiceTotal.SuspendLayout();
            this.pnlInvoiceDetails.SuspendLayout();
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
            this.pnlMain.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMain.Size = new System.Drawing.Size(1600, 900);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.pnlProducts);
            this.pnlLeft.Controls.Add(this.pnlSeats);
            this.pnlLeft.Controls.Add(this.pnlShowTime);
            this.pnlLeft.Controls.Add(this.pnlMovieInfo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(15, 15);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlLeft.Size = new System.Drawing.Size(1120, 870);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.Color.White;
            this.pnlProducts.Controls.Add(this.flpProducts);
            this.pnlProducts.Controls.Add(this.lbProducts);
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProducts.Location = new System.Drawing.Point(0, 855);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.pnlProducts.Size = new System.Drawing.Size(1089, 800);
            this.pnlProducts.TabIndex = 3;
            // 
            // flpProducts
            // 
            this.flpProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProducts.Location = new System.Drawing.Point(20, 59);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(1049, 721);
            this.flpProducts.TabIndex = 1;
            // 
            // lbProducts
            // 
            this.lbProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.lbProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbProducts.Location = new System.Drawing.Point(20, 15);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lbProducts.Size = new System.Drawing.Size(1049, 44);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.Text = global::UI.Resources.Lang.lbProducts;
            // 
            // pnlSeats
            // 
            this.pnlSeats.BackColor = System.Drawing.Color.White;
            this.pnlSeats.Controls.Add(this.flpTickets);
            this.pnlSeats.Controls.Add(this.lbSeats);
            this.pnlSeats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeats.Location = new System.Drawing.Point(0, 280);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.pnlSeats.Size = new System.Drawing.Size(1089, 575);
            this.pnlSeats.TabIndex = 2;
            // 
            // flpTickets
            // 
            this.flpTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTickets.Location = new System.Drawing.Point(20, 57);
            this.flpTickets.Name = "flpTickets";
            this.flpTickets.Size = new System.Drawing.Size(1049, 498);
            this.flpTickets.TabIndex = 1;
            // 
            // lbSeats
            // 
            this.lbSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.lbSeats.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbSeats.Location = new System.Drawing.Point(20, 15);
            this.lbSeats.Name = "lbSeats";
            this.lbSeats.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lbSeats.Size = new System.Drawing.Size(1049, 42);
            this.lbSeats.TabIndex = 0;
            this.lbSeats.Text = global::UI.Resources.Lang.lbSeats;
            // 
            // pnlShowTime
            // 
            this.pnlShowTime.BackColor = System.Drawing.Color.White;
            this.pnlShowTime.Controls.Add(this.flpShowTimes);
            this.pnlShowTime.Controls.Add(this.lbShowTime);
            this.pnlShowTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShowTime.Location = new System.Drawing.Point(0, 170);
            this.pnlShowTime.Name = "pnlShowTime";
            this.pnlShowTime.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlShowTime.Size = new System.Drawing.Size(1089, 110);
            this.pnlShowTime.TabIndex = 1;
            // 
            // flpShowTimes
            // 
            this.flpShowTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpShowTimes.Location = new System.Drawing.Point(20, 51);
            this.flpShowTimes.Name = "flpShowTimes";
            this.flpShowTimes.Size = new System.Drawing.Size(1049, 44);
            this.flpShowTimes.TabIndex = 1;
            // 
            // lbShowTime
            // 
            this.lbShowTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.lbShowTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbShowTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbShowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbShowTime.Location = new System.Drawing.Point(20, 15);
            this.lbShowTime.Name = "lbShowTime";
            this.lbShowTime.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lbShowTime.Size = new System.Drawing.Size(1049, 36);
            this.lbShowTime.TabIndex = 0;
            this.lbShowTime.Text = global::UI.Resources.Lang.lbShowTime;
            // 
            // pnlMovieInfo
            // 
            this.pnlMovieInfo.BackColor = System.Drawing.Color.White;
            this.pnlMovieInfo.Controls.Add(this.lbCustomerPhone);
            this.pnlMovieInfo.Controls.Add(this.lbCustomerName);
            this.pnlMovieInfo.Controls.Add(this.btnCheckCustomer);
            this.pnlMovieInfo.Controls.Add(this.txt_Phone);
            this.pnlMovieInfo.Controls.Add(this.lbInfo);
            this.pnlMovieInfo.Controls.Add(this.lbTitle);
            this.pnlMovieInfo.Controls.Add(this.picPoster);
            this.pnlMovieInfo.Controls.Add(this.btn_back);
            this.pnlMovieInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMovieInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlMovieInfo.Name = "pnlMovieInfo";
            this.pnlMovieInfo.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMovieInfo.Size = new System.Drawing.Size(1089, 170);
            this.pnlMovieInfo.TabIndex = 0;
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lbCustomerPhone.Location = new System.Drawing.Point(705, 112);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(370, 20);
            this.lbCustomerPhone.TabIndex = 7;
            this.lbCustomerPhone.Text = global::UI.Resources.Lang.PhoneLabel;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbCustomerName.Location = new System.Drawing.Point(705, 87);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(370, 23);
            this.lbCustomerName.TabIndex = 6;
            this.lbCustomerName.Text = "👤 Khách hàng: ---";
            // 
            // btnCheckCustomer
            // 
            this.btnCheckCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnCheckCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckCustomer.FlatAppearance.BorderSize = 0;
            this.btnCheckCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCheckCustomer.Location = new System.Drawing.Point(975, 42);
            this.btnCheckCustomer.Name = "btnCheckCustomer";
            this.btnCheckCustomer.Size = new System.Drawing.Size(100, 32);
            this.btnCheckCustomer.TabIndex = 5;
            this.btnCheckCustomer.Text = global::UI.Resources.Lang.CheckCustomer;
            this.btnCheckCustomer.UseVisualStyleBackColor = false;
            this.btnCheckCustomer.Click += new System.EventHandler(this.btnCheckCustomer_Click);
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Phone.ForeColor = System.Drawing.Color.Gray;
            this.txt_Phone.Location = new System.Drawing.Point(705, 42);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(260, 30);
            this.txt_Phone.TabIndex = 4;
            this.txt_Phone.Text = "Nhập SĐT khách hàng...";
            this.txt_Phone.Enter += new System.EventHandler(this.txt_Phone_Enter);
            this.txt_Phone.Leave += new System.EventHandler(this.txt_Phone_Leave);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lbInfo.Location = new System.Drawing.Point(175, 24);
            this.lbInfo.MaximumSize = new System.Drawing.Size(520, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(212, 20);
            this.lbInfo.TabIndex = 3;
            this.lbInfo.Text = "Thể loại • Thời lượng • Độ tuổi";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbTitle.Location = new System.Drawing.Point(175, 20);
            this.lbTitle.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(500, 60);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Tên phim";
            this.lbTitle.AutoSize = false;
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(90, 20);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(70, 95);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 1;
            this.picPoster.TabStop = false;
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
            this.btn_back.Location = new System.Drawing.Point(20, 55);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(50, 50);
            this.btn_back.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_back.TabIndex = 0;
            this.btn_back.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_back.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.pnlInvoice);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1135, 15);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(450, 870);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BackColor = System.Drawing.Color.White;
            this.pnlInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInvoice.Controls.Add(this.pnlInvoiceContent);
            this.pnlInvoice.Controls.Add(this.btnToggleInvoice);
            this.pnlInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoice.Location = new System.Drawing.Point(0, 0);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(450, 870);
            this.pnlInvoice.TabIndex = 0;
            // 
            // pnlInvoiceContent
            // 
            this.pnlInvoiceContent.AutoScroll = true;
            this.pnlInvoiceContent.Controls.Add(this.btnPayment);
            this.pnlInvoiceContent.Controls.Add(this.pnlInvoiceTotal);
            this.pnlInvoiceContent.Controls.Add(this.pnlInvoiceDetails);
            this.pnlInvoiceContent.Controls.Add(this.lbInvoiceTitle);
            this.pnlInvoiceContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoiceContent.Location = new System.Drawing.Point(0, 45);
            this.pnlInvoiceContent.Name = "pnlInvoiceContent";
            this.pnlInvoiceContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlInvoiceContent.Size = new System.Drawing.Size(448, 823);
            this.pnlInvoiceContent.TabIndex = 1;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(20, 680);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(408, 55);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = global::UI.Resources.Lang.PaymentButton;
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // pnlInvoiceTotal
            // 
            this.pnlInvoiceTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.pnlInvoiceTotal.Controls.Add(this.lbInvoiceTotal);
            this.pnlInvoiceTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInvoiceTotal.Location = new System.Drawing.Point(20, 600);
            this.pnlInvoiceTotal.Name = "pnlInvoiceTotal";
            this.pnlInvoiceTotal.Padding = new System.Windows.Forms.Padding(15);
            this.pnlInvoiceTotal.Size = new System.Drawing.Size(408, 80);
            this.pnlInvoiceTotal.TabIndex = 2;
            // 
            // lbInvoiceTotal
            // 
            this.lbInvoiceTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInvoiceTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lbInvoiceTotal.Location = new System.Drawing.Point(15, 15);
            this.lbInvoiceTotal.Name = "lbInvoiceTotal";
            this.lbInvoiceTotal.Size = new System.Drawing.Size(378, 50);
            this.lbInvoiceTotal.TabIndex = 0;
            this.lbInvoiceTotal.Text = "Tổng tiền: 0đ";
            this.lbInvoiceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInvoiceDetails
            // 
            this.pnlInvoiceDetails.AutoScroll = true;
            this.pnlInvoiceDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlInvoiceDetails.Controls.Add(this.lbInvoiceProducts);
            this.pnlInvoiceDetails.Controls.Add(this.lbInvoiceTickets);
            this.pnlInvoiceDetails.Controls.Add(this.lbInvoiceShowTime);
            this.pnlInvoiceDetails.Controls.Add(this.lbInvoiceMovie);
            this.pnlInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInvoiceDetails.Location = new System.Drawing.Point(20, 85);
            this.pnlInvoiceDetails.Name = "pnlInvoiceDetails";
            this.pnlInvoiceDetails.Padding = new System.Windows.Forms.Padding(15);
            this.pnlInvoiceDetails.Size = new System.Drawing.Size(408, 515);
            this.pnlInvoiceDetails.TabIndex = 1;
            // 
            // lbInvoiceProducts
            // 
            this.lbInvoiceProducts.AutoSize = true;
            this.lbInvoiceProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbInvoiceProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lbInvoiceProducts.Location = new System.Drawing.Point(15, 233);
            this.lbInvoiceProducts.MaximumSize = new System.Drawing.Size(370, 0);
            this.lbInvoiceProducts.Name = "lbInvoiceProducts";
            this.lbInvoiceProducts.Size = new System.Drawing.Size(160, 20);
            this.lbInvoiceProducts.TabIndex = 3;
            this.lbInvoiceProducts.Text = "🍿 Sản phẩm đã chọn:";
            // 
            // lbInvoiceTickets
            // 
            this.lbInvoiceTickets.AutoSize = true;
            this.lbInvoiceTickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbInvoiceTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lbInvoiceTickets.Location = new System.Drawing.Point(15, 133);
            this.lbInvoiceTickets.MaximumSize = new System.Drawing.Size(370, 0);
            this.lbInvoiceTickets.Name = "lbInvoiceTickets";
            this.lbInvoiceTickets.Size = new System.Drawing.Size(120, 20);
            this.lbInvoiceTickets.TabIndex = 2;
            this.lbInvoiceTickets.Text = "🎫 Ghế đã chọn:";
            // 
            // lbInvoiceShowTime
            // 
            this.lbInvoiceShowTime.AutoSize = true;
            this.lbInvoiceShowTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbInvoiceShowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lbInvoiceShowTime.Location = new System.Drawing.Point(15, 88);
            this.lbInvoiceShowTime.MaximumSize = new System.Drawing.Size(370, 0);
            this.lbInvoiceShowTime.Name = "lbInvoiceShowTime";
            this.lbInvoiceShowTime.Size = new System.Drawing.Size(105, 20);
            this.lbInvoiceShowTime.TabIndex = 1;
            this.lbInvoiceShowTime.Text = "🕐 Suất chiếu:";
            // 
            // lbInvoiceMovie
            // 
            this.lbInvoiceMovie.AutoSize = true;
            this.lbInvoiceMovie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbInvoiceMovie.Location = new System.Drawing.Point(15, 15);
            this.lbInvoiceMovie.MaximumSize = new System.Drawing.Size(370, 0);
            this.lbInvoiceMovie.Name = "lbInvoiceMovie";
            this.lbInvoiceMovie.Size = new System.Drawing.Size(85, 23);
            this.lbInvoiceMovie.TabIndex = 0;
            this.lbInvoiceMovie.Text = "🎬 Phim:";
            // 
            // lbInvoiceTitle
            // 
            this.lbInvoiceTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbInvoiceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInvoiceTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceTitle.ForeColor = System.Drawing.Color.White;
            this.lbInvoiceTitle.Location = new System.Drawing.Point(20, 20);
            this.lbInvoiceTitle.Name = "lbInvoiceTitle";
            this.lbInvoiceTitle.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.lbInvoiceTitle.Size = new System.Drawing.Size(408, 65);
            this.lbInvoiceTitle.TabIndex = 0;
            this.lbInvoiceTitle.Text = global::UI.Resources.Lang.InvoiceTitle;
            this.lbInvoiceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToggleInvoice
            // 
            this.btnToggleInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnToggleInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToggleInvoice.FlatAppearance.BorderSize = 0;
            this.btnToggleInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleInvoice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnToggleInvoice.ForeColor = System.Drawing.Color.White;
            this.btnToggleInvoice.Location = new System.Drawing.Point(0, 0);
            this.btnToggleInvoice.Name = "btnToggleInvoice";
            this.btnToggleInvoice.Size = new System.Drawing.Size(448, 45);
            this.btnToggleInvoice.TabIndex = 0;
            this.btnToggleInvoice.Text = global::UI.Resources.Lang.ToggleInvoice;
            this.btnToggleInvoice.UseVisualStyleBackColor = false;
            this.btnToggleInvoice.Click += new System.EventHandler(this.btnToggleInvoice_Click);
            // 
            // SaleTicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "SaleTicketUC";
            this.Size = new System.Drawing.Size(1600, 900);
            this.pnlMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlProducts.ResumeLayout(false);
            this.pnlSeats.ResumeLayout(false);
            this.pnlShowTime.ResumeLayout(false);
            this.pnlMovieInfo.ResumeLayout(false);
            this.pnlMovieInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoiceContent.ResumeLayout(false);
            this.pnlInvoiceTotal.ResumeLayout(false);
            this.pnlInvoiceDetails.ResumeLayout(false);
            this.pnlInvoiceDetails.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}