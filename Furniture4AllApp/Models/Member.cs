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
        /// <summary>
        /// The member ID.
        /// </summary>
        public int MemberID { get; set; }

        /// <summary>
        /// The first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The sex (M or F).
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// The date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The street address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The ZIP code.
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        public string Phone { get; set; }
    }
}