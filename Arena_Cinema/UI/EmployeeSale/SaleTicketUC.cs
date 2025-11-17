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
        private List<Product> _products = new List<Product>();
        private List<Guid> _selectedTickets = new List<Guid>();
        private List<int> _selectedProducts = new List<int>();

        public SaleTicketUC(DTO.Movie movie)
        {
            InitializeComponent();
            _movie = movie;
            LoadMovieInfo();
            LoadShowTimes();
            LoadProducts();
            cboShowTime.SelectedIndexChanged += CboShowTime_SelectedIndexChanged;
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
            cboShowTime.Items.Clear();
            foreach (var st in _showTimes)
            {
                cboShowTime.Items.Add($"{st.StartTime:HH:mm dd/MM/yyyy} - Phòng {st.RoomID}");
            }
            if (cboShowTime.Items.Count > 0)
                cboShowTime.SelectedIndex = 0;
        }

        private void CboShowTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShowTime.SelectedIndex < 0) return;
            var showTime = _showTimes[cboShowTime.SelectedIndex];
            LoadTickets(showTime.ShowTimeID);
        }

        private void LoadTickets(Guid showTimeID)
        {
            flpTickets.Controls.Clear();
            _tickets = _saleTicketDAL.GetTicketsByShowTimeID(showTimeID);
            foreach (var ticket in _tickets)
            {
                var btnSeat = new Button
                {
                    Text = $"Ghế {ticket.SeatID}",
                    Tag = ticket.TicketID,
                    Width = 80,
                    Height = 40,
                    Margin = new Padding(5),
                    BackColor = ticket.Status == "Đã bán" ? Color.Gray : Color.LightGreen,
                    Enabled = ticket.Status != "Đã bán"
                };
                btnSeat.Click += BtnSeat_Click;
                flpTickets.Controls.Add(btnSeat);
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var ticketID = (Guid)btn.Tag;
            if (_selectedTickets.Contains(ticketID))
            {
                _selectedTickets.Remove(ticketID);
                btn.BackColor = Color.LightGreen;
            }
            else
            {
                _selectedTickets.Add(ticketID);
                btn.BackColor = Color.Orange;
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
        }

        private void ChkProduct_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            var productID = (int)chk.Tag;
            if (chk.Checked)
            {
                if (!_selectedProducts.Contains(productID))
                    _selectedProducts.Add(productID);
            }
            else
            {
                if (_selectedProducts.Contains(productID))
                    _selectedProducts.Remove(productID);
            }
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            if (_selectedTickets.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Xử lý thanh toán ở đây (ví dụ: mở form Payment, lưu vào DB, ...)
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
