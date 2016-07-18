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
    public partial class frmAddMovie : Form
    {
        public frmAddMovie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.Name = txtMovieTitle.Text;
            movie.Genre = txtGenre.Text;
            movie.Language = txtLanguage.Text;
            movie.Rating = Convert.ToInt32(txtRatings.Text);
            movie.Cast = txtCast.Text;
            movie.Year_Release = comboYear.Text;
            movie.generateID();
            MessageBox.Show(movie.Movie_ID + " Saved...");
            this.Close();

        }

        private void txtMovieTitle_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            int index = t.Text.IndexOf("  ");
            while (index != -1)
            {
                t.Text = t.Text.Replace("  ", " ");
                index = t.Text.IndexOf("  ");
            }
            t.SelectionStart = t.Text.Length;
        }

        private void txtCast_TextChanged(object sender, EventArgs e)
        {
            /*TextBox t = (TextBox)sender;
            int index = t.Text.IndexOf("  ");
            while (index != -1)
            {
                t.Text = t.Text.Replace("  ", " ");
                index = t.Text.IndexOf("  ");
            }
            t.SelectionStart = t.Text.Length;*/
        }

        private void frmAddMovie_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
