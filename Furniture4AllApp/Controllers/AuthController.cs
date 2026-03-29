using Furniture4AllApp.DAL;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Controllers
{
    public class AuthController
    {
        private EmployeeDAL employeeDAL = new EmployeeDAL();

        public Employee Login(string username, string password)
        {
            return employeeDAL.GetEmployee(username, password);
        }
    }
}
