using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Blog.Authorization.Roles;
using Blog.Authorization.Users;
using Blog.MultiTenancy;
using Blog.Posts;
using Blog.Categories;

namespace Blog.EntityFrameworkCore
{
    public class BlogDbContext : AbpZeroDbContext<Tenant, Role, User, BlogDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }
    }
}
