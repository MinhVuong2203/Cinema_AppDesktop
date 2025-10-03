using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDAL
    {
        public Employee getAccount(string username, string password)
        {
            using (SqlConnection conn = SqlConnectData.Connect())
            {
                conn.Open();
                string query = "SELECT * " +
                               "FROM Employee " +
                               "WHERE Username = @username AND PasswordHash = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = int.Parse(reader["EmployeeID"].ToString());
                    string FullName = reader["FullName"].ToString();
                    string Phone = reader["Phone"].ToString();
                    string Email = reader["Email"].ToString();
                    string Address = reader["Address"].ToString();
                    string BirthDate = reader["BirthDate"].ToString();
                    int HourWage = int.Parse(reader["HourWage"].ToString());
                    string CCCD = reader["CCCD"].ToString();
                    string Gender = reader["Gender"].ToString();
                    string Role = reader["Role"].ToString();
                    string Username = reader["Username"].ToString();
                    string PasswordHash = reader["PasswordHash"].ToString();
                    string ImageUrl = reader["ImageUrl"].ToString();
                    DateTime? RegisterDate = reader["RegisterDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["RegisterDate"]);
                    bool IsDeleted = bool.Parse(reader["IsDeleted"].ToString());

                    return new Employee(id, FullName, Phone, Email, BirthDate, Gender, RegisterDate.GetValueOrDefault(),
                        IsDeleted, Address, HourWage, CCCD, Role, username, PasswordHash, ImageUrl);
                }
                
            }

            return null;
        }
    }
}
