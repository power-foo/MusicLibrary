using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    // Tri Le and Chris
    public class SongController
    {
        // Connection string to database
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MusicLibrary.accdb;";

        // Method for retrieving songs from the database
        public List<Song> GetSongs(string query = "SELECT * FROM Songs")
        {
            List<Song> songs = new List<Song>();

            // Actual connection to the database
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();

                // Looping through each row within database
                while (reader.Read())
                {
                    // Each row within database is converted into Song object
                    songs.Add(new Song()
                    {
                        SongID = Convert.ToInt32(reader["SongID"]),
                        SongName = reader["SongName"].ToString(),
                        Artist = reader["Artist"].ToString(),
                        Genre = reader["Genre"].ToString(),
                        AlbumName = reader["AlbumName"].ToString(),
                        AlbumCover = reader["AlbumCover"].ToString(),
                        ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"])
                    });
                }
            }

            // Returns the list of Song objects into the view
            return songs;
        }

        // Method for sorting songs by a selected criteria
        public List<Song> SortSongs(string column)
        {
            return GetSongs($"SELECT * FROM Songs ORDER BY {column}");
        }

        // Method for filtering the songs by either Genre or Artist
        public List<Song> FilterSongs(string value)
        {
            return GetSongs($"SELECT * FROM Songs WHERE Genre='{value}' OR Artist='{value}'");
        }

        // Method for dynamically filling the cmbFilter combobox with genres in database
        public List<string> GetGenres()
        {
            List<string> genres = new List<string>();

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT DISTINCT Genre FROM Songs", conn);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    genres.Add(reader["Genre"].ToString());
                }
            }

            return genres;
        }

        // Method for retrieving reviews from the database
        public List<Review> GetAllReviews()
        {
            List<Review> reviews = new List<Review>();

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Reviews", conn);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reviews.Add(new Review()
                    {
                        ReviewID = Convert.ToInt32(reader["ReviewID"]),
                        SongID = Convert.ToInt32(reader["SongID"]),
                        UserID = Convert.ToInt32(reader["UserID"]),
                        RatingValue = Convert.ToInt32(reader["RatingValue"]),
                        ReviewText = reader["ReviewText"].ToString(),
                        ReviewDate = Convert.ToDateTime(reader["ReviewDate"])
                    });
                }
            }
            return reviews;
        }

        // Method for retrieving song name by its ID
        public string GetSongNameByID(int songID)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand(
                    "SELECT SongName FROM Songs WHERE SongID = ?", conn);

                cmd.Parameters.AddWithValue("?", songID);

                object result = cmd.ExecuteScalar();

                // Returns the song name if found, otherwise it is an empty string
                return result != null ? result.ToString() : "";
            }
        }

        // Method for adding/saving a new review
        public void SaveReview(int songID, int userID, string reviewText, int rating)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                // Insert query for adding a new review
                OleDbCommand insert = new OleDbCommand(
                    "INSERT INTO Reviews (SongID, UserID, RatingValue, ReviewText, ReviewDate) " +
                    "VALUES (?, ?, ?, ?, ?)", conn);

                insert.Parameters.Add("?", OleDbType.Integer).Value = songID;
                insert.Parameters.Add("?", OleDbType.Integer).Value = userID;
                insert.Parameters.Add("?", OleDbType.Integer).Value = rating;
                insert.Parameters.Add("?", OleDbType.VarChar).Value = reviewText;
                insert.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;

                insert.ExecuteNonQuery();
            }
        }

        // Method for deleting a review
        public void DeleteReview(int reviewID)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand(
                    "DELETE FROM Reviews WHERE ReviewID = ?", conn);

                cmd.Parameters.AddWithValue("?", reviewID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
