using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FrontToBack.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            //Viewdan id gelir-tag-helpers  vasitesi ile
            //ViewBag.id = id;

            AboutUs aboutUs = await _context.AboutUs.FirstOrDefaultAsync();

           
           IEnumerable<TeamMember> teamMembers =await _context.TeamMembers.Include(m=>m.Team).Where(m => !m.SoftDeleted).ToListAsync();

            AboutVM model = new()
            {
                AboutUs = aboutUs,
                TeamMembers = teamMembers
            };
            return View(model);
        }
    }
}
