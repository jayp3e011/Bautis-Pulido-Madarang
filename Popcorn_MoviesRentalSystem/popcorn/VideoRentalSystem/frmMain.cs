using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

namespace VideoRentalSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void splashStart()
        {
            Application.Run(new frmSplash());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            string date = string.Format("{0:MMddyyy}", d);
            Customer c = new Customer();
            c.RegDate = date;
            c.LastName = "Bautista";
            c.Contact_No = "099-9313";
            c.generateID();
            Movie m = new Movie();
            m.Name = "Teenage Mutant Ninja Turtle 2";
            m.Year_Release = "2016";
            m.generateID();
            label1.Text = c.CustomerID + "  Movie: " + m.Movie_ID;
            //MessageBox.Show(c.generateID());
        }
        public string res { get; set; }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            frmMovie movie = new frmMovie();
            movie.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer reg = new frmAddCustomer();
            reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRentMovie rent = new frmRentMovie();
            rent.Show();
        }
    }
}
