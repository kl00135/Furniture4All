namespace Furniture4AllApp.Models
{
    /// <summary>
    /// An employee represents a user of the application who can log in and perform various actions based on their role (admin or regular employee). The Employee class contains properties for storing the employee's ID, username, password hash, first name, last name, and whether they have admin privileges.
    /// </summary>
    public class Employee
    {
        /// <summary>Gets or sets the employee ID.</summary>
        public int EmployeeID { get; set; }
        /// <summary>Gets or sets the username used for login.</summary>
        public string Username { get; set; }
        /// <summary>Gets or sets the hashed password.</summary>
        public string PasswordHash { get; set; }
        /// <summary>Gets or sets the first name.</summary>
        public string FirstName { get; set; }
        /// <summary>Gets or sets the last name.</summary>
        public string LastName { get; set; }
        /// <summary>Gets or sets whether the employee has admin privileges.</summary>
        public bool IsAdmin { get; set; }
    }
}
