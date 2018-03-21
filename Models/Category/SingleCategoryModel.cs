using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Category
{
    public class SingleCategoryModel
    {
        public string Title { get; set; }
        public SingleCategoryModel(CategoryModel model)
        {
            Title = model.CategoryName;
        }
    }
}
