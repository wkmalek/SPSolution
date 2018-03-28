using Models.Images;
using Models.Post;
using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PocoModels;

namespace Models.Statistics
{
    public class NewestNewsModel : INewestNewsModel
    {
        private readonly NewsRepository newsRepo = RepositoryFactory.GetRepositoryInstance<NewsModel, NewsRepository>();
        private readonly ImagesRepository imageRepo = RepositoryFactory.GetRepositoryInstance<ImagesModel, ImagesRepository>();
        public NewestNewsModelSingle GetModel()
        {
            NewsModel news = newsRepo.GetNewestNews();
            List<ImagesModel> imageList = imageRepo.GetImagesByPostID(news.ID.ToString());
            ImagesModel image = imageList.Where(x => x.IsThumb == true).SingleOrDefault();
            string imgUrl;
            if (image != null)
                imgUrl = image.FileName;
            else
                imgUrl = "";
            return new NewestNewsModelSingle() {_Description=news.NewsTitle, _imageUrl=imgUrl, _listUrl="",_Title=news.NewsTitle };
        }
    }
}
