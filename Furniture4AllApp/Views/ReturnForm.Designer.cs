namespace Furniture4AllApp.Views
{
    partial class ReturnForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.btnLookupMember = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberIdLabel = new System.Windows.Forms.Label();
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.dgvReturnCart = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProcessReturn = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 24);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Return Furniture";
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoggedIn.Location = new System.Drawing.Point(303, 11);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(250, 17);
            this.lblLoggedIn.TabIndex = 4;
            this.lblLoggedIn.Text = "Logged in as:";
            this.lblLoggedIn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.Location = new System.Drawing.Point(12, 9);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(292, 17);
            this.lblAppTitle.TabIndex = 3;
            this.lblAppTitle.Text = "Furniture4All - Furniture Rental System";
            // 
            // btnLookupMember
            // 
            this.btnLookupMember.Location = new System.Drawing.Point(220, 22);
            this.btnLookupMember.Name = "btnLookupMember";
            this.btnLookupMember.Size = new System.Drawing.Size(75, 27);
            this.btnLookupMember.TabIndex = 2;
            this.btnLookupMember.Text = "Lookup";
            this.btnLookupMember.UseVisualStyleBackColor = true;
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
            // gbMember
            // 
            this.gbMember.Controls.Add(this.lblMemberInfo);
            this.gbMember.Controls.Add(this.btnLookupMember);
            this.gbMember.Controls.Add(this.txtMemberID);
            this.gbMember.Controls.Add(this.lblMemberIdLabel);
            this.gbMember.Location = new System.Drawing.Point(16, 87);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(649, 67);
            this.gbMember.TabIndex = 6;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "Find Member Rentals";
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
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmployee.Location = new System.Drawing.Point(19, 172);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(197, 15);
            this.lblEmployee.TabIndex = 7;
            this.lblEmployee.Text = "Active Rentals for [Employee]:";
            // 
            // dgvReturnCart
            // 
            this.dgvReturnCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.RentalID,
            this.ItemID,
            this.Name,
            this.Quantity,
            this.Rate,
            this.Rented,
            this.Due});
            this.dgvReturnCart.Location = new System.Drawing.Point(16, 190);
            this.dgvReturnCart.Name = "dgvReturnCart";
            this.dgvReturnCart.Size = new System.Drawing.Size(649, 150);
            this.dgvReturnCart.TabIndex = 8;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            // 
            // RentalID
            // 
            this.RentalID.HeaderText = "Rental  ID";
            this.RentalID.Name = "RentalID";
            this.RentalID.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Rented
            // 
            this.Rented.HeaderText = "Rented";
            this.Rented.Name = "Rented";
            this.Rented.ReadOnly = true;
            // 
            // Due
            // 
            this.Due.HeaderText = "Due";
            this.Due.Name = "Due";
            this.Due.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(339, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 45);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnProcessReturn
            // 
            this.btnProcessReturn.BackColor = System.Drawing.Color.Green;
            this.btnProcessReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnProcessReturn.ForeColor = System.Drawing.Color.White;
            this.btnProcessReturn.Location = new System.Drawing.Point(154, 464);
            this.btnProcessReturn.Name = "btnProcessReturn";
            this.btnProcessReturn.Size = new System.Drawing.Size(160, 45);
            this.btnProcessReturn.TabIndex = 11;
            this.btnProcessReturn.Text = "Process Return";
            this.btnProcessReturn.UseVisualStyleBackColor = false;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblService.Location = new System.Drawing.Point(13, 436);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(204, 15);
            this.lblService.TabIndex = 13;
            this.lblService.Text = "Service Employee:  [Employee]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Return Quantity for Seletced Items: ";
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProcessReturn);
            this.Controls.Add(this.dgvReturnCart);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.gbMember);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.lblAppTitle);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnLookupMember;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblMemberIdLabel;
        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.DataGridView dgvReturnCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rented;
        private System.Windows.Forms.DataGridViewTextBoxColumn Due;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProcessReturn;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label label1;
    }
}