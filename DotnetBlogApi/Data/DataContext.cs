using Azure;
using DotnetBlogApi.Models;
using Microsoft.EntityFrameworkCore;


namespace DotnetBlogApi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(){}
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; } = default!;

        public DbSet<User> Users { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().ToTable("Blog");
            modelBuilder.Entity<User>().ToTable("User");
        }

    }
}
