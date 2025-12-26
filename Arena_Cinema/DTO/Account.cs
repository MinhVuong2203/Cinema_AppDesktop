namespace DTO
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [ForeignKey("Employee")]
        public Guid EmployeeID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(255)]
        public string PasswordHash { get; set; }

        public int RoleId { get; set; }

        [StringLength(200)]
        public string ResetOtpHash { get; set; }

        public DateTime? ResetOtpExpiresAt { get; set; }

        public int ResetOtpAttemptCount { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}
