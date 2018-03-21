using Models.Comments;
using Models.Images;
using Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.News
{
    public class SingleNewsViewModel: ISingleNewsModel
    {
        private readonly SingleNewsModel newsModel;
        
        private NewsViewModel singleNewsViewModel { get; set; }

        public SingleNewsViewModel()
        {
            newsModel = new SingleNewsModel();
        }


        public NewsViewModel GetModel(string ID)
        {
            return newsModel.GetModel(ID);
        }
    }
}
