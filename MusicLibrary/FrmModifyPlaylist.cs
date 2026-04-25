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
        public FrmModifyPlaylist(int playlistID, string playlistName)
        {
            InitializeComponent();

            currentPlaylistID = playlistID;

            lblPlaylistName.Text = playlistName;

            LoadSongs();
            LoadAllSongs();
        }

        private void LoadSongs()
        {
            flpSongs.Controls.Clear();

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();

                //Gets all the songs that belogns in the playlist
                string sql = "SELECT Songs.SongID, SongName, Artist, AlbumCover, PreviewURL FROM Songs INNER JOIN PlaylistSong ON Songs.SongID = PlaylistSong.SongID WHERE PlaylistID = ?";

                OleDbCommand cmd = new OleDbCommand(sql, myConnection);
                cmd.Parameters.AddWithValue("@id", currentPlaylistID);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Creates one card for one song
                    Panel songPanel = new Panel();
                    songPanel.Width = 350;
                    songPanel.Height = 120;
                    songPanel.BorderStyle = BorderStyle.FixedSingle;
                    songPanel.Margin = new Padding(10);

                    //Creates the album picture
                    PictureBox picAlbum = new PictureBox();
                    picAlbum.Width = 90;
                    picAlbum.Height = 90;
                    picAlbum.Location = new Point(10, 10);
                    picAlbum.SizeMode = PictureBoxSizeMode.Zoom;

                    try
                    {
                        //Loads the image from the database URL
                        picAlbum.LoadAsync(reader["AlbumCover"].ToString());
                    }
                    catch
                    {
                        picAlbum.BackColor = Color.LightGray;
                    }

                    //Shows the song name
                    Label lblSong = new Label();
                    lblSong.Text = reader["SongName"].ToString();
                    lblSong.Location = new Point(115, 15);
                    lblSong.Width = 200;
                    lblSong.Font = new Font("Arial", 11, FontStyle.Bold);

                    //Shows the artist name
                    Label lblArtist = new Label();
                    lblArtist.Text = reader["Artist"].ToString();
                    lblArtist.Location = new Point(115, 45);
                    lblArtist.Width = 200;

                    //Remove button
                    Button btnRemove = new Button();
                    btnRemove.Text = "Remove";
                    btnRemove.Location = new Point(115, 75);
                    btnRemove.Width = 90;
                    btnRemove.BackColor = Color.FromArgb(128, 255, 255);
                    btnRemove.FlatStyle = FlatStyle.Flat;

                    //Preview button
                    Button btnPreview = new Button();
                    btnPreview.Text = "Preview";
                    btnPreview.Location = new Point(210, 75);
                    btnPreview.Width = 90;
                    btnPreview.BackColor = Color.FromArgb(128, 255, 255);
                    btnPreview.FlatStyle = FlatStyle.Flat;

                    //Gets the preview link from database which would be the itunes link
                    string previewURL = reader["PreviewURL"].ToString();

                    btnPreview.Click += (s, e) =>
                    {
                        wmpPreview.URL = previewURL;
                        wmpPreview.Ctlcontrols.play();
                    };

                    int songID = Convert.ToInt32(reader["SongID"]);

                    //Removes the song when you click remoive
                    btnRemove.Click += (s, e) =>
                    {
                        RemoveSongByID(songID);
                    };

                    songPanel.Controls.Add(picAlbum);
                    songPanel.Controls.Add(lblSong);
                    songPanel.Controls.Add(lblArtist);
                    songPanel.Controls.Add(btnRemove);
                    songPanel.Controls.Add(btnPreview);

                    flpSongs.Controls.Add(songPanel);
                }

                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading songs: " + ex.Message);
            }
        }
        private void RemoveSongByID(int songID)
        {
            //Removes the song from playlist from its songID
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();

                string sql = "DELETE FROM PlaylistSong WHERE SongID = ? AND PlaylistID = ?";

                OleDbCommand cmd = new OleDbCommand(sql, myConnection);
                cmd.Parameters.AddWithValue("@songID", songID);
                cmd.Parameters.AddWithValue("@playlistID", currentPlaylistID);

                cmd.ExecuteNonQuery();

                myConnection.Close();

                LoadSongs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing song: " + ex.Message);
            }
        }

        private void LoadAllSongs()
        {
            //It clears the dropdown
            cboSongs.Items.Clear();

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            try
            {
                //Gets all the songs from the Songs table
                myConnection.Open();

                string sql = "SELECT SongName FROM Songs";

                OleDbCommand cmd = new OleDbCommand(sql, myConnection);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Adds the songs in the dropdown
                    cboSongs.Items.Add(reader["SongName"].ToString());
                }

                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all songs: " + ex.Message);
            }
        }

        private void AddSong(string songName)
        {
            //Adds the selected song into the playlist
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();

                //Finds through SongID by SongName and then from there adds it into PlaylistSong
                string sql = "INSERT INTO PlaylistSong (PlaylistID, SongID) SELECT ?, SongID FROM Songs WHERE SongName = ?";

                OleDbCommand cmd = new OleDbCommand(sql, myConnection);
                cmd.Parameters.AddWithValue("@playlistID", currentPlaylistID);
                cmd.Parameters.AddWithValue("@songName", songName);

                cmd.ExecuteNonQuery();

                myConnection.Close();

                LoadSongs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding song: " + ex.Message);
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (cboSongs.SelectedItem == null)
            {
                MessageBox.Show("Select a song first.");
                return;
            }

            string songName = cboSongs.SelectedItem.ToString();

            AddSong(songName);
        }

        private void btnStopPreview_Click(object sender, EventArgs e)
        {
            //Stops the music preview by clearning the preview link
            wmpPreview.Ctlcontrols.stop();
            wmpPreview.URL = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }


}
