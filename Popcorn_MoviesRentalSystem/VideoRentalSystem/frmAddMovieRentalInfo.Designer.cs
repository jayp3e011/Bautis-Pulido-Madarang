namespace VideoRentalSystem
{
    partial class frmAddMovieRentalInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMovieRentalInfo));
            this.txtRenaltFee = new System.Windows.Forms.TextBox();
            this.txtRentType = new System.Windows.Forms.TextBox();
            this.txtPenaltyFee = new System.Windows.Forms.TextBox();
            this.lblRenaltFee = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblRentType = new System.Windows.Forms.Label();
            this.lblPenaltyFee = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.imgMoviePoster = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.moviesView = new System.Windows.Forms.DataGridView();
            this.movieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movietitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviegenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movielanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviecastsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieyearReleasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieimageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getMovieSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_videoRentalDataSet7 = new VideoRentalSystem.db_videoRentalDataSet7();
            this.getMovieSetTableAdapter = new VideoRentalSystem.db_videoRentalDataSet7TableAdapters.GetMovieSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoviePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMovieSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRenaltFee
            // 
            this.txtRenaltFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenaltFee.Location = new System.Drawing.Point(26, 470);
            this.txtRenaltFee.Name = "txtRenaltFee";
            this.txtRenaltFee.Size = new System.Drawing.Size(245, 26);
            this.txtRenaltFee.TabIndex = 3;
            // 
            // txtRentType
            // 
            this.txtRentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentType.Location = new System.Drawing.Point(26, 362);
            this.txtRentType.Name = "txtRentType";
            this.txtRentType.Size = new System.Drawing.Size(245, 26);
            this.txtRentType.TabIndex = 1;
            // 
            // txtPenaltyFee
            // 
            this.txtPenaltyFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenaltyFee.Location = new System.Drawing.Point(26, 524);
            this.txtPenaltyFee.Name = "txtPenaltyFee";
            this.txtPenaltyFee.Size = new System.Drawing.Size(245, 26);
            this.txtPenaltyFee.TabIndex = 4;
            // 
            // lblRenaltFee
            // 
            this.lblRenaltFee.AutoSize = true;
            this.lblRenaltFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenaltFee.Location = new System.Drawing.Point(22, 446);
            this.lblRenaltFee.Name = "lblRenaltFee";
            this.lblRenaltFee.Size = new System.Drawing.Size(88, 20);
            this.lblRenaltFee.TabIndex = 4;
            this.lblRenaltFee.Text = "Rental Fee";
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(26, 416);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(245, 26);
            this.txtDays.TabIndex = 2;
            // 
            // lblRentType
            // 
            this.lblRentType.AutoSize = true;
            this.lblRentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentType.Location = new System.Drawing.Point(22, 338);
            this.lblRentType.Name = "lblRentType";
            this.lblRentType.Size = new System.Drawing.Size(94, 20);
            this.lblRentType.TabIndex = 5;
            this.lblRentType.Text = "Rental Type";
            // 
            // lblPenaltyFee
            // 
            this.lblPenaltyFee.AutoSize = true;
            this.lblPenaltyFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenaltyFee.Location = new System.Drawing.Point(22, 500);
            this.lblPenaltyFee.Name = "lblPenaltyFee";
            this.lblPenaltyFee.Size = new System.Drawing.Size(93, 20);
            this.lblPenaltyFee.TabIndex = 6;
            this.lblPenaltyFee.Text = "Penalty Fee";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(22, 392);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(91, 20);
            this.lblDays.TabIndex = 7;
            this.lblDays.Text = "No. of Days";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(158, 596);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "    Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMovieID
            // 
            this.txtMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieID.Location = new System.Drawing.Point(26, 28);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(245, 26);
            this.txtMovieID.TabIndex = 0;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(22, 5);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(71, 20);
            this.lblMovieID.TabIndex = 12;
            this.lblMovieID.Text = "Movie ID";
            // 
            // imgMoviePoster
            // 
            this.imgMoviePoster.Location = new System.Drawing.Point(26, 59);
            this.imgMoviePoster.Name = "imgMoviePoster";
            this.imgMoviePoster.Size = new System.Drawing.Size(245, 264);
            this.imgMoviePoster.TabIndex = 14;
            this.imgMoviePoster.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(12, 596);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 34);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // moviesView
            // 
            this.moviesView.AutoGenerateColumns = false;
            this.moviesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieidDataGridViewTextBoxColumn,
            this.movietitleDataGridViewTextBoxColumn,
            this.moviegenreDataGridViewTextBoxColumn,
            this.movieratingDataGridViewTextBoxColumn,
            this.movielanguageDataGridViewTextBoxColumn,
            this.moviecastsDataGridViewTextBoxColumn,
            this.movieyearReleasedDataGridViewTextBoxColumn,
            this.movieimageDataGridViewTextBoxColumn});
            this.moviesView.DataSource = this.getMovieSetBindingSource;
            this.moviesView.Location = new System.Drawing.Point(291, 59);
            this.moviesView.Name = "moviesView";
            this.moviesView.Size = new System.Drawing.Size(671, 571);
            this.moviesView.TabIndex = 16;
            this.moviesView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesView_CellContentClick);
            this.moviesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesView_CellContentClick);
            // 
            // movieidDataGridViewTextBoxColumn
            // 
            this.movieidDataGridViewTextBoxColumn.DataPropertyName = "movie_id";
            this.movieidDataGridViewTextBoxColumn.HeaderText = "Movie ID";
            this.movieidDataGridViewTextBoxColumn.Name = "movieidDataGridViewTextBoxColumn";
            // 
            // movietitleDataGridViewTextBoxColumn
            // 
            this.movietitleDataGridViewTextBoxColumn.DataPropertyName = "movie_title";
            this.movietitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.movietitleDataGridViewTextBoxColumn.Name = "movietitleDataGridViewTextBoxColumn";
            this.movietitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // moviegenreDataGridViewTextBoxColumn
            // 
            this.moviegenreDataGridViewTextBoxColumn.DataPropertyName = "movie_genre";
            this.moviegenreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.moviegenreDataGridViewTextBoxColumn.Name = "moviegenreDataGridViewTextBoxColumn";
            // 
            // movieratingDataGridViewTextBoxColumn
            // 
            this.movieratingDataGridViewTextBoxColumn.DataPropertyName = "movie_rating";
            this.movieratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.movieratingDataGridViewTextBoxColumn.Name = "movieratingDataGridViewTextBoxColumn";
            // 
            // movielanguageDataGridViewTextBoxColumn
            // 
            this.movielanguageDataGridViewTextBoxColumn.DataPropertyName = "movie_language";
            this.movielanguageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.movielanguageDataGridViewTextBoxColumn.Name = "movielanguageDataGridViewTextBoxColumn";
            this.movielanguageDataGridViewTextBoxColumn.Visible = false;
            // 
            // moviecastsDataGridViewTextBoxColumn
            // 
            this.moviecastsDataGridViewTextBoxColumn.DataPropertyName = "movie_casts";
            this.moviecastsDataGridViewTextBoxColumn.HeaderText = "Casts";
            this.moviecastsDataGridViewTextBoxColumn.Name = "moviecastsDataGridViewTextBoxColumn";
            this.moviecastsDataGridViewTextBoxColumn.Width = 105;
            // 
            // movieyearReleasedDataGridViewTextBoxColumn
            // 
            this.movieyearReleasedDataGridViewTextBoxColumn.DataPropertyName = "movie_yearReleased";
            this.movieyearReleasedDataGridViewTextBoxColumn.HeaderText = "Year Released";
            this.movieyearReleasedDataGridViewTextBoxColumn.Name = "movieyearReleasedDataGridViewTextBoxColumn";
            // 
            // movieimageDataGridViewTextBoxColumn
            // 
            this.movieimageDataGridViewTextBoxColumn.DataPropertyName = "movie_image";
            this.movieimageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.movieimageDataGridViewTextBoxColumn.Name = "movieimageDataGridViewTextBoxColumn";
            this.movieimageDataGridViewTextBoxColumn.Visible = false;
            // 
            // getMovieSetBindingSource
            // 
            this.getMovieSetBindingSource.DataMember = "GetMovieSet";
            this.getMovieSetBindingSource.DataSource = this.db_videoRentalDataSet7;
            // 
            // db_videoRentalDataSet7
            // 
            this.db_videoRentalDataSet7.DataSetName = "db_videoRentalDataSet7";
            this.db_videoRentalDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getMovieSetTableAdapter
            // 
            this.getMovieSetTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddMovieRentalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 642);
            this.Controls.Add(this.moviesView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.imgMoviePoster);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.txtRenaltFee);
            this.Controls.Add(this.txtRentType);
            this.Controls.Add(this.txtPenaltyFee);
            this.Controls.Add(this.lblRenaltFee);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblRentType);
            this.Controls.Add(this.lblPenaltyFee);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAddMovieRentalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Movie Rental Information";
            this.Load += new System.EventHandler(this.frmAddMovieRentalInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMoviePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMovieSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRenaltFee;
        private System.Windows.Forms.TextBox txtRentType;
        private System.Windows.Forms.TextBox txtPenaltyFee;
        private System.Windows.Forms.Label lblRenaltFee;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblRentType;
        private System.Windows.Forms.Label lblPenaltyFee;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.PictureBox imgMoviePoster;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView moviesView;
        private db_videoRentalDataSet7 db_videoRentalDataSet7;
        private System.Windows.Forms.BindingSource getMovieSetBindingSource;
        private db_videoRentalDataSet7TableAdapters.GetMovieSetTableAdapter getMovieSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movietitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviegenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movielanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviecastsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieyearReleasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieimageDataGridViewTextBoxColumn;
    }
}