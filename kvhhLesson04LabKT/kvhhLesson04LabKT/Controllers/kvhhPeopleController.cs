using kvhhLesson04LabKT.Models;
using Microsoft.AspNetCore.Mvc;

namespace kvhhLesson04LabKT.Controllers
{
    public class kvhhPeopleController : Controller
    {
        // GET: kvhhPeopleController
        public ActionResult Index()
        {
            var _peoples = DataLocal.GetPeoples();
            return View(_peoples);
        }

        // GET: kvhhPeopleController/Details/5
        public ActionResult Details(int id)
        {
            var peoples = DataLocal.GetPeopleById(id);
            return View(peoples);
        }

        // GET: kvhhPeopleController/Create
        public ActionResult Create()
        {
            People people = new People();
            return View(people);
        }

        // POST: kvhhPeopleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(People model)
        {
            try
            {
                // Lấy file upload
                var files = HttpContext.Request.Form.Files;

                if (files.Count > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var fileName = file.FileName;

                    // Đường dẫn lưu ảnh
                    var path = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "images",
                        "avatar",
                        fileName
                    );

                    // Lưu ảnh
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    // Lưu đường dẫn ảnh vào Avatar
                    model.Avatar = "images/avatar/" + fileName;
                }

                // Thêm People vào DataLocal
                DataLocal._peoples.Add(model);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View(model);
            }
        }

        // GET: kvhhPeopleController/Edit/5
        public ActionResult Edit(int id)
        {
            var people = DataLocal.GetPeopleById(id);
            return View(people);
        }

        // POST: kvhhPeopleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, People model)
        {
            try
            {
                // Upload file vào thư mục wwwroot/images/avatar
                var files = HttpContext.Request.Form.Files;

                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;

                    // Đường dẫn lưu ảnh
                    var path = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "images",
                        "avatar",
                        FileName
                    );

                    // Lưu file
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    // Gán đường dẫn ảnh cho Avatar
                    model.Avatar = "images/avatar/" + FileName;
                }

                // Cập nhật model vào danh sách DataLocal
                for (int i = 0; i < DataLocal._peoples.Count; i++)
                {
                    if (DataLocal._peoples[i].Id == id)
                    {
                        DataLocal._peoples[i] = model;
                        break;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: kvhhPeopleController/Delete/5
        public ActionResult Delete(int id)
        {
            var peoples = DataLocal.GetPeopleById(id);
            return View(peoples);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, People model)
        {
            try
            {
                for (int i = 0; i < DataLocal._peoples.Count; i++)
                {
                    if (DataLocal._peoples[i].Id == id)
                    {
                        DataLocal._peoples.RemoveAt(i);
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}