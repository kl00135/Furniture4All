namespace Furniture4AllApp.Views
{
    partial class MainForm
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
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.ApplicationNameLabel = new System.Windows.Forms.Label();
            this.RegisterMemberLabel = new System.Windows.Forms.Label();
            this.RegisterMemberLowerLabel = new System.Windows.Forms.Label();
            this.RegisterMemberButton = new System.Windows.Forms.Button();
            this.SearchEditMemberButton = new System.Windows.Forms.Button();
            this.SearchEditMemberLowerLabel = new System.Windows.Forms.Label();
            this.SearchEditMemberLabel = new System.Windows.Forms.Label();
            this.SearhcFurnitureButton = new System.Windows.Forms.Button();
            this.SearchFurnitureLowerLabel = new System.Windows.Forms.Label();
            this.SearchFurnitureLabel = new System.Windows.Forms.Label();
            this.RentFurnitureButton = new System.Windows.Forms.Button();
            this.RentFurnitureLowerLabel = new System.Windows.Forms.Label();
            this.RentFurnitureLabel = new System.Windows.Forms.Label();
            this.ReturnFurnitureButton = new System.Windows.Forms.Button();
            this.ReturnFurnitureLowerLabel = new System.Windows.Forms.Label();
            this.ReturnFurnitureLabel = new System.Windows.Forms.Label();
            this.RentalReturnHistoryButton = new System.Windows.Forms.Button();
            this.RentalReturnLowerLabel = new System.Windows.Forms.Label();
            this.RentalReturnHistoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLinkLabel.Location = new System.Drawing.Point(714, 56);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(48, 16);
            this.LogoutLinkLabel.TabIndex = 0;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Logout";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInAsLabel.Location = new System.Drawing.Point(595, 9);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(91, 16);
            this.LoggedInAsLabel.TabIndex = 1;
            this.LoggedInAsLabel.Text = "Logged in as: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(714, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 16);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "(User)";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(721, 32);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(41, 15);
            this.RoleLabel.TabIndex = 3;
            this.RoleLabel.Text = "(Role)";
            // 
            // ApplicationNameLabel
            // 
            this.ApplicationNameLabel.AutoSize = true;
            this.ApplicationNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationNameLabel.Location = new System.Drawing.Point(29, 32);
            this.ApplicationNameLabel.Name = "ApplicationNameLabel";
            this.ApplicationNameLabel.Size = new System.Drawing.Size(350, 24);
            this.ApplicationNameLabel.TabIndex = 4;
            this.ApplicationNameLabel.Text = "Furniture4All - Employee Dashboard";
            // 
            // RegisterMemberLabel
            // 
            this.RegisterMemberLabel.AutoSize = true;
            this.RegisterMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RegisterMemberLabel.Location = new System.Drawing.Point(53, 111);
            this.RegisterMemberLabel.Name = "RegisterMemberLabel";
            this.RegisterMemberLabel.Size = new System.Drawing.Size(155, 24);
            this.RegisterMemberLabel.TabIndex = 5;
            this.RegisterMemberLabel.Text = "Register Member";
            // 
            // RegisterMemberLowerLabel
            // 
            this.RegisterMemberLowerLabel.AutoSize = true;
            this.RegisterMemberLowerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RegisterMemberLowerLabel.Location = new System.Drawing.Point(57, 139);
            this.RegisterMemberLowerLabel.Name = "RegisterMemberLowerLabel";
            this.RegisterMemberLowerLabel.Size = new System.Drawing.Size(166, 13);
            this.RegisterMemberLowerLabel.TabIndex = 6;
            this.RegisterMemberLowerLabel.Text = "Add a new member to the system.";
            // 
            // RegisterMemberButton
            // 
            this.RegisterMemberButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RegisterMemberButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RegisterMemberButton.Location = new System.Drawing.Point(60, 169);
            this.RegisterMemberButton.Name = "RegisterMemberButton";
            this.RegisterMemberButton.Size = new System.Drawing.Size(106, 45);
            this.RegisterMemberButton.TabIndex = 7;
            this.RegisterMemberButton.Text = "Open";
            this.RegisterMemberButton.UseVisualStyleBackColor = false;
            // 
            // SearchEditMemberButton
            // 
            this.SearchEditMemberButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SearchEditMemberButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SearchEditMemberButton.Location = new System.Drawing.Point(63, 334);
            this.SearchEditMemberButton.Name = "SearchEditMemberButton";
            this.SearchEditMemberButton.Size = new System.Drawing.Size(106, 45);
            this.SearchEditMemberButton.TabIndex = 10;
            this.SearchEditMemberButton.Text = "Open";
            this.SearchEditMemberButton.UseVisualStyleBackColor = false;
            // 
            // SearchEditMemberLowerLabel
            // 
            this.SearchEditMemberLowerLabel.AutoSize = true;
            this.SearchEditMemberLowerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchEditMemberLowerLabel.Location = new System.Drawing.Point(60, 304);
            this.SearchEditMemberLowerLabel.Name = "SearchEditMemberLowerLabel";
            this.SearchEditMemberLowerLabel.Size = new System.Drawing.Size(121, 13);
            this.SearchEditMemberLowerLabel.TabIndex = 9;
            this.SearchEditMemberLowerLabel.Text = "Browse furniture catalog";
            // 
            // SearchEditMemberLabel
            // 
            this.SearchEditMemberLabel.AutoSize = true;
            this.SearchEditMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEditMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SearchEditMemberLabel.Location = new System.Drawing.Point(56, 276);
            this.SearchEditMemberLabel.Name = "SearchEditMemberLabel";
            this.SearchEditMemberLabel.Size = new System.Drawing.Size(193, 24);
            this.SearchEditMemberLabel.TabIndex = 8;
            this.SearchEditMemberLabel.Text = "Search / Edit Member";
            // 
            // SearhcFurnitureButton
            // 
            this.SearhcFurnitureButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SearhcFurnitureButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SearhcFurnitureButton.Location = new System.Drawing.Point(304, 169);
            this.SearhcFurnitureButton.Name = "SearhcFurnitureButton";
            this.SearhcFurnitureButton.Size = new System.Drawing.Size(106, 45);
            this.SearhcFurnitureButton.TabIndex = 13;
            this.SearhcFurnitureButton.Text = "Open";
            this.SearhcFurnitureButton.UseVisualStyleBackColor = false;
            // 
            // SearchFurnitureLowerLabel
            // 
            this.SearchFurnitureLowerLabel.AutoSize = true;
            this.SearchFurnitureLowerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchFurnitureLowerLabel.Location = new System.Drawing.Point(301, 139);
            this.SearchFurnitureLowerLabel.Name = "SearchFurnitureLowerLabel";
            this.SearchFurnitureLowerLabel.Size = new System.Drawing.Size(121, 13);
            this.SearchFurnitureLowerLabel.TabIndex = 12;
            this.SearchFurnitureLowerLabel.Text = "Browse furniture catalog";
            // 
            // SearchFurnitureLabel
            // 
            this.SearchFurnitureLabel.AutoSize = true;
            this.SearchFurnitureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFurnitureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SearchFurnitureLabel.Location = new System.Drawing.Point(297, 111);
            this.SearchFurnitureLabel.Name = "SearchFurnitureLabel";
            this.SearchFurnitureLabel.Size = new System.Drawing.Size(151, 24);
            this.SearchFurnitureLabel.TabIndex = 11;
            this.SearchFurnitureLabel.Text = "Search Furniture";
            // 
            // RentFurnitureButton
            // 
            this.RentFurnitureButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RentFurnitureButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RentFurnitureButton.Location = new System.Drawing.Point(304, 334);
            this.RentFurnitureButton.Name = "RentFurnitureButton";
            this.RentFurnitureButton.Size = new System.Drawing.Size(106, 45);
            this.RentFurnitureButton.TabIndex = 16;
            this.RentFurnitureButton.Text = "Open";
            this.RentFurnitureButton.UseVisualStyleBackColor = false;
            // 
            // RentFurnitureLowerLabel
            // 
            this.RentFurnitureLowerLabel.AutoSize = true;
            this.RentFurnitureLowerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RentFurnitureLowerLabel.Location = new System.Drawing.Point(301, 304);
            this.RentFurnitureLowerLabel.Name = "RentFurnitureLowerLabel";
            this.RentFurnitureLowerLabel.Size = new System.Drawing.Size(154, 13);
            this.RentFurnitureLowerLabel.TabIndex = 15;
            this.RentFurnitureLowerLabel.Text = "Create a new rental transaction";
            // 
            // RentFurnitureLabel
            // 
            this.RentFurnitureLabel.AutoSize = true;
            this.RentFurnitureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentFurnitureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RentFurnitureLabel.Location = new System.Drawing.Point(297, 276);
            this.RentFurnitureLabel.Name = "RentFurnitureLabel";
            this.RentFurnitureLabel.Size = new System.Drawing.Size(130, 24);
            this.RentFurnitureLabel.TabIndex = 14;
            this.RentFurnitureLabel.Text = "Rent Furniture";
            // 
            // ReturnFurnitureButton
            // 
            this.ReturnFurnitureButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ReturnFurnitureButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ReturnFurnitureButton.Location = new System.Drawing.Point(529, 169);
            this.ReturnFurnitureButton.Name = "ReturnFurnitureButton";
            this.ReturnFurnitureButton.Size = new System.Drawing.Size(106, 45);
            this.ReturnFurnitureButton.TabIndex = 19;
            this.ReturnFurnitureButton.Text = "Open";
            this.ReturnFurnitureButton.UseVisualStyleBackColor = false;
            // 
            // ReturnFurnitureLowerLabel
            // 
            this.ReturnFurnitureLowerLabel.AutoSize = true;
            this.ReturnFurnitureLowerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReturnFurnitureLowerLabel.Location = new System.Drawing.Point(526, 139);
            this.ReturnFurnitureLowerLabel.Name = "ReturnFurnitureLowerLabel";
            this.ReturnFurnitureLowerLabel.Size = new System.Drawing.Size(121, 13);
            this.ReturnFurnitureLowerLabel.TabIndex = 18;
            this.ReturnFurnitureLowerLabel.Text = "Process furniture returns";
            // 
            // ReturnFurnitureLabel
            // 
            this.ReturnFurnitureLabel.AutoSize = true;
            this.ReturnFurnitureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnFurnitureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReturnFurnitureLabel.Location = new System.Drawing.Point(522, 111);
            this.ReturnFurnitureLabel.Name = "ReturnFurnitureLabel";
            this.ReturnFurnitureLabel.Size = new System.Drawing.Size(147, 24);
            this.ReturnFurnitureLabel.TabIndex = 17;
            this.ReturnFurnitureLabel.Text = "Return Furniture";
            // 
            // RentalReturnHistoryButton
            // 
            this.RentalReturnHistoryButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RentalReturnHistoryButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RentalReturnHistoryButton.Location = new System.Drawing.Point(529, 334);
            this.RentalReturnHistoryButton.Name = "RentalReturnHistoryButton";
            this.RentalReturnHistoryButton.Size = new System.Drawing.Size(106, 45);
            this.RentalReturnHistoryButton.TabIndex = 22;
            this.RentalReturnHistoryButton.Text = "Open";
            this.RentalReturnHistoryButton.UseVisualStyleBackColor = false;
            // 
            // RentalReturnLowerLabel
            // 
            this.RentalReturnLowerLabel.AutoSize = true;
            this.RentalReturnLowerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RentalReturnLowerLabel.Location = new System.Drawing.Point(526, 304);
            this.RentalReturnLowerLabel.Name = "RentalReturnLowerLabel";
            this.RentalReturnLowerLabel.Size = new System.Drawing.Size(118, 13);
            this.RentalReturnLowerLabel.TabIndex = 21;
            this.RentalReturnLowerLabel.Text = "View transaction history";
            // 
            // RentalReturnHistoryLabel
            // 
            this.RentalReturnHistoryLabel.AutoSize = true;
            this.RentalReturnHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalReturnHistoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RentalReturnHistoryLabel.Location = new System.Drawing.Point(522, 276);
            this.RentalReturnHistoryLabel.Name = "RentalReturnHistoryLabel";
            this.RentalReturnHistoryLabel.Size = new System.Drawing.Size(196, 24);
            this.RentalReturnHistoryLabel.TabIndex = 20;
            this.RentalReturnHistoryLabel.Text = "Rental / Return History";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RentalReturnHistoryButton);
            this.Controls.Add(this.RentalReturnLowerLabel);
            this.Controls.Add(this.RentalReturnHistoryLabel);
            this.Controls.Add(this.ReturnFurnitureButton);
            this.Controls.Add(this.ReturnFurnitureLowerLabel);
            this.Controls.Add(this.ReturnFurnitureLabel);
            this.Controls.Add(this.RentFurnitureButton);
            this.Controls.Add(this.RentFurnitureLowerLabel);
            this.Controls.Add(this.RentFurnitureLabel);
            this.Controls.Add(this.SearhcFurnitureButton);
            this.Controls.Add(this.SearchFurnitureLowerLabel);
            this.Controls.Add(this.SearchFurnitureLabel);
            this.Controls.Add(this.SearchEditMemberButton);
            this.Controls.Add(this.SearchEditMemberLowerLabel);
            this.Controls.Add(this.SearchEditMemberLabel);
            this.Controls.Add(this.RegisterMemberButton);
            this.Controls.Add(this.RegisterMemberLowerLabel);
            this.Controls.Add(this.RegisterMemberLabel);
            this.Controls.Add(this.ApplicationNameLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.Label LoggedInAsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label ApplicationNameLabel;
        private System.Windows.Forms.Label RegisterMemberLabel;
        private System.Windows.Forms.Label RegisterMemberLowerLabel;
        private System.Windows.Forms.Button RegisterMemberButton;
        private System.Windows.Forms.Button SearchEditMemberButton;
        private System.Windows.Forms.Label SearchEditMemberLowerLabel;
        private System.Windows.Forms.Label SearchEditMemberLabel;
        private System.Windows.Forms.Button SearhcFurnitureButton;
        private System.Windows.Forms.Label SearchFurnitureLowerLabel;
        private System.Windows.Forms.Label SearchFurnitureLabel;
        private System.Windows.Forms.Button RentFurnitureButton;
        private System.Windows.Forms.Label RentFurnitureLowerLabel;
        private System.Windows.Forms.Label RentFurnitureLabel;
        private System.Windows.Forms.Button ReturnFurnitureButton;
        private System.Windows.Forms.Label ReturnFurnitureLowerLabel;
        private System.Windows.Forms.Label ReturnFurnitureLabel;
        private System.Windows.Forms.Button RentalReturnHistoryButton;
        private System.Windows.Forms.Label RentalReturnLowerLabel;
        private System.Windows.Forms.Label RentalReturnHistoryLabel;
    }
}