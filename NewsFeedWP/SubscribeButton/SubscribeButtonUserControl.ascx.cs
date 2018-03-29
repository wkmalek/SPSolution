using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace SubscriptionJob.SubscribeButton
{
    public partial class SubscribeButtonUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SPList subList = SPContext.Current.Web.Lists["SubscriberList"];
            int userID = SPContext.Current.Web.CurrentUser.ID;
            SPQuery query = new SPQuery();
            query.Query = "<Query><Where><Eq><FieldRef Name=\"User\" /><Value Type=\"Integer\">" + userID + "</Value></Eq></Where></Query>";
            SPListItemCollection items = subList.GetItems(query);

            if (items.Count == 1)
            {
                Sub.Text = "Unsub";
            }

            else if (items.Count == 0)
            {
                Sub.Text = "Sub";
            }
        }

        protected void Sub_OnClick(object sender, EventArgs e)
        {
            SPList subList = SPContext.Current.Web.Lists["SubscriberList"];
            int userID = SPContext.Current.Web.CurrentUser.ID;
            SPQuery query = new SPQuery();
            query.Query = "<Query><Where><Eq><FieldRef Name=\"User\" /><Value Type=\"Integer\">" + userID + "</Value></Eq></Where></Query>";
            SPListItemCollection items = subList.GetItems(query);

            if (items.Count == 1)
            {
                Sub.Text = "Unsub";
                subList.Items.DeleteItemById(items[0].ID);
            }

            else if (items.Count == 0)
            {
                Sub.Text = "Sub";
                SPListItem newSub = subList.Items.Add();
                newSub["Title"] = "Tlt";
                newSub["User"] = userID;
                newSub["SubscribeDate"] = DateTime.UtcNow;
                newSub.Update();
            }

        }
    }
}
