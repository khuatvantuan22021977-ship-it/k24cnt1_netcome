using Microsoft.AspNetCore.Mvc;

namespace kvhhNetCoreLA7.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
