using PocoModels;
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
        public UserModel Author { get; set; }
        

        public CommentNewsModel(CommentsModel model, UserModel user)
        {
            //Title
            Title = model.Title;
            Author = user;
            PostID = model.NewsLookup;
            DateCreated = model._DCDateCreated;
            DateModified = model._DateModified;
            CommentBody = model.CommentBody;
        }

       
    }
}
