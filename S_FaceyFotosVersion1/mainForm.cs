using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_FaceyFotosVersion1
{
    public partial class frmMainForm : Form
    {
       private readonly frmRegisterationForm registrationForm;
        private readonly frmLoginForm lgn;
        public frmMainForm()
        {
            InitializeComponent();
            registrationForm = new frmRegisterationForm(); 
            lgn = new frmLoginForm();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {            
            registrationForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            lgn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookingReviewConfirmationForm x = new bookingReviewConfirmationForm();
            x.Show();
        }

        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lgn.Close();
        }
    }
}
