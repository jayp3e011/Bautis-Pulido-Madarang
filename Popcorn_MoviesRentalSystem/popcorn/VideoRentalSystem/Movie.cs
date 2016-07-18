using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalSystem
{
    class Movie
    {
        public Movie()
        {

        }
        private string yearRelease;
        private string cast;
        private string language;
        private int rating;
        private string genre;
        private string name;
        private string movieID;

        public string Movie_ID
        {
            get { return movieID; }
            set { movieID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public string Cast
        {
            get { return cast; }
            set { cast = value; }
        }

        public string Year_Release
        {
            get { return yearRelease; }
            set { yearRelease = value; }
        }
        public void generateID()
        {
            string id = "";
            string[] n = name.Split(' ');
            foreach (string s in n )
            {
                id += s.Substring(0,1);
            }
            Movie_ID =  yearRelease + "_" + id;
        }

        public void insert()
        {
            string  sql = "INSERT INTO tbl_movieRentalInfo (movie_id, movie_title, movie_genre, movie_rating, movie_language, movie_casts, movie_yearReleased) VALUES('" + this.movieID+ "', '" + this.name+ "', '" + this.genre+ "', '" + this.rating+ "', '" + this.language+ "', '" + this.cast+ "', '" + this.yearRelease+ "');";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);

        }

        public void update()
        {
            string sql = "UPDATE tbl_movieRentalInfo SET movie_title = " + this.name+ ", movie_genre = " + this.genre+ ", movie_rating = " + this.rating+ ", movie_language = " + this.language+ ", movie_casts = " + this.cast+ ", movie_yearReleased = " + this.yearRelease+ " WHERE movie_id = " + this.movieID+ ";";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);
        }

        public void delete()
        {
            string sql = "DELETE FROM tbl_movieRentalInfo WHERE movie_id = " + this.movieID+ ";";
            connectDB conn = new connectDB();
            conn.connect();
            conn.query(sql);
        }
    }
}
