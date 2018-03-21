using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Models.Comments;
using Models.Post;

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
                _DCDateCreated = CheckDateValue(item["_DCDateCreated"]),
                _DateModified = CheckDateValue(item["_DCDateModified"]),
                Editor = CheckStringValue(item["Editor"]),
                CommentBody = CheckStringValue(item["NewsBody"]),
                NewsLookup = (int)item["NewsLookup"],
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

    }
}
