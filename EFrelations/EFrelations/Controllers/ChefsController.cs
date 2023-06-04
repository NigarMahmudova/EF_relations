using EFrelations.DAL;
using EFrelations.Entities;
using EFrelations.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFrelations.Controllers
{
    public class ChefsController : Controller
    {
        readonly RelationsDbContext _context;

        public ChefsController(RelationsDbContext context)
        {
            _context = context;  
        }
        public IActionResult Index()
        {
            List<Chef> model = _context.Chefs.Include(x => x.Profession).ToList();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            if (id <= 0) return BadRequest();
            Chef? chef = _context.Chefs.Include(x => x.Profession).Include(y => y.ChefSocialMedia).FirstOrDefault(x => x.Id == id);
            if (chef == null) return NotFound(id);
            return View(chef);
        }
    }
}
