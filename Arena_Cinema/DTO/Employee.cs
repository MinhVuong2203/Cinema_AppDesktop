namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Invoices = new HashSet<Invoice>();
            WorkShifts = new HashSet<WorkShift>();
            Operations = new HashSet<Operation>();

            //voucher navigation properties
            CreatedVouchers = new HashSet<Voucher>();
            RedeemedVouchers = new HashSet<CustomerVoucher>();
        }

        public Guid EmployeeID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        public int? HourWage { get; set; }

        [StringLength(20)]
        public string CCCD { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }
        public int? RoleId { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RegisterDate { get; set; }

        public bool IsDeleted { get; set; }
        public virtual Role Role { get; set; }

        public virtual Account Account { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }

        public virtual Setting Setting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkShift> WorkShifts { get; set; }

        public virtual ICollection<Operation> Operations { get; set; }

        //voucher navigation properties
        public virtual ICollection<Voucher> CreatedVouchers { get; set; }
        public virtual ICollection<CustomerVoucher> RedeemedVouchers { get; set; }


    }
}
