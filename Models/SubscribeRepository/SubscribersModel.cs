using Models.Category;
using Models.Post;
using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SubscribersModel
    {
        private readonly SubscribeRepository subRepo = RepositoryFactory.GetRepositoryInstance<SubscriberModel, SubscribeRepository>();
        private readonly CategoryRepository catRepo = RepositoryFactory.GetRepositoryInstance<CategoryModel, CategoryRepository>();
        private readonly NewsRepository newsRepo = RepositoryFactory.GetRepositoryInstance<NewsModel, NewsRepository>();

        private List<SingleSubscriberModel> GetSubscribers(List<CategoryModel> category)
        {
            throw new NotImplementedException();
        }

        public void CheckSubscriptions()
        {
            List<CategoryModel> catModel = catRepo.GetAllElements();
            List<SingleSubscriberModel> subList = GetSubscribers(catModel);


        }
    }
}
