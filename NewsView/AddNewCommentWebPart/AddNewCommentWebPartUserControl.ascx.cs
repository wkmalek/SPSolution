using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using SharedLib;
using NewsView.Presenter;

namespace NewsView.AddNewCommentWebPart
{
    public partial class AddNewCommentWebPartUserControl : MyUserControl<NewCommentPresenter, INewCommentView>, INewCommentView
    {
        string INewCommentView.Body { get { return Body.Text; } }

        string INewCommentView.Title { get { return Title.Text; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }



        protected void SubmitComment_OnClick(object sender, EventArgs e)
        {
            NewCommentPresenter _presenter = new NewCommentPresenter();
            _presenter._pView = this;
            _presenter.AddComment();
           //SPList comments = SPContext.Current.Web.Lists["Comments"]; 
           // SPListItem newComment = comments.Items.Add();
           // string elementID = Page.Request.QueryString["ID"];
           // newComment["NewsLookup"] = elementID;
           // newComment["Title"] = Title.Text;
           // newComment["Body"] = Body.Text;
           // newComment.Update();
        }
    }
}
