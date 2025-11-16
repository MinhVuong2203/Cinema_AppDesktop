using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using DTO;
using DAL;

namespace BLL
{
    public class MovieBLL
    {
        private readonly MovieDAL movieDAL;

        public MovieBLL()
        {
            movieDAL = new MovieDAL();
        }

        // Validate dữ liệu phim
        private string ValidateMovie(Movie movie, bool isUpdate = false)
        {
            if (string.IsNullOrWhiteSpace(movie.Title))
                return "Tên phim không được để trống!";

            if (movie.Title.Length > 200)
                return "Tên phim không được vượt quá 200 ký tự!";

            if (movie.DurationMinutes <= 0)
                return "Thời lượng phim phải lớn hơn 0!";

            if (movie.DurationMinutes > 500)
                return "Thời lượng phim không hợp lệ (quá 500 phút)!";

            if (string.IsNullOrWhiteSpace(movie.Language))
                return "Vui lòng chọn ngôn ngữ!";

            if (string.IsNullOrWhiteSpace(movie.AgeLimit))
                return "Vui lòng chọn giới hạn độ tuổi!";

            if (movie.StartTime.HasValue && movie.EndTime.HasValue)
            {
                if (movie.EndTime.Value < movie.StartTime.Value)
                    return "Ngày kết thúc phải sau ngày khởi chiếu!";
            }

            // Kiểm tra tên phim trùng lặp
            int? excludeId = isUpdate ? movie.MovieID : (int?)null;
            if (movieDAL.IsMovieTitleExists(movie.Title, excludeId))
                return "Tên phim đã tồn tại trong hệ thống!";

            return string.Empty;
        }

        // Thêm phim mới
        public Tuple<bool, string> AddMovie(Movie movie)
        {
            try
            {
                // Validate
                string validationError = ValidateMovie(movie);
                if (!string.IsNullOrEmpty(validationError))
                    return new Tuple<bool, string>(false, validationError);

                // Set default values
                movie.IsDeleted = false;
                movie.MovieType = "Phim"; // Default value

                // Thêm vào database
                bool result = movieDAL.AddMovie(movie);

                if (result)
                    return new Tuple<bool, string>(true, "Thêm phim thành công!");
                else
                    return new Tuple<bool, string>(false, "Có lỗi xảy ra khi thêm phim!");
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, $"Lỗi: {ex.Message}");
            }
        }

        // Lấy tất cả phim
        public List<Movie> GetAllMovies()
        {
            try
            {
                return movieDAL.GetAllMovies();
            }
            catch (Exception)
            {
                return new List<Movie>();
            }
        }

        // Lấy phim theo ID
        public Movie GetMovieById(int movieId)
        {
            try
            {
                return movieDAL.GetMovieById(movieId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Tìm kiếm phim
        public List<Movie> SearchMovies(string searchText, string filterStatus = "Tất cả phim")
        {
            try
            {
                List<Movie> movies;

                // Lọc theo trạng thái trước
                if (filterStatus != "Tất cả phim")
                {
                    movies = movieDAL.FilterMoviesByStatus(filterStatus);
                }
                else
                {
                    movies = movieDAL.GetAllMovies();
                }

                // Nếu có text tìm kiếm, lọc thêm theo tên
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    movies = movies.Where(m => m.Title.ToLower().Contains(searchText.ToLower())).ToList();
                }

                return movies;
            }
            catch (Exception)
            {
                return new List<Movie>();
            }
        }

        // Tìm kiếm và lọc với phân trang
        public List<Movie> SearchMoviesWithPaging(string searchText, string filterStatus, int pageNumber, int pageSize, out int totalPages)
        {
            try
            {
                int totalRecords;
                var movies = movieDAL.SearchAndFilterMovies(searchText, filterStatus, pageNumber, pageSize, out totalRecords);
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                return movies;
            }
            catch (Exception)
            {
                totalPages = 0;
                return new List<Movie>();
            }
        }

        // Lấy trạng thái phim
        public string GetMovieStatus(Movie movie)
        {
            try
            {
                DateTime today = DateTime.Today;

                if (!movie.StartTime.HasValue)
                    return "Chưa xác định";

                if (movie.StartTime.Value > today)
                    return "Sắp chiếu";

                if (!movie.EndTime.HasValue || movie.EndTime.Value >= today)
                    return "Đang chiếu";

                return "Đã kết thúc";
            }
            catch (Exception)
            {
                return "Không xác định";
            }
        }

        // Lấy màu badge theo trạng thái
        public Tuple<int, int, int> GetStatusBadgeColorRGB(string status)
        {
            switch (status)
            {
                case "Đang chiếu":
                    return new Tuple<int, int, int>(40, 167, 69); // Green
                case "Sắp chiếu":
                    return new Tuple<int, int, int>(255, 193, 7); // Yellow
                case "Đã kết thúc":
                    return new Tuple<int, int, int>(108, 117, 125); // Gray
                default:
                    return new Tuple<int, int, int>(23, 162, 184); // Blue
            }
        }

        // Cập nhật phim
        public Tuple<bool, string> UpdateMovie(Movie movie)
        {
            try
            {
                // Validate
                string validationError = ValidateMovie(movie, true);
                if (!string.IsNullOrEmpty(validationError))
                    return new Tuple<bool, string>(false, validationError);

                // Cập nhật
                bool result = movieDAL.UpdateMovie(movie);

                if (result)
                    return new Tuple<bool, string>(true, "Cập nhật phim thành công!");
                else
                    return new Tuple<bool, string>(false, "Có lỗi xảy ra khi cập nhật phim!");
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, $"Lỗi: {ex.Message}");
            }
        }

        // Xóa phim
        public Tuple<bool, string> DeleteMovie(int movieId)
        {
            try
            {
                bool result = movieDAL.DeleteMovie(movieId);

                if (result)
                    return new Tuple<bool, string>(true, "Xóa phim thành công!");
                else
                    return new Tuple<bool, string>(false, "Không tìm thấy phim hoặc có lỗi xảy ra!");
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, $"Lỗi: {ex.Message}");
            }
        }

        // Lấy phim với phân trang
        public List<Movie> GetMoviesWithPaging(int pageNumber, int pageSize, out int totalPages)
        {
            try
            {
                int totalRecords;
                var movies = movieDAL.GetMoviesWithPaging(pageNumber, pageSize, out totalRecords);
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                return movies;
            }
            catch (Exception)
            {
                totalPages = 0;
                return new List<Movie>();
            }
        }

        // Format thời lượng để hiển thị
        public string FormatDuration(int durationMinutes)
        {
            return $"{durationMinutes} phút";
        }

        // Format ngày tháng để hiển thị
        public string FormatDate(DateTime? date)
        {
            if (!date.HasValue)
                return "";

            return date.Value.ToString("dd/MM/yyyy");
        }

        // Format thông tin ngày chiếu
        public string FormatMovieDates(Movie movie)
        {
            string startDate = FormatDate(movie.StartTime);
            string endDate = FormatDate(movie.EndTime);

            if (string.IsNullOrEmpty(startDate))
                return "Chưa xác định";

            if (string.IsNullOrEmpty(endDate))
                return $"Khởi chiếu: {startDate}";

            return $"Khởi chiếu: {startDate}\nKết thúc: {endDate}";
        }
    }
}