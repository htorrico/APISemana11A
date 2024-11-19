using APISemana11A.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APISemana11A.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly InvoiceContext _context;

        public CoursesController(InvoiceContext context)
        {
            _context = context;
        }


        [HttpGet]
        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        [HttpPost]
        public void Insert(Course product)
        {
            _context.Courses.Add(product);
            _context.SaveChanges();
        }

    }
}
