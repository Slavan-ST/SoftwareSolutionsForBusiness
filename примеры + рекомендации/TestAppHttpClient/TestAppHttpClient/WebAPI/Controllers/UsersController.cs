using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    //http://localhost:5170/users
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        //
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            ApplicationContext db = new ApplicationContext();
            var user = await db.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (user == null)
            {
                return NotFound();
            }
            return new JsonResult(user);
        }
    }
}
