using BlogApp.BackService.Data;
using BlogApp.BackService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.BackService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        BlogAppDbContext _context;
        public BlogPostController(BlogAppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreatePost([FromBody]BlogPost postDto)
        {
            return Ok();
        }
    }
}
