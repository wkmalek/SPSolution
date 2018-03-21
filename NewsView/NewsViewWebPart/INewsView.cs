using Models.Comments;
using Models.Images;
using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsView.NewsViewWebPart
{
    public interface INewsView:IMyView
    {
        string newsTitle { get; set; }
        string postBody { get; set; }
        string dateCreated { get; set; }
        string authorName { get; set; }
    }
}
