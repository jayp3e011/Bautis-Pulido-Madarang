namespace VideoRentalSystem
{
    partial class frmAddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMovie));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtCast = new System.Windows.Forms.RichTextBox();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.lblRatings = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtRatings = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblCast = new System.Windows.Forms.Label();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picBoxMovie = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(332, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "    Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(261, 68);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(115, 20);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year Released";
            this.lblYear.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCast
            // 
            this.txtCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCast.Location = new System.Drawing.Point(265, 254);
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(180, 97);
            this.txtCast.TabIndex = 6;
            this.txtCast.Text = "";
            this.txtCast.TextChanged += new System.EventHandler(this.txtCast_TextChanged);
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(21, 14);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(83, 20);
            this.lblMovieTitle.TabIndex = 1;
            this.lblMovieTitle.Text = "Movie Title";
            this.lblMovieTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieTitle.Location = new System.Drawing.Point(25, 37);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(219, 26);
            this.txtMovieTitle.TabIndex = 1;
            this.txtMovieTitle.TextChanged += new System.EventHandler(this.txtMovieTitle_TextChanged);
            // 
            // lblRatings
            // 
            this.lblRatings.AutoSize = true;
            this.lblRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatings.Location = new System.Drawing.Point(261, 176);
            this.lblRatings.Name = "lblRatings";
            this.lblRatings.Size = new System.Drawing.Size(64, 20);
            this.lblRatings.TabIndex = 1;
            this.lblRatings.Text = "Ratings";
            this.lblRatings.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(261, 122);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(81, 20);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Language";
            this.lblLanguage.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRatings
            // 
            this.txtRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRatings.Location = new System.Drawing.Point(265, 200);
            this.txtRatings.Name = "txtRatings";
            this.txtRatings.Size = new System.Drawing.Size(180, 26);
            this.txtRatings.TabIndex = 5;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguage.Location = new System.Drawing.Point(265, 146);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(180, 26);
            this.txtLanguage.TabIndex = 4;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(261, 14);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 20);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre";
            this.lblGenre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(265, 38);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(180, 26);
            this.txtGenre.TabIndex = 2;
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCast.Location = new System.Drawing.Point(261, 230);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(50, 20);
            this.lblCast.TabIndex = 1;
            this.lblCast.Text = "Casts";
            this.lblCast.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboYear
            // 
            this.comboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Items.AddRange(new object[] {
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960"});
            this.comboYear.Location = new System.Drawing.Point(265, 92);
            this.comboYear.MaxDropDownItems = 100;
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(180, 26);
            this.comboYear.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(181, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "   Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picBoxMovie
            // 
            this.picBoxMovie.Location = new System.Drawing.Point(25, 69);
            this.picBoxMovie.Name = "picBoxMovie";
            this.picBoxMovie.Size = new System.Drawing.Size(219, 264);
            this.picBoxMovie.TabIndex = 9;
            this.picBoxMovie.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(168, 340);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 26);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtImgPath
            // 
            this.txtImgPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImgPath.Location = new System.Drawing.Point(25, 340);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.Size = new System.Drawing.Size(137, 26);
            this.txtImgPath.TabIndex = 7;
            // 
            // frmAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 429);
            this.Controls.Add(this.txtImgPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picBoxMovie);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.txtCast);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtRatings);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblRatings);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddMovie";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.frmAddMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.RichTextBox txtCast;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label lblRatings;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.TextBox txtRatings;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picBoxMovie;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtImgPath;
    }
}