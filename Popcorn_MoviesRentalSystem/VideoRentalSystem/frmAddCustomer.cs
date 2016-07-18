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
    public partial class frmAddCustomer : Form
    {
        static private DateTime d = DateTime.Now;
        private string date = string.Format("{0:MMddyyy}", d);
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        private void txtFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar == ' ') && (tb.Text.Length > 0))
            {
                if (tb.Text[tb.Text.Length - 1] == ' ')
                    e.Handled = true;
            }
        }

        private void txtLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar == ' ') && (tb.Text.Length > 0))
            {
                if (tb.Text[tb.Text.Length - 1] == ' ')
                    e.Handled = true;
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*TextBox tb = (TextBox)sender;
            if ((e.KeyChar == ' ') && (tb.Text.Length > 0))
            {
                if (tb.Text[tb.Text.Length - 1] == ' ')
                    e.Handled = true;
            }*/
        }

        private void txtFN_TextChanged(object sender, EventArgs e)
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

        private void txtLN_TextChanged(object sender, EventArgs e)
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

        private void txtAddress_TextChanged(object sender, EventArgs e)
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

        private void btnAddCostumer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.RegDate = this.date;
            customer.FirstName = txtFN.Text;
            customer.LastName = txtLN.Text;
            customer.MiddleInitial = txtMI.Text;
            customer.Address = txtAddress.Text;
            customer.Email = txtEmail.Text;
            customer.Contact_No = txtContact.Text;
            customer.Status = "Active";
            customer.generateID();
            customer.insert();
            MessageBox.Show(customer.CustomerID+"  Saved....");
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }
    }

}
