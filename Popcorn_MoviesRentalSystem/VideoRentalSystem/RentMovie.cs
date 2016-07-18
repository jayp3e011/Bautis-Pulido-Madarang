using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalSystem
{
    class RentMovie
    {
        public RentMovie()
        {

        }
        private int penaltyFee;
        private int rentalFee;
        private int total_days;
        private string returnedDate;
        private string borrowedDate;
        private string customerID;
        private string moveID;
        private string rentID;

        public string RentID
        {
            get { return rentID; }
            set { rentID = value; }
        }


        public string Movie_ID
        {
            get { return moveID; }
            set { moveID = value; }
        }

        public string Customer_ID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string Borrowed_Date
        {
            get { return borrowedDate; }
            set { borrowedDate = value; }
        }

        public string Returned_Date
        {
            get { return returnedDate; }
            set { returnedDate = value; }
        }

        public int Total_Days
        {
            get { return total_days; }
            set { total_days = value; }
        }

        public int Rental_Fee
        {
            get { return rentalFee; }
            set { rentalFee = value; }
        }

        public int Penalty_Fee
        {
            get { return penaltyFee; }
            set { penaltyFee = value; }
        }

        public void insert()
        {
            string sql = "INSERT INTO tbl_rentMovie (rent_id, movie_id, customer_id, rent_dateBorrowed, rent_dateReturned, rent_daysTotal, rent_rentalFee, rent_penaltyFee) VALUES('" + this.rentID+ "', '" + this.moveID+ "', '" + this.customerID+ "', '" + this.borrowedDate+ "', '" + this.returnedDate+ "', '" + this.total_days+ "', '" + this.rentalFee+ "', '" + this.penaltyFee+ "')";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);

        }

        public void update()
        {
            string sql = "UPDATE tbl_rentMovie SET movie_id = " + this.moveID+ ", customer_id = " + this.customerID+ ", rent_dateBorrowed = " + this.borrowedDate+ ", rent_dateReturned = " + this.returnedDate+ ", rent_daysTotal = " + this.total_days+ ", rent_rentalFee = " + this.rentalFee+ ", rent_penaltyFee = " + this.penaltyFee+ " WHERE rent_id = " + this.rentID+ "";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);
        }

        public void delete()
        {
            string sql = "DELETE FROM tbl_rentMovie WHERE rent_id = " + this.rentID+ "";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);
        }

        public void select()
        {
            string sql = "SELECT rent_id, movie_id, customer_id, rent_dateBorrowed, rent_dateReturned, rent_daysTotal, rent_rentalFee, rent_penaltyFee FROM tbl_rentMovie";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);
        }
    }
}
