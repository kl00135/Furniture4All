/// <summary>
/// This file will construct the members.
/// 
/// Author: Laken Harville
/// Version: 3/30/2026
/// </summary>

using System;

namespace Furniture4AllApp.Models
{
    /// <summary>
    /// This class will be the member that represents a customer registered
    /// in the system.
    /// Members are able to rent and return furniture.
    /// Member personal information stored.
    /// </summary>
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
    }
}