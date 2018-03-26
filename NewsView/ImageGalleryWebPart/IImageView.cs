using Models.Images;
using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsView.ImageGalleryWebPart
{
    public interface IImageView : IMyView
    {
        List<ImageNewsViewModel> Images { set; }
    }
}
