using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace WebParts.NewsTools
{
    public partial class NewsToolsUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void AddContent_OnClick(object sender, EventArgs e)
        {
            SPList news = SPContext.Current.Web.Lists["ListNews"];
            Page.Response.Redirect(SPContext.Current.Web.Url +"/"+news.Forms[2].Url);
            
        }
    }
}
