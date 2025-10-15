using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
       [HttpPost]
       public void Add(string ime, string prezime)
        {
            var s = new Student
            {
                Id = 1,
                Ime="Suana",
                Prezime="Mešić",
                DateCreated = DateTime.Now
            };
        }
    }
}
