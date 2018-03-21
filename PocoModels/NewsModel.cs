using Models.Comments;
using Models.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Post
{
    public class NewsModel:BaseModel
    {
        public string NewsTitle { get; set; }
        public string NewsBody { get; set; }
        public string Category { get; set; }
        public string FinanceScope { get; set; }
        public string CompanyName { get; set; }
        public string BandName { get; set; }
        public string MusicGenre { get; set; }
        public string ScienceType { get; set; }
        public string ScienceBranch { get; set; }

    }
}
