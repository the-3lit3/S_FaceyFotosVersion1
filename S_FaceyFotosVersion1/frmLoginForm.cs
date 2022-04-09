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
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void btnLoginMain_Click(object sender, EventArgs e)
        {
            frmShootBooking launchBooking = new frmShootBooking();
            launchBooking.Show();
            this.Hide();
        }

    }
}
