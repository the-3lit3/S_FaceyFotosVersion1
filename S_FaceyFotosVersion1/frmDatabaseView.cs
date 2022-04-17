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
        private readonly db_sfaceyFotos2Entities3 db_entity;
        public frmDatabaseView()
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();
        }

        private void viewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clientRecords = db_entity.tb_bookingInfo.ToList();
            gridFotoDBview.DataSource = clientRecords;
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userAccounts = db_entity.tb_userRegistration.ToList();
            gridFotoDBview.DataSource = userAccounts;
        }
    }
}
