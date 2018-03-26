using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Comments
{
    public class CommentNewsViewModel
    {
        public string Title { get; set; }
        public string PostUtl { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public string PostBody { get; set; }
        public string UserName { get; set; }
        public string UserUrl { get; set; }
        private string UserID { get; set; }

        public CommentNewsViewModel(CommentNewsModel model)
        {
            if (model.Title != null)
                Title = model.Title;
            else
                Title = "";
            if (model.PostUrl != null)
                PostUtl = model.PostUrl;
            else
                PostUtl = "";
            DateCreated = model.DateCreated.ToString();
            DateModified = model.DateModified.ToString();
            PostBody = model.CommentBody;
            UserName = model.Author.Name;
            UserID = model.Author.SID;
            UserUrl = model.Author.Url;
        }
    }
}
