using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public TaiKhoan GetTaiKhoan(string username, string password)
        {
            using (SqlConnection conn = SqlConnectData.Connect())
            {
               conn.Open();
                string query = "SELECT * " +
                               "FROM TaiKhoan " +
                               "WHERE sTaiKhoan = @username AND sMatKhau = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new TaiKhoan(
                       reader["sMaTK"].ToString(),
                       reader["sTaiKhoan"].ToString(),
                       reader["sMatKhau"].ToString(),
                       reader["sQuyen"].ToString()
                    );
                }
            }
            return null;
        }

    }
}
