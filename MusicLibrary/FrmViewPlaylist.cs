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
        }

        private void btnLoadPlaylists_Click(object sender, EventArgs e)
        {
            string connectionString;
            OleDbConnection myConnection;
            OleDbCommand myCommand;
            OleDbDataAdapter myAdapter;
            DataTable myTable;
            string sql;

            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";
            myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();

                sql = "SELECT * FROM Playlist";
                myCommand = new OleDbCommand(sql, myConnection);

                myAdapter = new OleDbDataAdapter(myCommand);
                myTable = new DataTable();

                myAdapter.Fill(myTable);

                dgvPlaylists.DataSource = myTable;

                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading playlists: " + ex.Message);
            }
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            string connectionString;
            OleDbConnection myConnection;
            OleDbCommand myCommand;
            string sql;

            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MusicLibrary.accdb";
            myConnection = new OleDbConnection(connectionString);

            try
            {
                myConnection.Open();

                sql = "INSERT INTO Playlist (PlaylistName, UserID) VALUES (?, ?)";
                myCommand = new OleDbCommand(sql, myConnection);

                myCommand.Parameters.AddWithValue("?", txtPlaylistName.Text);
                myCommand.Parameters.AddWithValue("?", 1);

                myCommand.ExecuteNonQuery();

                MessageBox.Show("Playlist added successfully.");

                myConnection.Close();

                btnLoadPlaylists_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Can not add a playlist");
            }
        }
    }
}
