using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;

namespace Web.Controllers;

public class DiaryController : Controller
{
    private readonly Context _context;
    public DiaryController(Context context) => _context = context;
    public async Task<IActionResult> Index()
    {
        var diaries = await _context.Diaries.ToListAsync();
        return View(diaries);
    }

    public IActionResult Create()
    {
        return View(new DiaryModel()); // Pass an empty DiaryModel to the view
    }

    // POST: Diary/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(DiaryModel diary)
    {
        if (ModelState.IsValid)
        {
            _context.Diaries.Add(diary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(diary); // In case validation fails, return the model to the view
    }

    // Edit (update an existing diary)
    public async Task<IActionResult> Edit(int id)
    {
        var diary = await _context.Diaries.FindAsync(id);
        if (diary == null) return NotFound();
        return View(diary);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, DiaryModel diary)
    {
        if (id != diary.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(diary);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiaryExists(diary.Id))
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
        return View(diary);
    }

    // Details (view a single diary)
    public async Task<IActionResult> Details(int id)
    {
        var diary = await _context.Diaries
            .FirstOrDefaultAsync(m => m.Id == id);
        if (diary == null)
        {
            return NotFound();
        }

        return View(diary);
    }

    // Delete (confirm deletion of a diary)
    public async Task<IActionResult> Delete(int id)
    {
        var diary = await _context.Diaries
            .FirstOrDefaultAsync(m => m.Id == id);
        if (diary == null)
        {
            return NotFound();
        }
        return View(diary);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var diary = await _context.Diaries.FindAsync(id);
        if (diary != null)
        {
            _context.Diaries.Remove(diary);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Index));
    }

    private bool DiaryExists(int id)
    {
        return _context.Diaries.Any(e => e.Id == id);
    }
}