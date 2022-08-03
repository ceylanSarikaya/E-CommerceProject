using Business.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryService _categoryService;

        public CategoryManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public void Add(Category category)
        {
           _categoryService.Add(category);
        }

        public void Delete(Category category)
        {
           _categoryService.Delete(category);
        }

        public List<Category> GetCategories()
        {
            return _categoryService.GetCategories();
        }

        public Category GetCategory(int id)
        {
          return  _categoryService.GetCategory(id);
        }

        public void Update(Category category)
        {
           _categoryService.Update(category);
        }
    }
}
