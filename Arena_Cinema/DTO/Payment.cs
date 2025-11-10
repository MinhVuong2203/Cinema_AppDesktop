namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        public Guid PaymentID { get; set; }

        public Guid InvoiceID { get; set; }

        [StringLength(50)]
        public string Method { get; set; }

        public decimal? Amount { get; set; }

        public DateTime? PaymentTime { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
