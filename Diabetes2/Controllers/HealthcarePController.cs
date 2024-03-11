using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Diabetes2.Controllers
{
    public class HealthcarePController : Controller
    {
        // GET: HealthcarePController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HealthcarePController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HealthcarePController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HealthcarePController/Create
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

        // GET: HealthcarePController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HealthcarePController/Edit/5
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

        // GET: HealthcarePController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HealthcarePController/Delete/5
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
