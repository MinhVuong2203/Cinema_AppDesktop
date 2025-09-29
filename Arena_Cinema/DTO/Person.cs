using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string gender { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
