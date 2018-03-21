using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repository;
using Repository.Repositories;

namespace Models.Category
{
    public class CategoriesModel : ICategoriesModel
    {
        private readonly CategoryRepository repo = RepositoryFactory.GetRepositoryInstance<CategoryModel, CategoryRepository>();

        public CategoriesViewModel GetModel()
        {
            List<CategoryModel> categories = repo.GetAllElements();
            List<SingleCategoryModel> categoriesModelList = new List<SingleCategoryModel>();

            foreach(CategoryModel item in categories)
            {
                categoriesModelList.Add(new SingleCategoryModel(item));
            }

            return new CategoriesViewModel(categoriesModelList);
        }
    }
}
