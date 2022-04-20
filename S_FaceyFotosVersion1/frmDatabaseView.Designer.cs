namespace S_FaceyFotosVersion1
{
    partial class frmDatabaseView
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
            this.lblRegistrationForm = new System.Windows.Forms.Label();
            this.gridFotoDBview = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnLoadBooking = new System.Windows.Forms.Button();
            this.btnModifyRecord = new System.Windows.Forms.Button();
            this.btnUserRecords = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFotoDBview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistrationForm
            // 
            this.lblRegistrationForm.AutoSize = true;
            this.lblRegistrationForm.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationForm.Location = new System.Drawing.Point(263, 50);
            this.lblRegistrationForm.Name = "lblRegistrationForm";
            this.lblRegistrationForm.Size = new System.Drawing.Size(499, 34);
            this.lblRegistrationForm.TabIndex = 3;
            this.lblRegistrationForm.Text = "S FACEY FOTOS DATASHEET";
            // 
            // gridFotoDBview
            // 
            this.gridFotoDBview.AllowUserToAddRows = false;
            this.gridFotoDBview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFotoDBview.Location = new System.Drawing.Point(40, 97);
            this.gridFotoDBview.Name = "gridFotoDBview";
            this.gridFotoDBview.RowHeadersWidth = 51;
            this.gridFotoDBview.RowTemplate.Height = 24;
            this.gridFotoDBview.Size = new System.Drawing.Size(1328, 353);
            this.gridFotoDBview.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1522, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnLoadBooking
            // 
            this.btnLoadBooking.Location = new System.Drawing.Point(113, 461);
            this.btnLoadBooking.Name = "btnLoadBooking";
            this.btnLoadBooking.Size = new System.Drawing.Size(151, 49);
            this.btnLoadBooking.TabIndex = 6;
            this.btnLoadBooking.Text = "Load Booking Records";
            this.btnLoadBooking.UseVisualStyleBackColor = true;
            this.btnLoadBooking.Click += new System.EventHandler(this.btnLoadBooking_Click);
            // 
            // btnModifyRecord
            // 
            this.btnModifyRecord.Location = new System.Drawing.Point(458, 461);
            this.btnModifyRecord.Name = "btnModifyRecord";
            this.btnModifyRecord.Size = new System.Drawing.Size(128, 49);
            this.btnModifyRecord.TabIndex = 7;
            this.btnModifyRecord.Text = "Modify";
            this.btnModifyRecord.UseVisualStyleBackColor = true;
            this.btnModifyRecord.Click += new System.EventHandler(this.btnModifyRecord_Click);
            // 
            // btnUserRecords
            // 
            this.btnUserRecords.Location = new System.Drawing.Point(300, 461);
            this.btnUserRecords.Name = "btnUserRecords";
            this.btnUserRecords.Size = new System.Drawing.Size(120, 49);
            this.btnUserRecords.TabIndex = 8;
            this.btnUserRecords.Text = "Load User Records";
            this.btnUserRecords.UseVisualStyleBackColor = true;
            this.btnUserRecords.Click += new System.EventHandler(this.btnUserRecords_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(626, 461);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 49);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(780, 461);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 49);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmDatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 535);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUserRecords);
            this.Controls.Add(this.btnModifyRecord);
            this.Controls.Add(this.btnLoadBooking);
            this.Controls.Add(this.gridFotoDBview);
            this.Controls.Add(this.lblRegistrationForm);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmDatabaseView";
            this.Text = "S Facey Fotos Database";
            ((System.ComponentModel.ISupportInitialize)(this.gridFotoDBview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrationForm;
        private System.Windows.Forms.DataGridView gridFotoDBview;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnLoadBooking;
        private System.Windows.Forms.Button btnModifyRecord;
        private System.Windows.Forms.Button btnUserRecords;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogout;
    }
}