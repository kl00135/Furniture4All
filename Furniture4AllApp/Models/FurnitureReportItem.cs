/// <summary>
/// This file represents a single row in the Most Popular Furniture During Dates report.
/// Each row contains aggregate rental info for one furniture item over a date range,
/// including age demographics for the members who rented it.
///
/// Author: Anu Rayini
/// Version: 5/2/2026
/// </summary>

namespace Furniture4AllApp.Models
{
    /// <summary>
    /// This class represents one furniture item's aggregated rental statistics
    /// for the admin "Most Popular Furniture During Dates" report.
    /// </summary>
    public class FurnitureReportItem
    {
        /// <summary>
        /// The furniture ID.
        /// </summary>
        public int FurnitureID { get; set; }

        /// <summary>
        /// The category name (e.g. Chair, Table, Sofa).
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The furniture name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The number of rental transactions in which this furniture was rented during the period.
        /// </summary>
        public int RentalCount { get; set; }

        /// <summary>
        /// The total number of all furniture rental transactions during the period.
        /// Same value across all rows in the report.
        /// </summary>
        public int TotalRentalCount { get; set; }

        /// <summary>
        /// The percentage of RentalCount over TotalRentalCount.
        /// </summary>
        public decimal PercentRentals { get; set; }

        /// <summary>
        /// The percentage of members aged 18-29 (at the time of rental) who rented this item,
        /// among all members who rented this item during the period.
        /// </summary>
        public decimal PercentAge1829 { get; set; }

        /// <summary>
        /// The percentage of members outside the 18-29 age range (at the time of rental)
        /// who rented this item, among all members who rented this item during the period.
        /// </summary>
        public decimal PercentAgeOther { get; set; }
    }
}
