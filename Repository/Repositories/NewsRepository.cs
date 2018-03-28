using PocoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace Repository.Repositories
{
    public class NewsRepository : AbstractRepository<NewsModel>, INewsRepository<NewsModel>
    {
        public List<NewsModel> GetNewNews(string userID, DateTime? subscribeDate)
        {
            throw new NotImplementedException();
        }

        public List<NewsModel> GetNewNews(string userID, DateTime? subscribeDate, List<SubscribeElementModel> subElementList)
        {
            SPQuery query = new SPQuery();
            query.Query = "<Query><Where><And><Gt><FieldRef Name=\"Created\" /><Value IncludeTimeValue=\"TRUE\" Type=\"DateTime\">"+subscribeDate+"</Value></Gt><Eq><FieldRef Name=\"Author\" /><Value Type=\"User\">"+userID+"</Value></Eq></And></Where></Query>";
            SPListItemCollection items = list.GetItems(query);
            List<NewsModel> output =  mapper.Translate(items);
            List<NewsModel> filteredOutput = output.Where(x=> !subElementList.Any(y => x.ID != y.NewsID)).ToList();
            return filteredOutput;
        }

        public float GetNewsPerDay()
        {
            int newsCount = list.ItemCount;
            DateTime siteCreated = context.GetSiteCreatedDate();
            TimeSpan span = DateTime.Now.Subtract(siteCreated);
            int siteLifetime = span.Days;
            return newsCount / siteLifetime;

        }

        public int GetNewsCount()
        {
            return list.ItemCount;
        }

        public NewsModel GetNewestNews()
        {
            SPQuery query = new SPQuery();
            query.Query = "";
            SPListItem item = list.GetItems(query)[0];
            return mapper.Translate(item);
        }
    }
}
