using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsStaisticsWebParts.NewsStatsWP
{
    public interface INewsStatsWPView: IMyView
    {
        string NewsCount { set; }
        string NewsPerDay { set; }
    }
}
