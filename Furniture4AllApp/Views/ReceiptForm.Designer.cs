namespace Furniture4AllApp.Views
{
    partial class ReceiptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used please don't edit.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblTransactionId = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblRentalDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dgvLineItems = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rental Confirmation Summary";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSuccess.Location = new System.Drawing.Point(15, 50);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(297, 18);
            this.lblSuccess.TabIndex = 1;
            this.lblSuccess.Text = "Rental Order Submitted Successfully!";
            // 
            // lblTransactionId
            // 
            this.lblTransactionId.AutoSize = true;
            this.lblTransactionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTransactionId.Location = new System.Drawing.Point(15, 85);
            this.lblTransactionId.Name = "lblTransactionId";
            this.lblTransactionId.Size = new System.Drawing.Size(150, 17);
            this.lblTransactionId.TabIndex = 2;
            this.lblTransactionId.Text = "Rental Transaction ID:";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(15, 110);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(50, 13);
            this.lblMember.TabIndex = 3;
            this.lblMember.Text = "Member:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(15, 130);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(58, 13);
            this.lblEmployee.TabIndex = 4;
            this.lblEmployee.Text = "Employee:";
            // 
            // lblRentalDate
            // 
            this.lblRentalDate.AutoSize = true;
            this.lblRentalDate.Location = new System.Drawing.Point(15, 150);
            this.lblRentalDate.Name = "lblRentalDate";
            this.lblRentalDate.Size = new System.Drawing.Size(70, 13);
            this.lblRentalDate.TabIndex = 5;
            this.lblRentalDate.Text = "Rental Date:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(15, 170);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date:";
            // 
            // dgvLineItems
            // 
            this.dgvLineItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineItems.Location = new System.Drawing.Point(15, 200);
            this.dgvLineItems.Name = "dgvLineItems";
            this.dgvLineItems.Size = new System.Drawing.Size(640, 200);
            this.dgvLineItems.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotal.Location = new System.Drawing.Point(15, 415);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(159, 24);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total Daily Cost:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(265, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 520);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvLineItems);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblRentalDate);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblTransactionId);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furniture4All - Rental Receipt";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblTransactionId;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblRentalDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DataGridView dgvLineItems;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClose;
    }
}