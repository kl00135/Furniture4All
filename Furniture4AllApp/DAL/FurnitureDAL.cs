/// <summary>
/// This file will handle Furniture logic and database connections.
///
/// Author: Anu Rayini
/// Version: 3/30/2026
/// </summary>

using System.Collections.Generic;
using System.Data.SqlClient;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.DAL
{
    /// <summary>
    /// This class will handle the database operations for the Furniture table.
    /// The methods laid out will handle furniture retrieval and search.
    /// </summary>
    public class FurnitureDAL
    {
        private DBHelper dbHelper = new DBHelper();

        /// <summary>
        /// This method will retrieve a furniture item by its ID.
        /// </summary>
        /// <param name="furnitureId">The ID to search for.</param>
        /// <returns>Furniture object if found, null if no match.</returns>
        public Furniture GetFurnitureById(int furnitureId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT f.furniture_id, f.name, f.description,
                    c.name AS category_name, s.name AS style_name,
                    f.daily_rental_rate, f.quantity
                    FROM Furniture f
                    INNER JOIN Category c ON f.category_id = c.category_id
                    INNER JOIN Style s ON f.style_id = s.style_id
                    WHERE f.furniture_id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", furnitureId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return BuildFurniture(reader);
                }
            }
            return null;
        }

        /// <summary>
        /// This method will retrieve furniture items by category name.
        /// </summary>
        /// <param name="categoryName">The category to search for.</param>
        /// <returns>List of matching furniture items.</returns>
        public List<Furniture> GetFurnitureByCategory(string categoryName)
        {
            List<Furniture> results = new List<Furniture>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT f.furniture_id, f.name, f.description,
                    c.name AS category_name, s.name AS style_name,
                    f.daily_rental_rate, f.quantity
                    FROM Furniture f
                    INNER JOIN Category c ON f.category_id = c.category_id
                    INNER JOIN Style s ON f.style_id = s.style_id
                    WHERE c.name = @category";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@category", categoryName);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    results.Add(BuildFurniture(reader));
                }
            }
            return results;
        }

        /// <summary>
        /// This method will retrieve furniture items by style name.
        /// </summary>
        /// <param name="styleName">The style to search for.</param>
        /// <returns>List of matching furniture items.</returns>
        public List<Furniture> GetFurnitureByStyle(string styleName)
        {
            List<Furniture> results = new List<Furniture>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT f.furniture_id, f.name, f.description,
                    c.name AS category_name, s.name AS style_name,
                    f.daily_rental_rate, f.quantity
                    FROM Furniture f
                    INNER JOIN Category c ON f.category_id = c.category_id
                    INNER JOIN Style s ON f.style_id = s.style_id
                    WHERE s.name = @style";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@style", styleName);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    results.Add(BuildFurniture(reader));
                }
            }
            return results;
        }

        /// <summary>
        /// This method will retrieve all categories from the database.
        /// </summary>
        /// <returns>List of category names.</returns>
        public List<string> GetAllCategories()
        {
            List<string> categories = new List<string>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT name FROM Category ORDER BY name";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add(reader["name"].ToString());
                }
            }
            return categories;
        }

        /// <summary>
        /// This method will retrieve all styles from the database.
        /// </summary>
        /// <returns>List of style names.</returns>
        public List<string> GetAllStyles()
        {
            List<string> styles = new List<string>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT name FROM Style ORDER BY name";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    styles.Add(reader["name"].ToString());
                }
            }
            return styles;
        }

        /// <summary>
        /// This method will build the Furniture object from a SqlDataReader row.
        /// The point of this is to avoid duplication from the column-to-property mapping
        /// in every method.
        /// </summary>
        /// <param name="reader">A SqlDataReader positioned on a valid row.</param>
        /// <returns>Populated Furniture object.</returns>
        private Furniture BuildFurniture(SqlDataReader reader)
        {
            return new Furniture
            {
                FurnitureID = (int)reader["furniture_id"],
                Name = reader["name"].ToString(),
                Description = reader["description"].ToString(),
                CategoryName = reader["category_name"].ToString(),
                StyleName = reader["style_name"].ToString(),
                DailyRentalRate = (decimal)reader["daily_rental_rate"],
                Quantity = (int)reader["quantity"]
            };
        }
    }
}
