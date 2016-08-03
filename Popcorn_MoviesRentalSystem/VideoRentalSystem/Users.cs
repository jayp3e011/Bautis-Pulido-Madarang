using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem
{
    class Users
    {
        private string username;
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public Boolean spTest()
        {
            Boolean match = false;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["videoRental"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Login", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", this.username));
                    cmd.Parameters.Add(new SqlParameter("@password", this.password));
                    con.Open();
                    int usercount = (Int32)cmd.ExecuteScalar();// for taking single value

                    if (usercount == 1)  // comparing users from table 
                    {
                        match = true;
                    }
                    else
                    {
                        con.Close();
                        match = false;
                    }

                }
            }
            return match;
        }

    }
}
