using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace SubscriptionJob.Features.SubscriptionJob
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("cc8ce2c7-d3ad-4d57-b0ac-4c249babed96")]
    public class SubscriptionJobEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPWeb web = properties.Feature.Parent as SPWeb;
            SPWebApplication webApp = web.Site.WebApplication;
            //RegisterJob(webApp);
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

        // Uncomment the method below to handle the event raised before a feature is deactivated.

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            SPWeb web = properties.Feature.Parent as SPWeb;
            SPWebApplication webApp = web.Site.WebApplication;
            DeleteJob(webApp);
        }

        private void DeleteJob(SPWebApplication webApp)
        {
            SubJob subJob = webApp.JobDefinitions.OfType<SubJob> ().FirstOrDefault();
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
