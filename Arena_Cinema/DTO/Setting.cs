namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Setting")]
    public partial class Setting
    {
        [Key, ForeignKey("Employee")]
        public Guid EmployeeID { get; set; }

        [StringLength(10)]
        public string LanguageCode { get; set; }

        [StringLength(50)]
        public string FontText { get; set; }

        public int? SizeText { get; set; }

        [StringLength(20)]
        public string MainColor { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
