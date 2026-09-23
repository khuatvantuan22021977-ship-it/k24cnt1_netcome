using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson04Lab.Controllers
{
    public class kvhhPeopleController : Controller
    {
        // GET: kvhhPeopleController
        public ActionResult Index()
        {
            var _peoples = DataLocal.Getpeoples();
            return View(_peoples);
        }

        // GET: kvhhPeopleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: kvhhPeopleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: kvhhPeopleController/Create
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

        // GET: kvhhPeopleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: kvhhPeopleController/Edit/5
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

        // GET: kvhhPeopleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: kvhhPeopleController/Delete/5
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
