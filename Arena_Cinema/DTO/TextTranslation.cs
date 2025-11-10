namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TextTranslation")]
    public partial class TextTranslation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string TextKey { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string LanguageCode { get; set; }

        [Required]
        [StringLength(255)]
        public string DisplayText { get; set; }

        public virtual Language Language { get; set; }
    }
}
