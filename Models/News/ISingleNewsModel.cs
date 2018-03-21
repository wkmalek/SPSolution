using Models.Comments;
using Models.Images;
using Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.News
{
    public interface ISingleNewsModel:IModel
    {
        NewsViewModel GetModel(string ID);
    }
}
