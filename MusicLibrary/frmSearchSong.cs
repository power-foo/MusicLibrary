using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MusicLibrary
{
    // Tri Le
    public partial class frmSearchSong : Form
    {
        // Instance of controller
        private SongController controller = new SongController();

        public frmSearchSong()
        {
            InitializeComponent();
        }

        /* Tri Le Learning Opportunity: Visualizing the data with a Chart (Bar Chart), specifically 
         showing how many songs of each genre there are within the database */
        private void LoadChart()
        {
            chtGenres.Series.Clear();

            Series series = new Series()
            {
                ChartType = SeriesChartType.Bar
            };

            var songs = controller.GetSongs();
            var groupSongs = songs.GroupBy(s => s.Genre).Select(g => new { Genre = g.Key, Count = g.Count() });

            foreach (var item in groupSongs)
            {
                int index = series.Points.AddXY(item.Genre, item.Count);
                series.Points[index].Label = $"{item.Genre}: {item.Count}";
                series.Points[index].LegendText = $"{item.Genre}: {item.Count}";
            }
            chtGenres.Series.Add(series);
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.Black;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearchSong_Load(object sender, EventArgs e)
        {
            // Add the criteria for the sorting combobox
            cmbSort.Items.AddRange(new string[]
            {
                "Title (A-Z)",
                "Artist",
                "Release Date",
                "Genre"
            });

            // Dynamically populate cmbFilter with genres from database only
            cmbFilter.Items.Clear();
            foreach (var genre in controller.GetGenres())
            {
                cmbFilter.Items.Add(genre);
            }

            chtGenres.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chtGenres.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chtGenres.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chtGenres.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            DisplaySongs(controller.GetSongs());
            LoadChart();
        }

        private void DisplaySongs(List<Song> songs)
        {
            flpSongs.Controls.Clear();

            foreach (Song song in songs)
            {
                Panel panel = new Panel
                {
                    Width = flpSongs.Width - 25,
                    Height = 90,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = song
                };

                // Creating the labels for song info
                Label lblSong = new Label
                {
                    Text = song.SongName,
                    Left = 10,
                    Top = 8,
                    Width = 200,
                    Height = 20
                };

                Label lblAlbum = new Label
                {
                    Text = "Album: " + song.AlbumName,
                    Top = 8,
                    Left = 220,
                    Width = 250,
                    Height = 20,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top
                };

                Label lblArtist = new Label
                {
                    Text = "Artist: " + song.Artist,
                    Left = 10,
                    Top = 40,
                    Width = 200,
                    Height = 20
                };

                Label lblGenre = new Label
                {
                    Text = "Genre: " + song.Genre,
                    Left = 220,
                    Top = 40,
                    Width = 150,
                    Height = 20
                };

                Label lblDate = new Label
                {
                    Text = "Released: " + song.ReleaseDate.ToShortDateString(),
                    Top = 60,
                    Left = 10,
                    Width = 300,
                    Height = 20
                };

                // Click events (entire card clickable)
                panel.Click += SongPanel_Click;
                lblSong.Click += SongPanel_Click;
                lblArtist.Click += SongPanel_Click;
                lblGenre.Click += SongPanel_Click;
                lblAlbum.Click += SongPanel_Click;
                lblDate.Click += SongPanel_Click;

                // Add controls
                panel.Controls.Add(lblSong);
                panel.Controls.Add(lblArtist);
                panel.Controls.Add(lblGenre);
                panel.Controls.Add(lblAlbum);
                panel.Controls.Add(lblDate);

                flpSongs.Controls.Add(panel);
            }
        }

        private void SongPanel_Click(object sender, EventArgs e)
        {
            Control clicked = sender as Control;

            while (clicked != null && !(clicked is Panel))
            {
                clicked = clicked.Parent;
            }

            Panel panel = clicked as Panel;
            if (panel == null) return;

            Song song = panel.Tag as Song;
            if (song == null) return;

            foreach (Control ctrl in flpSongs.Controls)
                ctrl.BackColor = SystemColors.Control;

            panel.BackColor = Color.LightBlue;

            LoadSelectedImage(song.AlbumCover);
        }

        // Loads the album image from the URL
        private void LoadSelectedImage(string url)
        {
            try
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(url);
                MemoryStream ms = new MemoryStream(bytes);
                picSelectedAlbum.Image = Image.FromStream(ms);
            }
            catch
            {
                picSelectedAlbum.Image = null;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cmbSort.SelectedItem == null) return;

            string column = cmbSort.SelectedItem.ToString();

            switch (column)
            {
                case "Title (A-Z)": column = "SongName"; break;
                case "Artist": column = "Artist"; break;
                case "Release Date": column = "ReleaseDate"; break;
                case "Genre": column = "Genre"; break;
            }

            DisplaySongs(controller.SortSongs(column));
            LoadChart();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem == null) return;

            DisplaySongs(controller.FilterSongs(cmbFilter.SelectedItem.ToString()));
            LoadChart();
        }
    }
}