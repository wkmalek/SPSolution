using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using SharedLib;
using NewsView.Presenter;
using SharedLib.Presenter;
using Models.Images;
using Models.Comments;
using System.Collections.Generic;

namespace NewsView.NewsViewWebPart
{
    public partial class NewsViewWebPartUserControl : MyUserControl<NewsViewPresenter, INewsView>, INewsView
    {
        public string newsTitle { get { return NewsTitle.Text; } set { NewsTitle.Text = value; } }
        public string postBody { get { return PostBody.Text; } set { PostBody.Text = value; } }
        public string dateCreated { get { return PostCreatedDate.Text; }set { PostCreatedDate.Text = value; } }
        public string authorName { get { return AuthorUserName.Text; }set { AuthorUserName.Text = value; } }


        protected void Page_Load(object sender, EventArgs e)
        {
            NewsViewPresenter _presenter = new NewsViewPresenter();
            _presenter._pView = this;
            _presenter.LoadNews();
        }
    }
}
