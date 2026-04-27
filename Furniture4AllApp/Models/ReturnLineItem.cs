/// <summary>
/// This file is our representation of a single line item 
/// in a return transaction. Each item will reference one furniture item from a 
/// specific rental transaction being returned in a specific quantity. 
/// Here is where the user can find if they receive a refund or a fine.
///
/// Author: Laken Harville
/// Version: 4/27/2026
/// </summary>

using System;

namespace Furniture4AllApp.Models
{
    /// <summary>
    /// This class represents a single line item in a return transaction.
    /// It will map to the ReturnLineItems table in the database.
    /// </summary>
    public class ReturnLineItem
    {
        public int ReturnTransactionID { get; set; }
        public int RentalTransactionID { get; set; }
        public int FurnitureID { get; set; }
        public string FurnitureName { get; set; }
        public int Quantity { get; set; }
        public decimal DailyRate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Fine { get; set; }
        public decimal Refund { get; set; }

        /// <summary>
        /// This method will calculate the refund or fine for this line item based
        /// on the return date.
        /// </summary>
        /// <param name="returnDate">The date the return is being processed.</param>
        public void CalculateFineAndRefund(DateTime returnDate)
        {
            int daysDiff = (DueDate.Date - returnDate.Date).Days;

            if (daysDiff > 0)
            {
                Refund = DailyRate * Quantity * daysDiff;
                Fine = 0;
            }
            else if (daysDiff < 0)
            {
                Fine = DailyRate * Quantity * Math.Abs(daysDiff);
                Refund = 0;
            }
            else
            {
                Fine = 0;
                Refund = 0;
            }
        }
    }
}