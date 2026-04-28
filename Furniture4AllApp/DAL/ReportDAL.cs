/// <summary>
/// This file handles database operations for admin reports.
/// Currently supports the Most Rented Furniture report with a date range filter.
///
/// Author: Anu Rayini
/// Version: 4/27/2026
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
        /// This method will retrieve aggregated rental data for each furniture item
        /// rented within a date range. Sorted by most rented first.
        /// </summary>
        /// <param name="startDate">The start of the date range (inclusive).</param>
        /// <param name="endDate">The end of the date range (inclusive).</param>
        /// <returns>A list of FurnitureReportItem rows.</returns>
        public List<FurnitureReportItem> GetMostRentedFurniture(DateTime startDate, DateTime endDate)
        {
            List<FurnitureReportItem> results = new List<FurnitureReportItem>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT
                        f.furniture_id,
                        f.name,
                        c.name AS category_name,
                        f.daily_rental_rate,
                        SUM(rli.quantity) AS total_quantity,
                        COUNT(DISTINCT rt.rental_transaction_id) AS transaction_count,
                        SUM(rli.quantity * f.daily_rental_rate *
                            DATEDIFF(day, rt.rental_date, rt.due_date)) AS estimated_revenue
                    FROM RentalTransaction rt
                    JOIN RentalLineItem rli ON rt.rental_transaction_id = rli.rental_transaction_id
                    JOIN Furniture f ON rli.furniture_id = f.furniture_id
                    LEFT JOIN Category c ON f.category_id = c.category_id
                    WHERE rt.rental_date BETWEEN @start_date AND @end_date
                    GROUP BY f.furniture_id, f.name, c.name, f.daily_rental_rate
                    ORDER BY total_quantity DESC, f.name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start_date", startDate.Date);
                cmd.Parameters.AddWithValue("@end_date", endDate.Date);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(new FurnitureReportItem
                    {
                        FurnitureID = (int)reader["furniture_id"],
                        Name = reader["name"].ToString(),
                        Category = reader["category_name"] == DBNull.Value ? "" : reader["category_name"].ToString(),
                        DailyRate = (decimal)reader["daily_rental_rate"],
                        TotalQuantityRented = (int)reader["total_quantity"],
                        TransactionCount = (int)reader["transaction_count"],
                        EstimatedRevenue = reader["estimated_revenue"] == DBNull.Value ? 0m : (decimal)reader["estimated_revenue"]
                    });
                }
            }

            return results;
        }
    }
}
