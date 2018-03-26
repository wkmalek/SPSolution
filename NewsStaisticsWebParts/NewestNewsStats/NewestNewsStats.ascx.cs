using Microsoft.SharePoint;
using NewsStaisticsWebParts.Presenter;
using SharedLib;
using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;

namespace NewsStaisticsWebParts.NewestNewsStats
{
    [ToolboxItemAttribute(false)]
    public partial class NewestNewsStats : MySandboxedWebPart<NewestNewsPresenter,INewestNewsView>,INewestNewsView
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]

        public string _listUrl { set { listUrl.Text = value;  } }
        public string _imageUrl { set { background.Attributes.Add("style", "background:url(" + value + ") no-repeat"); } }
        public string _Title { set { Title.Text = value; } }
        public string _Description { set { Description.Text = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            SPListItem item = GetNewestListItem(SPContext.Current.Web.Url, "NewsList", "Created");

            string imageUrl = SPContext.Current.Web.Url + "/NewestNewsStyle/images.jpg";
            //string newsLink = SPContext.Current.Web.Url+(item.Url.Split('_')[0]);
            int itemID = item.ID;
            int lastSlash = item.Url.LastIndexOf('/');

            string _listUrl = item.Url.Substring(0, lastSlash);
            string _newsLink = _listUrl + "News.aspx" + "?ID=" + itemID;
            string _Title = (string)item["Title"];
            string _Descritpion = (string)item["NewsBody"];

            Title.Text = _Title;
            Description.Text = _Title;
            
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        private SPListItem GetNewestListItem(string siteUrl, string listName, string columnName)
        {
            try
            {
                using (SPSite site = new SPSite(siteUrl))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        SPList list = web.Lists[listName];

                        SPQuery objQuery = new SPQuery();
                        objQuery.Query = "<OrderBy><FieldRef Name='" + columnName + "' Ascending='False' /></OrderBy>";
                        objQuery.RowLimit = 1;

                        SPListItemCollection items = list.GetItems(objQuery);

                        if (items.Count == 1)
                        {
                            return items[0];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return null;
        }
    }
}
