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
    public partial class frmModifyBookingRecord : Form
    {
        private readonly db_sfaceyFotos2Entities3 db_entity;
        public frmModifyBookingRecord()
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();
        }

        public frmModifyBookingRecord(tb_bookingInfo editBookingRecord)
        {
            //Overloaded Constructor for updating and deleting records
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();
            populateForm(editBookingRecord);
        }

        private void populateForm(tb_bookingInfo editBookingRecord)
        {
            //Method to populate form fields when the user selects a row
            //to select it
            lblEditFormId.Text = editBookingRecord.Id.ToString();
            tbFirstName.Text = editBookingRecord.First_Name;
            tbLastName.Text = editBookingRecord.Last_Name;
            tbEmailAddress.Text = editBookingRecord.Email_Address;
            mtbTelephone.Text = editBookingRecord.Telephone;      
            tbCardNumber.Text = editBookingRecord.Card_Number;
            cmbCardType.SelectedValue = editBookingRecord.Card_TypeID;
            tbCSV.Text = editBookingRecord.CSV_Number.ToString();
            mtbExpiry.Text = editBookingRecord.Expiration_Date.ToString("MM/dd/yyyy");
            cmbPackageSelect.SelectedValue = editBookingRecord.Package_TypeID;
            dtShootDate.Value = editBookingRecord.Shoot_Date;
            cmbShootTime.SelectedValue = editBookingRecord.Shoot_TimeID;
            tbLocation.Text = editBookingRecord.Shoot_Location;
            tbUnitCost.Text = editBookingRecord.tb_packageType.Unit_Cost.ToString();
            tbDeposit.Text = editBookingRecord.Deposit.ToString();
            tbTotal.Text = editBookingRecord.Total.ToString();

        }

        private void frmModifyBookingRecord_Load(object sender, EventArgs e)
        {
            try
            {
                var userAccounts = db_entity.tb_bookingInfo.Select(q => new
                {
                    //Database query code 
                    ID = q.Id,
                    FIRST_NAME = q.First_Name,
                    LAST_NAME = q.Last_Name,
                    EMAIL = q.Email_Address,
                    TELEPHONE = q.Telephone,                    
                    CARD_NUMBER = q.Card_Number,
                    CARD_TYPE = q.tb_cardType.Card_Name,
                    CSV = q.CSV_Number,
                    EXPIRY = q.Expiration_Date,
                    PACKAGE_TYPE = q.tb_packageType.Package_Name,
                    SHOOT_DATE = q.Shoot_Date,
                    SHOOT_TIME = q.tb_shootTime.Shoot_Time,
                    LOCATION = q.Shoot_Location,
                    UNIT_COST = q.tb_packageType.Unit_Cost,
                    DEPOSIT = q.Deposit,
                    TOTAL = q.Total

                }).ToList();

                //Code to populate the dropdown box
                var cardType = db_entity.tb_cardType.ToList();
                cmbCardType.DisplayMember = "Card_Name";
                cmbCardType.ValueMember = "Id";
                cmbCardType.DataSource = cardType;

                
                //Populate the Shoot Package datafield
                var packageType = db_entity.tb_packageType.ToList();
                cmbPackageSelect.DisplayMember = "Package_Name";
                cmbPackageSelect.ValueMember = "Id";
                cmbPackageSelect.DataSource = packageType;



                //Populate the Shoot Time datafield 
                var shootTime = db_entity.tb_shootTime.ToList();
                cmbShootTime.DisplayMember = "Shoot_Time";
                cmbShootTime.ValueMember = "Id";
                cmbShootTime.DataSource = shootTime;

                //Code to draw and label the columns in the grid view
                gvUserAccountDatabase.DataSource = userAccounts;
                gvUserAccountDatabase.Columns[0].Visible = false;
                gvUserAccountDatabase.Columns[1].HeaderText = "FIRST NAME ";
                gvUserAccountDatabase.Columns[2].HeaderText = "LAST NAME";
                gvUserAccountDatabase.Columns[3].HeaderText = "EMAIL";
                gvUserAccountDatabase.Columns[4].HeaderText = "TELEPHONE";
                gvUserAccountDatabase.Columns[5].HeaderText = "CARD #";
                gvUserAccountDatabase.Columns[6].HeaderText = "CARD TYPE";
                gvUserAccountDatabase.Columns[7].HeaderText = "CSV";
                gvUserAccountDatabase.Columns[8].HeaderText = "EXPIRY DATE";
                gvUserAccountDatabase.Columns[9].HeaderText = "PACKAGE TYPE";
                gvUserAccountDatabase.Columns[10].HeaderText = "SHOOT DATE";
                gvUserAccountDatabase.Columns[11].HeaderText = "SHOOT TIME";
                gvUserAccountDatabase.Columns[12].HeaderText = "LOCATION";
                gvUserAccountDatabase.Columns[13].HeaderText = "UNIT COST";
                gvUserAccountDatabase.Columns[14].HeaderText = "DEPOSIT";
                gvUserAccountDatabase.Columns[15].HeaderText = "TOTAL";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditUserRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //Code to query the database for a single record via ID value and column name
                var id = (int)gvUserAccountDatabase.SelectedRows[0].Cells["Id"].Value;
                var getBookingRecord = db_entity.tb_bookingInfo.FirstOrDefault(q => q.Id == id);
                this.populateForm(getBookingRecord);//Loading the database entry into the form fields
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " User not found!");
            }
        }
    }
    
}
