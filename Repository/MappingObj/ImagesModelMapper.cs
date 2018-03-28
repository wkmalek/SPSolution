using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using PocoModels;

namespace Repository.MappingObj
{
    public class ImagesModelMapper : BaseMapper, IMapper<ImagesModel>
    {
        public string Url { get; set; }
        public ImagesModelMapper(string ListName, string Url)
        {
            this.ListName = ListName;
            this.Url = Url;
        }

        public List<ImagesModel> Translate(SPListItemCollection items)
        {
            List<ImagesModel> listOfImages = new List<ImagesModel>();
            foreach(SPListItem item in items)
            {
                listOfImages.Add(Translate(item));
            }
            return listOfImages;
        }

        public ImagesModel Translate(SPListItem item)
        {
            return new ImagesModel()
            {
                ID = item.ID,
                ContentType = item.ContentType.Name,
                Author = CheckStringValue(item["Author"]),
                _DCDateCreated = CheckDateValue(item["Created"]),
                _DateModified = CheckDateValue(item["Modified"]),
                Editor = CheckStringValue(item["Editor"]),
                NewsLookup = CheckStringValue(item["NewsLookup"]),
                FileName = Url + @"/Lists/" +ListName +@"/" + CheckStringValue(item["LinkFilename"]),
                IsThumb = (bool)item["IsThumbnail"],
                //TODO
            };
        }

        public void Translate(ImagesModel model, SPListItem item)
        {
            throw new NotImplementedException();
        }
    }
}
