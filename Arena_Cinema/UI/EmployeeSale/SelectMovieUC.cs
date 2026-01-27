using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BLL;
using Common;
using DAL;
using DTO;

namespace UI.EmployeeSale
{
    public partial class SelectMovieUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private MovieBLL _movieBLL = new MovieBLL();
        private List<DTO.Movie> _allMoviesShowingToday;

        public SelectMovieUC(Home form, DTO.Employee employee)
        {
            InitializeComponent();
            _home = form;
            _employee = employee;
            
            InitializeUI();
            LoadMoviesShowingToday();
            StartClock();
        }

        private void InitializeUI()
        {
            // Khởi tạo ComboBox
            cboGenre.SelectedIndex = 0;
            
            // Placeholder cho TextBox
            txtSearch.ForeColor = Color.FromArgb(156, 163, 175);
            
            // Subscribe events
            cboGenre.SelectedIndexChanged += CboGenre_SelectedIndexChanged;
        }

        private void StartClock()
        {
            UpdateDateTime();
            timerClock.Start();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            DateTime now = DateTime.Now;
            string dayOfWeek = now.ToString("dddd", new System.Globalization.CultureInfo("vi-VN"));
            dayOfWeek = char.ToUpper(dayOfWeek[0]) + dayOfWeek.Substring(1);
            
            lblDateTime.Text = $"📅 {dayOfWeek}, {now:dd/MM/yyyy} - ⏰ {now:HH:mm:ss}";
        }

        private void LoadMoviesShowingToday()
        {
            flpMovies.Controls.Clear();

            using (var showTimeDAL = new ShowTimeDAL())
            {
                var todayShowTimes = showTimeDAL.GetTodayShowTimes();

                var movieIdsWithShowTime = todayShowTimes
                    .Select(st => st.MovieID)
                    .Distinct()
                    .ToList();

                var allMovies = _movieBLL.GetAllMovies();
                _allMoviesShowingToday = allMovies
                    .Where(m => movieIdsWithShowTime.Contains(m.MovieID) && !m.IsDeleted)
                    .ToList();

                // Cập nhật số lượng phim
                lblMovieCount.Text = $"Đang chiếu {_allMoviesShowingToday.Count} phim hôm nay";

                DisplayMovies(_allMoviesShowingToday);
            }
        }

        private void DisplayMovies(List<DTO.Movie> movies)
        {
            flpMovies.Controls.Clear();

            if (!movies.Any())
            {
                // Hiển thị thông báo không có phim
                var lblNoMovie = new Label
                {
                    Text = "📽️ Không có phim nào chiếu trong ngày hôm nay",
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(156, 163, 175),
                    AutoSize = true,
                    Padding = new Padding(50),
                    Margin = new Padding(300, 100, 0, 0)
                };
                flpMovies.Controls.Add(lblNoMovie);
                return;
            }

            foreach (var movie in movies)
            {
                // Panel chính cho mỗi phim
                var panel = new Panel
                {
                    Width = 350,
                    Height = 600,
                    Margin = new Padding(15),
                    BackColor = Color.White,
                    Cursor = Cursors.Hand
                };

                // Shadow effect (sử dụng border)
                panel.Paint += (s, e) =>
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (var pen = new Pen(Color.FromArgb(229, 231, 235), 2))
                    {
                        e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
                    }
                };

                // PictureBox cho poster phim
                var picPoster = new PictureBox
                {
                    Location = new Point(0, 0),
                    Size = new Size(350, 450),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.FromArgb(243, 244, 246)
                };
                ImgHelper.DisplayImageFromRelative(movie.ImageUrl, picPoster);

                // Badge độ tuổi
                var lblAgeBadge = new Label
                {
                    Location = new Point(10, 10),
                    Size = new Size(50, 30),
                    Text = movie.AgeLimit,
                    BackColor = Color.FromArgb(220, 38, 38),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Tên phim
                var lbTitle = new Label
                {
                    Location = new Point(15, 460),
                    Size = new Size(320, 60),
                    Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(31, 41, 55),
                    Text = movie.Title,
                    AutoEllipsis = true
                };

                // Thông tin phim
                var lbInfo = new Label
                {
                    Location = new Point(15, 520),
                    Size = new Size(320, 25),
                    Font = new Font("Segoe UI", 9.5F),
                    ForeColor = Color.FromArgb(107, 114, 128),
                    Text = $"🎭 {movie.Genre}"
                };

                var lbDuration = new Label
                {
                    Location = new Point(15, 545),
                    Size = new Size(150, 25),
                    Font = new Font("Segoe UI", 9.5F),
                    ForeColor = Color.FromArgb(107, 114, 128),
                    Text = $"⏱️ {movie.DurationMinutes} phút"
                };

                // Nút đặt vé
                var btnBook = new ReaLTaiizor.Controls.MaterialButton
                {
                    Location = new Point(180, 540),
                    Size = new Size(155, 45),
                    Text = "ĐẶT VÉ",
                    BackColor = Color.FromArgb(220, 38, 38),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    UseVisualStyleBackColor = false,
                    Cursor = Cursors.Hand,
                    Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained
                };
                btnBook.Click += (s, e) => _home.LoadControl(new SaleTicketUC(movie, _home, _employee));

                // Thêm hover effect cho panel
                panel.MouseEnter += (s, e) =>
                {
                    panel.BackColor = Color.FromArgb(248, 250, 252);
                };
                panel.MouseLeave += (s, e) =>
                {
                    panel.BackColor = Color.White;
                };

                // Click panel cũng chuyển trang
                picPoster.Click += (s, e) => btnBook.PerformClick();
                lbTitle.Click += (s, e) => btnBook.PerformClick();

                // Thêm controls vào panel
                panel.Controls.Add(picPoster);
                panel.Controls.Add(lblAgeBadge);
                panel.Controls.Add(lbTitle);
                panel.Controls.Add(lbInfo);
                panel.Controls.Add(lbDuration);
                panel.Controls.Add(btnBook);

                flpMovies.Controls.Add(panel);
            }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập tên phim...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.FromArgb(31, 41, 55);
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Nhập tên phim...";
                txtSearch.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterMovies();
        }

        private void CboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMovies();
        }

        private void FilterMovies()
        {
            if (_allMoviesShowingToday == null) return;

            var filtered = _allMoviesShowingToday.AsEnumerable();

            // Lọc theo tên phim
            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text != "Nhập tên phim...")
            {
                var searchText = txtSearch.Text.ToLower();
                filtered = filtered.Where(m => m.Title.ToLower().Contains(searchText));
            }

            // Lọc theo thể loại
            if (cboGenre.SelectedIndex > 0)
            {
                var selectedGenre = cboGenre.Text.ToLower();
                filtered = filtered.Where(m => m.Genre != null && m.Genre.ToLower().Contains(selectedGenre));
            }

            var result = filtered.ToList();
            
            // Cập nhật số lượng
            lblMovieCount.Text = $"Tìm thấy {result.Count} phim";

            DisplayMovies(result);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _home.LoadControl(new SaleHomeUC(_home, _employee));
        }
    }
}
