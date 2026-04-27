/// <summary>
/// This file is a representation of an active rental line item.
/// This will be used in the Return Furniture form to show us what a member
/// currently is renting.
///
/// Author: Laken Harville
/// Version: 4/27/2026
/// </summary>

using System;

namespace Furniture4AllApp.Models
{
    /// <summary>
    /// This class is a representation of an item that is currently rented by a member.
    /// The item has yet to be returned.
    /// </summary>
    public class ActiveRental
    {
        public int RentalTransactionID { get; set; }
        public int FurnitureID { get; set; }
        public string FurnitureName { get; set; }
        public decimal DailyRate { get; set; }
        public int QuantityRented { get; set; }
        public int QuantityReturned { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }

        /// <summary>
        /// How many of this item are still out and available to return.
        /// </summary>
        public int QuantityRemaining => QuantityRented - QuantityReturned;
    }
}