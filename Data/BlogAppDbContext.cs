using BlogApp.BackService.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.BackService.Data
{
    public class BlogAppDbContext : DbContext
    {
        public BlogAppDbContext(DbContextOptions<BlogAppDbContext> options) :base(options)
        {            
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<PostComment> PostComments { get; set; }

    }
}
