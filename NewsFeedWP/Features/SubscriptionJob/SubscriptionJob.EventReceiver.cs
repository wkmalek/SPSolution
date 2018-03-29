using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using SubscriptionJob;
using System.Linq;

namespace NewsFeedWP.Features.SubscriptionJob
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("f0456ebc-dd5d-4166-8654-c2a0c09ce850")]
    public class SubscriptionJobEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPWeb web = properties.Feature.Parent as SPWeb;
            SPWebApplication webApp = web.Site.WebApplication;
        }

        private void RegisterJob(SPWebApplication webApp)
        {
            DeleteJob(webApp);

            SubJob job = new SubJob(webApp, "http://localhost");

            SPMinuteSchedule scheduleSubJob = new SPMinuteSchedule();

            scheduleSubJob.BeginSecond = 0;
            scheduleSubJob.EndSecond = 15;
            scheduleSubJob.Interval = 1;

            job.Schedule = scheduleSubJob;
            job.Update();
        }

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            SPWeb web = properties.Feature.Parent as SPWeb;
            SPWebApplication webApp = web.Site.WebApplication;
            DeleteJob(webApp);
        }

        private void DeleteJob(SPWebApplication webApp)
        {
            SubJob subJob = webApp.JobDefinitions.OfType<SubJob>().FirstOrDefault();
            if (subJob != null)
                subJob.Delete();
        }

        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
