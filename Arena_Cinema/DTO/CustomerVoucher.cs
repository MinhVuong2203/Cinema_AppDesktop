using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("CustomerVoucher")]
    public partial class CustomerVoucher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerVoucherID { get; set; }

        [Required]
        public int VoucherID { get; set; }

        [Required]
        public Guid CustomerID { get; set; }

        public Guid? RedeemedBy { get; set; }

        public DateTime RedeemedDate { get; set; }

        public int PointsUsed { get; set; }

        [Required]
        [StringLength(30)]
        public string Status { get; set; } // 'Chưa sử dụng', 'Đã sử dụng', 'Hết hạn'

        public DateTime? UsedDate { get; set; }

        public Guid? InvoiceID { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        public bool IsDeleted { get; set; }

        // Navigation properties
        [ForeignKey("VoucherID")]
        public virtual Voucher Voucher { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("RedeemedBy")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("InvoiceID")]
        public virtual Invoice Invoice { get; set; }
    }
}