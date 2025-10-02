using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int DurationMinutes { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Sub { get; set; }
        public bool Dub { get; set; }
        public int AgeLimit { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public bool IsDeleted { get; set; }

        public Movie() { }

        public Movie(int movieID, string title, int durationMinutes, string genre, string language, string sub, bool dub, int ageLimit, DateTime startTime, DateTime endTime, string description, string imgUrl, bool isDeleted)
        {
            MovieID = movieID;
            Title = title;
            DurationMinutes = durationMinutes;
            Genre = genre;
            Language = language;
            Sub = sub;
            Dub = dub;
            AgeLimit = ageLimit;
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
            ImgUrl = imgUrl;
            IsDeleted = isDeleted;
        }
    }
}
