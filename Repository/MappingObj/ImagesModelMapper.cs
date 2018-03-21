using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Models.Images;

namespace Repository.MappingObj
{
    public class ImagesModelMapper : BaseMapper, IMapper<ImagesModel>
    {
        public List<ImagesModel> Translate(SPListItemCollection items)
        {
            throw new NotImplementedException();
        }

        public ImagesModel Translate(SPListItem item)
        {
            return new ImagesModel()
            {
                ID = item.ID,
                ContentType = item.ContentType.Name,
                Author = CheckStringValue(item["Author"]),
                _DCDateCreated = CheckDateValue(item["_DCDateCreated"]),
                _DateModified = CheckDateValue(item["_DCDateModified"]),
                Editor = CheckStringValue(item["Editor"]),
                //TODO
            };
        }
    }
}
