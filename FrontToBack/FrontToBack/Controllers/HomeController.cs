
using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<SliderInfo> sliderInfos = await _context.SliderInfos.Include(m => m.SliderImage).Where(m => !m.SoftDeleted).ToListAsync();

            IEnumerable<RecentWork> recentWorks = await _context.RecentWorks.Where(m => !m.SoftDeleted).ToListAsync();

            IEnumerable<Category> categories = await _context.Categories.Where(m => !m.SoftDeleted).ToListAsync();

            IEnumerable<Work> works = await _context.Works.Include(m=>m.Images).Include(m => m.Category).Where(m => !m.SoftDeleted).ToListAsync();

            Service service = await _context.Services.FirstOrDefaultAsync();
            HomeVM model = new()
            {
                SliderInfos = sliderInfos,
                Services = service,
                RecentWorks = recentWorks,
                Works= works,
                Categories = categories
            };
            return View(model);
        }



    }
}