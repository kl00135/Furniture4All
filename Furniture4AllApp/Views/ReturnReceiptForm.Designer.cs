namespace Furniture4AllApp.Views
{
    partial class ReturnReceiptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dgvLineItems = new System.Windows.Forms.DataGridView();
            this.lblTotalFine = new System.Windows.Forms.Label();
            this.lblTotalRefund = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
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
            this.lblTitle.Size = new System.Drawing.Size(307, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Return Confirmation Summary";
            //
            // lblSuccess
            //
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSuccess.Location = new System.Drawing.Point(15, 50);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(232, 18);
            this.lblSuccess.TabIndex = 1;
            this.lblSuccess.Text = "Return Processed Successfully!";
            //
            // lblTransactionId
            //
            this.lblTransactionId.AutoSize = true;
            this.lblTransactionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTransactionId.Location = new System.Drawing.Point(15, 85);
            this.lblTransactionId.Name = "lblTransactionId";
            this.lblTransactionId.Size = new System.Drawing.Size(160, 17);
            this.lblTransactionId.TabIndex = 2;
            this.lblTransactionId.Text = "Return Transaction ID:";
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
            this.lblEmployee.Size = new System.Drawing.Size(105, 13);
            this.lblEmployee.TabIndex = 4;
            this.lblEmployee.Text = "Service Employee:";
            //
            // lblReturnDate
            //
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(15, 150);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(72, 13);
            this.lblReturnDate.TabIndex = 5;
            this.lblReturnDate.Text = "Return Date:";
            //
            // dgvLineItems
            //
            this.dgvLineItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineItems.Location = new System.Drawing.Point(15, 180);
            this.dgvLineItems.Name = "dgvLineItems";
            this.dgvLineItems.Size = new System.Drawing.Size(720, 200);
            this.dgvLineItems.TabIndex = 6;
            //
            // lblTotalFine
            //
            this.lblTotalFine.AutoSize = true;
            this.lblTotalFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalFine.Location = new System.Drawing.Point(15, 395);
            this.lblTotalFine.Name = "lblTotalFine";
            this.lblTotalFine.Size = new System.Drawing.Size(85, 18);
            this.lblTotalFine.TabIndex = 7;
            this.lblTotalFine.Text = "Total Fine:";
            //
            // lblTotalRefund
            //
            this.lblTotalRefund.AutoSize = true;
            this.lblTotalRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalRefund.Location = new System.Drawing.Point(15, 420);
            this.lblTotalRefund.Name = "lblTotalRefund";
            this.lblTotalRefund.Size = new System.Drawing.Size(108, 18);
            this.lblTotalRefund.TabIndex = 8;
            this.lblTotalRefund.Text = "Total Refund:";
            //
            // lblNetAmount
            //
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblNetAmount.Location = new System.Drawing.Point(15, 450);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(116, 22);
            this.lblNetAmount.TabIndex = 9;
            this.lblNetAmount.Text = "Net Amount:";
            //
            // btnClose
            //
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(305, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            //
            // ReturnReceiptForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 555);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.lblTotalRefund);
            this.Controls.Add(this.lblTotalFine);
            this.Controls.Add(this.dgvLineItems);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblTransactionId);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReturnReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furniture4All - Return Receipt";
            this.Load += new System.EventHandler(this.ReturnReceiptForm_Load);
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
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DataGridView dgvLineItems;
        private System.Windows.Forms.Label lblTotalFine;
        private System.Windows.Forms.Label lblTotalRefund;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Button btnClose;
    }
}