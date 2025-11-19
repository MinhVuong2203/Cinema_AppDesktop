namespace UI.EmployeeSale
{
    partial class ProductPaymentInfor
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPaymentInfor));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.parrotbtn_payCash = new ReaLTaiizor.Controls.ParrotButton();
            this.btnBack = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPay = new ReaLTaiizor.Controls.ParrotButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.panelInvoiceInfo = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.picSuccess = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.parrotBtn_printInvoice = new ReaLTaiizor.Controls.ParrotButton();
            this.panelMain.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelInvoiceInfo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelMain.Controls.Add(this.panelButtons);
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(30);
            this.panelMain.Size = new System.Drawing.Size(1800, 900);
            this.panelMain.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.parrotBtn_printInvoice);
            this.panelButtons.Controls.Add(this.parrotbtn_payCash);
            this.panelButtons.Controls.Add(this.btnBack);
            this.panelButtons.Controls.Add(this.btnPay);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(30, 800);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1740, 70);
            this.panelButtons.TabIndex = 2;
            // 
            // parrotbtn_payCash
            // 
            this.parrotbtn_payCash.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.parrotbtn_payCash.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotbtn_payCash.ButtonImage")));
            this.parrotbtn_payCash.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotbtn_payCash.ButtonText = "Thanh toán tiền mặt";
            this.parrotbtn_payCash.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.parrotbtn_payCash.ClickTextColor = System.Drawing.Color.White;
            this.parrotbtn_payCash.CornerRadius = 5;
            this.parrotbtn_payCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotbtn_payCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotbtn_payCash.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotbtn_payCash.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.parrotbtn_payCash.HoverTextColor = System.Drawing.Color.White;
            this.parrotbtn_payCash.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotbtn_payCash.Location = new System.Drawing.Point(922, 10);
            this.parrotbtn_payCash.Name = "parrotbtn_payCash";
            this.parrotbtn_payCash.Size = new System.Drawing.Size(200, 50);
            this.parrotbtn_payCash.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotbtn_payCash.TabIndex = 2;
            this.parrotbtn_payCash.TextColor = System.Drawing.Color.White;
            this.parrotbtn_payCash.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotbtn_payCash.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotbtn_payCash.Click += new System.EventHandler(this.parrotbtn_payCash_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnBack.ButtonImage = global::UI.Properties.Resources.chevrons;
            this.btnBack.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnBack.ButtonText = "Quay lại";
            this.btnBack.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnBack.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnBack.CornerRadius = 8;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnBack.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnBack.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnBack.Location = new System.Drawing.Point(30, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 50);
            this.btnBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnBack.TabIndex = 1;
            this.btnBack.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnBack.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnPay
            // 
            this.btnPay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnPay.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPay.ButtonImage")));
            this.btnPay.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnPay.ButtonText = "Thanh toán PayOS";
            this.btnPay.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnPay.ClickTextColor = System.Drawing.Color.White;
            this.btnPay.CornerRadius = 8;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPay.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnPay.HoverTextColor = System.Drawing.Color.White;
            this.btnPay.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnPay.Location = new System.Drawing.Point(1154, 10);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(203, 50);
            this.btnPay.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPay.TabIndex = 0;
            this.btnPay.TextColor = System.Drawing.Color.White;
            this.btnPay.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPay.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.panelSummary);
            this.panelContent.Controls.Add(this.panelProducts);
            this.panelContent.Controls.Add(this.panelInvoiceInfo);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(30, 124);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(30);
            this.panelContent.Size = new System.Drawing.Size(1740, 746);
            this.panelContent.TabIndex = 1;
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panelSummary.Controls.Add(this.lblTotal);
            this.panelSummary.Controls.Add(this.lblDiscount);
            this.panelSummary.Controls.Add(this.lblSubtotal);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSummary.Location = new System.Drawing.Point(30, 507);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelSummary.Size = new System.Drawing.Size(1680, 209);
            this.panelSummary.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTotal.Location = new System.Drawing.Point(1078, 110);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(450, 40);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Tổng cộng: 0 ₫";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDiscount.Location = new System.Drawing.Point(1072, 63);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(450, 30);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "Giảm giá: 0 ₫";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtotal.Location = new System.Drawing.Point(1072, 20);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(450, 30);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Tạm tính: 0 ₫";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelProducts
            // 
            this.panelProducts.Controls.Add(this.dgvProducts);
            this.panelProducts.Controls.Add(this.lblProductsTitle);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(30, 150);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(1680, 566);
            this.panelProducts.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeight = 45;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colQuantity,
            this.colUnitPrice,
            this.colTotalPrice});
            this.dgvProducts.Location = new System.Drawing.Point(0, 53);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 50;
            this.dgvProducts.Size = new System.Drawing.Size(1680, 282);
            this.dgvProducts.TabIndex = 1;
            // 
            // colProductName
            // 
            this.colProductName.FillWeight = 40F;
            this.colProductName.HeaderText = "Tên sản phẩm";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.FillWeight = 20F;
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FillWeight = 20F;
            this.colUnitPrice.HeaderText = "Đơn giá";
            this.colUnitPrice.MinimumWidth = 6;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.FillWeight = 20F;
            this.colTotalPrice.HeaderText = "Thành tiền";
            this.colTotalPrice.MinimumWidth = 6;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.ReadOnly = true;
            // 
            // lblProductsTitle
            // 
            this.lblProductsTitle.AutoSize = true;
            this.lblProductsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblProductsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblProductsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblProductsTitle.Name = "lblProductsTitle";
            this.lblProductsTitle.Padding = new System.Windows.Forms.Padding(20, 15, 0, 15);
            this.lblProductsTitle.Size = new System.Drawing.Size(214, 60);
            this.lblProductsTitle.TabIndex = 0;
            this.lblProductsTitle.Text = "Chi tiết sản phẩm";
            // 
            // panelInvoiceInfo
            // 
            this.panelInvoiceInfo.Controls.Add(this.lblStatus);
            this.panelInvoiceInfo.Controls.Add(this.lblEmployee);
            this.panelInvoiceInfo.Controls.Add(this.lblInvoiceDate);
            this.panelInvoiceInfo.Controls.Add(this.lblInvoiceTitle);
            this.panelInvoiceInfo.Controls.Add(this.lblCustomerName);
            this.panelInvoiceInfo.Controls.Add(this.lblCustomerPhone);
            this.panelInvoiceInfo.Controls.Add(this.lblCustomerEmail);
            this.panelInvoiceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInvoiceInfo.Location = new System.Drawing.Point(30, 30);
            this.panelInvoiceInfo.Name = "panelInvoiceInfo";
            this.panelInvoiceInfo.Size = new System.Drawing.Size(1680, 120);
            this.panelInvoiceInfo.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblStatus.Location = new System.Drawing.Point(1450, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.lblStatus.Size = new System.Drawing.Size(189, 44);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Chờ thanh toán";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEmployee.Location = new System.Drawing.Point(20, 85);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(227, 25);
            this.lblEmployee.TabIndex = 2;
            this.lblEmployee.Text = "Nhân viên: Nguyễn Văn A";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblInvoiceDate.Location = new System.Drawing.Point(20, 55);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(264, 25);
            this.lblInvoiceDate.TabIndex = 1;
            this.lblInvoiceDate.Text = "Ngày tạo: 18/11/2025 14:30:00";
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.AutoSize = true;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblInvoiceTitle.Location = new System.Drawing.Point(20, 15);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(271, 32);
            this.lblInvoiceTitle.TabIndex = 0;
            this.lblInvoiceTitle.Text = "Mã hóa đơn: HD00001";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCustomerName.Location = new System.Drawing.Point(400, 15);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(177, 25);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Tên khách hàng: ---";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCustomerPhone.Location = new System.Drawing.Point(400, 55);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(78, 25);
            this.lblCustomerPhone.TabIndex = 5;
            this.lblCustomerPhone.Text = "SĐT: ---";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCustomerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCustomerEmail.Location = new System.Drawing.Point(400, 85);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(91, 25);
            this.lblCustomerEmail.TabIndex = 6;
            this.lblCustomerEmail.Text = "Email: ---";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.picSuccess);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(30, 30);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1740, 94);
            this.panelHeader.TabIndex = 0;
            // 
            // picSuccess
            // 
            this.picSuccess.Location = new System.Drawing.Point(650, 30);
            this.picSuccess.Name = "picSuccess";
            this.picSuccess.Size = new System.Drawing.Size(60, 60);
            this.picSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSuccess.TabIndex = 1;
            this.picSuccess.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblTitle.Location = new System.Drawing.Point(720, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(588, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TẠO HÓA ĐƠN THÀNH CÔNG";
            // 
            // parrotBtn_printInvoice
            // 
            this.parrotBtn_printInvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.parrotBtn_printInvoice.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotBtn_printInvoice.ButtonImage")));
            this.parrotBtn_printInvoice.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotBtn_printInvoice.ButtonText = "In hóa đơn";
            this.parrotBtn_printInvoice.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.parrotBtn_printInvoice.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.parrotBtn_printInvoice.CornerRadius = 5;
            this.parrotBtn_printInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotBtn_printInvoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotBtn_printInvoice.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotBtn_printInvoice.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.parrotBtn_printInvoice.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.parrotBtn_printInvoice.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotBtn_printInvoice.Location = new System.Drawing.Point(1453, 10);
            this.parrotBtn_printInvoice.Name = "parrotBtn_printInvoice";
            this.parrotBtn_printInvoice.Size = new System.Drawing.Size(200, 50);
            this.parrotBtn_printInvoice.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotBtn_printInvoice.TabIndex = 3;
            this.parrotBtn_printInvoice.TextColor = System.Drawing.Color.DodgerBlue;
            this.parrotBtn_printInvoice.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotBtn_printInvoice.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotBtn_printInvoice.Click += new System.EventHandler(this.parrotBtn_printInvoice_Click);
            // 
            // ProductPaymentInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "ProductPaymentInfor";
            this.Size = new System.Drawing.Size(1800, 900);
            this.panelMain.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelSummary.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            this.panelProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelInvoiceInfo.ResumeLayout(false);
            this.panelInvoiceInfo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picSuccess;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelInvoiceInfo;
        private System.Windows.Forms.Label lblInvoiceTitle;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panelButtons;
        private ReaLTaiizor.Controls.ParrotButton btnPay;
        private ReaLTaiizor.Controls.ParrotButton btnBack;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerEmail;
        private ReaLTaiizor.Controls.ParrotButton parrotbtn_payCash;
        private ReaLTaiizor.Controls.ParrotButton parrotBtn_printInvoice;
    }
}