using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("Licenses", Schema = "dbo")]
    public partial class License
    {
        [Key]
        public int LicenseId { get; set; }

        [Required]
        public Guid TenantId { get; set; }

        [Required]
        public string LicenseToken { get; set; } // NVARCHAR(MAX)

        [StringLength(50)]
        public string PlanCode { get; set; }     // NVARCHAR(50) NULL

        [Required]
        public int MaxSeats { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime ExpiresAtUtc { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime ActivatedAtUtc { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? RevokedAtUtc { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public License()
        {
            ActivatedAtUtc = DateTime.UtcNow;
            IsActive = true;
        }
    }
}
