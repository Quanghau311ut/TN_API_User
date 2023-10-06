using API_USER_CET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_USER_CET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcountsController : ControllerBase
    {
        private readonly TnDbContext _DbContext;
        public AcountsController(TnDbContext context)
        {
            _DbContext = context;
        }

        //api/Acount/Login
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] Acount acount)
        {
            var apply = await _DbContext.Acounts.FirstOrDefaultAsync(
                        x => x.Username == acount.Username
                       && x.Password == acount.Password);
            if (apply == null)
            {
                return NotFound("Không hợp lệ");
            }
            return Ok("Đăng nhập thành công");
        }

        //api/Acount/Logout
        [HttpPost("LogOut")]
        public async Task<IActionResult> LogOut()
        {
            Response.Cookies.Delete("Authorization");
            return Ok("Đăng xuất thành công");
        }

        //api/Acount/Register
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] Acount acount)
        {
            if (string.IsNullOrEmpty(acount.Username)
                || string.IsNullOrEmpty(acount.Email)
                || string.IsNullOrEmpty(acount.Name)
                || string.IsNullOrEmpty(acount.Address)
                || string.IsNullOrEmpty(acount.Password))
            {
                return BadRequest("Điền đầy đủ thông tin các trường");
            }

            var existingAcount = await _DbContext.Acounts.FirstOrDefaultAsync(x => x.Username == acount.Username && x.Email == acount.Email);
            if (existingAcount != null)
            {
                return Conflict("Thông tin đã tồn tại");
            }
            await _DbContext.Acounts.AddAsync(acount);
            await _DbContext.SaveChangesAsync();
            return Ok("Tạo tài khoản thành công");

        }

        //api/Acount/Update/{id}
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Acount updateAcount)
        {
            var info = await _DbContext.Acounts.FirstOrDefaultAsync(x => x.Id == id);
            if (info == null)
            {
                return NotFound("Tài khoản không tồn tại");
            }

            info.Name = updateAcount.Name;
            info.Address = updateAcount.Address;
            info.Password = updateAcount.Password;
            info.Email = updateAcount.Email;
            info.Dateofbirth = updateAcount.Dateofbirth;

            await _DbContext.SaveChangesAsync();
            return Ok("Cập nhật thông tin thành công");
        }




    }
}
