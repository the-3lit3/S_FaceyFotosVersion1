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
    public partial class frmDatabaseView : Form
    {
        private db_sfaceyFotos2Entities3 db_entity;
        public frmDatabaseView()
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();


        }

        public frmDatabaseView(tb_userRegistration editUser)
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();

        }

        private void btnLoadBooking_Click(object sender, EventArgs e)
        {
            //var bookingRecords = db_entity.tb_bookingInfo.ToList();This a sekect * query
            var bookingRecords = db_entity.tb_bookingInfo.Select(q => new
            {
                ID = q.Id,
                FIRST_NAME = q.First_Name,
                LAST_NAME = q.Last_Name,
                EMAIL = q.Email_Address,
                TELEPHONE = q.Telephone,
                CARD_NUMBER = q.Card_Number,
                CARD_TYPE = q.tb_cardType.Card_Name,
                CSV = q.CSV_Number,
                EXPIRY = q.Expiration_Date,
                PACKAGE_TYPE = q.tb_packageType.Package_Name
                ,SHOOT_DATE = q.Shoot_Date,
                SHOOT_TIME = q.tb_shootTime.Shoot_Time,
                LOCATION = q.Shoot_Location,
                DEPOSIT = q.Deposit,
                TOTAL = q.Total
            }).ToList();

            gridFotoDBview.DataSource = bookingRecords;
            gridFotoDBview.Columns[0].HeaderText = "ID";
            gridFotoDBview.Columns[1].HeaderText = "FIRST NAME ";
            gridFotoDBview.Columns[2].HeaderText = "LAST NAME";
            gridFotoDBview.Columns[3].HeaderText = "EMAIL";
            gridFotoDBview.Columns[4].HeaderText = "TELEPHONE";
            gridFotoDBview.Columns[5].HeaderText = "CARD #";
            gridFotoDBview.Columns[6].HeaderText = "CARD TYPE";
            gridFotoDBview.Columns[7].HeaderText = "CSV";
            gridFotoDBview.Columns[8].HeaderText = "EXPIRY DATE";
            gridFotoDBview.Columns[9].HeaderText = "PACKAGE TYPE";            
            gridFotoDBview.Columns[11].HeaderText = "SHOOT DATE";
            gridFotoDBview.Columns[12].HeaderText = "SHOOT TIME";
            gridFotoDBview.Columns[10].HeaderText = "LOCATION";
            gridFotoDBview.Columns[13].HeaderText = "DEPOSIT";
            gridFotoDBview.Columns[14].HeaderText = "TOTAL";

        }

        private void btnUserRecords_Click(object sender, EventArgs e)
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

            gridFotoDBview.DataSource = userAccounts;
            gridFotoDBview.Columns[0].Visible = false;
            gridFotoDBview.Columns[1].HeaderText = "FIRST NAME ";
            gridFotoDBview.Columns[2].HeaderText = "LAST NAME";
            gridFotoDBview.Columns[3].HeaderText = "EMAIL";
            gridFotoDBview.Columns[4].HeaderText = "TELEPHONE";
            gridFotoDBview.Columns[5].HeaderText = "USERNAME";
            gridFotoDBview.Columns[6].HeaderText = "PASSWORD";
            gridFotoDBview.Columns[7].HeaderText = "CARD #";
            gridFotoDBview.Columns[8].HeaderText = "CARD TYPE";
            gridFotoDBview.Columns[9].HeaderText = "CSV";
            gridFotoDBview.Columns[10].HeaderText = "EXPIRY DATE";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var bookingRecords = db_entity.tb_userRegistration.Select(q => new
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

        }

        private void btnModifyRecord_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLoginForm launchLogin = new frmLoginForm();
            launchLogin.Show();
            this.Hide();
        }
    }
}
