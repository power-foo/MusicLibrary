using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary
{
    public partial class FrmMain : Form
    {
        public FrmMain(string username)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + username; //Shows username when you login

            LoadMainButtons();
        }
        private void LoadMainButtons()
        {
            flpMainButtons.Controls.Clear();

            //Adding buttons into the flp
            CreateMainButton("View Playlist", ViewPlaylist_Click);
            CreateMainButton("Search Songs", SearchSongs_Click);
            CreateMainButton("Rate Songs", RateSongs_Click);
        }
        private void CreateMainButton(string buttonText, EventHandler buttonClick)
        {
            Button btn = new Button();

            btn.Text = buttonText;
            btn.Width = 220;
            btn.Height = 55;
            btn.Margin = new Padding(10);
            btn.BackColor = Color.SteelBlue;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Arial", 12, FontStyle.Bold);

            btn.Click += buttonClick;

            flpMainButtons.Controls.Add(btn);
        }
        
        //Open playlist
        private void ViewPlaylist_Click(object sender, EventArgs e)
        {
            FrmViewPlaylist frm = new FrmViewPlaylist();
            frm.ShowDialog();
        }

        //Open Search songs
        private void SearchSongs_Click(object sender, EventArgs e)
        {
            frmSearchSong frm = new frmSearchSong();
            frm.ShowDialog();
        }

        //Open Rate songs
        private void RateSongs_Click(object sender, EventArgs e)
        {
            frmRateSong frm = new frmRateSong();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
