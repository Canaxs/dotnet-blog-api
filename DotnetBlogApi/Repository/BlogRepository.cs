using DotnetBlogApi.Models;

namespace DotnetBlogApi.Repository
{
    public interface BlogRepository
    {
        ICollection<Blog> GetBlogs();
        bool CreateBlog(Blog blog);
        bool DeleteBlog(int id);
        Blog getBlog(int id);

    }
}
