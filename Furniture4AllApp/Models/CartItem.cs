/// <summary>
/// Represents an item in the shopping cart.
/// 
/// Author: Kade Levy
/// Version: 4/11/2026
/// Modified by Laken Harville: I changed the visibility from internal to public for consistency.
/// Version: 4/12/2026
/// </summary>

namespace Furniture4AllApp.Models
{
    /// <summary>
    /// Represents an item in the shopping cart.
    /// </summary>
    public class CartItem
    {
        public int FurnitureId { get; set; }
        public string Name { get; set; }
        public decimal DailyRate { get; set; }
        public int Quantity { get; set; }

        public decimal Subtotal => DailyRate * Quantity;
    }
}
