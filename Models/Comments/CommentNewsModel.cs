using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Comments
{
    public class CommentNewsModel
    {
        public string Title { get; set; }
        public int PostID { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string PostUrl { get; set; }
        public string CommentBody { get; set; }


        public CommentNewsModel(CommentsModel model)
        {
            //Title
            PostID = model.NewsLookup;
            DateCreated = model._DCDateCreated;
            DateModified = model._DateModified;
            //PostUrl = 
            CommentBody = model.CommentBody;

        }
    }
}
