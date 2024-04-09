using DotnetBlogApi.Dto;
using DotnetBlogApi.Models;

namespace DotnetBlogApi.Service
{
    public interface BlogService
    {
        List<Blog> getBlogs();
        Blog GetBlog(int id);
        BlogDTO deleteBlog(int id);
        bool CreateBlog(BlogDTO blogDTO);
    }
}
