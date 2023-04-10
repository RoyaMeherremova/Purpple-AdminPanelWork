using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Package> packages = await _context.Packages.Include(m=>m.Offers).Where(m=>!m.SoftDeleted).Take(3).ToListAsync();

            PricingVM model = new()
            {
                Packages = packages
            };
            return View(model);
        }
    }
}
