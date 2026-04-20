namespace MusicLibrary
{
    partial class FrmViewPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPlaylists = new System.Windows.Forms.DataGridView();
            this.btnLoadPlaylists = new System.Windows.Forms.Button();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlaylists
            // 
            this.dgvPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylists.Location = new System.Drawing.Point(34, 31);
            this.dgvPlaylists.Name = "dgvPlaylists";
            this.dgvPlaylists.Size = new System.Drawing.Size(381, 150);
            this.dgvPlaylists.TabIndex = 0;
            // 
            // btnLoadPlaylists
            // 
            this.btnLoadPlaylists.Location = new System.Drawing.Point(34, 201);
            this.btnLoadPlaylists.Name = "btnLoadPlaylists";
            this.btnLoadPlaylists.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPlaylists.TabIndex = 1;
            this.btnLoadPlaylists.Text = "Load Playlists";
            this.btnLoadPlaylists.UseVisualStyleBackColor = true;
            this.btnLoadPlaylists.Click += new System.EventHandler(this.btnLoadPlaylists_Click);
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Location = new System.Drawing.Point(34, 250);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(100, 20);
            this.txtPlaylistName.TabIndex = 2;
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.Location = new System.Drawing.Point(34, 292);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlaylist.TabIndex = 3;
            this.btnAddPlaylist.Text = "Add Playlist";
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // FrmViewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.txtPlaylistName);
            this.Controls.Add(this.btnLoadPlaylists);
            this.Controls.Add(this.dgvPlaylists);
            this.Name = "FrmViewPlaylist";
            this.Text = "FrmViewPlaylist";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlaylists;
        private System.Windows.Forms.Button btnLoadPlaylists;
        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.Button btnAddPlaylist;
    }
}