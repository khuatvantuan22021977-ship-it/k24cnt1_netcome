using Microsoft.AspNetCore.Mvc;
using kvhhLesson08Models.Models;

namespace kvhhLesson08Models.Controllers
{
    public class kvhhMemberController : Controller
    {
        // Mock data - kvhhMember
        private static List<kvhhMember> _members = new List<kvhhMember>()
        {
            new kvhhMember
            {
                kvhhMemberId = Guid.NewGuid().ToString(),
                kvhhUserName = "ChungTv",
                kvhhPassword = "Password123!",
                kvhhFullName = "khuất văn hoàng hiệp",
                kvhhEmail = "khuatvanhoanghiepj@gmail.com"
            },
            new kvhhMember
            {
                kvhhMemberId = Guid.NewGuid().ToString(),
                kvhhUserName = "tranthib",
                kvhhPassword = "SecurePass456#",
                kvhhFullName = "Trần Thị B",
                kvhhEmail = "tranthib@outlook.com"
            },
            new kvhhMember
            {
                kvhhMemberId = Guid.NewGuid().ToString(),
                kvhhUserName = "levanc",
                kvhhPassword = "MyPassword789$",
                kvhhFullName = "Lê Văn C",
                kvhhEmail = "levanc@company.com"
            }
        };

        // GET: Danh sách thành viên
        public IActionResult Index()
        {
            return View(_members);
        }

        [HttpGet]
        public IActionResult kvhhCreate()
        {
            var member = new kvhhMember();
            return View(member);
        }

        [HttpPost]
        public IActionResult kvhhCreate(kvhhMember kvhhMember)
        {
            kvhhMember.kvhhMemberId = Guid.NewGuid().ToString();
            _members.Add(kvhhMember);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult kvhhEdit(string id)
        {
            var member = _members.Where(x=>x.kvhhMemberId.Equals(id)).FirstOrDefault();

            return View(member);
        }

        [HttpPost]
        public IActionResult kvhhEdit(string id, kvhhMember kvhhMember)
        {
            for (int i = 0; i < _members.Count; i++)
            {
                if (_members[i].kvhhMemberId == id)
                {
                    _members[i].kvhhUserName = kvhhMember.kvhhUserName;
                    _members[i].kvhhPassword = kvhhMember.kvhhPassword;
                    _members[i].kvhhFullName = kvhhMember.kvhhFullName;
                    _members[i].kvhhEmail = kvhhMember.kvhhEmail;

                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult kvhhDetails(string id)
        {
            var member = _members
                .Where(x => x.kvhhMemberId.Equals(id))
                .FirstOrDefault();

            return View(member);
        }

        [HttpGet]
        public IActionResult kvhhDelete(string id)
        {
            var member = _members
                .Where(x => x.kvhhMemberId.Equals(id))
                .FirstOrDefault();

            return View(member);
        }

        [HttpPost]
        public IActionResult kvhhDeleted(string id)
        {
            foreach (var item in _members)
            {
                if (item.kvhhMemberId.Equals(id))
                {
                    _members.Remove(item);
                    return RedirectToAction("Index");
                }
            }

            return View("kvhhDelete");
        }
        public IActionResult kvhhAbout()
        {
            return View();
        }
    }
}