using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace WebParts.CategoryListWebPart
{
    public partial class CategoryListWebPartUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SPList categories = SPContext.Current.Web.Lists["Categories"];
            Repeater.DataSource = categories.Items;
            Repeater.DataBind();
        }
    }
}
