using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace NewsView.NewsViewWebPart
{
    public partial class NewsViewWebPartUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string elementID = Page.Request.QueryString["ID"];
            string listID = Page.Request.QueryString["List"];
            string contentTypeID = Page.Request.QueryString["ContentTypeID"];

            SPListItemCollection list = SPContext.Current.Web.Lists.GetList(new Guid(listID), true).Items;
            SPListItem news = list[Int32.Parse(elementID)-1];

            NewsTitle.Text = (string)news["NewsTitle"];
            PostBody.Text = (string) news["NewsBody"];
            PostCreatedDate.Text = ((DateTime)news["_DCDateCreated"]).ToString();
            AuthorUserName.Text = (string)news["Editor"];
        }
    }
}
