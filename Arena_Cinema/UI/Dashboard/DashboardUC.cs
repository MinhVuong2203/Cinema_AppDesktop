using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using Common;
using DTO;

namespace UI.Dashboard
{
    public partial class DashboardUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private MovieBLL _movieBLL;
        private List<DTO.Movie> _allUpcomingMovies;
        private int _currentPage = 0;
        private const int MOVIES_PER_PAGE = 4; // Số phim trên 1 trang

        public DashboardUC(Home home, DTO.Employee employee)
        {
            InitializeComponent();
            _home = home;
            _employee = employee;
            _movieBLL = new MovieBLL();
            _allUpcomingMovies = new List<DTO.Movie>();

            // Gán sự kiện cho các nút
            btnNext.Click += BtnNext_Click;
            btnPrev.Click += BtnPrev_Click;
        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            LoadUpcomingMovies();
        }

        public void RefreshData()
        {
            LoadUpcomingMovies();
        }

        public void LoadUpcomingMovies()
        {
            try
            {
                // Lấy tất cả phim
                List<DTO.Movie> allMovies = _movieBLL.GetAllMovies();

                // Lọc phim sắp chiếu
                _allUpcomingMovies = allMovies
                    .Where(m => _movieBLL.GetMovieStatus(m) == "Sắp chiếu")
                    .OrderBy(m => m.StartTime)
                    .ToList();

                _currentPage = 0;

                if (_allUpcomingMovies.Count == 0)
                {
                    flowPanelMovies.Visible = false;
                    lblNoData.Visible = true;
                    lblTitle.Text = "PHIM SẮP CHIẾU (0 phim)";
                    btnNext.Enabled = false;
                    btnPrev.Enabled = false;
                    return;
                }

                flowPanelMovies.Visible = true;
                lblNoData.Visible = false;
                lblTitle.Text = $"PHIM SẮP CHIẾU ({_allUpcomingMovies.Count} phim)";

                DisplayPage(_currentPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải phim sắp chiếu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayPage(int pageIndex)
        {
            flowPanelMovies.Controls.Clear();

            int totalPages = (int)Math.Ceiling((double)_allUpcomingMovies.Count / MOVIES_PER_PAGE);

            // Giới hạn pageIndex
            if (pageIndex < 0) pageIndex = 0;
            if (pageIndex >= totalPages) pageIndex = totalPages - 1;

            _currentPage = pageIndex;

            // Lấy phim của trang hiện tại
            var moviesInPage = _allUpcomingMovies
                .Skip(pageIndex * MOVIES_PER_PAGE)
                .Take(MOVIES_PER_PAGE)
                .ToList();

            // Thêm poster
            foreach (var movie in moviesInPage)
            {
                Panel moviePanel = CreateMoviePanel(movie);
                flowPanelMovies.Controls.Add(moviePanel);
            }

            // Cập nhật trạng thái nút
            btnPrev.Enabled = pageIndex > 0;
            btnNext.Enabled = pageIndex < totalPages - 1;

            // Cập nhật text hiển thị trang
            lblTitle.Text = $"PHIM SẮP CHIẾU ({_allUpcomingMovies.Count} phim) - Trang {pageIndex + 1}/{totalPages}";
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_allUpcomingMovies.Count / MOVIES_PER_PAGE);
            if (_currentPage < totalPages - 1)
            {
                DisplayPage(_currentPage + 1);
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 0)
            {
                DisplayPage(_currentPage - 1);
            }
        }

        private Panel CreateMoviePanel(DTO.Movie movie)
        {
            Panel panel = new Panel
            {
                Width = 280,
                Height = 380,
                Margin = new Padding(20),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand,
                Tag = movie.MovieID
            };

            // Poster
            PictureBox pictureBox = new PictureBox
            {
                Width = 240,
                Height = 280,
                Left = 20,
                Top = 20,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand
            };

            // Load ảnh poster
            LoadMoviePoster(pictureBox, movie.ImageUrl);

            // Label tên phim
            Label titleLabel = new Label
            {
                Text = movie.Title,
                Left = 20,
                Top = 310,
                Width = 240,
                Height = 50,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = false,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                TextAlign = ContentAlignment.TopLeft
            };

            // Tooltip
            ToolTip toolTip = new ToolTip();
            string tooltipText = $"{movie.Title}\nKhởi chiếu: {movie.StartTime:dd/MM/yyyy}\nThể loại: {movie.Genre}";
            toolTip.SetToolTip(pictureBox, tooltipText);
            toolTip.SetToolTip(titleLabel, tooltipText);

            // Sự kiện click
            EventHandler clickHandler = (s, e) => ShowMovieDetails(movie);
            pictureBox.Click += clickHandler;
            titleLabel.Click += clickHandler;
            panel.Click += clickHandler;

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(titleLabel);

            return panel;
        }

        private void LoadMoviePoster(PictureBox pictureBox, string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath))
                {
                    System.Diagnostics.Debug.WriteLine($"Loading image: {imagePath}");
                    ImgHelper.DisplayImageFromRelative(imagePath, pictureBox);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Image path is empty");
                    pictureBox.BackColor = Color.LightGray;
                    pictureBox.Image = null;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi load hình: {ex.Message}");
                pictureBox.BackColor = Color.LightGray;
                pictureBox.Image = null;
            }
        }

        private void ShowMovieDetails(DTO.Movie movie)
        {
            string details = $"Tên phim: {movie.Title}\n\n" +
                           $"Thể loại: {movie.Genre}\n\n" +
                           $"Khởi chiếu: {movie.StartTime:dd/MM/yyyy}\n\n" +
                           $"Kết thúc: {(movie.EndTime.HasValue ? movie.EndTime.Value.ToString("dd/MM/yyyy") : "Chưa xác định")}\n\n" +
                           $"Thời lượng: {_movieBLL.FormatDuration(movie.DurationMinutes)}\n\n" +
                           $"Ngôn ngữ: {movie.Language}\n\n" +
                           $"Giới hạn tuổi: {movie.AgeLimit}\n\n" +
                           $"Loại phim: {movie.MovieType}";

            MessageBox.Show(details, $"Chi tiết phim - {movie.Title}",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}