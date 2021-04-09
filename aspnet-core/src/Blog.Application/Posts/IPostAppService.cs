using Abp.Application.Services;
using Blog.Posts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Posts
{
    public interface IPostAppService: IApplicationService
    {

        Task CreateAsync(CreatePostDto input);
        Task<PostDto> GetAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task<List<PostDto>> GetAll();

    }
}
