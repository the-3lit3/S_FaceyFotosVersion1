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
    public partial class frmRegisterationForm : Form
    {
        private readonly db_sfaceyFotos2Entities2 db_entity; 
        public frmRegisterationForm()
        {
            InitializeComponent();
              db_entity = new db_sfaceyFotos2Entities2();
            
        }

        private void btnRegisterSubmit_Click(object sender, EventArgs e)
        {
            frmLoginForm launchLogin = new frmLoginForm();
            launchLogin.Show();
            this.Hide();
        }

        private void frmRegisterationForm_Load(object sender, EventArgs e)
        {
            try
            {
                var newClient = new tb_userRegistration();
                var clientID = tbMemberID.Text;
                var fName = tbFirstName.Text;
                var lName = tbLastName.Text;
                var clientEmail = tbEmailAddress.Text;
                var clientPhone = mtbTelephone.Text;
                var cUser = tbUsername.Text;
                var cPass = mtbPass1.Text;
                var cCardNumber = tbCardNumber.Text;
                var CSV = tbCSV.Text;
                var cardExpiry = mtbExpiry.Text;

                var cardType = db_entity.tb_cardType.ToList();
                newClient.UserID = clientID;
                newClient.First_Name = fName;
                newClient.Last_Name = lName;
                newClient.Email_Address = clientEmail;
                newClient.Telephone = clientPhone;
                newClient.Username = cUser.Trim();
                newClient.Pass = cPass;
                newClient.Card_Number = cCardNumber;
                cmbCardType.DisplayMember = "Card_Type";
                cmbCardType.ValueMember = "Id";
                cmbCardType.DataSource = cardType;
                newClient.Card_TypeID = Convert.ToInt32(cmbCardType.SelectedValue);
                newClient.CSV_Number = Convert.ToInt32(CSV);
                newClient.Expiration_Date = DateTime.Parse(cardExpiry);
                db_entity.tb_userRegistration.Add(newClient);
                db_entity.SaveChanges();

                MessageBox.Show("Registration successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
