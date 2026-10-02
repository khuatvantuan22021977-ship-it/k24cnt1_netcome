using Microsoft.AspNetCore.Mvc;

namespace kvhhLesson13Layout.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string Keyword)
        {
                ViewData["keyword"] = Keyword;
                return View();
        }
        public IActionResult Host()
        {
            
            return View();
        }

    }
}
