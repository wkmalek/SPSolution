using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public interface IImagesRepository<T>:IRepository<T> where T:class
    {
    }
}
