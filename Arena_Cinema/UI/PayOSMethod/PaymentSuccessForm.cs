using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using UI.EmployeeSale;
using UI.Helpers;

namespace UI.PayOSMethod
{
    public partial class PaymentSuccessForm : Form
    {
        private CinemaDBContext _context;
        private Guid _invoiceID;
        private Home _home;
        private DTO.Employee _employee;

        public PaymentSuccessForm(Guid invoiceID, Home home, DTO.Employee employee)
        {
            InitializeComponent();
            _context = new CinemaDBContext();
            _invoiceID = invoiceID;
            _home = home;
            _employee = employee;

            //InitializeUI();
            ProcessPaymentSuccess();
        }

        private void InitializeUI()
        {
            this.Text = "Thanh toán thành công";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 253, 244);

            // Icon success
            PictureBox iconSuccess = new PictureBox
            {
                Size = new Size(80, 80),
                Location = new Point(210, 30),
                SizeMode = PictureBoxSizeMode.CenterImage
            };
            // Có thể set icon từ resources
            this.Controls.Add(iconSuccess);

            // Label "Thanh toán thành công!"
            Label lblTitle = new Label
            {
                Text = "✓ Thanh toán thành công!",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(22, 163, 74),
                AutoSize = true,
                Location = new Point(120, 130)
            };
            this.Controls.Add(lblTitle);

            // Label thông tin
            Label lblInfo = new Label
            {
                Text = "Hóa đơn của bạn đã được thanh toán.\nVé đã được kích hoạt.",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(31, 41, 55),
                AutoSize = true,
                Location = new Point(120, 180),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblInfo);

            // Button "Xem hóa đơn"
            Button btnViewInvoice = new Button
            {
                Text = "Xem hóa đơn",
                Size = new Size(150, 45),
                Location = new Point(90, 260),
                BackColor = Color.FromArgb(59, 130, 246),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnViewInvoice.Click += BtnViewInvoice_Click;
            this.Controls.Add(btnViewInvoice);

            // Button "In hóa đơn"
            Button btnPrintInvoice = new Button
            {
                Text = "In hóa đơn",
                Size = new Size(150, 45),
                Location = new Point(180, 320),
                BackColor = Color.FromArgb(22, 163, 74),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnPrintInvoice.Click += BtnPrintInvoice_Click;
            this.Controls.Add(btnPrintInvoice);

            // Button "Về trang chủ"
            Button btnHome = new Button
            {
                Text = "Về trang chủ",
                Size = new Size(150, 45),
                Location = new Point(260, 260),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(59, 130, 246),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            btnHome.Click += BtnHome_Click;
            this.Controls.Add(btnHome);
        }

        private void ProcessPaymentSuccess()
        {
            try
            {
                var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID);
                if (invoice == null) return;

                // Chỉ hiển thị thông tin, không update gì thêm
                Console.WriteLine($"✅ Displaying success for Invoice: {_invoiceID}");
                Console.WriteLine($"Status: {invoice.Status}");

                //// Cập nhật trạng thái hóa đơn
                //invoice.Status = "Đã thanh toán";
                ////invoice.PaymentMethod = "PayOS";
                ////invoice.PaymentDate = DateTime.Now;

                //// Cập nhật trạng thái vé nếu có
                //var invoiceTickets = _context.InvoiceTickets
                //    .Where(it => it.InvoiceID == _invoiceID)
                //    .ToList();

                //if (invoiceTickets.Any())
                //{
                //    var ticketIds = invoiceTickets.Select(it => it.TicketID).ToList();
                //    var tickets = _context.Tickets.Where(t => ticketIds.Contains(t.TicketID)).ToList();

                //    foreach (var ticket in tickets)
                //    {
                //        ticket.Status = "Đã bán";
                //    }
                //}

                //_context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật trạng thái: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPrintInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                var printHelper = new InvoicePrintHelper(_invoiceID);
                printHelper.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi in hóa đơn: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnViewInvoice_Click(object sender, EventArgs e)
        {
            this.Close();
            // Chuyển đến trang xem hóa đơn
            if (_home != null)
            {
                _home.LoadControl(new EmployeeSale.TicketPaymentInfo(_invoiceID, _employee, _home));
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            if (_home != null)
            {
                _home.LoadControl(new SaleHomeUC(_home, _employee));
            }
        }

        private void parrotButton_home_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new SaleHomeUC(_home, _employee));
        }
    }
}
