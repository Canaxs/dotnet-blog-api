using Microsoft.AspNetCore.Mvc;

namespace DotnetBlogApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {


        [HttpGet]
        [Route("get")]
        public string Get()
        {
            return "deneme";
        }
    }


}
