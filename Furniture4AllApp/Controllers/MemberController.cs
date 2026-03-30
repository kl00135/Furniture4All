///<summary>
/// The point of this file is to be the brain of the Member feature.
/// The logic of member variables live here and builds the constraints needed for rules.
/// 
/// Author: Laken Harville
/// 3/30/2026
/// </summary>

using System;
using System.Collections.Generic;
using Furniture4AllApp.DAL;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Controllers
{
    /// <summary>
    /// This class handles the logic and validation for Member operations.
    /// Intermediary between the views and MemberDAL.
    /// </summary>
    public class MemberController
    {
        private MemberDAL memberDAL = new MemberDAL();

        /// <summary>
        /// This method will validate member data and register a new member if valid.
        /// </summary>
        /// <param name="member">Member object to register.</param>
        /// <returns>Member's new auto-generated ID.</returns>
        /// <exception cref="ArgumentException">Thrown when validation fails followed by an error message.</exception>
        public int RegisterMember(Member member)
        {
            List<string> errors = ValidateMember(member);

            if (errors.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errors));
            }

            return memberDAL.RegisterMember(member);
        }

        /// <summary>
        /// This method will validate the member data and update
        /// the member if valid.
        /// </summary>
        /// <param name="member">Member object with updated data.</param>
        /// <returns>True if updated succeeded.</returns>
        /// <exception cref="ArgumentException">Thrown when validation fails.</exception>
        public bool UpdateMember(Member member)
        {
            List<string> errors = ValidateMember(member);

            if (errors.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errors));
            }

            return memberDAL.UpdateMember(member);
        }

        /// <summary>
        /// This method will retrieve the member by their ID.
        /// </summary>
        /// <param name="memberId">The ID to search for.</param>
        /// <returns>Member if found, or null.</returns>
        public Member GetMemberById(int memberId)
        {
            return memberDAL.GetMemberById(memberId);
        }

        /// <summary>
        /// This method will retrieve the member by their phone number.
        /// </summary>
        /// <param name="phone">The 10-digit phone number.</param>
        /// <returns>Member if found, or null.</returns>
        public Member GetMemberByPhone(string phone)
        {
            return memberDAL.GetMemberByPhone(phone);
        }

        /// <summary>
        /// This method will retrieve a member by their first and last name.
        /// </summary>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName">Last name.</param>
        /// <returns>Member if found, or null.</returns>
        public Member GetMemberByName(string firstName, string lastName)
        {
            return memberDAL.GetMemberByName(firstName, lastName);
        }

        /// <summary>
        /// The whole point of this method is to validate all fields of the member
        /// object. 
        /// Returns a list of error messages or blank if no errors exist.
        /// </summary>
        /// <param name="member">The member to validate.</param>
        /// <returns>A list of error strings.</returns>
        private List<string> ValidateMember(Member member)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(member.FirstName))
            {
                errors.Add("First name is required.");
            }

            if (string.IsNullOrWhiteSpace(member.LastName))
            {
                errors.Add("Last name is required.");
            }

            if (string.IsNullOrWhiteSpace(member.Sex))
            {
                errors.Add("Please select a sex.");
            }

            if (member.DateOfBirth == DateTime.MinValue)
            {
                errors.Add("Date of birth is required.");
            }
            else if (member.DateOfBirth >= DateTime.Today)
            {
                errors.Add("Date of birth must be in the past.");
            }

            if (string.IsNullOrWhiteSpace(member.Address))
            {
                errors.Add("Address is required.");
            }

            if (string.IsNullOrWhiteSpace(member.City))
            {
                errors.Add("City is required.");
            }

            if (string.IsNullOrWhiteSpace(member.State))
            {
                errors.Add("Please select a state.");
            }

            if (string.IsNullOrWhiteSpace(member.Zip))
            {
                errors.Add("ZIP code is required.");
            }

            if (string.IsNullOrWhiteSpace(member.Phone))
            {
                errors.Add("Phone number is required.");
            }
            else if (member.Phone.Length != 10 || !IsAllDigits(member.Phone))
            {
                errors.Add("Phone number must be exactly 10 digits.");
            }

            return errors;
        }

        private bool IsAllDigits(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}