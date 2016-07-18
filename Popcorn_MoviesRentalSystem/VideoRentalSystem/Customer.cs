using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem
{
    class Customer
    {
        public Customer()
        {

        }
        private string status;
        private string contactNo;
        private string email;
        private string address;
        private string middleInitial;
        private string lastName;
        private string firstName;
        private string customerID;

        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string MiddleInitial
        {
            get { return middleInitial; }
            set { middleInitial = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Contact_No
        {
            get { return contactNo; }
            set { contactNo = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string regDate;

        public string RegDate
        {
            get { return regDate; }
            set { regDate = value; }
        }

        public void generateID()
        {
            //MessageBox.Show(lastName+contactNo);
            string[] contact = contactNo.Split('-');
           
            string id = this.regDate + "_" + lastName + "_" + contact[1].Substring(1,3);
            CustomerID = id;
            //MessageBox.Show(lastName);
            //MessageBox.Show(date);
            //MessageBox.Show(contact[2]);
            //MessageBox.Show(id);
            //frmMain m = new frmMain();
           // m.res = id;
            //return id;
        }
        public void insert()
        {
            //string sql = "INSERT INTO Customers (customer_id,first_name,last_name,middle_initial,address,email_address,contact_no,customer_status,registered_date) VALUES('" + this.customerID + "','" + this.firstName + "','" + this.lastName + "','" + this.middleInitial + "','" + this.address + "','" + this.email + "','" + this.contactNo + "','" + this.status + "','" + this.regDate + "');";
            string sql = "INSERT INTO tbl_customer(customer_id, customer_firstName, customer_lastName, customer_middleInitial, customer_address, customer_emailAdd, customer_contactNo, customer_status, customer_registeredDate) "+
                "VALUES('"+this.customerID+"', '"+this.firstName+ "', '"+this.lastName+"', '"+this.middleInitial+"', '"+this.address+ "', '"+this.email+ "', '"+this.contactNo+ "', '"+this.status+ "', '"+this.regDate+"') ";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);

        }
        
        public void update()
        {
            string sql = "UPDATE tbl_customer SET costumer_firstName = "+this.firstName+ ", costumer_lastName = "+this.lastName+ ", costumer_middleInitial = " + this.middleInitial+ ", costumer_address = " + this.address+ ", costumer_emailAdd = " + this.email+ ", customer_contactNo = " + this.contactNo+ ", customer_status = " + this.contactNo+ ", customer_registeredDate = " + this.regDate+ " WHERE customer_id = " + this.customerID+ " ";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);
        }

        public void delete()
        {
            string sql = "DELETE FROM tbl_customer WHERE customer_id = "+this.customerID+";";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);
        }

        public void select()
        {
            string sql = "SELECT customer_id, customer_firstName, customer_lastName, customer_middleInitial, customer_address, customer_emailAdd, customer_contactNo, customer_status, customer_registeredDate FROM tbl_customer";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);
        }
    }
}
