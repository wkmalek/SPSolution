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
        
        public CommentNewsViewModel(CommentNewsModel model)
        {
            //Title
            //PostUrl
            DateCreated = model.DateCreated.ToString();
            DateModified = model.DateModified.ToString();
            PostBody = model.ToString();

        }
    }
}
