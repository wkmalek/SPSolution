using Microsoft.SharePoint;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class SubscribeElementRepository : AbstractRepository<SubscribeElementModel>, ISubscriberElementRepository<SubscribeElementModel>
    {
        public List<SubscribeElementModel> GetSubscriberElementsByCategory(string UserID)
        {
            SPQuery query = new SPQuery();
            query.Query = "<Where><And><Eq><FieldRef Name=\"User\" /><Value Type=\"Integer\">"+UserID+"</Value></Eq></And></Where>";
            SPListItemCollection subscriberElements = list.GetItems(query);
            return mapper.Translate(subscriberElements);
        }

        public List<SubscribeElementModel> GetAllElementsByUserID(string userID)
        {
            SPQuery query = new SPQuery();
            query.Query = "<Where><Eq><FieldRef Name=\"Author\" /><Value Type=\"User\">"+userID+"</Value></Eq></Where>";
            SPListItemCollection subscriberElements = list.GetItems(query);
            return mapper.Translate(subscriberElements);
        }
    }
}
