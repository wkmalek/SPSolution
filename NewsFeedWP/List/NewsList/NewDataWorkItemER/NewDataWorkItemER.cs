using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using SubscriptionJob;

namespace NewsFeedWP.List.NewsList.NewDataWorkItemER
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class NewDataWorkItemER : SPItemEventReceiver
    {
        /// <summary>
        /// An item was added.
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {
            Guid siteId = properties.SiteId;
            Guid webId = properties.Web.ID;
            Guid listId = properties.ListId;
            int itemId = properties.ListItemId;
            //var context = SPContext.GetContext(properties.Web);
            Guid itemUniqueId = properties.ListItem.UniqueId;
            int currentUserId = properties.CurrentUserId;
            SPSecurity.RunWithElevatedPrivileges(() =>
            {
                using (SPSite site = new SPSite(siteId))
                {
                    site.AddWorkItem(Guid.NewGuid(),
                        DateTime.Now.ToUniversalTime(),
                        SubWorkItemJob.WorkItemTypeId,
                        webId,
                        listId,
                        itemId,
                        true,
                        itemUniqueId,
                        itemUniqueId,
                        currentUserId,
                        null,
                        "Pass this message to the timer job.",
                        Guid.Empty);
                }
            });
        }


    }
}