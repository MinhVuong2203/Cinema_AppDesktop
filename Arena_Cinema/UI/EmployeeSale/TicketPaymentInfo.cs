using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using UI.Helpers;
using UI.PayOSMethod.Services;

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

        private int? _selectedVoucherID;
        private decimal _originalTotal; // Tổng tiền gốc trước khi giảm
        private decimal _discountAmount; // Số tiền được giảm


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

            //hiển thị điểm của khách hàng
            lblCustomerPoints.Text = invoice.Customer != null && !invoice.Customer.IsDeleted
                ? (invoice.Customer.Point?.ToString("N0") ?? "0") + " điểm"
                : "0 điểm";

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
            _originalTotal = ticketTotal + productTotal;
            _discountAmount = invoice.Discount ?? 0;
            decimal finalTotal = _originalTotal - _discountAmount;


            lblSubtotal.Text = _originalTotal.ToString("#,##0") + " ₫";
            lblDiscount.Text = _discountAmount.ToString("#,##0") + " ₫";
            lblGrandTotal.Text = finalTotal.ToString("#,##0") + " ₫";

            LoadAppliedVoucher();
        }

        private void LoadAppliedVoucher()
        {
            var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID);
            if (invoice == null) return;

            // Kiểm tra xem có voucher nào đã được áp dụng chưa
            var appliedVoucher = _context.CustomerVouchers
                .Where(cv => cv.InvoiceID == _invoiceID && !cv.IsDeleted)
                .Select(cv => cv.Voucher)
                .FirstOrDefault();

            if (appliedVoucher != null)
            {
                lblVoucherName.Text = appliedVoucher.VoucherName;
                lblVoucherName.ForeColor = Color.FromArgb(22, 163, 74);
                btnSelectVoucher.Text = "🔄 Đổi voucher";
                btnRemoveVoucher.Visible = true;
                _selectedVoucherID = appliedVoucher.VoucherID;
            }
            else
            {
                lblVoucherName.Text = "Chưa chọn voucher";
                lblVoucherName.ForeColor = Color.FromArgb(107, 114, 128);
                btnSelectVoucher.Text = "🎫 Chọn voucher";
                btnRemoveVoucher.Visible = false;
                _selectedVoucherID = null;
            }
        }

        private void btnSelectVoucher_Click(object sender, EventArgs e)
        {
            var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID);
            if (invoice == null || invoice.Status != "Chờ thanh toán")
            {
                MessageBox.Show("Chỉ có thể chọn voucher cho hóa đơn đang chờ thanh toán!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form chọn voucher
            var voucherForm = new Form
            {
                Text = "Chọn Voucher",
                Size = new Size(850, 700),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            var voucherSelection = new Voucher.VoucherSelectionUC();
            voucherSelection.Dock = DockStyle.Fill;

            // Load vouchers với tổng tiền hiện tại
            voucherSelection.LoadVouchers(_originalTotal, invoice.CustomerID, _employee.EmployeeID);

            // Subscribe to event
            voucherSelection.VoucherSelected += (s, args) =>
            {
                if (args.CustomerVoucherID.HasValue)
                {
                    //ApplyVoucher(args.CustomerVoucherID.HasValue);
                    ApplyVoucherFromCustomerVoucher(args.CustomerVoucherID.Value);
                }
                else
                {
                    RemoveVoucher();
                }
            };

            voucherForm.Controls.Add(voucherSelection);
            voucherForm.ShowDialog(this);
        }

        private void ApplyVoucherFromCustomerVoucher(Guid customerVoucherID)
        {
            try
            {
                var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID);
                if (invoice == null) return;

                // Lấy thông tin CustomerVoucher
                var customerVoucher = _context.CustomerVouchers
                    .FirstOrDefault(cv => cv.CustomerVoucherID == customerVoucherID && !cv.IsDeleted);

                if (customerVoucher == null || customerVoucher.Status != "Chưa sử dụng")
                {
                    MessageBox.Show("Voucher không hợp lệ hoặc đã được sử dụng!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var voucher = _context.Vouchers.FirstOrDefault(v => v.VoucherID == customerVoucher.VoucherID && !v.IsDeleted);
                if (voucher == null)
                {
                    MessageBox.Show("Voucher không tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra điều kiện áp dụng
                if (_originalTotal < voucher.MinOrderAmount)
                {
                    MessageBox.Show(
                        $"Đơn hàng chưa đủ điều kiện áp dụng voucher!\n\n" +
                        $"Yêu cầu tối thiểu: {voucher.MinOrderAmount:N0} ₫\n" +
                        $"Tổng đơn hiện tại: {_originalTotal:N0} ₫",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Tính discount
                decimal discount = 0;
                if (voucher.DiscountType == "Phần trăm")
                {
                    discount = _originalTotal * (voucher.DiscountValue / 100m);
                    if (voucher.MaxDiscountAmount.HasValue && voucher.MaxDiscountAmount.Value > 0)
                    {
                        discount = Math.Min(discount, voucher.MaxDiscountAmount.Value);
                    }
                }
                else
                {
                    discount = voucher.DiscountValue;
                }

                discount = Math.Min(discount, _originalTotal);

                // ✅ Cập nhật CustomerVoucher: Link với Invoice
                customerVoucher.InvoiceID = _invoiceID;
                customerVoucher.Status = "Đã sử dụng";
                customerVoucher.UsedDate = DateTime.Now;

                // Cập nhật invoice
                invoice.Discount = discount;
                invoice.TotalAmount = _originalTotal - discount;

                _context.SaveChanges();

                // Cập nhật UI
                _selectedVoucherID = voucher.VoucherID;
                _discountAmount = discount;

                lblDiscount.Text = discount.ToString("#,##0") + " ₫";
                lblGrandTotal.Text = invoice.TotalAmount?.ToString("#,##0") + " ₫";

                LoadAppliedVoucher();

                MessageBox.Show(
                    $"Áp dụng voucher thành công!\n\n" +
                    $"Voucher: {voucher.VoucherName}\n" +
                    $"Đã giảm: {discount:N0} ₫",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi áp dụng voucher: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //THÊM: Áp dụng voucher
        private void ApplyVoucher(int voucherID)
        {
            try
            {
                var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID);
                if (invoice == null) return;

                var voucher = _context.Vouchers.FirstOrDefault(v => v.VoucherID == voucherID && !v.IsDeleted);
                if (voucher == null)
                {
                    MessageBox.Show("Voucher không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tính discount
                decimal discount = 0;
                if (voucher.DiscountType == "Phần trăm")
                {
                    discount = _originalTotal * (voucher.DiscountValue / 100m);
                    if (voucher.MaxDiscountAmount.HasValue && voucher.MaxDiscountAmount.Value > 0)
                    {
                        discount = Math.Min(discount, voucher.MaxDiscountAmount.Value);
                    }
                }
                else
                {
                    discount = voucher.DiscountValue;
                }

                discount = Math.Min(discount, _originalTotal);

                // Cập nhật invoice
                invoice.Discount = discount;
                invoice.TotalAmount = _originalTotal - discount;

                _context.SaveChanges();

                // Cập nhật UI
                _selectedVoucherID = voucherID;
                _discountAmount = discount;

                lblDiscount.Text = discount.ToString("#,##0") + " ₫";
                lblGrandTotal.Text = invoice.TotalAmount?.ToString("#,##0") + " ₫";

                LoadAppliedVoucher();

                MessageBox.Show($"Áp dụng voucher thành công!\nĐã giảm: {discount:N0} ₫",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi áp dụng voucher: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //THÊM: Xóa voucher
        private void btnRemoveVoucher_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc muốn bỏ voucher này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                RemoveVoucher();
            }
        }

        private void RemoveVoucher()
        {
            try
            {
                var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID);
                if (invoice == null) return;

                // Reset discount
                invoice.Discount = 0;
                invoice.TotalAmount = _originalTotal;

                _context.SaveChanges();

                // Cập nhật UI
                _selectedVoucherID = null;
                _discountAmount = 0;

                lblDiscount.Text = "0 ₫";
                lblGrandTotal.Text = _originalTotal.ToString("#,##0") + " ₫";

                LoadAppliedVoucher();

                MessageBox.Show("Đã bỏ voucher", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi bỏ voucher: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                //_home.LoadControl(new SaleHomeUC(_home, _employee));
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
                Console.WriteLine($"Checking payment status... (Attempt {checkCount}/{maxChecks})");

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

                            LoadInvoiceInfo();

                            var successForm = new PayOSMethod.PaymentSuccessForm(invoiceID, _home, _employee);
                            successForm.ShowDialog();

                            _home.LoadControl(new SaleHomeUC(_home, _employee));
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
                        "Bạn có muốn lưu hóa đơn tạm không?",
                        "Cảnh báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result != DialogResult.Yes)
                    {
                        return;
                    }
                }

                // ✅ SỬ DỤNG PrintManager để lưu PDF
                var printManager = new PrintManager(_invoiceID);
                printManager.SaveInvoiceOnly();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu hóa đơn: {ex.Message}", "Lỗi",
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
                LoadInvoiceInfo();

                var successForm = new UI.PayOSMethod.PaymentSuccessForm(_invoiceID, _home, _employee);
                successForm.ShowDialog();

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