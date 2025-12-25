namespace DTO
{
    using DAL;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            Seats = new HashSet<Seat>();
            ShowTimes = new HashSet<ShowTime>();
        }

        public int RoomID { get; set; }

        [Required]
        [StringLength(100)]
        public string RoomName { get; set; }

        public int? SeatCount { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string RoomType { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(255)]
        public string statement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seat> Seats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
    }
}
