using kvhhLesson04Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace kvhhLesson04Lab.Controllers
{
    public class kvhhAccountController : Controller
    {
        private readonly List<kvhhAccount> kvhhAccounts = new()
        {
            new kvhhAccount
            {
                Id = 1,
                Name = "Nguyễn Ngọc Anh",
                Email = "nguyenngocanh@gmail.com",
                Phone = "0901234567",
                Anime = "/imager/1.jpg",
                Address = "Hà Nội",
                Bio = "Yêu thích anime và manga",
                Gender = 0,
                Birthday = new DateTime(2005, 5, 10)
            },

            new kvhhAccount
            {
                Id = 2,
                Name = "Trần Thị Mai",
                Email = "tranthimai@gmail.com",
                Phone = "0912345678",
                Anime = "/imager/2.jpg",
                Address = "Hải Phòng",
                Bio = "Thích xem anime và đọc truyện",
                Gender = 0,
                Birthday = new DateTime(2006, 8, 15)
            },

            new kvhhAccount
            {
                Id = 3,
                Name = "Lê Khánh Linh",
                Email = "lekhanhlinh@gmail.com",
                Phone = "0923456789",
                Anime = "/imager/3.jpg",
                Address = "Đà Nẵng",
                Bio = "Fan của One Piece",
                Gender = 0,
                Birthday = new DateTime(2004, 3, 22)
            },

            new kvhhAccount
            {
                Id = 4,
                Name = "Phạm Ngọc Linh",
                Email = "phamngoclinh@gmail.com",
                Phone = "0934567890",
                Anime = "/imager/4.jpg",
                Address = "Hồ Chí Minh",
                Bio = "Yêu thích anime hành động",
                Gender = 0,
                Birthday = new DateTime(2005, 11, 5)
            }
        };

        public IActionResult kvhhIndex()
        {
            ViewBag.kvhhAccounts = kvhhAccounts;
            return View(kvhhAccounts);
        }
    }
}