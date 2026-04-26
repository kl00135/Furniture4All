/// <summary>
/// Designer view of the rental form.
/// 
/// Author: Kade Levy
/// Version: 4/13/2026
/// </summary>
namespace Furniture4AllApp.Views
{
    partial class RentalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.btnLookupMember = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberIdLabel = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnAddFurniture = new System.Windows.Forms.Button();
            this.gbCart = new System.Windows.Forms.GroupBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.totalLabel = new System.Windows.Forms.Label();
            this.rentalDueLabel = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDailyTotal = new System.Windows.Forms.Label();
            this.totalDailyLabel = new System.Windows.Forms.Label();
            this.gbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.gbCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.Location = new System.Drawing.Point(12, 9);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(292, 17);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Furniture4All - Furniture Rental System";
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoggedIn.Location = new System.Drawing.Point(310, 9);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(255, 17);
            this.lblLoggedIn.TabIndex = 1;
            this.lblLoggedIn.Text = "Logged in as:";
            this.lblLoggedIn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Rent Furniture";
            // 
            // gbMember
            // 
            this.gbMember.Controls.Add(this.lblMemberInfo);
            this.gbMember.Controls.Add(this.btnLookupMember);
            this.gbMember.Controls.Add(this.txtMemberID);
            this.gbMember.Controls.Add(this.lblMemberIdLabel);
            this.gbMember.Location = new System.Drawing.Point(15, 70);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(555, 90);
            this.gbMember.TabIndex = 3;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "Member Lookup";
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMemberInfo.Location = new System.Drawing.Point(15, 60);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(0, 15);
            this.lblMemberInfo.TabIndex = 3;
            // 
            // btnLookupMember
            // 
            this.btnLookupMember.Location = new System.Drawing.Point(220, 22);
            this.btnLookupMember.Name = "btnLookupMember";
            this.btnLookupMember.Size = new System.Drawing.Size(75, 27);
            this.btnLookupMember.TabIndex = 2;
            this.btnLookupMember.Text = "Lookup";
            this.btnLookupMember.UseVisualStyleBackColor = true;
            this.btnLookupMember.Click += new System.EventHandler(this.btnLookupMember_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(85, 25);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(120, 20);
            this.txtMemberID.TabIndex = 1;
            // 
            // lblMemberIdLabel
            // 
            this.lblMemberIdLabel.AutoSize = true;
            this.lblMemberIdLabel.Location = new System.Drawing.Point(15, 28);
            this.lblMemberIdLabel.Name = "lblMemberIdLabel";
            this.lblMemberIdLabel.Size = new System.Drawing.Size(62, 13);
            this.lblMemberIdLabel.TabIndex = 0;
            this.lblMemberIdLabel.Text = "Member ID:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmployee.Location = new System.Drawing.Point(15, 170);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(74, 15);
            this.lblEmployee.TabIndex = 4;
            this.lblEmployee.Text = "Employee:";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCart.Location = new System.Drawing.Point(11, 195);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(114, 24);
            this.lblCart.TabIndex = 5;
            this.lblCart.Text = "Cart Items: ";
            // 
            // dgvCart
            // 
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(15, 222);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(555, 150);
            this.dgvCart.TabIndex = 6;
            // 
            // btnAddFurniture
            // 
            this.btnAddFurniture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddFurniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddFurniture.ForeColor = System.Drawing.Color.White;
            this.btnAddFurniture.Location = new System.Drawing.Point(15, 380);
            this.btnAddFurniture.Name = "btnAddFurniture";
            this.btnAddFurniture.Size = new System.Drawing.Size(150, 32);
            this.btnAddFurniture.TabIndex = 7;
            this.btnAddFurniture.Text = "Add Furniture...";
            this.btnAddFurniture.UseVisualStyleBackColor = false;
            this.btnAddFurniture.Click += new System.EventHandler(this.btnAddFurniture_Click);
            // 
            // gbCart
            // 
            this.gbCart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCart.Controls.Add(this.lblDailyTotal);
            this.gbCart.Controls.Add(this.totalDailyLabel);
            this.gbCart.Controls.Add(this.lblTotalCost);
            this.gbCart.Controls.Add(this.dtpDueDate);
            this.gbCart.Controls.Add(this.totalLabel);
            this.gbCart.Controls.Add(this.rentalDueLabel);
            this.gbCart.Location = new System.Drawing.Point(15, 425);
            this.gbCart.Name = "gbCart";
            this.gbCart.Size = new System.Drawing.Size(555, 136);
            this.gbCart.TabIndex = 8;
            this.gbCart.TabStop = false;
            this.gbCart.Text = "Order Summary";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalCost.Location = new System.Drawing.Point(181, 98);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(54, 20);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "$0.00";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(170, 27);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(150, 20);
            this.dtpDueDate.TabIndex = 1;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.totalLabel.Location = new System.Drawing.Point(16, 98);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(101, 20);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total Cost: ";
            // 
            // rentalDueLabel
            // 
            this.rentalDueLabel.AutoSize = true;
            this.rentalDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rentalDueLabel.Location = new System.Drawing.Point(15, 25);
            this.rentalDueLabel.Name = "rentalDueLabel";
            this.rentalDueLabel.Size = new System.Drawing.Size(149, 20);
            this.rentalDueLabel.TabIndex = 0;
            this.rentalDueLabel.Text = "Rental Due Date:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(128, 567);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 45);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit Rental";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(313, 567);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 45);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(15, 615);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(555, 35);
            this.lblStatus.TabIndex = 11;
            // 
            // lblDailyTotal
            // 
            this.lblDailyTotal.AutoSize = true;
            this.lblDailyTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDailyTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDailyTotal.Location = new System.Drawing.Point(180, 69);
            this.lblDailyTotal.Name = "lblDailyTotal";
            this.lblDailyTotal.Size = new System.Drawing.Size(54, 20);
            this.lblDailyTotal.TabIndex = 5;
            this.lblDailyTotal.Text = "$0.00";
            // 
            // totalDailyLabel
            // 
            this.totalDailyLabel.AutoSize = true;
            this.totalDailyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.totalDailyLabel.Location = new System.Drawing.Point(15, 69);
            this.totalDailyLabel.Name = "totalDailyLabel";
            this.totalDailyLabel.Size = new System.Drawing.Size(100, 20);
            this.totalDailyLabel.TabIndex = 4;
            this.totalDailyLabel.Text = "Daily Cost: ";
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 660);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbCart);
            this.Controls.Add(this.btnAddFurniture);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.gbMember);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.lblAppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furniture4All - Rent Furniture";
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.gbCart.ResumeLayout(false);
            this.gbCart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.Button btnLookupMember;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblMemberIdLabel;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnAddFurniture;
        private System.Windows.Forms.GroupBox gbCart;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label rentalDueLabel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDailyTotal;
        private System.Windows.Forms.Label totalDailyLabel;
    }
}