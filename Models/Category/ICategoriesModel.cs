using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Category
{
    public interface ICategoriesModel:IModel
    {
        CategoriesViewModel GetModel();
    }
}
