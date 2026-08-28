using kvhhLesson03.Models;
using Microsoft.AspNetCore.Mvc;

namespace kvhhLesson03.Controllers
{
    public class kvhhProductController : Controller
    {
        // tao mock data
        private readonly List<kvhhProduct> _products = new()
        {
        new kvhhProduct
{
    kvhhProductId = "SP001",
    kvhhProductName = "iPhone 15",
    kvhhYearRelease = "2023",
    kvhhPrice = "18990000"
},
new kvhhProduct
{
    kvhhProductId = "SP002",
    kvhhProductName = "Samsung Galaxy S24",
    kvhhYearRelease = "2024",
    kvhhPrice = "21990000"
},
new kvhhProduct
{
    kvhhProductId = "SP003",
    kvhhProductName = "Xiaomi 14",
    kvhhYearRelease = "2024",
    kvhhPrice = "16990000"
},
new kvhhProduct
{
    kvhhProductId = "SP004",
    kvhhProductName = "Google Pixel 8",
    kvhhYearRelease = "2023",
    kvhhPrice = "15990000"
},
new kvhhProduct
{
    kvhhProductId = "SP005",
    kvhhProductName = "OPPO Find X7",
    kvhhYearRelease = "2024",
    kvhhPrice = "17990000"
},
new kvhhProduct
{
    kvhhProductId = "SP006",
    kvhhProductName = "MacBook Air M2",
    kvhhYearRelease = "2022",
    kvhhPrice = "24990000"
},
new kvhhProduct
{
    kvhhProductId = "SP007",
    kvhhProductName = "Dell Inspiron 15",
    kvhhYearRelease = "2023",
    kvhhPrice = "15990000"
},
new kvhhProduct
{
    kvhhProductId = "SP008",
    kvhhProductName = "ASUS Vivobook 15",
    kvhhYearRelease = "2024",
    kvhhPrice = "14990000"
},
new kvhhProduct
{
    kvhhProductId = "SP009",
    kvhhProductName = "Lenovo IdeaPad 5",
    kvhhYearRelease = "2023",
    kvhhPrice = "13990000"
},
new kvhhProduct
{
    kvhhProductId = "SP010",
    kvhhProductName = "HP Pavilion 14",
    kvhhYearRelease = "2024",
    kvhhPrice = "16990000"
}
        };
        public IActionResult Index()
        {

            return Json(_products);
        }

        // Get:danh sach sản pham 
        public IActionResult kvhhGetAllProduct()
        {
            ViewData["products"] = _products;
            return View();
        }

        public IActionResult kvhhGetListProduct()
        {
           
            return View(_products);
        }
    }
}