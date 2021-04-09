using Abp.Application.Services;
using Blog.Categories.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Categories
{
    public interface ICategoryAppService : IApplicationService
    {

        Task CreateAsync(CreateCategoryDto input);
        Task<CategoryDTO> GetAsync(Guid id);
        Task DeleteAsync(Guid id);

        Task<List<CategoryDTO>> GetAll();

    }
}
