using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WashingtonChameleons.Models;

namespace WashingtonChameleons.Controllers
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

        private bool ChameleonTableExists(int id)
        {
            return _context.ChameleonTable.Any(e => e.ChameleonId == id);
        }
    }
}
