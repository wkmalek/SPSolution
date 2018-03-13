using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System.Collections.Generic;

namespace NewsFeedWP.NewsFeed
{
    [ToolboxItemAttribute(false)]
    public class NewsFeed : WebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/NewsFeedWP/NewsFeed/NewsFeedUserControl.ascx";
        private const string siteURL = "http://localhost";
        private Repeater repeater;

        protected override void CreateChildControls()
        {
            Control control = Page.LoadControl(_ascxPath);
            Controls.Add(control);
            repeater = control.FindControl("Posts") as Repeater;
            repeater.DataSource = GetPostList("News list");
            repeater.DataBind();
        }

        public List<PostOnListViewModel> GetPostList(string listName)
        {
            List<PostOnListViewModel> output = new List<PostOnListViewModel>();
            try
            {
                using (SPSite siteCollection = new SPSite(siteURL))
                {
                    using (SPWeb web = siteCollection.RootWeb)
                    {
                        SPList list = web.Lists[listName];
                        SPListItemCollection items = list.GetItems();

                        
                        foreach (SPListItem item in items)
                        {
                            string articleTitle = (string) item["News title"];
                            //PostCategory = (string)item["Category"];
                            string postAuthor = (string) item["Created By"];
                            //string descTemp = (string)item[58];
                            string shortDescription;
                            //if (descTemp.Length>128)
                            //     shortDescription = descTemp.Substring(0, 128) + "...";
                            //else
                            //     shortDescription = descTemp;
                            output.Add(new PostOnListViewModel()
                            {
                                ArticleTitle = articleTitle,
                                PostAuthor = postAuthor,
                                //ShortDescription = shortDescription,
                                
                            });
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
            }
           

            return output;
        }
    }
}
