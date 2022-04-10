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
            MessageBox.Show("Coming back to finish this tomorrow.", "Information",  MessageBoxButtons.OK, MessageBoxIcon.Information);
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
