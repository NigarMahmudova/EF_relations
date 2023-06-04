using EFrelations.DAL;
using EFrelations.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFrelations.Controllers
{
    public class HomeController : Controller
    {
        readonly RelationsDbContext _context;

        public HomeController(RelationsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            RelationsVM model = new RelationsVM()
            {
                Chefs = _context.Chefs.Include(x => x.Profession).Include(y => y.ChefSocialMedia).ToList(),
                Testimonials = _context.Testimonials.Include(x => x.Profession).ToList(),
                Professions = _context.Professions.ToList(),
                ChefSocialMedias = _context.ChefSocialMedias.ToList()
            };
            return View(model);
        }
    }
}
