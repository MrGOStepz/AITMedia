using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BusinessLogic;
using System.Data;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable GetListofUsers()
        {
            UserLogic userLogic = new UserLogic();
            List<UserModel> users = userLogic.GetListOfUsers();
            
            return AppUtil.ToDataTable(users); //return this in the form of xnl to be sent via the internet or local network

        }

        [WebMethod]
        public DataTable GetListOfUsersByLogin(string userName, string password)
        {
            UserLogic userLogic = new UserLogic();
            List<UserModel> users = userLogic.GetListOfUsersByLogin(userName, password);

            return AppUtil.ToDataTable(users);
        }

        #region Add, Update and Delete User
        [WebMethod]
        public int InsertNewUser(String UserName, String Password, int UserLevel, String Email)
        {
            UserLogic userLogic = new UserLogic();

            return userLogic.AddNewUser(UserName, Password, UserLevel, Email);
        }

        [WebMethod]
        public int UpdatePassword(String NewPassword, int UserID, int AdminLevel)
        {
            UserLogic userLogic = new UserLogic();
            //Need to be an admin to change user passwords (for some reason)
            if (AdminLevel < 3)
            {
                return -1;
            }
            else
            {
                return userLogic.UpdatePassword(NewPassword, UserID, AdminLevel);
            }
        }

        [WebMethod]
        public int DeleteUserByUserID(int UserID)
        {
            UserLogic userLogic = new UserLogic();

            return userLogic.DeleteUserByUserID(UserID);
        }
        #endregion



        #region Search Media
        /// <summary>
        /// Get List of Media
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataTable ListMedia()
        {
            MediaLogic mediaLogic = new MediaLogic();
            List<MediaModel> medias = new List<MediaModel>();

            medias = mediaLogic.ListMedia();

            return AppUtil.ToDataTable(medias);
        }

        /// <summary>
        /// Get List of Media by publish year
        /// </summary>
        /// <param name="publishYear"></param>
        /// <returns></returns>
        /// 
        [WebMethod]
        public DataTable ListMediaByPublishYear(int publishYear)
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<MediaModel> medias = new List<MediaModel>();

                medias = mediaLogic.ListMediaByPublishYear(publishYear);

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Get Media Data by Director
        /// </summary>
        /// <param name="director"></param>
        /// <returns></returns>
        [WebMethod]
        public DataTable ListMediaByDirector(String director)
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<MediaModel> medias = new List<MediaModel>();

                medias = mediaLogic.ListMediaByDirector(director);

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [WebMethod]
        public DataTable ListMediaByBudget(decimal budget)
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<MediaModel> medias = new List<MediaModel>();

                medias = mediaLogic.ListMediaByBudget(budget);

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [WebMethod]
        public DataTable ListMediaByGenre(String genre)
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<MediaModel> medias = new List<MediaModel>();

                medias = mediaLogic.ListMediaByGenre(genre);

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [WebMethod]
        public DataTable ListMediaByLanguage(String language)
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<MediaModel> medias = new List<MediaModel>();

                medias = mediaLogic.ListMediaByLanguage(language);

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [WebMethod]
        public DataTable ListMediaByTitle(String title)
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<MediaModel> medias = new List<MediaModel>();

                medias = mediaLogic.ListMediaByTitle(title);

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region List of Borrow user by ID on Media Browser
        [WebMethod]
        public DataTable ListMediaBorrowUser(int UserID)
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<BRModel> medias = new List<BRModel>();

                medias = mediaLogic.ListMediaBorrowUser(UserID);

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region Get List Language,Genre and Director and Fill into combobox in Admin Form

        [WebMethod]
        public DataTable ListLanguages()
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<PairModel> medias = new List<PairModel>();

                medias = mediaLogic.ListLanguages();

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [WebMethod]
        public DataTable ListGenres()
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<PairModel> medias = new List<PairModel>();

                medias = mediaLogic.ListGenres();

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [WebMethod]
        public DataTable ListDirector()
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<PairModel> medias = new List<PairModel>();

                medias = mediaLogic.ListDirector();

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region Report Media Available in Admin Form
        [WebMethod]
        public DataTable ListMediaAvailbable()
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<MediaModel> medias = new List<MediaModel>();

                medias = mediaLogic.ListMediaAvailbable();

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        [WebMethod]
        public DataTable ListMediaBorrowed()
        {
            try
            {
                MediaLogic mediaLogic = new MediaLogic();
                List<MediaModel> medias = new List<MediaModel>();

                medias = mediaLogic.ListMediaBorrowed();

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region Add, Update and Delete Media
        [WebMethod]
        public int DeleteMediaByID(int ID)
        {
            MediaLogic mediaLogic = new MediaLogic();

            return mediaLogic.DeleteMediaByID(ID);
        }

        [WebMethod]
        public int UpdateMediaByID(int ID, String Title, int Genre, int Language, int Director, int Publish, decimal Budget)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.UpdateMediaByID(ID, Title, Genre, Director, Language, Publish, Budget);
        }

        [WebMethod]
        public int InsertNewMedia(String Title, int Genre, int Director, int Language, int PublishYear, decimal Budget)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.InsertNewMedia(Title, Genre, Director, Language, PublishYear, Budget);
        }
        #endregion

        #region Borrow, Return and Reserve Media
        [WebMethod]
        public int InsertNewResevebyID(int UserID, int MediaID, String Date)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.InsertNewResevebyID(UserID, MediaID, Date);
        }

        [WebMethod]
        public int InsertBorrowMedia(int UserID, int MediaID, String DateBorrow, String DateReturn, String MediaTitle)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.InsertBorrowMedia(UserID, MediaID, DateBorrow, DateReturn, MediaTitle);
        }

        [WebMethod]
        public int UpdateReturnMedia(String ActualDate, decimal LateFee, int UserID, int MediaID)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.UpdateReturnMedia(ActualDate, LateFee, UserID, MediaID);
        }

        [WebMethod]
        public DataTable ListOfReservedMedia()
        {
            try
            {
                
                MediaLogic mediaLogic = new MediaLogic();
                List<BRModel> medias = new List<BRModel>();

                medias = mediaLogic.ListOfReservedMedia();

                return AppUtil.ToDataTable(medias);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Add Update Delete Language, Genre and Director
        [WebMethod]
        public int DeleteLanguageByID(int LanguageID)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.DeleteLanguageByID(LanguageID);
        }

        [WebMethod]
        public int DeleteGenreByID(int GenreID)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.DeleteGenreByID(GenreID);
        }

        [WebMethod]
        public int DeleteDirectorByID(int DirectorID)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.DeleteDirectorByID(DirectorID);
        }

        [WebMethod]
        public int UpdateLanguageByID(int LanguageID, String LanguageName)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.UpdateLanguageByID(LanguageID, LanguageName);
        }

        [WebMethod]
        public int UpdateGenreByID(int GenreID, String GenreName)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.UpdateGenreByID(GenreID, GenreName);
        }

        [WebMethod]
        public int UpdateDirectorByID(int DirectorID, String DirectorName)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.UpdateDirectorByID(DirectorID, DirectorName);
        }

        [WebMethod]
        public int InsertLanguage(String LanguageName)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.InsertLanguage(LanguageName);
        }

        [WebMethod]
        public int InsertGenre(String GenreName)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.InsertGenre(GenreName);
        }

        [WebMethod]
        public int InsertDirector(String DirectorName)
        {
            MediaLogic mediaLogic = new MediaLogic();
            return mediaLogic.InsertDirector(DirectorName);
        }
        #endregion

        #region List of Laguage,Genre and Director
        [WebMethod]
        public DataTable GetListofLanguage()
        {
            MediaLogic mediaLogic = new MediaLogic();
            PairModel pairModel = new PairModel();
            List<PairModel> pair = mediaLogic.ListLanguages();

            return AppUtil.ToDataTable(pair); //return this in the form of xnl to be sent via the internet or local network
        }

        [WebMethod]
        public DataTable GetListofGenre()
        {
            MediaLogic mediaLogic = new MediaLogic();
            PairModel pairModel = new PairModel();
            List<PairModel> pair = mediaLogic.ListGenres();

            return AppUtil.ToDataTable(pair); //return this in the form of xnl to be sent via the internet or local network
        }

        [WebMethod]
        public DataTable GetListofDirector()
        {
            MediaLogic mediaLogic = new MediaLogic();
            PairModel pairModel = new PairModel();
            List<PairModel> pair = mediaLogic.ListDirector();

            return AppUtil.ToDataTable(pair); //return this in the form of xnl to be sent via the internet or local network
        }
        #endregion
    }
}
