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
    }
}
