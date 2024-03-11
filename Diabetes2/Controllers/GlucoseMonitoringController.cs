using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Diabetes2.Controllers
{
    public class GlucoseMonitoringController : Controller
    {
        // GET: GlucoseMonitoringController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GlucoseMonitoringController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GlucoseMonitoringController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GlucoseMonitoringController/Create
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

        // GET: GlucoseMonitoringController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GlucoseMonitoringController/Edit/5
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

        // GET: GlucoseMonitoringController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GlucoseMonitoringController/Delete/5
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
