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
    public partial class frmRentMovie : Form
    {
        public frmRentMovie()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RentMovie rent = new RentMovie();
            rent.Customer_ID = txtCostumerID.Text;
            rent.Movie_ID = txtMovieID.Text;
            rent.Borrowed_Date = txtDateBorrowed.Text;
            rent.Returned_Date = txtDateReturned.Text;
            rent.Total_Days = Convert.ToInt32(txtDays.Text);
            rent.Rental_Fee = Convert.ToInt32(txtRenaltFee.Text);
            rent.Penalty_Fee = Convert.ToInt32(txtPenaltyFee.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
