using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChameleonGUI.Models;
using X.PagedList;

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
        public ActionResult Index(string currentFilter, string searchString, int? page)
        {

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var carriers = from c in _context.Carriers
                           select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                carriers = carriers.Where(c => c.CarrierName.Contains(searchString));
            }

            int pageSize = 50;
            int pageNumber = (page ?? 1);
            return View(carriers.ToPagedList(pageNumber, pageSize));

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
