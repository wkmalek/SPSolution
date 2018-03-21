using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using SharedLib;
using NewsView.Presenter;
using Models.Comments;
using System.Collections.Generic;

namespace NewsView.NewsCommentsWebPart.cs
{
    public partial class NewsCommentsWebPartUserControl : MyUserControl<CommentsViewPresenter, ICommentsView>, ICommentsView
    {
        //
        public CommentsNewsViewModel comments
        {
            get { return comments; }
            set
            {
                comments = value;
                Repeater.DataSource = comments;
                Repeater.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CommentsViewPresenter _presenter = new CommentsViewPresenter();
            //_presenter._pView = this;
            //_presenter.LoadComments();
        }
    }
}
