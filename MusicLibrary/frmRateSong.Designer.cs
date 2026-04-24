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
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblReviewTitle = new System.Windows.Forms.Label();
            this.lblReviewCaption = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaveTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.txtReview = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReviews
            // 
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Location = new System.Drawing.Point(12, 61);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.RowHeadersWidth = 51;
            this.dgvReviews.RowTemplate.Height = 24;
            this.dgvReviews.Size = new System.Drawing.Size(522, 476);
            this.dgvReviews.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Navy;
            this.btnSave.Location = new System.Drawing.Point(607, 330);
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
            this.lblReviewCaption.Size = new System.Drawing.Size(386, 74);
            this.lblReviewCaption.TabIndex = 34;
            this.lblReviewCaption.Text = "Browse through our curated reviews, or leave a review of your own! You may also r" +
    "emove a review if you desire.";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Navy;
            this.btnClose.Location = new System.Drawing.Point(693, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 81);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close Window";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Location = new System.Drawing.Point(774, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 81);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete Review";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(559, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 51);
            this.label1.TabIndex = 37;
            this.label1.Text = "To leave a song review, please complete the form below.";
            // 
            // lblSaveTitle
            // 
            this.lblSaveTitle.AutoSize = true;
            this.lblSaveTitle.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblSaveTitle.Location = new System.Drawing.Point(559, 160);
            this.lblSaveTitle.Name = "lblSaveTitle";
            this.lblSaveTitle.Size = new System.Drawing.Size(92, 20);
            this.lblSaveTitle.TabIndex = 38;
            this.lblSaveTitle.Text = "Song Title:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(668, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 24);
            this.comboBox1.TabIndex = 39;
            // 
            // nudRating
            // 
            this.nudRating.Location = new System.Drawing.Point(682, 205);
            this.nudRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(120, 22);
            this.nudRating.TabIndex = 40;
            this.nudRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ForeColor = System.Drawing.Color.Navy;
            this.lblRating.Location = new System.Drawing.Point(559, 204);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(108, 20);
            this.lblRating.TabIndex = 41;
            this.lblRating.Text = "Rating (0-5):";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.ForeColor = System.Drawing.Color.Navy;
            this.lblReview.Location = new System.Drawing.Point(624, 252);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(257, 20);
            this.lblReview.TabIndex = 42;
            this.lblReview.Text = "Please leave your review below.";
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(563, 281);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(382, 22);
            this.txtReview.TabIndex = 43;
            // 
            // frmRateSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(957, 549);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSaveTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblReviewCaption);
            this.Controls.Add(this.lblReviewTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvReviews);
            this.Name = "frmRateSong";
            this.Text = "Music Library - Rate a Song";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblReviewTitle;
        private System.Windows.Forms.Label lblReviewCaption;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaveTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.TextBox txtReview;
    }
}