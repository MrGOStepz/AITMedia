using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class MediaLogic
    {
        private MediaDAO mediaDAO;
        private MediaDS.ViewMediaDataTable mediaTable;
        private MediaDS.TabLanguageDataTable languageTable;
        private MediaDS.TabGenreDataTable genreTable;
        private MediaDS.TabDirectorDataTable directorTable;
        private MediaDS.TabBorrowDataTable borrowTable;
        private MediaDS.TabReservedDataTable reservedTable;
        private MediaDS.ViewMediaAvailableDataTable mediaAvailableTable;
        private MediaDS.ViewMediaBorrowedDataTable mediaBorrowedTable;

        public MediaLogic()
        {
            mediaDAO = new MediaDAO();
            mediaTable = new MediaDS.ViewMediaDataTable();
            languageTable = new MediaDS.TabLanguageDataTable();
            genreTable = new MediaDS.TabGenreDataTable();
            directorTable = new MediaDS.TabDirectorDataTable();
            borrowTable = new MediaDS.TabBorrowDataTable();
            mediaAvailableTable = new MediaDS.ViewMediaAvailableDataTable();
            mediaBorrowedTable = new MediaDS.ViewMediaBorrowedDataTable();
            reservedTable = new MediaDS.TabReservedDataTable();
        }

        #region Search Media
        /// <summary>
        /// Get List of Media
        /// </summary>
        /// <returns></returns>
        public List<MediaModel> ListMedia()
        {
            List<MediaModel> medias = new List<MediaModel>();
            mediaTable = mediaDAO.ListMedia();

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        /// <summary>
        /// Get List of Media by publish year
        /// </summary>
        /// <param name="publishYear"></param>
        /// <returns></returns>
        public List<MediaModel> ListMediaByPublishYear(int publishYear)
        {
            try
            {
                List<MediaModel> medias = new List<MediaModel>();
                mediaTable = mediaDAO.ListMediaByPublishYear(publishYear);

                foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
                {
                    MediaModel media = MediaModel.Parse(row);
                    medias.Add(media);
                }
                return medias;
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
        public List<MediaModel> ListMediaByDirector(String director)
        {
            try
            {
                List<MediaModel> medias = new List<MediaModel>();
                mediaTable = mediaDAO.ListMediaByDirector(director);

                foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
                {
                    MediaModel media = MediaModel.Parse(row);
                    medias.Add(media);
                }
                return medias;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<MediaModel> ListMediaByBudget(decimal budget)
        {
            try
            {
                List<MediaModel> medias = new List<MediaModel>();
                mediaTable = mediaDAO.ListMediaByBudget(budget);

                foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
                {
                    MediaModel media = MediaModel.Parse(row);
                    medias.Add(media);
                }
                return medias;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<MediaModel> ListMediaByGenre(String genre)
        {
            try
            {
                List<MediaModel> medias = new List<MediaModel>();
                mediaTable = mediaDAO.ListMediaByGenre(genre);

                foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
                {
                    MediaModel media = MediaModel.Parse(row);
                    medias.Add(media);
                }
                return medias;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<MediaModel> ListMediaByLanguage(String language)
        {
            try
            {
                List<MediaModel> medias = new List<MediaModel>();
                mediaTable = mediaDAO.ListMediaByLanguage(language);

                foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
                {
                    MediaModel media = MediaModel.Parse(row);
                    medias.Add(media);
                }
                return medias;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<MediaModel> ListMediaByTitle(String title)
        {
            try
            {
                List<MediaModel> medias = new List<MediaModel>();
                mediaTable = mediaDAO.ListMediaByTitle(title);

                foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
                {
                    MediaModel media = MediaModel.Parse(row);
                    medias.Add(media);
                }
                return medias;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region List of Borrow user by ID on Media Browser
        public List<BRModel> ListMediaBorrowUser(int UserID)
        {
            try
            {
                List<BRModel> medias = new List<BRModel>();
                borrowTable = mediaDAO.ListMediaReturn(UserID);

                foreach (MediaDS.TabBorrowRow row in borrowTable.Rows)
                {
                    BRModel media = BRModel.Parse(row);
                    medias.Add(media);
                }
                return medias;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region Get List Language,Genre and Director and Fill into combobox in Admin Form

        public List<PairModel> ListLanguages()
        {
            try
            {
                List<PairModel> list = new List<PairModel>();
                languageTable = mediaDAO.ListLanguages();
                foreach (MediaDS.TabLanguageRow row in languageTable.Rows)
                {
                    PairModel pair = PairModel.Parse(row);
                    list.Add(pair);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<PairModel> ListGenres()
        {
            try
            {
                List<PairModel> list = new List<PairModel>();
                genreTable = mediaDAO.ListGenres();
                foreach (MediaDS.TabGenreRow row in genreTable.Rows)
                {
                    PairModel pair = PairModel.Parse(row);
                    list.Add(pair);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<PairModel> ListDirector()
        {
            try
            {
                List<PairModel> list = new List<PairModel>();
                directorTable = mediaDAO.ListDirector();
                foreach (MediaDS.TabDirectorRow row in directorTable.Rows)
                {
                    PairModel pair = PairModel.Parse(row);
                    list.Add(pair);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region Report Media Available in Admin Form
        public List<MediaModel> ListMediaAvailbable()
        {
            try
            {
                List<MediaModel> medias = new List<MediaModel>();
                mediaAvailableTable = mediaDAO.ListMediaAvailbable();

                foreach (MediaDS.ViewMediaAvailableRow row in mediaAvailableTable.Rows)
                {
                    MediaModel media = MediaModel.Parse(row);
                    medias.Add(media);
                }
                return medias;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<MediaModel> ListMediaBorrowed()
        {
            try
            {
                List<MediaModel> medias = new List<MediaModel>();
                mediaBorrowedTable = mediaDAO.ListMediaBorrowed();

                foreach (MediaDS.ViewMediaBorrowedRow row in mediaBorrowedTable.Rows)
                {
                    MediaModel media = MediaModel.Parse(row);
                    medias.Add(media);
                }
                return medias;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region Add, Update and Delete Media
        public int DeleteMediaByID(int ID)
        {
            return mediaDAO.DeleteMediaByID(ID);
        }

        public int UpdateMediaByID(int ID, String Title, int Genre, int Language, int Director, int Publish, decimal Budget)
        {
            return mediaDAO.UpdateMediaByID(ID, Title, Genre, Director, Language, Publish, Budget);
        }

        public int InsertNewMedia(String Title, int Genre, int Director, int Language, int PublishYear, decimal Budget)
        {
            return mediaDAO.InsertNewMedia(Title, Genre, Director, Language, PublishYear, Budget);
        }
        #endregion

        #region Borrow, Return and Reserve Media
        public int InsertNewResevebyID(int UserID, int MediaID, String Date)
        {
            return mediaDAO.InsertNewReserveByID(UserID,MediaID,Date);
        }

        public int InsertBorrowMedia(int UserID, int MediaID, String DateBorrow, String DateReturn, String MediaTitle)
        {
            return mediaDAO.InsertBorrowMedia(UserID, MediaID, DateBorrow, DateReturn, MediaTitle);
        }

        public int UpdateReturnMedia(String ActualDate, decimal LateFee, int UserID, int MediaID)
        {
            return mediaDAO.UpdateReturnMeida(ActualDate, LateFee, UserID, MediaID);
        }

        public List<BRModel> ListOfReservedMedia()
        {
            try
            {
                List<BRModel> medias = new List<BRModel>();
                reservedTable = mediaDAO.ListOfReservedMedia();

                foreach (MediaDS.TabReservedRow row in reservedTable.Rows)
                {
                    BRModel media = BRModel.Parse(row);
                    medias.Add(media);
                }
                return medias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Add Update Delete Language, Genre and Director
        public int DeleteLanguageByID(int LanguageID)
        {
            return mediaDAO.DeleteLanguageByID(LanguageID);
        }

        public int DeleteGenreByID(int GenreID)
        {
            return mediaDAO.DeleteGenreByID(GenreID);
        }

        public int DeleteDirectorByID(int DirectorID)
        {
            return mediaDAO.DeleteDirectorByID(DirectorID);
        }

        public int UpdateLanguageByID(int LanguageID, String LanguageName)
        {
            return mediaDAO.UpdateLanguageByID(LanguageID, LanguageName);
        }

        public int UpdateGenreByID(int GenreID, String GenreName)
        {
            return mediaDAO.UpdateGenreByID(GenreID, GenreName);
        }

        public int UpdateDirectorByID(int DirectorID, String DirectorName)
        {
            return mediaDAO.UpdateDirectorByID(DirectorID, DirectorName);
        }

        public int InsertLanguage(String LanguageName)
        {
            return mediaDAO.InsertLanguage(LanguageName);
        }

        public int InsertGenre(String GenreName)
        {
            return mediaDAO.InsertGenre(GenreName);
        }

        public int InsertDirector(String DirectorName)
        {
            return mediaDAO.InsertDirector(DirectorName);
        }
        #endregion
    }
}
