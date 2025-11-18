using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using DAL;
using DTO;

namespace UI.EmployeeSale
{
    public partial class SaleProductUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private SaleTicketDAL _saleTicketDAL = new SaleTicketDAL();
        private List<DTO.ShowTime> _showTimes = new List<DTO.ShowTime>();
        private List<Ticket> _tickets = new List<Ticket>();
        private List<Seat> _seats = new List<Seat>();
        private List<Product> _products = new List<Product>();
        private List<int> _selectedSeatIds = new List<int>();
        private Dictionary<string, int> _selectedTicketTypeCounts = new Dictionary<string, int>();
        private List<int> _selectedProductIds = new List<int>();
        private Dictionary<int, int> _selectedProductQuantities = new Dictionary<int, int>();
        private Guid _selectedShowTimeId = Guid.Empty;
        public SaleProductUC(Home home, DTO.Employee employee)
        {
            InitializeComponent();
            _home = home;
            _employee = employee;
            btn_back.Click += btn_back_Click;
            LoadProducts();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new SaleHomeUC(_home, _employee));
        }

        private void LoadProducts()
        {
            flpProducts.Controls.Clear();
            _products = _saleTicketDAL.GetAllProducts();

            foreach (var product in _products)
            {
                // Panel chính cho mỗi sản phẩm
                var productPanel = new Panel
                {
                    Width = 900,
                    Height = 150,
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(248, 250, 252),
                    BorderStyle = BorderStyle.None
                };

                // PictureBox cho hình ảnh sản phẩm
                var picProduct = new PictureBox
                {
                    Location = new Point(20, 25),
                    Size = new Size(100, 100),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.White
                };

                // Load hình ảnh
                if (!string.IsNullOrEmpty(product.ImageUrl))
                {
                    ImgHelper.DisplayImageFromRelative(product.ImageUrl, picProduct);
                }

                // Label tên sản phẩm
                var lblName = new Label
                {
                    Text = product.ProductName,
                    Location = new Point(140, 30),
                    Size = new Size(350, 35),
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(31, 41, 55),
                    AutoSize = false
                };

                // Label mã/loại sản phẩm (nếu có)
                var lblCategory = new Label
                {
                    Text = product.ProductType ?? "SẢN PHẨM",
                    Location = new Point(140, 70),
                    Size = new Size(350, 25),
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = Color.FromArgb(156, 163, 175),
                    AutoSize = false
                };

                // Label giá tiền
                var lblPrice = new Label
                {
                    Text = (product.Price ?? 0).ToString("#,##0.00") + " ₫",
                    Location = new Point(630, 30),
                    Size = new Size(170, 35),
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(220, 38, 38),
                    TextAlign = ContentAlignment.TopRight,
                    AutoSize = false
                };

                // Nút giảm số lượng
                var btnMinus = new ReaLTaiizor.Controls.ParrotButton
                {
                    Width = 45,
                    Height = 45,
                    Location = new Point(630, 80),
                    ButtonText = "-",
                    ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded,
                    CornerRadius = 8,
                    BackgroundColor = Color.White,
                    HoverBackgroundColor = Color.FromArgb(254, 226, 226),
                    ClickBackColor = Color.FromArgb(252, 165, 165),
                    TextColor = Color.FromArgb(220, 38, 38),
                    HoverTextColor = Color.FromArgb(220, 38, 38),
                    ClickTextColor = Color.FromArgb(220, 38, 38),
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Tag = product.ProductID
                };

                // Label hiển thị số lượng
                var lblQuantity = new Label
                {
                    Text = "0",
                    Location = new Point(685, 80),
                    Size = new Size(50, 45),
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(31, 41, 55),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Name = $"lblQty_{product.ProductID}"
                };

                // Nút tăng số lượng
                var btnPlus = new ReaLTaiizor.Controls.ParrotButton
                {
                    Width = 45,
                    Height = 45,
                    Location = new Point(745, 80),
                    ButtonText = "+",
                    ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded,
                    CornerRadius = 8,
                    BackgroundColor = Color.White,
                    HoverBackgroundColor = Color.FromArgb(254, 226, 226),
                    ClickBackColor = Color.FromArgb(252, 165, 165),
                    TextColor = Color.FromArgb(220, 38, 38),
                    HoverTextColor = Color.FromArgb(220, 38, 38),
                    ClickTextColor = Color.FromArgb(220, 38, 38),
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Tag = product.ProductID
                };

                // Dictionary lưu số lượng từng sản phẩm
                if (!_selectedProductQuantities.ContainsKey(product.ProductID))
                {
                    _selectedProductQuantities[product.ProductID] = 0;
                }

                // Sự kiện click nút giảm
                btnMinus.Click += (s, e) =>
                {
                    int productId = (int)((ReaLTaiizor.Controls.ParrotButton)s).Tag;
                    if (_selectedProductQuantities[productId] > 0)
                    {
                        _selectedProductQuantities[productId]--;
                        var lbl = productPanel.Controls.Find($"lblQty_{productId}", false).FirstOrDefault() as Label;
                        if (lbl != null) lbl.Text = _selectedProductQuantities[productId].ToString();

                        // Cập nhật danh sách sản phẩm đã chọn
                        if (_selectedProductQuantities[productId] == 0)
                        {
                            _selectedProductIds.Remove(productId);
                        }
                        UpdateInvoice();
                    }
                };

                // Sự kiện click nút tăng
                btnPlus.Click += (s, e) =>
                {
                    int productId = (int)((ReaLTaiizor.Controls.ParrotButton)s).Tag;
                    _selectedProductQuantities[productId]++;
                    var lbl = productPanel.Controls.Find($"lblQty_{productId}", false).FirstOrDefault() as Label;
                    if (lbl != null) lbl.Text = _selectedProductQuantities[productId].ToString();

                    // Thêm vào danh sách đã chọn nếu chưa có, nếu đã có thì tính lại tiền của sản phẩm
                    if (!_selectedProductIds.Contains(productId))
                    {
                        _selectedProductIds.Add(productId);
                    }
                    UpdateInvoice();
                };

                // Thêm controls vào panel
                productPanel.Controls.Add(picProduct);
                productPanel.Controls.Add(lblName);
                productPanel.Controls.Add(lblCategory);
                productPanel.Controls.Add(lblPrice);
                productPanel.Controls.Add(btnMinus);
                productPanel.Controls.Add(lblQuantity);
                productPanel.Controls.Add(btnPlus);

                flpProducts.Controls.Add(productPanel);
            }
            UpdateInvoice();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            if (_selectedShowTimeId == Guid.Empty)
            {
                MessageBox.Show("Vui lòng chọn suất chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_selectedSeatIds.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_selectedTicketTypeCounts.Values.Sum() != _selectedSeatIds.Count)
            {
                MessageBox.Show("Vui lòng phân bổ loại vé cho tất cả ghế đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateInvoice()
        {

            // Hiển thị sản phẩm đã chọn và số lượng
            var selectedProducts = _products.Where(p => _selectedProductIds.Contains(p.ProductID)).ToList();
            lbInvoiceProducts.Text = "Sản phẩm đã chọn:\n" + (selectedProducts.Count > 0
                ? string.Join("\n", selectedProducts.Select(p =>
                {
                    int qty = _selectedProductQuantities.ContainsKey(p.ProductID) ? _selectedProductQuantities[p.ProductID] : 0;
                    return $"{p.ProductName} x{qty} - {(p.Price ?? 0) * qty:C0}";
                }))
                : "Chưa chọn");

            // Tính tổng tiền vé
            decimal totalTickets = 0;
            foreach (var kv in _selectedTicketTypeCounts)
            {
                var price = _tickets.Where(t => t.TicketType == kv.Key).Select(t => t.Price ?? 0).FirstOrDefault();
                totalTickets += price * kv.Value;
            }

            // Tính tổng tiền sản phẩm theo số lượng từng sản phẩm
            decimal totalProducts = 0;
            foreach (var p in selectedProducts)
            {
                int qty = _selectedProductQuantities.ContainsKey(p.ProductID) ? _selectedProductQuantities[p.ProductID] : 0;
                totalProducts += (p.Price ?? 0) * qty;
            }

            lbInvoiceTotal.Text = $"Tổng tiền: {(totalTickets + totalProducts).ToString("C0")}";
        }
    }
}
