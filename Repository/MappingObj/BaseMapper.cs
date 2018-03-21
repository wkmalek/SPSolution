using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.MappingObj
{
    public abstract class BaseMapper
    {
        public string ListName { get; set; }
        protected virtual string CheckStringValue(object obj)
        {
            if (obj != null)
                return (string)obj;
            return null;
        }
        protected virtual DateTime? CheckDateValue(object obj)
        {
            if (obj != null)
                return (DateTime)obj;
            return null;
        }

        

    }
}
