using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class RepositoryFactory
    {
        public static TRepository GetRepositoryInstance<T, TRepository>()
        where TRepository : IRepository<T>, new() where T : class
        {
            return new TRepository();
        }
    }
}
