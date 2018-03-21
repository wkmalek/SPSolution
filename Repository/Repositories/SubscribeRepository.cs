using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Microsoft.SharePoint;

namespace Repository.Repositories
{
    public class SubscribeRepository : AbstractRepository<SubscriberModel>, ISubscriberRepository<SubscriberModel>
    {
        public List<SubscriberModel> GetSubscriberByUserID(string UserID, string Category, bool AllCategories)
        {
            SPQuery query = new SPQuery();
            if (!AllCategories)
                query.Query = "<Where><And><Eq><FieldRef Name=\"User\" /><Value Type=\"Integer\">"+UserID+"</Value></Eq><Eq><FieldRef Name=\"Category\" /><Value Type=\"Lookup\">"+Category+"</Value></Eq></And></Where>";
            else
                query.Query = "<Where><Eq><FieldRef Name=\"User\" /><Value Type=\"Integer\">" + UserID + "</Value></Eq></Where>";
            SPListItemCollection subscriberModel = list.GetItems(query);
            return mapper.Translate(subscriberModel);
        }
    }
}
