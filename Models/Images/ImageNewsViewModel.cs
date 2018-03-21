using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Images
{
    public class ImageNewsViewModel
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string PostUrl { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public bool IsThumbnail { get; set; }

        public ImageNewsViewModel(SingleImageNewsModel model)
        {
            ImageUrl = model.PostID;
            Title = model.Title;
            PostUrl = model.PostUrl;
            DateCreated = model.DateCreated.ToString();
            DateModified = model.DateModified.ToString();
            IsThumbnail = model.IsThumbnail;
        }
    }
}
