namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkShift")]
    public partial class WorkShift
    {
        [Key]
        public int ShiftID { get; set; }

        public Guid EmployeeID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public double? WorkingHours { get; set; }

        public decimal? SalaryPerHour { get; set; }

        [StringLength(30)]
        public string Status { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
