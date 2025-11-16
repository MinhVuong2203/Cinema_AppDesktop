using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Common; // Thêm namespace Common

namespace UI.Movie
{
    public partial class Movie_MainUC : UserControl
    {
        private bool isFirstLoad = true;
        private Home _home;
        private DTO.Employee _employee;
        private MovieBLL movieBLL;

        private int currentPage = 1;
        private int pageSize = 8; // 8 phim mỗi trang (2 hàng x 4 cột)
        private int totalPages = 1;
        private List<DTO.Movie> currentMovies = new List<DTO.Movie>();

        public Movie_MainUC(Home form, DTO.Employee employee)
        {
            InitializeComponent();
            this.Load += Movie_MainUC_Load;
            this._home = form;
            this._employee = employee;

            movieBLL = new MovieBLL();

            // Setup events
            btnSearch.Click += BtnSearch_Click;
            cboFilter.SelectedIndexChanged += CboFilter_SelectedIndexChanged;
            btnAddMovie.Click += BtnAddMovie_Click;

            // Pagination events
            btnFirstPage.Click += (s, e) => NavigateToPage(1);
            btnPrevPage.Click += (s, e) => NavigateToPage(currentPage - 1);
            btnPage2.Click += (s, e) => NavigateToPage(int.Parse(btnPage2.Text));
            btnPage3.Click += (s, e) => NavigateToPage(int.Parse(btnPage3.Text));
            btnNextPage.Click += (s, e) => NavigateToPage(currentPage + 1);
            btnLastPage.Click += (s, e) => NavigateToPage(totalPages);
        }

        private void Movie_MainUC_Load(object sender, EventArgs e)
        {
            // Lắng nghe resize để điều chỉnh margin động
            this.SizeChanged += (s, ev) => AdjustCardMargins();
            panel_movie.SizeChanged += (s, ev) => AdjustCardMargins();

            // Load dữ liệu ban đầu
            LoadMovies();

            // QUAN TRỌNG: Delay để đảm bảo control đã render xong
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((state) =>
            {
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        AdjustCardMargins();
                        isFirstLoad = false;
                    }));
                    timer?.Dispose();
                }
            }, null, 100, System.Threading.Timeout.Infinite);
        }

        private void LoadMovies()
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                string filterStatus = cboFilter.SelectedItem?.ToString() ?? "Tất cả phim";

                // Lấy dữ liệu với phân trang
                currentMovies = movieBLL.SearchMoviesWithPaging(
                    searchText,
                    filterStatus,
                    currentPage,
                    pageSize,
                    out totalPages);

                // Hiển thị phim
                DisplayMovies(currentMovies);

                // Cập nhật thông tin
                UpdateInfoLabel();

                // Cập nhật pagination
                UpdatePaginationButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMovies(List<DTO.Movie> movies)
        {
            // Clear old cards
            moviesContainer.Controls.Clear();

            if (movies == null || movies.Count == 0)
            {
                Label lblNoData = new Label
                {
                    Text = "Không tìm thấy phim nào!",
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                moviesContainer.Controls.Add(lblNoData);
                return;
            }

            // Tạo card cho mỗi phim
            foreach (var movie in movies)
            {
                var card = CreateMovieCard(movie);
                moviesContainer.Controls.Add(card);
            }
        }

        private ReaLTaiizor.Controls.MaterialCard CreateMovieCard(DTO.Movie movie)
        {
            var card = new ReaLTaiizor.Controls.MaterialCard
            {
                BackColor = Color.FromArgb(255, 255, 255),
                Size = new Size(296, 380),
                Margin = new Padding(6)
            };

            // Badge (trạng thái)
            string status = movieBLL.GetMovieStatus(movie);
            Label badge = new Label
            {
                BackColor = GetStatusColor(status),
                Font = new Font("Segoe UI", 7F, FontStyle.Bold),
                ForeColor = status == "Sắp chiếu" ? Color.Black : Color.White,
                Location = new Point(8, 8),
                Size = new Size(75, 18),
                Text = status,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Poster - Sử dụng PictureBox để hiển thị ảnh
            PictureBox posterPicBox = new PictureBox
            {
                Location = new Point(10, 10),
                Size = new Size(276, 180),
                BackColor = Color.FromArgb(200, 200, 200),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            // Load ảnh từ đường dẫn tương đối sử dụng ImgHelper
            if (!string.IsNullOrEmpty(movie.ImageUrl))
            {
                ImgHelper.DisplayImageFromRelative(movie.ImageUrl, posterPicBox);
            }

            // Title
            Label lblTitle = new Label
            {
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50),
                Location = new Point(10, 200),
                Size = new Size(276, 45),
                Text = movie.Title
            };

            // Duration
            Label lblDuration = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(12, 250),
                Text = $"🔴 {movieBLL.FormatDuration(movie.DurationMinutes)}"
            };

            // Category
            Label lblCategory = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(12, 270),
                Text = $"❤️ {movie.Sub ?? "Chưa xác định"}"
            };

            // Language
            Label lblLanguage = new Label
            {
                AutoSize = true,
                BackColor = Color.FromArgb(220, 53, 69),
                Font = new Font("Segoe UI", 7F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(12, 292),
                Padding = new Padding(4),
                Text = $"🎬 {movie.Language}"
            };

            // Dates
            Label lblDates = new Label
            {
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(12, 320),
                Size = new Size(275, 30),
                Text = movieBLL.FormatMovieDates(movie)
            };

            // Buttons
            var btnView = CreateActionButton("👁", Color.FromArgb(23, 162, 184), new Point(12, 350));
            btnView.Click += (s, e) => ViewMovieDetail(movie);

            var btnEdit = CreateActionButton("✏", Color.FromArgb(255, 193, 7), new Point(125, 350));
            btnEdit.Click += (s, e) => EditMovie(movie);

            var btnDelete = CreateActionButton("🗑", Color.FromArgb(220, 53, 69), new Point(245, 350));
            btnDelete.Click += (s, e) => DeleteMovie(movie);

            // Add controls to card
            card.Controls.AddRange(new Control[] {
                posterPicBox, // Thay đổi từ poster Panel sang PictureBox
                badge, lblTitle, lblDuration, lblCategory,
                lblLanguage, lblDates, btnView, btnEdit, btnDelete
            });

            return card;
        }

        private ReaLTaiizor.Controls.ParrotButton CreateActionButton(string text, Color bgColor, Point location)
        {
            return new ReaLTaiizor.Controls.ParrotButton
            {
                BackgroundColor = bgColor,
                ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded,
                ButtonText = text,
                CornerRadius = 3,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Location = location,
                Size = new Size(40, 25),
                TextColor = Color.White
            };
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Đang chiếu":
                    return Color.FromArgb(40, 167, 69); // Green
                case "Sắp chiếu":
                    return Color.FromArgb(255, 193, 7); // Yellow
                case "Đã kết thúc":
                    return Color.FromArgb(108, 117, 125); // Gray
                default:
                    return Color.FromArgb(23, 162, 184); // Blue
            }
        }

        private void ViewMovieDetail(DTO.Movie movie)
        {
            // TODO: Implement view detail
            string details = $"Tên phim: {movie.Title}\n" +
                           $"Thời lượng: {movieBLL.FormatDuration(movie.DurationMinutes)}\n" +
                           $"Thể loại: {movie.Sub}\n" +
                           $"Ngôn ngữ: {movie.Language}\n" +
                           $"Giới hạn tuổi: {movie.AgeLimit}\n" +
                           $"Trạng thái: {movieBLL.GetMovieStatus(movie)}\n" +
                           $"Mô tả: {movie.Description}";

            MessageBox.Show(details, "Chi tiết phim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditMovie(DTO.Movie movie)
        {
            // TODO: Implement edit - Tạo form EditMovieUC tương tự AddMovieUC
            MessageBox.Show($"Chức năng chỉnh sửa phim '{movie.Title}' đang được phát triển!",
                "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteMovie(DTO.Movie movie)
        {
            var confirmResult = MessageBox.Show(
                $"Bạn có chắc muốn xóa phim '{movie.Title}'?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                var result = movieBLL.DeleteMovie(movie.MovieID);

                if (result.Item1)
                {
                    MessageBox.Show(result.Item2, "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMovies(); // Reload
                }
                else
                {
                    MessageBox.Show(result.Item2, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateInfoLabel()
        {
            int totalMovies = currentMovies.Count;
            lblInfo.Text = $"Tìm thấy: {totalMovies} phim                                                                                                                                                                 Trang {currentPage} / {totalPages}";
        }

        private void UpdatePaginationButtons()
        {
            // Enable/Disable buttons
            btnFirstPage.Enabled = currentPage > 1;
            btnPrevPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPages;
            btnLastPage.Enabled = currentPage < totalPages;

            // Update page numbers
            btnFirstPage.Text = "1";
            btnPrevPage.Text = currentPage > 1 ? (currentPage - 1).ToString() : "1";
            btnPage2.Text = currentPage.ToString();
            btnPage3.Text = currentPage < totalPages ? (currentPage + 1).ToString() : currentPage.ToString();

            // Highlight current page
            btnFirstPage.BackgroundColor = currentPage == 1
                ? Color.FromArgb(220, 53, 69)
                : Color.FromArgb(108, 117, 125);

            btnPage2.BackgroundColor = Color.FromArgb(220, 53, 69); // Current page
        }

        private void NavigateToPage(int page)
        {
            if (page < 1 || page > totalPages)
                return;

            currentPage = page;
            LoadMovies();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            currentPage = 1; // Reset về trang 1
            LoadMovies();
        }

        private void CboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset về trang 1
            LoadMovies();
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            this._home.LoadControl(new AddMovieUC(this._home, this._employee));
        }

        private void AdjustCardMargins()
        {
            if (moviesContainer == null || !moviesContainer.IsHandleCreated)
                return;

            var cards = moviesContainer.Controls
                .OfType<ReaLTaiizor.Controls.MaterialCard>()
                .ToList();

            if (cards.Count == 0)
                return;

            int containerWidth = panel_movie.ClientSize.Width;
            if (containerWidth <= 0) return;

            int panelPadding = panel_movie.Padding.Left + panel_movie.Padding.Right;
            int flowPadding = moviesContainer.Padding.Left + moviesContainer.Padding.Right;
            int availableWidth = containerWidth - panelPadding - flowPadding - 25;

            int cardWidth = cards[0].Width;
            int cardsPerRow = 4;
            int minMargin = 6;

            int minTotalWidth = (cardsPerRow * cardWidth) + (minMargin * 2 * cardsPerRow);

            if (minTotalWidth > availableWidth)
            {
                cardsPerRow = 3;
                minTotalWidth = (cardsPerRow * cardWidth) + (minMargin * 2 * cardsPerRow);

                if (minTotalWidth > availableWidth)
                {
                    cardsPerRow = 2;
                }
            }

            int totalCardWidth = cardsPerRow * cardWidth;
            int remainingSpace = availableWidth - totalCardWidth;
            int calculatedMargin = remainingSpace / (cardsPerRow * 2);
            int finalMargin = Math.Max(6, Math.Min(calculatedMargin, 35));

            moviesContainer.SuspendLayout();
            try
            {
                foreach (var card in cards)
                {
                    card.Margin = new Padding(finalMargin);
                }
            }
            finally
            {
                moviesContainer.ResumeLayout(true);
                moviesContainer.PerformLayout();
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BtnSearch_Click(sender, e);
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboFilter_SelectedIndexChanged(sender, e);
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            BtnAddMovie_Click(sender, e);
        }
    }
}