using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SeatDAL
    {
        private readonly CinemaDBContext _context;
        public SeatDAL()
        {
            _context = new CinemaDBContext();
        }

        public Seat getAllSeatById(int id)
        {
            return _context.Seats.Find(id); 
        }
    }
}
