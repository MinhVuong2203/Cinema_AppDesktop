using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;
using Common;
using DAL;

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
        private List<int> _selectedSeatIds = new List<int>();
        private Dictionary<string, int> _selectedTicketTypeCounts = new Dictionary<string, int>();
        private List<int> _selectedProductIds = new List<int>();
        private Dictionary<int, int> _selectedProductQuantities = new Dictionary<int, int>();
        private Guid _selectedShowTimeId = Guid.Empty;

        // Constructor
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

            // Đăng ký sự kiện cho nút back nếu có
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

        // Hàm quay lại trang chọn phim
        private void btn_back_Click(object sender, EventArgs e)
        {
            if (_parentForm != null && _employee != null)
            {
                _parentForm.LoadControl(new SelectMovieUC(_parentForm, _employee));
            }
            else
            {
                // Fallback nếu không có parent
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
                LoadTicketTypes(showTimeId);
            }

            _selectedSeatIds.Clear();
            _selectedTicketTypeCounts.Clear();
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
                var isSelected = _selectedSeatIds.Contains(seat.SeatID);

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
            if (_selectedSeatIds.Contains(seatId))
            {
                _selectedSeatIds.Remove(seatId);
                btn.BackColor = Color.White;
            }
            else
            {
                _selectedSeatIds.Add(seatId);
                btn.BackColor = Color.Yellow;
            }
            UpdateTicketTypePanel();
            UpdateInvoice();
        }

        private void LoadTicketTypes(Guid showTimeId)
        {
            flpTicketTypes.Controls.Clear();
            var ticketTypeDict = _saleTicketDAL.GetTicketTypesByShowTimeID(showTimeId);
            _tickets = _saleTicketDAL.GetTicketsByShowTimeID(showTimeId);

            foreach (var kv in ticketTypeDict)
            {
                var price = _tickets.Where(t => t.TicketType == kv.Key).Select(t => t.Price ?? 0).FirstOrDefault();
                var panel = new Panel { Width = 180, Height = 50, Margin = new Padding(5) };

                var lblType = new Label
                {
                    Text = $"{kv.Key}\n{price.ToString("C0")}",
                    Width = 100,
                    Height = 40,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                var btnMinus = new Button
                {
                    Text = "-",
                    Width = 30,
                    Height = 30,
                    Tag = kv.Key
                };
                btnMinus.Click += BtnTicketTypeMinus_Click;

                var btnPlus = new Button
                {
                    Text = "+",
                    Width = 30,
                    Height = 30,
                    Tag = kv.Key
                };
                btnPlus.Click += BtnTicketTypePlus_Click;

                var lblCount = new Label
                {
                    Text = "0",
                    Width = 20,
                    Height = 30,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Name = $"lblTypeCount_{kv.Key}"
                };

                panel.Controls.Add(lblType);
                panel.Controls.Add(btnMinus);
                panel.Controls.Add(lblCount);
                panel.Controls.Add(btnPlus);

                lblType.Location = new Point(0, 5);
                btnMinus.Location = new Point(105, 10);
                lblCount.Location = new Point(140, 10);
                btnPlus.Location = new Point(165, 10);

                flpTicketTypes.Controls.Add(panel);
            }
        }

        private void UpdateTicketTypePanel()
        {
            var totalSelected = _selectedSeatIds.Count;
            var ticketTypePanels = flpTicketTypes.Controls.OfType<Panel>().ToList();
            var ticketTypes = ticketTypePanels.Select(p => ((Label)p.Controls[0]).Text.Split('\n')[0]).ToList();

            foreach (var panel in ticketTypePanels)
            {
                var lblCount = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name.StartsWith("lblTypeCount_"));
                if (lblCount != null) lblCount.Text = "0";
            }
            _selectedTicketTypeCounts.Clear();

            if (ticketTypes.Count > 0 && totalSelected > 0)
            {
                _selectedTicketTypeCounts[ticketTypes[0]] = totalSelected;
                var panel = ticketTypePanels[0];
                var lblCount = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name.StartsWith("lblTypeCount_"));
                if (lblCount != null) lblCount.Text = totalSelected.ToString();
            }
        }

        private void BtnTicketTypeMinus_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var ticketType = btn.Tag as string;
            var panel = btn.Parent as Panel;
            var lblCount = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == $"lblTypeCount_{ticketType}");
            int current = int.Parse(lblCount.Text);
            if (current > 0)
            {
                lblCount.Text = (current - 1).ToString();
                _selectedTicketTypeCounts[ticketType] = current - 1;
            }
            UpdateTotalTicketTypeCount();
            UpdateInvoice();
        }

        private void BtnTicketTypePlus_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var ticketType = btn.Tag as string;
            var panel = btn.Parent as Panel;
            var lblCount = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == $"lblTypeCount_{ticketType}");
            int current = int.Parse(lblCount.Text);
            int totalSelected = _selectedSeatIds.Count;
            int totalAssigned = _selectedTicketTypeCounts.Values.Sum();
            if (totalAssigned < totalSelected)
            {
                lblCount.Text = (current + 1).ToString();
                _selectedTicketTypeCounts[ticketType] = current + 1;
            }
            UpdateTotalTicketTypeCount();
            UpdateInvoice();
        }

        private void UpdateTotalTicketTypeCount()
        {
            int totalSelected = _selectedSeatIds.Count;
            int totalAssigned = _selectedTicketTypeCounts.Values.Sum();
            if (totalAssigned > totalSelected)
            {
                var lastType = _selectedTicketTypeCounts.Keys.LastOrDefault();
                if (lastType != null && _selectedTicketTypeCounts[lastType] > 0)
                {
                    _selectedTicketTypeCounts[lastType]--;
                    var panel = flpTicketTypes.Controls.OfType<Panel>().FirstOrDefault(p =>
                        ((Label)p.Controls[0]).Text.Split('\n')[0] == lastType);
                    var lblCount = panel?.Controls.OfType<Label>().FirstOrDefault(l => l.Name == $"lblTypeCount_{lastType}");
                    if (lblCount != null) lblCount.Text = _selectedTicketTypeCounts[lastType].ToString();
                }
            }
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
            lbInvoiceMovie.Text = _movie != null
                ? $"Phim: {_movie.Title} ({_movie.Genre}, {_movie.DurationMinutes} phút, {_movie.AgeLimit})"
                : "Phim:";

            var showTime = _showTimes.FirstOrDefault(st => st.ShowTimeID == _selectedShowTimeId);
            lbInvoiceShowTime.Text = showTime != null
                ? $"Suất chiếu: {showTime.StartTime:dd/MM/yyyy HH:mm} - Phòng {showTime.RoomID} - Giá vé {showTime.Price.ToString("C0")}"
                : "Suất chiếu:";

            lbInvoiceTickets.Text = "Ghế đã chọn:\n" + (_selectedSeatIds.Count > 0
                ? string.Join(", ", _seats.Where(s => _selectedSeatIds.Contains(s.SeatID)).Select(s => s.SeatName))
                : "Chưa chọn");

            if (_selectedTicketTypeCounts.Count > 0)
            {
                lbInvoiceTicketTypes.Text = "Số lượng từng loại vé:\n" +
                    string.Join(", ", _selectedTicketTypeCounts.Select(kv => $"{kv.Key}: {kv.Value}"));
            }
            else
            {
                lbInvoiceTicketTypes.Text = "Số lượng từng loại vé: Chưa chọn";
            }

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

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            if (_parentForm != null && _employee != null)
            {
                _parentForm.LoadControl(new SelectMovieUC(_parentForm, _employee));
            }
            else
            {
                // Fallback nếu không có parent
                var parent = this.Parent as Home;
                if (parent != null && _employee != null)
                {
                    parent.LoadControl(new SelectMovieUC(parent, _employee));
                }
            }
        }
    }
}