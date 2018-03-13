using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Linq; 
using Microsoft.SharePoint.WebControls;

namespace NewsStaisticsWebParts.NewsStats
{
    [ToolboxItemAttribute(false)]
    public class NewsStats : WebPart
    {
        protected override void CreateChildControls()
        {
        }

        protected override void Render(HtmlTextWriter writer)
        {
            NewsStatsContainer container = GetNewestListItem(SPContext.Current.Web.Url, "ListNews");

            string newsCount = container.NewsCount;
            string newsPerDay = container.NewsPerDay;
            
            writer.Write("News per day: " + newsPerDay + "<br>");
            writer.Write("News count: " + newsCount);

        }

        private NewsStatsContainer GetNewestListItem(string siteUrl, string listName)
        {
            try
            {
                using (SPSite site = new SPSite(siteUrl))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        float newsPerDay;
                        int newsCount;
                        
                        SPList list = web.Lists[listName];
                        newsCount = list.ItemCount;
                        DateTime siteCreated = web.Created;
                        TimeSpan span = DateTime.Now.Subtract(siteCreated);
                        int siteLifetime = span.Days;
                        newsPerDay = newsCount / siteLifetime;

                        SPQuery query = new SPQuery();
                        query.Query = "";
                        query.RowLimit = 1;
                        
                        SPListItemCollection items = list.GetItems(query);

                        return new NewsStatsContainer(newsPerDay, newsCount);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
               
            }

           
        }

        public class NewsStatsContainer
        {
            public string NewsPerDay { get; private set; }
            public string NewsCount { get; private set; }
            

            public NewsStatsContainer(float NewsPerDay, int NewsCount)
            {
                this.NewsPerDay = NewsPerDay.ToString();
                this.NewsCount = NewsCount.ToString();
            }
        }
    }
}
