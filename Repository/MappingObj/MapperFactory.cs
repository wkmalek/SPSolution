using Microsoft.SharePoint;
using PocoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.MappingObj
{
    public class MapperFactory<T> where T : class
    {
        private readonly Dictionary<string, string> listMap = new Dictionary<string, string>
        {
            {typeof(NewsModel).ToString(), "NewsList" },
            {typeof(ImagesModel).ToString(), "NewsImages" },
            {typeof(CategoryModel).ToString(), "Categories" },
            {typeof(CommentsModel).ToString(), "Comments" },
            {typeof(SubscribeElementModel).ToString(), "SubscribeElementList"},
            {typeof(SubscriberModel).ToString(), "SubscriberList" },
        };

        private IMapper<T> mapper { get; set; }

        public  IMapper<T> GetMapper(string Url)
        {
            string t = typeof(T).ToString();
            if (t.Split('.').Last() == "NewsModel")
                mapper = (IMapper<T>)(new NewsModelMapper(listMap[t]));
            if (t.Split('.').Last() == "Categories")
                mapper = (IMapper<T>)(new CategoryModelMapper(listMap[t]));
            if (t.Split('.').Last() == "CommentsModel")
                mapper = (IMapper<T>)(new CommentsModelMapper(listMap[t]));
            if (t.Split('.').Last() == "ImagesModel")
                mapper = (IMapper<T>)(new ImagesModelMapper(listMap[t], Url));
            if (t.Split('.').Last() == "SubscribeElementList")
                mapper = (IMapper<T>)(new SubscribeElementModelMapper(listMap[t]));
            if (t.Split('.').Last() == "SubscriberList")
                mapper = (IMapper<T>)(new SubscribeModelMapper(listMap[t]));
            return mapper;
        }
        
    }
}
