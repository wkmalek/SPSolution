using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace NewsView.AddNewCommentWebPart
{
    public partial class AddNewCommentWebPartUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }



        protected void SubmitComment_OnClick(object sender, EventArgs e)
        {
           SPList comments = SPContext.Current.Web.Lists["Comments"]; 
            SPListItem newComment = comments.Items.Add();
            string elementID = Page.Request.QueryString["ID"];
            newComment["NewsLookup"] = elementID;
            newComment["Title"] = Title.Text;
            newComment["Body"] = Body.Text;
            newComment.Update();
        }
    }
}
