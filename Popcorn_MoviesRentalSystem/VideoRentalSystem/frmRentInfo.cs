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
    public partial class frmRentInfo : Form
    {
        public frmRentInfo()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmAddMovieRentalInfo info = new frmAddMovieRentalInfo();
            info.Show();
        }

        private void frmRentInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_videoRentalDataSet6.tbl_movieRentalInfo' table. You can move, or remove it, as needed.
            this.tbl_movieRentalInfoTableAdapter.Fill(this.db_videoRentalDataSet6.tbl_movieRentalInfo);

        }

        private void tblRentalInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow row = tblRentalInfo.Rows[e.RowIndex];
                string id = row.Cells[0].Value.ToString();
                Movie img = new Movie();
                img.Movie_ID = id;
                string[] info = img.getMovieInfo();
                txtTitle.Text = info[0];
                txtGenre.Text = info[1];
                txtYear.Text = info[2];
                picMovie.Image = Image.FromFile(@info[3]);

            }
        }
    }
}
