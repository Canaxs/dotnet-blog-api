using DotnetBlogApi.Dto;
using DotnetBlogApi.Models;
using DotnetBlogApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBlogApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {

        private readonly BlogService _blogService;

        public BlogController(BlogService blogService)
        {
            _blogService = blogService;
        }


        [HttpGet]
        [Route("blogsGet")]
        public IActionResult blogsGet()
        {
            return Ok(_blogService.getBlogs());
        }

        [HttpPost]
        [Route("blogGet")]
        public IActionResult blogGet([FromBody] BlogRequest blogRequest)
        {
            return Ok(_blogService.GetBlog(blogRequest.Id));
        }


        [HttpPost]
        [Route("createBlog")]
        public IActionResult createBlog([FromBody] BlogDTO blogDTO)
        {
            return Ok(_blogService.CreateBlog(blogDTO));
        }

        [HttpDelete]
        [Route("deleteBlog")]
        public IActionResult deleteBlog([FromBody] BlogRequest BlogRequest)
        {
            return Ok(_blogService.deleteBlog(BlogRequest.Id));
        }

    }


}
