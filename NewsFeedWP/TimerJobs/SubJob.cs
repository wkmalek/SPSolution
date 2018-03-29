using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System.Runtime.InteropServices;
using Models;

namespace SubscriptionJob
{
    [Guid("7913FC64-135C-4066-A711-417335B572DE")]
    internal class SubJob : SPJobDefinition
    {
        public const string JobName = "Subscription Job";
        [Persisted] public string siteUrl;

        public SubJob():base()
        {
            Title = JobName;
        }

        public SubJob(SPWebApplication webApp, string siteUrl):base(JobName, webApp,null,SPJobLockType.None)
        {
            this.siteUrl = siteUrl;
            Title = JobName;
        }

        public override void Execute(Guid targetInstanceId)
        {
            //TODO
            //Get list of subscribers
            //Foreach one get newses after certain date and without existing ones
            //Add to subscribers list
            foreach (SPSite site in WebApplication.Sites)
                using (site)
                {
                    using (SPWeb web = site.RootWeb)
                    {
                        //check if list exist, if yes do smth
                        //also rewrite to caml
                        //also it should probably use some repo or smth
                        SPList subscribersList = web.Lists["SubscriberList"];
                        SPList postList = web.Lists["ListNews"];
                        SPList elementList = web.Lists["SubscribeElementList"];

                        for (int j = 0; j < postList.ItemCount; j++)
                        {
                            SPListItem post = postList.Items[j];
                            string postID = ((int)post["ID"]).ToString();
                            DateTime postDate = (DateTime)post["Created"];
                            for (int i = 0; i < subscribersList.ItemCount; i++)
                            {
                                SPListItem item = subscribersList.Items[i];
                                string userID = ((int)item["User"]).ToString();
                                DateTime subscribeDate = (DateTime)item["SubscribeDate"];

                                if (DateTime.Compare(postDate, subscribeDate) >= 0)
                                {
                                    SPQuery query = new SPQuery();
                                    query.Query = "<Where><Eq><FieldRef Name='NewsID'/><Value Type='Text'>" + postID + "</Value></Eq></Where>";
                                    SPListItemCollection col = elementList.GetItems(query);
                                    if (col.Count <= 0)
                                    {
                                        SPListItem newItem = elementList.Items.Add();
                                        newItem["NewsID"] = postID;
                                        newItem["User"] = userID;
                                        newItem["Readed"] = false;
                                        newItem.Update();
                                    }
                                }
                            }
                        }
                    }
                }


        }
    }
}
