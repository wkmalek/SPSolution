using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using PocoModels;

namespace Repository.MappingObj
{
    public class CommentsModelMapper: BaseMapper, IMapper<CommentsModel>
    {
        public CommentsModelMapper(string ListName)
        {
            this.ListName = ListName;
        }

        public CommentsModel Translate(SPListItem item)
        {
            return new CommentsModel()
            {
                ID = item.ID,
                ContentType = item.ContentType.Name,
                Author = CheckStringValue(item["Author"]),
                _DCDateCreated = CheckDateValue(item["Created"]),
                _DateModified = CheckDateValue(item["Modified"]),
                Editor = CheckStringValue(item["Editor"]),
                CommentBody = CheckStringValue(item["CommentBody"]),
                NewsLookup = int.Parse(CheckStringValue(item["NewsLookup"]).Split(';').First()),
                Title = CheckStringValue(item["Title"]),
            };
        }

        public List<CommentsModel> Translate(SPListItemCollection items)
        {
            List<CommentsModel> listOfComments = new List<CommentsModel>();
            foreach(SPListItem item in items)
            {
                listOfComments.Add(Translate(item));
            }
            return listOfComments;
        }

        public void Translate(CommentsModel model, SPListItem item)
        {
            item["CommentBody"] = model.CommentBody;
            item["Title"] = model.Title;
            item["NewsLookup"] = model.NewsLookup;
        }
    }
}
