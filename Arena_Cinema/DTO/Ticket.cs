namespace DTO
{
    using DAL;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            InvoiceTickets = new HashSet<InvoiceTicket>();
        }

        public Guid TicketID { get; set; }

        public Guid ShowTimeID { get; set; }

        public int SeatID { get; set; }

        [StringLength(50)]
        public string TicketType { get; set; }

        public decimal? Price { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public Guid? LockedBy { get; set; }

        public DateTime? LockedAt { get; set; }

        public bool IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceTicket> InvoiceTickets { get; set; }

        public virtual Seat Seat { get; set; }

        public virtual ShowTime ShowTime { get; set; }
    }
}
