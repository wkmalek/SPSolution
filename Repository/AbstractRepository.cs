using Microsoft.SharePoint;
using Repository.MappingObj;
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
        protected  MapperFactory<T> mapperFactory = new MapperFactory<T>();
        protected IMapper<T> mapper;
        public AbstractRepository()
        {
            mapper = mapperFactory.GetMapper();
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


    }
}
