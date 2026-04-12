///<summary>
/// This file will represent a single line item in a rental transaction.
/// Each line item will reference one furniture item with a specific quantity.
///
/// Author: Laken Harville
/// Version: 4/12/2026
/// </summary>

namespace Furniture4AllApp.Models
{
    /// <summary>
    /// This class will represent one line item in a transaction.
    /// </summary>
    public class RentalLineItem
    {
        public int RentalTransactionID { get; set; }
        public int FurnitureID { get; set; }
        public string FurnitureName { get; set; }
        public int Quantity { get; set; }
        public decimal DailyRate { get; set; }
        public int QuantityReturned { get; set; }

        /// <summary>
        /// This method will compute the subtotal which is
        /// DailyRate multiplied by Quantity.
        /// </summary>
        public decimal Subtotal => DailyRate * Quantity;
    }
}