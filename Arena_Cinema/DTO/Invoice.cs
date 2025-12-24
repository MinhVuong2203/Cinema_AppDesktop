namespace DTO
{
    using DAL;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            InvoiceProducts = new HashSet<InvoiceProduct>();
            InvoiceTickets = new HashSet<InvoiceTicket>();
            Payments = new HashSet<Payment>();

            CustomerVouchers = new HashSet<CustomerVoucher>();
        }

        public Guid InvoiceID { get; set; }

        public Guid? EmployeeID { get; set; }

        public Guid? CustomerID { get; set; }

        public DateTime IssueDate { get; set; }

        public decimal? TotalAmount { get; set; }

        public decimal? Discount { get; set; }

        [StringLength(30)]
        public string Status { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceTicket> InvoiceTickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }

        public virtual ICollection<CustomerVoucher> CustomerVouchers { get; set; }
    }
}
