using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("Voucher")]
    public partial class Voucher
    {
        public Voucher()
        {
            CustomerVouchers = new HashSet<CustomerVoucher>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VoucherID { get; set; }

        [Required]
        [StringLength(50)]
        public string VoucherCode { get; set; }

        [Required]
        [StringLength(200)]
        public string VoucherName { get; set; }

        public string Description { get; set; }

        [Required]
        [StringLength(20)]
        public string DiscountType { get; set; }

        [Required]
        public decimal DiscountValue { get; set; } // BỎ [Column(TypeName = "decimal(18,2)")]

        public decimal? MaxDiscountAmount { get; set; } // BỎ [Column(TypeName = "decimal(18,2)")]

        public decimal MinOrderAmount { get; set; } // BỎ [Column(TypeName = "decimal(18,2)")]

        public int PointRequired { get; set; }

        public int TotalQuantity { get; set; }

        public int UsedQuantity { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? RemainingQuantity { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public int MaxUsagePerCustomer { get; set; }

        [StringLength(50)]
        public string VoucherCategory { get; set; }

        [StringLength(50)]
        public string ApplicableFor { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        // Navigation properties
        [ForeignKey("CreatedBy")]
        public virtual Employee Employee { get; set; }

        public virtual ICollection<CustomerVoucher> CustomerVouchers { get; set; }
    }
}