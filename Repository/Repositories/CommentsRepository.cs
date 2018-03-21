using Microsoft.SharePoint;
using Models.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class CommentsRepository : AbstractRepository<CommentsModel>, ICommentsRepository<CommentsModel>
    {
        public List<CommentsModel> GetCommentsByNewsID(string ID)
        {
            SPQuery query = new SPQuery();
            query.Query = "<Where><Eq><FieldRef Name=\"NewsLookup\" /><Value Type=\"Lookup\">"+ID+"</Value></Eq></Where>";
            SPListItemCollection commentsList = list.GetItems(query);
            return mapper.Translate(commentsList);
        }
    }
}
