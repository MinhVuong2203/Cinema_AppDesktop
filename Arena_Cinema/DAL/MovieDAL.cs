using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                // Log exception nếu cần
                System.Diagnostics.Debug.WriteLine($"Error in AddMovie: {ex.Message}");
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

        // Dispose context khi cần
        public void Dispose()
        {
            db?.Dispose();
        }
    }
}