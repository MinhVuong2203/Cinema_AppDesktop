using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using DTO;
using UI.PayOSMethod.Services;
using UI.Helpers;

namespace UI.EmployeeSale
{
    public partial class ProductPaymentInfor : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        //private Invoice _invoice;
        private Guid _invoiceID;
        private List<Invoice> _invoices;
        private CinemaDBContext _context;
        private long _currentOrderCode = 0;
        private Timer _paymentTimer;

        public ProductPaymentInfor()
        {
            InitializeComponent();
            _context = new CinemaDBContext();
        }

        public ProductPaymentInfor(Home home, DTO.Employee employee, Guid invoiceID) : this()
        {
            _home = home;
            _employee = employee;
            //_invoice = invoice;
            _invoiceID = invoiceID;

            // Khởi tạo sự kiện
            btnBack.Click += BtnBack_Click;
            //btnPay.Click += BtnPrint_Click;

            // Load thông tin hóa đơn vừa tạo
            LoadLatestInvoices();

            // Tùy chỉnh giao diện DataGridView
            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            // Tùy chỉnh header
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(59, 130, 246);
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tùy chỉnh rows
            dgvProducts.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvProducts.DefaultCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 41, 55);
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);

            // Alignment cho các cột số
            dgvProducts.Columns["colQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.Columns["colUnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns["colTotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void SetCustomerInfo(DTO.Customer customer)
        {
            if (customer != null)
            {
                lblCustomerName.Text = $"Tên khách hàng: {customer.FullName}";
                lblCustomerPhone.Text = $"SĐT: {customer.Phone}";
                lblCustomerEmail.Text = $"Email: {customer.Email}";
            }
            else
            {
                lblCustomerName.Text = "Tên khách hàng: Khách vãng lai";
                lblCustomerPhone.Text = "SĐT: ";
                lblCustomerEmail.Text = "Email: ";
            }
        }

        private void LoadLatestInvoices()
        {
            try
            {
                // Lấy danh sách hóa đơn mới nhất của nhân viên với trạng thái "Chờ thanh toán"
                _invoices = _context.Invoices
                    .Where(i => i.EmployeeID == _employee.EmployeeID &&
                               i.Status == "Chờ thanh toán" &&
                               i.InvoiceID == _invoiceID &&
                               !i.IsDeleted)
                    .OrderByDescending(i => i.IssueDate)
                    .Take(10) // Lấy tối đa 10 hóa đơn gần nhất
                    .ToList();

                if (_invoices.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn nào.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hiển thị thông tin hóa đơn đầu tiên (mới nhất)
                DisplayInvoiceInfo(_invoices[0]);
                LoadInvoiceProducts(_invoices);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin hóa đơn: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayInvoiceInfo(Invoice invoice)
        {
            // Hiển thị mã hóa đơn (8 ký tự đầu của GUID)
            lblInvoiceTitle.Text = $"Mã hóa đơn: {invoice.InvoiceID.ToString().Substring(0, 8).ToUpper()}";

            // Hiển thị ngày tạo
            lblInvoiceDate.Text = $"Ngày tạo: {invoice.IssueDate:dd/MM/yyyy HH:mm:ss}";

            // Hiển thị tên nhân viên
            lblEmployee.Text = $"Nhân viên: {_employee.FullName}";

            // Hiển thị trạng thái
            lblStatus.Text = invoice.Status;

            // Thay đổi màu sắc của label trạng thái dựa trên trạng thái
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
        }

        private void LoadInvoiceProducts(List<Invoice> invoices)
        {
            try
            {
                dgvProducts.Rows.Clear();
                decimal subtotal = 0;
                decimal totalDiscount = 0;

                // Lấy tất cả các sản phẩm từ các hóa đơn
                foreach (var invoice in invoices)
                {
                    var invoiceProducts = _context.InvoiceProducts
                        .Where(ip => ip.InvoiceID == invoice.InvoiceID)
                        .ToList();

                    foreach (var ip in invoiceProducts)
                    {
                        var product = _context.Products.FirstOrDefault(p => p.ProductID == ip.ProductID);

                        if (product != null)
                        {
                            decimal unitPrice = ip.UnitPrice ?? 0;
                            int quantity = ip.Quantity ?? 0;
                            decimal totalPrice = unitPrice * quantity;

                            dgvProducts.Rows.Add(
                                product.ProductName,
                                quantity.ToString(),
                                unitPrice.ToString("#,##0") + " ₫",
                                totalPrice.ToString("#,##0") + " ₫"
                            );

                            subtotal += totalPrice;
                        }
                    }

                    totalDiscount += invoice.Discount ?? 0;
                }

                // Hiển thị tổng kết
                lblSubtotal.Text = $"Tạm tính: {subtotal.ToString("#,##0")} ₫";
                lblDiscount.Text = $"Giảm giá: {totalDiscount.ToString("#,##0")} ₫";
                lblTotal.Text = $"Tổng cộng: {(subtotal - totalDiscount).ToString("#,##0")} ₫";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết sản phẩm: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
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

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo dialog in
                PrintDialog printDialog = new PrintDialog();
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();

                printDocument.PrintPage += (s, ev) =>
                {
                    // Vẽ nội dung hóa đơn
                    Font titleFont = new Font("Segoe UI", 18, FontStyle.Bold);
                    Font headerFont = new Font("Segoe UI", 12, FontStyle.Bold);
                    Font normalFont = new Font("Segoe UI", 10);

                    float yPos = 50;
                    float leftMargin = 50;

                    // Tiêu đề
                    ev.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", titleFont, Brushes.Black, leftMargin, yPos);
                    yPos += 40;

                    // Thông tin hóa đơn
                    ev.Graphics.DrawString(lblInvoiceTitle.Text, normalFont, Brushes.Black, leftMargin, yPos);
                    yPos += 25;
                    ev.Graphics.DrawString(lblInvoiceDate.Text, normalFont, Brushes.Black, leftMargin, yPos);
                    yPos += 25;
                    ev.Graphics.DrawString(lblEmployee.Text, normalFont, Brushes.Black, leftMargin, yPos);
                    yPos += 40;

                    // Header bảng
                    ev.Graphics.DrawString("Sản phẩm", headerFont, Brushes.Black, leftMargin, yPos);
                    ev.Graphics.DrawString("SL", headerFont, Brushes.Black, leftMargin + 300, yPos);
                    ev.Graphics.DrawString("Đơn giá", headerFont, Brushes.Black, leftMargin + 380, yPos);
                    ev.Graphics.DrawString("Thành tiền", headerFont, Brushes.Black, leftMargin + 500, yPos);
                    yPos += 30;

                    // Vẽ đường kẻ
                    ev.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 650, yPos);
                    yPos += 10;

                    // Chi tiết sản phẩm
                    foreach (DataGridViewRow row in dgvProducts.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            ev.Graphics.DrawString(row.Cells[0].Value.ToString(), normalFont, Brushes.Black, leftMargin, yPos);
                            ev.Graphics.DrawString(row.Cells[1].Value.ToString(), normalFont, Brushes.Black, leftMargin + 300, yPos);
                            ev.Graphics.DrawString(row.Cells[2].Value.ToString(), normalFont, Brushes.Black, leftMargin + 380, yPos);
                            ev.Graphics.DrawString(row.Cells[3].Value.ToString(), normalFont, Brushes.Black, leftMargin + 500, yPos);
                            yPos += 25;
                        }
                    }

                    yPos += 20;
                    ev.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 650, yPos);
                    yPos += 20;

                    // Tổng kết
                    ev.Graphics.DrawString(lblSubtotal.Text, normalFont, Brushes.Black, leftMargin + 400, yPos);
                    yPos += 25;
                    ev.Graphics.DrawString(lblDiscount.Text, normalFont, Brushes.Black, leftMargin + 400, yPos);
                    yPos += 30;
                    ev.Graphics.DrawString(lblTotal.Text, headerFont, Brushes.Black, leftMargin + 400, yPos);
                };

                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                    MessageBox.Show("In hóa đơn thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi in hóa đơn: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private async void btnPay_Click(object sender, EventArgs e)
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

        private async void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy hóa đơn hiện tại
                var invoice = _context.Invoices.FirstOrDefault(i => i.InvoiceID == _invoiceID && !i.IsDeleted);
                if (invoice == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra trạng thái hóa đơn
                if (invoice.Status != "Chờ thanh toán")
                {
                    MessageBox.Show("Hóa đơn không hợp lệ hoặc đã thanh toán!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tính tổng tiền
                int amount = (int)(invoice.TotalAmount ?? 0);
                if (amount <= 0)
                {
                    MessageBox.Show("Tổng tiền phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ SỬA: Tạo orderCode kiểu long với format yyyyMMddHHmmss
                long orderCode = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));

                // Tạo mô tả ngắn gọn
                string description = $"HD {invoice.InvoiceID.ToString().Substring(0, 8).ToUpper()}";

                // URL trả về
                string returnUrl = "https://localhost:3000/success";
                string cancelUrl = "https://localhost:3000/cancel";

                Console.WriteLine($"Creating payment with orderCode: {orderCode}");

                // Tạo link thanh toán
                var paymentService = new PaymentService();

                // ✅ SỬA: Thêm await và nhận giá trị trả về
                string paymentUrl = await paymentService.CreatePaymentLink(
                    orderCode,
                    amount,
                    description,
                    returnUrl,
                    cancelUrl
                );

                // Lưu orderCode vào database để tracking sau này
                // TODO: Thêm field OrderCode vào bảng Invoice hoặc tạo bảng mới PaymentTransaction
                // invoice.PaymentOrderCode = orderCode;
                // _context.SaveChanges();

                // ✅ Mở trình duyệt với URL nhận được
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = paymentUrl,
                    UseShellExecute = true
                });

                MessageBox.Show(
                    $"Đã tạo link thanh toán!\nMã giao dịch: {orderCode}",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                // Lưu orderCode hiện tại để polling
                _currentOrderCode = orderCode;
                // Bắt đầu polling trạng thái thanh toán
                StartPaymentStatusPolling(_invoiceID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi khi tạo thanh toán:\n{ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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

                        var successForm = new PayOSMethod.PaymentSuccessForm(invoiceID, _home, _employee);
                        successForm.ShowDialog();


                        // Reload thông tin hóa đơn
                        LoadLatestInvoices();
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

        private void parrotbtn_payCash_Click(object sender, EventArgs e)
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

            var confirmResult = MessageBox.Show(
                $"Xác nhận thanh toán tiền mặt?\n\nSố tiền: {(invoice.TotalAmount ?? 0).ToString("#,##0")} ₫",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // ✅ XỬ LÝ THANH TOÁN TIỀN MẶT
            var paymentService = new PaymentService();
            bool success = paymentService.ProcessCashPayment(_invoiceID);

            if (success)
            {
                MessageBox.Show(
                    "✓ Thanh toán tiền mặt thành công!\n\nHóa đơn đã được cập nhật.",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

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

        private void parrotBtn_printInvoice_Click(object sender, EventArgs e)
        {
            try
            {
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

                var printHelper = new InvoicePrintHelper(_invoiceID);
                printHelper.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi in hóa đơn: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}