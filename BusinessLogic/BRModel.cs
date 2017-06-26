using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class BRModel
    {
        private int borrowID;
        private int userID;
        private int mediaID;
        private int reservedID;
        private String mediaTitle;
        private String dateBorrow;
        private String dateReturn;
        private String dateActualReturn;
        private decimal fee;

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

        public String DateBorrow
        {
            set { dateBorrow = value; }
            get { return dateBorrow; }
        }


        public String DateReturn
        {
            set { dateReturn = value; }
            get { return dateReturn; }
        }

        public decimal Fee
        {
            get { return fee; }
            set { fee = value; }
        }

        public int BorrowID
        {
            set { borrowID = value; }
            get { return borrowID; }
        }

        public int ReservedID
        {
            set { reservedID = value; }
            get { return reservedID; }
        }

        public int UserID
        {
            set { userID = value; }
            get { return userID; }
        }

        public String DateActualReturn
        {
            set { dateActualReturn = value; }
            get { return dateActualReturn; }
        }


        /// <summary>
        /// Get data from Table "Borrow" and show on Media Braoser
        /// </summary>
        /// <param name="mediaRow"></param>
        /// <returns></returns>
        public static BRModel Parse(MediaDS.TabBorrowRow mediaRow)
        {
            if (mediaRow == null)
                return null;
            BRModel media = new BRModel();
            media.MediaID = mediaRow.MediaID;
            media.BorrowID = mediaRow.BID;
            media.userID = mediaRow.UID;
            media.MediaTitle = mediaRow.MediaTitle;
            media.DateBorrow = mediaRow.BorrowDate.ToString();
            media.DateReturn = mediaRow.ReturnDate.ToString();
            media.DateActualReturn = mediaRow.ActualReturnDate.ToString();
            media.Fee = mediaRow.LateFee;

            return media;
        }

        public static BRModel Parse(MediaDS.TabReservedRow mediaRow)
        {
            if (mediaRow == null)
                return null;
            BRModel media = new BRModel();
            media.MediaID = mediaRow.MediaID;
            media.UserID = mediaRow.UID;
            media.ReservedID = mediaRow.RID;
            return media;
        }
    }
}

