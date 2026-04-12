/// <summary>
/// This class will represent the rental transaction. A rental will have a member,
/// an employee, a rental date, a due date, and a list of line items (one per furniture item rented).
/// 
/// Author: Laken Harville
/// Version: 4/12/2026
/// </summary>

using System;
using System.Collections.Generic;

namespace Furniture4AllApp.Models
{
    /// <summary>
    /// Represents the rental transaction made by a member and processed by employees.
    /// This will contain the parent transaction info plus a list of rental line items.
    /// </summary>
    public class RentalTransaction
    {
        public int RentalTransactionID { get; set; }
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }

        /// <summary>
        /// This is a list of items in the rental.
        /// </summary>
        public List<RentalLineItem> LineItems { get; set; } = new List<RentalLineItem>();

        /// <summary>
        /// This method will be the computed property that can sum up all
        /// daily costs across all the line items.
        /// </summary>
        public decimal TotalDailyCost
        {
            get
            {
                decimal total = 0;
                foreach (RentalLineItem item in LineItems)
                {
                    total += item.DailyRate * item.Quantity;
                }
                return total;
            }
        }
    }
}
