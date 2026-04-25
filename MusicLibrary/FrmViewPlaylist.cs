using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MusicLibrary
{
    public partial class FrmViewPlaylist : Form
    {
        public FrmViewPlaylist()
        {
            InitializeComponent();
            LoadPlaylists();
        }

        private void LoadPlaylists()
        {
            flpPlaylists.Controls.Clear(); //Clears the playlist when reloading

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();

                string sql = "SELECT * FROM Playlist"; //Getting all the playlists in the database

                OleDbCommand myCommand = new OleDbCommand(sql, myConnection);

                OleDbDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    //Creates the playlist card
                    Panel playlistPanel = new Panel();
                    playlistPanel.Width = 300;
                    playlistPanel.Height = 100;
                    playlistPanel.BorderStyle = BorderStyle.FixedSingle;
                    playlistPanel.Margin = new Padding(10);

                    //Shows the playlist's name
                    Label lblPlaylistName = new Label();
                    lblPlaylistName.Text = reader["PlaylistName"].ToString();
                    lblPlaylistName.Location = new Point(10, 10);
                    lblPlaylistName.Width = 250;
                    lblPlaylistName.Font = new Font("Arial", 12, FontStyle.Bold);

                    //Creates the open playlist button
                    Button btnView = new Button();
                    btnView.Text = "Open";
                    btnView.Location = new Point(10, 50);
                    btnView.Width = 90;
                    btnView.BackColor = Color.FromArgb(128, 255, 255);
                    btnView.FlatStyle = FlatStyle.Flat;

                    int playlistID = Convert.ToInt32(reader["PlaylistID"]);
                    string playlistName = reader["PlaylistName"].ToString();

                    //Thjis is open the modify playlist form when you click
                    btnView.Click += (s, e) =>
                    {
                        FrmModifyPlaylist frm = new FrmModifyPlaylist(playlistID, playlistName);
                        frm.Show();
                    };

                    Button btnDelete = new Button();
                    btnDelete.Text = "Delete";
                    btnDelete.Location = new Point(110, 50);
                    btnDelete.Width = 80;
                    btnDelete.BackColor = Color.FromArgb(128, 255, 255);
                    btnDelete.FlatStyle = FlatStyle.Flat;
                    //Deletes the playlist
                    btnDelete.Click += (s, e) =>
                    {
                        DeletePlaylist(playlistID);
                    };

                    //Will add the playlist add
                    playlistPanel.Controls.Add(lblPlaylistName);
                    playlistPanel.Controls.Add(btnView);
                    playlistPanel.Controls.Add(btnDelete);
                    //Adds the card into the flp
                    flpPlaylists.Controls.Add(playlistPanel);
                }

                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading playlists: " + ex.Message);
            }
        }

        private void DeletePlaylist(int playlistID)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();

                string sql = "DELETE FROM Playlist WHERE PlaylistID = ?";

                OleDbCommand cmd = new OleDbCommand(sql, myConnection);
                cmd.Parameters.AddWithValue("@id", playlistID);

                cmd.ExecuteNonQuery();

                myConnection.Close();

                LoadPlaylists();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting playlist: " + ex.Message);
            }
        }



        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {

            if (txtPlaylistName.Text == "")
            {
                MessageBox.Show("Please enter a playlist name.");
                return;
            }

            string connectionString;
            OleDbConnection myConnection;
            OleDbCommand myCommand;
            string sql;

            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";
            myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();

                //Adds the new playlist into the database
                sql = "INSERT INTO Playlist (PlaylistName, UserID) VALUES (?, ?)";
                myCommand = new OleDbCommand(sql, myConnection);

                myCommand.Parameters.AddWithValue("?", txtPlaylistName.Text);
                myCommand.Parameters.AddWithValue("?", 1);

                myCommand.ExecuteNonQuery();

                MessageBox.Show("Playlist added successfully.");

                myConnection.Close();

                LoadPlaylists();
                txtPlaylistName.Clear();
            }
            catch
            {
                MessageBox.Show("Can not add a playlist");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGeneratePlaylist_Click(object sender, EventArgs e)
        {

            //Make sure the user enters a playlist name 
            if (txtPlaylistName.Text == "")
            {
                MessageBox.Show("Enter a playlist name first.");
                return;
            }

            //User must pick a genre to be able to generate a playlist
            if (cboGenre.SelectedItem == null)
            {
                MessageBox.Show("Select a genre first.");
                return;
            }

            //Creates the playlist
            GeneratePlaylist(txtPlaylistName.Text, cboGenre.SelectedItem.ToString());
        }
        private void GeneratePlaylist(string playlistName, string genre)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();
                //This will create the playlist
                string insertPlaylistSql = "INSERT INTO Playlist (PlaylistName, UserID) VALUES (?, ?)";
                OleDbCommand playlistCmd = new OleDbCommand(insertPlaylistSql, myConnection);
                playlistCmd.Parameters.AddWithValue("?", playlistName);
                playlistCmd.Parameters.AddWithValue("?", 1);
                playlistCmd.ExecuteNonQuery();

                //This will get the ID of the new playlist it has made
                string getPlaylistSql = "SELECT @@IDENTITY";
                OleDbCommand getPlaylistCmd = new OleDbCommand(getPlaylistSql, myConnection);
                int newPlaylistID = Convert.ToInt32(getPlaylistCmd.ExecuteScalar());

                //It will find songs that matches the genre
                string getSongsSql = "SELECT SongID FROM Songs WHERE Genre = ?";
                OleDbCommand songCmd = new OleDbCommand(getSongsSql, myConnection);
                songCmd.Parameters.AddWithValue("?", genre);

                OleDbDataReader reader = songCmd.ExecuteReader();

                int songsAdded = 0;

                while (reader.Read())
                {
                    int songID = Convert.ToInt32(reader["SongID"]);

                    //Then it will match the song into the playlist
                    string insertSongSql = "INSERT INTO PlaylistSong (PlaylistID, SongID) VALUES (?, ?)";
                    OleDbCommand insertSongCmd = new OleDbCommand(insertSongSql, myConnection);
                    insertSongCmd.Parameters.AddWithValue("?", newPlaylistID);
                    insertSongCmd.Parameters.AddWithValue("?", songID);
                    insertSongCmd.ExecuteNonQuery();

                    songsAdded++;
                }

                myConnection.Close();

                MessageBox.Show("Playlist generated with " + songsAdded + " songs.");

                //Reload the playlist for the new playlist
                txtPlaylistName.Clear();
                cboGenre.SelectedIndex = -1;
                LoadPlaylists();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating playlist: " + ex.Message);
            }
        }
    }
}
