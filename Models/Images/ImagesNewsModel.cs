using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Images
{
    public class ImagesNewsModel : IImagesNewsModel
    {
        private readonly ImagesRepository repo = RepositoryFactory.GetRepositoryInstance<ImagesModel, ImagesRepository>();
        public ImagesNewsViewModel GetModel(string ID)
        {
            List<ImagesModel> images = repo.GetImagesByPostID(ID);
            List<SingleImageNewsModel> imagesModelList = new List<SingleImageNewsModel>();

            foreach(ImagesModel item in images)
            {
                imagesModelList.Add(new SingleImageNewsModel(item));
            }
            return new ImagesNewsViewModel(imagesModelList);
        }
    }
}
