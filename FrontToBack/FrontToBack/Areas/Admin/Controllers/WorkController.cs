using FrontToBack.Data;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;

        public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            IEnumerable<WorkImage> works = await _context.WorkImages.Where(m => !m.SoftDeleted).ToListAsync();
            return View(works);
        }



         public async Task<IActionResult> Detail(int? id)
        {
            
            if (id == null) return BadRequest();
            WorkImage? work = await _context.WorkImages.Include(m => m.Work).FirstOrDefaultAsync(m => m.Id == id);
        
            if (work == null) return NotFound();
            return View(work);
        }


        //[HttpGet]-datani goturende 
        [HttpGet]

        public IActionResult Create()    
        {

            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return BadRequest();
            WorkImage? work = await _context.WorkImages.Include(m=>m.Work).FirstOrDefaultAsync(m => m.Id == id);

            if (work == null) return NotFound();
            return View(work);

        }
    }
}
