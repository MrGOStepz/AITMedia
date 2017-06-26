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
    public partial class LoginForm : Form
    {
        //webservice as an attribute - woo!
        WebService ws = new WebService();

        public LoginForm()
        {
            InitializeComponent();
            //txtUsername.Text = "admin";
            //txtPassword.Text = "Admin123";

            txtUsername.Text = "user";
            txtPassword.Text = "a1234567B";
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            //get users based on textbox entries
            DataTable data = ws.GetListOfUsersByLogin(txtUsername.Text, txtPassword.Text);

            //if got some users
            if (data.Rows.Count > 0)
            {
                //keep track of current user details
                CurrentUser.UserName = data.Rows[0]["UserName"].ToString();
                CurrentUser.UserLevel = (int)data.Rows[0]["UserLevel"];
                CurrentUser.UserID = (int)data.Rows[0]["UserID"];
                CurrentUser.UserEmail = data.Rows[0]["UserEmail"].ToString();

                //if admin user (userLevel 3) goto admin form
                if (CurrentUser.UserLevel == 3)
                {
                    //go to admin form

                    //create new thread that will call this function openAdminForm
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenAdminForm));
                    t.Start();
                }
                else
                {
                    //go to student form
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMediaForm));
                    t.Start();
                }
                //either way, close this form off
                this.Close();
            }
            else
            {
                lblError.Text =AppConstants.LoginError;
            }
        }

        public static void OpenMediaForm()
        {
            Application.Run(new MediaBrowser());
        }

        public static void OpenAdminForm()
        {
            Application.Run(new AdminForm());
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            //UserLogic userLogic = new UserLogic();
            //List<UserModel> users = userLogic.GetListOfUsers();

            //userComboBox.DataSource = userLogic.GetListOfUsers(); //make combobox reference list of all user models
            ////what to show in the list: Uses the string provided to look for an attribute of this name for each list item
            //userComboBox.DisplayMember = "UserName"; 
            ////what the value of this choice would be if we chose it 
            //userComboBox.ValueMember = "UserID";
        }
    }
}
