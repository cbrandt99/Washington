using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChameleonGUI.Models;
using X.PagedList;
using SmartBreadcrumbs.Attributes;

namespace ChameleonGUI.Controllers
{
    public class CarriersController : Controller
    {
        private readonly WashingtonContext _context;

        public CarriersController(WashingtonContext context)
        {
            _context = context;
        }

        [Breadcrumb("Carriers", FromAction = "Index", FromController = typeof(HomeController))]
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

        [Breadcrumb("Carrier Details", FromAction = "Index", FromController = typeof(HomeController))]
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
