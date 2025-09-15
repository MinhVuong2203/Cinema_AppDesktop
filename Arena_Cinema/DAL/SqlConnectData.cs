using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectData
    {
        private static string strconnect = "Server=tcp:cinema-manager.database.windows.net,1433;Initial Catalog=ArenaCinema;Persist Security Info=False;User ID=arena;Password=AC123456789@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        // tạo chuỗi kết nối DB
        public static SqlConnection Connect()
        {
            return new SqlConnection(strconnect); // Khởi tạo connection
        }

        // đóng kết nối DB
        public static void Disconnect(SqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
    }
}
