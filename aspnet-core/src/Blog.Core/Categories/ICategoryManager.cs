using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Categories
{
    public interface ICategoryManager : IDomainService
    {
        Task CreateAsync(Category input);
        Task<Category> GetAsync(Guid id);
        Task DeleteAsync(Guid id);
    }
}
