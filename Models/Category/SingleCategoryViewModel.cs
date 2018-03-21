using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Category
{
    public class SingleCategoryViewModel
    {
        public string Title { get; set; }
        public SingleCategoryViewModel(SingleCategoryModel model)
        {
            Title = model.Title;
        }
    }
}
