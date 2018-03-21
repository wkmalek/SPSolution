using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Comments
{
    public class CommentsNewsViewModel
    {
        public List<CommentNewsViewModel> Comments { get; private set; }
        public CommentsNewsViewModel(List<CommentNewsModel> models)
        {
            foreach(CommentNewsModel item in models)
            {
                Comments.Add(new CommentNewsViewModel(item));
            }
        }
    }
}
