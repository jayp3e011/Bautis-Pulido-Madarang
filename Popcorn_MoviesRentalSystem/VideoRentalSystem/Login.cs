using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem
{
    class Login : ApplicationContext
    {
        public Login()
        {
            //Application.Run(new frmLogin());
            frmLogin f1 = new frmLogin();
            DialogResult dr = f1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
