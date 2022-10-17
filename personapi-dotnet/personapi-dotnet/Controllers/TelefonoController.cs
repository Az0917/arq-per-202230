using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace personapi_dotnet.Controllers
{
    public class TelefonoController : Controller
    {
        private readonly persona_dbContext _context;

        public TelefonoController(persona_dbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var telefonos = _context.Telefonos.Include(b => b.DuenioNavigation);
            return View(await telefonos.ToListAsync());
        }
    }
}
