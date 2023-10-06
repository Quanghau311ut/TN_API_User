using API_USER_CET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_USER_CET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly TnDbContext _DbContext;
        public HomeController(TnDbContext context)
        {
            _DbContext = context;
        }
        //api/getdanhmuc
        [HttpGet("Get-danh-muc")]
        public async Task<IActionResult> Getdanhmuc()
        {
            var data = await _DbContext.Categories.ToListAsync();
            return Ok(data);
        }

        //api/slider
        [HttpGet("get-slider")]
        public async Task<IActionResult> getslider()
        {
            var data= await _DbContext.Sliders.ToListAsync();
            return Ok(data);
        }

        //api/Brand
        [HttpGet("get-brand")]
        public async Task<IActionResult> getbrand()
        {
            var data = await _DbContext.Brands.ToListAsync();
            return Ok(data);
        }
    }
}
