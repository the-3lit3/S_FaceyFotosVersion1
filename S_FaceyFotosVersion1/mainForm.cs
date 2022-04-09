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
       private frmRegisterationForm registrationForm;
        public frmMainForm()
        {
            InitializeComponent();
            registrationForm = new frmRegisterationForm();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registrationForm.Show();
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLoginForm showForm = new frmLoginForm();
            showForm.Show();
            this.Hide();
        }
    }
}
