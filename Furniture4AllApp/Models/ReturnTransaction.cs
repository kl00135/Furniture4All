/// <summary>
/// The point of this file is for us to have a representation of the return transaction.
/// A return will have a member, employee, return date, and a list of line items that 
/// are being returned.
///
/// Author: Laken Harville
/// Version: 4/27/2026
/// </summary>

using System;
using System.Collections.Generic;

namespace Furniture4AllApp.Models
{
    /// <summary>
    /// This class represents a return transaction, which includes details about the member, employee, return date, and line items involved in the return. 
    /// It also computes total fines and refunds based on the line items.
    /// </summary>
    public class ReturnTransaction
    {
        public int ReturnTransactionID { get; set; }
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime ReturnDate { get; set; }

        /// <summary>
        /// Line items in this return. Initialized empty so callers can just .Add().
        /// </summary>
        public List<ReturnLineItem> LineItems { get; set; } = new List<ReturnLineItem>();

        /// <summary>
        /// This method will be the total of all fines across line items.
        /// It should compute on demand so changes are synced.
        /// </summary>
        public decimal TotalFine
        {
            get
            {
                decimal total = 0;
                foreach (ReturnLineItem item in LineItems)
                {
                    total += item.Fine;
                }
                return total;
            }
        }

        /// <summary>
        /// Total of all refunds across the line items.
        /// </summary>
        public decimal TotalRefund
        {
            get
            {
                decimal total = 0;
                foreach (ReturnLineItem item in LineItems)
                {
                    total += item.Refund;
                }
                return total;
            }
        }

        /// <summary>
        /// Net amount: positive = customer owes, negative = customer is refunded.
        /// </summary>
        public decimal NetAmount => TotalFine - TotalRefund;
    }
}