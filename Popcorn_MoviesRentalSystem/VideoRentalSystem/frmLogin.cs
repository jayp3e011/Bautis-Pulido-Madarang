using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Username = txtUsername.Text;
            users.Password = txtPassword.Text;
            Boolean match = users.spTest();
            if (match == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Invalid account");
                txtUsername.Clear();
                txtUsername.Clear();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
