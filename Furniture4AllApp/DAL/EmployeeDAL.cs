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
        /// Gets the employee. The plain-text password is hashed (SHA256) before
        /// being compared to the password_hash column in the Employee table.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The plain-text password.</param>
        /// <returns>The Employee if credentials match, otherwise null.</returns>
        public Employee GetEmployee(string username, string password)
        {
            string hashed = PasswordHasher.Hash(password);

            using (SqlConnection conn = dbHelper.GetConnection()) {
                conn.Open();
                string query = @"SELECT employee_id, fname, lname, username, is_admin
                FROM Employee Where
                username = @username AND password_hash = @password";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashed);

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
