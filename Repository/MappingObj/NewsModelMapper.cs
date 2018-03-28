using Microsoft.SharePoint;
using PocoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.MappingObj
{
    public class NewsModelMapper: BaseMapper, IMapper<NewsModel>
    {
        //public string ListName { get; private set; }
        public NewsModelMapper(string ListName)
        {
            this.ListName = ListName;
        }

        public List<NewsModel> Translate(SPListItemCollection items)
        {
            throw new NotImplementedException();
        }

        public NewsModel Translate (SPListItem item)
        {
            return new NewsModel()
            {
                ID = item.ID,
                ContentType = item.ContentType.Name,
                Author = CheckStringValue(item["Author"]),
                _DCDateCreated = CheckDateValue(item["Created"]),
                _DateModified = CheckDateValue(item["Modified"]),
                Editor = CheckStringValue(item["Editor"]),
                NewsTitle = CheckStringValue(item["Title"]),
                NewsBody = CheckStringValue(item["NewsBody"]),
                Category = CheckStringValue(item["CategoryLookup"]),
                FinanceScope = CheckStringValue(item["FinanceScope"]),
                CompanyName = CheckStringValue(item["CompanyName"]),
                BandName = CheckStringValue(item["BandName"]),
                MusicGenre = CheckStringValue(item["MusicGenre"]),
                ScienceType = CheckStringValue(item["ScienceType"]),
                ScienceBranch = CheckStringValue(item["ScienceBrach"]),
            };
        }

        public void Translate(NewsModel model, SPListItem item)
        {
            throw new NotImplementedException();
        }
    }
}
