using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.MappingObj
{
    public interface IMapper<T>
    {
        string ListName { get; }
        T Translate(SPListItem item);
        void Translate(T model, SPListItem item);
        List<T> Translate(SPListItemCollection items);
    }
}
