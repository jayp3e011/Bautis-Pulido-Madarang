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
            info.spTest("Insert");
            MessageBox.Show("Saved.....");
        }

        private void moviesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.moviesView.Rows[e.RowIndex];

                txtMovieID.Text = row.Cells[0].Value.ToString();
                imgMoviePoster.Image = Image.FromFile(@row.Cells[7].Value.ToString());

            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddMovieRentalInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_videoRentalDataSet7.GetMovieSet' table. You can move, or remove it, as needed.
            this.getMovieSetTableAdapter.Fill(this.db_videoRentalDataSet7.GetMovieSet);

        }
    }
}
