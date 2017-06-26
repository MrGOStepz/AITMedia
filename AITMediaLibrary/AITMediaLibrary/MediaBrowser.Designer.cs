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
            this.txtSearch.Location = new System.Drawing.Point(321, 51);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 26);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(801, 48);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbCatagories
            // 
            this.cbCatagories.FormattingEnabled = true;
            this.cbCatagories.Location = new System.Drawing.Point(627, 49);
            this.cbCatagories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCatagories.Name = "cbCatagories";
            this.cbCatagories.Size = new System.Drawing.Size(138, 28);
            this.cbCatagories.TabIndex = 7;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lbCategory);
            this.gbSearch.Controls.Add(this.lbName);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.cbCatagories);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearch.Location = new System.Drawing.Point(0, 0);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearch.Size = new System.Drawing.Size(1191, 112);
            this.gbSearch.TabIndex = 9;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(480, 42);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(135, 36);
            this.lbCategory.TabIndex = 9;
            this.lbCategory.Text = "Category";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(216, 42);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(92, 36);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Name";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(290, 212);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(292, 146);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // mediaDataGridView
            // 
            this.mediaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.mediaDataGridView.Location = new System.Drawing.Point(4, 25);
            this.mediaDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mediaDataGridView.Name = "mediaDataGridView";
            this.mediaDataGridView.Size = new System.Drawing.Size(1178, 318);
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
            this.gbSeletedMedia.Location = new System.Drawing.Point(4, 352);
            this.gbSeletedMedia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSeletedMedia.Name = "gbSeletedMedia";
            this.gbSeletedMedia.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSeletedMedia.Size = new System.Drawing.Size(284, 368);
            this.gbSeletedMedia.TabIndex = 1;
            this.gbSeletedMedia.TabStop = false;
            this.gbSeletedMedia.Text = "Seleted Media";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(108, 272);
            this.txtBudget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.ReadOnly = true;
            this.txtBudget.Size = new System.Drawing.Size(148, 26);
            this.txtBudget.TabIndex = 13;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(134, 312);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(124, 46);
            this.btnBorrow.TabIndex = 1;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // lbSeletedBudget
            // 
            this.lbSeletedBudget.AutoSize = true;
            this.lbSeletedBudget.Location = new System.Drawing.Point(33, 277);
            this.lbSeletedBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSeletedBudget.Name = "lbSeletedBudget";
            this.lbSeletedBudget.Size = new System.Drawing.Size(65, 20);
            this.lbSeletedBudget.TabIndex = 12;
            this.lbSeletedBudget.Text = "Budget:";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(4, 312);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(123, 46);
            this.btnReserve.TabIndex = 0;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // txtPublish
            // 
            this.txtPublish.Location = new System.Drawing.Point(108, 232);
            this.txtPublish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.ReadOnly = true;
            this.txtPublish.Size = new System.Drawing.Size(148, 26);
            this.txtPublish.TabIndex = 11;
            // 
            // lbSeletedPublish
            // 
            this.lbSeletedPublish.AutoSize = true;
            this.lbSeletedPublish.Location = new System.Drawing.Point(4, 237);
            this.lbSeletedPublish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSeletedPublish.Name = "lbSeletedPublish";
            this.lbSeletedPublish.Size = new System.Drawing.Size(98, 20);
            this.lbSeletedPublish.TabIndex = 10;
            this.lbSeletedPublish.Text = "Publish year:";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(108, 192);
            this.txtLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.Size = new System.Drawing.Size(148, 26);
            this.txtLanguage.TabIndex = 9;
            // 
            // lbSeletedLanguage
            // 
            this.lbSeletedLanguage.AutoSize = true;
            this.lbSeletedLanguage.Location = new System.Drawing.Point(12, 197);
            this.lbSeletedLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSeletedLanguage.Name = "lbSeletedLanguage";
            this.lbSeletedLanguage.Size = new System.Drawing.Size(85, 20);
            this.lbSeletedLanguage.TabIndex = 8;
            this.lbSeletedLanguage.Text = "Language:";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(108, 152);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(148, 26);
            this.txtGenre.TabIndex = 7;
            // 
            // lbSeletedGenre
            // 
            this.lbSeletedGenre.AutoSize = true;
            this.lbSeletedGenre.Location = new System.Drawing.Point(40, 157);
            this.lbSeletedGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSeletedGenre.Name = "lbSeletedGenre";
            this.lbSeletedGenre.Size = new System.Drawing.Size(58, 20);
            this.lbSeletedGenre.TabIndex = 6;
            this.lbSeletedGenre.Text = "Genre:";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(108, 112);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.ReadOnly = true;
            this.txtDirector.Size = new System.Drawing.Size(148, 26);
            this.txtDirector.TabIndex = 5;
            // 
            // lbSeletedDirector
            // 
            this.lbSeletedDirector.AutoSize = true;
            this.lbSeletedDirector.Location = new System.Drawing.Point(28, 117);
            this.lbSeletedDirector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSeletedDirector.Name = "lbSeletedDirector";
            this.lbSeletedDirector.Size = new System.Drawing.Size(69, 20);
            this.lbSeletedDirector.TabIndex = 4;
            this.lbSeletedDirector.Text = "Director:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(108, 72);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(148, 26);
            this.txtTitle.TabIndex = 3;
            // 
            // lbSeletedMediaTitle
            // 
            this.lbSeletedMediaTitle.AutoSize = true;
            this.lbSeletedMediaTitle.Location = new System.Drawing.Point(54, 77);
            this.lbSeletedMediaTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSeletedMediaTitle.Name = "lbSeletedMediaTitle";
            this.lbSeletedMediaTitle.Size = new System.Drawing.Size(42, 20);
            this.lbSeletedMediaTitle.TabIndex = 2;
            this.lbSeletedMediaTitle.Text = "Title:";
            // 
            // txtMediaID
            // 
            this.txtMediaID.Location = new System.Drawing.Point(108, 32);
            this.txtMediaID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMediaID.Name = "txtMediaID";
            this.txtMediaID.ReadOnly = true;
            this.txtMediaID.Size = new System.Drawing.Size(148, 26);
            this.txtMediaID.TabIndex = 1;
            // 
            // lbSeletedMediaID
            // 
            this.lbSeletedMediaID.AutoSize = true;
            this.lbSeletedMediaID.Location = new System.Drawing.Point(20, 37);
            this.lbSeletedMediaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSeletedMediaID.Name = "lbSeletedMediaID";
            this.lbSeletedMediaID.Size = new System.Drawing.Size(77, 20);
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
            this.gbListMedia.Location = new System.Drawing.Point(0, 112);
            this.gbListMedia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListMedia.Name = "gbListMedia";
            this.gbListMedia.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListMedia.Size = new System.Drawing.Size(1191, 726);
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
            this.gbUserBorrow.Location = new System.Drawing.Point(591, 352);
            this.gbUserBorrow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUserBorrow.Name = "gbUserBorrow";
            this.gbUserBorrow.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUserBorrow.Size = new System.Drawing.Size(591, 368);
            this.gbUserBorrow.TabIndex = 16;
            this.gbUserBorrow.TabStop = false;
            this.gbUserBorrow.Text = "List of Borrow";
            // 
            // txtBorrowMediaID
            // 
            this.txtBorrowMediaID.Location = new System.Drawing.Point(130, 172);
            this.txtBorrowMediaID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBorrowMediaID.Name = "txtBorrowMediaID";
            this.txtBorrowMediaID.Size = new System.Drawing.Size(148, 26);
            this.txtBorrowMediaID.TabIndex = 12;
            // 
            // lbBorrowMediaID
            // 
            this.lbBorrowMediaID.AutoSize = true;
            this.lbBorrowMediaID.Location = new System.Drawing.Point(42, 177);
            this.lbBorrowMediaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBorrowMediaID.Name = "lbBorrowMediaID";
            this.lbBorrowMediaID.Size = new System.Drawing.Size(77, 20);
            this.lbBorrowMediaID.TabIndex = 11;
            this.lbBorrowMediaID.Text = "Media ID:";
            // 
            // txtDateToday
            // 
            this.txtDateToday.Location = new System.Drawing.Point(130, 292);
            this.txtDateToday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDateToday.Name = "txtDateToday";
            this.txtDateToday.Size = new System.Drawing.Size(148, 26);
            this.txtDateToday.TabIndex = 10;
            // 
            // lbDateToday
            // 
            this.lbDateToday.AutoSize = true;
            this.lbDateToday.Location = new System.Drawing.Point(72, 297);
            this.lbDateToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateToday.Name = "lbDateToday";
            this.lbDateToday.Size = new System.Drawing.Size(48, 20);
            this.lbDateToday.TabIndex = 9;
            this.lbDateToday.Text = "Date:";
            // 
            // txtDateReturn
            // 
            this.txtDateReturn.Location = new System.Drawing.Point(130, 252);
            this.txtDateReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDateReturn.Name = "txtDateReturn";
            this.txtDateReturn.Size = new System.Drawing.Size(148, 26);
            this.txtDateReturn.TabIndex = 8;
            // 
            // lbDateReturn
            // 
            this.lbDateReturn.AutoSize = true;
            this.lbDateReturn.Location = new System.Drawing.Point(20, 255);
            this.lbDateReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateReturn.Name = "lbDateReturn";
            this.lbDateReturn.Size = new System.Drawing.Size(101, 20);
            this.lbDateReturn.TabIndex = 7;
            this.lbDateReturn.Text = "Date Return:";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(130, 331);
            this.txtFee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(148, 26);
            this.txtFee.TabIndex = 6;
            // 
            // lbLateFee
            // 
            this.lbLateFee.AutoSize = true;
            this.lbLateFee.Location = new System.Drawing.Point(44, 335);
            this.lbLateFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLateFee.Name = "lbLateFee";
            this.lbLateFee.Size = new System.Drawing.Size(77, 20);
            this.lbLateFee.TabIndex = 5;
            this.lbLateFee.Text = "Late Fee:";
            // 
            // txtBorrowMedia
            // 
            this.txtBorrowMedia.Location = new System.Drawing.Point(130, 212);
            this.txtBorrowMedia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBorrowMedia.Name = "txtBorrowMedia";
            this.txtBorrowMedia.Size = new System.Drawing.Size(148, 26);
            this.txtBorrowMedia.TabIndex = 4;
            // 
            // lbReturnMedia
            // 
            this.lbReturnMedia.AutoSize = true;
            this.lbReturnMedia.Location = new System.Drawing.Point(4, 215);
            this.lbReturnMedia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReturnMedia.Name = "lbReturnMedia";
            this.lbReturnMedia.Size = new System.Drawing.Size(115, 20);
            this.lbReturnMedia.TabIndex = 3;
            this.lbReturnMedia.Text = "Seleted Media:";
            // 
            // dgvListBorrow
            // 
            this.dgvListBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBorrow.Location = new System.Drawing.Point(9, 29);
            this.dgvListBorrow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListBorrow.Name = "dgvListBorrow";
            this.dgvListBorrow.Size = new System.Drawing.Size(573, 134);
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
            this.gbUserInformation.Location = new System.Drawing.Point(297, 352);
            this.gbUserInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUserInformation.Name = "gbUserInformation";
            this.gbUserInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUserInformation.Size = new System.Drawing.Size(284, 243);
            this.gbUserInformation.TabIndex = 15;
            this.gbUserInformation.TabStop = false;
            this.gbUserInformation.Text = "User Information";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(58, 192);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(198, 26);
            this.txtDate.TabIndex = 9;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(9, 197);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(48, 20);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "Date:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(108, 152);
            this.txtUserEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.ReadOnly = true;
            this.txtUserEmail.Size = new System.Drawing.Size(148, 26);
            this.txtUserEmail.TabIndex = 7;
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.Location = new System.Drawing.Point(40, 157);
            this.lbUserEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(52, 20);
            this.lbUserEmail.TabIndex = 6;
            this.lbUserEmail.Text = "Email:";
            // 
            // txtUserLevel
            // 
            this.txtUserLevel.Location = new System.Drawing.Point(108, 112);
            this.txtUserLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserLevel.Name = "txtUserLevel";
            this.txtUserLevel.ReadOnly = true;
            this.txtUserLevel.Size = new System.Drawing.Size(148, 26);
            this.txtUserLevel.TabIndex = 5;
            // 
            // lbUserLevel
            // 
            this.lbUserLevel.AutoSize = true;
            this.lbUserLevel.Location = new System.Drawing.Point(8, 117);
            this.lbUserLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserLevel.Name = "lbUserLevel";
            this.lbUserLevel.Size = new System.Drawing.Size(88, 20);
            this.lbUserLevel.TabIndex = 4;
            this.lbUserLevel.Text = "User Level:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(108, 72);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(148, 26);
            this.txtUserName.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 77);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "User Name:";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(108, 32);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(148, 26);
            this.txtUserID.TabIndex = 1;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(28, 37);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(68, 20);
            this.lbUserID.TabIndex = 0;
            this.lbUserID.Text = "User ID:";
            // 
            // MediaBrowser
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 838);
            this.Controls.Add(this.gbListMedia);
            this.Controls.Add(this.gbSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}