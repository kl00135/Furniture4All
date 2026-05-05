/// <summary>
/// This file handles database operations for admin reports.
/// Provides the "Most Popular Furniture During Dates" report which shows
/// furniture rented in 2+ transactions during a date range, with age demographics.
///
/// Author: Anu Rayini
/// Version: 5/2/2026
/// </summary>

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.DAL
{
    /// <summary>
    /// This class will handle database operations for the admin report features.
    /// </summary>
    public class ReportDAL
    {
        private DBHelper dbHelper = new DBHelper();

        /// <summary>
        /// This method retrieves the Most Popular Furniture During Dates report.
        /// Returns furniture items that were rented in at least 2 rental transactions
        /// during the date range, along with member age demographics.
        /// Sorted by rental count DESC, then by furniture id DESC.
        /// </summary>
        /// <param name="startDate">The start of the date range (inclusive).</param>
        /// <param name="endDate">The end of the date range (inclusive).</param>
        /// <returns>A list of FurnitureReportItem rows.</returns>
        public List<FurnitureReportItem> GetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            List<FurnitureReportItem> results = new List<FurnitureReportItem>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                // CTE-based query:
                // 1. FurnitureRentals: one row per (furniture x rental) with member age at rental time
                // 2. TotalTransactions: total # of distinct rental transactions in period
                // 3. FurnitureStats: per-furniture aggregates, filtered to >=2 transactions
                // Final SELECT joins everything and computes percentages.
                //
                // Age at time of rental uses DATEDIFF(YEAR) with a birthday-not-reached adjustment
                // to handle people whose birthday hasn't happened yet that year.
                string query = @"
                    WITH FurnitureRentals AS (
                        SELECT
                            rli.furniture_id,
                            rt.rental_transaction_id,
                            DATEDIFF(YEAR, m.date_of_birth, rt.rental_date) -
                                CASE
                                    WHEN DATEADD(YEAR, DATEDIFF(YEAR, m.date_of_birth, rt.rental_date), m.date_of_birth) > rt.rental_date
                                    THEN 1
                                    ELSE 0
                                END AS age_at_rental
                        FROM RentalTransaction rt
                        JOIN RentalLineItem rli ON rt.rental_transaction_id = rli.rental_transaction_id
                        JOIN Member m ON rt.member_id = m.member_id
                        WHERE rt.rental_date BETWEEN @start_date AND @end_date
                    ),
                    TotalTransactions AS (
                        SELECT COUNT(DISTINCT rental_transaction_id) AS total_count
                        FROM FurnitureRentals
                    ),
                    FurnitureStats AS (
                        SELECT
                            furniture_id,
                            COUNT(DISTINCT rental_transaction_id) AS rental_count,
                            COUNT(*) AS total_renters,
                            SUM(CASE WHEN age_at_rental BETWEEN 18 AND 29 THEN 1 ELSE 0 END) AS age_18_29_count,
                            SUM(CASE WHEN age_at_rental NOT BETWEEN 18 AND 29 THEN 1 ELSE 0 END) AS age_other_count
                        FROM FurnitureRentals
                        GROUP BY furniture_id
                        HAVING COUNT(DISTINCT rental_transaction_id) >= 2
                    )
                    SELECT
                        f.furniture_id,
                        ISNULL(c.name, '') AS category,
                        f.name AS furniture_name,
                        fs.rental_count,
                        tt.total_count,
                        CAST(fs.rental_count * 100.0 / NULLIF(tt.total_count, 0) AS DECIMAL(5,2)) AS pct_rentals,
                        CAST(fs.age_18_29_count * 100.0 / NULLIF(fs.total_renters, 0) AS DECIMAL(5,2)) AS pct_age_18_29,
                        CAST(fs.age_other_count * 100.0 / NULLIF(fs.total_renters, 0) AS DECIMAL(5,2)) AS pct_age_other
                    FROM FurnitureStats fs
                    JOIN Furniture f ON fs.furniture_id = f.furniture_id
                    LEFT JOIN Category c ON f.category_id = c.category_id
                    CROSS JOIN TotalTransactions tt
                    ORDER BY fs.rental_count DESC, f.furniture_id DESC;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start_date", startDate.Date);
                cmd.Parameters.AddWithValue("@end_date", endDate.Date);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(new FurnitureReportItem
                    {
                        FurnitureID = (int)reader["furniture_id"],
                        Category = reader["category"].ToString(),
                        Name = reader["furniture_name"].ToString(),
                        RentalCount = (int)reader["rental_count"],
                        TotalRentalCount = (int)reader["total_count"],
                        PercentRentals = reader["pct_rentals"] == DBNull.Value ? 0m : (decimal)reader["pct_rentals"],
                        PercentAge1829 = reader["pct_age_18_29"] == DBNull.Value ? 0m : (decimal)reader["pct_age_18_29"],
                        PercentAgeOther = reader["pct_age_other"] == DBNull.Value ? 0m : (decimal)reader["pct_age_other"]
                    });
                }
            }

            return results;
        }
    }
}
