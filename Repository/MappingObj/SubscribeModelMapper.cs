using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Models;

namespace Repository.MappingObj
{
    public class SubscribeModelMapper : BaseMapper, IMapper<SubscriberModel>
    {
        public SubscribeModelMapper(string ListName)
        {
            this.ListName = ListName;
        }
        public List<SubscriberModel> Translate(SPListItemCollection items)
        {
            List<SubscriberModel> listOfSubModels = new List<SubscriberModel>();
            foreach (SPListItem item in items)
            {
                listOfSubModels.Add(Translate(item));
            }
            return listOfSubModels;
        }

        public SubscriberModel Translate(SPListItem item)
        {
            return new SubscriberModel()
            {
                ID = item.ID,
                ContentType = item.ContentType.Name,
                Author = CheckStringValue(item["Author"]),
                _DCDateCreated = CheckDateValue(item["_DCDateCreated"]),
                _DateModified = CheckDateValue(item["_DCDateModified"]),
                Editor = CheckStringValue(item["Editor"]),
                Category = CheckStringValue(item["CategoryLookup"]),
                AllCategories = (bool)item["AllCategories"],
            };
        }

        public void Translate(SubscriberModel model, SPListItem item)
        {
            throw new NotImplementedException();
        }
    }
}
