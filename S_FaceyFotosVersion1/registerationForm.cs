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
    public partial class frmRegisterationForm : Form
    {
        private readonly db_sfaceyFotos2Entities3 db_entity;

        public frmRegisterationForm()
        {
            InitializeComponent();
             db_entity = new db_sfaceyFotos2Entities3();
            
        }

        private void btnRegisterSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var newClient = new tb_userRegistration();
         
                var fName = tbFirstName.Text;
                var lName = tbLastName.Text;
                var clientEmail = tbEmailAddress.Text;
                var clientPhone = mtbTelephone.Text;
                
                var cUser = tbUsername.Text;
                var cPass = mtbPass1.Text;
                
                var cCardNumber = tbCardNumber.Text;
                var cType = (int)cmbCardType.SelectedValue;
                var CSV = tbCSV.Text;
                var cardExpiry = mtbExpiry.Text;

                newClient.First_Name = fName;
                newClient.Last_Name = lName;
                newClient.Email_Address = clientEmail;
                newClient.Telephone = clientPhone;
                newClient.Username = cUser.Trim();

                SHA256 sha = SHA256.Create();
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(cPass));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }
                var hashed_pass = sb.ToString();
                newClient.Pass = hashed_pass;
                newClient.Card_Number = cCardNumber;
                newClient.Card_TypeID = cType;
                newClient.CSV_Number = Convert.ToInt32(CSV);
                newClient.Expiration_Date = DateTime.Parse(cardExpiry);

                db_entity.tb_userRegistration.Add(newClient);
                db_entity.SaveChanges();
                //this.Refresh();

                MessageBox.Show("Registration successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmLoginForm launchLogin = new frmLoginForm();
                launchLogin.Show();
                this.Hide();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Critical error occured. Record failed.");
            }
            
        }

        private void frmRegisterationForm_Load(object sender, EventArgs e)
        {
            try
            {
                var cardType = db_entity.tb_cardType.ToList();
                cmbCardType.DisplayMember = "Card_Name";
                cmbCardType.ValueMember = "Id";
                cmbCardType.DataSource = cardType;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
