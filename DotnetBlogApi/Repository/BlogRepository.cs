using DotnetBlogApi.Models;

namespace DotnetBlogApi.Repository
{
    public interface BlogRepository
    {
        List<Blog> GetBlogs();
        bool CreateBlog(Blog blog);
        bool DeleteBlog(int id);
        Blog getBlog(int id);

    }
}
