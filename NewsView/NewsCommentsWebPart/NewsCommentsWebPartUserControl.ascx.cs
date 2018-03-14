using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace NewsView.NewsCommentsWebPart.cs
{
    public partial class NewsCommentsWebPartUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SPList comments = SPContext.Current.Web.Lists["Comments"];
            SPQuery query = new SPQuery();
            string postID = Page.Request.QueryString["ID"];
            query.Query = "<Where><Eq><FieldRef Name=\"NewsLookup\" /><Value Type=\"Lookup\">"+ postID +"</Value></Eq></Where>";
            SPListItemCollection items = comments.GetItems(query);
            Repeater.DataSource = items;
            Repeater.DataBind();
        }
    }
}
