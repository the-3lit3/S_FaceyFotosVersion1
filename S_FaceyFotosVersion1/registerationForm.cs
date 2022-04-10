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
    public partial class frmRegisterationForm : Form
    {
        private readonly db_sfaceyFotos2Entities1 db_entity; 
        public frmRegisterationForm()
        {
            InitializeComponent();
              db_entity = new db_sfaceyFotos2Entities1();
            
        }

        private void btnRegisterSubmit_Click(object sender, EventArgs e)
        {
            frmLoginForm launchLogin = new frmLoginForm();
            launchLogin.Show();
            this.Hide();
        }

        private void frmRegisterationForm_Load(object sender, EventArgs e)
        {
            var cardType = db_entity.tb_cardType.ToList();
            cmbCardType.DisplayMember = "Card_Type";
            cmbCardType.ValueMember = "Id";
            cmbCardType.DataSource = cardType;

        }
    }
}
