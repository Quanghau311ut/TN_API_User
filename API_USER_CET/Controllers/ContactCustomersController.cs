using API_USER_CET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_USER_CET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactCustomersController : ControllerBase
    {
        private readonly TnDbContext _DbContext;
        public ContactCustomersController(TnDbContext dbContext)
        {
            _DbContext = dbContext;
        }   
        //api/contact
        [HttpPost("NewContact")]
        public async Task<IActionResult> NewContact([FromBody] Hotline hotline)
        {
            await _DbContext.AddAsync(hotline);
            await _DbContext.SaveChangesAsync();
            return Ok("Chia sẻ thành công");
        }

        

        
        
    }
}
