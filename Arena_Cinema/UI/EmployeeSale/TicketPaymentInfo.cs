using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DTO;
using DAL;
using UI.PayOSMethod.Services;

namespace UI.EmployeeSale
{
    public partial class TicketPaymentInfo : UserControl
    {
        private Guid _invoiceID;
        private CinemaDBContext _context;
        private Home _home;
        private DTO.Employee _employee;

        public TicketPaymentInfo(Guid invoiceID)
        {
            InitializeComponent();
            _invoiceID = invoiceID;
            _context = new CinemaDBContext();
            LoadInvoiceInfo();
            CustomizeUI();
        }

        public TicketPaymentInfo(Guid invoiceID, Home home, DTO.Employee employee) : this(invoiceID)
        {
            _home = home;
            _employee = employee;
        }

        private void CustomizeUI()
        {
            // Set background colors
            this.BackColor = Color.FromArgb(249, 250, 251);
            panelHeader.BackColor = Color.White;
            panelCustomer.BackColor = Color.White;
            panelTickets.BackColor = Color.White;
            panelProducts.BackColor = Color.White;
            panelTotal.BackColor = Color.FromArgb(240, 253, 244);
        }

        private void LoadInvoiceInfo()
        {
            var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID && !i.IsDeleted);
            if (invoice == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // === HEADER INFORMATION ===
            lblInvoiceCode.Text = invoice.InvoiceID.ToString().Substring(0, 8).ToUpper();
            lblInvoiceDate.Text = invoice.IssueDate.ToString("dd/MM/yyyy HH:mm:ss") ?? "N/A";
            lblEmployee.Text = invoice.Employee?.FullName ?? "N/A";

            // Status with color
            lblStatus.Text = invoice.Status;
            switch (invoice.Status)
            {
                case "Chờ thanh toán":
                    lblStatus.BackColor = Color.FromArgb(254, 243, 199);
                    lblStatus.ForeColor = Color.FromArgb(180, 83, 9);
                    break;
                case "Đã thanh toán":
                    lblStatus.BackColor = Color.FromArgb(209, 250, 229);
                    lblStatus.ForeColor = Color.FromArgb(22, 163, 74);
                    break;
                case "Đã hủy":
                    lblStatus.BackColor = Color.FromArgb(254, 226, 226);
                    lblStatus.ForeColor = Color.FromArgb(220, 38, 38);
                    break;
            }

            // === CUSTOMER INFORMATION ===
            var customer = invoice.Customer;
            if (customer != null && !customer.IsDeleted)
            {
                lblCustomerName.Text = customer.FullName;
                lblCustomerPhone.Text = customer.Phone ?? "---";
                lblCustomerEmail.Text = customer.Email ?? "---";
            }
            else
            {
                lblCustomerName.Text = "Khách vãng lai";
                lblCustomerPhone.Text = "---";
                lblCustomerEmail.Text = "---";
            }

            // === TICKETS INFORMATION ===
            var invoiceTickets = _context.InvoiceTickets.Where(it => it.InvoiceID == _invoiceID).ToList();
            dgvTickets.Rows.Clear();
            decimal ticketTotal = 0;

            foreach (var it in invoiceTickets)
            {
                var ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == it.TicketID);
                if (ticket != null)
                {
                    var seat = _context.Seats.FirstOrDefault(s => s.SeatID == ticket.SeatID);
                    var showTime = _context.ShowTimes.FirstOrDefault(st => st.ShowTimeID == ticket.ShowTimeID);
                    var movie = showTime != null ? _context.Movies.FirstOrDefault(m => m.MovieID == showTime.MovieID) : null;

                    dgvTickets.Rows.Add(
                        movie?.Title ?? "N/A",
                        seat?.SeatName ?? "N/A",
                        ticket.TicketType ?? "N/A",
                        (ticket.Price ?? 0).ToString("#,##0") + " ₫"
                    );

                    ticketTotal += ticket.Price ?? 0;
                }
            }

            lblTicketTotal.Text = ticketTotal.ToString("#,##0") + " ₫";

            // === PRODUCTS INFORMATION ===
            var invoiceProducts = _context.InvoiceProducts.Where(ip => ip.InvoiceID == _invoiceID).ToList();
            dgvProducts.Rows.Clear();
            decimal productTotal = 0;

            foreach (var ip in invoiceProducts)
            {
                var product = _context.Products.FirstOrDefault(p => p.ProductID == ip.ProductID);
                if (product != null)
                {
                    decimal unitPrice = ip.UnitPrice ?? 0;
                    int quantity = ip.Quantity ?? 0;
                    decimal total = unitPrice * quantity;

                    dgvProducts.Rows.Add(
                        product.ProductName,
                        quantity.ToString(),
                        unitPrice.ToString("#,##0") + " ₫",
                        total.ToString("#,##0") + " ₫"
                    );

                    productTotal += total;
                }
            }

            lblProductTotal.Text = productTotal.ToString("#,##0") + " ₫";

            // === TOTAL ===
            decimal grandTotal = invoice.TotalAmount ?? 0;
            decimal discount = invoice.Discount ?? 0;
            decimal subtotal = grandTotal + discount;

            lblSubtotal.Text = subtotal.ToString("#,##0") + " ₫";
            lblDiscount.Text = discount.ToString("#,##0") + " ₫";
            lblGrandTotal.Text = grandTotal.ToString("#,##0") + " ₫";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_home != null && _employee != null)
            {
                _home.LoadControl(new SaleHomeUC(_home, _employee));
            }
        }

        private async void btnPayOS_Click(object sender, EventArgs e)
        {
            try
            {
                var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID && !i.IsDeleted);
                if (invoice == null || invoice.Status != "Chờ thanh toán")
                {
                    MessageBox.Show("Hóa đơn không hợp lệ hoặc đã thanh toán!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int amount = (int)(invoice.TotalAmount ?? 0);
                if (amount <= 0)
                {
                    MessageBox.Show("Tổng tiền phải lớn hơn 0!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int orderCode = (int)(DateTimeOffset.UtcNow.ToUnixTimeSeconds() % 1000000000);
                string description = $"HD {invoice.InvoiceID.ToString().Substring(0, 8).ToUpper()}";

                var paymentService = new PaymentService();
                string paymentUrl = await paymentService.CreatePaymentLinkAsync(
                    orderCode,
                    amount,
                    description,
                    "https://localhost:3000/success",
                    "https://localhost:3000/cancel"
                );

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = paymentUrl,
                    UseShellExecute = true
                });

                MessageBox.Show($"Đã tạo link thanh toán!\nMã giao dịch: {orderCode}",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo thanh toán:\n{ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng in hóa đơn đang được phát triển!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}