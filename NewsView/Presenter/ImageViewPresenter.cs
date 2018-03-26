using Models.Images;
using NewsView.ImageGalleryWebPart;
using SharedLib.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsView.Presenter
{
    public class ImageViewPresenter : AbstractPresenter<IImageView>
    {
        internal readonly IImagesNewsModel _pModel = new ImagesNewsModel();
        public void LoadImages()
        {
            ImagesNewsViewModel view = _pModel.GetModel(_pView.newsID);
            _pView.Images = view.Images;

        }
    }
}
