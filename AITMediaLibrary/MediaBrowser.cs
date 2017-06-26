using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AITMediaLibrary.Webservice;


namespace AITMediaLibrary
{
    public partial class MediaBrowser : Form
    {

        private WebService _ws = new WebService();
        private DataTable _datable;
        private String _seletedDGV;
        public MediaBrowser()
        {
            InitializeComponent();
            FillItemsToCombobox();

            txtUserID.Text = CurrentUser.UserID.ToString();
            txtUserName.Text = CurrentUser.UserName;
            txtUserLevel.Text = CurrentUser.UserLevel.ToString();
            txtUserEmail.Text = CurrentUser.UserEmail;
            txtDate.Text = DateTime.Today.ToLongDateString();
            
        }

        private void MediaBrowser_Load(object sender, EventArgs e)
        {
            this.Text = CurrentUser.UserName + " User Level: " + CurrentUser.UserLevel;

            _datable = _ws.ListMedia();
            mediaDataGridView.DataSource = _datable;
            dgvListBorrow.DataSource = _ws.ListMediaBorrowUser(CurrentUser.UserID);

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
            if (mediaDataGridView.Rows[e.RowIndex].Cells["MediaID"].Value.ToString() != "")
            {
                _seletedDGV = mediaDataGridView.Rows[e.RowIndex].Cells["MediaTitle"].Value.ToString();

                txtMediaID.Text = mediaDataGridView.Rows[e.RowIndex].Cells["MediaID"].Value.ToString();
                txtTitle.Text = mediaDataGridView.Rows[e.RowIndex].Cells["MediaTitle"].Value.ToString();
                txtDirector.Text = mediaDataGridView.Rows[e.RowIndex].Cells["MediaDirector"].Value.ToString();
                txtGenre.Text = mediaDataGridView.Rows[e.RowIndex].Cells["MediaGenre"].Value.ToString();
                txtLanguage.Text = mediaDataGridView.Rows[e.RowIndex].Cells["MediaLanguage"].Value.ToString();
                txtPublish.Text = mediaDataGridView.Rows[e.RowIndex].Cells["MediaPublishYear"].Value.ToString();
                txtBudget.Text = mediaDataGridView.Rows[e.RowIndex].Cells["MediaBudget"].Value.ToString();
            }
        }

        private void dgvListBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dateActualBorrow = new DateTime();
            DateTime dateReturn = new DateTime();
            int row = e.RowIndex;
            if (dgvListBorrow.Rows[e.RowIndex].Cells["MediaID"].Value.ToString() != "")
            {

                dateActualBorrow = Convert.ToDateTime(dgvListBorrow.Rows[e.RowIndex].Cells["DateActualReturn"].Value.ToString());
                dateReturn = Convert.ToDateTime(dgvListBorrow.Rows[e.RowIndex].Cells["DateReturn"].Value.ToString());

                txtBorrowMediaID.Text = dgvListBorrow.Rows[e.RowIndex].Cells["MediaID"].Value.ToString();
                txtBorrowMedia.Text = dgvListBorrow.Rows[e.RowIndex].Cells["MediaTitle"].Value.ToString();
                txtDateReturn.Text = dgvListBorrow.Rows[e.RowIndex].Cells["DateReturn"].Value.ToString();
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

        private void btnPublishYearSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" && cbCatagories.Text != "All Categories")
                return;
            switch (cbCatagories.Text)
            {
                case "All Categories":
                    //Set data source for data grid view
                    mediaDataGridView.DataSource = _ws.ListMedia();
                    break;
                case "Title":
                    mediaDataGridView.DataSource = _ws.ListMediaByTitle(txtSearch.Text);
                    break;
                case "Genre":
                    mediaDataGridView.DataSource = _ws.ListMediaByGenre(txtSearch.Text);
                    break;
                case "Director":
                    mediaDataGridView.DataSource = _ws.ListMediaByDirector(txtSearch.Text);
                    break;
                case "Language":
                    mediaDataGridView.DataSource = _ws.ListMediaByLanguage(txtSearch.Text);
                    break;
                case "PublishYear":
                    try
                    {
                        mediaDataGridView.DataSource = _ws.ListMediaByPublishYear(int.Parse(txtSearch.Text));
                    }
                    catch (Exception)
                    {

                        mediaDataGridView.DataSource = _ws.ListMediaByPublishYear(0);
                    }
                    
                    break;
                case "Budget":
                    try
                    {
                        mediaDataGridView.DataSource = _ws.ListMediaByBudget(decimal.Parse(txtSearch.Text));
                    }
                    catch (Exception)
                    {

                        mediaDataGridView.DataSource = _ws.ListMediaByPublishYear(0);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                _ws.InsertNewResevebyID(CurrentUser.UserID, int.Parse(txtMediaID.Text), DateTime.Today.ToShortDateString());
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
                _ws.InsertBorrowMedia(CurrentUser.UserID, int.Parse(txtMediaID.Text), DateTime.Today.ToShortDateString(), DateTime.Today.AddDays(7).ToString(), txtTitle.Text);
                dgvListBorrow.DataSource = _ws.ListMediaBorrowUser(CurrentUser.UserID);
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
                _ws.UpdateReturnMedia(txtDateToday.Text, decimal.Parse(txtFee.Text), CurrentUser.UserID, int.Parse(txtBorrowMediaID.Text));
                dgvListBorrow.DataSource = _ws.ListMediaBorrowUser(CurrentUser.UserID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Return media.\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            MessageBox.Show("Return complete");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //go to student form
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            t.Start();
            this.Close();
        }
                

        public static void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }
    }
}
