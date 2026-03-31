/// <summary>
/// This file will construct the furniture items.
///
/// Author: Anu Rayini
/// Version: 3/30/2026
/// </summary>

namespace Furniture4AllApp.Models
{
    /// <summary>
    /// This class will be the furniture item that represents a piece of furniture
    /// available for rental in the system.
    /// Furniture belongs to a category and style.
    /// </summary>
    public class Furniture
    {
        public int FurnitureID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string StyleName { get; set; }
        public decimal DailyRentalRate { get; set; }
        public int Quantity { get; set; }
    }
}
