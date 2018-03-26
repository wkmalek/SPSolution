using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Images
{
    public class ImagesNewsViewModel
    {
        public List<ImageNewsViewModel> Images { get; private set; }
        public ImagesNewsViewModel(List<SingleImageNewsModel> images)
        {
            Images = new List<ImageNewsViewModel>();
           foreach (SingleImageNewsModel item in images)
            {
                Images.Add(new ImageNewsViewModel(item));
            }
        }
    }
}
