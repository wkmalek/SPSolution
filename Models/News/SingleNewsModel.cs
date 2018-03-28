using Models.Comments;
using Models.Images;
using Models.Post;
using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PocoModels;

namespace Models.News
{
    public class SingleNewsModel:ISingleNewsModel
    {
        private readonly NewsRepository newsRepo = RepositoryFactory.GetRepositoryInstance<NewsModel, NewsRepository>();
        public NewsViewModel GetModel(string ID)
        {
            NewsModel newsModel = newsRepo.GetSingleElementByID(int.Parse(ID));
            NewsViewModel newsViewModel = new NewsViewModel(newsModel);
            return newsViewModel;
        }
    }
}
