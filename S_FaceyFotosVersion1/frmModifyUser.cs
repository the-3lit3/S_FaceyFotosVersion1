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
        private readonly bool isEditMode;
        public frmModifyUser()
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();            
        }
        public frmModifyUser(tb_userRegistration editUserRecord)
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();
            isEditMode = false;
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
            var id = (int)gvUserAccountDatabase.SelectedRows[0].Cells["Id"].Value;
            var getUser = db_entity.tb_userRegistration.FirstOrDefault(q => q.Id == id);
            this.populateForm(getUser); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
