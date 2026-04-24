namespace MusicLibrary
{
    partial class FrmModifyPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyPlaylist));
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.cboSongs = new System.Windows.Forms.ComboBox();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.flpSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.btnStopPreview = new System.Windows.Forms.Button();
            this.wmpPreview = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSongs
            // 
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.Location = new System.Drawing.Point(628, -16);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(239, 186);
            this.lstSongs.TabIndex = 0;
            this.lstSongs.Visible = false;
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(685, 25);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(115, 23);
            this.btnRemoveSong.TabIndex = 1;
            this.btnRemoveSong.Text = "Remove Song";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Visible = false;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // cboSongs
            // 
            this.cboSongs.FormattingEnabled = true;
            this.cboSongs.Location = new System.Drawing.Point(256, 420);
            this.cboSongs.Name = "cboSongs";
            this.cboSongs.Size = new System.Drawing.Size(169, 21);
            this.cboSongs.TabIndex = 2;
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddSong.Location = new System.Drawing.Point(166, 420);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 3;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // flpSongs
            // 
            this.flpSongs.AutoScroll = true;
            this.flpSongs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSongs.Location = new System.Drawing.Point(166, 52);
            this.flpSongs.Name = "flpSongs";
            this.flpSongs.Size = new System.Drawing.Size(443, 360);
            this.flpSongs.TabIndex = 4;
            this.flpSongs.WrapContents = false;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.Location = new System.Drawing.Point(249, 12);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(287, 37);
            this.lblPlaylistName.TabIndex = 5;
            this.lblPlaylistName.Text = "[PLAYLIST NAME]";
            // 
            // btnStopPreview
            // 
            this.btnStopPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStopPreview.Location = new System.Drawing.Point(506, 418);
            this.btnStopPreview.Name = "btnStopPreview";
            this.btnStopPreview.Size = new System.Drawing.Size(103, 23);
            this.btnStopPreview.TabIndex = 7;
            this.btnStopPreview.Text = "Stop Preview";
            this.btnStopPreview.UseVisualStyleBackColor = false;
            this.btnStopPreview.Click += new System.EventHandler(this.btnStopPreview_Click);
            // 
            // wmpPreview
            // 
            this.wmpPreview.Enabled = true;
            this.wmpPreview.Location = new System.Drawing.Point(57, 193);
            this.wmpPreview.Name = "wmpPreview";
            this.wmpPreview.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPreview.OcxState")));
            this.wmpPreview.Size = new System.Drawing.Size(75, 23);
            this.wmpPreview.TabIndex = 6;
            this.wmpPreview.Visible = false;
            // 
            // FrmModifyPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStopPreview);
            this.Controls.Add(this.wmpPreview);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.flpSongs);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.cboSongs);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.lstSongs);
            this.Name = "FrmModifyPlaylist";
            this.Text = "FrmModifyPlaylist";
            ((System.ComponentModel.ISupportInitialize)(this.wmpPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.ComboBox cboSongs;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.FlowLayoutPanel flpSongs;
        private System.Windows.Forms.Label lblPlaylistName;
        private AxWMPLib.AxWindowsMediaPlayer wmpPreview;
        private System.Windows.Forms.Button btnStopPreview;
    }
}