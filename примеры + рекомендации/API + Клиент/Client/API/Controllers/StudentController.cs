using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public async Task<Microsoft.AspNetCore.Mvc.JsonResult> GetStudents()
        {
            ApplicationContext db = new ApplicationContext();
            var students = await db.Students.ToListAsync();
            return new JsonResult(students);
        }

        [HttpPost]
        public async Task<StatusCodeResult> Post(Student student)
        {
            ApplicationContext db = new ApplicationContext();

            try
            {
                await db.Students.AddAsync(student);
                await db.SaveChangesAsync();
                return new StatusCodeResult(200);
            }
            catch
            {
                return new StatusCodeResult(400);
            }
        }
    }
}
