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
    }
}
