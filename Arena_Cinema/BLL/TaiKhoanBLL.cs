using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; 
using DTO;
namespace BLL
{
    public class TaiKhoanBLL
    {
        public TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public TaiKhoanBLL() {
           
        }

        //public TaiKhoan Login(string username, string password)
        //{
        //        return taiKhoanDAL.GetTaiKhoan(username, password);           
        //}
    }
}
