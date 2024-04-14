using DotnetBlogApi.Dto;
using DotnetBlogApi.Models;
using DotnetBlogApi.Repository;
using Microsoft.Extensions.Logging;

namespace DotnetBlogApi.Service.Impl
{
    public class BlogServiceImpl : BlogService
    {

        private readonly BlogRepository _blogRepository;

        private readonly ILogger _logger;

        public BlogServiceImpl(BlogRepository blogRepository, ILogger<BlogServiceImpl> logger)
        {
            _blogRepository = blogRepository;
            _logger = logger;
        }

        public bool CreateBlog(BlogDTO blogDTO)
        {
            Blog blog = new Blog();
            blog.Username = blogDTO.Starpoint;
            blog.Title = blogDTO.Title;
            blog.Description = blogDTO.Description;
            blog.Starpoint = blogDTO.Starpoint;
            return _blogRepository.CreateBlog(blog);
        }

        public BlogDTO deleteBlog(int id)
        {
            BlogDTO blogDTO = new BlogDTO();
            try{

                Blog blog = _blogRepository.getBlog(id);
                blogDTO.Username = blog.Username;
                blogDTO.Title = blog.Title;
                blogDTO.Description = blog.Description;
                blogDTO.Starpoint = blog.Starpoint;
                _blogRepository.DeleteBlog(id);
                _logger.LogInformation("DeleteBlog: "+blogDTO.Username);
            }
            catch (Exception e)
            {
                _logger.LogInformation("Delete Exception"+e.Message);
            }
            return blogDTO;
        }

        public Blog GetBlog(int id)
        {
            return _blogRepository.getBlog(id);
        }

        public List<Blog> getBlogs()
        {
            return _blogRepository.GetBlogs();
        }
    }
}
