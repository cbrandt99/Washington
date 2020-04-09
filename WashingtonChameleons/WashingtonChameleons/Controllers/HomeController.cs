using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartBreadcrumbs.Attributes;
using WashingtonChameleons.Models;

namespace WashingtonChameleons.Controllers
{

    public class HomeController : Controller
    {

        private readonly WashingtonContext _context;

        public HomeController(WashingtonContext context)
        {
            _context = context;
        }

        [DefaultBreadcrumb("<i class=\"fas fa-home\"></i>")]
        public IActionResult Index(string zipcode)
        {
            List<MapMarker> markers = new List<MapMarker>();

            if (!String.IsNullOrEmpty(zipcode))
            {

                var possibleChameleons = (from c in _context.ChameleonTable.Where(c => c.ZipCode == zipcode)
                                          select c).ToList();

                List<string> usedCompanies = new List<string>();

                foreach (var company in possibleChameleons)
                {

                    markers.Add(new MapMarker(company.CurrentName, company.FormerName, company.Latitude, company.Longitude, company.ConfidenceLevel, company.ChameleonId));
                    usedCompanies.Add(company.CurrentName);

                }

                var normalCompanies = (from c in _context.ActiveCarriers.Where(c => c.Phyzip == zipcode && !(usedCompanies.Contains(c.LegalName)))
                                       select c).ToList();

                foreach (var company in normalCompanies)
                {

                    markers.Add(new MapMarker(company.LegalName, company.Latitude, company.Longitude, company.DotNumber));

                }

                @ViewData["ZipCode"] = zipcode;

            }

            return View(markers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
