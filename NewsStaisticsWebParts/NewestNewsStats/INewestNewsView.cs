using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsStaisticsWebParts.NewestNewsStats
{
    public interface INewestNewsView:IMyView
    {
        string _listUrl { set; }
        string _imageUrl { set; }
        string _Title { set; }
        string _Description { set; }
    }
}
