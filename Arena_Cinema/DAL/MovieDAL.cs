using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using DTO;

namespace DAL
{
    public class MovieDAL
    {
        private readonly CinemaDBContext db;

        public MovieDAL()
        {
            db = new CinemaDBContext();
        }

        // Thêm phim mới
        public bool AddMovie(Movie movie)
        {
            try
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in AddMovie: {ex.Message}");
                if (ex.InnerException != null)
                    System.Diagnostics.Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                return false;
            }
        }

        // Lấy tất cả phim chưa bị xóa
        public List<Movie> GetAllMovies()
        {
            try
            {
                return db.Movies
                    .Where(m => !m.IsDeleted)
                    .OrderByDescending(m => m.MovieID)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetAllMovies: {ex.Message}");
                return new List<Movie>();
            }
        }

        // Lấy phim theo ID
        public Movie GetMovieById(int movieId)
        {
            try
            {
                return db.Movies.FirstOrDefault(m => m.MovieID == movieId && !m.IsDeleted);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetMovieById: {ex.Message}");
                return null;
            }
        }

        // Tìm kiếm phim theo tên
        public List<Movie> SearchMoviesByTitle(string title)
        {
            try
            {
                return db.Movies
                    .Where(m => !m.IsDeleted && m.Title.Contains(title))
                    .OrderByDescending(m => m.MovieID)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in SearchMoviesByTitle: {ex.Message}");
                return new List<Movie>();
            }
        }

        // Lọc phim theo trạng thái
        public List<Movie> FilterMoviesByStatus(string status)
        {
            try
            {
                DateTime today = DateTime.Today;

                switch (status)
                {
                    case "Đang chiếu":
                        return db.Movies
                            .Where(m => !m.IsDeleted &&
                                   m.StartTime <= today &&
                                   (m.EndTime == null || m.EndTime >= today))
                            .OrderByDescending(m => m.MovieID)
                            .ToList();

                    case "Sắp chiếu":
                        return db.Movies
                            .Where(m => !m.IsDeleted && m.StartTime > today)
                            .OrderByDescending(m => m.MovieID)
                            .ToList();

                    case "Đã kết thúc":
                        return db.Movies
                            .Where(m => !m.IsDeleted &&
                                   m.EndTime != null &&
                                   m.EndTime < today)
                            .OrderByDescending(m => m.MovieID)
                            .ToList();

                    default: // Tất cả phim
                        return GetAllMovies();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in FilterMoviesByStatus: {ex.Message}");
                return new List<Movie>();
            }
        }

        // Cập nhật thông tin phim
        public bool UpdateMovie(Movie movie)
        {
            try
            {
                var existingMovie = db.Movies.Find(movie.MovieID);
                if (existingMovie == null || existingMovie.IsDeleted)
                    return false;

                // Cập nhật các thuộc tính
                existingMovie.Title = movie.Title;
                existingMovie.DurationMinutes = movie.DurationMinutes;
                existingMovie.Genre = movie.Genre;
                existingMovie.Language = movie.Language;
                existingMovie.Sub = movie.Sub;
                existingMovie.Dub = movie.Dub;
                existingMovie.AgeLimit = movie.AgeLimit;
                existingMovie.MovieType = movie.MovieType;
                existingMovie.StartTime = movie.StartTime;
                existingMovie.EndTime = movie.EndTime;
                existingMovie.Description = movie.Description;
                existingMovie.Preview = movie.Preview;
                existingMovie.ImageUrl = movie.ImageUrl;
                existingMovie.LinkTrailer = movie.LinkTrailer;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in UpdateMovie: {ex.Message}");
                if (ex.InnerException != null)
                    System.Diagnostics.Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                return false;
            }
        }

        // Xóa mềm phim (đặt IsDeleted = true)
        public bool DeleteMovie(int movieId)
        {
            try
            {
                var movie = db.Movies.Find(movieId);
                if (movie == null)
                    return false;

                movie.IsDeleted = true;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in DeleteMovie: {ex.Message}");
                return false;
            }
        }

        // Kiểm tra tên phim đã tồn tại chưa
        public bool IsMovieTitleExists(string title, int? excludeMovieId = null)
        {
            try
            {
                var query = db.Movies.Where(m => !m.IsDeleted && m.Title.Trim().ToLower() == title.Trim().ToLower());

                if (excludeMovieId.HasValue)
                    query = query.Where(m => m.MovieID != excludeMovieId.Value);

                return query.Any();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in IsMovieTitleExists: {ex.Message}");
                return false;
            }
        }

        // Lấy phim với phân trang
        public List<Movie> GetMoviesWithPaging(int pageNumber, int pageSize, out int totalRecords)
        {
            try
            {
                var query = db.Movies.Where(m => !m.IsDeleted).OrderByDescending(m => m.MovieID);
                totalRecords = query.Count();

                return query
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetMoviesWithPaging: {ex.Message}");
                totalRecords = 0;
                return new List<Movie>();
            }
        }

        // Tìm kiếm và lọc kết hợp với phân trang
        public List<Movie> SearchAndFilterMovies(string searchText, string filterStatus, int pageNumber, int pageSize, out int totalRecords)
        {
            try
            {
                DateTime today = DateTime.Today;
                var query = db.Movies.Where(m => !m.IsDeleted);

                // Lọc theo trạng thái
                switch (filterStatus)
                {
                    case "Đang chiếu":
                        query = query.Where(m => m.StartTime <= today && (m.EndTime == null || m.EndTime >= today));
                        break;
                    case "Sắp chiếu":
                        query = query.Where(m => m.StartTime > today);
                        break;
                    case "Đã kết thúc":
                        query = query.Where(m => m.EndTime != null && m.EndTime < today);
                        break;
                }

                // Tìm kiếm theo tên
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    query = query.Where(m => m.Title.Contains(searchText));
                }

                query = query.OrderByDescending(m => m.MovieID);
                totalRecords = query.Count();

                return query
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in SearchAndFilterMovies: {ex.Message}");
                totalRecords = 0;
                return new List<Movie>();
            }
        }

        // Sử dụng Stored Procedure phân trang
        public List<Movie> GetMoviesPaginatedWithSP(
     int pageNumber,
     int pageSize,
     out int totalRecords,
     out int totalPages,
     string searchKeyword = null,
     string genre = null,
     string ageLimit = null,
     bool isDeleted = false)
        {
            try
            {
                var moviesList = new List<Movie>();
                totalRecords = 0;
                totalPages = 1;

                using (var command = db.Database.Connection.CreateCommand())
                {
                    command.CommandText = "sp_GetMoviesPaginated";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = 30;

                    // Parameters
                    var param1 = new SqlParameter("@PageNumber", pageNumber);
                    var param2 = new SqlParameter("@PageSize", pageSize);
                    var param3 = new SqlParameter("@SearchKeyword", searchKeyword ?? (object)DBNull.Value);
                    var param4 = new SqlParameter("@Genre", genre ?? (object)DBNull.Value);
                    var param5 = new SqlParameter("@AgeLimit", ageLimit ?? (object)DBNull.Value);
                    var param6 = new SqlParameter("@MovieType", DBNull.Value);
                    var param7 = new SqlParameter("@Language", DBNull.Value);
                    var param8 = new SqlParameter("@IsDeleted", isDeleted);
                    var param9 = new SqlParameter("@SortBy", "MovieID");
                    var param10 = new SqlParameter("@SortOrder", "DESC");

                    command.Parameters.AddRange(new[] { param1, param2, param3, param4, param5, param6, param7, param8, param9, param10 });

                    System.Diagnostics.Debug.WriteLine($"[DAL] Executing SP with: Page={pageNumber}, Size={pageSize}, Keyword={searchKeyword}, Genre={genre}, Age={ageLimit}, IsDeleted={isDeleted}");

                    if (command.Connection.State != System.Data.ConnectionState.Open)
                        command.Connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var movie = new Movie
                            {
                                MovieID = reader.GetInt32(reader.GetOrdinal("MovieID")),
                                Title = reader.GetString(reader.GetOrdinal("Title")),
                                DurationMinutes = reader.GetInt32(reader.GetOrdinal("DurationMinutes")),
                                Genre = reader.IsDBNull(reader.GetOrdinal("Genre")) ? null : reader.GetString(reader.GetOrdinal("Genre")),
                                Language = reader.IsDBNull(reader.GetOrdinal("Language")) ? null : reader.GetString(reader.GetOrdinal("Language")),
                                Sub = reader.IsDBNull(reader.GetOrdinal("Sub")) ? null : reader.GetString(reader.GetOrdinal("Sub")),
                                Dub = reader.IsDBNull(reader.GetOrdinal("Dub")) ? (bool?)null : reader.GetBoolean(reader.GetOrdinal("Dub")),
                                AgeLimit = reader.IsDBNull(reader.GetOrdinal("AgeLimit")) ? null : reader.GetString(reader.GetOrdinal("AgeLimit")),
                                MovieType = reader.IsDBNull(reader.GetOrdinal("MovieType")) ? null : reader.GetString(reader.GetOrdinal("MovieType")),
                                StartTime = reader.IsDBNull(reader.GetOrdinal("StartTime")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("StartTime")),
                                EndTime = reader.IsDBNull(reader.GetOrdinal("EndTime")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("EndTime")),
                                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                                Preview = reader.IsDBNull(reader.GetOrdinal("Preview")) ? null : reader.GetString(reader.GetOrdinal("Preview")),
                                ImageUrl = reader.IsDBNull(reader.GetOrdinal("ImageUrl")) ? null : reader.GetString(reader.GetOrdinal("ImageUrl")),
                                LinkTrailer = reader.IsDBNull(reader.GetOrdinal("LinkTrailer")) ? null : reader.GetString(reader.GetOrdinal("LinkTrailer")),
                                IsDeleted = reader.GetBoolean(reader.GetOrdinal("IsDeleted"))
                            };

                            if (!reader.IsDBNull(reader.GetOrdinal("TotalRecords")))
                                totalRecords = reader.GetInt32(reader.GetOrdinal("TotalRecords"));

                            if (!reader.IsDBNull(reader.GetOrdinal("TotalPages")))
                                totalPages = reader.GetInt32(reader.GetOrdinal("TotalPages"));

                            moviesList.Add(movie);
                        }
                    }
                }

                System.Diagnostics.Debug.WriteLine($"[DAL] SP returned: {moviesList.Count} movies, TotalRecords={totalRecords}, TotalPages={totalPages}");

                if (moviesList.Count == 0 && totalRecords > 0)
                {
                    System.Diagnostics.Debug.WriteLine("[DAL] WARNING: TotalRecords > 0 nhưng không có data trả về!");
                }

                return moviesList;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[DAL ERROR] {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"[DAL ERROR] {ex.StackTrace}");
                if (ex.InnerException != null)
                    System.Diagnostics.Debug.WriteLine($"[DAL ERROR Inner] {ex.InnerException.Message}");

                totalRecords = 0;
                totalPages = 1;
                return new List<Movie>();
            }
        }

        // Kiểm tra phim có đang được sử dụng trong ShowTime không
        public bool IsMovieInUse(int movieId)
        {
            try
            {
                return db.ShowTimes.Any(st => st.MovieID == movieId);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in IsMovieInUse: {ex.Message}");
                return false;
            }
        }

        // Kiểm tra phim có đang được sử dụng trong MovieProduct không
        public bool IsMovieInMovieProducts(int movieId)
        {
            try
            {
                return db.MovieProducts.Any(mp => mp.MovieID == movieId);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in IsMovieInMovieProducts: {ex.Message}");
                return false;
            }
        }

        // Lấy phim theo ngôn ngữ
        public List<Movie> GetMoviesByLanguage(string language)
        {
            try
            {
                return db.Movies
                    .Where(m => !m.IsDeleted && m.Language == language)
                    .OrderByDescending(m => m.MovieID)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetMoviesByLanguage: {ex.Message}");
                return new List<Movie>();
            }
        }

        // Lấy phim theo giới hạn tuổi
        public List<Movie> GetMoviesByAgeLimit(string ageLimit)
        {
            try
            {
                return db.Movies
                    .Where(m => !m.IsDeleted && m.AgeLimit == ageLimit)
                    .OrderByDescending(m => m.MovieID)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetMoviesByAgeLimit: {ex.Message}");
                return new List<Movie>();
            }
        }

        // Lấy tất cả phim đã xóa
        public List<Movie> GetDeletedMovies()
        {
            try
            {
                return db.Movies
                    .Where(m => m.IsDeleted)
                    .OrderByDescending(m => m.MovieID)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetDeletedMovies: {ex.Message}");
                return new List<Movie>();
            }
        }

        // Khôi phục phim (đặt IsDeleted = false)
        public bool RestoreMovie(int movieId)
        {
            try
            {
                var movie = db.Movies.Find(movieId);
                if (movie == null)
                    return false;

                movie.IsDeleted = false;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in RestoreMovie: {ex.Message}");
                return false;
            }
        }

        // Xóa vĩnh viễn phim
        public bool PermanentDeleteMovie(int movieId)
        {
            try
            {
                var movie = db.Movies.Find(movieId);
                if (movie == null)
                    return false;

                db.Movies.Remove(movie);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in PermanentDeleteMovie: {ex.Message}");
                return false;
            }
        }

        // Lấy danh sách thể loại phim (từ DB trực tiếp)
        public List<string> GetMovieGenres()
        {
            try
            {
                return db.Movies
                    .Where(m => !m.IsDeleted && !string.IsNullOrEmpty(m.Genre))
                    .Select(m => m.Genre)
                    .Distinct()
                    .OrderBy(g => g)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetMovieGenres: {ex.Message}");
                return new List<string>();
            }
        }

        // Lấy danh sách độ tuổi (từ DB trực tiếp)
        public List<string> GetAgeRatings()
        {
            try
            {
                return db.Movies
                    .Where(m => !m.IsDeleted && !string.IsNullOrEmpty(m.AgeLimit))
                    .Select(m => m.AgeLimit)
                    .Distinct()
                    .OrderBy(a => a)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetAgeRatings: {ex.Message}");
                return new List<string>();
            }
        }

        // Dispose context khi cần
        public void Dispose()
        {
            db?.Dispose();
        }
    }
}