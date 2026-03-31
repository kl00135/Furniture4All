///<summary>
/// The point of this file is to be the brain of the Furniture Search feature.
/// The logic of furniture search operations live here.
///
/// Author: Anu Rayini
/// Version: 3/30/2026
/// </summary>

using System;
using System.Collections.Generic;
using Furniture4AllApp.DAL;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Controllers
{
    /// <summary>
    /// This class handles the logic for Furniture search operations.
    /// Intermediary between the views and FurnitureDAL.
    /// </summary>
    public class FurnitureController
    {
        private FurnitureDAL furnitureDAL = new FurnitureDAL();

        /// <summary>
        /// This method will retrieve a furniture item by its ID.
        /// </summary>
        /// <param name="furnitureId">The ID to search for.</param>
        /// <returns>Furniture if found, or null.</returns>
        public Furniture GetFurnitureById(int furnitureId)
        {
            return furnitureDAL.GetFurnitureById(furnitureId);
        }

        /// <summary>
        /// This method will retrieve furniture items by category name.
        /// </summary>
        /// <param name="categoryName">The category to search for.</param>
        /// <returns>List of matching furniture items.</returns>
        public List<Furniture> GetFurnitureByCategory(string categoryName)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                throw new ArgumentException("Please select a category.");
            }

            return furnitureDAL.GetFurnitureByCategory(categoryName);
        }

        /// <summary>
        /// This method will retrieve furniture items by style name.
        /// </summary>
        /// <param name="styleName">The style to search for.</param>
        /// <returns>List of matching furniture items.</returns>
        public List<Furniture> GetFurnitureByStyle(string styleName)
        {
            if (string.IsNullOrWhiteSpace(styleName))
            {
                throw new ArgumentException("Please select a style.");
            }

            return furnitureDAL.GetFurnitureByStyle(styleName);
        }

        /// <summary>
        /// This method will retrieve all category names from the database.
        /// </summary>
        /// <returns>List of category names.</returns>
        public List<string> GetAllCategories()
        {
            return furnitureDAL.GetAllCategories();
        }

        /// <summary>
        /// This method will retrieve all style names from the database.
        /// </summary>
        /// <returns>List of style names.</returns>
        public List<string> GetAllStyles()
        {
            return furnitureDAL.GetAllStyles();
        }
    }
}
