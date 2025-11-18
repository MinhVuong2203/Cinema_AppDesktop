using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using DTO;

namespace UI.EmployeeSale
{
    public partial class ProductPaymentInfor : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private List<Invoice> _invoices;
        private CinemaDBContext _context;

        public ProductPaymentInfor()
        {
            InitializeComponent();
            _context = new CinemaDBContext();
        }

        public ProductPaymentInfor(Home home, DTO.Employee employee) : this()
        {
            _home = home;
            _employee = employee;

            // Khởi tạo sự kiện
            btnBack.Click += BtnBack_Click;
            btnPrint.Click += BtnPrint_Click;

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

        private void LoadLatestInvoices()
        {
            try
            {
                // Lấy danh sách hóa đơn mới nhất của nhân viên với trạng thái "Chờ thanh toán"
                _invoices = _context.Invoices
                    .Where(i => i.EmployeeID == _employee.EmployeeID &&
                               i.Status == "Chờ thanh toán" &&
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
            if (_home != null)
            {
                _home.LoadControl(new SaleHomeUC(_home, _employee));
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
    }
}