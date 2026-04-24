using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    // Tri Le
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

        // Method for retrieving the Reviews + Ratings from database
        public (string review, int rating) GetReviewBySongID(int songID)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand(
                    "SELECT ReviewText, RatingValue FROM Reviews WHERE SongID = ?", conn);

                cmd.Parameters.AddWithValue("?", songID);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string review = reader["ReviewText"].ToString();
                    int rating = Convert.ToInt32(reader["RatingValue"]);

                    return (review, rating);
                }
            }
            return ("", 0);
        }

        // Method for saving a review (updating an existing one or creating a new one)
        public void SaveReview(int songID, int userID, string reviewText, int rating)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();

                // Checking if a review already exists for the song
                OleDbCommand check = new OleDbCommand(
                    "SELECT COUNT(*) FROM Reviews WHERE SongID = ?", conn);

                check.Parameters.AddWithValue("?", songID);

                int exists = Convert.ToInt32(check.ExecuteScalar());

                // Inserts new review for song if it doesn't exist yet
                if (exists == 0)
                {
                    OleDbCommand insert = new OleDbCommand(
                        "INSERT INTO Reviews (SongID, UserID, RatingValue, ReviewText, ReviewDate) " +
                        "VALUES (?, ?, ?, ?, ?)", conn);

                    insert.Parameters.AddWithValue("?", songID);
                    insert.Parameters.AddWithValue("?", userID);
                    insert.Parameters.AddWithValue("?", rating);
                    insert.Parameters.AddWithValue("?", reviewText);
                    insert.Parameters.AddWithValue("?", DateTime.Now);

                    insert.ExecuteNonQuery();
                }
                else
                {
                    // Updates review if it does exist
                    OleDbCommand update = new OleDbCommand(
                        "UPDATE Reviews SET RatingValue = ?, ReviewText = ?, ReviewDate = ? " +
                        "WHERE SongID = ?", conn);

                    update.Parameters.AddWithValue("?", rating);
                    update.Parameters.AddWithValue("?", reviewText);
                    update.Parameters.AddWithValue("?", DateTime.Now);
                    update.Parameters.AddWithValue("?", songID);

                    update.ExecuteNonQuery();
                }
            }
        }
    }
}
