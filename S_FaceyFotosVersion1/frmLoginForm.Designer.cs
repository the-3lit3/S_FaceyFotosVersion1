namespace S_FaceyFotosVersion1
{
    partial class frmLoginForm
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLoginMain = new System.Windows.Forms.Button();
            this.linkedRegister = new System.Windows.Forms.LinkLabel();
            this.linkedPasswordRecovery = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblRegistrationForm
            // 
            this.lblRegistrationForm.AutoSize = true;
            this.lblRegistrationForm.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationForm.Location = new System.Drawing.Point(174, 9);
            this.lblRegistrationForm.Name = "lblRegistrationForm";
            this.lblRegistrationForm.Size = new System.Drawing.Size(401, 34);
            this.lblRegistrationForm.TabIndex = 1;
            this.lblRegistrationForm.Text = "S FACEY FOTOS LOGIN";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(362, 139);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(213, 22);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(362, 179);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(213, 22);
            this.tbPassword.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(177, 145);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 16);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "USERNAME";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(177, 185);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "PASSWORD";
            // 
            // btnLoginMain
            // 
            this.btnLoginMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoginMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginMain.Location = new System.Drawing.Point(430, 230);
            this.btnLoginMain.Name = "btnLoginMain";
            this.btnLoginMain.Size = new System.Drawing.Size(85, 32);
            this.btnLoginMain.TabIndex = 6;
            this.btnLoginMain.Text = "LOGIN";
            this.btnLoginMain.UseVisualStyleBackColor = false;
            this.btnLoginMain.Click += new System.EventHandler(this.btnLoginMain_Click);
            // 
            // linkedRegister
            // 
            this.linkedRegister.AutoSize = true;
            this.linkedRegister.Location = new System.Drawing.Point(177, 295);
            this.linkedRegister.Name = "linkedRegister";
            this.linkedRegister.Size = new System.Drawing.Size(58, 16);
            this.linkedRegister.TabIndex = 7;
            this.linkedRegister.TabStop = true;
            this.linkedRegister.Text = "Register";
            // 
            // linkedPasswordRecovery
            // 
            this.linkedPasswordRecovery.AutoSize = true;
            this.linkedPasswordRecovery.Location = new System.Drawing.Point(431, 295);
            this.linkedPasswordRecovery.Name = "linkedPasswordRecovery";
            this.linkedPasswordRecovery.Size = new System.Drawing.Size(144, 16);
            this.linkedPasswordRecovery.TabIndex = 8;
            this.linkedPasswordRecovery.TabStop = true;
            this.linkedPasswordRecovery.Text = "Forgot your password?";
            // 
            // frmLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkedPasswordRecovery);
            this.Controls.Add(this.linkedRegister);
            this.Controls.Add(this.btnLoginMain);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblRegistrationForm);
            this.Name = "frmLoginForm";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrationForm;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLoginMain;
        private System.Windows.Forms.LinkLabel linkedRegister;
        private System.Windows.Forms.LinkLabel linkedPasswordRecovery;
    }
}