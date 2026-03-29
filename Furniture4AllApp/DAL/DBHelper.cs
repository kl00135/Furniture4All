using System.Data.SqlClient;

namespace Furniture4AllApp.DAL
{

    /// <summary>
    /// Sets up connection to the database. The connection string is stored in the app.config file and is read by the constructor of this class. The GetConnection method returns a new SqlConnection object that can be used to interact with the database.
    /// </summary>
    public class DBHelper
    {
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=sqldb-uwg-cs-dev-eu2-01-cs6232-g2;Trusted_Connection=True;";

        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
