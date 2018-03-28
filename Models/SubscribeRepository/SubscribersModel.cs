using Microsoft.SharePoint;
using Models.Category;
using Models.Post;
using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PocoModels;

namespace Models
{
    public class SubscribersModel
    {
        private readonly SubscribeRepository subRepo = RepositoryFactory.GetRepositoryInstance<SubscriberModel, SubscribeRepository>();
        private readonly SubscribeElementRepository subElementRepo = RepositoryFactory.GetRepositoryInstance<SubscribeElementModel, SubscribeElementRepository>();
        private readonly CategoryRepository catRepo = RepositoryFactory.GetRepositoryInstance<CategoryModel, CategoryRepository>();
        private readonly NewsRepository newsRepo = RepositoryFactory.GetRepositoryInstance<NewsModel, NewsRepository>();

        public bool CheckSubscriptions()
        {
            List<CategoryModel> catModel = catRepo.GetAllElements();
            List<SubscriberModel> subModelList = subRepo.GetSubscriberByCategoryID(catModel);
            List<SingleSubscriberModel> subList = new List<SingleSubscriberModel>();
            foreach(SubscriberModel item in subModelList)
            {
                subList.Add(new SingleSubscriberModel(item));
            }

            foreach(SingleSubscriberModel submodel in subList)
            {
                List<SubscribeElementModel> subElementList = subElementRepo.GetAllElementsByUserID(submodel.UserID);
                List<NewsModel> newsModelList = newsRepo.GetNewNews(submodel.UserID, submodel.SubscribeDate, subElementList);
                List<SubscribeElementModel> itemsToAdd = new List<SubscribeElementModel>();
                foreach(NewsModel news in newsModelList)
                {
                    itemsToAdd.Add(new SubscribeElementModel()
                    {
                        UserID = news.Author,
                        NewsID = news.ID,
                        Readed = false,
                    });
                }
                subElementRepo.AddElements(itemsToAdd);
            }
            return true;
        }

        public bool CheckSubscriptions(SPWorkItem workItem, SPWorkItemCollection workItems)
        {
            NewsModel listItem = newsRepo.GetSingleElementByID(workItem.ItemId);
            List<CategoryModel> catModel = catRepo.GetAllElements();
            List<SubscriberModel> subModelList = subRepo.GetSubscriberByCategoryID(catModel);
            List<SingleSubscriberModel> subList = new List<SingleSubscriberModel>();
            foreach (SubscriberModel item in subModelList)
            {
                subList.Add(new SingleSubscriberModel(item));
            }

            foreach(SingleSubscriberModel submodel in subList)
            {
                List<SubscribeElementModel> subElementList = subElementRepo.GetAllElementsByUserID(submodel.UserID);
                SubscribeElementModel itemToAdd = new SubscribeElementModel()
                {
                    UserID = workItem.UserId.ToString(),
                    NewsID = listItem.ID,
                    Readed = false,
                };
                subElementRepo.AddElement(itemToAdd);
            }
            return true;

        }
    }
}
