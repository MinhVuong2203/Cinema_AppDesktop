namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceTicket")]
    public partial class InvoiceTicket
    {
        public Guid InvoiceTicketID { get; set; }

        public Guid InvoiceID { get; set; }

        public Guid TicketID { get; set; }

        public int? Quantity { get; set; }

        public decimal? UnitPrice { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
