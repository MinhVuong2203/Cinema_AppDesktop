using System.Drawing;
using System.Windows.Forms;

namespace UI.EmployeeSale
{
    partial class TicketPaymentInfo
    {
        private System.ComponentModel.IContainer components = null;

        // Panels
        private Panel panelHeader;
        private Panel panelCustomer;
        private Panel panelTickets;
        private Panel panelProducts;
        private Panel panelTotal;

        // Header controls
        private Label lblTitle;
        private Label lblInvoiceCodeLabel;
        private Label lblInvoiceCode;
        private Label lblInvoiceDateLabel;
        private Label lblInvoiceDate;
        private Label lblEmployeeLabel;
        private Label lblEmployee;
        private Label lblStatusLabel;
        private Label lblStatus;

        // Customer controls
        private Label lblCustomerTitle;
        private Label lblCustomerNameLabel;
        private Label lblCustomerName;
        private Label lblCustomerPhoneLabel;
        private Label lblCustomerPhone;
        private Label lblCustomerEmailLabel;
        private Label lblCustomerEmail;

        // Tickets controls
        private Label lblTicketsTitle;
        private DataGridView dgvTickets;
        private Label lblTicketTotalLabel;
        private Label lblTicketTotal;

        // Products controls
        private Label lblProductsTitle;
        private DataGridView dgvProducts;
        private Label lblProductTotalLabel;
        private Label lblProductTotal;

        // Total controls
        private Label lblSubtotalLabel;
        private Label lblSubtotal;
        private Label lblDiscountLabel;
        private Label lblDiscount;
        private Label lblGrandTotalLabel;
        private Label lblGrandTotal;

        // Buttons
        private Button btnBack;
        private Button btnPayOS;

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
            this.colMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInvoiceCodeLabel = new System.Windows.Forms.Label();
            this.lblInvoiceCode = new System.Windows.Forms.Label();
            this.lblInvoiceDateLabel = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblEmployeeLabel = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerPhoneLabel = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerEmailLabel = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.panelTickets = new System.Windows.Forms.Panel();
            this.lblTicketsTitle = new System.Windows.Forms.Label();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.lblTicketTotalLabel = new System.Windows.Forms.Label();
            this.lblTicketTotal = new System.Windows.Forms.Label();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblProductTotalLabel = new System.Windows.Forms.Label();
            this.lblProductTotal = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblSubtotalLabel = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountLabel = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblGrandTotalLabel = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPayOS = new System.Windows.Forms.Button();
            this.btn_payCash = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // colMovie
            // 
            this.colMovie.HeaderText = "Phim";
            this.colMovie.MinimumWidth = 6;
            this.colMovie.Name = "colMovie";
            this.colMovie.ReadOnly = true;
            // 
            // colSeat
            // 
            this.colSeat.HeaderText = "Ghế";
            this.colSeat.MinimumWidth = 6;
            this.colSeat.Name = "colSeat";
            this.colSeat.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Loại";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "Sản phẩm";
            this.colProduct.MinimumWidth = 6;
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "SL";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "Đơn giá";
            this.colUnitPrice.MinimumWidth = 6;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Thành tiền";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblInvoiceCodeLabel);
            this.panelHeader.Controls.Add(this.lblInvoiceCode);
            this.panelHeader.Controls.Add(this.lblInvoiceDateLabel);
            this.panelHeader.Controls.Add(this.lblInvoiceDate);
            this.panelHeader.Controls.Add(this.lblEmployeeLabel);
            this.panelHeader.Controls.Add(this.lblEmployee);
            this.panelHeader.Controls.Add(this.lblStatusLabel);
            this.panelHeader.Controls.Add(this.lblStatus);
            this.panelHeader.Location = new System.Drawing.Point(20, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1587, 150);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // lblInvoiceCodeLabel
            // 
            this.lblInvoiceCodeLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInvoiceCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblInvoiceCodeLabel.Location = new System.Drawing.Point(20, 65);
            this.lblInvoiceCodeLabel.Name = "lblInvoiceCodeLabel";
            this.lblInvoiceCodeLabel.Size = new System.Drawing.Size(120, 25);
            this.lblInvoiceCodeLabel.TabIndex = 1;
            this.lblInvoiceCodeLabel.Text = "Mã hóa đơn:";
            // 
            // lblInvoiceCode
            // 
            this.lblInvoiceCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblInvoiceCode.Location = new System.Drawing.Point(150, 65);
            this.lblInvoiceCode.Name = "lblInvoiceCode";
            this.lblInvoiceCode.Size = new System.Drawing.Size(200, 25);
            this.lblInvoiceCode.TabIndex = 2;
            this.lblInvoiceCode.Text = "---";
            // 
            // lblInvoiceDateLabel
            // 
            this.lblInvoiceDateLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInvoiceDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblInvoiceDateLabel.Location = new System.Drawing.Point(20, 100);
            this.lblInvoiceDateLabel.Name = "lblInvoiceDateLabel";
            this.lblInvoiceDateLabel.Size = new System.Drawing.Size(120, 25);
            this.lblInvoiceDateLabel.TabIndex = 3;
            this.lblInvoiceDateLabel.Text = "Ngày tạo:";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblInvoiceDate.Location = new System.Drawing.Point(150, 100);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(200, 25);
            this.lblInvoiceDate.TabIndex = 4;
            this.lblInvoiceDate.Text = "---";
            // 
            // lblEmployeeLabel
            // 
            this.lblEmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmployeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEmployeeLabel.Location = new System.Drawing.Point(800, 65);
            this.lblEmployeeLabel.Name = "lblEmployeeLabel";
            this.lblEmployeeLabel.Size = new System.Drawing.Size(120, 25);
            this.lblEmployeeLabel.TabIndex = 5;
            this.lblEmployeeLabel.Text = "Nhân viên:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblEmployee.Location = new System.Drawing.Point(930, 65);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(250, 25);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "---";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblStatusLabel.Location = new System.Drawing.Point(800, 100);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(120, 25);
            this.lblStatusLabel.TabIndex = 7;
            this.lblStatusLabel.Text = "Trạng thái:";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.LightGray;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(930, 95);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(150, 35);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "---";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.White;
            this.panelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomer.Controls.Add(this.lblCustomerTitle);
            this.panelCustomer.Controls.Add(this.lblCustomerNameLabel);
            this.panelCustomer.Controls.Add(this.lblCustomerName);
            this.panelCustomer.Controls.Add(this.lblCustomerPhoneLabel);
            this.panelCustomer.Controls.Add(this.lblCustomerPhone);
            this.panelCustomer.Controls.Add(this.lblCustomerEmailLabel);
            this.panelCustomer.Controls.Add(this.lblCustomerEmail);
            this.panelCustomer.Location = new System.Drawing.Point(20, 190);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(781, 150);
            this.panelCustomer.TabIndex = 1;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCustomerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblCustomerTitle.Location = new System.Drawing.Point(20, 15);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(350, 30);
            this.lblCustomerTitle.TabIndex = 0;
            this.lblCustomerTitle.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(20, 60);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(150, 25);
            this.lblCustomerNameLabel.TabIndex = 1;
            this.lblCustomerNameLabel.Text = "Tên khách hàng:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblCustomerName.Location = new System.Drawing.Point(180, 60);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(350, 25);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "---";
            // 
            // lblCustomerPhoneLabel
            // 
            this.lblCustomerPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCustomerPhoneLabel.Location = new System.Drawing.Point(20, 90);
            this.lblCustomerPhoneLabel.Name = "lblCustomerPhoneLabel";
            this.lblCustomerPhoneLabel.Size = new System.Drawing.Size(150, 25);
            this.lblCustomerPhoneLabel.TabIndex = 3;
            this.lblCustomerPhoneLabel.Text = "Số điện thoại:";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblCustomerPhone.Location = new System.Drawing.Point(180, 90);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(350, 25);
            this.lblCustomerPhone.TabIndex = 4;
            this.lblCustomerPhone.Text = "---";
            // 
            // lblCustomerEmailLabel
            // 
            this.lblCustomerEmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblCustomerEmailLabel.Location = new System.Drawing.Point(20, 120);
            this.lblCustomerEmailLabel.Name = "lblCustomerEmailLabel";
            this.lblCustomerEmailLabel.Size = new System.Drawing.Size(150, 25);
            this.lblCustomerEmailLabel.TabIndex = 5;
            this.lblCustomerEmailLabel.Text = "Email:";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblCustomerEmail.Location = new System.Drawing.Point(180, 120);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(350, 25);
            this.lblCustomerEmail.TabIndex = 6;
            this.lblCustomerEmail.Text = "---";
            // 
            // panelTickets
            // 
            this.panelTickets.BackColor = System.Drawing.Color.White;
            this.panelTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTickets.Controls.Add(this.lblTicketsTitle);
            this.panelTickets.Controls.Add(this.dgvTickets);
            this.panelTickets.Controls.Add(this.lblTicketTotalLabel);
            this.panelTickets.Controls.Add(this.lblTicketTotal);
            this.panelTickets.Location = new System.Drawing.Point(20, 360);
            this.panelTickets.Name = "panelTickets";
            this.panelTickets.Size = new System.Drawing.Size(781, 350);
            this.panelTickets.TabIndex = 2;
            // 
            // lblTicketsTitle
            // 
            this.lblTicketsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTicketsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTicketsTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTicketsTitle.Name = "lblTicketsTitle";
            this.lblTicketsTitle.Size = new System.Drawing.Size(250, 30);
            this.lblTicketsTitle.TabIndex = 0;
            this.lblTicketsTitle.Text = "THÔNG TIN VÉ";
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.BackgroundColor = System.Drawing.Color.White;
            this.dgvTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMovie,
            this.colSeat,
            this.colType,
            this.colPrice});
            this.dgvTickets.Location = new System.Drawing.Point(20, 60);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.RowHeadersVisible = false;
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.Size = new System.Drawing.Size(745, 230);
            this.dgvTickets.TabIndex = 1;
            // 
            // lblTicketTotalLabel
            // 
            this.lblTicketTotalLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTicketTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTicketTotalLabel.Location = new System.Drawing.Point(20, 305);
            this.lblTicketTotalLabel.Name = "lblTicketTotalLabel";
            this.lblTicketTotalLabel.Size = new System.Drawing.Size(314, 25);
            this.lblTicketTotalLabel.TabIndex = 2;
            this.lblTicketTotalLabel.Text = "Tổng tiền vé:";
            // 
            // lblTicketTotal
            // 
            this.lblTicketTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTicketTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTicketTotal.Location = new System.Drawing.Point(453, 305);
            this.lblTicketTotal.Name = "lblTicketTotal";
            this.lblTicketTotal.Size = new System.Drawing.Size(312, 25);
            this.lblTicketTotal.TabIndex = 3;
            this.lblTicketTotal.Text = "0 ₫";
            this.lblTicketTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelProducts
            // 
            this.panelProducts.BackColor = System.Drawing.Color.White;
            this.panelProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProducts.Controls.Add(this.lblProductsTitle);
            this.panelProducts.Controls.Add(this.dgvProducts);
            this.panelProducts.Controls.Add(this.lblProductTotalLabel);
            this.panelProducts.Controls.Add(this.lblProductTotal);
            this.panelProducts.Location = new System.Drawing.Point(824, 190);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(779, 377);
            this.panelProducts.TabIndex = 3;
            // 
            // lblProductsTitle
            // 
            this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProductsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblProductsTitle.Location = new System.Drawing.Point(20, 15);
            this.lblProductsTitle.Name = "lblProductsTitle";
            this.lblProductsTitle.Size = new System.Drawing.Size(300, 30);
            this.lblProductsTitle.TabIndex = 0;
            this.lblProductsTitle.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduct,
            this.colQty,
            this.colUnitPrice,
            this.colTotal});
            this.dgvProducts.Location = new System.Drawing.Point(20, 60);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(728, 195);
            this.dgvProducts.TabIndex = 1;
            // 
            // lblProductTotalLabel
            // 
            this.lblProductTotalLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblProductTotalLabel.Location = new System.Drawing.Point(20, 322);
            this.lblProductTotalLabel.Name = "lblProductTotalLabel";
            this.lblProductTotalLabel.Size = new System.Drawing.Size(221, 25);
            this.lblProductTotalLabel.TabIndex = 2;
            this.lblProductTotalLabel.Text = "Tổng tiền sản phẩm:";
            // 
            // lblProductTotal
            // 
            this.lblProductTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblProductTotal.Location = new System.Drawing.Point(538, 322);
            this.lblProductTotal.Name = "lblProductTotal";
            this.lblProductTotal.Size = new System.Drawing.Size(210, 25);
            this.lblProductTotal.TabIndex = 3;
            this.lblProductTotal.Text = "0 ₫";
            this.lblProductTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.panelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotal.Controls.Add(this.lblSubtotalLabel);
            this.panelTotal.Controls.Add(this.lblSubtotal);
            this.panelTotal.Controls.Add(this.lblDiscountLabel);
            this.panelTotal.Controls.Add(this.lblDiscount);
            this.panelTotal.Controls.Add(this.lblGrandTotalLabel);
            this.panelTotal.Controls.Add(this.lblGrandTotal);
            this.panelTotal.Location = new System.Drawing.Point(824, 590);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(779, 120);
            this.panelTotal.TabIndex = 4;
            // 
            // lblSubtotalLabel
            // 
            this.lblSubtotalLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblSubtotalLabel.Location = new System.Drawing.Point(30, 12);
            this.lblSubtotalLabel.Name = "lblSubtotalLabel";
            this.lblSubtotalLabel.Size = new System.Drawing.Size(100, 25);
            this.lblSubtotalLabel.TabIndex = 0;
            this.lblSubtotalLabel.Text = "Tạm tính:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblSubtotal.Location = new System.Drawing.Point(598, 12);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(150, 25);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "0 ₫";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDiscountLabel
            // 
            this.lblDiscountLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDiscountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblDiscountLabel.Location = new System.Drawing.Point(30, 42);
            this.lblDiscountLabel.Name = "lblDiscountLabel";
            this.lblDiscountLabel.Size = new System.Drawing.Size(100, 25);
            this.lblDiscountLabel.TabIndex = 2;
            this.lblDiscountLabel.Text = "Giảm giá:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDiscount.Location = new System.Drawing.Point(598, 42);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(150, 25);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "0 ₫";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGrandTotalLabel
            // 
            this.lblGrandTotalLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblGrandTotalLabel.Location = new System.Drawing.Point(30, 77);
            this.lblGrandTotalLabel.Name = "lblGrandTotalLabel";
            this.lblGrandTotalLabel.Size = new System.Drawing.Size(150, 30);
            this.lblGrandTotalLabel.TabIndex = 4;
            this.lblGrandTotalLabel.Text = "TỔNG CỘNG:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(598, 77);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(150, 30);
            this.lblGrandTotal.TabIndex = 5;
            this.lblGrandTotal.Text = "0 ₫";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 730);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 50);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "← Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnPayOS
            // 
            this.btnPayOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnPayOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayOS.FlatAppearance.BorderSize = 0;
            this.btnPayOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayOS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPayOS.ForeColor = System.Drawing.Color.White;
            this.btnPayOS.Location = new System.Drawing.Point(1256, 719);
            this.btnPayOS.Name = "btnPayOS";
            this.btnPayOS.Size = new System.Drawing.Size(257, 50);
            this.btnPayOS.TabIndex = 6;
            this.btnPayOS.Text = "💳 Thanh toán PayOS";
            this.btnPayOS.UseVisualStyleBackColor = false;
            this.btnPayOS.Click += new System.EventHandler(this.btnPayOS_Click);
            // 
            // btn_payCash
            // 
            this.btn_payCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btn_payCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_payCash.FlatAppearance.BorderSize = 0;
            this.btn_payCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payCash.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_payCash.ForeColor = System.Drawing.Color.White;
            this.btn_payCash.Location = new System.Drawing.Point(960, 719);
            this.btn_payCash.Name = "btn_payCash";
            this.btn_payCash.Size = new System.Drawing.Size(249, 50);
            this.btn_payCash.TabIndex = 6;
            this.btn_payCash.Text = "💳 Thanh toán tiền mặt";
            this.btn_payCash.UseVisualStyleBackColor = false;
            this.btn_payCash.Click += new System.EventHandler(this.btn_payCash_Click);
            // 
            // TicketPaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelTickets);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_payCash);
            this.Controls.Add(this.btnPayOS);
            this.Name = "TicketPaymentInfo";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1630, 800);
            this.panelHeader.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panelTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.panelProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelTotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DataGridViewTextBoxColumn colMovie;
        private DataGridViewTextBoxColumn colSeat;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colTotal;
        private Button btn_payCash;
    }
}