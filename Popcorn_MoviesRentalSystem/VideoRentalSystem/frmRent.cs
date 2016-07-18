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
    public partial class frmRent : Form
    {
        public frmRent()
        {
            InitializeComponent();
        }

        private void topNavi_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmRentMovie rent = new frmRentMovie();
            rent.Show();
        }
    }
}
