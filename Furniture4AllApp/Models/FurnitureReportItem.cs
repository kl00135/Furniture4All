/// <summary>
/// This file represents a single row in the Most Rented Furniture report.
/// Each row contains aggregate rental info for one furniture item over a date range.
///
/// Author: Anu Rayini
/// Version: 4/27/2026
/// </summary>

namespace Furniture4AllApp.Models
{
    /// <summary>
    /// This class represents one furniture item's aggregated rental statistics
    /// over a given date range. Used by the admin report.
    /// </summary>
    public class FurnitureReportItem
    {
        /// <summary>
        /// The furniture ID.
        /// </summary>
        public int FurnitureID { get; set; }

        /// <summary>
        /// The furniture name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The category of the furniture.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The total quantity of this item rented in the date range.
        /// </summary>
        public int TotalQuantityRented { get; set; }

        /// <summary>
        /// The number of distinct rental transactions that included this item.
        /// </summary>
        public int TransactionCount { get; set; }

        /// <summary>
        /// The daily rental rate for this furniture.
        /// </summary>
        public decimal DailyRate { get; set; }

        /// <summary>
        /// Estimated total revenue for this item over the date range
        /// (quantity * daily rate * rental days).
        /// </summary>
        public decimal EstimatedRevenue { get; set; }
    }
}
