using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class PairModel
    {
        private int pairID; //attribute
        private string pairName;

        public string PairName
        {
            get { return pairName; }
            set { pairName = value; }
        }

        public int PairID //property to manage attribute
        {
            get { return pairID; }
            set { pairID = value; }
        }

        public static PairModel Parse(MediaDS.TabGenreRow genreRow)
        {
            if (genreRow == null)
                return null;

            PairModel pair = new PairModel();
            pair.PairID = genreRow.GID;
            pair.PairName = genreRow.GenreName;

            return pair;
        }
        public static PairModel Parse(MediaDS.TabLanguageRow langRow)
        {
            if (langRow == null)
                return null;
            PairModel pair = new PairModel();
            pair.PairID = langRow.LID;
            pair.PairName = langRow.LanguageName;

            return pair;          
        }

        public static PairModel Parse(MediaDS.TabDirectorRow directRow)
        {
            if (directRow == null)
                return null;
            PairModel pair = new PairModel();
            pair.PairID = directRow.DID;
            pair.PairName = directRow.DirectorName;

            return pair;
        }
    }
}
