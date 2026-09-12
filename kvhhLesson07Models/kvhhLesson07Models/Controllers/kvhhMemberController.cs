using Microsoft.AspNetCore.Mvc;
using kvhhLesson07Models.Models.DataModels;

namespace kvhhLesson07Models.Controllers
{
    public class kvhhMemberController : Controller
    {
        // Mock Data
        protected static List<kvhhMember> _members = new List<kvhhMember>
        {
            new kvhhMember
            {
                kvhhMemberId = Guid.NewGuid().ToString(),
                kvhhUserName = "hieptv",
                kvhhPassword = "123456",
                kvhhFullName = "Khuất Văn Hoàng Hiệp",
                kvhhEmail = "hoanghiepj@example.com"
            },
            new kvhhMember
            {
                kvhhMemberId = Guid.NewGuid().ToString(),
                kvhhUserName = "nguyenvanson",
                kvhhPassword = "123456",
                kvhhFullName = "Nguyễn Văn Sơn",
                kvhhEmail = "nguyenvanson@example.com"
            },
            new kvhhMember
            {
                kvhhMemberId = Guid.NewGuid().ToString(),
                kvhhUserName = "tranthibinh",
                kvhhPassword = "123456",
                kvhhFullName = "Trần Thị Bình",
                kvhhEmail = "tranthibinh@example.com"
            },
            new kvhhMember
            {
                kvhhMemberId = Guid.NewGuid().ToString(),
                kvhhUserName = "levancuong",
                kvhhPassword = "123456",
                kvhhFullName = "Lê Văn Cường",
                kvhhEmail = "levancuong@example.com"
            },
            new kvhhMember
            {
                kvhhMemberId = Guid.NewGuid().ToString(),
                kvhhUserName = "phamthiduyen",
                kvhhPassword = "123456",
                kvhhFullName = "Phạm Thị Duyên",
                kvhhEmail = "phamthiduyen@example.com"
            }
        };

        public IActionResult Index()
        {
            return View(_members);
        }

        public IActionResult GetMember()
        {
            var member = new kvhhMember
            {
                kvhhMemberId = Guid.NewGuid().ToString(),
                kvhhUserName = "hieptv",
                kvhhPassword = "password123",
                kvhhFullName = "Khuất Văn Hoàng Hiệp",
                kvhhEmail = "hoanghiepj@gmail.com"
            };

            return View(member);
        }

        // Đưa dữ liệu dạng List ra View
        public IActionResult GetMembers()
        {
            // Lấy từ mock data
            ViewBag.Members = _members;
            return View();
        }

        // GET: Create member
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create member
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(kvhhMember member)
        {
            if (ModelState.IsValid)
            {
                member.kvhhMemberId = Guid.NewGuid().ToString();
                _members.Add(member);
                return RedirectToAction(nameof(Index));
            }

            return View(member);
        }
    }
}