using EFrelations.DAL;
using EFrelations.Entities;
using EFrelations.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFrelations.Controllers
{
    public class TestimonialsController : Controller
    {
        readonly RelationsDbContext _context;

        public TestimonialsController(RelationsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Testimonial> model = _context.Testimonials.Include(x => x.Profession).ToList();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            if (id<=0) return BadRequest();
            Testimonial? testimonial = _context.Testimonials.Include(x => x.Profession).FirstOrDefault(x => x.Id == id);
            if (testimonial == null) return NotFound(id);
            return View(testimonial);
        }
    }
}
