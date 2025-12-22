using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("Operation")]
    public partial class Operation
    {
        public Operation()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        public int OperationId { get; set; }

        [Required]
        [StringLength(100)]
        public string OperationCode { get; set; }

        [Required]
        [StringLength(100)]
        public string OperationName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
