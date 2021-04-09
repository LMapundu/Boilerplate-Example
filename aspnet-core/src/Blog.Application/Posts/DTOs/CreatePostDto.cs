using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Blog.Authorization.Users;
using Blog.Categories.DTOs;
using Blog.Users.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Posts.DTOs
{
    [AutoMapTo(typeof(Post))]
    public class CreatePostDto
    {
        public string Title { get; set; }
        public long AuthorId { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
    }
}
