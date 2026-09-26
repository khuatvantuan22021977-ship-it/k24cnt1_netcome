
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using kvhh2410900034_exam.Models;
using kvhh2410900034_exam.Models.Data;

public class kvhhStudentController : Controller
{
    private readonly ApplicationDbContext _context;

    public kvhhStudentController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: KVHHSTUDENTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.kvhhStudent.ToListAsync());
    }

    // GET: KVHHSTUDENTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var kvhhstudent = await _context.kvhhStudent
            .FirstOrDefaultAsync(m => m.Id == id);
        if (kvhhstudent == null)
        {
            return NotFound();
        }

        return View(kvhhstudent);
    }

    // GET: KVHHSTUDENTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: KVHHSTUDENTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,kvhhName,kvhhGender,kvhhBirthDay,kvhhEmail,kvhhPhone,kvhhActive")] kvhhStudent kvhhstudent)
    {
        if (ModelState.IsValid)
        {
            _context.Add(kvhhstudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(kvhhstudent);
    }

    // GET: KVHHSTUDENTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var kvhhstudent = await _context.kvhhStudent.FindAsync(id);
        if (kvhhstudent == null)
        {
            return NotFound();
        }
        return View(kvhhstudent);
    }

    // POST: KVHHSTUDENTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,kvhhName,kvhhGender,kvhhBirthDay,kvhhEmail,kvhhPhone,kvhhActive")] kvhhStudent kvhhstudent)
    {
        if (id != kvhhstudent.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(kvhhstudent);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KvhhStudentExists(kvhhstudent.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(kvhhstudent);
    }

    // GET: KVHHSTUDENTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var kvhhstudent = await _context.kvhhStudent
            .FirstOrDefaultAsync(m => m.Id == id);
        if (kvhhstudent == null)
        {
            return NotFound();
        }

        return View(kvhhstudent);
    }

    // POST: KVHHSTUDENTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var kvhhstudent = await _context.kvhhStudent.FindAsync(id);
        if (kvhhstudent != null)
        {
            _context.kvhhStudent.Remove(kvhhstudent);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool KvhhStudentExists(int? id)
    {
        return _context.kvhhStudent.Any(e => e.Id == id);
    }
}
