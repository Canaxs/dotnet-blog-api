using Azure;
using DotnetBlogApi.Models;
using Microsoft.EntityFrameworkCore;


namespace DotnetBlogApi.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }

    }
}
