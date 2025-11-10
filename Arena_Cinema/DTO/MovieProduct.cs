namespace DAL
{
    using DTO;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovieProduct")]
    public partial class MovieProduct
    {
        public Guid MovieProductID { get; set; }

        public int MovieID { get; set; }

        public int ProductID { get; set; }

        [StringLength(20)]
        public string OfferType { get; set; }

        public int? Quantity { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual Product Product { get; set; }
    }
}
