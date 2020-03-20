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
    public class ChameleonController : Controller
    {
        private readonly WashingtonContext _context;

        public ChameleonController(WashingtonContext context)
        {
            _context = context;
        }

        // GET: Chameleon
        public async Task<IActionResult> Index(string searchString)
        {

            var companies = from c in _context.ChameleonTable
                            select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                companies = companies.Where(c => c.CurrentName.Contains(searchString) || c.FormerName.Contains(searchString));
            }

            return View(companies.ToList());
        }

        // GET: Chameleon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chameleonTable = await _context.ChameleonTable
                .FirstOrDefaultAsync(m => m.ChameleonId == id);
            if (chameleonTable == null)
            {
                return NotFound();
            }

            return View(chameleonTable);
        }

        private bool ChameleonTableExists(int id)
        {
            return _context.ChameleonTable.Any(e => e.ChameleonId == id);
        }
    }
}
