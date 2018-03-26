using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Comments
{
    public interface ICommentsNewsModel:IModel
    {
        CommentsNewsViewModel GetModel(string ID);
        void AddComment(NewComment comment);
    }
}
