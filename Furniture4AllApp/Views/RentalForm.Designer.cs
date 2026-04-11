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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.FurnitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Subtract = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 24);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Rent Furniture";
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoggedIn.Location = new System.Drawing.Point(282, 26);
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
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCart.Location = new System.Drawing.Point(11, 97);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(114, 24);
            this.lblCart.TabIndex = 6;
            this.lblCart.Text = "Cart Items: ";
            // 
            // dgvCart
            // 
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FurnitureID,
            this.Name,
            this.DailyRate,
            this.Quantity,
            this.Subtotal,
            this.Add,
            this.Subtract,
            this.Remove});
            this.dgvCart.Location = new System.Drawing.Point(27, 124);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(470, 165);
            this.dgvCart.TabIndex = 7;
            // 
            // FurnitureID
            // 
            this.FurnitureID.HeaderText = "FurnitureID";
            this.FurnitureID.Name = "FurnitureID";
            this.FurnitureID.ReadOnly = true;
            this.FurnitureID.Width = 84;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 60;
            // 
            // DailyRate
            // 
            this.DailyRate.HeaderText = "DailyRate";
            this.DailyRate.Name = "DailyRate";
            this.DailyRate.ReadOnly = true;
            this.DailyRate.Width = 78;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 71;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 71;
            // 
            // Add
            // 
            this.Add.HeaderText = "+";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Width = 21;
            // 
            // Subtract
            // 
            this.Subtract.HeaderText = "-";
            this.Subtract.Name = "Subtract";
            this.Subtract.ReadOnly = true;
            this.Subtract.Width = 21;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "X";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Width = 21;
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 528);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.lblAppTitle);
            this.Name = "RentalForm";
            this.Text = "RentalForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewButtonColumn Subtract;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}