using Abp.Domain.Repositories;
using Blog.Posts.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Posts
{
    public class PostAppService : BlogAppServiceBase, IPostAppService
    {
        private readonly IPostManager _postManager;
        private readonly IRepository<Post, Guid> _postrepository;

        public PostAppService(IPostManager postManager, IRepository<Post, Guid> postrepository)
        {
            _postManager = postManager;
            _postrepository = postrepository;
        }

        public async Task CreateAsync(CreatePostDto input)
        {
            var post = ObjectMapper.Map<Post>(input);
            await _postManager.CreateAsync(post);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _postManager.DeleteAsync(id);
        }

        public async Task<List<PostDto>> GetAll()
        {
            var post = await _postrepository.GetAll().ToListAsync();

            return new List<PostDto>(ObjectMapper.Map<List<PostDto>>(post));
        }

        public async Task<PostDto> GetAsync(Guid id)
        {
            var post = await _postManager.GetAsync(id);
            return ObjectMapper.Map<PostDto>(post);
        }
    }
}
