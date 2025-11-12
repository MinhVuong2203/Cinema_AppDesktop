using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleDAL
    {
        private readonly CinemaDBContext _context;
        public RoleDAL() {
            _context = new CinemaDBContext();
        }
        public List<DTO.Role> GetAllRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
