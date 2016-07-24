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

        private void frmRentMovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_videoRentalDataSet2.tbl_movieRentalInfo' table. You can move, or remove it, as needed.
            this.tbl_movieRentalInfoTableAdapter.Fill(this.db_videoRentalDataSet2.tbl_movieRentalInfo);
            // TODO: This line of code loads data into the 'db_videoRentalDataSet.tbl_customer' table. You can move, or remove it, as needed.
            this.tbl_customerTableAdapter.Fill(this.db_videoRentalDataSet.tbl_customer);

        }

        private void customerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customerView.Rows[e.RowIndex];

                txtCostumerID.Text = row.Cells[0].Value.ToString();
                
            }
        }
        private void moviesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.moviesView.Rows[e.RowIndex];

                txtMovieID.Text = row.Cells[0].Value.ToString();
                Movie img = new Movie();
                img.Movie_ID = row.Cells[0].Value.ToString();
                imgRentMoviePoster.Image = Image.FromFile(@img.getMovieImg());

            }
        }
    }
}
