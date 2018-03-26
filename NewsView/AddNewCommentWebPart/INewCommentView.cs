using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsView.AddNewCommentWebPart
{
    public interface INewCommentView:IMyView
    {
        string Title { get;}
        string Body { get; }
    }
}
