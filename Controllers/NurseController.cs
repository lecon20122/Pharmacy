using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Data;
using Pharmacy.Models;

namespace Pharmacy.Controllers
{
    [Authorize(Policy = "IsNurse")]
    public class NurseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NurseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Nurse
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Pet.Include(p => p.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Nurse/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pet == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet
                .Include(p => p.Report)
                .Include(p => p.Prescription)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // GET: Nurse/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName");
            return View();
        }

        // POST: Nurse/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Name,Age,Gender,Allergies,UserId")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName", pet.UserId);
            return View(pet);
        }

        // GET: Nurse/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pet == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", pet.UserId);
            return View(pet);
        }

        // POST: Nurse/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Name,Age,Gender,Allergies,UserId")] Pet pet)
        {
            if (id != pet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetExists(pet.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", pet.UserId);
            return View(pet);
        }

        // GET: Nurse/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pet == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // POST: Nurse/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pet == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Pet'  is null.");
            }
            var pet = await _context.Pet.FindAsync(id);
            if (pet != null)
            {
                _context.Pet.Remove(pet);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetExists(int id)
        {
            return (_context.Pet?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
