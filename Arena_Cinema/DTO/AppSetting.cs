using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("AppSettings", Schema = "dbo")]
    public partial class AppSetting
    {
        [Key]
        public int SettingId { get; set; }

        [Required]
        public Guid TenantId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TrialStartUtc { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedAtUtc { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime UpdatedAtUtc { get; set; }

        public AppSetting()
        {
            // Nếu bạn muốn “đỡ quên set” khi insert bằng EF
            var now = DateTime.UtcNow;
            CreatedAtUtc = now;
            UpdatedAtUtc = now;
        }
    }
}
