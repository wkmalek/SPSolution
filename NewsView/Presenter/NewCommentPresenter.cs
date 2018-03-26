using Models.Comments;
using NewsView.AddNewCommentWebPart;
using SharedLib.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsView.Presenter
{
    public class NewCommentPresenter : AbstractPresenter<INewCommentView>
    {
        internal readonly ICommentsNewsModel _pModel = new CommentsNewsModel();

        internal void AddComment()
        {
            NewComment comment = new NewComment()
            {
                Title = _pView.Title,
                Body = _pView.Body,
                LookupID = _pView.newsID,
            };

            _pModel.AddComment(comment);
        }
    }
}
