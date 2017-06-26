using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITMediaLibrary
{
    public partial class MediaBrowser : Form
    {

        private MediaLogic mediaLogic = new MediaLogic();
        
        public MediaBrowser()
        {
            InitializeComponent();
            FillItemsToCombobox();

            //Set User detil in User Groupbox
            txtUserID.Text = CurrentUser.UserID.ToString();
            txtUserName.Text = CurrentUser.UserName;
            txtUserLevel.Text = CurrentUser.UserLevel.ToString();
            txtUserEmail.Text = CurrentUser.UserEmail;
            txtDate.Text = DateTime.Today.ToLongDateString();
            
        }

        /**
         * Fill data to Grid View
         */
        private void MediaBrowser_Load(object sender, EventArgs e)
        {
            mediaDataGridView.DataSource = mediaLogic.ListMedia();
            dgvListBorrow.DataSource = mediaLogic.ListMediaBorrowUser(CurrentUser.UserID);

        }

        /**
         * Fill Item to Combobox
         * 
         */
        private void FillItemsToCombobox()
        {
            cbCatagories.Text = "All Categories";
            ComboboxItem cbItem = new ComboboxItem();
            List<ComboboxItem> lstItem = new List<ComboboxItem>();

            cbItem.Text = "All Categories";
            cbItem.Value = "1";
            cbCatagories.Items.Add(cbItem);
            cbItem = new ComboboxItem();
            cbItem.Text = "Title";
            cbItem.Value = "2";
            cbCatagories.Items.Add(cbItem);
            cbItem = new ComboboxItem();
            cbItem.Text = "Genre";
            cbItem.Value = "3";
            cbCatagories.Items.Add(cbItem);
            cbItem = new ComboboxItem();
            cbItem.Text = "Director";
            cbItem.Value = "4";
            cbCatagories.Items.Add(cbItem);
            cbItem = new ComboboxItem();
            cbItem.Text = "Language";
            cbItem.Value = "5";
            cbCatagories.Items.Add(cbItem);
            cbItem = new ComboboxItem();
            cbItem.Text = "PublishYear";
            cbItem.Value = "6";
            cbCatagories.Items.Add(cbItem);
            cbItem = new ComboboxItem();
            cbItem.Text = "Budget";
            cbItem.Value = "7";
            cbCatagories.Items.Add(cbItem);        
        }

        private void mediaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //User the e arg to get info on which cell was clicked. I only care about the row
            int row = e.RowIndex;
            if (row >= 0)
            {
                //get list of moels from the data grid view (changes based on searches etc)
                List<MediaModel> models = (List<MediaModel>) mediaDataGridView.DataSource;

                //get selected row media
                MediaModel media = models.ElementAt<MediaModel>(row);
                //change label to show name of media

                txtMediaID.Text = media.MediaID.ToString();
                txtTitle.Text = media.MediaTitle;
                txtDirector.Text = media.MediaDirector;
                txtGenre.Text = media.MediaGenre;
                txtLanguage.Text = media.MediaLanguage;
                txtPublish.Text = media.MediaPublishYear.ToString();
                txtBudget.Text = media.MediaBudget.ToString();
            }
        }

        private void dgvListBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dateActualBorrow = new DateTime();
            DateTime dateReturn = new DateTime();
            int row = e.RowIndex;
            if (row >= 0)
            {
                //get list of moels from the data grid view (changes based on searches etc)
                List<BRModel> models = (List<BRModel>)dgvListBorrow.DataSource;

                //get selected row media
                BRModel media = models.ElementAt<BRModel>(row);
                //change label to show name of media

                dateActualBorrow = Convert.ToDateTime(media.DateReturn.ToString());
                dateReturn = Convert.ToDateTime(media.DateReturn.ToString());

                txtBorrowMediaID.Text = media.MediaID.ToString();
                txtBorrowMedia.Text = media.MediaTitle;
                txtDateReturn.Text = dateReturn.ToShortDateString();
                txtDateToday.Text = DateTime.Today.ToShortDateString();
                if (DateTime.Today.Date > dateActualBorrow.Date)
                {
                    txtFee.Text = "20";
                }
                else
                {
                    txtFee.Text = "0";
                }

            }
        }


        /**
         * Reserve Media 
         */
         
        
        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                mediaLogic.InsertNewResevebyID(CurrentUser.UserID, int.Parse(txtMediaID.Text), DateTime.Today.ToShortDateString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not add reseve media.\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Add Reseve complete");
        }

        
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                mediaLogic.InsertBorrowMedia(CurrentUser.UserID, int.Parse(txtMediaID.Text), DateTime.Today.ToShortDateString(), DateTime.Today.AddDays(7).ToString(),txtTitle.Text);
                dgvListBorrow.DataSource = mediaLogic.ListMediaBorrowUser(CurrentUser.UserID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Borrow media.\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            MessageBox.Show("Borrow complete");

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                mediaLogic.UpdateReturnMedia(txtDateToday.Text, decimal.Parse(txtFee.Text), CurrentUser.UserID, int.Parse(txtBorrowMediaID.Text));
                dgvListBorrow.DataSource = mediaLogic.ListMediaBorrowUser(CurrentUser.UserID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Return media.\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            MessageBox.Show("Return complete");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" && cbCatagories.Text != "All Categories")
                return;

            MediaLogic mediaLogic = new MediaLogic();
            switch (cbCatagories.Text)
            {
                case "All Categories":
                    //Set data source for data grid view
                    mediaDataGridView.DataSource = mediaLogic.ListMedia();
                    break;
                case "Title":
                    mediaDataGridView.DataSource = mediaLogic.ListMediaByTitle(txtSearch.Text);
                    break;
                case "Genre":
                    mediaDataGridView.DataSource = mediaLogic.ListMediaByGenre(txtSearch.Text);
                    break;
                case "Director":
                    mediaDataGridView.DataSource = mediaLogic.ListMediaByDirector(txtSearch.Text);
                    break;
                case "Language":
                    mediaDataGridView.DataSource = mediaLogic.ListMediaByLanguage(txtSearch.Text);
                    break;
                case "PublishYear":
                    try
                    {
                        mediaDataGridView.DataSource = mediaLogic.ListMediaByPublishYear(int.Parse(txtSearch.Text));
                    }
                    catch (Exception)
                    {

                        mediaDataGridView.DataSource = mediaLogic.ListMediaByPublishYear(0);
                    }

                    break;
                case "Budget":
                    try
                    {
                        mediaDataGridView.DataSource = mediaLogic.ListMediaByBudget(decimal.Parse(txtSearch.Text));
                    }
                    catch (Exception)
                    {

                        mediaDataGridView.DataSource = mediaLogic.ListMediaByPublishYear(0);
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
