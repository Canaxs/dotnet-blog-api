using DotnetBlogApi.Data;
using DotnetBlogApi.Models;
using System.Reflection.Metadata;

namespace DotnetBlogApi.Repository.Impl
{
    public class BlogRepositoryImpl : BlogRepository
    {

        private readonly DataContext _context;

        public BlogRepositoryImpl(DataContext dataContext)
        {
            _context = dataContext;
        }


        public bool CreateBlog(Blog blog)
        {
            _context.Add(blog);
            return Save();
        }

        public bool DeleteBlog(int id)
        {
            Blog blog = _context.Blogs.Where(c => c.Id == id).FirstOrDefault();

            if (blog != null)
            {
                _context.Remove(blog);
            }

            return Save();
        }

        public Blog getBlog(int id)
        {
            return _context.Blogs.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Blog> GetBlogs()
        {
            return _context.Blogs.ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
