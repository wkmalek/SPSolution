using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public interface ISubscriberElementRepository<T>: IRepository<T> where T : class
    {
        List<T> GetSubscriberElementsByCategory(string UserID);
    }
}
