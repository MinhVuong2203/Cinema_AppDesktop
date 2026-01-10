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

            if (string.IsNullOrWhiteSpace(movie.Genre))
                return "Vui lòng nhập thể loại phim!";

            if (string.IsNullOrWhiteSpace(movie.MovieType))
                return "Vui lòng chọn loại phim!";

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

                // Nếu không có Sub thì dùng Genre
                if (string.IsNullOrWhiteSpace(movie.Sub))
                    movie.Sub = movie.Genre;

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

        // Tìm kiếm phim (phương thức cũ - giữ lại cho tương thích)
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

        // Tìm kiếm và lọc phim với phân trang sử dụng stored procedure
        // FIXED: Đổi thứ tự tham số để khớp với MovieDAL
        // Tìm kiếm và lọc phim với phân trang sử dụng stored procedure
        public List<Movie> SearchMoviesWithPagingSP(
            string searchText,
            string filterStatus,
            string genre,
            string ageLimit,
            int pageNumber,
            int pageSize,
            out int totalPages)
        {
            try
            {
                int totalRecords;

                // ✅ BƯỚC 1: Lấy TẤT CẢ phim phù hợp (không phân trang)
                // Đặt pageSize = int.MaxValue để lấy hết
                var allMovies = movieDAL.GetMoviesPaginatedWithSP(
                    pageNumber: 1,
                    pageSize: int.MaxValue,
                    totalRecords: out totalRecords,
                    totalPages: out int _,
                    searchKeyword: string.IsNullOrWhiteSpace(searchText) ? null : searchText,
                    genre: string.IsNullOrWhiteSpace(genre) || genre == "Tất cả" ? null : genre,
                    ageLimit: string.IsNullOrWhiteSpace(ageLimit) || ageLimit == "Tất cả" ? null : ageLimit,
                    isDeleted: false
                );

                // ✅ BƯỚC 2: Lọc theo trạng thái (client-side)
                List<Movie> filteredMovies;

                if (filterStatus != "Tất cả phim" && allMovies.Count > 0)
                {
                    DateTime today = DateTime.Today;

                    filteredMovies = allMovies.Where(m =>
                    {
                        string status = GetMovieStatus(m);
                        return status == filterStatus;
                    }).ToList();
                }
                else
                {
                    filteredMovies = allMovies;
                }

                // ✅ BƯỚC 3: Tính lại totalRecords và totalPages SAU KHI lọc
                int actualTotalRecords = filteredMovies.Count;
                totalPages = actualTotalRecords > 0
                    ? (int)Math.Ceiling((double)actualTotalRecords / pageSize)
                    : 1;

                // ✅ BƯỚC 4: Phân trang thủ công trên kết quả đã lọc
                var pagedMovies = filteredMovies
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                System.Diagnostics.Debug.WriteLine($"[BLL] FilterStatus={filterStatus}, AllMovies={allMovies.Count}, Filtered={filteredMovies.Count}, Paged={pagedMovies.Count}, TotalPages={totalPages}");

                return pagedMovies;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in SearchMoviesWithPagingSP: {ex.Message}");
                totalPages = 1;
                return new List<Movie>();
            }
        }

        // Tìm kiếm và lọc với phân trang (phương thức cũ - giữ lại cho tương thích)
        public List<Movie> SearchMoviesWithPaging(string searchText, string filterStatus, int pageNumber, int pageSize, out int totalPages)
        {
            try
            {
                int totalRecords;
                var movies = movieDAL.SearchAndFilterMovies(searchText, filterStatus, pageNumber, pageSize, out totalRecords);
                totalPages = totalRecords > 0 ? (int)Math.Ceiling((double)totalRecords / pageSize) : 1;
                return movies;
            }
            catch (Exception)
            {
                totalPages = 1;
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

                // Nếu không có Sub thì dùng Genre
                if (string.IsNullOrWhiteSpace(movie.Sub))
                    movie.Sub = movie.Genre;

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

        // Xóa phim (soft delete)
        public Tuple<bool, string> DeleteMovie(int movieId)
        {
            try
            {
                // Kiểm tra xem phim có tồn tại không
                var movie = movieDAL.GetMovieById(movieId);
                if (movie == null)
                    return new Tuple<bool, string>(false, "Không tìm thấy phim!");

                // Kiểm tra xem phim có đang được sử dụng trong lịch chiếu không
                if (movieDAL.IsMovieInUse(movieId))
                    return new Tuple<bool, string>(false, "Không thể xóa phim đang có lịch chiếu!");

                // Kiểm tra xem phim có trong MovieProducts không
                if (movieDAL.IsMovieInMovieProducts(movieId))
                    return new Tuple<bool, string>(false, "Không thể xóa phim đã có sản phẩm liên kết!");

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

        // Lấy phim với phân trang (phương thức cũ)
        public List<Movie> GetMoviesWithPaging(int pageNumber, int pageSize, out int totalPages)
        {
            try
            {
                int totalRecords;
                var movies = movieDAL.GetMoviesWithPaging(pageNumber, pageSize, out totalRecords);
                totalPages = totalRecords > 0 ? (int)Math.Ceiling((double)totalRecords / pageSize) : 1;
                return movies;
            }
            catch (Exception)
            {
                totalPages = 1;
                return new List<Movie>();
            }
        }

        // Format thời lượng để hiển thị
        public string FormatDuration(int durationMinutes)
        {
            if (durationMinutes < 60)
                return $"{durationMinutes} phút";

            int hours = durationMinutes / 60;
            int minutes = durationMinutes % 60;

            if (minutes == 0)
                return $"{hours} giờ";

            return $"{hours} giờ {minutes} phút";
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

        // Lấy danh sách ngôn ngữ
        public List<string> GetLanguages()
        {
            return new List<string>
            {
                "Tiếng Việt",
                "Tiếng Anh",
                "Tiếng Nhật",
                "Tiếng Hàn",
                "Tiếng Trung",
                "Tiếng Thái",
                "Tiếng Pháp",
                "Tiếng Tây Ban Nha"
            };
        }

        // Lấy danh sách giới hạn tuổi
        public List<string> GetAgeRatings()
        {
            return new List<string>
            {
                "P - Mọi lứa tuổi",
                "K - Dưới 13 tuổi",
                "T13 - Từ 13 tuổi",
                "T16 - Từ 16 tuổi",
                "T18 - Từ 18 tuổi",
                "C - Cấm chiếu"
            };
        }

        // Lấy danh sách loại phim
        public List<string> GetMovieTypes()
        {
            return new List<string>
            {
                "2D",
                "3D",
                "4D",
                "IMAX"
            };
        }

        // Kiểm tra phim có đang được chiếu không
        public bool IsMovieCurrentlyShowing(int movieId)
        {
            try
            {
                var movie = movieDAL.GetMovieById(movieId);
                if (movie == null)
                    return false;

                string status = GetMovieStatus(movie);
                return status == "Đang chiếu";
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Lấy số lượng phim theo trạng thái
        public Dictionary<string, int> GetMovieCountByStatus()
        {
            try
            {
                var allMovies = movieDAL.GetAllMovies();
                var result = new Dictionary<string, int>
                {
                    { "Tất cả phim", allMovies.Count },
                    { "Đang chiếu", 0 },
                    { "Sắp chiếu", 0 },
                    { "Đã kết thúc", 0 }
                };

                foreach (var movie in allMovies)
                {
                    string status = GetMovieStatus(movie);
                    if (result.ContainsKey(status))
                        result[status]++;
                }

                return result;
            }
            catch (Exception)
            {
                return new Dictionary<string, int>();
            }
        }

        // Kiểm tra phim có thể xóa không
        public Tuple<bool, string> CanDeleteMovie(int movieId)
        {
            try
            {
                var movie = movieDAL.GetMovieById(movieId);
                if (movie == null)
                    return new Tuple<bool, string>(false, "Không tìm thấy phim!");

                if (movieDAL.IsMovieInUse(movieId))
                    return new Tuple<bool, string>(false, "Phim đang có lịch chiếu!");

                if (movieDAL.IsMovieInMovieProducts(movieId))
                    return new Tuple<bool, string>(false, "Phim đã có sản phẩm liên kết!");

                return new Tuple<bool, string>(true, "Có thể xóa phim");
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, $"Lỗi: {ex.Message}");
            }
        }

        // Lấy danh sách phim đã xóa
        public List<Movie> GetDeletedMovies()
        {
            try
            {
                return movieDAL.GetDeletedMovies();
            }
            catch (Exception)
            {
                return new List<Movie>();
            }
        }

        // Khôi phục phim
        public Tuple<bool, string> RestoreMovie(int movieId)
        {
            try
            {
                var movie = movieDAL.GetMovieById(movieId);
                if (movie == null)
                {
                    // Thử tìm trong phim đã xóa
                    var deletedMovies = movieDAL.GetDeletedMovies();
                    movie = deletedMovies.FirstOrDefault(m => m.MovieID == movieId);

                    if (movie == null)
                        return new Tuple<bool, string>(false, "Không tìm thấy phim!");
                }

                bool result = movieDAL.RestoreMovie(movieId);

                if (result)
                    return new Tuple<bool, string>(true, "Khôi phục phim thành công!");
                else
                    return new Tuple<bool, string>(false, "Có lỗi xảy ra khi khôi phục phim!");
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, $"Lỗi: {ex.Message}");
            }
        }

        // Xóa vĩnh viễn phim
        public Tuple<bool, string> PermanentDeleteMovie(int movieId)
        {
            try
            {
                // Kiểm tra phim có đang được sử dụng không
                if (movieDAL.IsMovieInUse(movieId))
                    return new Tuple<bool, string>(false, "Không thể xóa vĩnh viễn phim đang có lịch chiếu!");

                if (movieDAL.IsMovieInMovieProducts(movieId))
                    return new Tuple<bool, string>(false, "Không thể xóa vĩnh viễn phim đã có sản phẩm liên kết!");

                bool result = movieDAL.PermanentDeleteMovie(movieId);

                if (result)
                    return new Tuple<bool, string>(true, "Xóa vĩnh viễn phim thành công!");
                else
                    return new Tuple<bool, string>(false, "Không tìm thấy phim hoặc có lỗi xảy ra!");
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, $"Lỗi: {ex.Message}");
            }
        }

        // Lấy danh sách thể loại từ database
        public List<string> GetGenresFromDB()
        {
            try
            {
                var genres = movieDAL.GetMovieGenres();
                genres.Insert(0, "Tất cả"); // Thêm option "Tất cả" ở đầu
                return genres;
            }
            catch (Exception)
            {
                return new List<string> { "Tất cả" };
            }
        }

        // Lấy danh sách độ tuổi từ database
        public List<string> GetAgeRatingsFromDB()
        {
            try
            {
                var ratings = movieDAL.GetAgeRatings();
                ratings.Insert(0, "Tất cả"); // Thêm option "Tất cả" ở đầu
                return ratings;
            }
            catch (Exception)
            {
                return new List<string> { "Tất cả" };
            }
        }

        // Dispose
        public void Dispose()
        {
            movieDAL?.Dispose();
        }
    }
}