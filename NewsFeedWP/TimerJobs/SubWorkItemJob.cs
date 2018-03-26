using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Models;

namespace SubscriptionJob
{
    [Guid("09B6812C-ADE9-485C-AC12-D3E72B8AA44B")]
    public class SubWorkItemJob:SPWorkItemJobDefinition
    {
        public const string JobName = "SubWorkItemJob";
   
        public static readonly Guid WorkItemTypeId = new Guid("5B1700CF-954C-4EFA-959E-E106A40DDDB7");
        [Persisted] public string siteUrl;

        public override Guid WorkItemType()
        {
            return WorkItemTypeId;
        }

        public SubWorkItemJob():base()
        {
            Title = JobName;
        }

        public SubWorkItemJob(string name, SPWebApplication webApplication):base(name, webApplication)
        {
            Title = name;
        }

        public override int BatchFetchLimit
        {
            get { return 50; }
        }

        public override string DisplayName
        {
            get { return JobName; }
        }

        protected override bool ProcessWorkItem(SPContentDatabase contentDb, SPWorkItemCollection workItems,
            SPWorkItem workItem, SPJobState jobState)
        {
            SubscribersModel model = new SubscribersModel();
            bool output = false;
            if (workItem == null) throw new ArgumentException("workItem is null");
            using (SPSite site = new SPSite(workItem.SiteId))
            {
                using (SPWeb web = site.OpenWeb(workItem.WebId))
                {
                    try
                    {

                        output = model.CheckSubscriptions(workItem, workItems);

                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        workItems.SubCollection(site, web, 0, (uint)workItems.Count).DeleteWorkItem(workItem.Id);
                    }
                }
            }
            return output; 
        }
    }
}
