using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.MediaDSTableAdapters;

namespace DataAccessLayer
{
    public class MediaDAO
    {
        private MediaDS mediaDataSet;
        private ViewMediaTableAdapter viewMediaAdapter;
        private TabLanguageTableAdapter languageTableAdapter;
        private TabGenreTableAdapter genreTableAdapter;
        private TabMediaTableAdapter mediaTableAdapter;
        private TabDirectorTableAdapter directorTableAdapter;
        private TabReservedTableAdapter reservedTableAdapter;
        private TabBorrowTableAdapter borrowTableAdapter;
        private ViewMediaAvailableTableAdapter viewMediaAvailavleAdapter;
        private ViewMediaBorrowedTableAdapter viewMediaBorrwedAdapter;
        //if we need TabMediaTableAdapter, we'll add it later :/

        public MediaDAO()
        {
            mediaDataSet = new MediaDS();
            viewMediaAdapter = new ViewMediaTableAdapter();
            languageTableAdapter = new TabLanguageTableAdapter();
            genreTableAdapter = new TabGenreTableAdapter();
            mediaTableAdapter = new TabMediaTableAdapter();
            directorTableAdapter = new TabDirectorTableAdapter();
            reservedTableAdapter = new TabReservedTableAdapter();
            borrowTableAdapter = new TabBorrowTableAdapter();
            viewMediaAvailavleAdapter = new ViewMediaAvailableTableAdapter();
            viewMediaBorrwedAdapter = new ViewMediaBorrowedTableAdapter();
        }

        #region Get data View Media and Filter Search
        public MediaDS.ViewMediaDataTable ListMedia()
        {
            viewMediaAdapter.Fill(mediaDataSet.ViewMedia);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByPublishYear(int publishYear)
        {
            viewMediaAdapter.FillByPublishYear(mediaDataSet.ViewMedia, publishYear);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByBudget(decimal budget)
        {
            viewMediaAdapter.FillByBudget(mediaDataSet.ViewMedia, budget);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByDirector(String director)
        {
            viewMediaAdapter.FillByDirector(mediaDataSet.ViewMedia, director);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByGenre(String genre)
        {
            viewMediaAdapter.FillByGenre(mediaDataSet.ViewMedia, genre);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByTitle(String title)
        {
            viewMediaAdapter.FillByTitle(mediaDataSet.ViewMedia, title);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByLanguage(String language)
        {
            viewMediaAdapter.FillByLanguage(mediaDataSet.ViewMedia, language);
            return mediaDataSet.ViewMedia;
        }
        #endregion

        #region Get data Table Language, Genre and Director
        public MediaDS.TabLanguageDataTable ListLanguages()
        {
            languageTableAdapter.Fill(mediaDataSet.TabLanguage);
            return mediaDataSet.TabLanguage;
        }
        public MediaDS.TabGenreDataTable ListGenres()
        {
            genreTableAdapter.Fill(mediaDataSet.TabGenre);
            return mediaDataSet.TabGenre;
        }

        public MediaDS.TabDirectorDataTable ListDirector()
        {
            directorTableAdapter.Fill(mediaDataSet.TabDirector);
            return mediaDataSet.TabDirector;
        }
        #endregion

        #region Get View Table MediaAvailable and MeidaBorrow

        public MediaDS.ViewMediaAvailableDataTable ListMediaAvailbable()
        {
            viewMediaAvailavleAdapter.Fill(mediaDataSet.ViewMediaAvailable);
            return mediaDataSet.ViewMediaAvailable;
        }

        public MediaDS.ViewMediaBorrowedDataTable ListMediaBorrowed()
        {
            viewMediaBorrwedAdapter.Fill(mediaDataSet.ViewMediaBorrowed);
            return mediaDataSet.ViewMediaBorrowed;
        }

        #endregion

        #region Get data from Borrow table
        public MediaDS.TabBorrowDataTable ListMediaReturn(int UserID)
        {
            borrowTableAdapter.FillByUserID(mediaDataSet.TabBorrow, UserID);
            //borrowTableAdapter.Fill(mediaDataSet.TabBorrow);
            return mediaDataSet.TabBorrow;
        }
        #endregion

        #region Add, Update and Delete Media
        public int DeleteMediaByID(int ID)
        {
            return mediaTableAdapter.DeleteMediaByID(ID);
        }

        public int UpdateMediaByID(int ID, String Title,int Genre,int Language,int Director,int Publish, decimal Budget)
        {
            return mediaTableAdapter.UpdateMediaByID(Title, Genre, Director, Language, Publish, Budget, ID);
        }

        public int InsertNewMedia(String Title,int Genre, int Director, int Language, int PublishYear, decimal Budget)
        {
            return mediaTableAdapter.InsertNewMedia(Title, Genre, Director, Language, PublishYear, Budget);
        }

        #endregion

        #region Reserve, Borrow and Return Media
        public int InsertNewReserveByID(int UserID, int MediaID, String Date)
        {
            return reservedTableAdapter.InsertNewReserve(UserID, MediaID, Date);
        }

        public int InsertBorrowMedia(int UserID, int MediaID, String DateBorrow, String DateReturn, String MediaTitle)
        {
            return borrowTableAdapter.InsertBorrowMedia(UserID, MediaID, DateBorrow, DateReturn, MediaTitle);
        }

        public int UpdateReturnMeida(String ActualDate, decimal Fee, int UserID, int MediaID)
        {
            return borrowTableAdapter.UpdateReturnMedia(ActualDate, Fee, UserID, MediaID);
        }

        public MediaDS.TabReservedDataTable ListOfReservedMedia()
        {
            reservedTableAdapter.Fill(mediaDataSet.TabReserved);
            return mediaDataSet.TabReserved;
        }

        #endregion

        #region Add, Update and Delete Language
        public int DeleteLanguageByID(int LanguageID)
        {
            return languageTableAdapter.DeleteLanguageByID(LanguageID);
        }

        public int UpdateLanguageByID(int LanguageID, String LanguageName)
        {
            return languageTableAdapter.UpdateLanguageByID(LanguageName, LanguageID);
        }

        public int InsertLanguage(String LanguageName)
        {
            return languageTableAdapter.InsertLanguage(LanguageName);
        }
        #endregion

        #region Add, Update and Delete Genre
        public int DeleteGenreByID(int GenreID)
        {
            return genreTableAdapter.DeleteGenreByID(GenreID);
        }

        public int InsertGenre(String GenreName)
        {
            return genreTableAdapter.InsertGenre(GenreName);
        }

        public int UpdateGenreByID(int GenreID, String GenreName)
        {
            return genreTableAdapter.UpdateGenreByID(GenreName,GenreID);
        }

        #endregion

        #region Add, Update and Delete Director

        public int UpdateDirectorByID(int DirectorID, String DirectorName)
        {
            return directorTableAdapter.UpdateDirectorByID(DirectorName, DirectorID);
        }

        public int DeleteDirectorByID(int DirectorID)
        {
            return directorTableAdapter.DeleteDirectorByID(DirectorID);
        }


        public int InsertDirector(String DirectorName)
        {
            return directorTableAdapter.InsertDirector(DirectorName);
        }

        #endregion
    }
}
