using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public string sMaTK { get; set; }
        public string sTaiKhoan { get; set; }
        public string sMatKhau { get; set; }
        public string sQuyen { get; set; }
        public TaiKhoan() { }
        public TaiKhoan(string maTK, string taiKhoan, string matKhau, string Quyen)
        {
            this.sMaTK = maTK;
            this.sTaiKhoan = taiKhoan;
            this.sMatKhau = matKhau;
            this.sQuyen = Quyen;
        }
        public override string ToString()
        {
            return $"Mã TK: {sMaTK}, Tài khoản: {sTaiKhoan}, Mật khẩu: {sMatKhau}, Mã quyền: {sQuyen}";
        }

    }
}
