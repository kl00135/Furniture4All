/// <summary>
/// This file will handle the database operation for rental transactions and the line items.
/// 
/// Author: Laken Harville
/// Version: 4/12/2026
/// </summary>


using System;
using System.Data.SqlClient;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.DAL
{
    /// <summary>
    /// This class will handle the database operations for rental transactions and their
    /// respective line items. SQL transactions implemented to make sure the parent and child rows
    /// are written atomically.
    /// </summary>
    public class RentalDAL
    {
        private DBHelper dbHelper = new DBHelper();

        /// <summary>
        /// This method will create a new rental transaction along with all of its line
        /// items. If any line items fails then everything will go back as if nothing happened.
        /// </summary>
        /// <param name="rental">The rental to save. LineItems must not be empty.</param>
        /// <returns>The auto-generated rental_transaction_id.</returns>
        public int CreateRental(RentalTransaction rental)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                using (SqlTransaction txn = conn.BeginTransaction())
                {
                    try
                    {
                        string parentQuery = @"INSERT INTO RentalTransaction
                            (member_id, employee_id, rental_date, due_date)
                            VALUES (@member_id, @employee_id, @rental_date, @due_date);
                            SELECT SCOPE_IDENTITY();";

                        SqlCommand parentCmd = new SqlCommand(parentQuery, conn, txn);
                        parentCmd.Parameters.AddWithValue("@member_id", rental.MemberID);
                        parentCmd.Parameters.AddWithValue("@employee_id", rental.EmployeeID);
                        parentCmd.Parameters.AddWithValue("@rental_date", rental.RentalDate);
                        parentCmd.Parameters.AddWithValue("@due_date", rental.DueDate);

                        int newRentalId = Convert.ToInt32(parentCmd.ExecuteScalar());

                        foreach (RentalLineItem item in rental.LineItems)
                        {
                            string childQuery = @"INSERT INTO RentalLineItem
                                (rental_transaction_id, furniture_id, quantity, quantity_returned)
                                VALUES (@rental_id, @furniture_id, @qty, 0)";

                            SqlCommand childCmd = new SqlCommand(childQuery, conn, txn);
                            childCmd.Parameters.AddWithValue("@rental_id", newRentalId);
                            childCmd.Parameters.AddWithValue("@furniture_id", item.FurnitureID);
                            childCmd.Parameters.AddWithValue("@qty", item.Quantity);
                            childCmd.ExecuteNonQuery();
                        }

                        txn.Commit();
                        return newRentalId;
                    }
                    catch
                    {
                        txn.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}