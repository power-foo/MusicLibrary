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
    // Tri Le
    public partial class frmRateSong : Form
    {
        SongController controller = new SongController();

        public frmRateSong()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmRateSong_Load(object sender, EventArgs e)
        {
            LoadSongs();
            LoadReviews();

            nudRating.Minimum = 1;
            nudRating.Maximum = 5;
        }

        // Loading songs into the ComboBox for selection
        private void LoadSongs()
        {
            cmbSongs.DataSource = controller.GetSongs();
            cmbSongs.DisplayMember = "SongName";
            cmbSongs.ValueMember = "SongID";
        }

        // Loading reviews into the DataGridView
        private void LoadReviews()
        {
            List<Review> reviews = controller.GetAllReviews();

            foreach (var review in reviews)
            {
                review.SongName = controller.GetSongNameByID(review.SongID);
            }
            dgvReviews.DataSource = reviews;

            // Hiding undesired columns
            dgvReviews.Columns["ReviewID"].Visible = false;
            dgvReviews.Columns["SongID"].Visible = false;
            dgvReviews.Columns["UserID"].Visible = false;

            // Setting the Song Name to be the first displayed index
            dgvReviews.Columns["SongName"].DisplayIndex = 0;

            // Setting the Review Text column to be bigger for better readability
            dgvReviews.Columns["ReviewText"].Width = 300;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int songID = (int)cmbSongs.SelectedValue;
            int userID = 1;
            string reviewText = txtReview.Text;
            int rating = (int)nudRating.Value;

            controller.SaveReview(songID, userID, reviewText, rating);

            MessageBox.Show("Review added!");
            LoadReviews();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review.");
                return;
            }

            int reviewID = Convert.ToInt32(
                dgvReviews.SelectedRows[0].Cells["ReviewID"].Value);

            controller.DeleteReview(reviewID);

            MessageBox.Show("Review deleted.");
            LoadReviews();
        }

        private void btnSortRatings_Click(object sender, EventArgs e)
        {
            // Sorts the reviews in the DGV by their Rating Value from highest to lowest
            List<Review> reviews = controller.GetAllReviews();

            foreach (var review in reviews)
            {
                review.SongName = controller.GetSongNameByID(review.SongID);
            }

            // Sorting the reviews by their Rating Values from highest to lowest
            reviews = reviews.OrderByDescending(r => r.RatingValue).ToList();

            dgvReviews.DataSource = reviews;
        }
    }
}
