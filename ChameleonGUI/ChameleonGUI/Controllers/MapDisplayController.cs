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
    public class MapDisplayController : Controller
    {
        private readonly WashingtonContext _context;

        public MapDisplayController(WashingtonContext context)
        {
            _context = context;
        }

        // GET: MapDisplay
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChameleonTable.ToListAsync());
        }
    }
}
