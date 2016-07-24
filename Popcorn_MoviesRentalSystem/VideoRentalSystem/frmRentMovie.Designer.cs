namespace VideoRentalSystem
{
    partial class frmRentMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentMovie));
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.txtRenaltFee = new System.Windows.Forms.TextBox();
            this.txtPenaltyFee = new System.Windows.Forms.TextBox();
            this.lblRenaltFee = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.imgRentMoviePoster = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDateBorrowed = new System.Windows.Forms.Label();
            this.lblCostumerID = new System.Windows.Forms.Label();
            this.txtCostumerID = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.customerView = new System.Windows.Forms.DataGridView();
            this.tblcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_videoRentalDataSet = new VideoRentalSystem.db_videoRentalDataSet();
            this.moviesView = new System.Windows.Forms.DataGridView();
            this.movieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inforentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inforentDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inforentFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infopenaltyFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infostatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblmovieRentalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_videoRentalDataSet2 = new VideoRentalSystem.db_videoRentalDataSet2();
            this.txtDateBorrowed = new System.Windows.Forms.DateTimePicker();
            this.txtDateReturned = new System.Windows.Forms.DateTimePicker();
            this.tbl_customerTableAdapter = new VideoRentalSystem.db_videoRentalDataSetTableAdapters.tbl_customerTableAdapter();
            this.db_videoRentalDataSet1 = new VideoRentalSystem.db_videoRentalDataSet1();
            this.dbvideoRentalDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_movieRentalInfoTableAdapter = new VideoRentalSystem.db_videoRentalDataSet2TableAdapters.tbl_movieRentalInfoTableAdapter();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerfirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerlastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customermiddleInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeremailAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customercontactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerregisteredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imgRentMoviePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmovieRentalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbvideoRentalDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMovieID
            // 
            this.txtMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieID.Location = new System.Drawing.Point(25, 37);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(278, 26);
            this.txtMovieID.TabIndex = 0;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(21, 14);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(71, 20);
            this.lblMovieID.TabIndex = 24;
            this.lblMovieID.Text = "Movie ID";
            // 
            // txtRenaltFee
            // 
            this.txtRenaltFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenaltFee.Location = new System.Drawing.Point(27, 582);
            this.txtRenaltFee.Name = "txtRenaltFee";
            this.txtRenaltFee.Size = new System.Drawing.Size(276, 26);
            this.txtRenaltFee.TabIndex = 4;
            // 
            // txtPenaltyFee
            // 
            this.txtPenaltyFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenaltyFee.Location = new System.Drawing.Point(27, 640);
            this.txtPenaltyFee.Name = "txtPenaltyFee";
            this.txtPenaltyFee.Size = new System.Drawing.Size(276, 26);
            this.txtPenaltyFee.TabIndex = 6;
            // 
            // lblRenaltFee
            // 
            this.lblRenaltFee.AutoSize = true;
            this.lblRenaltFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenaltFee.Location = new System.Drawing.Point(23, 558);
            this.lblRenaltFee.Name = "lblRenaltFee";
            this.lblRenaltFee.Size = new System.Drawing.Size(88, 20);
            this.lblRenaltFee.TabIndex = 16;
            this.lblRenaltFee.Text = "Rental Fee";
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(27, 528);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(276, 26);
            this.txtDays.TabIndex = 3;
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturned.Location = new System.Drawing.Point(23, 450);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(115, 20);
            this.lblDateReturned.TabIndex = 17;
            this.lblDateReturned.Text = "Date Returned";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(22, 504);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(125, 20);
            this.lblDays.TabIndex = 19;
            this.lblDays.Text = "Total no. of days";
            // 
            // imgRentMoviePoster
            // 
            this.imgRentMoviePoster.Location = new System.Drawing.Point(25, 69);
            this.imgRentMoviePoster.Name = "imgRentMoviePoster";
            this.imgRentMoviePoster.Size = new System.Drawing.Size(278, 264);
            this.imgRentMoviePoster.TabIndex = 26;
            this.imgRentMoviePoster.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(190, 695);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "    Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDateBorrowed
            // 
            this.lblDateBorrowed.AutoSize = true;
            this.lblDateBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBorrowed.Location = new System.Drawing.Point(22, 396);
            this.lblDateBorrowed.Name = "lblDateBorrowed";
            this.lblDateBorrowed.Size = new System.Drawing.Size(116, 20);
            this.lblDateBorrowed.TabIndex = 17;
            this.lblDateBorrowed.Text = "Date Borrowed";
            // 
            // lblCostumerID
            // 
            this.lblCostumerID.AutoSize = true;
            this.lblCostumerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostumerID.Location = new System.Drawing.Point(22, 342);
            this.lblCostumerID.Name = "lblCostumerID";
            this.lblCostumerID.Size = new System.Drawing.Size(99, 20);
            this.lblCostumerID.TabIndex = 24;
            this.lblCostumerID.Text = "Costumer ID";
            // 
            // txtCostumerID
            // 
            this.txtCostumerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostumerID.Location = new System.Drawing.Point(26, 366);
            this.txtCostumerID.Name = "txtCostumerID";
            this.txtCostumerID.Size = new System.Drawing.Size(277, 26);
            this.txtCostumerID.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(27, 612);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(111, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Penalty Fee";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(25, 695);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 34);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // customerView
            // 
            this.customerView.AutoGenerateColumns = false;
            this.customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.customerfirstNameDataGridViewTextBoxColumn,
            this.customerlastNameDataGridViewTextBoxColumn,
            this.customermiddleInitialDataGridViewTextBoxColumn,
            this.customeraddressDataGridViewTextBoxColumn,
            this.customeremailAddDataGridViewTextBoxColumn,
            this.customercontactNoDataGridViewTextBoxColumn,
            this.customerstatusDataGridViewTextBoxColumn,
            this.customerregisteredDateDataGridViewTextBoxColumn});
            this.customerView.DataSource = this.tblcustomerBindingSource;
            this.customerView.Location = new System.Drawing.Point(354, 69);
            this.customerView.Name = "customerView";
            this.customerView.Size = new System.Drawing.Size(594, 293);
            this.customerView.TabIndex = 28;
            this.customerView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerView_CellContentClick);
            // 
            // tblcustomerBindingSource
            // 
            this.tblcustomerBindingSource.DataMember = "tbl_customer";
            this.tblcustomerBindingSource.DataSource = this.db_videoRentalDataSet;
            // 
            // db_videoRentalDataSet
            // 
            this.db_videoRentalDataSet.DataSetName = "db_videoRentalDataSet";
            this.db_videoRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesView
            // 
            this.moviesView.AutoGenerateColumns = false;
            this.moviesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieidDataGridViewTextBoxColumn,
            this.inforentTypeDataGridViewTextBoxColumn,
            this.inforentDaysDataGridViewTextBoxColumn,
            this.inforentFeeDataGridViewTextBoxColumn,
            this.infopenaltyFeeDataGridViewTextBoxColumn,
            this.infostatusDataGridViewTextBoxColumn});
            this.moviesView.DataSource = this.tblmovieRentalInfoBindingSource;
            this.moviesView.Location = new System.Drawing.Point(354, 420);
            this.moviesView.Name = "moviesView";
            this.moviesView.Size = new System.Drawing.Size(594, 293);
            this.moviesView.TabIndex = 29;
            this.moviesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesView_CellContentClick);
            // 
            // movieidDataGridViewTextBoxColumn
            // 
            this.movieidDataGridViewTextBoxColumn.DataPropertyName = "movie_id";
            this.movieidDataGridViewTextBoxColumn.HeaderText = "Movie ID";
            this.movieidDataGridViewTextBoxColumn.Name = "movieidDataGridViewTextBoxColumn";
            // 
            // inforentTypeDataGridViewTextBoxColumn
            // 
            this.inforentTypeDataGridViewTextBoxColumn.DataPropertyName = "info_rentType";
            this.inforentTypeDataGridViewTextBoxColumn.HeaderText = "Rent Type";
            this.inforentTypeDataGridViewTextBoxColumn.Name = "inforentTypeDataGridViewTextBoxColumn";
            // 
            // inforentDaysDataGridViewTextBoxColumn
            // 
            this.inforentDaysDataGridViewTextBoxColumn.DataPropertyName = "info_rentDays";
            this.inforentDaysDataGridViewTextBoxColumn.HeaderText = "Rent Days";
            this.inforentDaysDataGridViewTextBoxColumn.Name = "inforentDaysDataGridViewTextBoxColumn";
            this.inforentDaysDataGridViewTextBoxColumn.Width = 60;
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
            // 
            // infostatusDataGridViewTextBoxColumn
            // 
            this.infostatusDataGridViewTextBoxColumn.DataPropertyName = "info_status";
            this.infostatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.infostatusDataGridViewTextBoxColumn.Name = "infostatusDataGridViewTextBoxColumn";
            // 
            // tblmovieRentalInfoBindingSource
            // 
            this.tblmovieRentalInfoBindingSource.DataMember = "tbl_movieRentalInfo";
            this.tblmovieRentalInfoBindingSource.DataSource = this.db_videoRentalDataSet2;
            // 
            // db_videoRentalDataSet2
            // 
            this.db_videoRentalDataSet2.DataSetName = "db_videoRentalDataSet2";
            this.db_videoRentalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDateBorrowed
            // 
            this.txtDateBorrowed.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateBorrowed.Location = new System.Drawing.Point(25, 420);
            this.txtDateBorrowed.Name = "txtDateBorrowed";
            this.txtDateBorrowed.Size = new System.Drawing.Size(278, 20);
            this.txtDateBorrowed.TabIndex = 30;
            // 
            // txtDateReturned
            // 
            this.txtDateReturned.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateReturned.Location = new System.Drawing.Point(25, 473);
            this.txtDateReturned.Name = "txtDateReturned";
            this.txtDateReturned.Size = new System.Drawing.Size(278, 20);
            this.txtDateReturned.TabIndex = 31;
            // 
            // tbl_customerTableAdapter
            // 
            this.tbl_customerTableAdapter.ClearBeforeFill = true;
            // 
            // db_videoRentalDataSet1
            // 
            this.db_videoRentalDataSet1.DataSetName = "db_videoRentalDataSet1";
            this.db_videoRentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbvideoRentalDataSet1BindingSource
            // 
            this.dbvideoRentalDataSet1BindingSource.DataSource = this.db_videoRentalDataSet1;
            this.dbvideoRentalDataSet1BindingSource.Position = 0;
            // 
            // tbl_movieRentalInfoTableAdapter
            // 
            this.tbl_movieRentalInfoTableAdapter.ClearBeforeFill = true;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "Custumer ID";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // customerfirstNameDataGridViewTextBoxColumn
            // 
            this.customerfirstNameDataGridViewTextBoxColumn.DataPropertyName = "customer_firstName";
            this.customerfirstNameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.customerfirstNameDataGridViewTextBoxColumn.Name = "customerfirstNameDataGridViewTextBoxColumn";
            // 
            // customerlastNameDataGridViewTextBoxColumn
            // 
            this.customerlastNameDataGridViewTextBoxColumn.DataPropertyName = "customer_lastName";
            this.customerlastNameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.customerlastNameDataGridViewTextBoxColumn.Name = "customerlastNameDataGridViewTextBoxColumn";
            // 
            // customermiddleInitialDataGridViewTextBoxColumn
            // 
            this.customermiddleInitialDataGridViewTextBoxColumn.DataPropertyName = "customer_middleInitial";
            this.customermiddleInitialDataGridViewTextBoxColumn.HeaderText = "Middle Initial";
            this.customermiddleInitialDataGridViewTextBoxColumn.Name = "customermiddleInitialDataGridViewTextBoxColumn";
            // 
            // customeraddressDataGridViewTextBoxColumn
            // 
            this.customeraddressDataGridViewTextBoxColumn.DataPropertyName = "customer_address";
            this.customeraddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.customeraddressDataGridViewTextBoxColumn.Name = "customeraddressDataGridViewTextBoxColumn";
            this.customeraddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // customeremailAddDataGridViewTextBoxColumn
            // 
            this.customeremailAddDataGridViewTextBoxColumn.DataPropertyName = "customer_emailAdd";
            this.customeremailAddDataGridViewTextBoxColumn.HeaderText = "customer_emailAdd";
            this.customeremailAddDataGridViewTextBoxColumn.Name = "customeremailAddDataGridViewTextBoxColumn";
            this.customeremailAddDataGridViewTextBoxColumn.Visible = false;
            // 
            // customercontactNoDataGridViewTextBoxColumn
            // 
            this.customercontactNoDataGridViewTextBoxColumn.DataPropertyName = "customer_contactNo";
            this.customercontactNoDataGridViewTextBoxColumn.HeaderText = "customer_contactNo";
            this.customercontactNoDataGridViewTextBoxColumn.Name = "customercontactNoDataGridViewTextBoxColumn";
            this.customercontactNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerstatusDataGridViewTextBoxColumn
            // 
            this.customerstatusDataGridViewTextBoxColumn.DataPropertyName = "customer_status";
            this.customerstatusDataGridViewTextBoxColumn.HeaderText = "customer_status";
            this.customerstatusDataGridViewTextBoxColumn.Name = "customerstatusDataGridViewTextBoxColumn";
            this.customerstatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerregisteredDateDataGridViewTextBoxColumn
            // 
            this.customerregisteredDateDataGridViewTextBoxColumn.DataPropertyName = "customer_registeredDate";
            this.customerregisteredDateDataGridViewTextBoxColumn.HeaderText = "customer_registeredDate";
            this.customerregisteredDateDataGridViewTextBoxColumn.Name = "customerregisteredDateDataGridViewTextBoxColumn";
            this.customerregisteredDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmRentMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 741);
            this.Controls.Add(this.txtDateReturned);
            this.Controls.Add(this.txtDateBorrowed);
            this.Controls.Add(this.moviesView);
            this.Controls.Add(this.customerView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.imgRentMoviePoster);
            this.Controls.Add(this.txtCostumerID);
            this.Controls.Add(this.lblCostumerID);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.txtRenaltFee);
            this.Controls.Add(this.txtPenaltyFee);
            this.Controls.Add(this.lblRenaltFee);
            this.Controls.Add(this.lblDateBorrowed);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblDateReturned);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.btnSave);
            this.Name = "frmRentMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Movie";
            this.Load += new System.EventHandler(this.frmRentMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgRentMoviePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmovieRentalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_videoRentalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbvideoRentalDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgRentMoviePoster;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.TextBox txtRenaltFee;
        private System.Windows.Forms.TextBox txtPenaltyFee;
        private System.Windows.Forms.Label lblRenaltFee;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDateBorrowed;
        private System.Windows.Forms.Label lblCostumerID;
        private System.Windows.Forms.TextBox txtCostumerID;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView customerView;
        private System.Windows.Forms.DataGridView moviesView;
        private System.Windows.Forms.DateTimePicker txtDateBorrowed;
        private System.Windows.Forms.DateTimePicker txtDateReturned;
        private db_videoRentalDataSet db_videoRentalDataSet;
        private System.Windows.Forms.BindingSource tblcustomerBindingSource;
        private db_videoRentalDataSetTableAdapters.tbl_customerTableAdapter tbl_customerTableAdapter;
        private db_videoRentalDataSet1 db_videoRentalDataSet1;
        private System.Windows.Forms.BindingSource dbvideoRentalDataSet1BindingSource;
        private db_videoRentalDataSet2 db_videoRentalDataSet2;
        private System.Windows.Forms.BindingSource tblmovieRentalInfoBindingSource;
        private db_videoRentalDataSet2TableAdapters.tbl_movieRentalInfoTableAdapter tbl_movieRentalInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inforentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inforentDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inforentFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infopenaltyFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infostatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerfirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerlastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customermiddleInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeremailAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customercontactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerregisteredDateDataGridViewTextBoxColumn;
    }
}