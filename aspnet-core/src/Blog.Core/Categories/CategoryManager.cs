using Abp.Domain.Repositories;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Categories
{
    public class CategoryManager : ICategoryManager
    {
        private readonly IRepository<Category, Guid> _categoryRepository;

        public CategoryManager(IRepository<Category, Guid> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public async Task CreateAsync(Category input)
        {
            await _categoryRepository.InsertAsync(input);
        }

        public async Task DeleteAsync(Guid id)
        {
            var category = await _categoryRepository.GetAsync(id);
            if (category == null)
            {
                throw new UserFriendlyException("Category Not Found, Maybe It's Deleted");
            }
            await _categoryRepository.DeleteAsync(category);
        }

        public async Task<Category> GetAsync(Guid id)
        {
            var category = await _categoryRepository.GetAsync(id);
            if (category == null)
            {
                throw new UserFriendlyException("Category Not Found, Maybe It's Deleted");
            }
            return category;
        }
    }
}
