using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class MediaModel
    {
        private int mediaID;
        private String mediaTitle;
        private int mediaPublishYear;
        private decimal mediaBudget;
        private String mediaDirector;
        private String mediaGenre;
        private String mediaLanguage;


        public int MediaID
        {
            set { mediaID = value; }
            get { return mediaID; }
        }

        public String MediaTitle
        {
            set { mediaTitle = value; }
            get { return mediaTitle; }
        }

        public String MediaGenre
        {
            get { return mediaGenre; }
            set { mediaGenre = value; }
        }

        public int MediaPublishYear
        {
            get { return mediaPublishYear; }
            set { mediaPublishYear = value; }
        }

        public String MediaDirector
        {
            get { return mediaDirector; }
            set { mediaDirector = value; }
        }
        

        public String MediaLanguage
        {
            get { return mediaLanguage; }
            set { mediaLanguage = value; }
        }
        


        public decimal MediaBudget
        {
            get { return mediaBudget; }
            set { mediaBudget = value; }
        }
        
        /// <summary>
        /// Get data view table from "ViewMedia"
        /// </summary>
        /// <param name="mediaRow"></param>
        /// <returns></returns>
        public static MediaModel Parse(MediaDS.ViewMediaRow mediaRow)
        {
            if (mediaRow == null)
                return null;
            MediaModel media = new MediaModel();
            media.MediaID = mediaRow.MediaID;
            media.MediaTitle = mediaRow.Title;
            media.MediaPublishYear = mediaRow.PublishYear;
            media.MediaBudget = mediaRow.Budget;
            media.MediaDirector = mediaRow.DirectorName;
            media.MediaGenre = mediaRow.GenreName;
            media.MediaLanguage = mediaRow.LanguageName;
            return media;
        }

        /// <summary>
        /// get data view table from "ViewMediaAvailable"
        /// </summary>
        /// <param name="mediaRow"></param>
        /// <returns></returns>
        public static MediaModel Parse(MediaDS.ViewMediaAvailableRow mediaRow)
        {
            if (mediaRow == null)
                return null;
            MediaModel media = new MediaModel();
            media.MediaID = mediaRow.MediaID;
            media.MediaTitle = mediaRow.Title;
            media.MediaPublishYear = mediaRow.PublishYear;
            media.MediaBudget = mediaRow.Budget;
            media.MediaDirector = mediaRow.DirectorName;
            media.MediaGenre = mediaRow.GenreName;
            media.MediaLanguage = mediaRow.LanguageName;
            return media;
        }

        /// <summary>
        /// get data view table from "ViewMediaBorrowed"
        /// </summary>
        /// <param name="mediaRow"></param>
        /// <returns></returns>
        public static MediaModel Parse(MediaDS.ViewMediaBorrowedRow mediaRow)
        {
            if (mediaRow == null)
                return null;
            MediaModel media = new MediaModel();
            media.MediaID = mediaRow.MediaID;
            media.MediaTitle = mediaRow.Title;
            media.MediaPublishYear = mediaRow.PublishYear;
            media.MediaBudget = mediaRow.Budget;
            media.MediaDirector = mediaRow.DirectorName;
            media.MediaGenre = mediaRow.GenreName;
            media.MediaLanguage = mediaRow.LanguageName;
            return media;
        }
    }
}
