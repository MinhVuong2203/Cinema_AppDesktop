using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Revenue
{
    public partial class Main_RevenueUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private RevenueBLL _revenueBLL;
        private string _currentFilter = "day"; // day, week, month, quarter, year
        private DateTime _selectedDate;

        public Main_RevenueUC(Home home, DTO.Employee employee)
        {
            InitializeComponent();
            _home = home;
            _employee = employee;
            _revenueBLL = new RevenueBLL();
            _selectedDate = DateTime.Now;
        }

        private void Main_RevenueUC_Load(object sender, EventArgs e)
        {
            InitializeUI();
            LoadRevenueData();
        }

        #region Khởi tạo UI

        private void InitializeUI()
        {
            _currentFilter = "day";
            SetActiveFilterButton(btnDay);

            dtpSelectDate.ValueChanged -= dtpSelectDate_ValueChanged;

            dtpSelectDate.Value = DateTime.Now;
            dtpSelectDate.Format = DateTimePickerFormat.Custom;
            dtpSelectDate.CustomFormat = "dd/MM/yyyy";

            dtpSelectDate.ValueChanged += dtpSelectDate_ValueChanged;

      
            cboTopCount.SelectedIndexChanged -= cboTopCount_SelectedIndexChanged;

           
            cboTopCount.Items.Clear();
            cboTopCount.Items.AddRange(new object[] { 5, 10, 15, 20 });
            cboTopCount.SelectedIndex = 1; // Default top 10

           
            cboTopCount.SelectedIndexChanged += cboTopCount_SelectedIndexChanged;

         
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvMovieRevenue.AutoGenerateColumns = false;
            dgvMovieRevenue.Columns.Clear();
            dgvMovieRevenue.AllowUserToAddRows = false;
            dgvMovieRevenue.ReadOnly = true;
            dgvMovieRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovieRevenue.MultiSelect = false;
            dgvMovieRevenue.RowTemplate.Height = 35;

            // Set header style
            dgvMovieRevenue.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvMovieRevenue.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMovieRevenue.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMovieRevenue.ColumnHeadersHeight = 40;
            dgvMovieRevenue.EnableHeadersVisualStyles = false;

            // Cột STT
            DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
            colNo.HeaderText = "STT";
            colNo.Name = "colNo";
            colNo.Width = 60;
            colNo.ReadOnly = true;
            colNo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMovieRevenue.Columns.Add(colNo);

            // Cột Tên phim
            DataGridViewTextBoxColumn colTitle = new DataGridViewTextBoxColumn();
            colTitle.HeaderText = "Tên Phim";
            colTitle.DataPropertyName = "MovieTitle";
            colTitle.Name = "colTitle";
            colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMovieRevenue.Columns.Add(colTitle);

            // Cột Thể loại
            DataGridViewTextBoxColumn colGenre = new DataGridViewTextBoxColumn();
            colGenre.HeaderText = "Thể Loại";
            colGenre.DataPropertyName = "Genre";
            colGenre.Name = "colGenre";
            colGenre.Width = 150;
            dgvMovieRevenue.Columns.Add(colGenre);

            // Cột Số vé bán
            DataGridViewTextBoxColumn colTickets = new DataGridViewTextBoxColumn();
            colTickets.HeaderText = "Số Vé Bán";
            colTickets.DataPropertyName = "TicketsSold";
            colTickets.Name = "colTickets";
            colTickets.Width = 120;
            colTickets.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTickets.DefaultCellStyle.Format = "#,##0";
            dgvMovieRevenue.Columns.Add(colTickets);

            // Cột Doanh thu
            DataGridViewTextBoxColumn colRevenue = new DataGridViewTextBoxColumn();
            colRevenue.HeaderText = "Doanh Thu (VNĐ)";
            colRevenue.DataPropertyName = "TotalRevenue";
            colRevenue.Name = "colRevenue";
            colRevenue.Width = 200;
            colRevenue.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colRevenue.DefaultCellStyle.Format = "#,##0";
            dgvMovieRevenue.Columns.Add(colRevenue);

            // Cột Phần trăm
            DataGridViewTextBoxColumn colPercent = new DataGridViewTextBoxColumn();
            colPercent.HeaderText = "% Đóng Góp";
            colPercent.Name = "colPercent";
            colPercent.Width = 100;
            colPercent.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvMovieRevenue.Columns.Add(colPercent);
        }

        private void SetActiveFilterButton(Button activeButton)
        {
            // Reset all buttons
            Color inactiveColor = Color.FromArgb(149, 165, 166);
            Color activeColor = Color.FromArgb(52, 152, 219);

            btnDay.BackColor = inactiveColor;
            btnWeek.BackColor = inactiveColor;
            btnMonth.BackColor = inactiveColor;
            btnQuarter.BackColor = inactiveColor;
            btnYear.BackColor = inactiveColor;

            btnDay.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            btnWeek.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            btnMonth.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            btnQuarter.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            btnYear.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            // Set active button
            activeButton.BackColor = activeColor;
            activeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }

        #endregion

        #region Load Data

        private void LoadRevenueData()
        {
            try
            {
                int topCount = Convert.ToInt32(cboTopCount.SelectedItem);
                List<MovieRevenueDTO> revenueData = GetRevenueByFilter(topCount);

                if (revenueData == null || revenueData.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu doanh thu trong khoảng thời gian này!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    return;
                }

                DisplayRevenueData(revenueData);
                UpdateStatistics(revenueData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<MovieRevenueDTO> GetRevenueByFilter(int topCount)
        {
            _selectedDate = dtpSelectDate.Value;

            switch (_currentFilter)
            {
                case "day":
                    return _revenueBLL.GetTopMovieRevenueByDate(_selectedDate, topCount);

                case "week":
                    return _revenueBLL.GetTopMovieRevenueByWeek(_selectedDate, topCount);

                case "month":
                    return _revenueBLL.GetTopMovieRevenueByMonth(_selectedDate.Month, _selectedDate.Year, topCount);

                case "quarter":
                    int quarter = (_selectedDate.Month - 1) / 3 + 1;
                    return _revenueBLL.GetTopMovieRevenueByQuarter(quarter, _selectedDate.Year, topCount);

                case "year":
                    return _revenueBLL.GetTopMovieRevenueByYear(_selectedDate.Year, topCount);

                default:
                    return _revenueBLL.GetTopMovieRevenueToday(topCount);
            }
        }

        private void DisplayRevenueData(List<MovieRevenueDTO> revenueData)
        {
            dgvMovieRevenue.Rows.Clear();

            // Tính tổng doanh thu để tính phần trăm
            decimal totalRevenue = revenueData.Sum(x => x.TotalRevenue);

            for (int i = 0; i < revenueData.Count; i++)
            {
                var movie = revenueData[i];
                int rowIndex = dgvMovieRevenue.Rows.Add();
                DataGridViewRow row = dgvMovieRevenue.Rows[rowIndex];

                // STT
                row.Cells["colNo"].Value = i + 1;

                // Tên phim
                row.Cells["colTitle"].Value = movie.MovieTitle;

                // Thể loại
                row.Cells["colGenre"].Value = movie.Genre;

                // Số vé
                row.Cells["colTickets"].Value = movie.TicketsSold;

                // Doanh thu
                row.Cells["colRevenue"].Value = movie.TotalRevenue;

                // Phần trăm đóng góp
                decimal percentage = totalRevenue > 0
                    ? _revenueBLL.CalculateRevenuePercentage(movie.TotalRevenue, totalRevenue)
                    : 0;
                row.Cells["colPercent"].Value = percentage.ToString("0.00") + "%";

                // Lưu MovieID vào Tag
                row.Tag = movie.MovieID;

                // Màu xen kẽ
                if (i % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                }
            }
        }

        private void UpdateStatistics(List<MovieRevenueDTO> revenueData)
        {
            var summary = _revenueBLL.GetRevenueSummary(revenueData);

            // Tổng doanh thu
            lblTotalRevenueValue.Text = _revenueBLL.FormatCurrency(summary.TotalRevenue);

            // Tổng số vé
            lblTotalTicketsValue.Text = summary.TotalTickets.ToString("#,##0") + " vé";

            // Số phim
            lblTotalMoviesValue.Text = summary.TotalMovies.ToString() + " phim";

            // Doanh thu trung bình
            lblAverageRevenueValue.Text = _revenueBLL.FormatCurrency(summary.AverageRevenuePerMovie);
        }

        private void ClearData()
        {
            dgvMovieRevenue.Rows.Clear();
            lblTotalRevenueValue.Text = "0 ₫";
            lblTotalTicketsValue.Text = "0 vé";
            lblTotalMoviesValue.Text = "0 phim";
            lblAverageRevenueValue.Text = "0 ₫";
        }

        #endregion

        #region Filter Button Events

        private void btnDay_Click(object sender, EventArgs e)
        {
            _currentFilter = "day";
            SetActiveFilterButton(btnDay);
            LoadRevenueData();
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            _currentFilter = "week";
            SetActiveFilterButton(btnWeek);
            LoadRevenueData();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            _currentFilter = "month";
            SetActiveFilterButton(btnMonth);
            LoadRevenueData();
        }

        private void btnQuarter_Click(object sender, EventArgs e)
        {
            _currentFilter = "quarter";
            SetActiveFilterButton(btnQuarter);
            LoadRevenueData();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            _currentFilter = "year";
            SetActiveFilterButton(btnYear);
            LoadRevenueData();
        }

        #endregion

        #region Other Events

        private void dtpSelectDate_ValueChanged(object sender, EventArgs e)
        {
            LoadRevenueData();
        }

        private void cboTopCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRevenueData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtpSelectDate.Value = DateTime.Now;
            _selectedDate = DateTime.Now;
            LoadRevenueData();
        }

        private void dgvMovieRevenue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                int movieId = Convert.ToInt32(dgvMovieRevenue.Rows[e.RowIndex].Tag);
                string movieTitle = dgvMovieRevenue.Rows[e.RowIndex].Cells["colTitle"].Value.ToString();

                // Hiển thị chi tiết doanh thu phim
                ShowMovieRevenueDetail(movieId, movieTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Helper Methods

        private void ShowMovieRevenueDetail(int movieId, string movieTitle)
        {
            try
            {
                MovieRevenueDetailDTO detail = null;

                // Lấy chi tiết theo filter hiện tại
                switch (_currentFilter)
                {
                    case "day":
                    case "week":
                    case "month":
                        detail = _revenueBLL.GetMovieRevenueDetail(movieId, _selectedDate.Month, _selectedDate.Year);
                        break;

                    case "quarter":
                        // Lấy theo quý - cần tạo method mới
                        int quarter = (_selectedDate.Month - 1) / 3 + 1;
                        detail = GetMovieRevenueDetailByQuarter(movieId, quarter, _selectedDate.Year);
                        break;

                    case "year":
                        detail = _revenueBLL.GetMovieRevenueDetailByYear(movieId, _selectedDate.Year);
                        break;
                }

                if (detail == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu chi tiết cho phim này!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string message = $"CHI TIẾT DOANH THU PHIM\n\n" +
                                $"Tên phim: {detail.MovieTitle}\n" +
                                $"Thể loại: {detail.Genre}\n" +
                                $"Kỳ: {detail.Period}\n\n" +
                                $"Tổng doanh thu: {_revenueBLL.FormatCurrency(detail.TotalRevenue)}\n" +
                                $"Tổng số vé: {detail.TicketsSold:N0} vé\n" +
                                $"Giá vé trung bình: {_revenueBLL.FormatCurrency(detail.AverageTicketPrice)}";

                MessageBox.Show(message, "Chi tiết doanh thu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private MovieRevenueDetailDTO GetMovieRevenueDetailByQuarter(int movieId, int quarter, int year)
        {
            var movie = new MovieDAL().GetMovieById(movieId); // Hoặc lấy từ data hiện có
            if (movie == null) return null;

            // Tính khoảng thời gian của quý
            int startMonth = (quarter - 1) * 3 + 1;
            int endMonth = startMonth + 2;

            DateTime startDate = new DateTime(year, startMonth, 1);
            DateTime endDate = new DateTime(year, endMonth, DateTime.DaysInMonth(year, endMonth)).AddDays(1);

            // Lấy dữ liệu từ database
            var _db = new CinemaDBContext();

            var revenues = from invoice in _db.Invoices
                           join invoiceTicket in _db.InvoiceTickets on invoice.InvoiceID equals invoiceTicket.InvoiceID
                           join ticket in _db.Tickets on invoiceTicket.TicketID equals ticket.TicketID
                           join showtime in _db.ShowTimes on ticket.ShowTimeID equals showtime.ShowTimeID
                           where !invoice.IsDeleted
                               && invoice.Status == "Đã thanh toán"
                               && invoice.IssueDate >= startDate
                               && invoice.IssueDate < endDate
                               && showtime.MovieID == movieId
                           select new
                           {
                               Revenue = (invoiceTicket.UnitPrice ?? 0) * (invoiceTicket.Quantity ?? 1),
                               Tickets = invoiceTicket.Quantity ?? 1
                           };

            var revenueList = revenues.ToList();

            return new MovieRevenueDetailDTO
            {
                MovieID = movieId,
                MovieTitle = movie.Title,
                ImageUrl = movie.ImageUrl,
                Genre = movie.Genre,
                TotalRevenue = revenueList.Sum(x => x.Revenue),
                TicketsSold = revenueList.Sum(x => x.Tickets),
                AverageTicketPrice = revenueList.Sum(x => x.Tickets) > 0
                    ? revenueList.Sum(x => x.Revenue) / revenueList.Sum(x => x.Tickets)
                    : 0,
                Period = $"Quý {quarter}/{year}"
            };
        }

        #endregion
    }
}