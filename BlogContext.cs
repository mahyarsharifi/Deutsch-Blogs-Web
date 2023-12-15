using BlogWeb.Mapping;
using BlogWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace BlogWeb
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlogMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
