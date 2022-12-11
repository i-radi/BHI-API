using BHI_API.Data;
using BHI_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BHI_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BHIController : ControllerBase
    {
        private readonly BHIContext _context;

        public BHIController(BHIContext context)
        {
            _context = context;
        }


        [HttpGet(Name = "GetStudents")]
        public IEnumerable<Student> Get()
        {
            return _context.Students;
        }

        [HttpGet("GetStudent")]
        public Student Get(int id)
        {
            return _context.Students.Find(id);
        }

    }
}