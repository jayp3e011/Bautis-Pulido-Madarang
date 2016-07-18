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
    public partial class frmMovie : Form
    {
        public frmMovie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddMovie addMovie = new frmAddMovie();
            addMovie.Show();
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            frmAddMovieRentalInfo addInfo = new frmAddMovieRentalInfo();
            addInfo.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmAddMovie movie = new frmAddMovie();
            movie.Show();
        }

        private void frmMovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_videoRentalDataSet1.tbl_movies' table. You can move, or remove it, as needed.
            this.tbl_moviesTableAdapter.Fill(this.db_videoRentalDataSet1.tbl_movies);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
