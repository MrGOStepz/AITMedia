namespace AITMediaLibrary
{
    partial class MediaBrowser
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbCatagories = new System.Windows.Forms.ComboBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.mediaDataGridView = new System.Windows.Forms.DataGridView();
            this.gbSeletedMedia = new System.Windows.Forms.GroupBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.lbSeletedBudget = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.txtPublish = new System.Windows.Forms.TextBox();
            this.lbSeletedPublish = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lbSeletedLanguage = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lbSeletedGenre = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lbSeletedDirector = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbSeletedMediaTitle = new System.Windows.Forms.Label();
            this.txtMediaID = new System.Windows.Forms.TextBox();
            this.lbSeletedMediaID = new System.Windows.Forms.Label();
            this.gbListMedia = new System.Windows.Forms.GroupBox();
            this.gbUserBorrow = new System.Windows.Forms.GroupBox();
            this.txtBorrowMediaID = new System.Windows.Forms.TextBox();
            this.lbBorrowMediaID = new System.Windows.Forms.Label();
            this.txtDateToday = new System.Windows.Forms.TextBox();
            this.lbDateToday = new System.Windows.Forms.Label();
            this.txtDateReturn = new System.Windows.Forms.TextBox();
            this.lbDateReturn = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.lbLateFee = new System.Windows.Forms.Label();
            this.txtBorrowMedia = new System.Windows.Forms.TextBox();
            this.lbReturnMedia = new System.Windows.Forms.Label();
            this.dgvListBorrow = new System.Windows.Forms.DataGridView();
            this.gbUserInformation = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.lbUserEmail = new System.Windows.Forms.Label();
            this.txtUserLevel = new System.Windows.Forms.TextBox();
            this.lbUserLevel = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataGridView)).BeginInit();
            this.gbSeletedMedia.SuspendLayout();
            this.gbListMedia.SuspendLayout();
            this.gbUserBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBorrow)).BeginInit();
            this.gbUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(214, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(534, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnPublishYearSearch_Click);
            // 
            // cbCatagories
            // 
            this.cbCatagories.FormattingEnabled = true;
            this.cbCatagories.Location = new System.Drawing.Point(418, 32);
            this.cbCatagories.Name = "cbCatagories";
            this.cbCatagories.Size = new System.Drawing.Size(93, 21);
            this.cbCatagories.TabIndex = 7;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnLogout);
            this.gbSearch.Controls.Add(this.lbCategory);
            this.gbSearch.Controls.Add(this.lbName);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.cbCatagories);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearch.Location = new System.Drawing.Point(0, 0);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(794, 73);
            this.gbSearch.TabIndex = 9;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(320, 27);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(92, 25);
            this.lbCategory.TabIndex = 9;
            this.lbCategory.Text = "Category";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(144, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(64, 25);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Name";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(193, 138);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(195, 95);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // mediaDataGridView
            // 
            this.mediaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.mediaDataGridView.Location = new System.Drawing.Point(3, 16);
            this.mediaDataGridView.Name = "mediaDataGridView";
            this.mediaDataGridView.Size = new System.Drawing.Size(785, 207);
            this.mediaDataGridView.TabIndex = 0;
            this.mediaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaDataGridView_CellClick);
            // 
            // gbSeletedMedia
            // 
            this.gbSeletedMedia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSeletedMedia.Controls.Add(this.txtBudget);
            this.gbSeletedMedia.Controls.Add(this.btnBorrow);
            this.gbSeletedMedia.Controls.Add(this.lbSeletedBudget);
            this.gbSeletedMedia.Controls.Add(this.btnReserve);
            this.gbSeletedMedia.Controls.Add(this.txtPublish);
            this.gbSeletedMedia.Controls.Add(this.lbSeletedPublish);
            this.gbSeletedMedia.Controls.Add(this.txtLanguage);
            this.gbSeletedMedia.Controls.Add(this.lbSeletedLanguage);
            this.gbSeletedMedia.Controls.Add(this.txtGenre);
            this.gbSeletedMedia.Controls.Add(this.lbSeletedGenre);
            this.gbSeletedMedia.Controls.Add(this.txtDirector);
            this.gbSeletedMedia.Controls.Add(this.lbSeletedDirector);
            this.gbSeletedMedia.Controls.Add(this.txtTitle);
            this.gbSeletedMedia.Controls.Add(this.lbSeletedMediaTitle);
            this.gbSeletedMedia.Controls.Add(this.txtMediaID);
            this.gbSeletedMedia.Controls.Add(this.lbSeletedMediaID);
            this.gbSeletedMedia.Location = new System.Drawing.Point(3, 229);
            this.gbSeletedMedia.Name = "gbSeletedMedia";
            this.gbSeletedMedia.Size = new System.Drawing.Size(189, 239);
            this.gbSeletedMedia.TabIndex = 1;
            this.gbSeletedMedia.TabStop = false;
            this.gbSeletedMedia.Text = "Seleted Media";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(72, 177);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.ReadOnly = true;
            this.txtBudget.Size = new System.Drawing.Size(100, 20);
            this.txtBudget.TabIndex = 13;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(89, 203);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(83, 30);
            this.btnBorrow.TabIndex = 1;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // lbSeletedBudget
            // 
            this.lbSeletedBudget.AutoSize = true;
            this.lbSeletedBudget.Location = new System.Drawing.Point(22, 180);
            this.lbSeletedBudget.Name = "lbSeletedBudget";
            this.lbSeletedBudget.Size = new System.Drawing.Size(44, 13);
            this.lbSeletedBudget.TabIndex = 12;
            this.lbSeletedBudget.Text = "Budget:";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(3, 203);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(82, 30);
            this.btnReserve.TabIndex = 0;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // txtPublish
            // 
            this.txtPublish.Location = new System.Drawing.Point(72, 151);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.ReadOnly = true;
            this.txtPublish.Size = new System.Drawing.Size(100, 20);
            this.txtPublish.TabIndex = 11;
            // 
            // lbSeletedPublish
            // 
            this.lbSeletedPublish.AutoSize = true;
            this.lbSeletedPublish.Location = new System.Drawing.Point(3, 154);
            this.lbSeletedPublish.Name = "lbSeletedPublish";
            this.lbSeletedPublish.Size = new System.Drawing.Size(67, 13);
            this.lbSeletedPublish.TabIndex = 10;
            this.lbSeletedPublish.Text = "Publish year:";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(72, 125);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.Size = new System.Drawing.Size(100, 20);
            this.txtLanguage.TabIndex = 9;
            // 
            // lbSeletedLanguage
            // 
            this.lbSeletedLanguage.AutoSize = true;
            this.lbSeletedLanguage.Location = new System.Drawing.Point(8, 128);
            this.lbSeletedLanguage.Name = "lbSeletedLanguage";
            this.lbSeletedLanguage.Size = new System.Drawing.Size(58, 13);
            this.lbSeletedLanguage.TabIndex = 8;
            this.lbSeletedLanguage.Text = "Language:";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(72, 99);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 7;
            // 
            // lbSeletedGenre
            // 
            this.lbSeletedGenre.AutoSize = true;
            this.lbSeletedGenre.Location = new System.Drawing.Point(27, 102);
            this.lbSeletedGenre.Name = "lbSeletedGenre";
            this.lbSeletedGenre.Size = new System.Drawing.Size(39, 13);
            this.lbSeletedGenre.TabIndex = 6;
            this.lbSeletedGenre.Text = "Genre:";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(72, 73);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.ReadOnly = true;
            this.txtDirector.Size = new System.Drawing.Size(100, 20);
            this.txtDirector.TabIndex = 5;
            // 
            // lbSeletedDirector
            // 
            this.lbSeletedDirector.AutoSize = true;
            this.lbSeletedDirector.Location = new System.Drawing.Point(19, 76);
            this.lbSeletedDirector.Name = "lbSeletedDirector";
            this.lbSeletedDirector.Size = new System.Drawing.Size(47, 13);
            this.lbSeletedDirector.TabIndex = 4;
            this.lbSeletedDirector.Text = "Director:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(72, 47);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lbSeletedMediaTitle
            // 
            this.lbSeletedMediaTitle.AutoSize = true;
            this.lbSeletedMediaTitle.Location = new System.Drawing.Point(36, 50);
            this.lbSeletedMediaTitle.Name = "lbSeletedMediaTitle";
            this.lbSeletedMediaTitle.Size = new System.Drawing.Size(30, 13);
            this.lbSeletedMediaTitle.TabIndex = 2;
            this.lbSeletedMediaTitle.Text = "Title:";
            // 
            // txtMediaID
            // 
            this.txtMediaID.Location = new System.Drawing.Point(72, 21);
            this.txtMediaID.Name = "txtMediaID";
            this.txtMediaID.ReadOnly = true;
            this.txtMediaID.Size = new System.Drawing.Size(100, 20);
            this.txtMediaID.TabIndex = 1;
            // 
            // lbSeletedMediaID
            // 
            this.lbSeletedMediaID.AutoSize = true;
            this.lbSeletedMediaID.Location = new System.Drawing.Point(13, 24);
            this.lbSeletedMediaID.Name = "lbSeletedMediaID";
            this.lbSeletedMediaID.Size = new System.Drawing.Size(53, 13);
            this.lbSeletedMediaID.TabIndex = 0;
            this.lbSeletedMediaID.Text = "Media ID:";
            // 
            // gbListMedia
            // 
            this.gbListMedia.Controls.Add(this.gbUserBorrow);
            this.gbListMedia.Controls.Add(this.gbUserInformation);
            this.gbListMedia.Controls.Add(this.gbSeletedMedia);
            this.gbListMedia.Controls.Add(this.mediaDataGridView);
            this.gbListMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbListMedia.Location = new System.Drawing.Point(0, 73);
            this.gbListMedia.Name = "gbListMedia";
            this.gbListMedia.Size = new System.Drawing.Size(794, 472);
            this.gbListMedia.TabIndex = 10;
            this.gbListMedia.TabStop = false;
            this.gbListMedia.Text = "List Media";
            // 
            // gbUserBorrow
            // 
            this.gbUserBorrow.Controls.Add(this.txtBorrowMediaID);
            this.gbUserBorrow.Controls.Add(this.lbBorrowMediaID);
            this.gbUserBorrow.Controls.Add(this.txtDateToday);
            this.gbUserBorrow.Controls.Add(this.lbDateToday);
            this.gbUserBorrow.Controls.Add(this.txtDateReturn);
            this.gbUserBorrow.Controls.Add(this.lbDateReturn);
            this.gbUserBorrow.Controls.Add(this.txtFee);
            this.gbUserBorrow.Controls.Add(this.lbLateFee);
            this.gbUserBorrow.Controls.Add(this.txtBorrowMedia);
            this.gbUserBorrow.Controls.Add(this.lbReturnMedia);
            this.gbUserBorrow.Controls.Add(this.btnReturn);
            this.gbUserBorrow.Controls.Add(this.dgvListBorrow);
            this.gbUserBorrow.Location = new System.Drawing.Point(394, 229);
            this.gbUserBorrow.Name = "gbUserBorrow";
            this.gbUserBorrow.Size = new System.Drawing.Size(394, 239);
            this.gbUserBorrow.TabIndex = 16;
            this.gbUserBorrow.TabStop = false;
            this.gbUserBorrow.Text = "List of Borrow";
            // 
            // txtBorrowMediaID
            // 
            this.txtBorrowMediaID.Location = new System.Drawing.Point(87, 112);
            this.txtBorrowMediaID.Name = "txtBorrowMediaID";
            this.txtBorrowMediaID.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowMediaID.TabIndex = 12;
            // 
            // lbBorrowMediaID
            // 
            this.lbBorrowMediaID.AutoSize = true;
            this.lbBorrowMediaID.Location = new System.Drawing.Point(28, 115);
            this.lbBorrowMediaID.Name = "lbBorrowMediaID";
            this.lbBorrowMediaID.Size = new System.Drawing.Size(53, 13);
            this.lbBorrowMediaID.TabIndex = 11;
            this.lbBorrowMediaID.Text = "Media ID:";
            // 
            // txtDateToday
            // 
            this.txtDateToday.Location = new System.Drawing.Point(87, 190);
            this.txtDateToday.Name = "txtDateToday";
            this.txtDateToday.Size = new System.Drawing.Size(100, 20);
            this.txtDateToday.TabIndex = 10;
            // 
            // lbDateToday
            // 
            this.lbDateToday.AutoSize = true;
            this.lbDateToday.Location = new System.Drawing.Point(48, 193);
            this.lbDateToday.Name = "lbDateToday";
            this.lbDateToday.Size = new System.Drawing.Size(33, 13);
            this.lbDateToday.TabIndex = 9;
            this.lbDateToday.Text = "Date:";
            // 
            // txtDateReturn
            // 
            this.txtDateReturn.Location = new System.Drawing.Point(87, 164);
            this.txtDateReturn.Name = "txtDateReturn";
            this.txtDateReturn.Size = new System.Drawing.Size(100, 20);
            this.txtDateReturn.TabIndex = 8;
            // 
            // lbDateReturn
            // 
            this.lbDateReturn.AutoSize = true;
            this.lbDateReturn.Location = new System.Drawing.Point(13, 166);
            this.lbDateReturn.Name = "lbDateReturn";
            this.lbDateReturn.Size = new System.Drawing.Size(68, 13);
            this.lbDateReturn.TabIndex = 7;
            this.lbDateReturn.Text = "Date Return:";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(87, 215);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(100, 20);
            this.txtFee.TabIndex = 6;
            // 
            // lbLateFee
            // 
            this.lbLateFee.AutoSize = true;
            this.lbLateFee.Location = new System.Drawing.Point(29, 218);
            this.lbLateFee.Name = "lbLateFee";
            this.lbLateFee.Size = new System.Drawing.Size(52, 13);
            this.lbLateFee.TabIndex = 5;
            this.lbLateFee.Text = "Late Fee:";
            // 
            // txtBorrowMedia
            // 
            this.txtBorrowMedia.Location = new System.Drawing.Point(87, 138);
            this.txtBorrowMedia.Name = "txtBorrowMedia";
            this.txtBorrowMedia.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowMedia.TabIndex = 4;
            // 
            // lbReturnMedia
            // 
            this.lbReturnMedia.AutoSize = true;
            this.lbReturnMedia.Location = new System.Drawing.Point(3, 140);
            this.lbReturnMedia.Name = "lbReturnMedia";
            this.lbReturnMedia.Size = new System.Drawing.Size(78, 13);
            this.lbReturnMedia.TabIndex = 3;
            this.lbReturnMedia.Text = "Seleted Media:";
            // 
            // dgvListBorrow
            // 
            this.dgvListBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBorrow.Location = new System.Drawing.Point(6, 19);
            this.dgvListBorrow.Name = "dgvListBorrow";
            this.dgvListBorrow.Size = new System.Drawing.Size(382, 87);
            this.dgvListBorrow.TabIndex = 0;
            this.dgvListBorrow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListBorrow_CellClick);
            // 
            // gbUserInformation
            // 
            this.gbUserInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbUserInformation.Controls.Add(this.txtDate);
            this.gbUserInformation.Controls.Add(this.lbDate);
            this.gbUserInformation.Controls.Add(this.txtUserEmail);
            this.gbUserInformation.Controls.Add(this.lbUserEmail);
            this.gbUserInformation.Controls.Add(this.txtUserLevel);
            this.gbUserInformation.Controls.Add(this.lbUserLevel);
            this.gbUserInformation.Controls.Add(this.txtUserName);
            this.gbUserInformation.Controls.Add(this.label13);
            this.gbUserInformation.Controls.Add(this.txtUserID);
            this.gbUserInformation.Controls.Add(this.lbUserID);
            this.gbUserInformation.Location = new System.Drawing.Point(198, 229);
            this.gbUserInformation.Name = "gbUserInformation";
            this.gbUserInformation.Size = new System.Drawing.Size(189, 158);
            this.gbUserInformation.TabIndex = 15;
            this.gbUserInformation.TabStop = false;
            this.gbUserInformation.Text = "User Information";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(39, 125);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(133, 20);
            this.txtDate.TabIndex = 9;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(6, 128);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(33, 13);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "Date:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(72, 99);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.ReadOnly = true;
            this.txtUserEmail.Size = new System.Drawing.Size(100, 20);
            this.txtUserEmail.TabIndex = 7;
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.Location = new System.Drawing.Point(27, 102);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(35, 13);
            this.lbUserEmail.TabIndex = 6;
            this.lbUserEmail.Text = "Email:";
            // 
            // txtUserLevel
            // 
            this.txtUserLevel.Location = new System.Drawing.Point(72, 73);
            this.txtUserLevel.Name = "txtUserLevel";
            this.txtUserLevel.ReadOnly = true;
            this.txtUserLevel.Size = new System.Drawing.Size(100, 20);
            this.txtUserLevel.TabIndex = 5;
            // 
            // lbUserLevel
            // 
            this.lbUserLevel.AutoSize = true;
            this.lbUserLevel.Location = new System.Drawing.Point(5, 76);
            this.lbUserLevel.Name = "lbUserLevel";
            this.lbUserLevel.Size = new System.Drawing.Size(61, 13);
            this.lbUserLevel.TabIndex = 4;
            this.lbUserLevel.Text = "User Level:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(72, 47);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "User Name:";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(72, 21);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 1;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(19, 24);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(46, 13);
            this.lbUserID.TabIndex = 0;
            this.lbUserID.Text = "User ID:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(713, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 55);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MediaBrowser
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 545);
            this.Controls.Add(this.gbListMedia);
            this.Controls.Add(this.gbSearch);
            this.Name = "MediaBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Browser";
            this.Load += new System.EventHandler(this.MediaBrowser_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataGridView)).EndInit();
            this.gbSeletedMedia.ResumeLayout(false);
            this.gbSeletedMedia.PerformLayout();
            this.gbListMedia.ResumeLayout(false);
            this.gbUserBorrow.ResumeLayout(false);
            this.gbUserBorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBorrow)).EndInit();
            this.gbUserInformation.ResumeLayout(false);
            this.gbUserInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbCatagories;

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView mediaDataGridView;
        private System.Windows.Forms.GroupBox gbSeletedMedia;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label lbSeletedBudget;
        private System.Windows.Forms.TextBox txtPublish;
        private System.Windows.Forms.Label lbSeletedPublish;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label lbSeletedLanguage;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lbSeletedGenre;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lbSeletedDirector;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbSeletedMediaTitle;
        private System.Windows.Forms.TextBox txtMediaID;
        private System.Windows.Forms.Label lbSeletedMediaID;
        private System.Windows.Forms.GroupBox gbListMedia;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.GroupBox gbUserInformation;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label lbUserEmail;
        private System.Windows.Forms.TextBox txtUserLevel;
        private System.Windows.Forms.Label lbUserLevel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.GroupBox gbUserBorrow;
        private System.Windows.Forms.DataGridView dgvListBorrow;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label lbLateFee;
        private System.Windows.Forms.TextBox txtBorrowMedia;
        private System.Windows.Forms.Label lbReturnMedia;
        private System.Windows.Forms.TextBox txtDateToday;
        private System.Windows.Forms.Label lbDateToday;
        private System.Windows.Forms.TextBox txtDateReturn;
        private System.Windows.Forms.Label lbDateReturn;
        private System.Windows.Forms.TextBox txtBorrowMediaID;
        private System.Windows.Forms.Label lbBorrowMediaID;
        private System.Windows.Forms.Button btnLogout;
    }
}