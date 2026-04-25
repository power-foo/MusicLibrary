namespace MusicLibrary
{
    partial class frmSearchSong
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flpSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.chtGenres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.picSelectedAlbum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // flpSongs
            // 
            this.flpSongs.AutoScroll = true;
            this.flpSongs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSongs.Location = new System.Drawing.Point(12, 12);
            this.flpSongs.Name = "flpSongs";
            this.flpSongs.Size = new System.Drawing.Size(648, 313);
            this.flpSongs.TabIndex = 0;
            this.flpSongs.WrapContents = false;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.Navy;
            this.btnSort.Location = new System.Drawing.Point(12, 431);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(125, 81);
            this.btnSort.TabIndex = 23;
            this.btnSort.Text = "Sort By Criteria";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Navy;
            this.btnSearch.Location = new System.Drawing.Point(181, 431);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 81);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search by Criteria";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Navy;
            this.btnClose.Location = new System.Drawing.Point(350, 431);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 81);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close Window";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(12, 374);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(130, 24);
            this.cmbSort.TabIndex = 27;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(181, 374);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(130, 24);
            this.cmbFilter.TabIndex = 28;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.ForeColor = System.Drawing.Color.Navy;
            this.lblSort.Location = new System.Drawing.Point(38, 342);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(71, 20);
            this.lblSort.TabIndex = 29;
            this.lblSort.Text = "Sort By:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Navy;
            this.lblSearch.Location = new System.Drawing.Point(199, 342);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(91, 20);
            this.lblSearch.TabIndex = 30;
            this.lblSearch.Text = "Search By:";
            // 
            // chtGenres
            // 
            this.chtGenres.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chtGenres.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chtGenres.Legends.Add(legend2);
            this.chtGenres.Location = new System.Drawing.Point(519, 342);
            this.chtGenres.Name = "chtGenres";
            this.chtGenres.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtGenres.Series.Add(series2);
            this.chtGenres.Size = new System.Drawing.Size(426, 195);
            this.chtGenres.TabIndex = 31;
            this.chtGenres.Text = "Song Genres";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(713, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 36);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Song Library";
            // 
            // lblCaption
            // 
            this.lblCaption.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.Navy;
            this.lblCaption.Location = new System.Drawing.Point(676, 58);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(269, 69);
            this.lblCaption.TabIndex = 33;
            this.lblCaption.Text = "Browse through our collection of songs. Click any song to preview its album cover" +
    "! You may also sort or search by criteria.";
            // 
            // picSelectedAlbum
            // 
            this.picSelectedAlbum.Location = new System.Drawing.Point(676, 130);
            this.picSelectedAlbum.Name = "picSelectedAlbum";
            this.picSelectedAlbum.Size = new System.Drawing.Size(269, 195);
            this.picSelectedAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelectedAlbum.TabIndex = 24;
            this.picSelectedAlbum.TabStop = false;
            // 
            // frmSearchSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(957, 549);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chtGenres);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.picSelectedAlbum);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.flpSongs);
            this.Name = "frmSearchSong";
            this.Text = "Music Library - Display Songs";
            this.Load += new System.EventHandler(this.frmSearchSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSongs;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.PictureBox picSelectedAlbum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGenres;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCaption;
    }
}