using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private SaleProductDAL _saleProductDAL = new SaleProductDAL();
        private List<Product> _products = new List<Product>();
        private List<int> _selectedProductIds = new List<int>();
        private Dictionary<int, int> _selectedProductQuantities = new Dictionary<int, int>();

        public SaleProductUC(Home home, DTO.Employee employee)
        {
            InitializeComponent();
            _home = home;
            _employee = employee;

            btn_back.Click += btn_back_Click;
            btnPayment.Click += BtnPayment_Click;

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

            int availableWidth = flpProducts.ClientSize.Width - 50;

            foreach (var product in _products)
            {
                //Kiểm tra số lượng tồn kho
                int stockQuantity = product.QuaLimited ?? 0;
                bool isOutOfStock = stockQuantity <= 0;

                var productPanel = new Panel
                {
                    Width = availableWidth,
                    Height = 130,
                    Margin = new Padding(5, 5, 5, 5),
                    BackColor = isOutOfStock
                        ? Color.FromArgb(243, 244, 246)
                        : Color.White,
                    BorderStyle = BorderStyle.None,
                    Cursor = isOutOfStock ? Cursors.No : Cursors.Default
                };

                // Border effect
                productPanel.Paint += (s, e) =>
                {
                    var pen = new Pen(Color.FromArgb(229, 231, 235), 1);
                    e.Graphics.DrawRectangle(pen, 0, 0, productPanel.Width - 1, productPanel.Height - 1);
                    pen.Dispose();
                };

                //PictureBox
                var picProduct = new PictureBox
                {
                    Location = new Point(15, 20),
                    Size = new Size(90, 90),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.FromArgb(249, 250, 251)
                };

                if (!string.IsNullOrEmpty(product.ImageUrl))
                {
                    ImgHelper.DisplayImageFromRelative(product.ImageUrl, picProduct);
                }

                //Overlay
                if (isOutOfStock)
                {
                    var lblOutOfStock = new Label
                    {
                        Text = "HẾT",
                        Location = new Point(15, 30),
                        Size = new Size(90, 70),
                        BackColor = Color.FromArgb(200, 0, 0, 0),
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    productPanel.Controls.Add(lblOutOfStock);
                    lblOutOfStock.BringToFront();
                }

                int nameWidth = availableWidth - 550; // Chiều rộng còn lại cho tên
                int priceX = availableWidth - 360;    // Vị trí giá
                int buttonX = availableWidth - 215;   // Vị trí nút -
                int qtyX = availableWidth - 165;      // Vị trí số lượng
                int plusX = availableWidth - 80;      // Vị trí nút +

                //Label tên sản phẩm - dynamic width
                var lblName = new Label
                {
                    Text = product.ProductName,
                    Location = new Point(120, 20),
                    Size = new Size(nameWidth, 32),
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    ForeColor = isOutOfStock
                        ? Color.FromArgb(156, 163, 175)
                        : Color.FromArgb(31, 41, 55),
                    AutoSize = false,
                    AutoEllipsis = true
                };

                //Label loại sản phẩm
                var lblCategory = new Label
                {
                    Text = $"📦 {product.ProductType ?? "Sản phẩm"}",
                    Location = new Point(120, 52),
                    Size = new Size(180, 20),
                    Font = new Font("Segoe UI", 8.5F),
                    ForeColor = Color.FromArgb(107, 114, 128),
                    AutoSize = false
                };

                //Label số lượng tồn kho
                var lblStock = new Label
                {
                    Text = isOutOfStock
                        ? "Hết hàng"
                        : $"Còn: {stockQuantity}",
                    Location = new Point(120, 75),
                    Size = new Size(160, 25),
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = isOutOfStock
                        ? Color.FromArgb(220, 38, 38)
                        : Color.FromArgb(22, 163, 74),
                    AutoSize = false,
                    Name = $"lblStock_{product.ProductID}"
                };

                //Label giá tiền
                var lblPrice = new Label
                {
                    Text = (product.Price ?? 0).ToString("#,##0") + " ₫",
                    Location = new Point(priceX, 45),
                    Size = new Size(150, 35),
                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                    ForeColor = isOutOfStock
                        ? Color.FromArgb(156, 163, 175)
                        : Color.FromArgb(220, 38, 38),
                    TextAlign = ContentAlignment.MiddleRight,
                    AutoSize = false
                };

                // Dictionary lưu số lượng
                if (!_selectedProductQuantities.ContainsKey(product.ProductID))
                {
                    _selectedProductQuantities[product.ProductID] = 0;
                }

                if (!isOutOfStock)
                {
                    //Nút giảm
                    var btnMinus = new ReaLTaiizor.Controls.ParrotButton
                    {
                        Width = 40,
                        Height = 40,
                        Location = new Point(buttonX, 45),
                        ButtonText = "",
                        ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded,
                        ButtonImage = Properties.Resources.minus1,
                        CornerRadius = 8,
                        BackgroundColor = Color.White,
                        HoverBackgroundColor = Color.FromArgb(254, 226, 226),
                        ClickBackColor = Color.FromArgb(252, 165, 165),
                        TextColor = Color.FromArgb(220, 38, 38),
                        HoverTextColor = Color.FromArgb(220, 38, 38),
                        ClickTextColor = Color.FromArgb(220, 38, 38),
                        Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                        Cursor = Cursors.Hand,
                        Tag = product.ProductID
                    };

                    //Label số lượng
                    var lblQuantity = new Label
                    {
                        Text = "0",
                        Location = new Point(qtyX, 45),
                        Size = new Size(70, 40),
                        Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(31, 41, 55),
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.FromArgb(243, 244, 246),
                        Name = $"lblQty_{product.ProductID}"
                    };

                    //Nút tăng
                    var btnPlus = new ReaLTaiizor.Controls.ParrotButton
                    {
                        Width = 40,
                        Height = 40,
                        Location = new Point(plusX, 45),
                        ButtonText = "",
                        ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded,
                        ButtonImage = Properties.Resources.add,
                        CornerRadius = 8,
                        BackgroundColor = Color.White,
                        HoverBackgroundColor = Color.FromArgb(220, 252, 231),
                        ClickBackColor = Color.FromArgb(187, 247, 208),
                        TextColor = Color.FromArgb(22, 163, 74),
                        HoverTextColor = Color.FromArgb(22, 163, 74),
                        ClickTextColor = Color.FromArgb(22, 163, 74),
                        Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                        Cursor = Cursors.Hand,
                        Tag = product.ProductID
                    };

                    //Sự kiện nút giảm
                    btnMinus.Click += (s, e) =>
                    {
                        int productId = (int)((ReaLTaiizor.Controls.ParrotButton)s).Tag;
                        if (_selectedProductQuantities[productId] > 0)
                        {
                            _selectedProductQuantities[productId]--;
                            var lbl = productPanel.Controls.Find($"lblQty_{productId}", false).FirstOrDefault() as Label;
                            if (lbl != null) lbl.Text = _selectedProductQuantities[productId].ToString();

                            if (_selectedProductQuantities[productId] == 0)
                            {
                                _selectedProductIds.Remove(productId);
                            }
                            UpdateInvoice();
                        }
                    };

                    //Sự kiện nút tăng (có kiểm tra tồn kho)
                    btnPlus.Click += (s, e) =>
                    {
                        int productId = (int)((ReaLTaiizor.Controls.ParrotButton)s).Tag;
                        var prod = _products.FirstOrDefault(p => p.ProductID == productId);

                        if (prod != null)
                        {
                            int currentQty = _selectedProductQuantities[productId];
                            int stock = prod.QuaLimited ?? 0;

                            //Không cho mua quá tồn kho
                            if (currentQty >= stock)
                            {
                                MessageBox.Show(
                                    $"⚠️ Không thể thêm!\n\n" +
                                    $"'{prod.ProductName}' chỉ còn {stock} trong kho.",
                                    "Vượt quá tồn kho",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                return;
                            }

                            _selectedProductQuantities[productId]++;
                            var lbl = productPanel.Controls.Find($"lblQty_{productId}", false).FirstOrDefault() as Label;
                            if (lbl != null) lbl.Text = _selectedProductQuantities[productId].ToString();

                            if (!_selectedProductIds.Contains(productId))
                            {
                                _selectedProductIds.Add(productId);
                            }
                            UpdateInvoice();
                        }
                    };

                    productPanel.Controls.Add(btnMinus);
                    productPanel.Controls.Add(lblQuantity);
                    productPanel.Controls.Add(btnPlus);
                }
                else
                {
                    // Nút "Hết hàng"
                    var btnDisabled = new Button
                    {
                        Text = "HẾT HÀNG",
                        Location = new Point(buttonX, 45),
                        Size = new Size(170, 40),
                        BackColor = Color.FromArgb(220, 38, 38),
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                        Enabled = false,
                        FlatStyle = FlatStyle.Flat,
                        FlatAppearance = { BorderSize = 0 }
                    };
                    productPanel.Controls.Add(btnDisabled);
                }

                // Thêm controls vào panel
                productPanel.Controls.Add(picProduct);
                productPanel.Controls.Add(lblName);
                productPanel.Controls.Add(lblCategory);
                productPanel.Controls.Add(lblStock);
                productPanel.Controls.Add(lblPrice);

                flpProducts.Controls.Add(productPanel);
            }

            UpdateInvoice();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedProducts = _products.Where(p => _selectedProductIds.Contains(p.ProductID)).ToList();
                if (selectedProducts.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để thanh toán.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //KIỂM TRA TỒN KHO TRƯỚC KHI THANH TOÁN
                foreach (var p in selectedProducts)
                {
                    int requestedQty = _selectedProductQuantities[p.ProductID];
                    int stock = p.QuaLimited ?? 0;

                    if (requestedQty > stock)
                    {
                        MessageBox.Show(
                            $"Sản phẩm '{p.ProductName}' chỉ còn {stock} trong kho!\n" +
                            $"Bạn đang chọn {requestedQty}.\n\n" +
                            $"Vui lòng giảm số lượng.",
                            "Vượt quá tồn kho",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }

                //var confirmResult = MessageBox.Show(
                //    $"Bạn có chắc chắn muốn tạo hóa đơn?\n\n" +
                //    $"{selectedProducts.Count} loại sản phẩm\n" +
                //    $"Tổng tiền: {CalculateTotal():N0} ₫",
                //    "Xác nhận tạo hóa đơn",
                //    MessageBoxButtons.YesNo,
                //    MessageBoxIcon.Question);

                //if (confirmResult != DialogResult.Yes)
                //{
                //    return;
                //}

                var customer = GetCustomerByPhone(txt_Phone.Text.Trim());

                decimal totalProducts = CalculateTotal();
                decimal discount = 0;

                // Tạo hóa đơn
                var invoiceId = _saleProductDAL.AddProductInvoice(
                    selectedProducts,
                    _selectedProductQuantities,
                    _employee,
                    customer,
                    totalProducts,
                    discount);

                //TRỪ SỐ LƯỢNG TỒN KHO
                using (var context = new CinemaDBContext())
                {
                    foreach (var p in selectedProducts)
                    {
                        int qty = _selectedProductQuantities[p.ProductID];
                        var productInDb = context.Products.Find(p.ProductID);

                        if (productInDb != null)
                        {
                            productInDb.QuaLimited = (productInDb.QuaLimited ?? 0) - qty;

                            p.QuaLimited = productInDb.QuaLimited;
                        }
                    }
                    context.SaveChanges();
                }

                //MessageBox.Show(
                //    "✅ Đã tạo thành công hóa đơn!",
                //    "Thông báo",
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Information);

                // Chuyển sang trang thanh toán
                var paymentInforUC = new ProductPaymentInfor(_home, _employee, invoiceId);
                paymentInforUC.SetCustomerInfo(customer);
                _home.LoadControl(paymentInforUC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi khi xử lý thanh toán: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private decimal CalculateTotal()
        {
            decimal total = 0;
            var selectedProducts = _products.Where(p => _selectedProductIds.Contains(p.ProductID));

            foreach (var p in selectedProducts)
            {
                int qty = _selectedProductQuantities[p.ProductID];
                total += (p.Price ?? 0) * qty;
            }

            return total;
        }

        private void UpdateInvoice()
        {
            var selectedProducts = _products.Where(p => _selectedProductIds.Contains(p.ProductID)).ToList();

            if (selectedProducts.Count == 0)
            {
                lbInvoiceProducts.Text = "🛒 Giỏ hàng trống\n\nVui lòng chọn sản phẩm.";
                lbInvoiceTotal.Text = "Tổng tiền: 0 ₫";
                return;
            }

            //Tạo danh sách
            var invoiceText = new System.Text.StringBuilder();
            invoiceText.AppendLine("🛒 GIỎ HÀNG:\n");

            decimal totalProducts = 0;
            foreach (var p in selectedProducts)
            {
                int qty = _selectedProductQuantities[p.ProductID];
                decimal itemTotal = (p.Price ?? 0) * qty;
                totalProducts += itemTotal;

                invoiceText.AppendLine($"• {p.ProductName}");
                invoiceText.AppendLine($"  {qty} x {(p.Price ?? 0):N0} ₫ = {itemTotal:N0} ₫");
                invoiceText.AppendLine();
            }

            lbInvoiceProducts.Text = invoiceText.ToString();
            lbInvoiceTotal.Text = $"Tổng tiền: {totalProducts:N0} ₫";
        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            var phone = txt_Phone.Text.Trim();
            if (phone.Length >= 10)
            {
                var customer = GetCustomerByPhone(phone);
                UpdateCustomerDisplay(customer);
            }
            else
            {
                UpdateCustomerDisplay(null);
            }
        }

        private void UpdateCustomerDisplay(Customer customer)
        {
            if (customer != null)
            {
                lbCustomerName.Text = $"👤 {customer.FullName}";
                lbCustomerName.ForeColor = Color.FromArgb(22, 163, 74);
                lbCustomerPhone.Text = $"📞 {customer.Phone}";
                lbCustomerEmail.Text = $"✉️ {customer.Email ?? "---"}";
            }
            else
            {
                lbCustomerName.Text = "👤 Khách vãng lai";
                lbCustomerName.ForeColor = Color.FromArgb(107, 114, 128);
                lbCustomerPhone.Text = "📞 ---";
                lbCustomerEmail.Text = "✉️ ---";
            }
        }

        private Customer GetCustomerByPhone(string phone)
        {
            try
            {
                using (var context = new CinemaDBContext())
                {
                    var customer = context.Customers
                        .FirstOrDefault(c => c.Phone == phone && !c.IsDeleted);

                    if (customer == null && !string.IsNullOrWhiteSpace(phone) && phone.Length >= 10)
                    {
                        CreatCustomer creatCustomer = new CreatCustomer(phone);
                        var result = creatCustomer.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            var customernew = context.Customers
                                .FirstOrDefault(c => c.Phone == phone && !c.IsDeleted);
                            return customernew;
                        }
                    }

                    return customer;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy khách hàng: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            var phone = txt_Phone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customer = GetCustomerByPhone(phone);
            UpdateCustomerDisplay(customer);

            if (customer == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}