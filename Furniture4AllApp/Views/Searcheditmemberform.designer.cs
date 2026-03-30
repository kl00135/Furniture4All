/// <summary>
/// This is the windows design for the user to see.
/// 
/// Author: Laken Harville
/// Version: 3/30/2026
/// </summary>
namespace Furniture4AllApp
{
    partial class SearchEditMemberForm
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
            this.txtSearchValue2 = new System.Windows.Forms.TextBox();
            this.lblSearchValue2 = new System.Windows.Forms.Label();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.lblSearchValue = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpSearch.SuspendLayout();
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
            this.lblLoggedIn.Location = new System.Drawing.Point(320, 14);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(250, 17);
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
            this.lblTitle.Size = new System.Drawing.Size(207, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Search / Edit Member";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearchValue2);
            this.grpSearch.Controls.Add(this.lblSearchValue2);
            this.grpSearch.Controls.Add(this.txtSearchValue);
            this.grpSearch.Controls.Add(this.lblSearchValue);
            this.grpSearch.Controls.Add(this.cmbSearchBy);
            this.grpSearch.Controls.Add(this.lblSearchBy);
            this.grpSearch.Location = new System.Drawing.Point(15, 80);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(555, 100);
            this.grpSearch.TabIndex = 3;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Member";
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(15, 30);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(59, 13);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Search by:";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Location = new System.Drawing.Point(80, 27);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(150, 21);
            this.cmbSearchBy.TabIndex = 1;
            this.cmbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBy_SelectedIndexChanged);
            // 
            // lblSearchValue
            // 
            this.lblSearchValue.AutoSize = true;
            this.lblSearchValue.Location = new System.Drawing.Point(15, 65);
            this.lblSearchValue.Name = "lblSearchValue";
            this.lblSearchValue.Size = new System.Drawing.Size(74, 13);
            this.lblSearchValue.TabIndex = 2;
            this.lblSearchValue.Text = "Search Value:";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(105, 62);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(160, 20);
            this.txtSearchValue.TabIndex = 3;
            // 
            // lblSearchValue2
            // 
            this.lblSearchValue2.AutoSize = true;
            this.lblSearchValue2.Location = new System.Drawing.Point(280, 65);
            this.lblSearchValue2.Name = "lblSearchValue2";
            this.lblSearchValue2.Size = new System.Drawing.Size(61, 13);
            this.lblSearchValue2.TabIndex = 4;
            this.lblSearchValue2.Text = "Last Name:";
            this.lblSearchValue2.Visible = false;
            // 
            // txtSearchValue2
            // 
            this.txtSearchValue2.Location = new System.Drawing.Point(348, 62);
            this.txtSearchValue2.Name = "txtSearchValue2";
            this.txtSearchValue2.Size = new System.Drawing.Size(120, 20);
            this.txtSearchValue2.TabIndex = 5;
            this.txtSearchValue2.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(480, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 25);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.Location = new System.Drawing.Point(15, 195);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(198, 17);
            this.lblDetailsTitle.TabIndex = 4;
            this.lblDetailsTitle.Text = "Member Details (Editable)";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(30, 228);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblMemberID.TabIndex = 5;
            this.lblMemberID.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.BackColor = System.Drawing.SystemColors.Control;
            this.txtMemberID.Location = new System.Drawing.Point(160, 225);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(80, 20);
            this.txtMemberID.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(30, 261);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(160, 258);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(250, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(30, 294);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(160, 291);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(250, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(30, 327);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 13);
            this.lblSex.TabIndex = 11;
            this.lblSex.Text = "Sex:";
            // 
            // cmbSex
            // 
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(160, 324);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(120, 21);
            this.cmbSex.TabIndex = 12;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(30, 362);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(73, 13);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(160, 359);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(150, 20);
            this.dtpDOB.TabIndex = 14;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(30, 398);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(160, 395);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 20);
            this.txtAddress.TabIndex = 16;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(30, 434);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(160, 431);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(250, 20);
            this.txtCity.TabIndex = 18;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(30, 470);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 19;
            this.lblState.Text = "State:";
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(160, 467);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(120, 21);
            this.cmbState.TabIndex = 20;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(30, 506);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(56, 13);
            this.lblZip.TabIndex = 21;
            this.lblZip.Text = "ZIP Code:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(160, 503);
            this.txtZip.MaxLength = 10;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(120, 20);
            this.txtZip.TabIndex = 22;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 542);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(160, 539);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 20);
            this.txtPhone.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 580);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 30);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(280, 580);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 30);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(30, 625);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(520, 40);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "";
            // 
            // SearchEditMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 671);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblDetailsTitle);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.lblAppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SearchEditMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furniture4All - Search / Edit Member";
            this.Load += new System.EventHandler(this.SearchEditMemberForm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchValue2;
        private System.Windows.Forms.Label lblSearchValue2;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lblSearchValue;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStatus;
    }
}