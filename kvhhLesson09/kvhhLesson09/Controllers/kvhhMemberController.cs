using Microsoft.AspNetCore.Mvc;
using kvhhLesson09.Models.DataModels;
using kvhhLesson09.Models.DataViewModels;

namespace kvhhLesson09.Controllers
{
    public class kvhhMemberController : Controller
    {
        // Danh sách thành viên tạm thời
        private static List<kvhhMember> _kvhhMembers = new List<kvhhMember>();

        // GET: /kvhhMember
        public IActionResult Index()
        {
            return View(_kvhhMembers);
        }

        // GET: /kvhhMember/Details/5
        public IActionResult Details(int id)
        {
            var member = _kvhhMembers.FirstOrDefault(x => x.KvhhMemberId == id);

            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // GET: /kvhhMember/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /kvhhMember/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(KvhhMemberRegister model)
        {
            // Kiểm tra Data Annotation
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Tạo ID tự động
            int newId = _kvhhMembers.Count == 0
                ? 1
                : _kvhhMembers.Max(x => x.KvhhMemberId) + 1;

            // Chuyển từ ViewModel sang DataModel
            var member = new kvhhMember
            {
                KvhhMemberId = newId,
                KvhhUserName = model.KvhhUserName,
                KvhhPassword = model.KvhhPassword,
                KvhhEmail = model.KvhhEmail,
                KvhhPhoneNumber = model.KvhhPhoneNumber,
                KvhhFullName = model.KvhhFullName,
                KvhhBirthday = model.KvhhBirthday
            };

            // Thêm thành viên vào danh sách
            _kvhhMembers.Add(member);

            // Quay về danh sách
            return RedirectToAction(nameof(Index));
        }

        // GET: /kvhhMember/Edit/5
        public IActionResult Edit(int id)
        {
            var member = _kvhhMembers.FirstOrDefault(x => x.KvhhMemberId == id);

            if (member == null)
            {
                return NotFound();
            }

            var model = new KvhhMemberRegister
            {
                KvhhMemberId = member.KvhhMemberId,
                KvhhUserName = member.KvhhUserName,
                KvhhPassword = member.KvhhPassword,
                KvhhEmail = member.KvhhEmail,
                KvhhPhoneNumber = member.KvhhPhoneNumber,
                KvhhFullName = member.KvhhFullName,
                KvhhBirthday = member.KvhhBirthday
            };

            return View(model);
        }

        // POST: /kvhhMember/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, KvhhMemberRegister model)
        {
            if (id != model.KvhhMemberId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var member = _kvhhMembers.FirstOrDefault(x => x.KvhhMemberId == id);

            if (member == null)
            {
                return NotFound();
            }

            member.KvhhUserName = model.KvhhUserName;
            member.KvhhPassword = model.KvhhPassword;
            member.KvhhEmail = model.KvhhEmail;
            member.KvhhPhoneNumber = model.KvhhPhoneNumber;
            member.KvhhFullName = model.KvhhFullName;
            member.KvhhBirthday = model.KvhhBirthday;

            return RedirectToAction(nameof(Index));
        }

        // GET: /kvhhMember/Delete/5
        public IActionResult Delete(int id)
        {
            var member = _kvhhMembers.FirstOrDefault(x => x.KvhhMemberId == id);

            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // POST: /kvhhMember/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var member = _kvhhMembers.FirstOrDefault(x => x.KvhhMemberId == id);

            if (member == null)
            {
                return NotFound();
            }

            _kvhhMembers.Remove(member);

            return RedirectToAction(nameof(Index));
        }
    }
}