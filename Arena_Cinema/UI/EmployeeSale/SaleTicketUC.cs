using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using Common;
using DAL;
using DTO;

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
                //Console.WriteLine($"[RefreshTimer] Refreshing seat status...");
                //RefreshSeatStatus();
                //Console.WriteLine($"[RefreshTimer] Refresh completed");
                // Đảm bảo chạy trên UI thread
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => RefreshSeatStatus()));
                }
                else
                {
                    RefreshSeatStatus();
                }
            }
        }

        /// <summary>
        /// Refresh trạng thái tất cả ghế từ database
        /// </summary>
        private void RefreshSeatStatus()
        {
            try
            {
                // Tạo context mới để tránh cache và lấy dữ liệu mới nhất từ database
                // Tương tự cách GetCustomerByPhone đã làm
                using (var context = new CinemaDBContext())
                {
                    // Reload tickets từ database với context mới để đảm bảo lấy LockedBy mới nhất
                    _tickets = context.Tickets
                        .Where(t => t.ShowTimeID == _selectedShowTimeId && !t.IsDeleted)
                        .ToList();
                }

                // Cập nhật màu sắc các button ghế
                foreach (Control control in flpTickets.Controls)
                {
                    // Bỏ qua Label "MÀN HÌNH"
                    if (control is Label) continue;

                    if (control is FlowLayoutPanel rowPanel)
                    {
                        foreach (Control ctrl in rowPanel.Controls)
                        {
                            // Bỏ qua Label hàng (A, B, C...)
                            if (ctrl is Label) continue;

                            if (ctrl is Button btnSeat && btnSeat.Tag is int seatId)
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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[RefreshSeatStatus] Error: {ex.Message}");
                Console.WriteLine($"[RefreshSeatStatus] StackTrace: {ex.StackTrace}");
            }
        }

        /// <summary>
        /// Cập nhật màu sắc và trạng thái của button ghế
        /// </summary>
        private void UpdateSeatButtonAppearance(Button btnSeat, Seat seat, Ticket ticket)
        {
            // Màu mặc định theo loại ghế
            Color seatColor = Color.DodgerBlue;
            if (seat.SeatType == "Ghế VIP") seatColor = Color.Gold;
            else if (seat.SeatType == "Ghế Đôi" || seat.SeatType == "Ghế đôi") seatColor = Color.HotPink;

            bool isSelected = _selectedTickets.Any(t => t.SeatID == seat.SeatID);
            bool isLockedByMe = ticket.LockedBy == _employee?.EmployeeID;
            bool isLockedByOther = ticket.LockedBy.HasValue && !isLockedByMe;
            bool isSold = ticket.Status == "Đã bán";

            // Thứ tự ưu tiên: Đã bán > Lock bởi người khác > Đang chọn (bởi mình hoặc đã lock) > Trống
            if (isSold)
            {
                btnSeat.BackColor = Color.Gray;
                btnSeat.Enabled = false;
            }
            else if (isLockedByOther)
            {
                // Ghế đang được nhân viên khác chọn - màu cam và disabled
                btnSeat.BackColor = Color.Orange;
                btnSeat.Enabled = false;
            }
            else if (isSelected || isLockedByMe)
            {
                // Ghế đang được mình chọn - màu xanh lá
                btnSeat.BackColor = Color.LimeGreen;
                btnSeat.Enabled = true;
            }
            else
            {
                // Ghế trống - màu gốc
                btnSeat.BackColor = seatColor;
                btnSeat.Enabled = true;
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

            DateTime now = DateTime.Now;
            foreach (var showTime in _showTimes)
            {
                DateTime bookingDeadline = showTime.StartTime.AddMinutes(15);

                // ✅ CHỈ HIỂN THỊ NẾU:
                // - Suất chiếu chưa bắt đầu (StartTime > now)
                // - HOẶC suất chiếu đã bắt đầu nhưng chưa quá 15 phút (bookingDeadline >= now)
                if (bookingDeadline < now)
                {
                    continue;
                }
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
            try
            {
                flpTickets.Controls.Clear();
                _seats = _saleTicketDAL.GetSeatsByRoomID(roomId);
                _tickets = _saleTicketDAL.GetTicketsByShowTimeID(_selectedShowTimeId);

                // Sắp xếp ghế theo tọa độ pY (hàng) và pX (cột)
                var sortedSeats = _seats.OrderBy(s => s.pY).ThenBy(s => s.pX).ToList();

                // Label "MÀN HÌNH"
                var lblScreen = new Label
                {
                    Text = "MÀN HÌNH",
                    Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.Black,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 80,
                    Width = flpTickets.Width
                };
                flpTickets.Controls.Add(lblScreen);

                // Constants giống SeatManagementUC
                const int CELL_SIZE = 58;
                const int OFFSET_Y = 90; // Bắt đầu sau label "MÀN HÌNH"
                const int OFFSET_X = 60;
                const int SNAP_GRID = 58;

                // Tìm số hàng tối đa
                int maxRow = sortedSeats.Any() ? sortedSeats.Max(s => s.pY) : 0;

                // Vẽ label hàng (A, B, C...)
                for (int row = 0; row <= maxRow; row++)
                {
                    var lblRow = new Label
                    {
                        Text = ((char)('A' + row)).ToString(),
                        Location = new Point(5, row * SNAP_GRID + OFFSET_Y),
                        Size = new Size(50, CELL_SIZE),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                        ForeColor = Color.White,
                        BackColor = Color.FromArgb(239, 68, 68)
                    };
                    flpTickets.Controls.Add(lblRow);
                }

                // Tạo button ghế dựa trên tọa độ
                foreach (var seat in sortedSeats)
                {
                    Color seatColor = Color.DodgerBlue;
                    if (seat.SeatType == "Ghế VIP") seatColor = Color.Gold;
                    else if (seat.SeatType == "Ghế Đôi" || seat.SeatType == "Ghế đôi") seatColor = Color.HotPink;

                    var ticket = _tickets.FirstOrDefault(t => t.SeatID == seat.SeatID);
                    bool isSold = ticket != null && ticket.Status == "Đã bán";
                    bool isLockedByOther = ticket != null && ticket.LockedBy.HasValue && ticket.LockedBy != _employee?.EmployeeID;
                    bool isSelected = _selectedTickets.Any(t => t.SeatID == seat.SeatID);
                    bool isLockedByMe = ticket != null && ticket.LockedBy == _employee?.EmployeeID;

                    // Tính toán vị trí dựa trên tọa độ pX, pY
                    int posX = seat.pX * SNAP_GRID + OFFSET_X;
                    int posY = seat.pY * SNAP_GRID + OFFSET_Y;

                    var btnSeat = new Button
                    {
                        Text = seat.SeatName,
                        Tag = seat.SeatID,
                        Location = new Point(posX, posY),
                        Size = new Size(
                            (seat.SeatType == "Ghế Đôi" || seat.SeatType == "Ghế đôi") ? CELL_SIZE * 2 + 8 : CELL_SIZE,
                            CELL_SIZE
                        ),
                        BackColor = isSold ? Color.Gray :
                                   (isLockedByOther ? Color.Orange :
                                   (isSelected || isLockedByMe ? Color.LimeGreen : seatColor)),
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                        Enabled = !isSold && !isLockedByOther,
                        FlatStyle = FlatStyle.Flat
                    };

                    // Style cho button
                    btnSeat.FlatAppearance.BorderSize = 1;
                    btnSeat.FlatAppearance.BorderColor = Color.White;

                    btnSeat.Click += BtnSeat_Click;
                    flpTickets.Controls.Add(btnSeat);
                }

                // Force refresh
                flpTickets.Refresh();
                flpTickets.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load ghế: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"[LoadSeatsByRoom] Error: {ex.Message}\n{ex.StackTrace}");
            }
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

            // Kiểm tra ghế có đang bị lock bởi người khác không
            // Reload ticket từ database để đảm bảo có dữ liệu mới nhất
            using (var context = new CinemaDBContext())
            {
                var freshTicket = context.Tickets
                    .FirstOrDefault(t => t.TicketID == ticket.TicketID && !t.IsDeleted);

                if (freshTicket != null)
                {
                    ticket = freshTicket;
                }
            }

            if (ticket.LockedBy.HasValue && ticket.LockedBy != _employee?.EmployeeID)
            {
                MessageBox.Show("Ghế này đang được nhân viên khác chọn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = _selectedTickets.FirstOrDefault(t => t.SeatID == seatId);
            if (selected != null)
            {
                // Bỏ chọn ghế - Unlock
                if (_employee != null)
                {
                    bool unlocked = _seatLockDAL.UnlockSeat(ticket.TicketID, _employee.EmployeeID);
                    if (unlocked)
                    {
                        _selectedTickets.Remove(selected);

                        // Reload tickets từ database để cập nhật trạng thái
                        using (var context = new CinemaDBContext())
                        {
                            _tickets = context.Tickets
                                .Where(t => t.ShowTimeID == _selectedShowTimeId && !t.IsDeleted)
                                .ToList();
                        }

                        // Cập nhật màu thông qua UpdateSeatButtonAppearance
                        var updatedTicket = _tickets.FirstOrDefault(t => t.TicketID == ticket.TicketID);
                        if (updatedTicket != null && seat != null)
                        {
                            UpdateSeatButtonAppearance(btn, seat, updatedTicket);
                        }
                    }
                }
            }
            else
            {
                // Chọn ghế - Lock
                if (_employee != null)
                {
                    bool locked = _seatLockDAL.LockSeat(ticket.TicketID, _employee.EmployeeID);
                    if (locked)
                    {
                        // Reload tickets từ database để cập nhật trạng thái
                        using (var context = new CinemaDBContext())
                        {
                            _tickets = context.Tickets
                                .Where(t => t.ShowTimeID == _selectedShowTimeId && !t.IsDeleted)
                                .ToList();
                        }

                        var updatedTicket = _tickets.FirstOrDefault(t => t.TicketID == ticket.TicketID);
                        if (updatedTicket != null)
                        {
                            _selectedTickets.Add(updatedTicket);
                            // Cập nhật màu thông qua UpdateSeatButtonAppearance
                            UpdateSeatButtonAppearance(btn, seat, updatedTicket);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể chọn ghế này!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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