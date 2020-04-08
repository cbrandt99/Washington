using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WashingtonChameleons.Models;
using PagedList;
using SmartBreadcrumbs.Attributes;

namespace WashingtonChameleons.Controllers
{
    public class ActiveCarriersController : Controller
    {
        private readonly WashingtonContext _context;

        public ActiveCarriersController(WashingtonContext context)
        {
            _context = context;
        }

        // GET: ActiveCarriers
        [Breadcrumb("Active Carriers")]
        public async Task<IActionResult> Index(string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var companies = from c in _context.ActiveCarriers
                            select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                companies = companies.Where(c => c.LegalName.Contains(searchString));
            }


            companies = companies.OrderBy(c => c.LegalName);

            int pageSize = 50;
            return View(await PaginatedList<Models.ActiveCarriers>.CreateAsync(companies.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: ActiveCarriers/Details/5
        [Breadcrumb("Details")]
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

    }
}
