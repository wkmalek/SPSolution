using Microsoft.SharePoint;
using Repository.MappingObj;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public abstract class AbstractRepository<T> : IRepository<T> where T : class
    {
        internal ContextHelper context;
        protected  SPList list;
        public UserHelper userHelper;
        protected  MapperFactory<T> mapperFactory = new MapperFactory<T>();
        protected IMapper<T> mapper;
        public AbstractRepository()
        {
            mapper = mapperFactory.GetMapper(SPContext.Current.Web.Url);
            userHelper = new UserHelper(SPContext.Current.Web.Url);
            Connect(SPContext.Current.Web.Url, mapper.ListName);
        }

        public virtual void Connect(string url, string listName)
        {
            context = new ContextHelper(url, listName);
            list = context.list;
        }

        public T GetSingleElementByID(int ID)
        {
            SPListItem items = list.GetItemById(ID);
            return mapper.Translate(items);
        }
        
        public List<T> GetAllElements()
        {
            throw new NotImplementedException();
        }

        public void AddElement(T model)
        {
            
            SPListItem newItem = list.Items.Add();
            mapper.Translate(model, newItem);
            newItem.Update();
        }

        public void AddElements(List<T> model)
        {
            foreach(T item in model)
            {
                AddElement(item);
            }
        }

        ~AbstractRepository()
        {
            context.Dispose();
            userHelper.Dispose();
        }
    }
}
