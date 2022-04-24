using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
                
                SHA256 sha = SHA256.Create();
                var frmUn = tbUsername.Text.Trim();
                var frmPs = tbPassword.Text;
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(frmPs));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }
                var hashed_pass = sb.ToString();
                

                var user = db_entity.tb_userRegistration.FirstOrDefault(getUser => getUser.Username == frmUn && getUser.Pass == hashed_pass);
                if(user == null)
                {
                    MessageBox.Show("Invalid login credentials.\n\rEnter correct credentials or\n\rregister an account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Login Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLaunchPad openLaunch = new frmLaunchPad();
                    openLaunch.Show();
                    this.Hide();         
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegisterationForm shwFrm = new frmRegisterationForm();
            shwFrm.Show();
            this.Hide();
        }
    }
}
