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
    public partial class frmModifyRecord : Form
    {
        public frmModifyRecord()
        {
            InitializeComponent();
        }

        private void modifyUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editUser = new frmModifyUser();
            editUser.MdiParent = this;
            editUser.Show();
        }

        private void modifyBookingEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editUser = new frmModifyBookingRecord();
            editUser.MdiParent = this;
            editUser.Show();
        }

        
    }
}
