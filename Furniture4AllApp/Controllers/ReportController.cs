/// <summary>
/// This file handles the business logic for admin reports.
/// It validates input and delegates to ReportDAL for data retrieval.
///
/// Author: Anu Rayini
/// Version: 4/27/2026
/// </summary>

using System;
using System.Collections.Generic;
using Furniture4AllApp.DAL;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Controllers
{
    /// <summary>
    /// This class handles validation and orchestration for admin report queries.
    /// </summary>
    public class ReportController
    {
        private ReportDAL reportDAL = new ReportDAL();

        /// <summary>
        /// This method will validate the date range and retrieve the most rented furniture report.
        /// </summary>
        /// <param name="startDate">The start of the date range.</param>
        /// <param name="endDate">The end of the date range.</param>
        /// <returns>A list of FurnitureReportItem rows.</returns>
        /// <exception cref="ArgumentException">Thrown if the date range is invalid.</exception>
        public List<FurnitureReportItem> GetMostRentedFurniture(DateTime startDate, DateTime endDate)
        {
            if (endDate.Date < startDate.Date)
            {
                throw new ArgumentException("End date must be on or after start date.");
            }

            return reportDAL.GetMostRentedFurniture(startDate, endDate);
        }
    }
}
