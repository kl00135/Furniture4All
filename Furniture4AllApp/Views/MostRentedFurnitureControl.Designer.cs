/// <summary>
/// This is the windows design for the Most Popular Furniture user control.
///
/// Author: Anu Rayini
/// Version: 5/2/2026
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
            this.lblQualifiedItemsValue = new System.Windows.Forms.Label();
            this.lblQualifiedItems = new System.Windows.Forms.Label();
            this.lblTotalTransValue = new System.Windows.Forms.Label();
            this.lblTotalTrans = new System.Windows.Forms.Label();
            this.lblDateRangeValue = new System.Windows.Forms.Label();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.lblResultsTitle = new System.Windows.Forms.Label();
            this.lblResultsSubtitle = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblNoData = new System.Windows.Forms.Label();
            this.lblColumnDescriptions = new System.Windows.Forms.Label();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            //
            // grpSummary
            //
            this.grpSummary.Controls.Add(this.lblQualifiedItemsValue);
            this.grpSummary.Controls.Add(this.lblQualifiedItems);
            this.grpSummary.Controls.Add(this.lblTotalTransValue);
            this.grpSummary.Controls.Add(this.lblTotalTrans);
            this.grpSummary.Controls.Add(this.lblDateRangeValue);
            this.grpSummary.Controls.Add(this.lblDateRange);
            this.grpSummary.Location = new System.Drawing.Point(0, 0);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(745, 70);
            this.grpSummary.TabIndex = 0;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            //
            // lblDateRange
            //
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateRange.Location = new System.Drawing.Point(15, 30);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(95, 15);
            this.lblDateRange.TabIndex = 0;
            this.lblDateRange.Text = "Date Range:";
            //
            // lblDateRangeValue
            //
            this.lblDateRangeValue.AutoSize = true;
            this.lblDateRangeValue.Location = new System.Drawing.Point(115, 31);
            this.lblDateRangeValue.Name = "lblDateRangeValue";
            this.lblDateRangeValue.Size = new System.Drawing.Size(13, 13);
            this.lblDateRangeValue.TabIndex = 1;
            this.lblDateRangeValue.Text = "-";
            //
            // lblTotalTrans
            //
            this.lblTotalTrans.AutoSize = true;
            this.lblTotalTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalTrans.Location = new System.Drawing.Point(295, 30);
            this.lblTotalTrans.Name = "lblTotalTrans";
            this.lblTotalTrans.Size = new System.Drawing.Size(135, 15);
            this.lblTotalTrans.TabIndex = 2;
            this.lblTotalTrans.Text = "Total Transactions:";
            //
            // lblTotalTransValue
            //
            this.lblTotalTransValue.AutoSize = true;
            this.lblTotalTransValue.Location = new System.Drawing.Point(430, 31);
            this.lblTotalTransValue.Name = "lblTotalTransValue";
            this.lblTotalTransValue.Size = new System.Drawing.Size(13, 13);
            this.lblTotalTransValue.TabIndex = 3;
            this.lblTotalTransValue.Text = "0";
            //
            // lblQualifiedItems
            //
            this.lblQualifiedItems.AutoSize = true;
            this.lblQualifiedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblQualifiedItems.Location = new System.Drawing.Point(490, 30);
            this.lblQualifiedItems.Name = "lblQualifiedItems";
            this.lblQualifiedItems.Size = new System.Drawing.Size(125, 15);
            this.lblQualifiedItems.TabIndex = 4;
            this.lblQualifiedItems.Text = "Qualified Items:";
            //
            // lblQualifiedItemsValue
            //
            this.lblQualifiedItemsValue.AutoSize = true;
            this.lblQualifiedItemsValue.Location = new System.Drawing.Point(615, 31);
            this.lblQualifiedItemsValue.Name = "lblQualifiedItemsValue";
            this.lblQualifiedItemsValue.Size = new System.Drawing.Size(13, 13);
            this.lblQualifiedItemsValue.TabIndex = 5;
            this.lblQualifiedItemsValue.Text = "0";
            //
            // lblResultsTitle
            //
            this.lblResultsTitle.AutoSize = true;
            this.lblResultsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultsTitle.Location = new System.Drawing.Point(0, 85);
            this.lblResultsTitle.Name = "lblResultsTitle";
            this.lblResultsTitle.Size = new System.Drawing.Size(295, 17);
            this.lblResultsTitle.TabIndex = 1;
            this.lblResultsTitle.Text = "Results (rented in 2+ transactions):";
            //
            // lblResultsSubtitle
            //
            this.lblResultsSubtitle.AutoSize = true;
            this.lblResultsSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblResultsSubtitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblResultsSubtitle.Location = new System.Drawing.Point(0, 105);
            this.lblResultsSubtitle.Name = "lblResultsSubtitle";
            this.lblResultsSubtitle.Size = new System.Drawing.Size(285, 13);
            this.lblResultsSubtitle.TabIndex = 6;
            this.lblResultsSubtitle.Text = "Sorted by most rented to least; ties broken by ID descending";
            //
            // dgvReport
            //
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(0, 125);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(745, 200);
            this.dgvReport.TabIndex = 2;
            //
            // lblNoData
            //
            this.lblNoData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblNoData.ForeColor = System.Drawing.Color.Gray;
            this.lblNoData.Location = new System.Drawing.Point(0, 215);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(745, 25);
            this.lblNoData.TabIndex = 3;
            this.lblNoData.Text = "No furniture was rented in 2+ transactions during this period.";
            this.lblNoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoData.Visible = false;
            //
            // lblColumnDescriptions
            //
            this.lblColumnDescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblColumnDescriptions.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblColumnDescriptions.Location = new System.Drawing.Point(0, 335);
            this.lblColumnDescriptions.Name = "lblColumnDescriptions";
            this.lblColumnDescriptions.Size = new System.Drawing.Size(745, 60);
            this.lblColumnDescriptions.TabIndex = 4;
            this.lblColumnDescriptions.Text = "# Rentals = number of rental transactions containing this furniture during the period\r\n" +
                "% Rentals = (# Rentals / Total Transactions) x 100\r\n" +
                "% Age 18-29 = percentage of renters aged 18-29 (at time of rental) among all renters of this item\r\n" +
                "% Other = percentage of renters outside 18-29 age range";
            //
            // MostRentedFurnitureControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblColumnDescriptions);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.lblResultsSubtitle);
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
        private System.Windows.Forms.Label lblQualifiedItemsValue;
        private System.Windows.Forms.Label lblQualifiedItems;
        private System.Windows.Forms.Label lblTotalTransValue;
        private System.Windows.Forms.Label lblTotalTrans;
        private System.Windows.Forms.Label lblDateRangeValue;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.Label lblResultsTitle;
        private System.Windows.Forms.Label lblResultsSubtitle;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.Label lblColumnDescriptions;
    }
}
