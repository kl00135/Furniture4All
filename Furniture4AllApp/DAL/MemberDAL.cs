/// <summary>
/// This file will handle Member logic and database connections.
/// 
/// Author: Laken Harville
/// Version 3/30/2026
/// </summary>

using System;
using System.Data.SqlClient;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.DAL
{
    /// <summary>
    /// This class will handle the database operations for the Member table.
    /// The methods laid out will handle member registration, retrieval, search, and update.
    /// </summary>
    public class MemberDAL
    {
        private DBHelper dbHelper = new DBHelper();

        /// <summary>
        /// This method will insert new members into the database and return an auto
        /// generated member ID.
        /// </summary>
        /// <param name="member"></param>
        /// <returns>The member ID.</returns>
        public int RegisterMember(Member member)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO Member
                    (fname, lname, sex, date_of_birth, address, city, state, zip, phone)
                    VALUES
                    (@fname, @lname, @sex, @dob, @address, @city, @state, @zip, @phone);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@fname", member.FirstName);
                cmd.Parameters.AddWithValue("@lname", member.LastName);
                cmd.Parameters.AddWithValue("@sex", member.Sex);
                cmd.Parameters.AddWithValue("@dob", member.DateOfBirth);
                cmd.Parameters.AddWithValue("@address", member.Address);
                cmd.Parameters.AddWithValue("@city", member.City);
                cmd.Parameters.AddWithValue("@state", member.State);
                cmd.Parameters.AddWithValue("@zip", member.Zip);
                cmd.Parameters.AddWithValue("@phone", member.Phone);

                int newId = Convert.ToInt32(cmd.ExecuteScalar());
                return newId;
            }
        }

        /// <summary>
        /// This method will retrieve a member by their ID
        /// </summary>
        /// <param name="memberId">The ID to search for.</param>
        /// <returns>Member object if found, null if no match.</returns>
        public Member GetMemberById(int memberId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Member WHERE member_id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", memberId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return BuildMember(reader);
                }
            }
            return null;
        }

        /// <summary>
        /// This method will retrieve a member by their phone number.
        /// </summary>
        /// <param name="phone">10-digit number to search for.</param>
        /// <returns>Member object if found, null if no match.</returns>
        public Member GetMemberByPhone(string phone)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Member WHERE phone = @phone";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@phone", phone);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return BuildMember(reader);
                }
            }
            return null;
        }

        /// <summary>
        /// This method will retrieve a member by their first and last name.
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name.</param>
        /// <returns>Member if found, null if no match.</returns>
        public Member GetMemberByName(string firstName, string lastName)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Member WHERE fname = @fname AND lname = @lname";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fname", firstName);
                cmd.Parameters.AddWithValue("@lname", lastName);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return BuildMember(reader);
                }
            }
            return null;
        }

        /// <summary>
        /// This method will update a member (if they exist) in the database.
        /// </summary>
        /// <param name="member">MemberId must be set for this. The Member object with updated data.</param>
        /// <returns>True if the updated row is accepted, otherwise is false.</returns>
        public bool UpdateMember(Member member)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE Member SET 
                    fname = @fname, 
                    lname = @lname, 
                    sex = @sex, 
                    date_of_birth = @dob, 
                    address = @address, 
                    city = @city, 
                    state = @state, 
                    zip = @zip, 
                    phone = @phone
                    WHERE member_id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", member.MemberID);
                cmd.Parameters.AddWithValue("@fname", member.FirstName);
                cmd.Parameters.AddWithValue("@lname", member.LastName);
                cmd.Parameters.AddWithValue("@sex", member.Sex);
                cmd.Parameters.AddWithValue("@dob", member.DateOfBirth);
                cmd.Parameters.AddWithValue("@address", member.Address);
                cmd.Parameters.AddWithValue("@city", member.City);
                cmd.Parameters.AddWithValue("@state", member.State);
                cmd.Parameters.AddWithValue("@zip", member.Zip);
                cmd.Parameters.AddWithValue("@phone", member.Phone);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected == 1;
            }
        }

        /// <summary>
        /// This method will build the Member object from a SqlDataReader row.
        /// The point of this is to avoid duplication from the column-to-property mapping
        /// in every method.
        /// </summary>
        /// <param name="reader">A SqlDataReader positioned on a valid row.</param>
        /// <returns>Populated Member object.</returns>
        private Member BuildMember(SqlDataReader reader)
        {
            return new Member
            {
                MemberID = (int)reader["member_id"],
                FirstName = reader["fname"].ToString(),
                LastName = reader["lname"].ToString(),
                Sex = reader["sex"].ToString(),
                DateOfBirth = (DateTime)reader["date_of_birth"],
                Address = reader["address"].ToString(),
                City = reader["city"].ToString(),
                State = reader["state"].ToString(),
                Zip = reader["zip"].ToString(),
                Phone = reader["phone"].ToString()
            };
        }
    }
}