using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChameleonGUI.Models;

namespace ChameleonGUI.Controllers
{
    public class CarriersController : Controller
    {
        private readonly WashingtonContext _context;

        public CarriersController(WashingtonContext context)
        {
            _context = context;
        }

        // GET: Carriers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carriers.ToListAsync());
        }

        // GET: Carriers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carriers = await _context.Carriers
                .FirstOrDefaultAsync(m => m.Number == id);
            if (carriers == null)
            {
                return NotFound();
            }

            return View(carriers);
        }

        private bool CarriersExists(int id)
        {
            return _context.Carriers.Any(e => e.Number == id);
        }
    }
}
