using DotnetBlogApi.Dto;
using DotnetBlogApi.Models;
using DotnetBlogApi.Repository;

namespace DotnetBlogApi.Service.Impl
{
    public class BlogServiceImpl : BlogService
    {

        private readonly BlogRepository _blogRepository;

        public BlogServiceImpl(BlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
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
            }
            catch (Exception)
            {
                throw;
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
