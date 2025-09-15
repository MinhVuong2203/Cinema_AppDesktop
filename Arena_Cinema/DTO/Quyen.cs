using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Quyen
    {
        public int iMaQuyen { get; set; }
        public string sTenQuyen { get; set; }

        public Quyen() { }
        public Quyen(int maQuyen, string tenQuyen)
        {
            this.iMaQuyen = maQuyen;
            this.sTenQuyen = tenQuyen;
        }
    }
}
