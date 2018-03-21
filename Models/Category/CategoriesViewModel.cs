using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Category
{
    public class CategoriesViewModel
    {
        public List<SingleCategoryViewModel> Categories { get; private set; }
        public CategoriesViewModel(List<SingleCategoryModel> models)
        {
            foreach(SingleCategoryModel item in models)
            {
                Categories.Add(new SingleCategoryViewModel(item));
            }
        }
    }
}
