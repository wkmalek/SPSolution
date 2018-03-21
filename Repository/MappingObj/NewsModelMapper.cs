using Microsoft.SharePoint;
using Models.Post;
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
                _DCDateCreated = CheckDateValue(item["_DCDateCreated"]),
                _DateModified = CheckDateValue(item["_DCDateModified"]),
                Editor = CheckStringValue(item["Editor"]),
                NewsTitle = CheckStringValue(item["NewsTitle"]),
                NewsBody = CheckStringValue(item["NewsBody"]),
                Category = CheckStringValue(item["Category"]),
                FinanceScope = CheckStringValue(item["FinanceScope"]),
                CompanyName = CheckStringValue(item["CompanyName"]),
                BandName = CheckStringValue(item["BandName"]),
                MusicGenre = CheckStringValue(item["MusicGenre"]),
                ScienceType = CheckStringValue(item["ScienceType"]),
                ScienceBranch = CheckStringValue(item["ScienceBranch"]),
            };
        }
        
    }
}
