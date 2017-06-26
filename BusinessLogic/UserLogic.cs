using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class UserLogic
    {
        //attributes
        private UserDAO userDAO;
        private UserDS.TabUserDataTable userTable;

        public UserLogic()
        {
            userDAO = new UserDAO();
            userTable = new UserDS.TabUserDataTable();
        }

        public List<UserModel> GetListOfUsers()
        {
            List<UserModel> users = new List<UserModel>(); //build empty list first

            userTable = userDAO.GetUserDataTable(); //fill userTable from our userDAO

            //for each row in our user table...
            foreach (UserDS.TabUserRow userRow in userTable.Rows)
            {
                //conver that row to a userModel and add it to the list
                UserModel user = UserModel.Parse(userRow);
                users.Add(user);
            }

            return users; //return list of users :D
        }

        public List<UserModel> GetListOfUsersByLogin(string userName, string password)
        {
            try
            {
                List<UserModel> users = new List<UserModel>(); //build empty list first

                userTable = userDAO.GetUserByUserNamePassword(userName, password);

                //for each row in our user table...
                foreach (UserDS.TabUserRow userRow in userTable.Rows)
                {
                    //conver that row to a userModel and add it to the list
                    UserModel user = UserModel.Parse(userRow);
                    users.Add(user);
                }

                return users; //return list of users :D
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        #region Add, Update and Delete User
        public int AddNewUser(String UserName, String Password, int UserLevel, String Email)
        {
            return userDAO.InsertNewUser(UserName, Password, UserLevel, Email);
        }

        public int UpdatePassword(String NewPassword, int UserID, int AdminLevel)
        {
            //Need to be an admin to change user passwords (for some reason)
            if (AdminLevel < 3)
            {
                return -1;
            }
            else
            {
                return userDAO.UpdatePassword(NewPassword, UserID);
            }
        }

        public int DeleteUserByUserID(int UserID)
        {
            return userDAO.DeleteUserByUserID(UserID);
        }
        #endregion
    }
}
