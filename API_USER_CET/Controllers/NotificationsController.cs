using API_USER_CET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_USER_CET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly TnDbContext _DbContext;
        public NotificationsController(TnDbContext context)
        {
            _DbContext = context;
        }

        //api/Lấy danh sách thông báo
        [HttpGet("list")]
        public async Task<IActionResult> getlist()
        {
            var data = await _DbContext.NewsArticles
                .OrderByDescending(x => x.Dated)
                .ToListAsync();
            return Ok(data);
        }
    }
}
