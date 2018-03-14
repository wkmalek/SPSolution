using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;

namespace NewsFeedWP.Features.NewsFeedDataObjects
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("eba6d887-43b6-4857-8639-3520dde75158")]
    public class NewsFeedDataObjectsEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            //TODO using ? 
            //Creating news list
            SPSite site = SPContext.Current.Site;
            SPWeb web = SPContext.Current.Web;
            SPListTemplateCollection lstTemplate = web.ListTemplates;

            SPListTemplate categoryTemplate = lstTemplate["Categories"];
            if (web.Lists.TryGetList("Categories") != null)
            {
                Guid listToDel = web.Lists["Categories"].ID;
                web.Lists.Delete(listToDel);
            }

            Guid catListID = web.Lists.Add("Categories", "DESC", categoryTemplate);
            SPList catList = web.Lists[catListID];
            
            SPListTemplate template = lstTemplate["ListNews"];
            if (web.Lists.TryGetList("ListNews") != null)
            {
                Guid listToDeleteID = web.Lists["ListNews"].ID;
                web.Lists.Delete(listToDeleteID);
            }
            Guid listID = web.Lists.Add("ListNews", "DescTROLOLOLL", template);
            SPList newsList = web.Lists[listID];

            SPFieldLookup catLookup = (SPFieldLookup)newsList.Fields["Categoryy"];
            catLookup.LookupField = catList.Fields["Category"].InternalName;
            catLookup.Update();

            web.Update();


            //Creating postID lookup column
            //web.Fields.Add("NewsLookup", SPFieldType.Number, true);

            web.Fields.AddLookup("NewsLookup", listID, true);
            SPFieldLookup lkp = (SPFieldLookup)web.Fields["NewsLookup"];
            lkp.LookupField = newsList.Fields["ID"].InternalName;
            lkp.Update();

            //Create ImageLibrary
            SPListTemplate imgTemplate = lstTemplate["ImageLibrary"];
            if (web.Lists.TryGetList("ImageLibrary") != null)
            {
                Guid libToDelete = web.Lists["ImageLibray"].ID;
                web.Lists.Delete(libToDelete);
            }

            Guid libID = web.Lists.Add("ImageLibrary", "desc", imgTemplate);
            SPList imgLib = web.Lists[libID];
            imgLib.Fields.Add(lkp);
            web.Update();

            SPContentTypeId CommentCTID = new SPContentTypeId("0x0100DA033945862B4092808FDBF1A9A77F98");
            SPContentType CommentCT = web.ContentTypes[CommentCTID];
            if (CommentCT == null)
            {
                CommentCT = new SPContentType(CommentCTID,web.ContentTypes,"Comments");
                web.ContentTypes.Add(CommentCT);

                AddFieldLink(lkp, CommentCT);
                SPField user = web.Fields["tp_Author"];
                AddFieldLink(user, CommentCT);
                SPField body = web.Fields["News body"];
                AddFieldLink(body, CommentCT);
                SPField date = web.Fields["tp_Created"];
                AddFieldLink(date, CommentCT);
                CommentCT.Update();
                web.Update();
            }
        }

        static void AddFieldLink(SPField field, SPContentType contentType)
        {
            // Is the FieldLink in the collection?
            SPFieldLink fieldLink = contentType.FieldLinks[field.Id];
            if (fieldLink == null) // No, so add it.
            {
                fieldLink = new SPFieldLink(field);
                contentType.FieldLinks.Add(fieldLink);
            }
        }

        // Uncomment the method below to handle the event raised before a feature is deactivated.

        //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        //{
        //}


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
