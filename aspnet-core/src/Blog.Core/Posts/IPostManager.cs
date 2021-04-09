using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Posts
{
    public interface IPostManager: IDomainService
    {

        Task CreateAsync(Post input);
        Task<Post> GetAsync(Guid id);
        Task DeleteAsync(Guid id);
    }
}
