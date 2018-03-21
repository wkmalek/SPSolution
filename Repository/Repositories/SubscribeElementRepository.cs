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
    }
}
