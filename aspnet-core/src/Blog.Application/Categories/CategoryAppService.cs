using Abp.Domain.Repositories;
using Blog.Categories.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Categories
{
    public class CategoryAppService : BlogAppServiceBase, ICategoryAppService
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IRepository<Category, Guid> _categoryRepository;

        public CategoryAppService(ICategoryManager categoryManager,
            IRepository<Category, Guid> categoryRepository)
        {
            _categoryManager = categoryManager;
            _categoryRepository = categoryRepository;
        }

        public async Task CreateAsync(CreateCategoryDto input)
        {
            var category = ObjectMapper.Map<Category>(input);
            await _categoryManager.CreateAsync(category);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _categoryManager.DeleteAsync(id);

        }

        public async Task<List<CategoryDTO>> GetAll()
        {
            var categories = await _categoryRepository.GetAll().ToListAsync();

            return new List<CategoryDTO>(ObjectMapper.Map<List<CategoryDTO>>(categories));
        }

        public async Task<CategoryDTO> GetAsync(Guid id)
        {
            var category = await _categoryManager.GetAsync(id);
            return ObjectMapper.Map<CategoryDTO>(category);
        }
    }
}
