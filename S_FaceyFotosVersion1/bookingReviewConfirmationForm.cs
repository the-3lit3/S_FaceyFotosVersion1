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
    
    public partial class bookingReviewConfirmationForm : Form
    {
        private readonly db_sfaceyFotos2Entities3 db_entity;
        public bookingReviewConfirmationForm()
        {
            InitializeComponent();
            db_entity = new db_sfaceyFotos2Entities3();
        }

        
        private void bookingReviewConfirmationForm_Load(object sender, EventArgs e)
        {
            try
            {
            
                //tb_bookingInfo getInfo = new tb_bookingInfo();
                //tbFirstNameDisplay.Text = getInfo.First_Name.ToString();
                //tbLastNameDisplay.Text = getInfo.Last_Name.ToString();
                //tbEmailAddressDisplay.Text = getInfo.Email_Address.ToString();
                //tbPhoneNumberDisplay.Text = getInfo.Telephone.ToString();
                //tbCardNumberDisplay.Text = getInfo.Card_Number.ToString();
                //tbCardTypeDisplay.Text = getInfo.Card_TypeID.ToString();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
