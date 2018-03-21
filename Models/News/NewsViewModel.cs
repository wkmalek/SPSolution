using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Post
{
    public class NewsViewModel
    {
        public string ContentType { get; set; }
        public string Author { get; set; }
        public string _DCDateCreated { get; set; }
        public string _DateModified { get; set; }
        public string Editor { get; set; }
        public string NewsTitle { get; set; }
        public string NewsBody { get; set; }
        public string FinanceScope { get; set; }
        public string CompanyName { get; set; }
        public string BandName { get; set; }
        public string MusicGenre { get; set; }
        public string ScienceType { get; set; }
        public string ScienceBranch { get; set; }

        public NewsViewModel(NewsModel model)
        {
            ContentType = model.ContentType;
            Author = model.Author;
            DateTime? dateCreated = model._DCDateCreated;
            if (dateCreated != null)
                _DCDateCreated = model._DCDateCreated.ToString();
            else
                _DCDateCreated = "";
            DateTime? dateModified = model._DateModified;
            if (dateModified != null)
                _DateModified = model._DateModified.ToString();
            else
                _DateModified = "";
            Editor = model.Editor;
            NewsTitle = model.NewsTitle;
            NewsBody = model.NewsBody;
            FinanceScope = model.FinanceScope;
            CompanyName = model.CompanyName;
            BandName = model.BandName;
            MusicGenre = model.MusicGenre;
            ScienceBranch = model.ScienceBranch;
            ScienceType = model.ScienceType;
        }

    }
}
