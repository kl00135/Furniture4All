/// <summary>
/// This file will handle the database operation for rental transactions and the line items.
/// 
/// Author: Laken Harville
/// Version: 4/12/2026
/// </summary>


using System;
using System.Collections.Generic;
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
        private FurnitureDAL furnitureDAL = new FurnitureDAL();

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
                            string checkQuery = @"SELECT stock_quantity FROM Furniture WHERE furniture_id = @furniture_id";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, conn, txn);
                            checkCmd.Parameters.AddWithValue("@furniture_id", item.FurnitureID);

                            int currentStock = Convert.ToInt32(checkCmd.ExecuteScalar());

                            if(currentStock < item.Quantity)
                            {
                                throw new Exception($"Not enough stock for furniture ID {item.FurnitureID}. Available: {currentStock}, Requested: {item.Quantity}");
                            }

                            string childQuery = @"INSERT INTO RentalLineItem
                                (rental_transaction_id, furniture_id, quantity, quantity_returned)
                                VALUES (@rental_id, @furniture_id, @qty, 0)";

                            SqlCommand childCmd = new SqlCommand(childQuery, conn, txn);
                            childCmd.Parameters.AddWithValue("@rental_id", newRentalId);
                            childCmd.Parameters.AddWithValue("@furniture_id", item.FurnitureID);
                            childCmd.Parameters.AddWithValue("@qty", item.Quantity);
                            childCmd.ExecuteNonQuery();

                            string updateStockQuery = @"UPDATE Furniture
                                SET stock_quantity = stock_quantity - @qty
                                WHERE furniture_id = @furniture_id";
                            
                            SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, conn, txn);
                            updateStockCmd.Parameters.AddWithValue("@qty", item.Quantity);
                            updateStockCmd.Parameters.AddWithValue("@furniture_id", item.FurnitureID);
                            updateStockCmd.ExecuteNonQuery();
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

        /// <summary>
        /// This method will retrieve all rental transactions for a given member.
        /// Each transaction includes its line items with furniture names and daily rates.
        /// </summary>
        /// <param name="memberId">The member ID to look up.</param>
        /// <returns>A list of RentalTransaction objects with their line items.</returns>
        public List<RentalTransaction> GetRentalsByMemberId(int memberId)
        {
            List<RentalTransaction> rentals = new List<RentalTransaction>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT rt.rental_transaction_id, rt.member_id, rt.employee_id,
                        rt.rental_date, rt.due_date,
                        m.fname + ' ' + m.lname AS member_name,
                        e.fname + ' ' + e.lname AS employee_name
                    FROM RentalTransaction rt
                    JOIN Member m ON rt.member_id = m.member_id
                    JOIN Employee e ON rt.employee_id = e.employee_id
                    WHERE rt.member_id = @member_id
                    ORDER BY rt.rental_date DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@member_id", memberId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RentalTransaction rental = new RentalTransaction
                    {
                        RentalTransactionID = (int)reader["rental_transaction_id"],
                        MemberID = (int)reader["member_id"],
                        MemberName = reader["member_name"].ToString(),
                        EmployeeID = (int)reader["employee_id"],
                        EmployeeName = reader["employee_name"].ToString(),
                        RentalDate = (DateTime)reader["rental_date"],
                        DueDate = (DateTime)reader["due_date"]
                    };
                    rentals.Add(rental);
                }
                reader.Close();

                foreach (RentalTransaction rental in rentals)
                {
                    string lineQuery = @"SELECT rli.furniture_id, f.name AS furniture_name,
                            rli.quantity, rli.quantity_returned, f.daily_rental_rate
                        FROM RentalLineItem rli
                        JOIN Furniture f ON rli.furniture_id = f.furniture_id
                        WHERE rli.rental_transaction_id = @rental_id";

                    SqlCommand lineCmd = new SqlCommand(lineQuery, conn);
                    lineCmd.Parameters.AddWithValue("@rental_id", rental.RentalTransactionID);

                    SqlDataReader lineReader = lineCmd.ExecuteReader();

                    while (lineReader.Read())
                    {
                        rental.LineItems.Add(new RentalLineItem
                        {
                            RentalTransactionID = rental.RentalTransactionID,
                            FurnitureID = (int)lineReader["furniture_id"],
                            FurnitureName = lineReader["furniture_name"].ToString(),
                            Quantity = (int)lineReader["quantity"],
                            QuantityReturned = (int)lineReader["quantity_returned"],
                            DailyRate = (decimal)lineReader["daily_rental_rate"]
                        });
                    }
                    lineReader.Close();
                }
            }

            return rentals;
        }
    }
}