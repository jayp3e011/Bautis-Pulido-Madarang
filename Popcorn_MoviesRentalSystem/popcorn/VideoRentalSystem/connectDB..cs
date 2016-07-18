using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
//using MySql.Data.MySqlClient;
namespace VideoRentalSystem
{
    class connectDB
    {
        public connectDB()
        {

        }
        public void connect()
        {
            //connetionString = ConfigurationManager.ConnectionStrings["videoRental"].ConnectionString;
           
        }
        public void query(string sql)
        {
            connetionString = "Data Source=AFKGAMING\\SQLEXPRESS;Initial Catalog=db_videoRental;Integrated Security=True";
            connection = new SqlConnection(connetionString);
            try
            {

                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");

            }
        }
        private string connetionString = null;
        private SqlConnection connection;
        private SqlCommand command;
    }
}
