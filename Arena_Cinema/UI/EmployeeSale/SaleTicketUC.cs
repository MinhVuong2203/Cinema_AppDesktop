using System;
using System.Collections.Generic;
using System.Drawing;
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
        private SaleTicketDAL _saleTicketDAL = new SaleTicketDAL();
        private List<DTO.ShowTime> _showTimes = new List<DTO.ShowTime>();
        private List<Ticket> _tickets = new List<Ticket>();
        private List<Seat> _seats = new List<Seat>();
        private List<Product> _products = new List<Product>();
        private List<int> _selectedSeatIds = new List<int>();
        private Dictionary<string, int> _selectedTicketTypeCounts = new Dictionary<string, int>();
        private List<int> _selectedProductIds = new List<int>();
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

        private void LoadMovieInfo()
        {
            ImgHelper.DisplayImageFromRelative(_movie.ImageUrl, picPoster);
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

        // Hiển thị danh sách ghế của phòng
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

        // Chọn/bỏ chọn ghế
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

        // Hiển thị các loại vé và số lượng (tăng/giảm)
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
            // Tự động phân bổ số lượng loại vé theo số ghế đã chọn (mặc định gán loại đầu tiên)
            var totalSelected = _selectedSeatIds.Count;
            var ticketTypePanels = flpTicketTypes.Controls.OfType<Panel>().ToList();
            var ticketTypes = ticketTypePanels.Select(p => ((Label)p.Controls[0]).Text.Split('\n')[0]).ToList();

            // Reset số lượng
            foreach (var panel in ticketTypePanels)
            {
                var lblCount = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name.StartsWith("lblTypeCount_"));
                if (lblCount != null) lblCount.Text = "0";
            }
            _selectedTicketTypeCounts.Clear();

            // Gán số lượng loại vé (mặc định loại đầu tiên)
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
            // Đảm bảo tổng số loại vé không vượt quá số ghế đã chọn
            int totalSelected = _selectedSeatIds.Count;
            int totalAssigned = _selectedTicketTypeCounts.Values.Sum();
            if (totalAssigned > totalSelected)
            {
                // Giảm loại vé cuối cùng
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
                var chkProduct = new CheckBox
                {
                    Text = $"{product.ProductName} ({product.Price?.ToString("C0") ?? "0đ"})",
                    Tag = product.ProductID,
                    Width = 200,
                    Height = 30,
                    Margin = new Padding(5)
                };
                chkProduct.CheckedChanged += ChkProduct_CheckedChanged;
                flpProducts.Controls.Add(chkProduct);
            }
            UpdateInvoice();
        }

        private void ChkProduct_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            var productId = (int)chk.Tag;
            if (chk.Checked)
            {
                if (!_selectedProductIds.Contains(productId))
                    _selectedProductIds.Add(productId);
            }
            else
            {
                if (_selectedProductIds.Contains(productId))
                    _selectedProductIds.Remove(productId);
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
            // Xử lý thanh toán ở đây (ví dụ: mở form Payment, lưu vào DB, ...)
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateInvoice()
        {
            // Movie info
            lbInvoiceMovie.Text = _movie != null
                ? $"Phim: {_movie.Title} ({_movie.Genre}, {_movie.DurationMinutes} phút, {_movie.AgeLimit})"
                : "Phim:";

            // ShowTime info
            var showTime = _showTimes.FirstOrDefault(st => st.ShowTimeID == _selectedShowTimeId);
            lbInvoiceShowTime.Text = showTime != null
                ? $"Suất chiếu: {showTime.StartTime:dd/MM/yyyy HH:mm} - Phòng {showTime.RoomID} - Giá vé {showTime.Price.ToString("C0")}"
                : "Suất chiếu:";

            // Selected seats
            lbInvoiceTickets.Text = "Ghế đã chọn:\n" + (_selectedSeatIds.Count > 0
                ? string.Join(", ", _seats.Where(s => _selectedSeatIds.Contains(s.SeatID)).Select(s => s.SeatName))
                : "Chưa chọn");

            // Ticket type quantities
            if (_selectedTicketTypeCounts.Count > 0)
            {
                lbInvoiceTicketTypes.Text = "Số lượng từng loại vé:\n" +
                    string.Join(", ", _selectedTicketTypeCounts.Select(kv => $"{kv.Key}: {kv.Value}"));
            }
            else
            {
                lbInvoiceTicketTypes.Text = "Số lượng từng loại vé: Chưa chọn";
            }

            // Selected products
            var selectedProducts = _products.Where(p => _selectedProductIds.Contains(p.ProductID)).ToList();
            lbInvoiceProducts.Text = "Sản phẩm đã chọn:\n" + (selectedProducts.Count > 0
                ? string.Join("\n", selectedProducts.Select(p => $"{p.ProductName} - {p.Price?.ToString("C0") ?? "0đ"}"))
                : "Chưa chọn");

            // Total
            decimal totalTickets = 0;
            foreach (var kv in _selectedTicketTypeCounts)
            {
                var price = _tickets.Where(t => t.TicketType == kv.Key).Select(t => t.Price ?? 0).FirstOrDefault();
                totalTickets += price * kv.Value;
            }
            decimal totalProducts = selectedProducts.Sum(p => p.Price ?? 0);
            lbInvoiceTotal.Text = $"Tổng tiền: {(totalTickets + totalProducts).ToString("C0")}";
        }
    }
}
