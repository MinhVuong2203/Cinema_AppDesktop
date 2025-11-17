using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Common;

namespace UI.Movie
{
    public partial class Movie_MainUC : UserControl
    {
        private bool isFirstLoad = true;
        private Home _home;
        private DTO.Employee _employee;
        private MovieBLL movieBLL;

        private int currentPage = 1;
        private int pageSize = 8;
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
            btnDeletedMovies.Click += btnDeletedMovies_Click;
            txtSearch.KeyDown += TxtSearch_KeyDown;

            // Pagination events - SỬA LỖI
            btnFirstPage.Click += (s, e) => NavigateToPage(1);

            btnPrevPage.Click += (s, e) => {
                if (int.TryParse(btnPrevPage.Text, out int page))
                    NavigateToPage(page);
                else
                    NavigateToPage(currentPage - 1);
            };

            btnPage2.Click += (s, e) => {
                if (int.TryParse(btnPage2.Text, out int page))
                    NavigateToPage(page);
            };

            btnPage3.Click += (s, e) => {
                if (int.TryParse(btnPage3.Text, out int page))
                    NavigateToPage(page);
                else
                    NavigateToPage(currentPage + 1);
            };

            btnNextPage.Click += (s, e) => NavigateToPage(currentPage + 1);
            btnLastPage.Click += (s, e) => NavigateToPage(totalPages);
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn âm beep
                BtnSearch_Click(sender, e);
            }
        }

        private void Movie_MainUC_Load(object sender, EventArgs e)
        {
            this.SizeChanged += (s, ev) => AdjustCardMargins();
            panel_movie.SizeChanged += (s, ev) => AdjustCardMargins();

            // Set default filter
            if (cboFilter.Items.Count > 0)
                cboFilter.SelectedIndex = 0;

            LoadMovies();

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
                // Hiển thị loading cursor
                this.Cursor = Cursors.WaitCursor;

                string searchText = txtSearch.Text.Trim();
                string filterStatus = cboFilter.SelectedItem?.ToString() ?? "Tất cả phim";

                currentMovies = movieBLL.SearchMoviesWithPaging(
                    searchText,
                    filterStatus,
                    currentPage,
                    pageSize,
                    out totalPages);

                DisplayMovies(currentMovies);
                UpdateInfoLabel();
                UpdatePaginationButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "✗ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void DisplayMovies(List<DTO.Movie> movies)
        {
            moviesContainer.SuspendLayout();
            try
            {
                moviesContainer.Controls.Clear();

                if (movies == null || movies.Count == 0)
                {
                    Panel noDataPanel = new Panel
                    {
                        Size = new Size(moviesContainer.Width - 50, 200),
                        Margin = new Padding(20)
                    };

                    Label lblNoData = new Label
                    {
                        Text = "📭 Không tìm thấy phim nào!",
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Location = new Point(
                            (noDataPanel.Width - 250) / 2,
                            (noDataPanel.Height - 30) / 2
                        )
                    };

                    noDataPanel.Controls.Add(lblNoData);
                    moviesContainer.Controls.Add(noDataPanel);
                    return;
                }

                foreach (var movie in movies)
                {
                    var card = CreateMovieCard(movie);
                    moviesContainer.Controls.Add(card);
                }
            }
            finally
            {
                moviesContainer.ResumeLayout(true);
                moviesContainer.PerformLayout();
            }
        }

        private ReaLTaiizor.Controls.MaterialCard CreateMovieCard(DTO.Movie movie)
        {
            var card = new ReaLTaiizor.Controls.MaterialCard
            {
                BackColor = Color.FromArgb(255, 255, 255),
                Size = new Size(296, 407),
                Margin = new Padding(6)
            };

            string status = movieBLL.GetMovieStatus(movie);

            // Badge trạng thái
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

            // Poster
            Panel posterPanel = new Panel
            {
                Location = new Point(10, 10),
                Size = new Size(276, 180),
                BackColor = Color.FromArgb(200, 200, 200)
            };

            PictureBox posterPicBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(200, 200, 200)
            };

            if (!string.IsNullOrEmpty(movie.ImageUrl))
            {
                ImgHelper.DisplayImageFromRelative(movie.ImageUrl, posterPicBox);
            }
            else
            {
                // Placeholder nếu không có ảnh
                Label lblNoImage = new Label
                {
                    Text = "📷\nChưa có ảnh",
                    Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                posterPicBox.Controls.Add(lblNoImage);
            }

            posterPanel.Controls.Add(posterPicBox);

            // Tiêu đề phim
            Label lblTitle = new Label
            {
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50),
                Location = new Point(10, 200),
                Size = new Size(276, 45),
                Text = movie.Title,
                AutoEllipsis = true
            };

            // Thời lượng
            Label lblDuration = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(12, 250),
                Text = $"⏱ {movieBLL.FormatDuration(movie.DurationMinutes)}"
            };

            // Thể loại
            Label lblCategory = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(12, 270),
                Size = new Size(260, 20),
                Text = $"🎭 {movie.Genre ?? "Chưa xác định"}",
                AutoEllipsis = true
            };

            // Ngôn ngữ
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

            // Ngày chiếu
            Label lblDates = new Label
            {
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(12, 320),
                Size = new Size(275, 39),
                Text = movieBLL.FormatMovieDates(movie)
            };

            // Buttons
            var btnView = CreateActionButton("👁 Chi tiết", Color.FromArgb(23, 162, 184), new Point(12, 374), new Size(89, 25));
            btnView.Click += (s, e) => ViewMovieDetail(movie);

            var btnEdit = CreateActionButton("✏ Sửa", Color.FromArgb(255, 193, 7), new Point(131, 374), new Size(65, 25));
            btnEdit.Click += (s, e) => EditMovie(movie);

            var btnDelete = CreateActionButton("🗑 Xóa", Color.FromArgb(220, 53, 69), new Point(223, 374), new Size(65, 25));
            btnDelete.Click += (s, e) => DeleteMovie(movie);

            card.Controls.AddRange(new Control[] {
                posterPanel, badge, lblTitle, lblDuration, lblCategory,
                lblLanguage, lblDates, btnView, btnEdit, btnDelete
            });

            return card;
        }

        private ReaLTaiizor.Controls.ParrotButton CreateActionButton(string text, Color bgColor, Point location, Size size)
        {
            return new ReaLTaiizor.Controls.ParrotButton
            {
                BackgroundColor = bgColor,
                ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded,
                ButtonText = text,
                ClickBackColor = Color.FromArgb(
                    Math.Max(0, bgColor.R - 40),
                    Math.Max(0, bgColor.G - 40),
                    Math.Max(0, bgColor.B - 40)
                ),
                HoverBackgroundColor = Color.FromArgb(
                    Math.Min(255, bgColor.R + 20),
                    Math.Min(255, bgColor.G + 20),
                    Math.Min(255, bgColor.B + 20)
                ),
                CornerRadius = 3,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Location = location,
                Size = size,
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
            string dub = movie.Dub == true ? "Có" : "Không";

            string details = $"━━━━━━━━━━━ THÔNG TIN CHI TIẾT PHIM ━━━━━━━━━━━\n\n" +
                           $"🎬 Tên phim: {movie.Title}\n\n" +
                           $"⏱️ Thời lượng: {movieBLL.FormatDuration(movie.DurationMinutes)}\n\n" +
                           $"🎭 Thể loại: {movie.Genre ?? "Chưa xác định"}\n\n" +
                           $"🗣️ Ngôn ngữ: {movie.Language}\n\n" +
                           $"🔊 Lồng tiếng: {dub}\n\n" +
                           $"👥 Giới hạn tuổi: {movie.AgeLimit}\n\n" +
                           $"🎥 Loại phim: {movie.MovieType}\n\n" +
                           $"📅 Trạng thái: {movieBLL.GetMovieStatus(movie)}\n\n" +
                           $"📆 {movieBLL.FormatMovieDates(movie)}\n\n" +
                           $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n" +
                           $"📝 Mô tả:\n{(string.IsNullOrWhiteSpace(movie.Description) ? "Chưa có mô tả" : movie.Description)}\n\n" +
                           $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n" +
                           $"📋 Nội dung:\n{(string.IsNullOrWhiteSpace(movie.Preview) ? "Chưa có nội dung" : movie.Preview)}\n\n" +
                           $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n" +
                           $"🎬 Trailer: {(string.IsNullOrWhiteSpace(movie.LinkTrailer) ? "Chưa có link" : movie.LinkTrailer)}";

            MessageBox.Show(details, "📽 Chi tiết phim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditMovie(DTO.Movie movie)
        {
            try
            {
                // Chuyển sang form Edit với movie data
                EditMovieUC editForm = new EditMovieUC(_home, _employee, movie);
                _home.LoadControl(editForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form chỉnh sửa: {ex.Message}", "✗ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteMovie(DTO.Movie movie)
        {
            try
            {
                // Kiểm tra xem phim có thể xóa không
                var canDelete = movieBLL.CanDeleteMovie(movie.MovieID);

                string message = $"Bạn có chắc muốn xóa phim '{movie.Title}'?";

                if (!canDelete.Item1)
                {
                    message += $"\n\n⚠ Cảnh báo: {canDelete.Item2}";
                }
                else
                {
                    message += "\n\nLưu ý: Phim sẽ bị xóa mềm và có thể khôi phục sau!";
                }

                var confirmResult = MessageBox.Show(
                    message,
                    "⚠ Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    var result = movieBLL.DeleteMovie(movie.MovieID);

                    if (result.Item1)
                    {
                        MessageBox.Show(result.Item2, "✓ Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload lại trang hiện tại
                        if (currentMovies.Count == 1 && currentPage > 1)
                        {
                            // Nếu xóa phim cuối cùng của trang, quay về trang trước
                            currentPage--;
                        }

                        LoadMovies();
                    }
                    else
                    {
                        MessageBox.Show(result.Item2, "✗ Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa phim: {ex.Message}", "✗ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInfoLabel()
        {
            try
            {
                int totalMovies = currentMovies.Count;
                string searchText = txtSearch.Text.Trim();
                string filterStatus = cboFilter.SelectedItem?.ToString() ?? "Tất cả phim";

                string searchInfo = string.IsNullOrEmpty(searchText)
                    ? ""
                    : $" (Tìm kiếm: '{searchText}')";

                string filterInfo = filterStatus == "Tất cả phim"
                    ? ""
                    : $" - Lọc: {filterStatus}";

                lblInfo.Text = $"📊 Hiển thị: {totalMovies} phim{searchInfo}{filterInfo}" +
                             $"                                                                                                                                                                                 " +
                             $"📄 Trang {currentPage} / {totalPages}";
            }
            catch (Exception ex)
            {
                lblInfo.Text = $"Lỗi hiển thị thông tin: {ex.Message}";
            }
        }

        private void UpdatePaginationButtons()
        {
            try
            {
                // Enable/Disable buttons
                btnFirstPage.Enabled = currentPage > 1;
                btnPrevPage.Enabled = currentPage > 1;
                btnNextPage.Enabled = currentPage < totalPages;
                btnLastPage.Enabled = currentPage < totalPages;

                // Update button text
                btnFirstPage.Text = "1";

                if (currentPage > 1)
                {
                    btnPrevPage.Text = (currentPage - 1).ToString();
                }
                else
                {
                    btnPrevPage.Text = "‹";
                }

                btnPage2.Text = currentPage.ToString();

                if (currentPage < totalPages)
                {
                    btnPage3.Text = (currentPage + 1).ToString();
                }
                else
                {
                    btnPage3.Text = "›";
                }

                // Update colors
                Color activeColor = Color.FromArgb(220, 53, 69);
                Color inactiveColor = Color.FromArgb(108, 117, 125);
                Color disabledColor = Color.FromArgb(180, 180, 180);

                btnFirstPage.BackgroundColor = currentPage == 1 ? activeColor : inactiveColor;
                btnPage2.BackgroundColor = activeColor; // Current page always active

                // Disabled color
                if (!btnFirstPage.Enabled)
                    btnFirstPage.BackgroundColor = disabledColor;
                if (!btnPrevPage.Enabled)
                    btnPrevPage.BackgroundColor = disabledColor;
                if (!btnNextPage.Enabled)
                    btnNextPage.BackgroundColor = disabledColor;
                if (!btnLastPage.Enabled)
                    btnLastPage.BackgroundColor = disabledColor;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating pagination: {ex.Message}");
            }
        }

        private void NavigateToPage(int page)
        {
            if (page < 1 || page > totalPages || page == currentPage)
                return;

            currentPage = page;
            LoadMovies();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            currentPage = 1; // Reset về trang 1 khi tìm kiếm
            LoadMovies();
        }

        private void CboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset về trang 1 khi lọc
            LoadMovies();
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                this._home.LoadControl(new AddMovieUC(this._home, this._employee));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form thêm phim: {ex.Message}", "✗ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    minTotalWidth = (cardsPerRow * cardWidth) + (minMargin * 2 * cardsPerRow);

                    if (minTotalWidth > availableWidth)
                    {
                        cardsPerRow = 1;
                    }
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
        private void btnDeletedMovies_Click(object sender, EventArgs e)
        {
            try
            {
                _home.LoadControl(new DeletedMoviesUC(_home, _employee));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở danh sách phim đã xóa: {ex.Message}", "✗ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}