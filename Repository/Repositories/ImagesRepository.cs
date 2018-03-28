using Microsoft.SharePoint;
using PocoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class ImagesRepository : AbstractRepository<ImagesModel>, IImagesRepository<ImagesModel>
    {
        public List<ImagesModel> GetImagesByPostID(string ID)
        {
            SPQuery query = new SPQuery();
            query.Query = "<Where><Eq><FieldRef Name=\"NewsLookup\" /><Value Type=\"Lookup\">"+ID+"</Value></Eq></Where>";
            SPListItemCollection imagesList = list.GetItems(query);
            return mapper.Translate(imagesList);
        }
    }
}
