using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem
{
    public partial class frmAddMovieRentalInfo : Form
    {
        public frmAddMovieRentalInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RentInfo info = new RentInfo();
            info.movie_ID = txtMovieID.Text;
            info.Rent_Type = txtRentType.Text;
            info.Rent_Fee = Convert.ToInt32(txtRenaltFee.Text);
            info.Penalty_Fee = Convert.ToInt32(txtPenaltyFee.Text);
            MessageBox.Show("Saved.....");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
