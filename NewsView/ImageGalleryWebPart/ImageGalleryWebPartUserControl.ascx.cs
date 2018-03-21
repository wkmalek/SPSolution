using System;
using System.Web.Query.Dynamic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace NewsView.ImageGalleryWebPart
{
    public partial class ImageGalleryWebPartUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SPList imageLib = SPContext.Current.Web.Lists["ImageLibrary"];
            SPQuery query = new SPQuery();
            string elementID = Page.Request.QueryString["ID"];
            //field name programmatically
            query.Query = "<Where><Eq><FieldRef Name='NewsLookup'/><Value Type='Lookup'>" + elementID +"</Value></Eq></Where>";
            SPListItemCollection items = imageLib.GetItems(query);

            Repeater.DataSource = items;
            Repeater.DataBind();
        }
    }
}
