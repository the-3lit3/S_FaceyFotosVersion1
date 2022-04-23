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
    public partial class frmLaunchPad : Form
    {
        private readonly db_sfaceyFotos2Entities3 db_entity;
        private frmDatabaseView launchDataGrid;
        private frmShootBooking launchShootForm;
        private frmLoginForm launchLoginForm;
        private frmModifyRecord launchModifyRec;
        public frmLaunchPad()
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();
            launchDataGrid = new frmDatabaseView();
            launchShootForm = new frmShootBooking();
            launchLoginForm = new frmLoginForm();
            launchModifyRec = new frmModifyRecord();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            launchDataGrid.Show();
            this.Hide();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            launchShootForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            launchLoginForm.Show();
            this.Hide();
        }

        private void btnModifyDB_Click(object sender, EventArgs e)
        {
            launchModifyRec.Show();
            this.Hide();
        }
    }
}
