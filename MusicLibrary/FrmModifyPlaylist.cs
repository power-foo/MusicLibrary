using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary
{
    public partial class FrmModifyPlaylist : Form
    {
        int currentPlaylistID;
        public FrmModifyPlaylist(int playlistID)
        {
            InitializeComponent();

            currentPlaylistID = playlistID;

            LoadSongs();
        }

        private void LoadSongs()
        {
            lstSongs.Items.Clear();

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();

                // NEW CODE
                string sql = "SELECT SongName FROM Songs INNER JOIN PlaylistSong ON Songs.SongID = PlaylistSong.SongID WHERE PlaylistID = ?";

                OleDbCommand cmd = new OleDbCommand(sql, myConnection);
                cmd.Parameters.AddWithValue("@id", currentPlaylistID);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstSongs.Items.Add(reader["SongName"].ToString());
                }

                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading songs: " + ex.Message);
            }
        }

        // NEW CODE
        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (lstSongs.SelectedItem == null)
            {
                MessageBox.Show("Select a song first.");
                return;
            }

            string songName = lstSongs.SelectedItem.ToString();

            RemoveSong(songName);
        }
        // NEW CODE
        private void RemoveSong(string songName)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();

                string sql = "DELETE FROM PlaylistSong WHERE SongID = (SELECT SongID FROM Songs WHERE SongName = ?) AND PlaylistID = ?";

                OleDbCommand cmd = new OleDbCommand(sql, myConnection);
                cmd.Parameters.AddWithValue("@name", songName);
                cmd.Parameters.AddWithValue("@id", currentPlaylistID);

                cmd.ExecuteNonQuery();

                myConnection.Close();

                LoadSongs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing song: " + ex.Message);
            }
        }

    }


}
