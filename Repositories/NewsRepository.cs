using Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class NewsRepository:AbstractRepository<NewsModel>,INewsRepository<NewsModel>
    {

    }
}
