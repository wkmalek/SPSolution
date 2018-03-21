using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedLib
{
    public interface IMyView
    {
        string newsID { get; }
        string listID { get; }
        string contentTypeID { get; }
    }
}
