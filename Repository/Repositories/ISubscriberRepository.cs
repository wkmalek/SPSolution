using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public interface ISubscriberRepository<T>: IRepository<T> where T : class
    {
        List<T> GetSubscriberByUserID(string UserID, string Category, bool AllCategories);
    }
}
