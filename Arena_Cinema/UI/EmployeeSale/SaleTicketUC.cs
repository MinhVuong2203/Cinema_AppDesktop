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
        private SeatLockDAL _seatLockDAL = new SeatLockDAL();

        private List<DTO.ShowTime> _showTimes = new List<DTO.ShowTime>();
        private List<Ticket> _tickets = new List<Ticket>();
        private List<Seat> _seats = new List<Seat>();
        private List<Product> _products = new List<Product>();
        private List<Ticket> _selectedTickets = new List<Ticket>();
        private List<int> _selectedProductIds = new List<int>();
        private Dictionary<int, int> _selectedProductQuantities = new Dictionary<int, int>();
        private Guid _selectedShowTimeId = Guid.Empty;

        private Dictionary<int, Button> _seatButtons = new Dictionary<int, Button>();
        
        // Timer refresh realtime
        private Timer _refreshTimer;
        private const int REFRESH_INTERVAL = 3000;

        public SaleTicketUC(DTO.Movie movie)
        {
            InitializeComponent();
            _movie = movie;
            LoadMovieInfo();
            LoadShowTimes();
            LoadProducts();

            // Khởi tạo timer
            InitializeRefreshTimer();

            btnPayment.Click += BtnPayment_Click;
        }

        /// <summary>
        /// Khởi tạo timer để refresh trạng thái ghế realtime
        /// </summary>
        private void InitializeRefreshTimer()
        {
            _refreshTimer = new Timer();
            _refreshTimer.Interval = REFRESH_INTERVAL;
            _refreshTimer.Tick += RefreshTimer_Tick;
            _refreshTimer.Start();
        }

        /// <summary>
        /// Sự kiện timer - refresh trạng thái ghế mỗi 3 giây
        /// </summary>
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (_selectedShowTimeId != Guid.Empty)
            {
                RefreshSeatStatus();
            }
        }

        /// <summary>
        /// Refresh trạng thái tất cả ghế từ database
        /// </summary>
        private void RefreshSeatStatus()
        {
            try
            {
                // Refresh context để lấy dữ liệu mới
                _seatLockDAL.RefreshContext();

                // Reload tickets từ database
                _tickets = _saleTicketDAL.GetTicketsByShowTimeID(_selectedShowTimeId);

                // Cập nhật màu sắc các button ghế
                foreach (Control control in flpTickets.Controls)
                {
                    if (control is Button btnSeat && btnSeat.Tag is int seatId)
                    {
                        var seat = _seats.FirstOrDefault(s => s.SeatID == seatId);
                        var ticket = _tickets.FirstOrDefault(t => t.SeatID == seatId);

                        if (seat != null && ticket != null)
                        {
                            UpdateSeatButtonAppearance(btnSeat, seat, ticket);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Không hiển thị MessageBox để tránh spam
                Console.WriteLine($"[RefreshSeatStatus] Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Cập nhật màu sắc và trạng thái của button ghế
        /// </summary>
        private void UpdateSeatButtonAppearance(Button btnSeat, Seat seat, Ticket ticket)
        {
            // Màu mặc định theo loại ghế
            Color seatColor = Color.FromArgb(30, 144, 255); // DodgerBlue
            if (seat.SeatType == "Ghế VIP")
                seatColor = Color.Gold;
            else if (seat.SeatType == "Ghế Đôi" || seat.SeatType == "Ghế đôi")
                seatColor = Color.FromArgb(255, 105, 180); // HotPink

            bool isSelected = _selectedTickets.Any(t => t.SeatID == seat.SeatID);
            bool isLockedByMe = ticket.LockedBy == _employee?.EmployeeID;
            bool isLockedByOther = ticket.LockedBy.HasValue && !isLockedByMe;
            bool isSold = ticket.Status == "Đã bán";

            if (isSold)
            {
                btnSeat.BackColor = Color.DarkGray;
                btnSeat.ForeColor = Color.White;
                btnSeat.Enabled = false;
                btnSeat.Cursor = Cursors.No;
                btnSeat.Text = seat.SeatName;
            }
            else if (isLockedByOther)
            {
                btnSeat.BackColor = Color.Orange;
                btnSeat.ForeColor = Color.White;
                btnSeat.Enabled = false;
                btnSeat.Cursor = Cursors.No;

                // Hiển thị icon khóa
                string displayText = (seat.SeatType == "Ghế đôi" || seat.SeatType == "Ghế Đôi")
                    ? seat.SeatName + "\n🔒 Couple"
                    : seat.SeatName + "\n🔒";
                btnSeat.Text = displayText;
            }
            else if (isSelected || isLockedByMe)
            {
                btnSeat.BackColor = Color.LimeGreen;
                btnSeat.ForeColor = Color.White;
                btnSeat.Enabled = true;
                btnSeat.Cursor = Cursors.Hand;

                string displayText = (seat.SeatType == "Ghế đôi" || seat.SeatType == "Ghế Đôi")
                    ? seat.SeatName + "\nCouple"
                    : seat.SeatName;
                btnSeat.Text = displayText;
            }
            else
            {
                btnSeat.BackColor = seatColor;
                btnSeat.ForeColor = Color.White;
                btnSeat.Enabled = true;
                btnSeat.Cursor = Cursors.Hand;

                string displayText = (seat.SeatType == "Ghế đôi" || seat.SeatType == "Ghế Đôi")
                    ? seat.SeatName + "\nCouple"
                    : seat.SeatName;
                btnSeat.Text = displayText;
            }
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
            _seatButtons.Clear();
            _seats = _saleTicketDAL.GetSeatsByRoomID(roomId);
            _tickets = _saleTicketDAL.GetTicketsByShowTimeID(_selectedShowTimeId);

            // ===== THIẾT LẬP LAYOUT GIỐNG SeatManagementUC =====
            const int CELL_SIZE = 58;        // Kích thước mỗi ô ghế (giống SeatManagementUC)
            const int OFFSET_Y = 80;         // Khoảng cách từ trên (cho màn hình)
            const int OFFSET_X = 60;         // Khoảng cách từ trái (cho label hàng)
            const int SNAP_GRID = 58;        // Lưới snap (giống SeatManagementUC)

            // Tính kích thước cần thiết
            int maxX = _seats.Any() ? _seats.Max(s => s.pX) : 15;
            int maxY = _seats.Any() ? _seats.Max(s => s.pY) : 10;

            // Tính số hàng thực tế
            int maxRows = maxY + 1;

            // Đặt chế độ absolute positioning
            flpTickets.AutoScroll = true;
            flpTickets.AutoScrollMinSize = new Size(
                (maxX + 2) * SNAP_GRID + OFFSET_X + 60,
                maxRows * SNAP_GRID + OFFSET_Y + 60
            );

            // ===== LABEL MÀN HÌNH =====
            var lblScreen = new Label
            {
                Text = "MÀN HÌNH",
                Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(OFFSET_X, 10),
                Size = new Size((maxX + 1) * SNAP_GRID, 60)
            };
            flpTickets.Controls.Add(lblScreen);

            // ===== LABEL HÀNG (A, B, C, D...) - GIỐNG SeatManagementUC =====
            // Lấy danh sách các hàng duy nhất
            var uniqueRows = _seats.Select(s => s.pY).Distinct().OrderBy(y => y).ToList();

            foreach (var rowY in uniqueRows)
            {
                // Lấy tên hàng từ ghế đầu tiên trong hàng
                var firstSeatInRow = _seats.Where(s => s.pY == rowY)
                                           .OrderBy(s => s.pX)
                                           .FirstOrDefault();

                if (firstSeatInRow != null && !string.IsNullOrEmpty(firstSeatInRow.SeatName))
                {
                    // Lấy ký tự đầu (A, B, C...)
                    string rowLetter = firstSeatInRow.SeatName.Substring(0, 1);

                    var lblRow = new Label
                    {
                        Text = rowLetter,
                        Location = new Point(5, rowY * SNAP_GRID + OFFSET_Y),
                        Size = new Size(50, SNAP_GRID),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                        ForeColor = Color.White,
                        BackColor = Color.FromArgb(220, 53, 69)
                    };
                    flpTickets.Controls.Add(lblRow);
                }
            }

            // ===== TẠO CÁC NÚT GHẾ THEO TỌA ĐỘ pX, pY =====
            foreach (var seat in _seats)
            {
                // Tính vị trí pixel từ tọa độ lưới (GIỐNG SeatManagementUC)
                int posX = seat.pX * SNAP_GRID + OFFSET_X;
                int posY = seat.pY * SNAP_GRID + OFFSET_Y;

                // Xác định màu ghế theo loại
                Color seatColor;
                switch (seat.SeatType)
                {
                    case "Ghế đôi":
                    case "Ghế Đôi":
                        seatColor = Color.FromArgb(255, 105, 180); // Hồng
                        break;
                    case "Ghế VIP":
                        seatColor = Color.Gold;
                        break;
                    default:
                        seatColor = Color.FromArgb(30, 144, 255); // Xanh dương
                        break;
                }

                // Kiểm tra trạng thái vé
                var ticket = _tickets.FirstOrDefault(t => t.SeatID == seat.SeatID);
                bool isLocked = ticket != null && ticket.Status != "Trống";

                // Kiểm tra ghế đã được chọn
                bool isSelected = _selectedTickets.Any(t => t.SeatID == seat.SeatID);

                // Tạo button ghế
                var btnSeat = new Button
                {
                    // Ghế đôi rộng gấp đôi
                    Width = (seat.SeatType == "Ghế đôi" || seat.SeatType == "Ghế Đôi")
                        ? CELL_SIZE * 2 + 8
                        : CELL_SIZE,
                    Height = CELL_SIZE,
                    Location = new Point(posX, posY),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                    Text = (seat.SeatType == "Ghế đôi" || seat.SeatType == "Ghế Đôi")
                        ? seat.SeatName + "\nCouple"
                        : seat.SeatName,
                    Tag = seat.SeatID,

                    // Màu sắc dựa trên trạng thái
                    BackColor = isLocked ? Color.Gray : (isSelected ? Color.LimeGreen : seatColor),
                    ForeColor = Color.White,

                    Enabled = !isLocked,
                    Cursor = isLocked ? Cursors.No : Cursors.Hand
                };

                // Style cho button
                btnSeat.FlatAppearance.BorderSize = 1;
                btnSeat.FlatAppearance.BorderColor = Color.White;

                // Sự kiện click
                btnSeat.Click += BtnSeat_Click;
                //rowPanel.Controls.Add(btnSeat);
                flpTickets.Controls.Add(btnSeat);

                _seatButtons[seat.SeatID] = btnSeat;
                btnSeat.BringToFront();
            }

            // Đưa màn hình lên trên cùng
            lblScreen.BringToFront();
        }

        /// <summary>
        /// Sự kiện click vào button ghế
        /// </summary>
        private void BtnSeat_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var seatId = (int)btn.Tag;
            var ticket = _tickets.FirstOrDefault(t => t.SeatID == seatId);
            var seat = _seats.FirstOrDefault(s => s.SeatID == seatId);

            if (ticket == null || seat == null) return;
            if (ticket.Status == "Đã bán") return;

            var selected = _selectedTickets.FirstOrDefault(t => t.SeatID == seatId);

            if (selected != null)
            {
                // ===== BỎ CHỌN GHẾ - UNLOCK =====
                if (_employee != null)
                {
                    bool unlocked = _seatLockDAL.UnlockSeat(ticket.TicketID, _employee.EmployeeID);
                    if (unlocked)
                    {
                        _selectedTickets.Remove(selected);

                        // Cập nhật giao diện ngay lập tức
                        Color seatColor = Color.FromArgb(30, 144, 255);
                        if (seat.SeatType == "Ghế VIP") seatColor = Color.Gold;
                        else if (seat.SeatType == "Ghế Đôi" || seat.SeatType == "Ghế đôi")
                            seatColor = Color.FromArgb(255, 105, 180);

                        btn.BackColor = seatColor;
                        string displayText = (seat.SeatType == "Ghế đôi" || seat.SeatType == "Ghế Đôi")
                            ? seat.SeatName + "\nCouple"
                            : seat.SeatName;
                        btn.Text = displayText;
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ chọn ghế này!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                // ===== CHỌN GHẾ - LOCK =====
                if (_employee != null)
                {
                    bool locked = _seatLockDAL.LockSeat(ticket.TicketID, _employee.EmployeeID);
                    if (locked)
                    {
                        // Reload ticket để lấy thông tin mới nhất
                        var updatedTicket = _saleTicketDAL.GetTicketsByShowTimeID(_selectedShowTimeId)
                            .FirstOrDefault(t => t.TicketID == ticket.TicketID);

                        if (updatedTicket != null)
                        {
                            _selectedTickets.Add(updatedTicket);
                            btn.BackColor = Color.LimeGreen;
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ghế này đang được chọn bởi nhân viên khác!\nVui lòng chọn ghế khác.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }

            RefreshSeatStatus();
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
                    ButtonText = "",
                    ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded,
                    ButtonImage = global::UI.Properties.Resources.minus1,
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
                    ButtonText = "",
                    ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded,
                    ButtonImage = global::UI.Properties.Resources.add,
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
            var customer = GetCustomerByPhone(txt_Phone.Text.Trim());

            var invoice = new DTO.Invoice
            {
                EmployeeID = _employee?.EmployeeID,
                CustomerID = customer?.CustomerID,
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

            _parentForm?.LoadControl(new TicketPaymentInfo(invoiceId, _employee, _parentForm));
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
                            return null; 
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
        /// <summary>
        /// Cleanup khi đóng form hoặc dispose
        /// </summary>
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);

            // Dừng timer
            if (_refreshTimer != null)
            {
                _refreshTimer.Stop();
                _refreshTimer.Dispose();
            }

            // Unlock tất cả ghế của nhân viên này
            if (_employee != null)
            {
                int unlockedCount = _seatLockDAL.UnlockAllSeatsForEmployee(_employee.EmployeeID);
                Console.WriteLine($"[Cleanup] Unlocked {unlockedCount} seats for employee {_employee.FullName}");
            }
        }
    }
}