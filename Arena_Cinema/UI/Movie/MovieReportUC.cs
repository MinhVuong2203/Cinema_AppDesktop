using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using MovieDTO = DTO.Movie;

namespace UI.Movie
{
    public partial class MovieReportUC : UserControl
    {
        private MovieBLL movieBLL;
        private List<MovieDTO> filteredMovies;

        public MovieReportUC()
        {
            InitializeComponent();
            movieBLL = new MovieBLL();
            filteredMovies = new List<MovieDTO>();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.Load += MovieReportUC_Load;
            btnApplyFilter.Click += BtnApplyFilter_Click;
            btnResetFilter.Click += BtnResetFilter_Click;
            cboGenre.SelectedIndexChanged += CboGenre_SelectedIndexChanged;
            cboAgeLimit.SelectedIndexChanged += CboAgeLimit_SelectedIndexChanged;
            cboStatus.SelectedIndexChanged += CboStatus_SelectedIndexChanged;
        }

        private void MovieReportUC_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFilterData();
                LoadDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFilterData()
        {
            try
            {
                // Load thể loại
                var genres = movieBLL.GetGenresFromDB();
                cboGenre.DataSource = genres;

                // Load độ tuổi
                var ageRatings = movieBLL.GetAgeRatingsFromDB();
                cboAgeLimit.DataSource = ageRatings;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải bộ lọc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDashboard()
        {
            try
            {
                // Lấy tất cả phim
                var allMovies = movieBLL.GetAllMovies();
                filteredMovies = allMovies;

                // Cập nhật thống kê
                UpdateStatistics(allMovies);

                // Vẽ biểu đồ
                DrawMovieStatusChart(allMovies);
                DrawGenreDistributionChart(allMovies);
                DrawAgeRatingDistributionChart(allMovies);

                // Load DataGridView
                LoadMoviesDataGrid(allMovies);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải bảng điều khiển: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatistics(List<MovieDTO> movies)
        {
            try
            {
                var stats = movieBLL.GetMovieCountByStatus();

                lblTotalMovies.Text = $"Tổng Phim: {stats["Tất cả phim"]}";
                lblShowingMovies.Text = $"Đang Chiếu: {stats["Đang chiếu"]}";
                lblComingMovies.Text = $"Sắp Chiếu: {stats["Sắp chiếu"]}";
                lblEndedMovies.Text = $"Đã Kết Thúc: {stats["Đã kết thúc"]}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật thống kê: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawMovieStatusChart(List<MovieDTO> movies)
        {
            try
            {
                chartMovieStats.Series.Clear();
                chartMovieStats.ChartAreas.Clear();

                var chartArea = new ChartArea("ChartArea1");
                chartMovieStats.ChartAreas.Add(chartArea);

                var series = new Series("Số Lượng Phim")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                var stats = movieBLL.GetMovieCountByStatus();

                series.Points.AddXY("Đang Chiếu", stats["Đang chiếu"]);
                series.Points.AddXY("Sắp Chiếu", stats["Sắp chiếu"]);
                series.Points.AddXY("Đã Kết Thúc", stats["Đã kết thúc"]);

                // Đặt màu cho các cột
                series.Points[0].Color = Color.FromArgb(46, 204, 113);  // Green
                series.Points[1].Color = Color.FromArgb(241, 196, 15);  // Yellow
                series.Points[2].Color = Color.FromArgb(149, 165, 166); // Gray

                chartMovieStats.Series.Add(series);
                chartMovieStats.Titles.Clear();
                chartMovieStats.Titles.Add("Thống Kê Trạng Thái Phim");

                chartMovieStats.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi vẽ biểu đồ trạng thái: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawGenreDistributionChart(List<MovieDTO> movies)
        {
            try
            {
                chartGenreDistribution.Series.Clear();
                chartGenreDistribution.ChartAreas.Clear();
                chartGenreDistribution.Legends.Clear();

                var chartArea = new ChartArea("ChartArea1");
                chartGenreDistribution.ChartAreas.Add(chartArea);

                var series = new Series("Số Lượng")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true
                };

                // Nhóm phim theo thể loại
                var genreGroups = movies
                    .Where(m => !string.IsNullOrEmpty(m.Genre))
                    .GroupBy(m => m.Genre)
                    .Select(g => new { Genre = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .Take(10); // Lấy top 10

                foreach (var genre in genreGroups)
                {
                    series.Points.AddXY(genre.Genre, genre.Count);
                }

                chartGenreDistribution.Series.Add(series);
                chartGenreDistribution.Titles.Clear();
                chartGenreDistribution.Titles.Add("Phân Bố Theo Thể Loại");

                // Thêm Legend
                var legend = new System.Windows.Forms.DataVisualization.Charting.Legend("Legend1");
                legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
                legend.Alignment = System.Drawing.StringAlignment.Center;
                chartGenreDistribution.Legends.Add(legend);
                series.Legend = "Legend1";
                series.IsVisibleInLegend = true;

                chartGenreDistribution.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi vẽ biểu đồ thể loại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawAgeRatingDistributionChart(List<MovieDTO> movies)
        {
            try
            {
                chartAgeRatingDistribution.Series.Clear();
                chartAgeRatingDistribution.ChartAreas.Clear();
                chartAgeRatingDistribution.Legends.Clear();

                var chartArea = new ChartArea("ChartArea1");
                chartAgeRatingDistribution.ChartAreas.Add(chartArea);

                var series = new Series("Số Lượng")
                {
                    ChartType = SeriesChartType.Doughnut,
                    IsValueShownAsLabel = true
                };

                // Nhóm phim theo độ tuổi
                var ageGroups = movies
                    .Where(m => !string.IsNullOrEmpty(m.AgeLimit))
                    .GroupBy(m => m.AgeLimit)
                    .Select(g => new { AgeLimit = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count);

                foreach (var age in ageGroups)
                {
                    series.Points.AddXY(age.AgeLimit, age.Count);
                }

                chartAgeRatingDistribution.Series.Add(series);
                chartAgeRatingDistribution.Titles.Clear();
                chartAgeRatingDistribution.Titles.Add("Phân Bố Theo Độ Tuổi");

                // Thêm Legend
                var legend = new System.Windows.Forms.DataVisualization.Charting.Legend("Legend1");
                legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
                legend.Alignment = System.Drawing.StringAlignment.Center;
                chartAgeRatingDistribution.Legends.Add(legend);
                series.Legend = "Legend1";
                series.IsVisibleInLegend = true;

                chartAgeRatingDistribution.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi vẽ biểu đồ độ tuổi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMoviesDataGrid(List<MovieDTO> movies)
        {
            try
            {
                dgvMovies.DataSource = null;
                dgvMovies.Rows.Clear();
                dgvMovies.Columns.Clear();

                // Tạo các cột
                dgvMovies.Columns.Add("MovieID", "ID");
                dgvMovies.Columns.Add("Title", "Tên Phim");
                dgvMovies.Columns.Add("Genre", "Thể Loại");
                dgvMovies.Columns.Add("AgeLimit", "Độ Tuổi");
                dgvMovies.Columns.Add("Duration", "Thời Lượng");
                dgvMovies.Columns.Add("StartDate", "Khởi Chiếu");
                dgvMovies.Columns.Add("EndDate", "Kết Thúc");
                dgvMovies.Columns.Add("Status", "Trạng Thái");

                // Đặt độ rộng cột
                dgvMovies.Columns["MovieID"].Width = 50;
                dgvMovies.Columns["Title"].Width = 200;
                dgvMovies.Columns["Genre"].Width = 100;
                dgvMovies.Columns["AgeLimit"].Width = 80;
                dgvMovies.Columns["Duration"].Width = 80;
                dgvMovies.Columns["StartDate"].Width = 100;
                dgvMovies.Columns["EndDate"].Width = 100;
                dgvMovies.Columns["Status"].Width = 100;

                // Thêm dữ liệu
                foreach (var movie in movies)
                {
                    string status = movieBLL.GetMovieStatus(movie);
                    Color statusColor = GetStatusColor(status);

                    dgvMovies.Rows.Add(
                        movie.MovieID,
                        movie.Title,
                        movie.Genre,
                        movie.AgeLimit,
                        movieBLL.FormatDuration(movie.DurationMinutes),
                        movieBLL.FormatDate(movie.StartTime),
                        movieBLL.FormatDate(movie.EndTime),
                        status
                    );

                    // Đặt màu cho hàng
                    int rowIndex = dgvMovies.Rows.Count - 1;
                    dgvMovies.Rows[rowIndex].DefaultCellStyle.BackColor = statusColor;
                    dgvMovies.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải bảng dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Đang chiếu":
                    return Color.FromArgb(46, 204, 113);
                case "Sắp chiếu":
                    return Color.FromArgb(241, 196, 15);
                case "Đã kết thúc":
                    return Color.FromArgb(149, 165, 166);
                default:
                    return Color.FromArgb(52, 152, 219);
            }
        }

        private void BtnApplyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedGenre = cboGenre.SelectedItem?.ToString();
                string selectedAge = cboAgeLimit.SelectedItem?.ToString();
                string selectedStatus = cboStatus.SelectedItem?.ToString();

                var allMovies = movieBLL.GetAllMovies();

                // Lọc theo thể loại
                if (!string.IsNullOrEmpty(selectedGenre) && selectedGenre != "Tất cả")
                {
                    allMovies = allMovies.Where(m =>
                        !string.IsNullOrEmpty(m.Genre) &&
                        m.Genre.Contains(selectedGenre)
                    ).ToList();
                }

                // Lọc theo độ tuổi
                if (!string.IsNullOrEmpty(selectedAge) && selectedAge != "Tất cả")
                {
                    allMovies = allMovies.Where(m => m.AgeLimit == selectedAge).ToList();
                }

                // Lọc theo trạng thái
                if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "Tất cả phim")
                {
                    allMovies = allMovies.Where(m =>
                        movieBLL.GetMovieStatus(m) == selectedStatus
                    ).ToList();
                }

                filteredMovies = allMovies;

                // Cập nhật giao diện
                UpdateStatistics(allMovies);
                DrawMovieStatusChart(allMovies);
                DrawGenreDistributionChart(allMovies);
                DrawAgeRatingDistributionChart(allMovies);
                LoadMoviesDataGrid(allMovies);

                MessageBox.Show($"Tìm thấy {allMovies.Count} phim phù hợp!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi áp dụng bộ lọc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnResetFilter_Click(object sender, EventArgs e)
        {
            try
            {
                cboGenre.SelectedIndex = 0;
                cboAgeLimit.SelectedIndex = 0;
                cboStatus.SelectedIndex = 0;

                LoadDashboard();
                MessageBox.Show("Đã đặt lại bộ lọc!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đặt lại bộ lọc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể thêm logic để cập nhật real-time nếu cần
        }

        private void CboAgeLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể thêm logic để cập nhật real-time nếu cần
        }

        private void CboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể thêm logic để cập nhật real-time nếu cần
        }
    }
}