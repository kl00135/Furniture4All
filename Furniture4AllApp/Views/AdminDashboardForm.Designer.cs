/// <summary>
/// Windows designer file for the Admin Dashboard.
///
/// Author: Anu Rayini
/// Version: 5/2/2026
/// </summary>
namespace Furniture4AllApp.Views
{
    partial class AdminDashboardForm
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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.ApplicationNameLabel = new System.Windows.Forms.Label();
            this.GenerateReportLabel = new System.Windows.Forms.Label();
            this.GenerateReportLowerLabel = new System.Windows.Forms.Label();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.ManageEmployeesLabel = new System.Windows.Forms.Label();
            this.ManageEmployeesLowerLabel = new System.Windows.Forms.Label();
            this.ManageEmployeesButton = new System.Windows.Forms.Button();
            this.EmployeeFunctionsLabel = new System.Windows.Forms.Label();
            this.EmployeeFunctionsLowerLabel = new System.Windows.Forms.Label();
            this.EmployeeFunctionsButton = new System.Windows.Forms.Button();
            this.GenerateReportBackgroundBox = new System.Windows.Forms.GroupBox();
            this.ManageEmployeesBackgroundBox = new System.Windows.Forms.GroupBox();
            this.EmployeeFunctionsBackgroundBox = new System.Windows.Forms.GroupBox();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.GenerateReportBackgroundBox.SuspendLayout();
            this.ManageEmployeesBackgroundBox.SuspendLayout();
            this.EmployeeFunctionsBackgroundBox.SuspendLayout();
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
            this.RoleLabel.Text = "(Admin)";
            //
            // ApplicationNameLabel
            //
            this.ApplicationNameLabel.AutoSize = true;
            this.ApplicationNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationNameLabel.Location = new System.Drawing.Point(29, 32);
            this.ApplicationNameLabel.Name = "ApplicationNameLabel";
            this.ApplicationNameLabel.Size = new System.Drawing.Size(280, 24);
            this.ApplicationNameLabel.TabIndex = 4;
            this.ApplicationNameLabel.Text = "Furniture4All - Admin Dashboard";
            //
            // GenerateReportLabel
            //
            this.GenerateReportLabel.AutoSize = true;
            this.GenerateReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReportLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GenerateReportLabel.Location = new System.Drawing.Point(9, 24);
            this.GenerateReportLabel.Name = "GenerateReportLabel";
            this.GenerateReportLabel.Size = new System.Drawing.Size(155, 24);
            this.GenerateReportLabel.TabIndex = 5;
            this.GenerateReportLabel.Text = "Generate Report";
            //
            // GenerateReportLowerLabel
            //
            this.GenerateReportLowerLabel.AutoSize = true;
            this.GenerateReportLowerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GenerateReportLowerLabel.Location = new System.Drawing.Point(13, 52);
            this.GenerateReportLowerLabel.Name = "GenerateReportLowerLabel";
            this.GenerateReportLowerLabel.Size = new System.Drawing.Size(170, 13);
            this.GenerateReportLowerLabel.TabIndex = 6;
            this.GenerateReportLowerLabel.Text = "Most Popular Furniture Report";
            //
            // GenerateReportButton
            //
            this.GenerateReportButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.GenerateReportButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GenerateReportButton.Location = new System.Drawing.Point(16, 82);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(106, 45);
            this.GenerateReportButton.TabIndex = 7;
            this.GenerateReportButton.Text = "Open";
            this.GenerateReportButton.UseVisualStyleBackColor = false;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            //
            // ManageEmployeesLabel
            //
            this.ManageEmployeesLabel.AutoSize = true;
            this.ManageEmployeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageEmployeesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ManageEmployeesLabel.Location = new System.Drawing.Point(9, 24);
            this.ManageEmployeesLabel.Name = "ManageEmployeesLabel";
            this.ManageEmployeesLabel.Size = new System.Drawing.Size(180, 24);
            this.ManageEmployeesLabel.TabIndex = 8;
            this.ManageEmployeesLabel.Text = "Manage Employees";
            //
            // ManageEmployeesLowerLabel
            //
            this.ManageEmployeesLowerLabel.AutoSize = true;
            this.ManageEmployeesLowerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ManageEmployeesLowerLabel.Location = new System.Drawing.Point(13, 52);
            this.ManageEmployeesLowerLabel.Name = "ManageEmployeesLowerLabel";
            this.ManageEmployeesLowerLabel.Size = new System.Drawing.Size(150, 13);
            this.ManageEmployeesLowerLabel.TabIndex = 9;
            this.ManageEmployeesLowerLabel.Text = "Add / Edit / View employees";
            //
            // ManageEmployeesButton
            //
            this.ManageEmployeesButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ManageEmployeesButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ManageEmployeesButton.Location = new System.Drawing.Point(16, 82);
            this.ManageEmployeesButton.Name = "ManageEmployeesButton";
            this.ManageEmployeesButton.Size = new System.Drawing.Size(106, 45);
            this.ManageEmployeesButton.TabIndex = 10;
            this.ManageEmployeesButton.Text = "Open";
            this.ManageEmployeesButton.UseVisualStyleBackColor = false;
            this.ManageEmployeesButton.Click += new System.EventHandler(this.ManageEmployeesButton_Click);
            //
            // EmployeeFunctionsLabel
            //
            this.EmployeeFunctionsLabel.AutoSize = true;
            this.EmployeeFunctionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeFunctionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EmployeeFunctionsLabel.Location = new System.Drawing.Point(9, 24);
            this.EmployeeFunctionsLabel.Name = "EmployeeFunctionsLabel";
            this.EmployeeFunctionsLabel.Size = new System.Drawing.Size(180, 24);
            this.EmployeeFunctionsLabel.TabIndex = 11;
            this.EmployeeFunctionsLabel.Text = "Employee Functions";
            //
            // EmployeeFunctionsLowerLabel
            //
            this.EmployeeFunctionsLowerLabel.AutoSize = true;
            this.EmployeeFunctionsLowerLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmployeeFunctionsLowerLabel.Location = new System.Drawing.Point(13, 52);
            this.EmployeeFunctionsLowerLabel.Name = "EmployeeFunctionsLowerLabel";
            this.EmployeeFunctionsLowerLabel.Size = new System.Drawing.Size(140, 13);
            this.EmployeeFunctionsLowerLabel.TabIndex = 12;
            this.EmployeeFunctionsLowerLabel.Text = "Access all employee features";
            //
            // EmployeeFunctionsButton
            //
            this.EmployeeFunctionsButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.EmployeeFunctionsButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EmployeeFunctionsButton.Location = new System.Drawing.Point(16, 82);
            this.EmployeeFunctionsButton.Name = "EmployeeFunctionsButton";
            this.EmployeeFunctionsButton.Size = new System.Drawing.Size(106, 45);
            this.EmployeeFunctionsButton.TabIndex = 13;
            this.EmployeeFunctionsButton.Text = "Open";
            this.EmployeeFunctionsButton.UseVisualStyleBackColor = false;
            this.EmployeeFunctionsButton.Click += new System.EventHandler(this.EmployeeFunctionsButton_Click);
            //
            // GenerateReportBackgroundBox
            //
            this.GenerateReportBackgroundBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenerateReportBackgroundBox.Controls.Add(this.GenerateReportButton);
            this.GenerateReportBackgroundBox.Controls.Add(this.GenerateReportLabel);
            this.GenerateReportBackgroundBox.Controls.Add(this.GenerateReportLowerLabel);
            this.GenerateReportBackgroundBox.Location = new System.Drawing.Point(33, 87);
            this.GenerateReportBackgroundBox.Name = "GenerateReportBackgroundBox";
            this.GenerateReportBackgroundBox.Size = new System.Drawing.Size(227, 151);
            this.GenerateReportBackgroundBox.TabIndex = 14;
            this.GenerateReportBackgroundBox.TabStop = false;
            //
            // ManageEmployeesBackgroundBox
            //
            this.ManageEmployeesBackgroundBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageEmployeesBackgroundBox.Controls.Add(this.ManageEmployeesButton);
            this.ManageEmployeesBackgroundBox.Controls.Add(this.ManageEmployeesLabel);
            this.ManageEmployeesBackgroundBox.Controls.Add(this.ManageEmployeesLowerLabel);
            this.ManageEmployeesBackgroundBox.Location = new System.Drawing.Point(277, 87);
            this.ManageEmployeesBackgroundBox.Name = "ManageEmployeesBackgroundBox";
            this.ManageEmployeesBackgroundBox.Size = new System.Drawing.Size(227, 151);
            this.ManageEmployeesBackgroundBox.TabIndex = 15;
            this.ManageEmployeesBackgroundBox.TabStop = false;
            //
            // EmployeeFunctionsBackgroundBox
            //
            this.EmployeeFunctionsBackgroundBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmployeeFunctionsBackgroundBox.Controls.Add(this.EmployeeFunctionsButton);
            this.EmployeeFunctionsBackgroundBox.Controls.Add(this.EmployeeFunctionsLabel);
            this.EmployeeFunctionsBackgroundBox.Controls.Add(this.EmployeeFunctionsLowerLabel);
            this.EmployeeFunctionsBackgroundBox.Location = new System.Drawing.Point(33, 260);
            this.EmployeeFunctionsBackgroundBox.Name = "EmployeeFunctionsBackgroundBox";
            this.EmployeeFunctionsBackgroundBox.Size = new System.Drawing.Size(227, 151);
            this.EmployeeFunctionsBackgroundBox.TabIndex = 16;
            this.EmployeeFunctionsBackgroundBox.TabStop = false;
            //
            // NoteLabel
            //
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.NoteLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NoteLabel.Location = new System.Drawing.Point(33, 425);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(415, 13);
            this.NoteLabel.TabIndex = 17;
            this.NoteLabel.Text = "* Admins have access to all employee functions plus report generation";
            //
            // AdminDashboardForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.ApplicationNameLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.GenerateReportBackgroundBox);
            this.Controls.Add(this.ManageEmployeesBackgroundBox);
            this.Controls.Add(this.EmployeeFunctionsBackgroundBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furniture4All - Admin Dashboard";
            this.GenerateReportBackgroundBox.ResumeLayout(false);
            this.GenerateReportBackgroundBox.PerformLayout();
            this.ManageEmployeesBackgroundBox.ResumeLayout(false);
            this.ManageEmployeesBackgroundBox.PerformLayout();
            this.EmployeeFunctionsBackgroundBox.ResumeLayout(false);
            this.EmployeeFunctionsBackgroundBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.Label LoggedInAsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label ApplicationNameLabel;
        private System.Windows.Forms.Label GenerateReportLabel;
        private System.Windows.Forms.Label GenerateReportLowerLabel;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.Label ManageEmployeesLabel;
        private System.Windows.Forms.Label ManageEmployeesLowerLabel;
        private System.Windows.Forms.Button ManageEmployeesButton;
        private System.Windows.Forms.Label EmployeeFunctionsLabel;
        private System.Windows.Forms.Label EmployeeFunctionsLowerLabel;
        private System.Windows.Forms.Button EmployeeFunctionsButton;
        private System.Windows.Forms.GroupBox GenerateReportBackgroundBox;
        private System.Windows.Forms.GroupBox ManageEmployeesBackgroundBox;
        private System.Windows.Forms.GroupBox EmployeeFunctionsBackgroundBox;
        private System.Windows.Forms.Label NoteLabel;
    }
}
