using API_USER_CET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_USER_CET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly TnDbContext _DbContext;
        public MenusController(TnDbContext context)
        {
            _DbContext = context;
        }
        //api/getall-Menu
        [HttpGet("ListMenu")]
        public async Task<IActionResult> ListMenu()
        {
            var data = await _DbContext.Menus.ToListAsync();
            return Ok(data);
        }
    }
}
