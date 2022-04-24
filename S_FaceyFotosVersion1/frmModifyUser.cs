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
            db_entity = new db_sfaceyFotos2Entities3(); //Initialize Database connectivity object           
        }
        public frmModifyUser(tb_userRegistration editUserRecord)
        {
            //Overloaded Constructor for updating and deleting records
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();
            populateForm(editUserRecord);
        }

        private void populateForm(tb_userRegistration newUserInfo)
        {
            //Method to populate form fields when the user selects a row
            //to select it
            lblEditFormId.Text = newUserInfo.Id.ToString();
            tbFirstName.Text = newUserInfo.First_Name;
            tbLastName.Text = newUserInfo.Last_Name;
            tbEmailAddress.Text = newUserInfo.Email_Address;
            mtbTelephone.Text = newUserInfo.Telephone;            
            tbUsername.Text = newUserInfo.Username;//Username field is not editable
            mtbPass1.Text = newUserInfo.Pass;//Password fiels is not editable           
            tbCardNumber.Text = newUserInfo.Card_Number;
            cmbCardType.SelectedValue = newUserInfo.Card_TypeID;
            tbCSV.Text = newUserInfo.CSV_Number.ToString();
            mtbExpiry.Text = newUserInfo.Expiration_Date.ToString("MM/dd/yyyy");
        }

        private void frmModifyUser_Load(object sender, EventArgs e)
        {
            var userAccounts = db_entity.tb_userRegistration.Select(q => new
            {
                //Database query code 
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

            //Code to populate the dropdown box
            var cardType = db_entity.tb_cardType.ToList();
            cmbCardType.DisplayMember = "Card_Name";
            cmbCardType.ValueMember = "Id";
            cmbCardType.DataSource = cardType;

            //Code to draw and label the columns in the grid view
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
                //Code to query the database for a single record via ID value and column name
                var id = (int)gvUserAccountDatabase.SelectedRows[0].Cells["Id"].Value;
                var getUser = db_entity.tb_userRegistration.FirstOrDefault(q => q.Id == id);
                this.populateForm(getUser);//Loading the database entry into the form fields
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
            this.MdiParent.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Code to update the edited record
                var id = int.Parse(lblEditFormId.Text);
                var updateUser = db_entity.tb_userRegistration.FirstOrDefault(q => q.Id == id);
                
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

                updateUser.First_Name = fName;
                updateUser.Last_Name = lName;
                updateUser.Email_Address = clientEmail;
                updateUser.Telephone = clientPhone;
                updateUser.Username = cUser;
                updateUser.Pass = cPass;
                updateUser.Card_Number = cCardNumber;
                updateUser.Card_TypeID = cType;
                updateUser.CSV_Number = Convert.ToInt32(CSV);
                updateUser.Expiration_Date = DateTime.Parse(cardExpiry);
                db_entity.SaveChanges();
                
                //Because the Refresh() didnt work I copied and paste the refresh code here temporarily
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
                
                //Code to clear form fields after record update was successful
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
                //Code to query database for a single record
                //Delete the found record and save the changes made
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
