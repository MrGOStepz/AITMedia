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
    public partial class AdminForm : Form
    {
        private WebService _ws = new WebService();
        private String _seletedUserID = "";

        public AdminForm()
        {
            InitializeComponent();
        }



        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshUserList();
            cbUserLevel.DataSource = Enum.GetValues(typeof(AppEnum.UserLevel));

            //Fill data to Data grid view
            dgvMedia.DataSource = _ws.ListMedia();
            dgvAvailableMedia.DataSource = _ws.ListMediaAvailbable();
            dgvBorrowMedia.DataSource = _ws.ListMediaBorrowed();
            dgvLanguage.DataSource = _ws.ListLanguages();
            dgvGenre.DataSource = _ws.ListGenres();
            dgvDirector.DataSource = _ws.ListDirector();
            dgvListOfResvered.DataSource = _ws.ListOfReservedMedia();

            cbUAMediaGenre.DataSource = _ws.ListGenres();
            cbUAMediaGenre.DisplayMember = "PairName";

            cbUAMediaLanguage.DataSource = _ws.ListLanguages();
            cbUAMediaLanguage.DisplayMember = "PairName";

            cbUAMediaDirector.DataSource = _ws.ListDirector();
            cbUAMediaDirector.DisplayMember = "PairName";

        }

        #region Refresh User and Media Data grid view
        private void RefreshUserList()
        {
            dgvUsers.DataSource = _ws.GetListofUsers();
        }

        private void RefreshMediaList()
        {
            dgvMedia.DataSource = _ws.ListMedia();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        #endregion

        #region User, Media, Language, Genre and Director Cell click event Data grid view

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //which row did i click on in the list
            if (dgvUsers.Rows[e.RowIndex].Cells["UserName"].Value.ToString() != "") //-1 clicking column names
            {
                txtSelectedUser.Text = dgvUsers.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                _seletedUserID = dgvUsers.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
            }
        }

        private void dgvMedia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //which row did i click on in the list
            if (dgvMedia.Rows[e.RowIndex].Cells["MediaID"].Value.ToString() != "") //-1 clicking column names
            {
                txtSeletedID.Text = dgvMedia.Rows[e.RowIndex].Cells["MediaID"].Value.ToString();
                txtSeletedTitle.Text = dgvMedia.Rows[e.RowIndex].Cells["MediaTitle"].Value.ToString(); 
                txtSeletedDirector.Text = dgvMedia.Rows[e.RowIndex].Cells["MediaDirector"].Value.ToString(); 
                txtSeletedGenre.Text = dgvMedia.Rows[e.RowIndex].Cells["MediaGenre"].Value.ToString(); 
                txtSeletedLanguage.Text = dgvMedia.Rows[e.RowIndex].Cells["MediaLanguage"].Value.ToString(); 
                txtSeletedPublish.Text = dgvMedia.Rows[e.RowIndex].Cells["MediaPublishYear"].Value.ToString();
                txtSeletedBudget.Text = dgvMedia.Rows[e.RowIndex].Cells["MediaBudget"].Value.ToString();
            }
        }

        private void dgvLanguage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (dgvLanguage.Rows[e.RowIndex].Cells["PairID"].Value.ToString() != "")
            {
                txtLanguageID.Text = dgvLanguage.Rows[e.RowIndex].Cells["PairID"].Value.ToString();
                txtLanguageName.Text = dgvLanguage.Rows[e.RowIndex].Cells["PairName"].Value.ToString();
            }
        }

        private void dgvDirector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (dgvDirector.Rows[e.RowIndex].Cells["PairID"].Value.ToString() != "")
            {
                txtDirectorID.Text = dgvDirector.Rows[e.RowIndex].Cells["PairID"].Value.ToString();
                txtDirectorName.Text = dgvDirector.Rows[e.RowIndex].Cells["PairName"].Value.ToString();
            }
        }

        private void dgvGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (dgvGenre.Rows[e.RowIndex].Cells["PairID"].Value.ToString() != "")
            {
                txtGenreID.Text = dgvGenre.Rows[e.RowIndex].Cells["PairID"].Value.ToString();
                txtGenreName.Text = dgvGenre.Rows[e.RowIndex].Cells["PairName"].Value.ToString();
            }
        }

        #endregion

        #region Add, Update and Delete User
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (txtSelectedUser.Text != "")
            {

                DialogResult result = MessageBox.Show("Do you want to delete ?" + txtSelectedUser.Text, "Delete User", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Delete user in DB
                    int affectedRows = _ws.DeleteUserByUserID(int.Parse(_seletedUserID));
                    if (affectedRows > 0)
                    {
                        lbStripStatus.Text = "\"" + txtSelectedUser.Text + "\"" + " has been deleted";
                    }
                    else
                    {
                        //couldn't find any users of this userID
                    }

                    txtSelectedUser.Text = "";
                    //refresh list
                    RefreshUserList();
                }
            }
        }

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            if (txtSelectedUser.Text != null)
            {
                //Check Condition Password mush have 1 Lowcase 1 Uppercase 1 Number and Length more than 8
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

                AppEnum.UserLevel userLevel = (AppEnum.UserLevel)Enum.Parse(typeof(AppEnum.UserLevel), cbUserLevel.Text);

                //Update selected user with new password ONLY IF current logged in user is an admin
                int rowAffrected = _ws.UpdatePassword(txtNewPassword.Text, (int)userLevel, CurrentUser.UserLevel);
                if (rowAffrected > 0)
                {
                    statusStrip.Text = "Password has been updated";
                    MessageBox.Show("\"" + txtSelectedUser.Text + "\"" + " password has been updated!");
                }
                RefreshUserList();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            DataTable userData = _ws.GetListofUsers();
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

            for (int i = 0; i < userData.Rows.Count; i++)
            {
                if (userData.Rows[i]["UserName"].ToString() == txtUserName.Text)
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
            _ws.InsertNewUser(txtUserName.Text, txtPassword.Text, (int)userLevel, txtEmail.Text);
            RefreshUserList();
        }

        #endregion

        #region Add, Update and Delete Media
    
        private void btnDeleteMedia_Click(object sender, EventArgs e)
        {
            if (txtSeletedID.Text != "")
            {

                DialogResult result = MessageBox.Show("Do you want to delete " + txtSeletedTitle.Text, "Delete Media", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Delete user in DB
                    int affectedRows = _ws.DeleteMediaByID(int.Parse(txtSeletedID.Text));
                    if (affectedRows > 0)
                    {
                        lbStripStatus.Text = "\"" + txtSeletedTitle.Text + "\"" + " has been deleted";
                    }
                    else
                    {
                        //couldn't find any users of this userID
                    }

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
            cbUAMediaLanguage.DataSource = _ws.ListLanguages();
            cbUAMediaGenre.DataSource = _ws.ListGenres();
            cbUAMediaDirector.DataSource = _ws.ListDirector();

            cbUAMediaLanguage.DisplayMember = "PairName";
            cbUAMediaGenre.DisplayMember = "PairName";
            cbUAMediaDirector.DisplayMember = "PairName";

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


            DataTable lstGenres = _ws.ListGenres();
            DataTable lstLanguage = _ws.ListLanguages();
            DataTable lstDirector = _ws.ListDirector();

            for (int i = 0; i < lstDirector.Rows.Count; i++)
            {
                if (lstDirector.Rows[0]["PairName"].ToString() == cbUAMediaDirector.Text)
                {
                    iDirectorID = int.Parse(lstDirector.Rows[0]["PairID"].ToString());
                    break;
                }
            }

            for (int i = 0; i < lstLanguage.Rows.Count; i++)
            {
                if (lstLanguage.Rows[0]["PairName"].ToString() == cbUAMediaLanguage.Text)
                {
                    iLanguageID = int.Parse(lstLanguage.Rows[0]["PairID"].ToString());
                    break;
                }
            }

            for (int i = 0; i < lstGenres.Rows.Count; i++)
            {
                if (lstGenres.Rows[0]["PairName"].ToString() == cbUAMediaGenre.Text)
                {
                    iGenresID = int.Parse(lstGenres.Rows[0]["PairID"].ToString());
                    break;
                }
            }


            //Update selected user with new password ONLY IF current logged in user is an admin
            int rowAffrected = _ws.UpdateMediaByID(int.Parse(txtUAMediaID.Text), txtUAMediaTitle.Text, iGenresID, iLanguageID, iDirectorID, int.Parse(txtUAMediaPublish.Text), decimal.Parse(txtUAMediaBudget.Text));
            if (rowAffrected > 0)
            {
                statusStrip.Text = "Media has been updated";
                MessageBox.Show("\"" + txtSeletedTitle.Text + "\"" + " Media has been updated!");
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


            DataTable lstGenres = _ws.ListGenres();
            DataTable lstLanguage = _ws.ListLanguages();
            DataTable lstDirector = _ws.ListDirector();

            for (int i = 0; i < lstDirector.Rows.Count; i++)
            {
                if (lstDirector.Rows[0]["PairName"].ToString() == cbUAMediaDirector.Text)
                {
                    iDirectorID = int.Parse(lstDirector.Rows[0]["PairID"].ToString());
                    break;
                }
            }

            for (int i = 0; i < lstLanguage.Rows.Count; i++)
            {
                if (lstLanguage.Rows[0]["PairName"].ToString() == cbUAMediaLanguage.Text)
                {
                    iLanguageID = int.Parse(lstLanguage.Rows[0]["PairID"].ToString());
                    break;
                }
            }

            for (int i = 0; i < lstGenres.Rows.Count; i++)
            {
                if (lstGenres.Rows[0]["PairName"].ToString() == cbUAMediaGenre.Text)
                {
                    iGenresID = int.Parse(lstGenres.Rows[0]["PairID"].ToString());
                    break;
                }
            }

            //Update selected user with new password ONLY IF current logged in user is an admin
            int rowAffrected = _ws.InsertNewMedia(txtUAMediaTitle.Text, iGenresID, iLanguageID, iDirectorID, int.Parse(txtUAMediaPublish.Text), decimal.Parse(txtUAMediaBudget.Text));
            if (rowAffrected > 0)
            {
                statusStrip.Text = "Media has been inserted";
                MessageBox.Show("\"" + txtUAMediaTitle.Text + "\"" + " Media has been inserted!");
            }

            RefreshMediaList();
        }

        #endregion

        #region Add, Update and Delete Language

        private void btnAddLanguage_Click(object sender, EventArgs e)
        {
            _ws.InsertLanguage(txtLanguageName.Text);
            dgvLanguage.DataSource = _ws.ListLanguages();
        }

        private void btnLanguageUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Update " + txtLanguageName.Text + "?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _ws.UpdateLanguageByID(int.Parse(txtLanguageID.Text), txtLanguageName.Text);
                dgvLanguage.DataSource = _ws.ListLanguages();
            }
        }

        private void btnDeleteLanguage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Delete " + txtLanguageName.Text + "?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _ws.DeleteLanguageByID(int.Parse(txtLanguageID.Text));
                dgvLanguage.DataSource = _ws.ListLanguages();
            }
        }
        #endregion

        #region Add, Update and Delete Genre
        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Update " + txtGenreName.Text + "?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _ws.UpdateGenreByID(int.Parse(txtGenreID.Text), txtGenreName.Text);
                dgvGenre.DataSource = _ws.ListGenres();
            }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            _ws.InsertGenre(txtGenreName.Text);
            dgvGenre.DataSource = _ws.ListGenres();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Delete " + txtGenreName.Text + "?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _ws.DeleteGenreByID(int.Parse(txtGenreID.Text));
                dgvGenre.DataSource = _ws.ListGenres();
            }
        }
        #endregion

        #region Add, Update and Delete Director
        private void btnUpdateDitector_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Update "+ txtDirectorName.Text + "?","Warning",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _ws.UpdateDirectorByID(int.Parse(txtDirectorID.Text), txtDirectorName.Text);
                dgvDirector.DataSource = _ws.ListDirector();
            }
        }

        private void btnDeleteDirector_Click(object sender, EventArgs e)
        {   
            DialogResult result = MessageBox.Show("Do you want to Delete "+ txtDirectorName.Text + "?","Warning",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _ws.DeleteDirectorByID(int.Parse(txtDirectorID.Text));
                dgvDirector.DataSource = _ws.ListDirector();
            }
        }



        private void btnAddDirector_Click(object sender, EventArgs e)
        {
            _ws.InsertDirector(txtDirectorName.Text);
            dgvDirector.DataSource = _ws.ListDirector();
        }
        #endregion

        private void btnLogout_Click(object sender, EventArgs e)
        {
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
