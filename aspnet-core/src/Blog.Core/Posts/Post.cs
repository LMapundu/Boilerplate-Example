using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Blog.Authorization.Users;
using Blog.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Posts
{
    [Table("AppPosts")]
    public class Post : FullAuditedEntity<Guid>
    {
        public string Title { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; }
        public long AuthorId { get; set; }


        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }

        public string Description { get; set; }
    }
}
