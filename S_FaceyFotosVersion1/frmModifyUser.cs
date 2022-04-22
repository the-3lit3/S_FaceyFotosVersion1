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
    public partial class frmModifyUser : Form
    {
        private readonly db_sfaceyFotos2Entities3 db_entity;
        public frmModifyUser()
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();            
        }
        public frmModifyUser(tb_userRegistration editUserRecord)
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();
            populateForm(editUserRecord);
        }

        private void populateForm(tb_userRegistration newUserInfo)
        {
            tbFirstName.Text = newUserInfo.First_Name;
            tbLastName.Text = newUserInfo.Last_Name;
            tbEmailAddress.Text = newUserInfo.Email_Address;
            mtbTelephone.Text = newUserInfo.Telephone;
            
            tbUsername.Text = newUserInfo.Username;
            mtbPass1.Text = newUserInfo.Pass;           
            tbCardNumber.Text = newUserInfo.Card_Number;
            cmbCardType.SelectedValue = newUserInfo.Card_TypeID;
            tbCSV.Text = newUserInfo.CSV_Number.ToString();
            mtbExpiry.Text = newUserInfo.Expiration_Date.ToString("MM/dd/yyyy");
        }

        private void frmModifyUser_Load(object sender, EventArgs e)
        {
            var userAccounts = db_entity.tb_userRegistration.Select(q => new
            {
                ID = q.Id,
                FIRST_NAME = q.First_Name,
                LAST_NAME = q.Last_Name,
                EMAIL = q.Email_Address,
                TELEPHONE = q.Telephone,
                USERNAME = q.Username,
                PASSWORD = q.Pass,
                CARD_NUMBER = q.Card_Number,
                CARD_TYPE = q.tb_cardType.Card_Name,
                CSV = q.CSV_Number,
                EXPIRY = q.Expiration_Date
            }).ToList();

            var cardType = db_entity.tb_cardType.ToList();
            cmbCardType.DisplayMember = "Card_Name";
            cmbCardType.ValueMember = "Id";
            cmbCardType.DataSource = cardType;

            gvUserAccountDatabase.DataSource = userAccounts;
            gvUserAccountDatabase.Columns[0].Visible = false;
            gvUserAccountDatabase.Columns[1].HeaderText = "FIRST NAME ";
            gvUserAccountDatabase.Columns[2].HeaderText = "LAST NAME";
            gvUserAccountDatabase.Columns[3].HeaderText = "EMAIL";
            gvUserAccountDatabase.Columns[4].HeaderText = "TELEPHONE";
            gvUserAccountDatabase.Columns[5].HeaderText = "USERNAME";
            gvUserAccountDatabase.Columns[6].HeaderText = "PASSWORD";
            gvUserAccountDatabase.Columns[7].HeaderText = "CARD #";
            gvUserAccountDatabase.Columns[8].HeaderText = "CARD TYPE";
            gvUserAccountDatabase.Columns[9].HeaderText = "CSV";
            gvUserAccountDatabase.Columns[10].HeaderText = "EXPIRY DATE";
        }

        private void btnEditUserRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserAccountDatabase.SelectedRows[0].Cells["Id"].Value;
                var getUser = db_entity.tb_userRegistration.FirstOrDefault(q => q.Id == id);
                this.populateForm(getUser);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " User not found!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                newClient.Username = cUser;
                newClient.Pass = cPass;
                newClient.Card_Number = cCardNumber;
                newClient.Card_TypeID = cType;
                newClient.CSV_Number = Convert.ToInt32(CSV);
                newClient.Expiration_Date = DateTime.Parse(cardExpiry);

                db_entity.tb_userRegistration.Add(newClient);
                //db_entity.tb_userRegistration.
                db_entity.SaveChanges();

                var userAccounts = db_entity.tb_userRegistration.Select(q => new
                {
                    ID = q.Id,
                    FIRST_NAME = q.First_Name,
                    LAST_NAME = q.Last_Name,
                    EMAIL = q.Email_Address,
                    TELEPHONE = q.Telephone,
                    USERNAME = q.Username,
                    PASSWORD = q.Pass,
                    CARD_NUMBER = q.Card_Number,
                    CARD_TYPE = q.tb_cardType.Card_Name,
                    CSV = q.CSV_Number,
                    EXPIRY = q.Expiration_Date
                }).ToList();

                var cardType = db_entity.tb_cardType.ToList();
                cmbCardType.DisplayMember = "Card_Name";
                cmbCardType.ValueMember = "Id";
                cmbCardType.DataSource = cardType;

                gvUserAccountDatabase.DataSource = userAccounts;
                gvUserAccountDatabase.Columns[0].Visible = false;
                gvUserAccountDatabase.Columns[1].HeaderText = "FIRST NAME ";
                gvUserAccountDatabase.Columns[2].HeaderText = "LAST NAME";
                gvUserAccountDatabase.Columns[3].HeaderText = "EMAIL";
                gvUserAccountDatabase.Columns[4].HeaderText = "TELEPHONE";
                gvUserAccountDatabase.Columns[5].HeaderText = "USERNAME";
                gvUserAccountDatabase.Columns[6].HeaderText = "PASSWORD";
                gvUserAccountDatabase.Columns[7].HeaderText = "CARD #";
                gvUserAccountDatabase.Columns[8].HeaderText = "CARD TYPE";
                gvUserAccountDatabase.Columns[9].HeaderText = "CSV";
                gvUserAccountDatabase.Columns[10].HeaderText = "EXPIRY DATE";

                MessageBox.Show("User record updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                tbFirstName.Clear();
                tbLastName.Clear();
                tbEmailAddress.Clear();
                mtbTelephone.Clear();
                tbUsername.Clear();
                mtbPass1.Clear(); ;
                tbCardNumber.Clear();
                cmbCardType.SelectedIndex = 0;
                tbCSV.Clear();
                mtbExpiry.Clear();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Critical error occured. User record failed to update.");
            }        
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserAccountDatabase.SelectedRows[0].Cells["Id"].Value;
                var deleteUser = db_entity.tb_userRegistration.FirstOrDefault(q => q.Id == id);

                db_entity.tb_userRegistration.Remove(deleteUser);
                db_entity.SaveChanges();                

                var userAccounts = db_entity.tb_userRegistration.Select(q => new
                {
                    ID = q.Id,
                    FIRST_NAME = q.First_Name,
                    LAST_NAME = q.Last_Name,
                    EMAIL = q.Email_Address,
                    TELEPHONE = q.Telephone,
                    USERNAME = q.Username,
                    PASSWORD = q.Pass,
                    CARD_NUMBER = q.Card_Number,
                    CARD_TYPE = q.tb_cardType.Card_Name,
                    CSV = q.CSV_Number,
                    EXPIRY = q.Expiration_Date
                }).ToList();

                var cardType = db_entity.tb_cardType.ToList();
                cmbCardType.DisplayMember = "Card_Name";
                cmbCardType.ValueMember = "Id";
                cmbCardType.DataSource = cardType;

                gvUserAccountDatabase.DataSource = userAccounts;
                gvUserAccountDatabase.Columns[0].Visible = false;
                gvUserAccountDatabase.Columns[1].HeaderText = "FIRST NAME ";
                gvUserAccountDatabase.Columns[2].HeaderText = "LAST NAME";
                gvUserAccountDatabase.Columns[3].HeaderText = "EMAIL";
                gvUserAccountDatabase.Columns[4].HeaderText = "TELEPHONE";
                gvUserAccountDatabase.Columns[5].HeaderText = "USERNAME";
                gvUserAccountDatabase.Columns[6].HeaderText = "PASSWORD";
                gvUserAccountDatabase.Columns[7].HeaderText = "CARD #";
                gvUserAccountDatabase.Columns[8].HeaderText = "CARD TYPE";
                gvUserAccountDatabase.Columns[9].HeaderText = "CSV";
                gvUserAccountDatabase.Columns[10].HeaderText = "EXPIRY DATE";
                
                MessageBox.Show("User record deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Failed to delete record.");
            }
            
        }
    }    
}
