using System;
using System.Linq;
using System.Windows.Forms;
using DTO;
using DAL;

namespace UI.EmployeeSale
{
    public partial class TicketPaymentInfo : UserControl
    {
        private Guid _invoiceID;
        private CinemaDBContext _context;

        public TicketPaymentInfo(Guid invoiceID)
        {
            InitializeComponent();
            _invoiceID = invoiceID;
            _context = new CinemaDBContext();
            LoadInvoiceInfo();
        }

        private void LoadInvoiceInfo()
        {
            var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID && !i.IsDeleted);
            if (invoice == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show basic info
            lblInvoiceID.Text = $"Mã hóa đơn: {invoice.InvoiceID.ToString().Substring(0, 8).ToUpper()}";
            lblEmployee.Text = $"Nhân viên: {invoice.Employee?.FullName}";
            lblDate.Text = $"Ngày tạo: {invoice.IssueDate:dd/MM/yyyy HH:mm:ss}";
            lblStatus.Text = $"Trạng thái: {invoice.Status}";

            // Tickets
            var invoiceTickets = _context.InvoiceTickets.Where(it => it.InvoiceID == _invoiceID).ToList();
            var ticketDetails = string.Join("\n", invoiceTickets.Select(it =>
            {
                var ticket = _context.Tickets.FirstOrDefault(t => t.TicketID == it.TicketID);
                return ticket != null
                    ? $"Ghế: {ticket.Seat?.SeatName}, Loại: {ticket.TicketType}, Giá: {(ticket.Price ?? 0):C0}"
                    : "";
            }));
            lblTickets.Text = "Thông tin vé:\n" + (ticketDetails.Length > 0 ? ticketDetails : "Không có");

            // Products
            var invoiceProducts = _context.InvoiceProducts.Where(ip => ip.InvoiceID == _invoiceID).ToList();
            var productDetails = string.Join("\n", invoiceProducts.Select(ip =>
            {
                var product = _context.Products.FirstOrDefault(p => p.ProductID == ip.ProductID);
                return product != null
                    ? $"{product.ProductName} x{ip.Quantity} - {(ip.UnitPrice ?? 0) * (ip.Quantity ?? 0):C0}"
                    : "";
            }));
            lblProducts.Text = "Thông tin sản phẩm:\n" + (productDetails.Length > 0 ? productDetails : "Không có");

            // Total
            lblTotal.Text = $"Tổng tiền: {(invoice.TotalAmount ?? 0):C0}";
        }
    }
}
