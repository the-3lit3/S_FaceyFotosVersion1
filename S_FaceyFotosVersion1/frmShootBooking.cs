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
    public partial class frmShootBooking : Form
    {
        private readonly db_sfaceyFotos2Entities3 db_entity;
        public frmShootBooking()
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();


        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            try
            {
                var newClient = new tb_bookingInfo();
                var fName = tbFname.Text;
                var lName = tbLname.Text;
                var clientEmail = tbEmailAdd.Text;
                var clientPhone = mtbTelephone.Text;
                var cCardNumber = tbCardNumber.Text;
                var cardT = (int)cmbCardType.SelectedValue;
                var CSV = tbCSV.Text;
                var cardExpiry = mtbExpiry.Text;
                var pkgID = (int)cmbPackageSelect.SelectedValue;
                var shootDate = dtShootDate.Value;
                var shootTimeID = (int)cmbShootTime.SelectedValue;
                var shootLocation = tbLocation.Text;
                var pkgInfo = db_entity.tb_packageType.FirstOrDefault(q => q.Id == pkgID);

                newClient.First_Name = fName;
                newClient.Last_Name = lName;
                newClient.Email_Address = clientEmail;
                newClient.Telephone = clientPhone;            
                newClient.Card_Number = cCardNumber;
                newClient.Card_TypeID = cardT;
                newClient.CSV_Number = Convert.ToInt32(CSV);
                newClient.Expiration_Date = DateTime.Parse(cardExpiry);
                newClient.Shoot_TimeID = shootTimeID;
                newClient.Shoot_Location = shootLocation;
                newClient.Shoot_Date = shootDate;
                newClient.Package_TypeID = pkgID;               
                newClient.Total = pkgInfo.Unit_Cost;
                newClient.Deposit = pkgInfo.Unit_Cost * 0.5m;                               
                tbUnitCost.Text = pkgInfo.Unit_Cost.ToString();
                tbDeposit.Text = newClient.Deposit.ToString();
                tbTotal.Text = newClient.Total.ToString();              

                db_entity.tb_bookingInfo.Add(newClient);              
                db_entity.SaveChanges();

                MessageBox.Show("Shoot successfully booked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Operation Failed.");
            }
            
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLoginForm launchLogin = new frmLoginForm();
            launchLogin.Show();
            this.Hide();
        }

        private void frmShootBooking_Load(object sender, EventArgs e)
        {
            try
            {
                //Populate the card type data field
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

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFname.Clear();
            tbLname.Clear();
            tbEmailAdd.Clear();
            mtbTelephone.Clear();
            tbCardNumber.Clear();
            cmbCardType.SelectedIndex = 0;
            tbCSV.Clear();
            mtbExpiry.Clear();
            cmbPackageSelect.SelectedIndex = 0;
            dtShootDate.ResetText();
            cmbShootTime.SelectedIndex = 0;
            tbLocation.Clear();
            cmbPackageSelect.SelectedIndex = 0;
            tbUnitCost.Clear();
            tbDeposit.Clear();
            tbTotal.Clear();

        }
    }
}
