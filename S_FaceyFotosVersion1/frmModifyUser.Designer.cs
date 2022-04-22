namespace S_FaceyFotosVersion1
{
    partial class frmModifyUser
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
            this.gvUserAccountDatabase = new System.Windows.Forms.DataGridView();
            this.btnEditUserRecord = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblUserAccount = new System.Windows.Forms.TableLayoutPanel();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblCardType = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCsv = new System.Windows.Forms.Label();
            this.mtbExpiry = new System.Windows.Forms.MaskedTextBox();
            this.cmbCardType = new System.Windows.Forms.ComboBox();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mtbPass1 = new System.Windows.Forms.MaskedTextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbCSV = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserAccountDatabase)).BeginInit();
            this.tblUserAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvUserAccountDatabase
            // 
            this.gvUserAccountDatabase.AllowUserToAddRows = false;
            this.gvUserAccountDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserAccountDatabase.Location = new System.Drawing.Point(34, 100);
            this.gvUserAccountDatabase.Name = "gvUserAccountDatabase";
            this.gvUserAccountDatabase.RowHeadersWidth = 51;
            this.gvUserAccountDatabase.RowTemplate.Height = 24;
            this.gvUserAccountDatabase.Size = new System.Drawing.Size(1424, 325);
            this.gvUserAccountDatabase.TabIndex = 0;
            // 
            // btnEditUserRecord
            // 
            this.btnEditUserRecord.Location = new System.Drawing.Point(375, 820);
            this.btnEditUserRecord.Name = "btnEditUserRecord";
            this.btnEditUserRecord.Size = new System.Drawing.Size(75, 23);
            this.btnEditUserRecord.TabIndex = 1;
            this.btnEditUserRecord.Text = "Edit";
            this.btnEditUserRecord.UseVisualStyleBackColor = true;
            this.btnEditUserRecord.Click += new System.EventHandler(this.btnEditUserRecord_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(808, 584);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(808, 645);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tblUserAccount
            // 
            this.tblUserAccount.ColumnCount = 2;
            this.tblUserAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.28571F));
            this.tblUserAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.71429F));
            this.tblUserAccount.Controls.Add(this.tbCSV, 1, 8);
            this.tblUserAccount.Controls.Add(this.cmbCardType, 1, 7);
            this.tblUserAccount.Controls.Add(this.lblExpiryDate, 0, 9);
            this.tblUserAccount.Controls.Add(this.tbCardNumber, 1, 6);
            this.tblUserAccount.Controls.Add(this.lblCardType, 0, 7);
            this.tblUserAccount.Controls.Add(this.lblCardNumber, 0, 6);
            this.tblUserAccount.Controls.Add(this.lblFname, 0, 0);
            this.tblUserAccount.Controls.Add(this.lblLastName, 0, 1);
            this.tblUserAccount.Controls.Add(this.tbLastName, 1, 1);
            this.tblUserAccount.Controls.Add(this.lblUsername, 0, 4);
            this.tblUserAccount.Controls.Add(this.tbFirstName, 1, 0);
            this.tblUserAccount.Controls.Add(this.lblPassword, 0, 5);
            this.tblUserAccount.Controls.Add(this.lblCsv, 0, 8);
            this.tblUserAccount.Controls.Add(this.mtbExpiry, 1, 9);
            this.tblUserAccount.Controls.Add(this.lblEmail, 0, 2);
            this.tblUserAccount.Controls.Add(this.lblPhone, 0, 3);
            this.tblUserAccount.Controls.Add(this.mtbTelephone, 1, 3);
            this.tblUserAccount.Controls.Add(this.tbEmailAddress, 1, 2);
            this.tblUserAccount.Controls.Add(this.mtbPass1, 1, 5);
            this.tblUserAccount.Controls.Add(this.tbUsername, 1, 4);
            this.tblUserAccount.Location = new System.Drawing.Point(34, 467);
            this.tblUserAccount.Name = "tblUserAccount";
            this.tblUserAccount.RowCount = 10;
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblUserAccount.Size = new System.Drawing.Size(680, 312);
            this.tblUserAccount.TabIndex = 4;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(3, 279);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(90, 19);
            this.lblExpiryDate.TabIndex = 31;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(3, 213);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(77, 19);
            this.lblCardType.TabIndex = 30;
            this.lblCardType.Text = "Card Type";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(3, 184);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(54, 19);
            this.lblCardNumber.TabIndex = 29;
            this.lblCardNumber.Text = "Card #";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(3, 121);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(99, 19);
            this.lblUsername.TabIndex = 28;
            this.lblUsername.Text = "USERNAME";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(3, 90);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 19);
            this.lblPhone.TabIndex = 27;
            this.lblPhone.Text = "PHONE";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 19);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "PASSWORD";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(3, 0);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(104, 19);
            this.lblFname.TabIndex = 23;
            this.lblFname.Text = "FIRST NAME";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 19);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "EMAIL";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(3, 30);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 19);
            this.lblLastName.TabIndex = 25;
            this.lblLastName.Text = "LAST NAME";
            // 
            // lblCsv
            // 
            this.lblCsv.AutoSize = true;
            this.lblCsv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCsv.Location = new System.Drawing.Point(3, 245);
            this.lblCsv.Name = "lblCsv";
            this.lblCsv.Size = new System.Drawing.Size(40, 19);
            this.lblCsv.TabIndex = 32;
            this.lblCsv.Text = "CSV";
            // 
            // mtbExpiry
            // 
            this.mtbExpiry.Location = new System.Drawing.Point(236, 282);
            this.mtbExpiry.Mask = "00/00/0000";
            this.mtbExpiry.Name = "mtbExpiry";
            this.mtbExpiry.Size = new System.Drawing.Size(441, 22);
            this.mtbExpiry.TabIndex = 21;
            this.mtbExpiry.ValidatingType = typeof(System.DateTime);
            // 
            // cmbCardType
            // 
            this.cmbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.cmbCardType.Location = new System.Drawing.Point(236, 216);
            this.cmbCardType.MaxDropDownItems = 10;
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(441, 24);
            this.cmbCardType.TabIndex = 20;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(236, 187);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(441, 22);
            this.tbCardNumber.TabIndex = 19;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(236, 124);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(441, 22);
            this.tbUsername.TabIndex = 17;
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(236, 93);
            this.mtbTelephone.Mask = "(999) 000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(441, 22);
            this.mtbTelephone.TabIndex = 16;
            // 
            // mtbPass1
            // 
            this.mtbPass1.Location = new System.Drawing.Point(236, 156);
            this.mtbPass1.Name = "mtbPass1";
            this.mtbPass1.PasswordChar = '*';
            this.mtbPass1.Size = new System.Drawing.Size(441, 22);
            this.mtbPass1.TabIndex = 18;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(236, 63);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(441, 22);
            this.tbEmailAddress.TabIndex = 15;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(236, 33);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(441, 22);
            this.tbLastName.TabIndex = 14;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(236, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(441, 22);
            this.tbFirstName.TabIndex = 13;
            // 
            // tbCSV
            // 
            this.tbCSV.Location = new System.Drawing.Point(236, 248);
            this.tbCSV.Name = "tbCSV";
            this.tbCSV.Size = new System.Drawing.Size(441, 22);
            this.tbCSV.TabIndex = 33;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(808, 708);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(808, 523);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 855);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tblUserAccount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUserRecord);
            this.Controls.Add(this.gvUserAccountDatabase);
            this.Name = "frmModifyUser";
            this.Text = "frmModifyUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmModifyUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserAccountDatabase)).EndInit();
            this.tblUserAccount.ResumeLayout(false);
            this.tblUserAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvUserAccountDatabase;
        private System.Windows.Forms.Button btnEditUserRecord;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tblUserAccount;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCsv;
        private System.Windows.Forms.MaskedTextBox mtbExpiry;
        private System.Windows.Forms.ComboBox cmbCardType;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.MaskedTextBox mtbPass1;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbCSV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
    }
}