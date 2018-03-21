using Models.Comments;
using SharedLib.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsView.Presenter
{
    public class CommentsViewPresenter : AbstractPresenter<ICommentsView>
    {
        internal readonly ICommentsNewsModel _pModel = new CommentsNewsModel();

        internal void LoadComments()
        {
           _pView.comments = _pModel.GetModel(_pView.newsID);
        }
    }
}
