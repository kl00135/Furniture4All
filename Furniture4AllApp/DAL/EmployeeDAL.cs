using System.Data.SqlClient;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.DAL
{
    /// <summary>
    /// Connects employees to the db.
    /// </summary>
    public class EmployeeDAL
    {
        private DBHelper dbHelper = new DBHelper();

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public Employee GetEmployee(string username, string password)
        {
            using (SqlConnection conn = dbHelper.GetConnection()) {
                conn.Open();
                string query = @"SELECT employee_id, fname, lname, username, is_admin
                FROM Employee Where 
                username = @username AND password_hash = @password";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Employee
                    {
                        EmployeeID = (int)reader["employee_id"],
                        Username = reader["username"].ToString(),
                        FirstName = reader["fname"].ToString(),
                        LastName = reader["lname"].ToString(),
                        IsAdmin = (bool)reader["is_admin"]
                    };
                }
            }
            return null;
        }
    }
}
