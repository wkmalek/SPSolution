using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Models;


namespace Repository.MappingObj
{
    public class SubscribeElementModelMapper : BaseMapper, IMapper<SubscribeElementModel>
    {
        public SubscribeElementModelMapper(string ListName)
        {
            this.ListName = ListName;
        }
        public List<SubscribeElementModel> Translate(SPListItemCollection items)
        {
            List<SubscribeElementModel> listOfSubElement = new List<SubscribeElementModel>();
            foreach (SPListItem item in items)
            {
                listOfSubElement.Add(Translate(item));
            }
            return listOfSubElement;
        }

        public SubscribeElementModel Translate(SPListItem item)
        {
            return new SubscribeElementModel()
            {
                ID = item.ID,
                ContentType = item.ContentType.Name,
                Author = CheckStringValue(item["Author"]),
                _DCDateCreated = CheckDateValue(item["_DCDateCreated"]),
                _DateModified = CheckDateValue(item["_DCDateModified"]),
                Editor = CheckStringValue(item["Editor"]),
                UserID = CheckStringValue(item["UserID"]),
                NewsID = CheckStringValue(item["NewsID"]),
                Readed = (bool)item["Readed"],
            };
        }     
    }
}
