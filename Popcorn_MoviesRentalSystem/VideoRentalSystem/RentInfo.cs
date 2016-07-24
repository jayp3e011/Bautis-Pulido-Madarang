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
    class RentInfo
    {
        public RentInfo()
        {

        }
        private string movieID;
        private string rentType;
        private int noOfDays;
        private int rentFee;
        private int penaltyFee;

        public int Penalty_Fee
        {
            get { return penaltyFee; }
            set { penaltyFee = value; }
        }

        public int Rent_Fee
        {
            get { return rentFee; }
            set { rentFee = value; }
        }

        public int No_OfDays
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }

        public string Rent_Type
        {
            get { return rentType; }
            set { rentType = value; }
        }

        public string movie_ID
        {
            get { return movieID; }
            set { movieID = value; }
        }

        public void insert()
        {
            string sql = "INSERT INTO tbl_movieRentalInfo (movie_id, info_rentType, info_rentDays, info_rentFee, info_penaltyFee) VALUES('" + this.movieID+ "', '" + this.rentType+ "', '" + this.noOfDays+ "', '" + this.rentFee+ "', '" + this.penaltyFee+ "')";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);

        }

        public void update()
        {
            string sql = "UPDATE tbl_movieRentalInfo SET info_rentType = " + this.rentType+ ", info_rentDays = " + this.noOfDays+ ", info_rentFee = " + this.rentFee+ ", info_penaltyFee = " + this.penaltyFee+ " WHERE movie_id = " + this.movieID+ "";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);
        }

        public void delete()
        {
            string sql = "DELETE FROM tbl_movieRentalInfo WHERE movie_id = " + this.movieID+ "";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);
        }

        public void select()
        {
            string sql = "SELECT movie_id, info_rentType, info_rentDays, info_rentFee, info_penaltyFee FROM tbl_movieRentalInfo";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);
        }
        public void spTest(string statementType)
        {

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["videoRental"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("rentInfoQuery", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@movie_id", this.movieID));
                    cmd.Parameters.Add(new SqlParameter("@info_rentType", this.rentType));
                    cmd.Parameters.Add(new SqlParameter("@info_rentDays", this.noOfDays));
                    cmd.Parameters.Add(new SqlParameter("@info_rentFee", this.rentFee));
                    cmd.Parameters.Add(new SqlParameter("@info_penaltyFee", this.penaltyFee));
                    cmd.Parameters.Add(new SqlParameter("@StatementType", statementType));
                    con.Open();
                    MessageBox.Show(cmd.ExecuteNonQuery().ToString());

                }

            }
        }
    }
}
