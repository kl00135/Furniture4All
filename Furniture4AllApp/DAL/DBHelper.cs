using System.Data.SqlClient;

namespace Furniture4AllApp.DAL
{

    public class DBHelper
    {
        private string connectionString = "";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
