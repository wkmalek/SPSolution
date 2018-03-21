using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public interface IRepository<T>
    {
        T GetSingleElementByID(int ID);
        List<T> GetAllElements();
    }
}
