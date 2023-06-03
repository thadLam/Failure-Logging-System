using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Failure_Logging_System.Controllers
{
    public class RecordController : Controller
    {

        // GET: RecordController/ViewRecord
        public IActionResult ViewRecord()
        {
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
    }
}
