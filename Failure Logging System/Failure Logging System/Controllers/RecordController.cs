using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using Failure_Logging_System.Models;
using Failure_Logging_System.Data;


namespace Failure_Logging_System.Controllers
{
    public class RecordController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecordController(ApplicationDbContext context)
        {
            _context = context;
        }  
        // GET: RecordController/ViewRecord
        public IActionResult ViewRecord(string searchString, string currentFilter, int? pageNumber, string sortOrder)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;
            var drivers = from d in _context.Drivers
                          select d;
            return View();
        }

        // GET: RecordController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecordController/Create
        public ActionResult Create()
        {
            //drivers list
            List<SelectListItem> drivers = new()
            {
                new SelectListItem { Value = "075.001-1", Text = "075.001-1"},
                new SelectListItem { Value = "075.QX", Text = "075.QX"},
                new SelectListItem { Value = "075.QXC6", Text = "075.QXC6"},
                new SelectListItem { Value = "075.QXC8", Text = "075.QXC8"},
                new SelectListItem { Value = "1.002", Text = "1.002"},
                new SelectListItem { Value = "1.003", Text = "1.003"},
                new SelectListItem { Value = "1.007", Text = "1.007"},
                new SelectListItem { Value = "10.002.2", Text = "10.002.2"},
                new SelectListItem { Value = "10.004", Text = "10.004"},
                new SelectListItem { Value = "12.001", Text = "12.001"},
                new SelectListItem { Value = "2.001", Text = "2.001"},
                new SelectListItem { Value = "2.003", Text = "2.003"},
                new SelectListItem { Value = "3.001-1", Text = "3.001-1"},
                new SelectListItem { Value = "3.003", Text = "3.003"},
                new SelectListItem { Value = "3.004", Text = "3.004"},
                new SelectListItem { Value = "4.001-1", Text = "4.001-1"},
                new SelectListItem { Value = "4.002-1", Text = "4.002-1"},
                new SelectListItem { Value = "4.003.1", Text = "4.003.1"},
                new SelectListItem { Value = "4.004", Text = "4.004"},
                new SelectListItem { Value = "4.005", Text = "4.005"},
                new SelectListItem { Value = "4.006", Text = "4.006"},
                new SelectListItem { Value = "5.007", Text = "5.007"},
                new SelectListItem { Value = "6.5.001F", Text = "6.5.001F"},
                new SelectListItem { Value = "6.5.002", Text = "6.5.002"},
                new SelectListItem { Value = "6.5.004", Text = "6.5.004"},
                new SelectListItem { Value = "6.5.005", Text = "6.5.005"},
                new SelectListItem { Value = "6.5.006", Text = "6.5.006"},
                new SelectListItem { Value = "6.5.008", Text = "6.5.008"},
                new SelectListItem { Value = "8.001F", Text = "8.001F"},
                new SelectListItem { Value = "8.003.1", Text = "8.003.1"},
                new SelectListItem { Value = "8.003.2", Text = "8.003.2"},
                new SelectListItem { Value = "DRV.2X5.001", Text = "DRV.2X5.001"},
                new SelectListItem { Value = "NE65W-04", Text = "NE65W-04"}
            };

            //airLeak Type list
            List<SelectListItem> airLeakType = new()
            {
                new SelectListItem { Value = "External", Text = "External"},
                new SelectListItem { Value = "Internal", Text = "Internal"},
                new SelectListItem { Value = "Unknown", Text = "Unknown"}
            };

            //airLeak Location list
            List<SelectListItem> airLeakLocation = new()
            {
                new SelectListItem { Value = "Cable Hole", Text = "Cable Hole"},
                new SelectListItem { Value = "Gasket", Text = "Gasket"},
                new SelectListItem { Value = "Woofer Seal", Text = "Woofer Seal"},
                new SelectListItem { Value = "Woofer Magnet", Text = "Woofer Magnet"},
                new SelectListItem { Value = "Unknown", Text = "Unknown"}
            };

            //cosmetic Location list
            List<SelectListItem> cosmeticLocation = new()
            {
                new SelectListItem { Value = "Damaged Driver Frame", Text = "Damaged Driver Frame"},
                new SelectListItem { Value = "Driver Cone Dented", Text = "Driver Cone Dented"},
                new SelectListItem { Value = "Imbalanced Tweeter", Text = "Imbalanced Tweeter"},
                new SelectListItem { Value = "Missing Terminal", Text = "Missing Terminal"},
                new SelectListItem { Value = "Woofer Seal", Text = "Woofer Seal"},
                new SelectListItem { Value = "Unknown", Text = "Unknown"}
            };

            //listening Type list
            List<SelectListItem> listeningType = new()
            {
                new SelectListItem { Value = "Distortion", Text = "Distortion"},
                new SelectListItem { Value = "Knocking", Text = "Knocking"},
                new SelectListItem { Value = "No Sound", Text = "No Sound"},
                new SelectListItem { Value = "Rattle", Text = "Rattle"},
                new SelectListItem { Value = "Rub/Buzz", Text = "Rub/Buzz"},
                new SelectListItem { Value = "Static", Text = "Static"},
                new SelectListItem { Value = "Vibration", Text = "Vibration"},
                new SelectListItem { Value = "Whistling", Text = "Whistling"},
                new SelectListItem { Value = "Other", Text = "Other"},
                new SelectListItem { Value = "Unknown", Text = "Unknown"}
            };

            //listening Location list
            List<SelectListItem> listeningLocation = new()
            {
                new SelectListItem { Value = "Cabinet", Text = "Cabinet"},
                new SelectListItem { Value = "Cable Hitting Woofer", Text = "Cable Hitting Woofer"},
                new SelectListItem { Value = "Coil Grinds", Text = "Coil Grinds"},
                new SelectListItem { Value = "Unknown", Text = "Unknown"}
            };

            //polarity Location list
            List<SelectListItem> polarityLocation = new()
            {
                new SelectListItem { Value = "Flipped Wiring", Text = "Flipped Wiring"},
                new SelectListItem { Value = "Unknown", Text = "Unknown"}
            };

            //apTest Type list
            List<SelectListItem> apTestType = new()
            {
                new SelectListItem { Value = "RMS", Text = "RMS"},
                new SelectListItem { Value = "Impedence", Text = "Impedence"},
                new SelectListItem { Value = "THD", Text = "THD"},
                new SelectListItem { Value = "Phase", Text = "Phase"},
                new SelectListItem { Value = "Unknown", Text = "Unknown"}
            };

            //apTest Location list
            List<SelectListItem> apTestLocation = new()
            {
                new SelectListItem { Value = "No Output", Text = "No Output"},
                new SelectListItem { Value = "Peak", Text = "Peak"},
                new SelectListItem { Value = "Dip", Text = "Dip"},
                new SelectListItem { Value = "Unknown", Text = "Unknown"}
            };

            //grounding Location list
            List<SelectListItem> groundingLocation = new()
            {
                new SelectListItem { Value = "Magnet", Text = "Magnet"},
                new SelectListItem { Value = "Cabinet", Text = "Cabinet"},
                new SelectListItem { Value = "Unknown", Text = "Unknown"}
            };

            //models list
            List<SelectListItem> models = new()
            {
                new SelectListItem { Value = "Unknown", Text = "Unknown"}
            };

            //failure Fault list
            List<SelectListItem> failureFault = new()
            {
                new SelectListItem { Value = "Assembly", Text = "Assembly"},
                new SelectListItem { Value = "External Manufacturer", Text = "External Manufacturer"},
                new SelectListItem { Value = "Internal Fabrication", Text = "Internal Fabrication"},
                new SelectListItem { Value = "QC", Text = "QC"},
                new SelectListItem { Value = "Unknown", Text = "Unknown"}
            };

            //quanity list
            List<SelectListItem> quantity = new()
            {
                new SelectListItem { Value = "1", Text = "1"},
                new SelectListItem { Value = "2", Text = "2"},
                new SelectListItem { Value = "3", Text = "3"},
                new SelectListItem { Value = "4", Text = "4"},
                new SelectListItem { Value = "5", Text = "5"},
                new SelectListItem { Value = "5", Text = "6"},
                new SelectListItem { Value = "5", Text = "7"},
                new SelectListItem { Value = "5", Text = "8"},
                new SelectListItem { Value = "5", Text = "9"},
                new SelectListItem { Value = "5", Text = "10"}
            };

            //assigning SelectListItem to View Bag
            ViewBag.drivers = drivers;
            ViewBag.airLeakType = airLeakType;
            ViewBag.airLeakLocation = airLeakLocation;
            ViewBag.cosmeticLocation = cosmeticLocation;
            ViewBag.listeningType = listeningType;
            ViewBag.listeningLocation = listeningLocation;
            ViewBag.polarityLocation = polarityLocation;
            ViewBag.apTestType = apTestType;
            ViewBag.apTestLocation = apTestLocation;
            ViewBag.groundingLocation = groundingLocation;
            ViewBag.models = models;
            ViewBag.failureFault = failureFault;
            ViewBag.quantity = quantity;
            return View();
        }

        // POST: RecordController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecordController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecordController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecordController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecordController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecordController/GenerateReport
        public IActionResult GenerateReport()
        {
            return View();
        }

        // GET: RecordController/Reporting
        public ActionResult Reporting()
        {
            //drivers list
            List<SelectListItem> drivers = new()
            {
                new SelectListItem { Value = "075.001-1", Text = "075.001-1"},
                new SelectListItem { Value = "075.QX", Text = "075.QX"},
                new SelectListItem { Value = "075.QXC6", Text = "075.QXC6"},
                new SelectListItem { Value = "075.QXC8", Text = "075.QXC8"},
                new SelectListItem { Value = "1.002", Text = "1.002"},
                new SelectListItem { Value = "1.003", Text = "1.003"},
                new SelectListItem { Value = "1.007", Text = "1.007"},
                new SelectListItem { Value = "10.002.2", Text = "10.002.2"},
                new SelectListItem { Value = "10.004", Text = "10.004"},
                new SelectListItem { Value = "12.001", Text = "12.001"},
                new SelectListItem { Value = "2.001", Text = "2.001"},
                new SelectListItem { Value = "2.003", Text = "2.003"},
                new SelectListItem { Value = "3.001-1", Text = "3.001-1"},
                new SelectListItem { Value = "3.003", Text = "3.003"},
                new SelectListItem { Value = "3.004", Text = "3.004"},
                new SelectListItem { Value = "4.001-1", Text = "4.001-1"},
                new SelectListItem { Value = "4.002-1", Text = "4.002-1"},
                new SelectListItem { Value = "4.003.1", Text = "4.003.1"},
                new SelectListItem { Value = "4.004", Text = "4.004"},
                new SelectListItem { Value = "4.005", Text = "4.005"},
                new SelectListItem { Value = "4.006", Text = "4.006"},
                new SelectListItem { Value = "5.007", Text = "5.007"},
                new SelectListItem { Value = "6.5.001F", Text = "6.5.001F"},
                new SelectListItem { Value = "6.5.002", Text = "6.5.002"},
                new SelectListItem { Value = "6.5.004", Text = "6.5.004"},
                new SelectListItem { Value = "6.5.005", Text = "6.5.005"},
                new SelectListItem { Value = "6.5.006", Text = "6.5.006"},
                new SelectListItem { Value = "6.5.008", Text = "6.5.008"},
                new SelectListItem { Value = "8.001F", Text = "8.001F"},
                new SelectListItem { Value = "8.003.1", Text = "8.003.1"},
                new SelectListItem { Value = "8.003.2", Text = "8.003.2"},
                new SelectListItem { Value = "DRV.2X5.001", Text = "DRV.2X5.001"},
                new SelectListItem { Value = "NE65W-04", Text = "NE65W-04"}
            };

            //assigning SelectListItem to View Bag
            ViewBag.drivers = drivers;
            return View();
        }
    }
}
