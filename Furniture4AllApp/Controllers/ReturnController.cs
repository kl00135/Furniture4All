/// <summary>
/// This file is going to handle the business logic for return transactions.
/// It is intended to validate data, calculate fines/refunds, and be able to save via ReturnDAL.
///
/// Author: Laken Harville
/// Version: 4/27/2026
/// </summary>

using System;
using System.Collections.Generic;
using Furniture4AllApp.DAL;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Controllers
{
    /// <summary>
    /// This class will handle the validation and orchestration for the return transactions.
    /// </summary>
    public class ReturnController
    {
        private ReturnDAL returnDAL = new ReturnDAL();

        /// <summary>
        /// This mehtod retrieves all rentals currently out for a member that can still be returned.
        /// </summary>
        /// <param name="memberId">The member ID.</param>
        /// <returns>A list of active (not fully returned) rentals.</returns>
        public List<ActiveRental> GetActiveRentalsByMemberId(int memberId)
        {
            return returnDAL.GetActiveRentalsByMemberId(memberId);
        }

        /// <summary>
        /// This method is supposed to validate the return data, calculate fines/refunds based
        /// on the return date, and save the transaction IF it is valid.
        /// </summary>
        /// <param name="returnTxn">The return to save.</param>
        /// <returns>The auto-generated return_transaction_id.</returns>
        /// <exception cref="ArgumentException">Thrown when validation fails.</exception>
        public int CreateReturn(ReturnTransaction returnTxn)
        {
            if (returnTxn != null && returnTxn.LineItems != null)
            {
                foreach (ReturnLineItem item in returnTxn.LineItems)
                {
                    item.CalculateFineAndRefund(returnTxn.ReturnDate);
                }
            }

            List<string> errors = ValidateReturn(returnTxn);
            if (errors.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errors));
            }
            return returnDAL.CreateReturn(returnTxn);
        }

        /// <summary>
        /// This method retrieves all return transactions for a given member.
        /// </summary>
        /// <param name="memberId">The member ID to look up.</param>
        /// <returns>A list of ReturnTransaction objects with their line items.</returns>
        public List<ReturnTransaction> GetReturnsByMemberId(int memberId)
        {
            return returnDAL.GetReturnsByMemberId(memberId);
        }

        /// <summary>
        /// This method will run the validation on a return transaction.
        /// </summary>
        private List<string> ValidateReturn(ReturnTransaction returnTxn)
        {
            List<string> errors = new List<string>();

            if (returnTxn == null)
            {
                errors.Add("Return data is missing.");
                return errors;
            }
            if (returnTxn.MemberID <= 0)
            {
                errors.Add("A member must be selected before processing a return.");
            }
            if (returnTxn.EmployeeID <= 0)
            {
                errors.Add("No employee is assigned to this transaction.");
            }
            if (returnTxn.LineItems == null || returnTxn.LineItems.Count == 0)
            {
                errors.Add("No items selected to return. Please select at least one item.");
            }
            else
            {
                foreach (ReturnLineItem item in returnTxn.LineItems)
                {
                    if (item.Quantity <= 0)
                    {
                        errors.Add($"Quantity for {item.FurnitureName} must be at least 1.");
                    }
                }
            }
            return errors;
        }
    }
}