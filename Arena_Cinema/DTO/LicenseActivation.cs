using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("LicenseActivations", Schema = "dbo")]
    public partial class LicenseActivation
    {
        [Key]
        public int ActivationId { get; set; }

        [Required]
        public Guid TenantId { get; set; }

        [Required]
        [StringLength(64)]
        public string InstallId { get; set; }

        [StringLength(128)]
        public string MachineName { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime ActivatedAtUtc { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime LastSeenAtUtc { get; set; }

        [Required]
        public bool IsBlocked { get; set; }

        public LicenseActivation()
        {
            var now = DateTime.UtcNow;
            ActivatedAtUtc = now;
            LastSeenAtUtc = now;
            IsBlocked = false;
        }
    }
}
