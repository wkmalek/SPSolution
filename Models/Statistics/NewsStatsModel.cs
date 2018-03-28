using PocoModels;
using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Statistics
{
    public class NewsStatsModel : INewsStatsModel
    {
        private readonly NewsRepository newsRepo = RepositoryFactory.GetRepositoryInstance<NewsModel, NewsRepository>();
        
        public NewsStatsModelSingle GetModel()
        {
            int newsCount = newsRepo.GetNewsCount();
            float newsPerDay = newsRepo.GetNewsPerDay();
            return new NewsStatsModelSingle() { NewsCount = newsCount, NewsPerDay = newsPerDay };
        }
    }
}
