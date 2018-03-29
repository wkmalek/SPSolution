using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace NewsFeedWP.List.NewsList.NewDataER
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class NewDataER : SPItemEventReceiver
    {
        /// <summary>
        /// An item was added.
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {
            using (SPWeb web = properties.Web.Site.RootWeb)
            {
                SPList list = web.Lists["SubscriberList"];
                SPList elements = web.Lists["SubscribeElementList"];
                //TODO Rewrite to caml
                for (int i = 0; i < list.ItemCount; i++)
                {
                    SPListItem item = list.Items[i];
                    if (properties.CurrentUserId == (int)item["User"])
                    {
                        SPListItem newSubItem = elements.Items.Add();
                        newSubItem["User"] = properties.CurrentUserId;
                        newSubItem["NewsLookup"] = properties.ListItem["ID"];
                        newSubItem["Reade"] = false;
                        newSubItem.Update();
                    }
                }
            }
            base.ItemAdded(properties);
        }


    }
}