/// <summary>
/// This is the windows design for the return history form.
///
/// Author: Anu Rayini
/// Version: 4/27/2026
/// </summary>
namespace Furniture4AllApp
{
    partial class ReturnHistoryForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Please don't modify this.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.lblTransactionsTitle = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.lblLineItemsTitle = new System.Windows.Forms.Label();
            this.dgvLineItems = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineItems)).BeginInit();
            this.SuspendLayout();
            //
            // lblAppTitle
            //
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.Location = new System.Drawing.Point(12, 12);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(325, 17);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Furniture4All - Furniture Rental System";
            //
            // lblLoggedIn
            //
            this.lblLoggedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoggedIn.Location = new System.Drawing.Point(390, 14);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(280, 17);
            this.lblLoggedIn.TabIndex = 1;
            this.lblLoggedIn.Text = "Logged in as:";
            this.lblLoggedIn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Return History";
            //
            // grpSearch
            //
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtMemberID);
            this.grpSearch.Controls.Add(this.lblMemberID);
            this.grpSearch.Controls.Add(this.lblMemberInfo);
            this.grpSearch.Location = new System.Drawing.Point(15, 80);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(655, 70);
            this.grpSearch.TabIndex = 3;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Look Up Member";
            //
            // lblMemberID
            //
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(15, 30);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "Member ID:";
            //
            // txtMemberID
            //
            this.txtMemberID.Location = new System.Drawing.Point(85, 27);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(120, 20);
            this.txtMemberID.TabIndex = 1;
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(215, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // lblMemberInfo
            //
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.Location = new System.Drawing.Point(290, 30);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(0, 13);
            this.lblMemberInfo.TabIndex = 3;
            //
            // lblTransactionsTitle
            //
            this.lblTransactionsTitle.AutoSize = true;
            this.lblTransactionsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTransactionsTitle.Location = new System.Drawing.Point(15, 165);
            this.lblTransactionsTitle.Name = "lblTransactionsTitle";
            this.lblTransactionsTitle.Size = new System.Drawing.Size(160, 17);
            this.lblTransactionsTitle.TabIndex = 4;
            this.lblTransactionsTitle.Text = "Return Transactions";
            //
            // dgvTransactions
            //
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(15, 190);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(655, 160);
            this.dgvTransactions.TabIndex = 5;
            //
            // lblLineItemsTitle
            //
            this.lblLineItemsTitle.AutoSize = true;
            this.lblLineItemsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblLineItemsTitle.Location = new System.Drawing.Point(15, 365);
            this.lblLineItemsTitle.Name = "lblLineItemsTitle";
            this.lblLineItemsTitle.Size = new System.Drawing.Size(207, 17);
            this.lblLineItemsTitle.TabIndex = 6;
            this.lblLineItemsTitle.Text = "Line Items for Selected Return";
            //
            // dgvLineItems
            //
            this.dgvLineItems.AllowUserToAddRows = false;
            this.dgvLineItems.AllowUserToDeleteRows = false;
            this.dgvLineItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineItems.Location = new System.Drawing.Point(15, 390);
            this.dgvLineItems.Name = "dgvLineItems";
            this.dgvLineItems.ReadOnly = true;
            this.dgvLineItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLineItems.Size = new System.Drawing.Size(655, 150);
            this.dgvLineItems.TabIndex = 7;
            //
            // btnBack
            //
            this.btnBack.Location = new System.Drawing.Point(15, 560);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 30);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //
            // lblStatus
            //
            this.lblStatus.Location = new System.Drawing.Point(110, 567);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(560, 20);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "";
            //
            // ReturnHistoryForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 601);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvLineItems);
            this.Controls.Add(this.lblLineItemsTitle);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.lblTransactionsTitle);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.lblAppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReturnHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furniture4All - Return History";
            this.Load += new System.EventHandler(this.ReturnHistoryForm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.Label lblTransactionsTitle;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label lblLineItemsTitle;
        private System.Windows.Forms.DataGridView dgvLineItems;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStatus;
    }
}
