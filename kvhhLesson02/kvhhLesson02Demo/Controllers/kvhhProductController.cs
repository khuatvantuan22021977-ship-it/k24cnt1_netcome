using kvhhLesson02Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace kvhhLesson02Demo.Controllers
{
    public class kvhhProductController : Controller
    {
        public IActionResult Index()
        {
            // dua du lieu ra view
            ViewBag.name = "khuat van hoang hiep ";
            ViewData["address"] = "Fit NTU ";
            TempData["UNI"] = "Truong dai hoc nguyen trai";

            return View();
        }

        // chi tiet san pham 
        public IActionResult GetProduct() 
        {
         // Mock data 
         kvhhProduct kvhhProduct = new kvhhProduct()
         {
           ProductId="P001",
           ProductName="Laptop dell",
           YearRelease=2024,
           Price=120000000000000,
           
         };

                ViewData["productVD"] = kvhhProduct;
                ViewBag.productVB = kvhhProduct;

                return View();
        }
    }
}
