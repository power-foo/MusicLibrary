namespace MusicLibrary
{
    partial class FrmMain
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewPlaylist = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.btnSearchSongs = new System.Windows.Forms.Button();
            this.btnModifyPlaylist = new System.Windows.Forms.Button();
            this.btnRateSongs = new System.Windows.Forms.Button();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(836, 540);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewPlaylist
            // 
            this.btnViewPlaylist.Location = new System.Drawing.Point(251, 189);
            this.btnViewPlaylist.Name = "btnViewPlaylist";
            this.btnViewPlaylist.Size = new System.Drawing.Size(190, 77);
            this.btnViewPlaylist.TabIndex = 1;
            this.btnViewPlaylist.Text = "View Playlist";
            this.btnViewPlaylist.UseVisualStyleBackColor = true;
            this.btnViewPlaylist.Click += new System.EventHandler(this.btnViewPlaylist_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(360, 99);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(295, 29);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Welcome, [USERNAME]";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(29, 25);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(168, 29);
            this.lblTitle1.TabIndex = 3;
            this.lblTitle1.Text = "Music Library";
            // 
            // btnSearchSongs
            // 
            this.btnSearchSongs.Location = new System.Drawing.Point(591, 189);
            this.btnSearchSongs.Name = "btnSearchSongs";
            this.btnSearchSongs.Size = new System.Drawing.Size(190, 77);
            this.btnSearchSongs.TabIndex = 4;
            this.btnSearchSongs.Text = "Search Songs";
            this.btnSearchSongs.UseVisualStyleBackColor = true;
            this.btnSearchSongs.Click += new System.EventHandler(this.btnSearchSongs_Click);
            // 
            // btnModifyPlaylist
            // 
            this.btnModifyPlaylist.Location = new System.Drawing.Point(251, 323);
            this.btnModifyPlaylist.Name = "btnModifyPlaylist";
            this.btnModifyPlaylist.Size = new System.Drawing.Size(190, 77);
            this.btnModifyPlaylist.TabIndex = 5;
            this.btnModifyPlaylist.Text = "Modify Playlist";
            this.btnModifyPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnRateSongs
            // 
            this.btnRateSongs.Location = new System.Drawing.Point(591, 323);
            this.btnRateSongs.Name = "btnRateSongs";
            this.btnRateSongs.Size = new System.Drawing.Size(190, 77);
            this.btnRateSongs.TabIndex = 6;
            this.btnRateSongs.Text = "Rate Songs";
            this.btnRateSongs.UseVisualStyleBackColor = true;
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.Location = new System.Drawing.Point(29, 54);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(257, 24);
            this.lblTitle3.TabIndex = 7;
            this.lblTitle3.Text = "Choose an option to continue";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1006, 591);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.btnRateSongs);
            this.Controls.Add(this.btnModifyPlaylist);
            this.Controls.Add(this.btnSearchSongs);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.btnViewPlaylist);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmMain";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewPlaylist;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Button btnSearchSongs;
        private System.Windows.Forms.Button btnModifyPlaylist;
        private System.Windows.Forms.Button btnRateSongs;
        private System.Windows.Forms.Label lblTitle3;
    }
}