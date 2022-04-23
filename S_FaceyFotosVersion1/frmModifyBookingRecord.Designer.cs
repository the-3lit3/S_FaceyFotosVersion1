namespace S_FaceyFotosVersion1
{
    partial class frmModifyBookingRecord
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
            this.lblRegisteredUsers = new System.Windows.Forms.Label();
            this.lblEditFormId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tblUserAccount = new System.Windows.Forms.TableLayoutPanel();
            this.tbCSV = new System.Windows.Forms.TextBox();
            this.cmbCardType = new System.Windows.Forms.ComboBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardType = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblCsv = new System.Windows.Forms.Label();
            this.mtbExpiry = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUserRecord = new System.Windows.Forms.Button();
            this.gvUserAccountDatabase = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbPackageSelect = new System.Windows.Forms.ComboBox();
            this.lblPkg = new System.Windows.Forms.Label();
            this.cmbShootTime = new System.Windows.Forms.ComboBox();
            this.lblShootTime = new System.Windows.Forms.Label();
            this.lblShootDate = new System.Windows.Forms.Label();
            this.dtShootDate = new System.Windows.Forms.DateTimePicker();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.tbUnitCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.tblUserAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserAccountDatabase)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegisteredUsers
            // 
            this.lblRegisteredUsers.AutoSize = true;
            this.lblRegisteredUsers.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredUsers.Location = new System.Drawing.Point(417, 9);
            this.lblRegisteredUsers.Name = "lblRegisteredUsers";
            this.lblRegisteredUsers.Size = new System.Drawing.Size(1021, 90);
            this.lblRegisteredUsers.TabIndex = 17;
            this.lblRegisteredUsers.Text = "BOOKED PHOTOSHOOTS";
            // 
            // lblEditFormId
            // 
            this.lblEditFormId.AutoSize = true;
            this.lblEditFormId.Location = new System.Drawing.Point(1026, 443);
            this.lblEditFormId.Name = "lblEditFormId";
            this.lblEditFormId.Size = new System.Drawing.Size(0, 16);
            this.lblEditFormId.TabIndex = 16;
            this.lblEditFormId.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(738, 788);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1190, 788);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // tblUserAccount
            // 
            this.tblUserAccount.ColumnCount = 2;
            this.tblUserAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.28571F));
            this.tblUserAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.71429F));
            this.tblUserAccount.Controls.Add(this.lblFname, 0, 0);
            this.tblUserAccount.Controls.Add(this.lblLastName, 0, 1);
            this.tblUserAccount.Controls.Add(this.tbLastName, 1, 1);
            this.tblUserAccount.Controls.Add(this.tbFirstName, 1, 0);
            this.tblUserAccount.Controls.Add(this.lblEmail, 0, 2);
            this.tblUserAccount.Controls.Add(this.lblPhone, 0, 3);
            this.tblUserAccount.Controls.Add(this.tbEmailAddress, 1, 2);
            this.tblUserAccount.Controls.Add(this.mtbTelephone, 1, 3);
            this.tblUserAccount.Controls.Add(this.lblCardNumber, 0, 4);
            this.tblUserAccount.Controls.Add(this.lblCardType, 0, 5);
            this.tblUserAccount.Controls.Add(this.lblCsv, 0, 6);
            this.tblUserAccount.Controls.Add(this.lblExpiryDate, 0, 7);
            this.tblUserAccount.Controls.Add(this.tbCardNumber, 1, 4);
            this.tblUserAccount.Controls.Add(this.cmbCardType, 1, 5);
            this.tblUserAccount.Controls.Add(this.tbCSV, 1, 6);
            this.tblUserAccount.Controls.Add(this.mtbExpiry, 1, 7);
            this.tblUserAccount.Location = new System.Drawing.Point(231, 464);
            this.tblUserAccount.Name = "tblUserAccount";
            this.tblUserAccount.RowCount = 8;
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblUserAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblUserAccount.Size = new System.Drawing.Size(680, 270);
            this.tblUserAccount.TabIndex = 13;
            // 
            // tbCSV
            // 
            this.tbCSV.Location = new System.Drawing.Point(236, 201);
            this.tbCSV.Name = "tbCSV";
            this.tbCSV.Size = new System.Drawing.Size(441, 22);
            this.tbCSV.TabIndex = 33;
            // 
            // cmbCardType
            // 
            this.cmbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.cmbCardType.Location = new System.Drawing.Point(236, 168);
            this.cmbCardType.MaxDropDownItems = 10;
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(441, 24);
            this.cmbCardType.TabIndex = 20;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(3, 231);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(90, 19);
            this.lblExpiryDate.TabIndex = 31;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(236, 135);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(441, 22);
            this.tbCardNumber.TabIndex = 19;
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(3, 165);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(77, 19);
            this.lblCardType.TabIndex = 30;
            this.lblCardType.Text = "Card Type";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(3, 132);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(54, 19);
            this.lblCardNumber.TabIndex = 29;
            this.lblCardNumber.Text = "Card #";
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
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(3, 33);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 19);
            this.lblLastName.TabIndex = 25;
            this.lblLastName.Text = "LAST NAME";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(236, 36);
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
            // lblCsv
            // 
            this.lblCsv.AutoSize = true;
            this.lblCsv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCsv.Location = new System.Drawing.Point(3, 198);
            this.lblCsv.Name = "lblCsv";
            this.lblCsv.Size = new System.Drawing.Size(40, 19);
            this.lblCsv.TabIndex = 32;
            this.lblCsv.Text = "CSV";
            // 
            // mtbExpiry
            // 
            this.mtbExpiry.Location = new System.Drawing.Point(236, 234);
            this.mtbExpiry.Mask = "00/00/0000";
            this.mtbExpiry.Name = "mtbExpiry";
            this.mtbExpiry.Size = new System.Drawing.Size(441, 22);
            this.mtbExpiry.TabIndex = 21;
            this.mtbExpiry.ValidatingType = typeof(System.DateTime);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 66);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 19);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "EMAIL";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(3, 99);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 19);
            this.lblPhone.TabIndex = 27;
            this.lblPhone.Text = "PHONE";
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(236, 69);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(441, 22);
            this.tbEmailAddress.TabIndex = 15;
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(236, 102);
            this.mtbTelephone.Mask = "(999) 000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(441, 22);
            this.mtbTelephone.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1041, 788);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(893, 788);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUserRecord
            // 
            this.btnEditUserRecord.Location = new System.Drawing.Point(585, 788);
            this.btnEditUserRecord.Name = "btnEditUserRecord";
            this.btnEditUserRecord.Size = new System.Drawing.Size(75, 23);
            this.btnEditUserRecord.TabIndex = 10;
            this.btnEditUserRecord.Text = "Edit";
            this.btnEditUserRecord.UseVisualStyleBackColor = true;
            this.btnEditUserRecord.Click += new System.EventHandler(this.btnEditUserRecord_Click);
            // 
            // gvUserAccountDatabase
            // 
            this.gvUserAccountDatabase.AllowUserToAddRows = false;
            this.gvUserAccountDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserAccountDatabase.Location = new System.Drawing.Point(26, 102);
            this.gvUserAccountDatabase.Name = "gvUserAccountDatabase";
            this.gvUserAccountDatabase.RowHeadersWidth = 51;
            this.gvUserAccountDatabase.RowTemplate.Height = 24;
            this.gvUserAccountDatabase.Size = new System.Drawing.Size(1886, 325);
            this.gvUserAccountDatabase.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.48485F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.51515F));
            this.tableLayoutPanel1.Controls.Add(this.tbDeposit, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbLocation, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblLocation, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblShootDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPkg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblShootTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUnitCost, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtShootDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbShootTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbPackageSelect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbTotal, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbUnitCost, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(995, 467);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 267);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(257, 117);
            this.tbLocation.Multiline = true;
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(400, 22);
            this.tbLocation.TabIndex = 26;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(3, 114);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(58, 16);
            this.lblLocation.TabIndex = 22;
            this.lblLocation.Text = "Location";
            // 
            // cmbPackageSelect
            // 
            this.cmbPackageSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackageSelect.FormattingEnabled = true;
            this.cmbPackageSelect.Location = new System.Drawing.Point(257, 3);
            this.cmbPackageSelect.Name = "cmbPackageSelect";
            this.cmbPackageSelect.Size = new System.Drawing.Size(400, 24);
            this.cmbPackageSelect.TabIndex = 23;
            // 
            // lblPkg
            // 
            this.lblPkg.AutoSize = true;
            this.lblPkg.Location = new System.Drawing.Point(3, 0);
            this.lblPkg.Name = "lblPkg";
            this.lblPkg.Size = new System.Drawing.Size(62, 16);
            this.lblPkg.TabIndex = 21;
            this.lblPkg.Text = "Package";
            // 
            // cmbShootTime
            // 
            this.cmbShootTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShootTime.FormattingEnabled = true;
            this.cmbShootTime.Items.AddRange(new object[] {
            "6:00 A.M",
            "7:00 A.M",
            "8:00 A.M",
            "9:00 A.M",
            "10:00 A.M",
            "11:00 A.M",
            "12:00 P.M",
            "1:00 P.M",
            "2:00 P.M",
            "3:00 P.M",
            "4:00 P.M",
            "5:00 P.M",
            "6:00 P.M"});
            this.cmbShootTime.Location = new System.Drawing.Point(257, 79);
            this.cmbShootTime.Name = "cmbShootTime";
            this.cmbShootTime.Size = new System.Drawing.Size(400, 24);
            this.cmbShootTime.TabIndex = 25;
            // 
            // lblShootTime
            // 
            this.lblShootTime.AutoSize = true;
            this.lblShootTime.Location = new System.Drawing.Point(3, 76);
            this.lblShootTime.Name = "lblShootTime";
            this.lblShootTime.Size = new System.Drawing.Size(76, 16);
            this.lblShootTime.TabIndex = 20;
            this.lblShootTime.Text = "Shoot Time";
            // 
            // lblShootDate
            // 
            this.lblShootDate.AutoSize = true;
            this.lblShootDate.Location = new System.Drawing.Point(3, 38);
            this.lblShootDate.Name = "lblShootDate";
            this.lblShootDate.Size = new System.Drawing.Size(74, 16);
            this.lblShootDate.TabIndex = 19;
            this.lblShootDate.Text = "Shoot Date";
            // 
            // dtShootDate
            // 
            this.dtShootDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtShootDate.Location = new System.Drawing.Point(257, 41);
            this.dtShootDate.Name = "dtShootDate";
            this.dtShootDate.Size = new System.Drawing.Size(400, 22);
            this.dtShootDate.TabIndex = 24;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(257, 231);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(400, 22);
            this.tbTotal.TabIndex = 35;
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(257, 193);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.ReadOnly = true;
            this.tbDeposit.Size = new System.Drawing.Size(400, 22);
            this.tbDeposit.TabIndex = 34;
            // 
            // tbUnitCost
            // 
            this.tbUnitCost.Location = new System.Drawing.Point(257, 155);
            this.tbUnitCost.Name = "tbUnitCost";
            this.tbUnitCost.ReadOnly = true;
            this.tbUnitCost.Size = new System.Drawing.Size(400, 22);
            this.tbUnitCost.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Total Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Deposit";
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Location = new System.Drawing.Point(3, 152);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(60, 16);
            this.lblUnitCost.TabIndex = 27;
            this.lblUnitCost.Text = "Unit Cost";
            // 
            // frmModifyBookingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 845);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblRegisteredUsers);
            this.Controls.Add(this.lblEditFormId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tblUserAccount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUserRecord);
            this.Controls.Add(this.gvUserAccountDatabase);
            this.Name = "frmModifyBookingRecord";
            this.Text = "frmModifyBookingRecord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmModifyBookingRecord_Load);
            this.tblUserAccount.ResumeLayout(false);
            this.tblUserAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserAccountDatabase)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisteredUsers;
        private System.Windows.Forms.Label lblEditFormId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tblUserAccount;
        private System.Windows.Forms.TextBox tbCSV;
        private System.Windows.Forms.ComboBox cmbCardType;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblCsv;
        private System.Windows.Forms.MaskedTextBox mtbExpiry;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUserRecord;
        private System.Windows.Forms.DataGridView gvUserAccountDatabase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DateTimePicker dtShootDate;
        private System.Windows.Forms.Label lblShootDate;
        private System.Windows.Forms.Label lblPkg;
        private System.Windows.Forms.Label lblShootTime;
        private System.Windows.Forms.ComboBox cmbPackageSelect;
        private System.Windows.Forms.ComboBox cmbShootTime;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.TextBox tbUnitCost;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUnitCost;
    }
}