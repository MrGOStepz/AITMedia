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
    public partial class AdminForm : Form
    {
        private UserModel _selectedUser = null;
        private UserLogic _userLogic = new UserLogic();
        private MediaModel _selectedMedia = null;
        private MediaLogic _mediaLogic = new MediaLogic();
        private PairModel _selectedPair = null;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshUserList();
            cbUserLevel.DataSource = Enum.GetValues(typeof(AppEnum.UserLevel));
            //List of media
            MediaLogic mediaLogic = new MediaLogic();
            dgvMedia.DataSource = mediaLogic.ListMedia();
            dgvAvailableMedia.DataSource = mediaLogic.ListMediaAvailbable();
            dgvBorrowMedia.DataSource = mediaLogic.ListMediaBorrowed();
            dgvLanguage.DataSource = mediaLogic.ListLanguages();
            dgvGenre.DataSource = mediaLogic.ListGenres();
            dgvDirector.DataSource = mediaLogic.ListDirector();


            List<PairModel> lstGenres = _mediaLogic.ListGenres();
            List<PairModel> lstLanguage = _mediaLogic.ListLanguages();
            List<PairModel> lstDirector = _mediaLogic.ListDirector();

            for (int i = 0; i < lstGenres.Count; i++)
            {
                cbUAMediaGenre.Items.Add(lstGenres[i].PairName);
            }

            for (int i = 0; i < lstLanguage.Count; i++)
            {
                cbUAMediaLanguage.Items.Add(lstLanguage[i].PairName);
            }

            for (int i = 0; i < lstDirector.Count; i++)
            {
                cbUAMediaDirector.Items.Add(lstDirector[i].PairName);
            }

        }

        private void RefreshUserList()
        {
            dgvUsers.DataSource = _userLogic.GetListOfUsers();
        }

        private void RefreshMediaList()
        {
            dgvMedia.DataSource = _mediaLogic.ListMedia();
        }


        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //which row did i click on in the list
            if (row > -1) //-1 clicking column names
            {
                //get users from the datagrid view
                //dataGridView's DataSource is an Object. So when we give it stuff it refernecs
                //it as a basic type. DataGridView can display any onjects properties, so it doesn't
                //Care what type.
                //However, we know we put it in as a list of users and we want to work with
                //as a list of users when we get it. So cast it back into a list of users
                List<UserModel> users = (List<UserModel>)dgvUsers.DataSource;
                //get the user at this posistion in the list and reference then and the selected user
                _selectedUser = users.ElementAt<UserModel>(row);
                txtSelectedUser.Text = _selectedUser.UserName;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (_selectedUser != null)
            {

                DialogResult result = MessageBox.Show("Do you want to delete " + _selectedUser.UserName, "Delete User", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Delete user in DB
                    int affectedRows = _userLogic.DeleteUserByUserID(_selectedUser.UserID);
                    if (affectedRows > 0)
                    {
                        lbStripStatus.Text = "\"" + _selectedUser.UserName + "\"" + " has been deleted";
                    }
                    else
                    {
                        //couldn't find any users of this userID
                    }

                    //Clear out selectedUser
                    _selectedUser = null;
                    txtSelectedUser.Text = "";
                    //refresh list
                    RefreshUserList();
                }
            }
        }

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            if (_selectedUser != null)
            {
                if (txtNewPassword.Text != txtUpdateConfirmPW.Text)
                {
                    lbStripStatus.Text = "Your new password does not match!";
                    return;
                }
                else if (!(txtNewPassword.Text.Any(char.IsLower) && txtNewPassword.Text.Any(char.IsUpper) && txtNewPassword.Text.Any(char.IsDigit) && (txtNewPassword.Text.Length > 8)))
                {
                    lbStripStatus.Text = "Password must have minimum 1 Uppercase, 1 Lowercase , 1 Number and 8 characters";
                    return;
                }

                //Update selected user with new password ONLY IF current logged in user is an admin
                int rowAffrected = _userLogic.UpdatePassword(txtNewPassword.Text, _selectedUser.UserLevel, CurrentUser.UserLevel);
                if (rowAffrected > 0)
                {
                    statusStrip.Text = "Password has been updated";
                    MessageBox.Show("\"" + _selectedUser.UserName + "\"" + " password has been updated!");
                }
                RefreshUserList();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            List<UserModel> users = _userLogic.GetListOfUsers();
            if (txtUserName.Text == "" && txtPassword.Text == "" && txtAddConfirmPW.Text == "" && txtEmail.Text == "")
            {
                lbStripStatus.Text = "Missing some information";
                MessageBox.Show("Please fill all form");
                return;
            }
            else if (txtPassword.Text != txtAddConfirmPW.Text)
            {
                lbStripStatus.Text = "Your password does not match";
                MessageBox.Show("Password dose not match");
                return;
            }
            else if (!(txtPassword.Text.Any(char.IsLower) && txtPassword.Text.Any(char.IsUpper) && txtPassword.Text.Any(char.IsDigit) && (txtPassword.Text.Length > 8)))
            {
                lbStripStatus.Text = "Password must have minimum 1 Uppercase, 1 Lowercase , 1 Number and 8 characters";
                MessageBox.Show("Password have condition");
                return;
            }

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserName == txtUserName.Text)
                {
                    lbStripStatus.Text = "User Name has already";
                    MessageBox.Show("User Name has already!");
                    return;

                }
            }

            //TODO for assignment: MAKE SURE PASSWORD VALIDATION IS GOOD AND NO FIELDS ARE LEFT EMPTY
            //NOTE: Combobox holds a list of strings, so we convert that string to the actural enum value it repersents
            AppEnum.UserLevel userLevel = (AppEnum.UserLevel)Enum.Parse(typeof(AppEnum.UserLevel), cbUserLevel.Text);
            //We pass all the Values to AddNewUser. We can cafst enums to ints to get their numeric value
            //userLogic.AddNewUser(txtUserName.Text, txtPassword.Text, cbUserLevel.SelectedIndex + 1, txtEmail.Text);
            _userLogic.AddNewUser(txtUserName.Text, txtPassword.Text, (int)userLevel, txtEmail.Text);
            RefreshUserList();
        }

        private void dgvMedia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //which row did i click on in the list
            if (row > -1) //-1 clicking column names
            {
                List<MediaModel> medias = (List<MediaModel>)dgvMedia.DataSource;
                _selectedMedia = medias.ElementAt<MediaModel>(row);
                txtSeletedID.Text = _selectedMedia.MediaID.ToString();
                txtSeletedTitle.Text = _selectedMedia.MediaTitle;
                txtSeletedDirector.Text = _selectedMedia.MediaDirector;
                txtSeletedGenre.Text = _selectedMedia.MediaGenre;
                txtSeletedLanguage.Text = _selectedMedia.MediaLanguage;
                txtSeletedPublish.Text = _selectedMedia.MediaPublishYear.ToString();
                txtSeletedBudget.Text = _selectedMedia.MediaBudget.ToString();
            }
        }

        private void btnDeleteMedia_Click(object sender, EventArgs e)
        {
            if (_selectedMedia != null)
            {

                DialogResult result = MessageBox.Show("Do you want to delete " + _selectedMedia.MediaTitle, "Delete Media", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Delete user in DB
                    int affectedRows = _mediaLogic.DeleteMediaByID(_selectedMedia.MediaID);
                    if (affectedRows > 0)
                    {
                        lbStripStatus.Text = "\"" + _selectedMedia.MediaTitle + "\"" + " has been deleted";
                    }
                    else
                    {
                        //couldn't find any users of this userID
                    }

                    //Clear out selectedUser
                    _selectedMedia = null;

                    txtSeletedID.Text = "";
                    txtSeletedTitle.Text = "";
                    txtSeletedDirector.Text = "";
                    txtSeletedGenre.Text = "";
                    txtSeletedLanguage.Text = "";
                    txtSeletedPublish.Text = "";
                    txtSeletedBudget.Text = "";

                    //refresh list
                    RefreshMediaList();
                }
            }
        }

        private void btnEditMedia_Click(object sender, EventArgs e)
        {
            cbUAMediaGenre.Items.Clear();
            cbUAMediaLanguage.Items.Clear();
            cbUAMediaDirector.Items.Clear();

            List<PairModel> lstGenres = _mediaLogic.ListGenres();
            List<PairModel> lstLanguage = _mediaLogic.ListLanguages();
            List<PairModel> lstDirector = _mediaLogic.ListDirector();

            for (int i = 0; i < lstGenres.Count; i++)
            {
                cbUAMediaGenre.Items.Add(lstGenres[i].PairName);
            }

            for (int i = 0; i < lstLanguage.Count; i++)
            {
                cbUAMediaLanguage.Items.Add(lstLanguage[i].PairName);
            }

            for (int i = 0; i < lstDirector.Count; i++)
            {
                cbUAMediaDirector.Items.Add(lstDirector[i].PairName);
            }

            txtUAMediaID.Text = txtSeletedID.Text;
            txtUAMediaTitle.Text = txtSeletedTitle.Text;
            cbUAMediaDirector.Text = txtSeletedDirector.Text;
            cbUAMediaGenre.Text = txtSeletedGenre.Text;
            cbUAMediaLanguage.Text = txtSeletedLanguage.Text;
            txtUAMediaPublish.Text = txtSeletedPublish.Text;
            txtUAMediaBudget.Text = txtSeletedBudget.Text;



        }

        private void btnResetMedia_Click(object sender, EventArgs e)
        {
            txtUAMediaID.Text = "";
            txtUAMediaTitle.Text = "";
            cbUAMediaDirector.Text = "";
            cbUAMediaGenre.Text = "";
            cbUAMediaLanguage.Text = "";
            txtUAMediaPublish.Text = "";
            txtUAMediaBudget.Text = "";
        }

        private void btnUpdateMedia_Click(object sender, EventArgs e)
        {
            if (txtUAMediaID.Text == "" || txtUAMediaTitle.Text == "" || cbUAMediaDirector.Text == "" || cbUAMediaGenre.Text == "" || cbUAMediaLanguage.Text == "" || txtUAMediaPublish.Text == "" || txtUAMediaBudget.Text == "")
            {
                lbStripStatus.Text = "Please fill all form";
                MessageBox.Show("Missing Information");
                return;
            }

            int iDirectorID = 1, iGenresID = 1, iLanguageID = 1;
            

            List<PairModel> lstGenres = _mediaLogic.ListGenres();
            List<PairModel> lstLanguage = _mediaLogic.ListLanguages();
            List<PairModel> lstDirector = _mediaLogic.ListDirector();

            for (int i = 0; i < lstDirector.Count; i++)
            {
                if (lstDirector[i].PairName == cbUAMediaDirector.Text)
                {
                    iDirectorID = lstDirector[i].PairID;
                    break;
                }
            }

            for (int i = 0; i < lstGenres.Count; i++)
            {
                if (lstGenres[i].PairName == cbUAMediaGenre.Text)
                {
                    iGenresID = lstGenres[i].PairID;
                    break;
                }
            }

            for (int i = 0; i < lstLanguage.Count; i++)
            {
                if (lstLanguage[i].PairName == cbUAMediaLanguage.Text)
                {
                    iLanguageID = lstLanguage[i].PairID;
                    break;
                }
            }

            //Update selected user with new password ONLY IF current logged in user is an admin
            int rowAffrected = _mediaLogic.UpdateMediaByID(int.Parse(txtUAMediaID.Text), txtUAMediaTitle.Text, iGenresID, iLanguageID, iDirectorID, int.Parse(txtUAMediaPublish.Text), decimal.Parse(txtUAMediaBudget.Text));
            if (rowAffrected > 0)
            {
                statusStrip.Text = "Media has been updated";
                MessageBox.Show("\"" + _selectedMedia.MediaTitle + "\"" + " Media has been updated!");
            }

            RefreshMediaList();
        }

        private void btnAddMedia_Click(object sender, EventArgs e)
        {
            if (txtUAMediaTitle.Text == "" || cbUAMediaDirector.Text == "" || cbUAMediaGenre.Text == "" || cbUAMediaLanguage.Text == "" || txtUAMediaPublish.Text == "" || txtUAMediaBudget.Text == "")
            {
                lbStripStatus.Text = "Please fill all form";
                MessageBox.Show("Missing Information");
                return;
            }

            int iDirectorID = 1, iGenresID = 1, iLanguageID = 1;


            List<PairModel> lstGenres = _mediaLogic.ListGenres();
            List<PairModel> lstLanguage = _mediaLogic.ListLanguages();
            List<PairModel> lstDirector = _mediaLogic.ListDirector();

            for (int i = 0; i < lstDirector.Count; i++)
            {
                if (lstDirector[i].PairName == cbUAMediaDirector.Text)
                {
                    iDirectorID = lstDirector[i].PairID;
                    break;
                }
            }

            for (int i = 0; i < lstGenres.Count; i++)
            {
                if (lstGenres[i].PairName == cbUAMediaGenre.Text)
                {
                    iGenresID = lstGenres[i].PairID;
                    break;
                }
            }

            for (int i = 0; i < lstLanguage.Count; i++)
            {
                if (lstLanguage[i].PairName == cbUAMediaLanguage.Text)
                {
                    iLanguageID = lstLanguage[i].PairID;
                    break;
                }
            }

            //Update selected user with new password ONLY IF current logged in user is an admin
            int rowAffrected = _mediaLogic.InsertNewMedia(txtUAMediaTitle.Text, iGenresID, iLanguageID, iDirectorID, int.Parse(txtUAMediaPublish.Text), decimal.Parse(txtUAMediaBudget.Text));
            if (rowAffrected > 0)
            {
                statusStrip.Text = "Media has been inserted";
                MessageBox.Show("\"" + txtUAMediaTitle.Text + "\"" + " Media has been inserted!");
            }

            RefreshMediaList();
        }

        private void dgvLanguage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)
            {
                List<PairModel> pairs = (List<PairModel>)dgvLanguage.DataSource;
                _selectedPair = pairs.ElementAt<PairModel>(row);
                txtLanguageID.Text = _selectedPair.PairID.ToString();
                txtLanguageName.Text = _selectedPair.PairName;
            }
        }

        private void dgvDirector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)
            {
                List<PairModel> pairs = (List<PairModel>)dgvDirector.DataSource;
                _selectedPair = pairs.ElementAt<PairModel>(row);
                txtDirectorID.Text = _selectedPair.PairID.ToString();
                txtDirectorName.Text = _selectedPair.PairName;
            }
        }

        private void dgvGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)
            {
                List<PairModel> pairs = (List<PairModel>)dgvGenre.DataSource;
                _selectedPair = pairs.ElementAt<PairModel>(row);
                txtGenreID.Text = _selectedPair.PairID.ToString();
                txtGenreName.Text = _selectedPair.PairName;
            }
        }

        private void btnAddLanguage_Click(object sender, EventArgs e)
        {
            _mediaLogic.InsertLanguage(txtLanguageName.Text);
            dgvLanguage.DataSource = _mediaLogic.ListLanguages();
        }

        private void btnLanguageUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Update " + txtLanguageName.Text + "?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _mediaLogic.UpdateLanguageByID(int.Parse(txtLanguageID.Text), txtLanguageName.Text);
                dgvLanguage.DataSource = _mediaLogic.ListLanguages();
            }
        }

        private void btnDeleteLanguage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Delete " + txtLanguageName.Text + "?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _mediaLogic.DeleteLanguageByID(int.Parse(txtLanguageID.Text));
                dgvLanguage.DataSource = _mediaLogic.ListLanguages();
            }
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Update " + txtGenreName.Text + "?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _mediaLogic.UpdateGenreByID(int.Parse(txtGenreID.Text), txtGenreName.Text);
                dgvGenre.DataSource = _mediaLogic.ListGenres();
            }
        }

        private void btnUpdateDitector_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Update "+ txtDirectorName.Text + "?","Warning",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _mediaLogic.UpdateDirectorByID(int.Parse(txtDirectorID.Text), txtDirectorName.Text);
                dgvDirector.DataSource = _mediaLogic.ListDirector();
            }
        }

        private void btnDeleteDirector_Click(object sender, EventArgs e)
        {   
            DialogResult result = MessageBox.Show("Do you want to Delete "+ txtDirectorName.Text + "?","Warning",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _mediaLogic.DeleteDirectorByID(int.Parse(txtDirectorID.Text));
                dgvDirector.DataSource = _mediaLogic.ListDirector();
            }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            _mediaLogic.InsertGenre(txtGenreName.Text);
            dgvGenre.DataSource = _mediaLogic.ListGenres();
        }

        private void btnAddDirector_Click(object sender, EventArgs e)
        {
            _mediaLogic.InsertDirector(txtDirectorName.Text);
            dgvDirector.DataSource = _mediaLogic.ListDirector();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Delete "+ txtGenreName.Text + "?","Warning",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _mediaLogic.DeleteGenreByID(int.Parse(txtGenreID.Text));
                dgvGenre.DataSource = _mediaLogic.ListGenres();
            }
        }
    }
}
