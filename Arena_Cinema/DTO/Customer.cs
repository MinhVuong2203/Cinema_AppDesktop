using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer : Person
    {
        public double Point { get; set; }
        public int VipLevel { get; set; }
        public Customer() { }

        public Customer(int id, string fullName, string phone, string email, string birthDate, string gender, DateTime registerDate, double point, int vipLevel, bool isDeleted) : base(id, fullName, phone, email, birthDate, gender, registerDate, isDeleted)
        {
            Point = point;
            VipLevel = vipLevel;
        }
    }
}
