using Models.News;
using Models.Post;
using NewsView.NewsViewWebPart;
using SharedLib.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace NewsView.Presenter
{
    public class NewsViewPresenter : AbstractPresenter<INewsView>
    {
        
        internal readonly ISingleNewsModel _pModel = new SingleNewsModel();

        internal void LoadNews()
        {
            NewsViewModel view = _pModel.GetModel(_pView.newsID);
            _pView.authorName = view.Author;
            _pView.newsTitle = view.NewsTitle;
            _pView.postBody = view.NewsBody;
            _pView.dateCreated = view._DCDateCreated;
        }

        internal void CreateComment()
        {

        }
    }
}
