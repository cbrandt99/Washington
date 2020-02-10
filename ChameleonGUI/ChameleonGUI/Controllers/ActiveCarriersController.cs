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
    public class ActiveCarriersController : Controller
    {
        private readonly WashingtonContext _context;

        public ActiveCarriersController(WashingtonContext context)
        {
            _context = context;
        }

        // GET: ActiveCarriers
        public async Task<IActionResult> Index()
        {
            return View(await _context.ActiveCarriers.ToListAsync());
        }

        // GET: ActiveCarriers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activeCarriers = await _context.ActiveCarriers
                .FirstOrDefaultAsync(m => m.DotNumber == id);
            if (activeCarriers == null)
            {
                return NotFound();
            }

            return View(activeCarriers);
        }

        private bool ActiveCarriersExists(int id)
        {
            return _context.ActiveCarriers.Any(e => e.DotNumber == id);
        }
    }
}
