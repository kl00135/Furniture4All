/// <summary>
/// The intention of this file is to handle our database operations
/// for return transactions and their line items.
/// SQL transactions are used to ensure all related rows are updated atomically.
///
/// Author: Laken Harville
/// Version: 4/27/2026
/// </summary>

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.DAL
{
    /// <summary>
    /// This class will handle database operations for return transactions and their line items.
    /// </summary>
    public class ReturnDAL
    {
        private DBHelper dbHelper = new DBHelper();

        /// <summary>
        /// This method will gather all active rental items for a member.
        /// It will also join RentalTransaction, RentalLineItem, and Furniture so we
        /// can receive the whole picture in one query.
        /// </summary>
        /// <param name="memberId">The member to look up.</param>
        /// <returns>A list of active rentals available for return.</returns>
        public List<ActiveRental> GetActiveRentalsByMemberId(int memberId)
        {
            List<ActiveRental> activeRentals = new List<ActiveRental>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT 
                        rli.rental_transaction_id,
                        rli.furniture_id,
                        f.name AS furniture_name,
                        f.daily_rental_rate,
                        rli.quantity,
                        rli.quantity_returned,
                        rt.rental_date,
                        rt.due_date
                    FROM RentalLineItem rli
                    JOIN RentalTransaction rt ON rli.rental_transaction_id = rt.rental_transaction_id
                    JOIN Furniture f ON rli.furniture_id = f.furniture_id
                    WHERE rt.member_id = @member_id
                      AND rli.quantity > rli.quantity_returned
                    ORDER BY rt.rental_date DESC, rli.furniture_id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@member_id", memberId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    activeRentals.Add(new ActiveRental
                    {
                        RentalTransactionID = (int)reader["rental_transaction_id"],
                        FurnitureID = (int)reader["furniture_id"],
                        FurnitureName = reader["furniture_name"].ToString(),
                        DailyRate = (decimal)reader["daily_rental_rate"],
                        QuantityRented = (int)reader["quantity"],
                        QuantityReturned = (int)reader["quantity_returned"],
                        RentalDate = (DateTime)reader["rental_date"],
                        DueDate = (DateTime)reader["due_date"]
                    });
                }
            }

            return activeRentals;
        }

        /// <summary>
        /// This method will create a return transaction and all line itmes and updates
        /// from the RentalLineItem.quantity_returned column.
        /// </summary>
        /// <param name="returnTxn">The return transaction to save.</param>
        /// <returns>The auto-generated return_transaction_id.</returns>
        public int CreateReturn(ReturnTransaction returnTxn)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                using (SqlTransaction txn = conn.BeginTransaction())
                {
                    try
                    {
                        string parentQuery = @"INSERT INTO ReturnTransaction
                            (member_id, employee_id, return_date)
                            VALUES (@member_id, @employee_id, @return_date);
                            SELECT SCOPE_IDENTITY();";

                        SqlCommand parentCmd = new SqlCommand(parentQuery, conn, txn);
                        parentCmd.Parameters.AddWithValue("@member_id", returnTxn.MemberID);
                        parentCmd.Parameters.AddWithValue("@employee_id", returnTxn.EmployeeID);
                        parentCmd.Parameters.AddWithValue("@return_date", returnTxn.ReturnDate);

                        int newReturnId = Convert.ToInt32(parentCmd.ExecuteScalar());

                        foreach (ReturnLineItem item in returnTxn.LineItems)
                        {
                            string childQuery = @"INSERT INTO ReturnLineItem
                                (return_transaction_id, rental_transaction_id, furniture_id, quantity, fine, refund)
                                VALUES (@return_id, @rental_id, @furniture_id, @qty, @fine, @refund)";

                            SqlCommand childCmd = new SqlCommand(childQuery, conn, txn);
                            childCmd.Parameters.AddWithValue("@return_id", newReturnId);
                            childCmd.Parameters.AddWithValue("@rental_id", item.RentalTransactionID);
                            childCmd.Parameters.AddWithValue("@furniture_id", item.FurnitureID);
                            childCmd.Parameters.AddWithValue("@qty", item.Quantity);
                            childCmd.Parameters.AddWithValue("@fine", item.Fine);
                            childCmd.Parameters.AddWithValue("@refund", item.Refund);
                            childCmd.ExecuteNonQuery();

                            string updateQuery = @"UPDATE RentalLineItem
                                SET quantity_returned = quantity_returned + @qty
                                WHERE rental_transaction_id = @rental_id
                                  AND furniture_id = @furniture_id";

                            SqlCommand updateCmd = new SqlCommand(updateQuery, conn, txn);
                            updateCmd.Parameters.AddWithValue("@qty", item.Quantity);
                            updateCmd.Parameters.AddWithValue("@rental_id", item.RentalTransactionID);
                            updateCmd.Parameters.AddWithValue("@furniture_id", item.FurnitureID);
                            updateCmd.ExecuteNonQuery();

                            string restockQuery = @"UPDATE Furniture
                                SET quantity = quantity + @qty
                                WHERE furniture_id = @furniture_id";

                            SqlCommand restockCmd = new SqlCommand(restockQuery, conn, txn);
                            restockCmd.Parameters.AddWithValue("@qty", item.Quantity);
                            restockCmd.Parameters.AddWithValue("@furniture_id", item.FurnitureID);
                            restockCmd.ExecuteNonQuery();
                        }


                        txn.Commit();
                        return newReturnId;
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
        /// This method will retrieve all return transactions for a given member.
        /// Each transaction will include its line items with furniture names and rental transaction IDs.
        /// </summary>
        /// <param name="memberId">The member ID to look up.</param>
        /// <returns>A list of ReturnTransaction objects with their line items.</returns>
        public List<ReturnTransaction> GetReturnsByMemberId(int memberId)
        {
            List<ReturnTransaction> returns = new List<ReturnTransaction>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT rt.return_transaction_id, rt.member_id, rt.employee_id,
                        rt.return_date,
                        m.fname + ' ' + m.lname AS member_name,
                        e.fname + ' ' + e.lname AS employee_name
                    FROM ReturnTransaction rt
                    JOIN Member m ON rt.member_id = m.member_id
                    JOIN Employee e ON rt.employee_id = e.employee_id
                    WHERE rt.member_id = @member_id
                    ORDER BY rt.return_date DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@member_id", memberId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ReturnTransaction returnTxn = new ReturnTransaction
                    {
                        ReturnTransactionID = (int)reader["return_transaction_id"],
                        MemberID = (int)reader["member_id"],
                        MemberName = reader["member_name"].ToString(),
                        EmployeeID = (int)reader["employee_id"],
                        EmployeeName = reader["employee_name"].ToString(),
                        ReturnDate = (DateTime)reader["return_date"]
                    };
                    returns.Add(returnTxn);
                }
                reader.Close();

                foreach (ReturnTransaction returnTxn in returns)
                {
                    string lineQuery = @"SELECT rli.return_transaction_id, rli.rental_transaction_id,
                            rli.furniture_id, f.name AS furniture_name,
                            rli.quantity, rli.fine, rli.refund,
                            f.daily_rental_rate, rt.due_date
                        FROM ReturnLineItem rli
                        JOIN Furniture f ON rli.furniture_id = f.furniture_id
                        JOIN RentalTransaction rt ON rli.rental_transaction_id = rt.rental_transaction_id
                        WHERE rli.return_transaction_id = @return_id";

                    SqlCommand lineCmd = new SqlCommand(lineQuery, conn);
                    lineCmd.Parameters.AddWithValue("@return_id", returnTxn.ReturnTransactionID);

                    SqlDataReader lineReader = lineCmd.ExecuteReader();

                    while (lineReader.Read())
                    {
                        returnTxn.LineItems.Add(new ReturnLineItem
                        {
                            ReturnTransactionID = (int)lineReader["return_transaction_id"],
                            RentalTransactionID = (int)lineReader["rental_transaction_id"],
                            FurnitureID = (int)lineReader["furniture_id"],
                            FurnitureName = lineReader["furniture_name"].ToString(),
                            Quantity = (int)lineReader["quantity"],
                            Fine = (decimal)lineReader["fine"],
                            Refund = (decimal)lineReader["refund"],
                            DailyRate = (decimal)lineReader["daily_rental_rate"],
                            DueDate = (DateTime)lineReader["due_date"]
                        });
                    }
                    lineReader.Close();
                }
            }

            return returns;
        }
    }
}