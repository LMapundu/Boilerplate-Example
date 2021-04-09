using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Blog.Authorization.Users;
using Blog.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Posts.DTOs
{
    [AutoMapFrom(typeof(Post))]
    public class PostDto : EntityDto<Guid>
    {
        public string Title { get; set; }

        public User Author { get; set; }
        public long AuthorId { get; set; }

        public Category Category { get; set; }
        public Guid CategoryId { get; set; }

        public string Description { get; set; }
    }
}
