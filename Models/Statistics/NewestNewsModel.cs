using Models.Images;
using Models.Post;
using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            return new NewestNewsModelSingle() {_Description=news.NewsTitle, _imageUrl=image.Url,_listUrl="",_Title=news.NewsTitle };

        }
    }
}
