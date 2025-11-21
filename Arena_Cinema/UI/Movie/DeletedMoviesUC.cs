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
    public partial class DeletedMoviesUC : UserControl
    {
        private Home _home;
        private DTO.Employee _employee;
        private MovieBLL movieBLL;
        private List<DTO.Movie> deletedMovies = new List<DTO.Movie>();

        public DeletedMoviesUC(Home form, DTO.Employee employee)
        {
            InitializeComponent();
            this._home = form;
            this._employee = employee;
            movieBLL = new MovieBLL();

            this.Load += DeletedMoviesUC_Load;
        }

        private void DeletedMoviesUC_Load(object sender, EventArgs e)
        {
            LoadDeletedMovies();
        }

        private void LoadDeletedMovies()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                deletedMovies = movieBLL.GetDeletedMovies();
                DisplayMovies(deletedMovies);
                UpdateInfoLabel();
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
                        Text = global::UI.Resources.Lang.khongcophimdaxoa,
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        ForeColor = Color.Gray,
                        AutoSize = true
                    };

                    lblNoData.Location = new Point(
                        (noDataPanel.Width - lblNoData.Width) / 2,
                        (noDataPanel.Height - lblNoData.Height) / 2
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
                BackColor = Color.FromArgb(255, 245, 245),
                Size = new Size(296, 407),
                Margin = new Padding(6)
            };

            // Badge đã xóa
            Label badge = new Label
            {
                BackColor = Color.FromArgb(220, 53, 69),
                Font = new Font("Segoe UI", 7F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(8, 8),
                Size = new Size(75, 18),
                Text = "Đã xóa",
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Poster với overlay mờ
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
                BackColor = Color.FromArgb(220, 220, 220)
            };

            if (!string.IsNullOrEmpty(movie.ImageUrl))
            {
                ImgHelper.DisplayImageFromRelative(movie.ImageUrl, posterPicBox);
            }

            // Overlay mờ
            Panel overlay = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(100, 128, 128, 128)
            };

            posterPicBox.Controls.Add(overlay);
            posterPanel.Controls.Add(posterPicBox);

            // Tiêu đề
            Label lblTitle = new Label
            {
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(100, 50, 50),
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
                ForeColor = Color.FromArgb(120, 120, 120),
                Location = new Point(12, 250),
                Text = $"⏱ {movieBLL.FormatDuration(movie.DurationMinutes)}"
            };

            // Thể loại
            Label lblCategory = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(120, 120, 120),
                Location = new Point(12, 270),
                Size = new Size(260, 20),
                Text = $"🎭 {movie.Genre ?? "Chưa xác định"}",
                AutoEllipsis = true
            };

            // Ngôn ngữ
            Label lblLanguage = new Label
            {
                AutoSize = true,
                BackColor = Color.FromArgb(150, 150, 150),
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
                ForeColor = Color.FromArgb(120, 120, 120),
                Location = new Point(12, 320),
                Size = new Size(275, 39),
                Text = movieBLL.FormatMovieDates(movie)
            };

            // Buttons

            var btnRestore = CreateActionButton("Khôi phục", Color.FromArgb(40, 167, 69), new Point(12, 374), new Size(125, 25));
            btnRestore.ButtonImage = null;
            btnRestore.Click += (s, e) => RestoreMovie(movie);

            var btnPermanentDelete = CreateActionButton("Xóa vĩnh viễn", Color.FromArgb(220, 53, 69), new Point(147, 374), new Size(141, 25));
            btnPermanentDelete.ButtonImage = null;
            btnPermanentDelete.Click += (s, e) => PermanentDeleteMovie(movie);

            card.Controls.AddRange(new Control[] {
                posterPanel, badge, lblTitle, lblDuration, lblCategory,
                lblLanguage, lblDates, btnRestore, btnPermanentDelete
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

        private void RestoreMovie(DTO.Movie movie)
        {
            try
            {
                var confirmResult = MessageBox.Show(
                    $"Bạn có chắc muốn khôi phục phim '{movie.Title}'?",
                    "♻️ Xác nhận khôi phục",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var result = movieBLL.RestoreMovie(movie.MovieID);

                    if (result.Item1)
                    {
                        MessageBox.Show(result.Item2, "✓ Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDeletedMovies();
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
                MessageBox.Show($"Lỗi khi khôi phục phim: {ex.Message}", "✗ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PermanentDeleteMovie(DTO.Movie movie)
        {
            try
            {
                var confirmResult = MessageBox.Show(
                    $"⚠️ CẢNH BÁO: Bạn có chắc muốn XÓA VĨNH VIỄN phim '{movie.Title}'?\n\n" +
                    "Hành động này KHÔNG THỂ HOÀN TÁC!",
                    "⚠️ Xác nhận xóa vĩnh viễn",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    var result = movieBLL.PermanentDeleteMovie(movie.MovieID);

                    if (result.Item1)
                    {
                        MessageBox.Show(result.Item2, "✓ Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDeletedMovies();
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
                MessageBox.Show($"Lỗi khi xóa vĩnh viễn phim: {ex.Message}", "✗ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInfoLabel()
        {
            try
            {
                lblInfo.Text = global::UI.Resources.Lang.tongsophimdaxoa +$" {deletedMovies.Count}";
            }
            catch (Exception ex)
            {
                lblInfo.Text = $"Lỗi hiển thị thông tin: {ex.Message}";
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                _home.LoadControl(new Movie_MainUC(_home, _employee));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi quay lại: {ex.Message}", "✗ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}