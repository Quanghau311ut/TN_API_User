using API_USER_CET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_USER_CET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBackController : ControllerBase
    {
        private readonly TnDbContext _DbContext;
        public FeedBackController(TnDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        //api/Comment/post
        [HttpPost("NewComment")]
        public async Task<IActionResult> NewComment([FromBody] Comment comment)
        {
            await _DbContext.Comments.AddAsync(comment);
            await _DbContext.SaveChangesAsync();
            return Ok("Bình luận thành công");
        }

        //api/Comment/get
        [HttpGet("getdata")]
        public async Task<IActionResult> getdata()
        {
            var data = await _DbContext.Comments.ToListAsync();
            return Ok(data);
        }
    }
}
