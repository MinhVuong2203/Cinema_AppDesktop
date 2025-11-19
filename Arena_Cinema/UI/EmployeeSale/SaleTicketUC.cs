using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;
using DAL;
using Common;

namespace UI.EmployeeSale
{
    public partial class SaleTicketUC : UserControl
    {
        private DTO.Movie _movie;
        private DTO.Employee _employee;
        private Home _parentForm;
        private SaleTicketDAL _saleTicketDAL = new SaleTicketDAL();
        private List<DTO.ShowTime> _showTimes = new List<DTO.ShowTime>();
        private List<Ticket> _tickets = new List<Ticket>();
        private List<Seat> _seats = new List<Seat>();
        private List<Product> _products = new List<Product>();
        private List<Ticket> _selectedTickets = new List<Ticket>();
        private List<int> _selectedProductIds = new List<int>();
        private Dictionary<int, int> _selectedProductQuantities = new Dictionary<int, int>();
        private Guid _selectedShowTimeId = Guid.Empty;

        public SaleTicketUC(DTO.Movie movie)
        {
            InitializeComponent();
            _movie = movie;
            LoadMovieInfo();
            LoadShowTimes();
            LoadProducts();
            btnPayment.Click += BtnPayment_Click;
        }

        public SaleTicketUC(DTO.Movie movie, Home parent, DTO.Employee employee) : this(movie)
        {
            _parentForm = parent;
            _employee = employee;

            if (this.Controls.Find("btnBack", true).Length > 0)
            {
                var btnBack = this.Controls.Find("btnBack", true)[0] as Button;
                if (btnBack != null)
                {
                    btnBack.Click += btn_back_Click;
                }
            }
            ImgHelper.DisplayImageFromRelative(movie.ImageUrl, picPoster);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (_parentForm != null && _employee != null)
            {
                _parentForm.LoadControl(new SelectMovieUC(_parentForm, _employee));
            }
            else
            {
                var parent = this.Parent as Home;
                if (parent != null && _employee != null)
                {
                    parent.LoadControl(new SelectMovieUC(parent, _employee));
                }
            }
        }

        private void LoadMovieInfo()
        {
            lbTitle.Text = $"{_movie.Title} ({_movie.AgeLimit})";
            lbInfo.Text = $"{_movie.Genre} • {_movie.DurationMinutes} phút • {_movie.AgeLimit}";
        }

        private void LoadShowTimes()
        {
            _showTimes = _saleTicketDAL.GetShowTimesByMovieID(_movie.MovieID);
            flpShowTimes.Controls.Clear();
            foreach (var showTime in _showTimes)
            {
                var btnShowTime = new Button
                {
                    Text = $"{showTime.StartTime:HH:mm} - Phòng {showTime.RoomID} - {showTime.Price.ToString("C0")}",
                    Width = 200,
                    Height = 40,
                    Margin = new Padding(5),
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    Tag = showTime.ShowTimeID
                };
                btnShowTime.Click += BtnShowTime_Click;
                flpShowTimes.Controls.Add(btnShowTime);
            }
            UpdateInvoice();
        }

        private void BtnShowTime_Click(object sender, EventArgs e)
        {
            foreach (Button btn in flpShowTimes.Controls)
                btn.BackColor = Color.White;

            var btnSelected = sender as Button;
            btnSelected.BackColor = Color.OrangeRed;

            var showTimeId = (Guid)btnSelected.Tag;
            _selectedShowTimeId = showTimeId;

            var showTime = _showTimes.FirstOrDefault(st => st.ShowTimeID == showTimeId);
            if (showTime != null)
            {
                LoadSeatsByRoom(showTime.RoomID);
            }

            _selectedTickets.Clear();
            UpdateInvoice();
        }

        private void LoadSeatsByRoom(int roomId)
        {
            flpTickets.Controls.Clear();
            _seats = _saleTicketDAL.GetSeatsByRoomID(roomId);
            _tickets = _saleTicketDAL.GetTicketsByShowTimeID(_selectedShowTimeId);

            foreach (var seat in _seats)
            {
                var ticket = _tickets.FirstOrDefault(t => t.SeatID == seat.SeatID);
                var isSold = ticket != null && ticket.Status == "Đã bán";
                var isSelected = _selectedTickets.Any(t => t.SeatID == seat.SeatID);

                var btnSeat = new Button
                {
                    Text = seat.SeatName,
                    Tag = seat.SeatID,
                    Width = 40,
                    Height = 40,
                    Margin = new Padding(2),
                    BackColor = isSold ? Color.Gray : (isSelected ? Color.Yellow : Color.White),
                    Enabled = !isSold && ticket != null,
                    Font = new Font("Segoe UI", 9F)
                };
                btnSeat.Click += BtnSeat_Click;
                flpTickets.Controls.Add(btnSeat);
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var seatId = (int)btn.Tag;
            var ticket = _tickets.FirstOrDefault(t => t.SeatID == seatId);

            if (ticket == null || ticket.Status == "Đã bán") return;

            var selected = _selectedTickets.FirstOrDefault(t => t.SeatID == seatId);
            if (selected != null)
            {
                _selectedTickets.Remove(selected);
                btn.BackColor = Color.White;
            }
            else
            {
                _selectedTickets.Add(ticket);
                btn.BackColor = Color.Yellow;
            }
            UpdateInvoice();
        }

        private void LoadProducts()
        {
            flpProducts.Controls.Clear();
            _products = _saleTicketDAL.GetAllProducts();

            foreach (var product in _products)
            {
                var productPanel = new Panel
                {
                    Width = 900,
                    Height = 150,
                    Margin = new Padding(5),
                    BackColor = Color.FromArgb(248, 250, 252),
                    BorderStyle = BorderStyle.None
                };

                var picProduct = new PictureBox
                {
                    Location = new Point(20, 25),
                    Size = new Size(100, 100),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.White
                };

                if (!string.IsNullOrEmpty(product.ImageUrl))
                {
                    ImgHelper.DisplayImageFromRelative(product.ImageUrl, picProduct);
                }

                var lblName = new Label
                {
                    Text = product.ProductName,
                    Location = new Point(140, 30),
                    Size = new Size(350, 35),
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(31, 41, 55),
                    AutoSize = false
                };

                var lblCategory = new Label
                {
                    Text = product.ProductType ?? "SẢN PHẨM",
                    Location = new Point(140, 70),
                    Size = new Size(350, 25),
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = Color.FromArgb(156, 163, 175),
                    AutoSize = false
                };

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

                if (!_selectedProductQuantities.ContainsKey(product.ProductID))
                {
                    _selectedProductQuantities[product.ProductID] = 0;
                }

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

                btnPlus.Click += (s, e) =>
                {
                    int productId = (int)((ReaLTaiizor.Controls.ParrotButton)s).Tag;
                    _selectedProductQuantities[productId]++;
                    var lbl = productPanel.Controls.Find($"lblQty_{productId}", false).FirstOrDefault() as Label;
                    if (lbl != null) lbl.Text = _selectedProductQuantities[productId].ToString();

                    if (!_selectedProductIds.Contains(productId))
                    {
                        _selectedProductIds.Add(productId);
                    }
                    UpdateInvoice();
                };

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
            if (_selectedTickets.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalTickets = _selectedTickets.Sum(t => t.Price ?? 0);

            decimal totalProducts = 0;
            foreach (var productId in _selectedProductIds)
            {
                var product = _products.FirstOrDefault(p => p.ProductID == productId);
                int qty = _selectedProductQuantities[productId];
                totalProducts += (product?.Price ?? 0) * qty;
            }

            var invoice = new DTO.Invoice
            {
                EmployeeID = _employee?.EmployeeID,
                TotalAmount = totalTickets + totalProducts,
                Status = "Chờ thanh toán",
                IsDeleted = false
            };

            var ticketIds = _selectedTickets.Select(t => t.TicketID).ToList();

            var productQuantities = new Dictionary<int, int>();
            foreach (var productId in _selectedProductIds)
            {
                productQuantities[productId] = _selectedProductQuantities[productId];
            }

            var bll = new SaleTicketBLL();
            Guid invoiceId = bll.CreateInvoice(invoice, ticketIds, productQuantities);

            MessageBox.Show("Đã tạo hóa đơn, vui lòng thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _parentForm?.LoadControl(new TicketPaymentInfo(invoiceId));
        }

        private void UpdateInvoice()
        {
            lbInvoiceMovie.Text = _movie != null
                ? $"Phim: {_movie.Title} ({_movie.Genre}, {_movie.DurationMinutes} phút, {_movie.AgeLimit})"
                : "Phim:";

            var showTime = _showTimes.FirstOrDefault(st => st.ShowTimeID == _selectedShowTimeId);
            lbInvoiceShowTime.Text = showTime != null
                ? $"Suất chiếu: {showTime.StartTime:dd/MM/yyyy HH:mm} - Phòng {showTime.RoomID} - Giá vé {showTime.Price.ToString("C0")}"
                : "Suất chiếu:";

            lbInvoiceTickets.Text = "Ghế đã chọn:\n" + (_selectedTickets.Count > 0
                ? string.Join(", ", _selectedTickets.Select(t =>
                    $"{_seats.FirstOrDefault(s => s.SeatID == t.SeatID)?.SeatName} ({t.TicketType} - {t.Price:C0})"))
                : "Chưa chọn");

            var selectedProducts = _products.Where(p => _selectedProductIds.Contains(p.ProductID)).ToList();
            lbInvoiceProducts.Text = "Sản phẩm đã chọn:\n" + (selectedProducts.Count > 0
                ? string.Join("\n", selectedProducts.Select(p =>
                {
                    int qty = _selectedProductQuantities.ContainsKey(p.ProductID) ? _selectedProductQuantities[p.ProductID] : 0;
                    return $"{p.ProductName} x{qty} - {(p.Price ?? 0) * qty:C0}";
                }))
                : "Chưa chọn");

            decimal totalTickets = _selectedTickets.Sum(t => t.Price ?? 0);

            decimal totalProducts = 0;
            foreach (var p in selectedProducts)
            {
                int qty = _selectedProductQuantities.ContainsKey(p.ProductID) ? _selectedProductQuantities[p.ProductID] : 0;
                totalProducts += (p.Price ?? 0) * qty;
            }

            lbInvoiceTotal.Text = $"Tổng tiền: {(totalTickets + totalProducts).ToString("C0")}";
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            if (_parentForm != null && _employee != null)
            {
                _parentForm.LoadControl(new SelectMovieUC(_parentForm, _employee));
            }
            else
            {
                var parent = this.Parent as Home;
                if (parent != null && _employee != null)
                {
                    parent.LoadControl(new SelectMovieUC(parent, _employee));
                }
            }
        }

        // Lấy hoặc tạo khách hàng mặc định
        private DTO.Customer GetCustomerByPhone(string phone)
        {
            try
            {
                using (var context = new CinemaDBContext())
                {
                    // Tìm khách hàng theo số điện thoại
                    var customer = context.Customers
                        .FirstOrDefault(c => c.Phone == phone && !c.IsDeleted);
                    //nếu không có mở cửa sổ tạo khách hàng mới và txt_phone không được trống
                    if (customer == null && !string.IsNullOrWhiteSpace(phone))
                    {
                        CreatCustomer creatCustomer = new CreatCustomer(phone);
                        var result = creatCustomer.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            // Lấy khách hàng mới tạo
                            var customernew = context.Customers
                                    .FirstOrDefault(c => c.Phone == phone && !c.IsDeleted);
                            return customernew;
                        }
                        else
                        {
                            return null; // Người dùng hủy tạo khách hàng
                        }
                    }

                    return customer;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy khách hàng: {ex.Message}");
            }
        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            var phone = txt_Phone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var customer = GetCustomerByPhone(phone);
            if (customer != null)
            {
                lbCustomerName.Text = $"Tên khách hàng: {customer.FullName}";
                lbCustomerPhone.Text = $"SĐT: {customer.Phone}";
                //lbCustomerEmail.Text = $"Email: {customer.Email}";
            }
            else
            {
                lbCustomerName.Text = "Tên khách hàng: ---";
                lbCustomerPhone.Text = "SĐT: ---";
                //lbCustomerEmail.Text = "Email: ---";
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}