namespace DTO
{
    using DAL;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            MovieProducts = new HashSet<MovieProduct>();
            ShowTimes = new HashSet<ShowTime>();
        }

        public int MovieID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public int DurationMinutes { get; set; }

        [StringLength(100)]
        public string Genre { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [StringLength(50)]
        public string Sub { get; set; }

        public bool? Dub { get; set; }

        [StringLength(10)]
        public string AgeLimit { get; set; }

        [StringLength(10)]
        public string MovieType { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string Description { get; set; }

        public string Preview { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }

        [StringLength(200)]
        public string LinkTrailer { get; set; }

        public bool IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieProduct> MovieProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
    }
}
