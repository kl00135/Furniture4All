/// <summary>
/// This file provides password hashing using SHA256.
/// Used by the login flow to hash user-entered passwords before
/// comparing with the password_hash column in the Employee table.
///
/// Author: Anu Rayini
/// Version: 4/27/2026
/// </summary>

using System.Security.Cryptography;
using System.Text;

namespace Furniture4AllApp.DAL
{
    /// <summary>
    /// This class provides static helpers for hashing passwords.
    /// </summary>
    public static class PasswordHasher
    {
        /// <summary>
        /// This method hashes the given plain-text password using SHA256
        /// and returns the result as a lowercase hex string.
        /// </summary>
        /// <param name="plainText">The plain-text password.</param>
        /// <returns>A lowercase hex SHA256 hash, or empty string if input is null.</returns>
        public static string Hash(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return "";
            }

            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
