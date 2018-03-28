using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PocoModels;

namespace Models.Images
{
    public class SingleImageNewsModel
    {
        public string Title { get; set; }
        public string PostID { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool IsThumbnail { get; set; }
        public string PostUrl { get; set; }

        public SingleImageNewsModel(ImagesModel model)
        {
            Title = model.Author;
            PostID = model.NewsLookup;
            DateCreated = model._DCDateCreated;
            DateModified = model._DateModified;
            IsThumbnail = model.IsThumb;
            PostUrl = model.FileName;
        }
    }
}
