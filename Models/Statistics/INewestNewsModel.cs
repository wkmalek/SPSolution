using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Statistics
{
    public interface INewestNewsModel
    {
        NewestNewsModelSingle GetModel();
    }
}
