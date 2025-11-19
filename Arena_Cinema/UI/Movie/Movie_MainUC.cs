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
        private int pageSize = 4;
        private int totalPages = 1;
        private List<DTO.Movie> currentMovies = new List<DTO.Movie>();

        public Movie_MainUC(Home form, DTO.Employee employee)
        {
            InitializeComponent();
            movieCardTemplate.Visible = false;

            this._home = form;
            this._employee = employee;

            movieBLL = new MovieBLL();

            // Setup keyboard events
            txtSearch.KeyDown += TxtSearch_KeyDown;

            // NOTE: Pagination events được tạo động trong UpdatePaginationButtons()
            // Không cần gắn event ở đây nữa

            // Load event
            this.Load += Movie_MainUC_Load;
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearch_Click(sender, e);
            }
        }

        private void Movie_MainUC_Load(object sender, EventArgs e)
        {
            try
            {
                // Setup resize events
                this.SizeChanged += (s, ev) => AdjustCardMargins();
                panel_movie.SizeChanged += (s, ev) => AdjustCardMargins();

                // Initialize filters
                if (cboFilter.Items.Count > 0)
                    cboFilter.SelectedIndex = 0;

                // Load genres and age limits from database
                LoadGenres();
                LoadAgeLimits();

                // Load movies
                LoadMovies();

                // Adjust layout after a short delay
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
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
             
                txtSearch.Text = "";

                if (cboFilter.Items.Count > 0)
                    cboFilter.SelectedIndex = 0; // "Tất cả phim"

                if (cboGenre.Items.Count > 0)
                    cboGenre.SelectedIndex = 0; // "Tất cả"

                if (cboAgeLimit.Items.Count > 0)
                    cboAgeLimit.SelectedIndex = 0; // "Tất cả"

                currentPage = 1;

                LoadMovies();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi reset bộ lọc: {ex.Message}", "✗ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadGenres()
        {
            try
            {
                cboGenre.Items.Clear();

                // Lấy danh sách thể loại từ BLL (trả về list có thể chứa giá trị ghép)
                var genresFromDB = movieBLL.GetGenresFromDB();

                // Tạo HashSet để tự động loại bỏ duplicate
                HashSet<string> uniqueGenres = new HashSet<string>();

                foreach (var genreString in genresFromDB)
                {
                    // Bỏ qua "Tất cả" (sẽ thêm sau)
                    if (genreString == "Tất cả")
                        continue;

                    // Tách chuỗi theo dấu phẩy
                    if (!string.IsNullOrWhiteSpace(genreString))
                    {
                        string[] genres = genreString.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var genre in genres)
                        {
                            string trimmedGenre = genre.Trim();
                            if (!string.IsNullOrWhiteSpace(trimmedGenre))
                            {
                                uniqueGenres.Add(trimmedGenre);
                            }
                        }
                    }
                }

                // Thêm "Tất cả" đầu tiên
                cboGenre.Items.Add("Tất cả");

                // Sắp xếp và thêm các thể loại vào ComboBox
                var sortedGenres = uniqueGenres.OrderBy(g => g).ToList();
                foreach (var genre in sortedGenres)
                {
                    cboGenre.Items.Add(genre);
                }

                if (cboGenre.Items.Count > 0)
                    cboGenre.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading genres: {ex.Message}");
                cboGenre.Items.Add("Tất cả");
                cboGenre.SelectedIndex = 0;
            }
        }
        private bool MovieMatchesGenre(DTO.Movie movie, string selectedGenre)
        {
            if (string.IsNullOrWhiteSpace(selectedGenre) || selectedGenre == "Tất cả")
                return true;

            if (string.IsNullOrWhiteSpace(movie.Genre))
                return false;

            // Tách thể loại của phim và kiểm tra xem có chứa thể loại được chọn không
            string[] movieGenres = movie.Genre.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                              .Select(g => g.Trim())
                                              .ToArray();

            return movieGenres.Any(g => g.Equals(selectedGenre, StringComparison.OrdinalIgnoreCase));
        }

        private void LoadAgeLimits()
        {
            try
            {
                cboAgeLimit.Items.Clear();
                var ageLimits = movieBLL.GetAgeRatingsFromDB();

                // GetAgeRatingsFromDB đã có "Tất cả" ở đầu rồi
                foreach (var age in ageLimits)
                {
                    cboAgeLimit.Items.Add(age);
                }

                if (cboAgeLimit.Items.Count > 0)
                    cboAgeLimit.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading age limits: {ex.Message}");
                cboAgeLimit.Items.Add("Tất cả");
                cboAgeLimit.SelectedIndex = 0;
            }
        }

        private void LoadMovies()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string searchText = txtSearch.Text.Trim();
                string filterStatus = cboFilter.SelectedItem?.ToString() ?? "Tất cả phim";
                string filterGenre = cboGenre.SelectedItem?.ToString() ?? "Tất cả";
                string filterAge = cboAgeLimit.SelectedItem?.ToString() ?? "Tất cả";

                // DEBUG
                System.Diagnostics.Debug.WriteLine($"=== LoadMovies ===");
                System.Diagnostics.Debug.WriteLine($"Search: '{searchText}'");
                System.Diagnostics.Debug.WriteLine($"Status: '{filterStatus}'");
                System.Diagnostics.Debug.WriteLine($"Genre: '{filterGenre}'");
                System.Diagnostics.Debug.WriteLine($"Age: '{filterAge}'");
                System.Diagnostics.Debug.WriteLine($"Page: {currentPage}, Size: {pageSize}");

                // Gọi BLL với stored procedure
                currentMovies = movieBLL.SearchMoviesWithPagingSP(
                    searchText,
                    filterStatus,
                    filterGenre,
                    filterAge,
                    currentPage,
                    pageSize,
                    out totalPages);

                System.Diagnostics.Debug.WriteLine($"Movies loaded: {currentMovies?.Count ?? 0}");
                System.Diagnostics.Debug.WriteLine($"Total pages: {totalPages}");

                DisplayMovies(currentMovies);
                UpdateInfoLabel();
                UpdatePaginationButtons();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"ERROR in LoadMovies: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack: {ex.StackTrace}");
                if (ex.InnerException != null)
                    System.Diagnostics.Debug.WriteLine($"Inner: {ex.InnerException.Message}");

                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}\n\nChi tiết: {ex.InnerException?.Message}",
                    "✗ Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Clear existing controls except template
                var controlsToRemove = moviesContainer.Controls
                    .Cast<Control>()
                    .Where(c => c != movieCardTemplate)
                    .ToList();

                foreach (var control in controlsToRemove)
                {
                    moviesContainer.Controls.Remove(control);
                    control.Dispose();
                }

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
                        AutoSize = true
                    };

                    lblNoData.Location = new Point(
                        Math.Max(0, (noDataPanel.Width - lblNoData.PreferredWidth) / 2),
                        Math.Max(0, (noDataPanel.Height - lblNoData.PreferredHeight) / 2)
                    );

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
                BackColor = movieCardTemplate.BackColor,
                Size = movieCardTemplate.Size,
                Margin = movieCardTemplate.Margin,
                Depth = movieCardTemplate.Depth,
                Padding = movieCardTemplate.Padding,
                Visible = true
            };

            string status = movieBLL.GetMovieStatus(movie);

            foreach (Control templateControl in movieCardTemplate.Controls)
            {
                Control clonedControl = null;

                if (templateControl.Name == "badgeTemplate")
                {
                    var badge = new Label
                    {
                        BackColor = GetStatusColor(status),
                        Font = (templateControl as Label).Font,
                        ForeColor = status == "Sắp chiếu" ? Color.Black : Color.White,
                        Location = templateControl.Location,
                        Size = templateControl.Size,
                        Text = status,
                        TextAlign = (templateControl as Label).TextAlign
                    };
                    clonedControl = badge;
                }
                else if (templateControl.Name == "posterTemplate")
                {
                    var posterPanel = new System.Windows.Forms.Panel
                    {
                        Location = templateControl.Location,
                        Size = templateControl.Size,
                        BackColor = templateControl.BackColor
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
                    clonedControl = posterPanel;
                }
                else if (templateControl.Name == "lblTitleTemplate")
                {
                    clonedControl = new Label
                    {
                        Font = (templateControl as Label).Font,
                        ForeColor = (templateControl as Label).ForeColor,
                        Location = templateControl.Location,
                        Size = templateControl.Size,
                        Text = movie.Title,
                        AutoEllipsis = true
                    };
                }
                else if (templateControl.Name == "lblDurationTemplate")
                {
                    clonedControl = new Label
                    {
                        AutoSize = (templateControl as Label).AutoSize,
                        Font = (templateControl as Label).Font,
                        ForeColor = (templateControl as Label).ForeColor,
                        Location = templateControl.Location,
                        Text = $"⏱ {movieBLL.FormatDuration(movie.DurationMinutes)}"
                    };
                }
                else if (templateControl.Name == "lblLanguageTemplate")
                {
                    clonedControl = new Label
                    {
                        AutoSize = (templateControl as Label).AutoSize,
                        Font = (templateControl as Label).Font,
                        ForeColor = (templateControl as Label).ForeColor,
                        Location = templateControl.Location,
                        Text = $"🎭 {movie.Genre ?? "Chưa xác định"}"
                    };
                }
                else if (templateControl.Name == "lblSubtitleTemplate")
                {
                    clonedControl = new Label
                    {
                        AutoSize = (templateControl as Label).AutoSize,
                        BackColor = (templateControl as Label).BackColor,
                        Font = (templateControl as Label).Font,
                        ForeColor = (templateControl as Label).ForeColor,
                        Location = templateControl.Location,
                        Padding = (templateControl as Label).Padding,
                        Text = $"🎬 {movie.Language}"
                    };
                }
                else if (templateControl.Name == "lblDatesTemplate")
                {
                    clonedControl = new Label
                    {
                        Font = (templateControl as Label).Font,
                        ForeColor = (templateControl as Label).ForeColor,
                        Location = templateControl.Location,
                        Size = templateControl.Size,
                        Text = movieBLL.FormatMovieDates(movie)
                    };
                }
                else if (templateControl.Name == "btnViewTemplate")
                {
                    var btn = templateControl as ReaLTaiizor.Controls.ParrotButton;
                    var newBtn = new ReaLTaiizor.Controls.ParrotButton
                    {
                        BackgroundColor = btn.BackgroundColor,
                        ButtonStyle = btn.ButtonStyle,
                        ButtonText = btn.ButtonText,
                        ClickBackColor = btn.ClickBackColor,
                        ClickTextColor = btn.ClickTextColor,
                        CornerRadius = btn.CornerRadius,
                        Cursor = btn.Cursor,
                        Font = btn.Font,
                        Horizontal_Alignment = btn.Horizontal_Alignment,
                        HoverBackgroundColor = btn.HoverBackgroundColor,
                        HoverTextColor = btn.HoverTextColor,
                        Location = btn.Location,
                        Size = btn.Size,
                        TextColor = btn.TextColor,
                        ButtonImage = btn.ButtonImage,
                        ImagePosition = btn.ImagePosition,
                        SmoothingType = btn.SmoothingType,
                        TextRenderingType = btn.TextRenderingType,
                        Vertical_Alignment = btn.Vertical_Alignment
                    };
                    newBtn.Click += (s, e) => ViewMovieDetail(movie);
                    clonedControl = newBtn;
                }
                else if (templateControl.Name == "btnEditTemplate")
                {
                    var btn = templateControl as ReaLTaiizor.Controls.ParrotButton;
                    var newBtn = new ReaLTaiizor.Controls.ParrotButton
                    {
                        BackgroundColor = btn.BackgroundColor,
                        ButtonStyle = btn.ButtonStyle,
                        ButtonText = btn.ButtonText,
                        ClickBackColor = btn.ClickBackColor,
                        ClickTextColor = btn.ClickTextColor,
                        CornerRadius = btn.CornerRadius,
                        Cursor = btn.Cursor,
                        Font = btn.Font,
                        Horizontal_Alignment = btn.Horizontal_Alignment,
                        HoverBackgroundColor = btn.HoverBackgroundColor,
                        HoverTextColor = btn.HoverTextColor,
                        Location = btn.Location,
                        Size = btn.Size,
                        TextColor = btn.TextColor,
                        ButtonImage = btn.ButtonImage,
                        ImagePosition = btn.ImagePosition,
                        SmoothingType = btn.SmoothingType,
                        TextRenderingType = btn.TextRenderingType,
                        Vertical_Alignment = btn.Vertical_Alignment
                    };
                    newBtn.Click += (s, e) => EditMovie(movie);
                    clonedControl = newBtn;
                }
                else if (templateControl.Name == "btnDeleteTemplate")
                {
                    var btn = templateControl as ReaLTaiizor.Controls.ParrotButton;
                    var newBtn = new ReaLTaiizor.Controls.ParrotButton
                    {
                        BackgroundColor = btn.BackgroundColor,
                        ButtonStyle = btn.ButtonStyle,
                        ButtonText = btn.ButtonText,
                        ClickBackColor = btn.ClickBackColor,
                        ClickTextColor = btn.ClickTextColor,
                        CornerRadius = btn.CornerRadius,
                        Cursor = btn.Cursor,
                        Font = btn.Font,
                        Horizontal_Alignment = btn.Horizontal_Alignment,
                        HoverBackgroundColor = btn.HoverBackgroundColor,
                        HoverTextColor = btn.HoverTextColor,
                        Location = btn.Location,
                        Size = btn.Size,
                        TextColor = btn.TextColor,
                        ButtonImage = btn.ButtonImage,
                        ImagePosition = btn.ImagePosition,
                        SmoothingType = btn.SmoothingType,
                        TextRenderingType = btn.TextRenderingType,
                        Vertical_Alignment = btn.Vertical_Alignment
                    };
                    newBtn.Click += (s, e) => DeleteMovie(movie);
                    clonedControl = newBtn;
                }

                if (clonedControl != null)
                {
                    card.Controls.Add(clonedControl);
                }
            }

            return card;
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Đang chiếu":
                    return Color.FromArgb(40, 167, 69);
                case "Sắp chiếu":
                    return Color.FromArgb(255, 193, 7);
                case "Đã kết thúc":
                    return Color.FromArgb(108, 117, 125);
                default:
                    return Color.FromArgb(23, 162, 184);
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

                        if (currentMovies.Count == 1 && currentPage > 1)
                        {
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
                int totalMovies = currentMovies?.Count ?? 0;
                string searchText = txtSearch.Text.Trim();
                string filterStatus = cboFilter.SelectedItem?.ToString() ?? "Tất cả phim";
                string filterGenre = cboGenre.SelectedItem?.ToString() ?? "Tất cả";
                string filterAge = cboAgeLimit.SelectedItem?.ToString() ?? "Tất cả";

                string searchInfo = string.IsNullOrEmpty(searchText) ? "" : $" | Tìm: '{searchText}'";
                string filterInfo = "";

                if (filterStatus != "Tất cả phim")
                    filterInfo += $" | {filterStatus}";
                if (filterGenre != "Tất cả")
                    filterInfo += $" | {filterGenre}";
                if (filterAge != "Tất cả")
                    filterInfo += $" | {filterAge}";

                lblInfo.Text = $"📊 Hiển thị: {totalMovies} phim{searchInfo}{filterInfo}" +
                             $"                                                                                                                                                                                 " +
                             $"📄 Trang {currentPage} / {totalPages}";
            }
            catch (Exception ex)
            {
                lblInfo.Text = $"Lỗi hiển thị thông tin: {ex.Message}";
            }
        }

        // ============================================
        // PHƯƠNG THỨC MỚI - TẠO NÚT PAGINATION ĐỘNG
        // ============================================
        private void UpdatePaginationButtons()
        {
            try
            {
                // Xóa tất cả nút cũ trừ template
                var buttonsToRemove = paginationPanel.Controls
                    .OfType<ReaLTaiizor.Controls.ParrotButton>()
                    .Where(btn => btn != btnPageNumberTemplate && btn != btnNavTemplate)
                    .ToList();

                foreach (var btn in buttonsToRemove)
                {
                    paginationPanel.Controls.Remove(btn);
                    btn.Dispose();
                }

                // Tạo lại các nút navigation và page number
                CreateNavigationButtons();
                CreatePageNumberButtons();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating pagination: {ex.Message}");
            }
        }

        // Tạo các nút điều hướng (First, Prev, Next, Last) từ TEMPLATE
        private void CreateNavigationButtons()
        {
            Color disabledColor = Color.FromArgb(180, 180, 180);

            // Nút First (««)
            var btnNavFirst = CloneNavButton("btnNavFirst", "««", 490);
            btnNavFirst.Click += (s, e) => NavigateToPage(1);
            btnNavFirst.Enabled = currentPage > 1;
            if (!btnNavFirst.Enabled) btnNavFirst.BackgroundColor = disabledColor;
            paginationPanel.Controls.Add(btnNavFirst);

            // Nút Previous (‹)
            var btnNavPrev = CloneNavButton("btnNavPrev", "‹", 540);
            btnNavPrev.Click += (s, e) => { if (currentPage > 1) NavigateToPage(currentPage - 1); };
            btnNavPrev.Enabled = currentPage > 1;
            if (!btnNavPrev.Enabled) btnNavPrev.BackgroundColor = disabledColor;
            paginationPanel.Controls.Add(btnNavPrev);

            // Tính vị trí Next button (động)
            int nextButtonX = 590 + (Math.Min(totalPages, 5) * 45);

            // Nút Next (›)
            var btnNavNext = CloneNavButton("btnNavNext", "›", nextButtonX);
            btnNavNext.Click += (s, e) => { if (currentPage < totalPages) NavigateToPage(currentPage + 1); };
            btnNavNext.Enabled = currentPage < totalPages;
            if (!btnNavNext.Enabled) btnNavNext.BackgroundColor = disabledColor;
            paginationPanel.Controls.Add(btnNavNext);

            // Nút Last (»)
            var btnNavLast = CloneNavButton("btnNavLast", "»", nextButtonX + 50);
            btnNavLast.Click += (s, e) => NavigateToPage(totalPages);
            btnNavLast.Enabled = currentPage < totalPages;
            if (!btnNavLast.Enabled) btnNavLast.BackgroundColor = disabledColor;
            paginationPanel.Controls.Add(btnNavLast);
        }

        // Clone nút navigation từ TEMPLATE
        private ReaLTaiizor.Controls.ParrotButton CloneNavButton(string name, string text, int x)
        {
            var btn = new ReaLTaiizor.Controls.ParrotButton
            {
                Name = name,
                // CLONE TẤT CẢ THUỘC TÍNH TỪ TEMPLATE
                BackgroundColor = btnNavTemplate.BackgroundColor,
                ButtonImage = btnNavTemplate.ButtonImage,
                ButtonStyle = btnNavTemplate.ButtonStyle,
                ButtonText = text,
                ClickBackColor = btnNavTemplate.ClickBackColor,
                ClickTextColor = btnNavTemplate.ClickTextColor,
                CornerRadius = btnNavTemplate.CornerRadius,
                Cursor = btnNavTemplate.Cursor,
                Font = btnNavTemplate.Font,
                Horizontal_Alignment = btnNavTemplate.Horizontal_Alignment,
                HoverBackgroundColor = btnNavTemplate.HoverBackgroundColor,
                HoverTextColor = btnNavTemplate.HoverTextColor,
                ImagePosition = btnNavTemplate.ImagePosition,
                Location = new Point(x, 10),
                Size = btnNavTemplate.Size,
                SmoothingType = btnNavTemplate.SmoothingType,
                TextColor = btnNavTemplate.TextColor,
                TextRenderingType = btnNavTemplate.TextRenderingType,
                Vertical_Alignment = btnNavTemplate.Vertical_Alignment
            };
            return btn;
        }

        // Tạo các nút số trang từ TEMPLATE
        private void CreatePageNumberButtons()
        {
            Color activeColor = Color.FromArgb(220, 53, 69);    // Đỏ - trang hiện tại
            Color inactiveColor = Color.FromArgb(108, 117, 125); // Xám - các trang khác

            List<int> pagesToShow = CalculatePagesToShow();
            int startX = 590;
            int buttonWidth = 35;
            int spacing = 10;

            for (int i = 0; i < pagesToShow.Count; i++)
            {
                int pageNum = pagesToShow[i];
                bool isCurrentPage = pageNum == currentPage;

                var btnPage = new ReaLTaiizor.Controls.ParrotButton
                {
                    Name = $"btnDynamicPage{pageNum}",
                    // CLONE TẤT CẢ THUỘC TÍNH TỪ TEMPLATE
                    BackgroundColor = isCurrentPage ? activeColor : inactiveColor, // ✅ FIX: Dùng inactiveColor thay vì template color
                    ButtonImage = btnPageNumberTemplate.ButtonImage,
                    ButtonStyle = btnPageNumberTemplate.ButtonStyle,
                    ButtonText = pageNum.ToString(),
                    ClickBackColor = btnPageNumberTemplate.ClickBackColor,
                    ClickTextColor = btnPageNumberTemplate.ClickTextColor,
                    CornerRadius = btnPageNumberTemplate.CornerRadius,
                    Cursor = btnPageNumberTemplate.Cursor,
                    Font = btnPageNumberTemplate.Font,
                    Horizontal_Alignment = btnPageNumberTemplate.Horizontal_Alignment,
                    HoverBackgroundColor = isCurrentPage ? activeColor : Color.FromArgb(128, 137, 145), // ✅ FIX: Hover cũng phân biệt
                    HoverTextColor = btnPageNumberTemplate.HoverTextColor,
                    ImagePosition = btnPageNumberTemplate.ImagePosition,
                    Location = new Point(startX + (i * (buttonWidth + spacing)), 10),
                    Size = btnPageNumberTemplate.Size,
                    SmoothingType = btnPageNumberTemplate.SmoothingType,
                    TextColor = btnPageNumberTemplate.TextColor,
                    TextRenderingType = btnPageNumberTemplate.TextRenderingType,
                    Vertical_Alignment = btnPageNumberTemplate.Vertical_Alignment,
                    Tag = pageNum
                };

                // Gắn sự kiện click
                btnPage.Click += (s, e) =>
                {
                    var btn = s as ReaLTaiizor.Controls.ParrotButton;
                    if (btn != null && btn.Tag is int page)
                    {
                        NavigateToPage(page);
                    }
                };

                paginationPanel.Controls.Add(btnPage);
            }
        }

        // Tính toán các trang cần hiển thị (GIỮ NGUYÊN)
        private List<int> CalculatePagesToShow()
        {
            List<int> pages = new List<int>();

            if (totalPages <= 5)
            {
                for (int i = 1; i <= totalPages; i++)
                {
                    pages.Add(i);
                }
            }
            else
            {
                if (currentPage <= 3)
                {
                    pages.AddRange(new[] { 1, 2, 3, 4, 5 });
                }
                else if (currentPage >= totalPages - 2)
                {
                    for (int i = totalPages - 4; i <= totalPages; i++)
                    {
                        pages.Add(i);
                    }
                }
                else
                {
                    for (int i = currentPage - 2; i <= currentPage + 2; i++)
                    {
                        pages.Add(i);
                    }
                }
            }

            return pages;
        }

        private void NavigateToPage(int page)
        {
            if (page < 1 || page > totalPages || page == currentPage)
                return;

            currentPage = page;
            LoadMovies();
        }

        private void AdjustCardMargins()
        {
            if (moviesContainer == null || !moviesContainer.IsHandleCreated)
                return;

            var cards = moviesContainer.Controls
                .OfType<ReaLTaiizor.Controls.MaterialCard>()
                .Where(c => c.Visible && c != movieCardTemplate)
                .ToList();

            if (cards.Count == 0)
                return;

            int containerWidth = panel_movie.ClientSize.Width;
            if (containerWidth <= 0) return;

            int panelPadding = panel_movie.Padding.Left + panel_movie.Padding.Right;
            int flowPadding = moviesContainer.Padding.Left + moviesContainer.Padding.Right;
            int availableWidth = containerWidth - panelPadding - flowPadding - 25;

            int cardWidth = 296;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadMovies();
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadMovies();
        }

        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadMovies();
        }

        private void cboAgeLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadMovies();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                _home.LoadControl(new AddMovieUC(_home, _employee));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form thêm phim: {ex.Message}", "✗ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void movieCardTemplate_MouseEnter(object sender, EventArgs e)
        {

        }

        private void movieCardTemplate_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadMovies();
        }
    }
}