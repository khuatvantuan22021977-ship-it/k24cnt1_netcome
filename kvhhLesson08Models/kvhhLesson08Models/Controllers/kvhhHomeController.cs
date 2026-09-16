using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using kvhhLesson08Models.Models;

namespace kvhhLesson08Models.Controllers
{
    public class kvhhHomeController : Controller
    {
        private readonly ILogger<kvhhHomeController> _logger;

        public kvhhHomeController(ILogger<kvhhHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult kvhhIndex()
        {
            return View();
        }

        public IActionResult kvhhPrivacy()
        {
            return View();
        }

        public IActionResult kvhhAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}