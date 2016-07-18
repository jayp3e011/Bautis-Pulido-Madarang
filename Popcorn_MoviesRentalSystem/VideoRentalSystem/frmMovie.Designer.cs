namespace VideoRentalSystem
{
    partial class frmMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovie));
            this.tblMovies = new System.Windows.Forms.DataGridView();
            this.topNavi = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statBar = new System.Windows.Forms.StatusStrip();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.db_videoRentalDataSet1 = new VideoRentalSystem.db_videoRentalDataSet1();
            this.tblmoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_moviesTableAdapter = new VideoRentalSystem.db_videoRentalDataSet1TableAdapters.tbl_moviesTableAdapter();
            this.movieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movietitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviegenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movielanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviecastsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieyearReleasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNavi)).BeginInit();
            this.topNavi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmoviesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMovies
            // 
            this.tblMovies.AllowUserToDeleteRows = false;
            this.tblMovies.AutoGenerateColumns = false;
            this.tblMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieidDataGridViewTextBoxColumn,
            this.movietitleDataGridViewTextBoxColumn,
            this.moviegenreDataGridViewTextBoxColumn,
            this.movieratingDataGridViewTextBoxColumn,
            this.movielanguageDataGridViewTextBoxColumn,
            this.moviecastsDataGridViewTextBoxColumn,
            this.movieyearReleasedDataGridViewTextBoxColumn});
            this.tblMovies.DataSource = this.tblmoviesBindingSource;
            this.tblMovies.Location = new System.Drawing.Point(35, 81);
            this.tblMovies.Name = "tblMovies";
            this.tblMovies.ReadOnly = true;
            this.tblMovies.Size = new System.Drawing.Size(932, 498);
            this.tblMovies.TabIndex = 6;
            // 
            // topNavi
            // 
            this.topNavi.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.topNavi.AddNewItem = this.bindingNavigatorAddNewItem;
            this.topNavi.BindingSource = this.tblmoviesBindingSource;
            this.topNavi.CountItem = this.bindingNavigatorCountItem;
            this.topNavi.DeleteItem = this.bindingNavigatorDeleteItem;
            this.topNavi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.topNavi.Location = new System.Drawing.Point(0, 0);
            this.topNavi.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.topNavi.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.topNavi.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.topNavi.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.topNavi.Name = "topNavi";
            this.topNavi.PositionItem = this.bindingNavigatorPositionItem;
            this.topNavi.Size = new System.Drawing.Size(1004, 25);
            this.topNavi.TabIndex = 5;
            this.topNavi.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statBar
            // 
            this.statBar.Location = new System.Drawing.Point(0, 620);
            this.statBar.Name = "statBar";
            this.statBar.Size = new System.Drawing.Size(1004, 22);
            this.statBar.TabIndex = 9;
            this.statBar.Text = "statusStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(376, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(35, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 26);
            this.txtSearch.TabIndex = 7;
            // 
            // db_videoRentalDataSet1
            // 
            this.db_videoRentalDataSet1.DataSetName = "db_videoRentalDataSet1";
            this.db_videoRentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmoviesBindingSource
            // 
            this.tblmoviesBindingSource.DataMember = "tbl_movies";
            this.tblmoviesBindingSource.DataSource = this.db_videoRentalDataSet1;
            // 
            // tbl_moviesTableAdapter
            // 
            this.tbl_moviesTableAdapter.ClearBeforeFill = true;
            // 
            // movieidDataGridViewTextBoxColumn
            // 
            this.movieidDataGridViewTextBoxColumn.DataPropertyName = "movie_id";
            this.movieidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.movieidDataGridViewTextBoxColumn.Name = "movieidDataGridViewTextBoxColumn";
            this.movieidDataGridViewTextBoxColumn.ReadOnly = true;
            this.movieidDataGridViewTextBoxColumn.Width = 120;
            // 
            // movietitleDataGridViewTextBoxColumn
            // 
            this.movietitleDataGridViewTextBoxColumn.DataPropertyName = "movie_title";
            this.movietitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.movietitleDataGridViewTextBoxColumn.Name = "movietitleDataGridViewTextBoxColumn";
            this.movietitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.movietitleDataGridViewTextBoxColumn.Width = 250;
            // 
            // moviegenreDataGridViewTextBoxColumn
            // 
            this.moviegenreDataGridViewTextBoxColumn.DataPropertyName = "movie_genre";
            this.moviegenreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.moviegenreDataGridViewTextBoxColumn.Name = "moviegenreDataGridViewTextBoxColumn";
            this.moviegenreDataGridViewTextBoxColumn.ReadOnly = true;
            this.moviegenreDataGridViewTextBoxColumn.Width = 80;
            // 
            // movieratingDataGridViewTextBoxColumn
            // 
            this.movieratingDataGridViewTextBoxColumn.DataPropertyName = "movie_rating";
            this.movieratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.movieratingDataGridViewTextBoxColumn.Name = "movieratingDataGridViewTextBoxColumn";
            this.movieratingDataGridViewTextBoxColumn.ReadOnly = true;
            this.movieratingDataGridViewTextBoxColumn.Width = 50;
            // 
            // movielanguageDataGridViewTextBoxColumn
            // 
            this.movielanguageDataGridViewTextBoxColumn.DataPropertyName = "movie_language";
            this.movielanguageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.movielanguageDataGridViewTextBoxColumn.Name = "movielanguageDataGridViewTextBoxColumn";
            this.movielanguageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moviecastsDataGridViewTextBoxColumn
            // 
            this.moviecastsDataGridViewTextBoxColumn.DataPropertyName = "movie_casts";
            this.moviecastsDataGridViewTextBoxColumn.HeaderText = "Casts";
            this.moviecastsDataGridViewTextBoxColumn.Name = "moviecastsDataGridViewTextBoxColumn";
            this.moviecastsDataGridViewTextBoxColumn.ReadOnly = true;
            this.moviecastsDataGridViewTextBoxColumn.Width = 200;
            // 
            // movieyearReleasedDataGridViewTextBoxColumn
            // 
            this.movieyearReleasedDataGridViewTextBoxColumn.DataPropertyName = "movie_yearReleased";
            this.movieyearReleasedDataGridViewTextBoxColumn.HeaderText = "Year Released";
            this.movieyearReleasedDataGridViewTextBoxColumn.Name = "movieyearReleasedDataGridViewTextBoxColumn";
            this.movieyearReleasedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VideoRentalSystem.Properties.Resources.staffMainBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 642);
            this.Controls.Add(this.tblMovies);
            this.Controls.Add(this.topNavi);
            this.Controls.Add(this.statBar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.DoubleBuffered = true;
            this.Name = "frmMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.frmMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNavi)).EndInit();
            this.topNavi.ResumeLayout(false);
            this.topNavi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmoviesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblMovies;
        private System.Windows.Forms.BindingNavigator topNavi;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.StatusStrip statBar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private db_videoRentalDataSet1 db_videoRentalDataSet1;
        private System.Windows.Forms.BindingSource tblmoviesBindingSource;
        private db_videoRentalDataSet1TableAdapters.tbl_moviesTableAdapter tbl_moviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movietitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviegenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movielanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviecastsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieyearReleasedDataGridViewTextBoxColumn;
    }
}