using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace SubscriptionJob.Features.SubscriptionWorkItemJob
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("821bced1-f726-4ba4-a935-09474796ee33")]
    public class SubscriptionWorkItemJobEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            //System.Diagnostics.Debugger.Launch();
            SPWeb web = properties.Feature.Parent as SPWeb;
            SPWebApplication webApp = web.Site.WebApplication;
            RegisterJob(webApp);
        }

        private void RegisterJob(SPWebApplication webApp)
        {
            DeleteJob(webApp);

            SubWorkItemJob workItemJob = new SubWorkItemJob("Mighty Job", webApp);

            SPMinuteSchedule scheduleWorkItemJob = new SPMinuteSchedule();

            scheduleWorkItemJob.BeginSecond = 0;
            scheduleWorkItemJob.EndSecond = 15;
            scheduleWorkItemJob.Interval = 1;

            workItemJob.Schedule = scheduleWorkItemJob;
            workItemJob.Update();
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
            SubWorkItemJob subWorkItemJob = webApp.JobDefinitions.OfType<SubWorkItemJob>().FirstOrDefault();
            if (subWorkItemJob != null)
                subWorkItemJob.Delete();
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
