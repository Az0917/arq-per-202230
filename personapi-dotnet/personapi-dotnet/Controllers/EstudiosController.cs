using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Controllers
{
    public class EstudiosController : Controller
    {
        private readonly persona_dbContext _context;
        public EstudiosController(persona_dbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var estudios = _context.Estudios
                .Include(b => b.CcPerNavigation)
                .Include(b=>b.IdProfNavigation);
            return View(await estudios.ToListAsync());
        }
    }
}
