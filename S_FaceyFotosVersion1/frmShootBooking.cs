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
        private readonly db_sfaceyFotos2Entities2 db_entity;
        public frmShootBooking()
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities2();


        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            try
            {
                var newClient = new tb_personalData2();
                var fName = tbFname.Text;
                var lName = tbLname.Text;
                var clientEmail = tbEmailAdd.Text;
                var clientPhone = mtbTelephone.Text;
                var cCardNumber = tbCardNumber.Text;
                var CSV = tbCSV.Text;
                var cardExpiry = mtbExpiry.Text;
                var pkgID = Convert.ToInt32(cmbCardType.SelectedValue);
                var shootDate = dtShootDate.Value;
                var shootTimeID = Convert.ToInt32(cmbShootTime.Text);
                var shootLocation = tbLocation.Text;
            
                newClient.First_Name = fName;
                newClient.Last_Name = lName;
                newClient.Email_Address = clientEmail;
                newClient.Telephone = clientPhone;            
                newClient.Card_Number = cCardNumber;
                newClient.Card_TypeID = Convert.ToInt32(cmbCardType.SelectedValue);
                newClient.CSV_Number = Convert.ToInt32(CSV);
                newClient.Expiration_Date = DateTime.Parse(cardExpiry);
                newClient.Package_TypeID = pkgID;
                newClient.Shoot_Date = shootDate;
                newClient.Shoot_TimeID = shootTimeID;
                newClient.Shoot_Location = shootLocation;

                if(pkgID == 1)
                {
                    double unitCost = 15000.00;
                    double deposit = unitCost / 2;
                    //double Taxes = unitCost * 0.165;
                    double Total = unitCost;

                    tbUnitCost.Text = unitCost.ToString();
                    tbDeposit.Text = deposit.ToString();
                    tbTotal.Text = Total.ToString();
                    //lblUnitCostDisplay.Text = unitCost.ToString();
                }
                if (pkgID == 2)
                {
                    double unitCost = 25000.00;
                    double deposit = unitCost / 2;
                    //double Taxes = unitCost * 0.165;
                    double Total = unitCost;

                    tbUnitCost.Text = unitCost.ToString();
                    tbDeposit.Text = deposit.ToString();
                    tbTotal.Text = Total.ToString();
                }
                if (pkgID == 3)
                {
                    double unitCost = 40000.00;
                    double deposit = unitCost / 2;
                    //double Taxes = unitCost * 0.165;
                    double Total = unitCost;

                    tbUnitCost.Text = unitCost.ToString();
                    tbDeposit.Text = deposit.ToString();
                    tbTotal.Text = Total.ToString();
                }
                var uCost = Convert.ToDouble(tbUnitCost.Text);
                var getDeposit = Convert.ToDouble(tbDeposit.Text);
                var getTotal= Convert.ToDouble(tbTotal.Text);

                newClient.Unit_Cost = (Decimal)uCost;
                newClient.Deposit = (Decimal)getDeposit;
                newClient.Total = (Decimal)getTotal;

                db_entity.tb_personalData2.Add(newClient);
                db_entity.SaveChanges();
                this.Refresh();

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
            //Populate the card type data field
            var cardType = db_entity.tb_cardType.ToList();
            cmbCardType.DisplayMember = "Card_Type";
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

        }
    }
}
