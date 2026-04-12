/// <summary>
/// This file will handle all of our business logic for rental transactions. Rental data
/// will be validated and saves will occur via RentalDAL
/// 
/// Author: Laken Harville
/// Version: 4/12/2026
/// </summary>

using System;
using System.Collections.Generic;
using Furniture4AllApp.DAL;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Controllers
{
    /// <summary>
    /// This class will handle the validation and use for rental transaction operations.
    /// This class is the intermediary between the RentalForm and RentalDAL.
    /// </summary>
    public class RentalController
    {
        private RentalDAL rentalDAL = new RentalDAL();

        /// <summary>
        /// This method will validate the rental data and create the transaction if it is valid.
        /// </summary>
        /// <param name="rental">The rental transaction to save.</param>
        /// <returns>The auto-generated rental_transaction_id.</returns>
        /// <exception cref="ArgumentException">Thrown when validation fails.</exception>
        public int CreateRental(RentalTransaction rental)
        {
            List<string> errors = ValidateRental(rental);
            if (errors.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errors));
            }
            return rentalDAL.CreateRental(rental);
        }

        /// <summary>
        /// This method will run all the validation checks on the rental transaction.
        /// It will return a list of error messages. An empty list means success.
        /// </summary>
        /// <param name="rental">The rental transaction to validate.</param>
        /// <returns>The list of error messages.</returns>
        private List<string> ValidateRental(RentalTransaction rental)
        {
            List<string> errors = new List<string>();

            if (rental == null)
            {
                errors.Add("Rental data is missing.");
                return errors;
            }
            if (rental.MemberID <= 0)
            {
                errors.Add("A member must be selected before submitting.");
            }
            if (rental.EmployeeID <= 0)
            {
                errors.Add("No employee is assigned to this transaction.");
            }
            if (rental.LineItems == null || rental.LineItems.Count == 0)
            {
                errors.Add("The cart cannot be empty. Please add at least one item.");
            }
            else
            {
                foreach (RentalLineItem item in rental.LineItems)
                {
                    if (item.Quantity <= 0)
                    {
                        errors.Add($"Quantity for {item.FurnitureName} must be at least 1.");
                    }
                }
            }
            if (rental.DueDate.Date <= rental.RentalDate.Date)
            {
                errors.Add("Due date must be after the rental date.");
            }
            return errors;
        }
    }
}