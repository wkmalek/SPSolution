using System;
using System.Web.Query.Dynamic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using SharedLib;
using NewsView.Presenter;
using Models.Images;
using System.Collections.Generic;

namespace NewsView.ImageGalleryWebPart
{
    public partial class ImageGalleryWebPartUserControl : MyUserControl<ImageViewPresenter, IImageView>,IImageView
    {
        public List<ImageNewsViewModel> Images
        {
            set
            {
                Repeater.DataSource = value;
                Repeater.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ImageViewPresenter _presenter = new ImageViewPresenter();
            _presenter._pView = this;
            _presenter.LoadImages();
            //SPList imageLib = SPContext.Current.Web.Lists["ImageLibrary"];
            //SPQuery query = new SPQuery();
            //string elementID = Page.Request.QueryString["ID"];
            ////field name programmatically
            //query.Query = "<Where><Eq><FieldRef Name='NewsLookup'/><Value Type='Lookup'>" + elementID +"</Value></Eq></Where>";
            //SPListItemCollection items = imageLib.GetItems(query);

            //Repeater.DataSource = items;
            //Repeater.DataBind();
        }
    }
}
