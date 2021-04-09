using Abp.Domain.Repositories;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Posts
{
    public class PostManager : IPostManager
    {
        private readonly IRepository<Post, Guid> _postRepository;
        public PostManager(IRepository<Post, Guid> postRepository)
        {
            _postRepository = postRepository;
        }

        

        public async Task CreateAsync(Post input)
        {
            await _postRepository.InsertAsync(input);
        }

        public async Task DeleteAsync(Guid id)
        {
            var post = await _postRepository.GetAsync(id);
            if (post == null)
            {
                throw new UserFriendlyException("Post Not Found, Maybe It's Deleted");
            }
            await _postRepository.DeleteAsync(post);
        }

        public async Task<Post> GetAsync(Guid id) 
        {
            var post = await _postRepository.GetAsync(id);
            if (post == null)
            {
                throw new UserFriendlyException("Post Not Found, Maybe It's Deleted");
            }
            return post;
        }
    }
}
