namespace S_FaceyFotosVersion1
{
    partial class frmLaunchPad
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
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnModifyDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(137, 211);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(130, 49);
            this.btnViewData.TabIndex = 0;
            this.btnViewData.Text = "View Data Tables";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(409, 211);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(130, 49);
            this.btnCreateBooking.TabIndex = 1;
            this.btnCreateBooking.Text = "Book Shoot";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(545, 211);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 49);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnModifyDB
            // 
            this.btnModifyDB.Location = new System.Drawing.Point(273, 211);
            this.btnModifyDB.Name = "btnModifyDB";
            this.btnModifyDB.Size = new System.Drawing.Size(130, 49);
            this.btnModifyDB.TabIndex = 3;
            this.btnModifyDB.Text = "Modify Database Records";
            this.btnModifyDB.UseVisualStyleBackColor = true;
            this.btnModifyDB.Click += new System.EventHandler(this.btnModifyDB_Click);
            // 
            // frmLaunchPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifyDB);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.btnViewData);
            this.Name = "frmLaunchPad";
            this.Text = "frmLaunchPad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnModifyDB;
    }
}