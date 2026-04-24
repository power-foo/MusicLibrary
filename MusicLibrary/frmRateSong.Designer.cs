namespace MusicLibrary
{
    partial class frmRateSong
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
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblReviewTitle = new System.Windows.Forms.Label();
            this.lblReviewCaption = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSongs
            // 
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Location = new System.Drawing.Point(12, 61);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.RowHeadersWidth = 51;
            this.dgvSongs.RowTemplate.Height = 24;
            this.dgvSongs.Size = new System.Drawing.Size(527, 476);
            this.dgvSongs.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Navy;
            this.btnSave.Location = new System.Drawing.Point(563, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 81);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save Review";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblReviewTitle
            // 
            this.lblReviewTitle.AutoSize = true;
            this.lblReviewTitle.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblReviewTitle.Location = new System.Drawing.Point(172, 9);
            this.lblReviewTitle.Name = "lblReviewTitle";
            this.lblReviewTitle.Size = new System.Drawing.Size(201, 36);
            this.lblReviewTitle.TabIndex = 33;
            this.lblReviewTitle.Text = "Song Reviews";
            // 
            // lblReviewCaption
            // 
            this.lblReviewCaption.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewCaption.ForeColor = System.Drawing.Color.Navy;
            this.lblReviewCaption.Location = new System.Drawing.Point(559, 20);
            this.lblReviewCaption.Name = "lblReviewCaption";
            this.lblReviewCaption.Size = new System.Drawing.Size(386, 67);
            this.lblReviewCaption.TabIndex = 34;
            this.lblReviewCaption.Text = "Browse through our curated reviews, or leave a review of your own!";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Navy;
            this.btnClose.Location = new System.Drawing.Point(820, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 81);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close Window";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRateSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(957, 549);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblReviewCaption);
            this.Controls.Add(this.lblReviewTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvSongs);
            this.Name = "frmRateSong";
            this.Text = "Music Library - Rate a Song";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblReviewTitle;
        private System.Windows.Forms.Label lblReviewCaption;
        private System.Windows.Forms.Button btnClose;
    }
}