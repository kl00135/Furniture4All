using Furniture4AllApp.DAL;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Controllers
{
    /// <summary>
    /// Represents the authentication controller for handling logins and user authentication.
    /// </summary>
    public class AuthController
    {
        private EmployeeDAL employeeDAL = new EmployeeDAL();

        /// <summary>
        /// Logins the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public Employee Login(string username, string password)
        {
            return employeeDAL.GetEmployee(username, password);
        }
    }
}
