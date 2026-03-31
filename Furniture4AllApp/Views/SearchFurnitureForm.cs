///<summary>
/// The point of this file is to set up the design for the search furniture page.
///
/// Author: Anu Rayini
/// Version: 3/30/2026
/// </summary>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Furniture4AllApp.Controllers;
using Furniture4AllApp.Models;

namespace Furniture4AllApp
{
    /// <summary>
    /// This form will allow employees to search for furniture items
    /// by ID, category, or style and view the results in a data grid.
    /// </summary>
    public partial class SearchFurnitureForm : Form
    {
        private Employee loggedInEmployee;
        private FurnitureController furnitureController;

        /// <summary>
        /// This method initializes the form with the currently logged-in employee.
        /// </summary>
        /// <param name="employee">The employee who is currently logged in.</param>
        public SearchFurnitureForm(Employee employee)
        {
            InitializeComponent();
            this.loggedInEmployee = employee;
            this.furnitureController = new FurnitureController();
        }

        /// <summary>
        /// This method will run once when the form appears.
        /// </summary>
        private void SearchFurnitureForm_Load(object sender, EventArgs e)
        {
            string role = loggedInEmployee.IsAdmin ? "Admin" : "Employee";
            lblLoggedIn.Text = $"Logged in as: {loggedInEmployee.FirstName} {loggedInEmployee.LastName} ({role})";

            cmbSearchBy.Items.AddRange(new string[]
            {
                "Furniture ID",
                "Category",
                "Style"
            });
            cmbSearchBy.SelectedIndex = 0;

            try
            {
                List<string> categories = furnitureController.GetAllCategories();
                cmbCategory.Items.AddRange(categories.ToArray());

                List<string> styles = furnitureController.GetAllStyles();
                cmbStyle.Items.AddRange(styles.ToArray());
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Error loading categories/styles: " + ex.Message;
            }

            cmbCategory.Visible = false;
            lblCategory.Visible = false;
            cmbStyle.Visible = false;
            lblStyle.Visible = false;

            SetupDataGridView();
        }

        /// <summary>
        /// This method will configure the DataGridView columns for furniture results.
        /// </summary>
        private void SetupDataGridView()
        {
            dgvResults.Columns.Clear();
            dgvResults.AutoGenerateColumns = false;
            dgvResults.ReadOnly = true;
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FurnitureID",
                HeaderText = "ID",
                DataPropertyName = "FurnitureID",
                Width = 50
            });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name",
                Width = 130
            });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "Description",
                DataPropertyName = "Description",
                Width = 160
            });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "Category",
                DataPropertyName = "CategoryName",
                Width = 80
            });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StyleName",
                HeaderText = "Style",
                DataPropertyName = "StyleName",
                Width = 80
            });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DailyRentalRate",
                HeaderText = "Daily Rate",
                DataPropertyName = "DailyRentalRate",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Qty",
                DataPropertyName = "Quantity",
                Width = 50
            });
        }

        /// <summary>
        /// This method will handle any changes to the search by dropdown.
        /// </summary>
        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedItem == null) return;

            string selected = cmbSearchBy.SelectedItem.ToString();

            txtSearchValue.Visible = selected == "Furniture ID";
            lblSearchValue.Visible = selected == "Furniture ID";

            cmbCategory.Visible = selected == "Category";
            lblCategory.Visible = selected == "Category";

            cmbStyle.Visible = selected == "Style";
            lblStyle.Visible = selected == "Style";

            dgvResults.Rows.Clear();
            lblStatus.Text = "";
        }

        /// <summary>
        /// This method will handle the search button clicks.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            dgvResults.Rows.Clear();

            if (cmbSearchBy.SelectedItem == null) return;
            string searchType = cmbSearchBy.SelectedItem.ToString();

            try
            {
                if (searchType == "Furniture ID")
                {
                    int id;
                    if (!int.TryParse(txtSearchValue.Text.Trim(), out id))
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "Please enter a valid numeric Furniture ID.";
                        return;
                    }

                    Furniture item = furnitureController.GetFurnitureById(id);

                    if (item != null)
                    {
                        AddFurnitureToGrid(item);
                        lblStatus.ForeColor = Color.Green;
                        lblStatus.Text = $"Furniture found: {item.Name} (ID: {item.FurnitureID})";
                    }
                    else
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "No furniture found with that ID.";
                    }
                }
                else if (searchType == "Category")
                {
                    if (cmbCategory.SelectedItem == null)
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "Please select a category.";
                        return;
                    }

                    string category = cmbCategory.SelectedItem.ToString();
                    List<Furniture> results = furnitureController.GetFurnitureByCategory(category);
                    DisplayResults(results);
                }
                else
                {
                    if (cmbStyle.SelectedItem == null)
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "Please select a style.";
                        return;
                    }

                    string style = cmbStyle.SelectedItem.ToString();
                    List<Furniture> results = furnitureController.GetFurnitureByStyle(style);
                    DisplayResults(results);
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Search error: " + ex.Message;
            }
        }

        /// <summary>
        /// This method will display a list of furniture results in the grid.
        /// </summary>
        /// <param name="results">The list of furniture items to display.</param>
        private void DisplayResults(List<Furniture> results)
        {
            if (results.Count > 0)
            {
                foreach (Furniture item in results)
                {
                    AddFurnitureToGrid(item);
                }
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = $"{results.Count} furniture item(s) found.";
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "No furniture found matching the search criteria.";
            }
        }

        /// <summary>
        /// This method will add a single furniture item as a row to the DataGridView.
        /// </summary>
        /// <param name="item">The furniture item to add.</param>
        private void AddFurnitureToGrid(Furniture item)
        {
            dgvResults.Rows.Add(
                item.FurnitureID,
                item.Name,
                item.Description,
                item.CategoryName,
                item.StyleName,
                item.DailyRentalRate.ToString("C2"),
                item.Quantity
            );
        }

        /// <summary>
        /// This method will close the form and return the user back to the dashboard.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
