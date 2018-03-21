using Microsoft.SharePoint;
using Models;
using Models.Category;
using Models.Images;
using Models.Post;
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
            {typeof(NewsModel).ToString(), "ListNews" },
            {typeof(ImagesModel).ToString(), "ImageLibrary" },
            {typeof(CategoryModel).ToString(), "Categories" },
            {typeof(SubscribeElementModel).ToString(), "SubscribeElementList"},
            {typeof(SubscriberModel).ToString(), "SubscriberList" },
        };

        private IMapper<T> mapper { get; set; }

        public  IMapper<T> GetMapper()
        {
            string t = typeof(T).ToString();
            if (t.Split('.').Last() == "NewsModel")
                mapper = (IMapper<T>)(new NewsModelMapper(listMap[t]));
            if (t.Split('.').Last() == "Categories")
                mapper = (IMapper<T>)(new CategoryModelMapper(listMap[t]));
            if (t.Split('.').Last() == "Comments")
                mapper = (IMapper<T>)(new CommentsModelMapper(listMap[t]));
            return mapper;
        }
        
    }
}
