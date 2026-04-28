/// <summary>
/// This is the windows design for the Most Rented Furniture user control.
///
/// Author: Anu Rayini
/// Version: 4/27/2026
/// </summary>
namespace Furniture4AllApp.Views
{
    partial class MostRentedFurnitureControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// This method will clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed. Otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Please don't modify this.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalRevenueValue = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalQtyValue = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblTotalItemsValue = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblResultsTitle = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblNoData = new System.Windows.Forms.Label();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            //
            // grpSummary
            //
            this.grpSummary.Controls.Add(this.lblTotalRevenueValue);
            this.grpSummary.Controls.Add(this.lblTotalRevenue);
            this.grpSummary.Controls.Add(this.lblTotalQtyValue);
            this.grpSummary.Controls.Add(this.lblTotalQty);
            this.grpSummary.Controls.Add(this.lblTotalItemsValue);
            this.grpSummary.Controls.Add(this.lblTotalItems);
            this.grpSummary.Location = new System.Drawing.Point(0, 0);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(745, 70);
            this.grpSummary.TabIndex = 0;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            //
            // lblTotalItems
            //
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalItems.Location = new System.Drawing.Point(15, 30);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(110, 15);
            this.lblTotalItems.TabIndex = 0;
            this.lblTotalItems.Text = "Unique Items:";
            //
            // lblTotalItemsValue
            //
            this.lblTotalItemsValue.AutoSize = true;
            this.lblTotalItemsValue.Location = new System.Drawing.Point(135, 31);
            this.lblTotalItemsValue.Name = "lblTotalItemsValue";
            this.lblTotalItemsValue.Size = new System.Drawing.Size(13, 13);
            this.lblTotalItemsValue.TabIndex = 1;
            this.lblTotalItemsValue.Text = "0";
            //
            // lblTotalQty
            //
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalQty.Location = new System.Drawing.Point(220, 30);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(110, 15);
            this.lblTotalQty.TabIndex = 2;
            this.lblTotalQty.Text = "Total Qty Rented:";
            //
            // lblTotalQtyValue
            //
            this.lblTotalQtyValue.AutoSize = true;
            this.lblTotalQtyValue.Location = new System.Drawing.Point(340, 31);
            this.lblTotalQtyValue.Name = "lblTotalQtyValue";
            this.lblTotalQtyValue.Size = new System.Drawing.Size(13, 13);
            this.lblTotalQtyValue.TabIndex = 3;
            this.lblTotalQtyValue.Text = "0";
            //
            // lblTotalRevenue
            //
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.Location = new System.Drawing.Point(440, 30);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(140, 15);
            this.lblTotalRevenue.TabIndex = 4;
            this.lblTotalRevenue.Text = "Estimated Revenue:";
            //
            // lblTotalRevenueValue
            //
            this.lblTotalRevenueValue.AutoSize = true;
            this.lblTotalRevenueValue.Location = new System.Drawing.Point(580, 31);
            this.lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            this.lblTotalRevenueValue.Size = new System.Drawing.Size(34, 13);
            this.lblTotalRevenueValue.TabIndex = 5;
            this.lblTotalRevenueValue.Text = "$0.00";
            //
            // lblResultsTitle
            //
            this.lblResultsTitle.AutoSize = true;
            this.lblResultsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultsTitle.Location = new System.Drawing.Point(0, 85);
            this.lblResultsTitle.Name = "lblResultsTitle";
            this.lblResultsTitle.Size = new System.Drawing.Size(225, 17);
            this.lblResultsTitle.TabIndex = 1;
            this.lblResultsTitle.Text = "Most Rented Furniture";
            //
            // dgvReport
            //
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(0, 110);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(745, 280);
            this.dgvReport.TabIndex = 2;
            //
            // lblNoData
            //
            this.lblNoData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblNoData.ForeColor = System.Drawing.Color.Gray;
            this.lblNoData.Location = new System.Drawing.Point(0, 220);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(745, 25);
            this.lblNoData.TabIndex = 3;
            this.lblNoData.Text = "No rental data found for the selected date range.";
            this.lblNoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoData.Visible = false;
            //
            // MostRentedFurnitureControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.lblResultsTitle);
            this.Controls.Add(this.grpSummary);
            this.Name = "MostRentedFurnitureControl";
            this.Size = new System.Drawing.Size(745, 395);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblTotalRevenueValue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalQtyValue;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblTotalItemsValue;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblResultsTitle;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblNoData;
    }
}
