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
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewPlaylist_Click(object sender, EventArgs e)
        {
            FrmViewPlaylist viewPlaylist = new FrmViewPlaylist();
            viewPlaylist.ShowDialog();
        }

        private void btnSearchSongs_Click(object sender, EventArgs e)
        {
            frmSearchSong songForm = new frmSearchSong();
            songForm.ShowDialog();
        }

        private void btnRateSongs_Click(object sender, EventArgs e)
        {

        }
    }
}
