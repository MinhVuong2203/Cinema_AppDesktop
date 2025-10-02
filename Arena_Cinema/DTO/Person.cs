using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class Person
    {
        protected int Id { get; set; }
        protected string FullName { get; set; }
        protected string Phone { get; set; }
        protected string Email { get; set; }
        protected string BirthDate { get; set; }
        protected string Gender { get; set; }
        protected DateTime RegisterDate { get; set; }
        protected bool IsDeleted { get; set; }

        public Person(int id, string fullName, string phone, string email, string birthDate, string gender, DateTime registerDate, bool isDeleted)
        {
            Id = id;
            FullName = fullName;
            Phone = phone;
            Email = email;
            BirthDate = birthDate;
            Gender = gender;
            RegisterDate = registerDate;
            IsDeleted = isDeleted;
        }

        public Person() { }

        
    }
}
