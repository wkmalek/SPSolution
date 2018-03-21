using Models.Comments;
using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsView.Presenter
{
    public interface ICommentsView : IMyView
    {
        CommentsNewsViewModel comments {get;set;}
    }
}
