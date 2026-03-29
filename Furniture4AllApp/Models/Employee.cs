namespace Furniture4AllApp.Models
{
    /// <summary>
    /// An employee represents a user of the application who can log in and perform various actions based on their role (admin or regular employee). The Employee class contains properties for storing the employee's ID, username, password hash, first name, last name, and whether they have admin privileges.
    /// </summary>
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
    }
}
