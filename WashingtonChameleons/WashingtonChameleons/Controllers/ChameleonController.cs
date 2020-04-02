using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WashingtonChameleons.Models;
using PagedList;

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
        public async Task<IActionResult> Index(string searchString, string currentFilter, int? pageNumber, int? minRating)
        {          

            if (searchString != null)
            {
                pageNumber = 1;
            } else
            {
                searchString = currentFilter;
            }

            var companies = from c in _context.ChameleonTable
                            select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                companies = companies.Where(c => c.CurrentName.Contains(searchString) || c.FormerName.Contains(searchString));
            }

            if (minRating != null)
            {
                companies = companies.Where(c => c.ConfidenceLevel >= minRating);
            }


            companies = companies.OrderBy(c => c.CurrentName);

            int pageSize = 12;
            return View(await PaginatedList<ChameleonTable>.CreateAsync(companies.AsNoTracking(), pageNumber ?? 1, pageSize));
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

            /* Get Potential Chameleon Company */
            var CurrentCompany = from c in _context.ActiveCarriers.Where(c => c.Latitude.Equals(chameleonTable.Latitude) && c.Longitude.Equals(chameleonTable.Longitude))
                                 select c;

            ViewBag.CurrentDotNumber = CurrentCompany.First().DotNumber;
            ViewBag.CurrentDrivers = CurrentCompany.First().DriverTotal;

            /* View Original */
            var OriginalCompany = from c in _context.Carriers.Where(c => c.Latitude.Equals(chameleonTable.Latitude) && c.Longitude.Equals(chameleonTable.Longitude))
                                  select c;


            ViewBag.OCDotNumber = OriginalCompany.First().DotNumber;
            ViewBag.OCName = OriginalCompany.First().CarrierName;
            ViewBag.OCStreet = OriginalCompany.First().StreetAddress;
            ViewBag.OCCity = OriginalCompany.First().City;
            ViewBag.OCState = OriginalCompany.First().StateAddress;
            ViewBag.OCZip = OriginalCompany.First().Zipcode;
            ViewBag.OCOOSReason = OriginalCompany.First().OosReason;

            return View(chameleonTable);
        }

        private bool ChameleonTableExists(int id)
        {
            return _context.ChameleonTable.Any(e => e.ChameleonId == id);
        }
    }
}
