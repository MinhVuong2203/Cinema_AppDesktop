using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee : Person
    {
        public string Address { get; set; }
        public int HourWage { get; set; }
        public string CCCD { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }

        public Employee() { }
        public Employee(int id, string fullName, string phone, string email, string birthDate,
            string gender, DateTime registerDate, bool isDeleted, string address, 
            int hourWage, string cCCD, string role, string username, string password, string imageUrl) : base(id, fullName, phone, email, birthDate, gender, registerDate, isDeleted)
        {
            Address = address;
            HourWage = hourWage;
            CCCD = cCCD;
            Role = role;
            Username = username;
            Password = password;
            ImageUrl = imageUrl;
        } 
    }
}
