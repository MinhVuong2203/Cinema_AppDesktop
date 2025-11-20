using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DTO;
using DAL;
using UI.PayOSMethod.Services;
using UI.Helpers;
using System.Threading.Tasks;

namespace UI.EmployeeSale
{
    public partial class TicketPaymentInfo : UserControl
    {
        private Guid _invoiceID;
        private CinemaDBContext _context;
        private Home _home;
        private DTO.Employee _employee;
        private long _currentOrderCode = 0;
        private Timer _paymentTimer;

        public TicketPaymentInfo(Guid invoiceID, DTO.Employee employee, Home home)
        {
            InitializeComponent();
            _invoiceID = invoiceID;
            _employee = employee;
            _home = home;
            _context = new CinemaDBContext();
            LoadInvoiceInfo();
            CustomizeUI();
        }

        public TicketPaymentInfo(Guid invoiceID, Home home, DTO.Employee employee) : this(invoiceID, employee, home)
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

        //private async void btnPayOS_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID && !i.IsDeleted);
        //        if (invoice == null || invoice.Status != "Chờ thanh toán")
        //        {
        //            MessageBox.Show("Hóa đơn không hợp lệ hoặc đã thanh toán!", "Lỗi",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        int amount = (int)(invoice.TotalAmount ?? 0);
        //        if (amount <= 0)
        //        {
        //            MessageBox.Show("Tổng tiền phải lớn hơn 0!", "Lỗi",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Tạo orderCode unique và lưu lại
        //        _currentOrderCode = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmssfff"));
        //        string description = $"HD {invoice.InvoiceID.ToString().Substring(0, 8).ToUpper()}";

        //        string baseUrl = "http://localhost:5000";
        //        string returnUrl = $"{baseUrl}/payment/success?invoiceId={_invoiceID}";
        //        string cancelUrl = $"{baseUrl}/payment/cancel?invoiceId={_invoiceID}";

        //        var paymentService = new PaymentService();
        //        string paymentUrl = await paymentService.CreatePaymentLink(
        //            //_invoiceID,
        //            //_currentOrderCode,
        //            _currentOrderCode,
        //            amount,
        //            description,
        //            returnUrl,
        //            cancelUrl
        //        );

        //        // Mở trình duyệt
        //        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        //        {
        //            FileName = paymentUrl,
        //            UseShellExecute = true
        //        });

        //        // Bắt đầu polling
        //        //StartPaymentStatusPolling(_invoiceID);

        //        MessageBox.Show(
        //            $"Đã tạo link thanh toán!\n" +
        //            $"Mã giao dịch: {_currentOrderCode}\n\n" +
        //            $"Vui lòng quét mã QR và thanh toán.\n" +
        //            $"Hệ thống sẽ tự động cập nhật khi thanh toán thành công.",
        //            "Thông báo",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information
        //        );
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi tạo thanh toán:\n{ex.Message}",
        //            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

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

                // ✅ SỬA: orderCode phải là long, dùng timestamp đầy đủ
                long orderCode = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));

                string description = $"HD {invoice.InvoiceID.ToString().Substring(0, 8).ToUpper()}";

                string returnUrl = $"https://localhost:3000/success?invoiceId={_invoiceID}";
                string cancelUrl = $"https://localhost:3000/cancel?invoiceId={_invoiceID}";


                var paymentService = new PaymentService();

                // ✅ SỬA: Thêm await và nhận giá trị trả về
                string paymentUrl = await paymentService.CreatePaymentLink(
                    _invoiceID,
                    orderCode,
                    amount,
                    description,
                    returnUrl,
                    cancelUrl
                );

                // ✅ Mở trình duyệt với URL nhận được
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = paymentUrl,
                    UseShellExecute = true
                });

                //MessageBox.Show($"Đã tạo link thanh toán!\nMã giao dịch: {orderCode}",
                //    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _currentOrderCode = orderCode;
                //StartPaymentStatusPolling(_invoiceID);
                StartPaymentStatusPollingWithAPI(_invoiceID, orderCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo thanh toán:\n{ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartPaymentStatusPolling(Guid invoiceID)
        {
            if (_paymentTimer != null)
            {
                _paymentTimer.Stop();
                _paymentTimer.Dispose();
            }

            _paymentTimer = new System.Windows.Forms.Timer();
            _paymentTimer.Interval = 3000; // Check mỗi 3 giây
            int checkCount = 0;
            int maxChecks = 120; // 120 * 3s = 6 phút

            _paymentTimer.Tick += (s, e) =>
            {
                checkCount++;

                // Refresh context
                _context.Dispose();
                _context = new CinemaDBContext();

                var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == invoiceID);

                if (invoice?.Status == "Đã thanh toán")
                {
                    _paymentTimer.Stop();

                    // ✅ XỬ LÝ THANH TOÁN THÀNH CÔNG
                    var paymentService = new PaymentService();
                    bool success = paymentService.ProcessSuccessPayment(invoiceID, _currentOrderCode, "PayOS");

                    if (success)
                    {
                        MessageBox.Show(
                            "✓ Thanh toán thành công!\n\n" +
                            $"Mã giao dịch: {_currentOrderCode}\n" +
                            "Hóa đơn và vé đã được cập nhật.",
                            "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        var successForm = new UI.PayOSMethod.PaymentSuccessForm(invoiceID, _home, _employee);
                        successForm.ShowDialog();

                        // Reload thông tin hóa đơn
                        LoadInvoiceInfo();
                    }
                }
                else if (checkCount >= maxChecks)
                {
                    _paymentTimer.Stop();
                    MessageBox.Show(
                        "⏱ Hết thời gian chờ thanh toán.\n\n" +
                        "Vui lòng kiểm tra lại trạng thái hóa đơn sau.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            };

            _paymentTimer.Start();
        }

        /// <summary>
        /// ✅ POLLING với PayOS Query API (Không cần webhook)
        /// </summary>
        private void StartPaymentStatusPollingWithAPI(Guid invoiceID, long orderCode)
        {
            if (_paymentTimer != null)
            {
                _paymentTimer.Stop();
                _paymentTimer.Dispose();
            }

            _paymentTimer = new System.Windows.Forms.Timer();
            _paymentTimer.Interval = 5000; // ✅ Check mỗi 5 giây (tránh spam API)
            int checkCount = 0;
            int maxChecks = 60; // 60 * 5s = 5 phút

            _paymentTimer.Tick += async (s, e) =>
            {
                checkCount++;
                Console.WriteLine($"🔄 Checking payment status... (Attempt {checkCount}/{maxChecks})");

                try
                {
                    var paymentService = new PaymentService();

                    // ✅ QUERY PayOS API
                    var result = await paymentService.CheckAndProcessPayment(orderCode);

                    Console.WriteLine($"📊 Status: {result.Status} - {result.Message}");

                    if (result.Status == "PAID" && result.Success)
                    {
                        _paymentTimer.Stop();

                        this.Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show(
                                "✓ Thanh toán thành công!\n\n" +
                                $"Mã giao dịch: {orderCode}\n" +
                                "Hóa đơn và vé đã được cập nhật.",
                                "Thành công",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            var successForm = new PayOSMethod.PaymentSuccessForm(invoiceID, _home, _employee);
                            successForm.ShowDialog();

                            LoadInvoiceInfo();
                        });
                    }
                    else if (result.Status == "CANCELLED")
                    {
                        _paymentTimer.Stop();

                        this.Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show(
                                "❌ Thanh toán đã bị hủy.\n\nVui lòng thử lại.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        });
                    }
                    else if (result.Status == "ERROR")
                    {
                        _paymentTimer.Stop();

                        this.Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show(
                                $"❌ Lỗi kiểm tra thanh toán:\n{result.Message}",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        });
                    }
                    else if (checkCount >= maxChecks)
                    {
                        _paymentTimer.Stop();

                        this.Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show(
                                "⏱ Hết thời gian chờ thanh toán.\n\n" +
                                "Vui lòng kiểm tra lại trạng thái hóa đơn sau.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Polling error: {ex.Message}");

                    if (checkCount >= maxChecks)
                    {
                        _paymentTimer.Stop();
                    }
                }
            };

            _paymentTimer.Start();
            Console.WriteLine("✅ Started payment polling with PayOS Query API");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (_paymentTimer != null)
        //        {
        //            _paymentTimer.Stop();
        //            _paymentTimer.Dispose();
        //        }
        //        _context?.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}


        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem hóa đơn đã thanh toán chưa
                var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID);
                if (invoice == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (invoice.Status != "Đã thanh toán")
                {
                    var result = MessageBox.Show(
                        "Hóa đơn chưa được thanh toán!\n\n" +
                        "Bạn có muốn in hóa đơn tạm không?",
                        "Cảnh báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result != DialogResult.Yes)
                    {
                        return;
                    }
                }

                // Sử dụng InvoicePrintHelper để in
                var printHelper = new InvoicePrintHelper(_invoiceID);
                printHelper.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi in hóa đơn: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //thanh toán tiền mặt
        private void btn_payCash_Click(object sender, EventArgs e)
        {
            var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID && !i.IsDeleted);
            if (invoice == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (invoice.Status == "Đã thanh toán")
            {
                MessageBox.Show("Hóa đơn đã được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xác nhận thanh toán tiền mặt
            var confirmResult = MessageBox.Show(
                $"Xác nhận thanh toán tiền mặt?\n\n" +
                $"Số tiền: {(invoice.TotalAmount ?? 0).ToString("#,##0")} ₫",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // ✅ XỬ LÝ THANH TOÁN TIỀN MẶT VÀ LƯU VÀO PAYMENT
            var paymentService = new PaymentService();
            bool success = paymentService.ProcessCashPayment(_invoiceID);

            if (success)
            {
                MessageBox.Show(
                    "✓ Thanh toán tiền mặt thành công!\n\n" +
                    "Hóa đơn và vé đã được cập nhật.",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Quay về trang chủ
                if (_home != null && _employee != null)
                {
                    _home.LoadControl(new SaleHomeUC(_home, _employee));
                }
            }
            else
            {
                MessageBox.Show("Lỗi khi xử lý thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (_home != null && _employee != null)
            {
                var confirmResult = MessageBox.Show(
                    "Xác nhận hủy hóa đơn này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    // ✅ XỬ LÝ HỦY VÀ LƯU VÀO PAYMENT
                    var paymentService = new PaymentService();
                    bool success = paymentService.ProcessCancelPayment(_invoiceID, "Nhân viên hủy");

                    if (success)
                    {
                        MessageBox.Show("Hóa đơn đã được hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _home.LoadControl(new SaleHomeUC(_home, _employee));
                    }
                }
            }
        }

        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy thanh toán này?",
                "Xác nhận hủy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                var paymentService = new PaymentService();
                bool success = paymentService.ProcessCancelPayment(_invoiceID, "Khách hàng hủy");

                if (success)
                {
                    // Hiển thị giao diện thanh toán bị hủy
                    var cancelForm = new PayOSMethod.PaymentCancelForm(_invoiceID, _home, _employee);
                    cancelForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lỗi khi hủy thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (_paymentTimer != null)
        //        {
        //            _paymentTimer.Stop();
        //            _paymentTimer.Dispose();
        //        }
        //        _context?.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}