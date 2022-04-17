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
    public partial class frmLoginForm : Form
    {
        private readonly db_sfaceyFotos2Entities3 db_entity;
        
        public frmLoginForm()
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();

        }

        private void btnLoginMain_Click(object sender, EventArgs e)
        {
            
            try
            {
                var frmUn = tbUsername.Text.Trim();
                var frmPs = tbPassword.Text;

                var user = db_entity.tb_userRegistration.FirstOrDefault(getUser => getUser.Username == frmUn);
                if(user == null)
                {
                    MessageBox.Show("Invalid login credentials.\n\rEnter correct credentials or\n\rregister an account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Login Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmShootBooking launchBooking = new frmShootBooking();
                    launchBooking.Show();
                    this.Hide();         
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                
        }

        private void linkedRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegisterationForm shwFrm = new frmRegisterationForm();
            shwFrm.Show();
            this.Hide();
        }
    }
}
