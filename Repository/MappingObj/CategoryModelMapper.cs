using Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace Repository.MappingObj
{
    public class CategoryModelMapper : BaseMapper, IMapper<CategoryModel>
    {
        public CategoryModelMapper(string ListName)
        {
            this.ListName = ListName;
        }

        public List<CategoryModel> Translate(SPListItemCollection items)
        {
            List<CategoryModel> listOfCategories = new List<CategoryModel>();
            foreach(SPListItem item in items)
            {
                listOfCategories.Add(Translate(item));
            }
            return listOfCategories;
        }

        public CategoryModel Translate(SPListItem item)
        {
            return new CategoryModel()
            {
                ID = item.ID,
                ContentType = item.ContentType.Name,
                Author = CheckStringValue(item["Author"]),
                _DCDateCreated = CheckDateValue(item["_DCDateCreated"]),
                _DateModified = CheckDateValue(item["_DCDateModified"]),
                Editor = CheckStringValue(item["Editor"]),
                CategoryName = CheckStringValue(item["CategoryName"]),
            };
        }
    }
}
