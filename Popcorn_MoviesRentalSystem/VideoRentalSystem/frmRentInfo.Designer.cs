namespace VideoRentalSystem
{
    partial class frmRentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentInfo));
            this.tblRentalInfo = new System.Windows.Forms.DataGridView();
            this.tblmovieRentalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_videoRentalDataSet6 = new VideoRentalSystem.db_videoRentalDataSet6();
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
            this.tbl_movieRentalInfoTableAdapter = new VideoRentalSystem.db_videoRentalDataSet6TableAdapters.tbl_movieRentalInfoTableAdapter();
            this.movieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inforentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inforentDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inforentFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infopenaltyFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infostatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picMovie = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblRentalInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmovieRentalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNavi)).BeginInit();
            this.topNavi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // tblRentalInfo
            // 
            this.tblRentalInfo.AutoGenerateColumns = false;
            this.tblRentalInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRentalInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieidDataGridViewTextBoxColumn,
            this.inforentTypeDataGridViewTextBoxColumn,
            this.inforentDaysDataGridViewTextBoxColumn,
            this.inforentFeeDataGridViewTextBoxColumn,
            this.infopenaltyFeeDataGridViewTextBoxColumn,
            this.infostatusDataGridViewTextBoxColumn});
            this.tblRentalInfo.DataSource = this.tblmovieRentalInfoBindingSource;
            this.tblRentalInfo.Location = new System.Drawing.Point(325, 79);
            this.tblRentalInfo.Name = "tblRentalInfo";
            this.tblRentalInfo.Size = new System.Drawing.Size(642, 498);
            this.tblRentalInfo.TabIndex = 6;
            this.tblRentalInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRentalInfo_CellContentClick);
            // 
            // tblmovieRentalInfoBindingSource
            // 
            this.tblmovieRentalInfoBindingSource.DataMember = "tbl_movieRentalInfo";
            this.tblmovieRentalInfoBindingSource.DataSource = this.db_videoRentalDataSet6;
            // 
            // db_videoRentalDataSet6
            // 
            this.db_videoRentalDataSet6.DataSetName = "db_videoRentalDataSet6";
            this.db_videoRentalDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // topNavi
            // 
            this.topNavi.AddNewItem = this.bindingNavigatorAddNewItem;
            this.topNavi.BindingSource = this.tblmovieRentalInfoBindingSource;
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
            this.bindingNavigatorAddNewItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
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
            this.btnSearch.Location = new System.Drawing.Point(666, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(325, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 26);
            this.txtSearch.TabIndex = 7;
            // 
            // tbl_movieRentalInfoTableAdapter
            // 
            this.tbl_movieRentalInfoTableAdapter.ClearBeforeFill = true;
            // 
            // movieidDataGridViewTextBoxColumn
            // 
            this.movieidDataGridViewTextBoxColumn.DataPropertyName = "movie_id";
            this.movieidDataGridViewTextBoxColumn.HeaderText = "Movie ID";
            this.movieidDataGridViewTextBoxColumn.Name = "movieidDataGridViewTextBoxColumn";
            this.movieidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inforentTypeDataGridViewTextBoxColumn
            // 
            this.inforentTypeDataGridViewTextBoxColumn.DataPropertyName = "info_rentType";
            this.inforentTypeDataGridViewTextBoxColumn.HeaderText = "Rent Type";
            this.inforentTypeDataGridViewTextBoxColumn.Name = "inforentTypeDataGridViewTextBoxColumn";
            this.inforentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inforentDaysDataGridViewTextBoxColumn
            // 
            this.inforentDaysDataGridViewTextBoxColumn.DataPropertyName = "info_rentDays";
            this.inforentDaysDataGridViewTextBoxColumn.HeaderText = "Rent Days";
            this.inforentDaysDataGridViewTextBoxColumn.Name = "inforentDaysDataGridViewTextBoxColumn";
            this.inforentDaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inforentFeeDataGridViewTextBoxColumn
            // 
            this.inforentFeeDataGridViewTextBoxColumn.DataPropertyName = "info_rentFee";
            this.inforentFeeDataGridViewTextBoxColumn.HeaderText = "Rent Fee";
            this.inforentFeeDataGridViewTextBoxColumn.Name = "inforentFeeDataGridViewTextBoxColumn";
            // 
            // infopenaltyFeeDataGridViewTextBoxColumn
            // 
            this.infopenaltyFeeDataGridViewTextBoxColumn.DataPropertyName = "info_penaltyFee";
            this.infopenaltyFeeDataGridViewTextBoxColumn.HeaderText = "Penalty Fee";
            this.infopenaltyFeeDataGridViewTextBoxColumn.Name = "infopenaltyFeeDataGridViewTextBoxColumn";
            this.infopenaltyFeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infostatusDataGridViewTextBoxColumn
            // 
            this.infostatusDataGridViewTextBoxColumn.DataPropertyName = "info_status";
            this.infostatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.infostatusDataGridViewTextBoxColumn.Name = "infostatusDataGridViewTextBoxColumn";
            this.infostatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // picMovie
            // 
            this.picMovie.Location = new System.Drawing.Point(30, 79);
            this.picMovie.Name = "picMovie";
            this.picMovie.Size = new System.Drawing.Size(251, 298);
            this.picMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMovie.TabIndex = 10;
            this.picMovie.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 384);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(83, 20);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Movie Title";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(30, 443);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 20);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(27, 494);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(115, 20);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year Released";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(30, 407);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(251, 26);
            this.txtTitle.TabIndex = 14;
            // 
            // txtGenre
            // 
            this.txtGenre.Enabled = false;
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(30, 465);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(251, 26);
            this.txtGenre.TabIndex = 15;
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(30, 517);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(251, 26);
            this.txtYear.TabIndex = 16;
            // 
            // frmRentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 642);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picMovie);
            this.Controls.Add(this.tblRentalInfo);
            this.Controls.Add(this.topNavi);
            this.Controls.Add(this.statBar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmRentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Info";
            this.Load += new System.EventHandler(this.frmRentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRentalInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmovieRentalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNavi)).EndInit();
            this.topNavi.ResumeLayout(false);
            this.topNavi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblRentalInfo;
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
        private db_videoRentalDataSet6 db_videoRentalDataSet6;
        private System.Windows.Forms.BindingSource tblmovieRentalInfoBindingSource;
        private db_videoRentalDataSet6TableAdapters.tbl_movieRentalInfoTableAdapter tbl_movieRentalInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inforentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inforentDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inforentFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infopenaltyFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infostatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox picMovie;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtYear;
    }
}