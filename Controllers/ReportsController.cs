using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Data;
using Pharmacy.Models;
using Pharmacy.Views.Reports;

namespace Pharmacy.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ReportsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Reports
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Report.Include(r => r.Pet);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Report == null)
            {
                return NotFound();
            }

            var report = await _context.Report
                .Include(r => r.Pet)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }

        // GET: Reports/Create
        public IActionResult Create(int? id)
        {
            var model = new CreateReportViewModel
            {
                paramPetId = id,
                selectListItems = new SelectList(_context.Pet, "Id", "Id")
            };
            return View(model);
        }

        // POST: Reports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Description,PetId,File")] CreateReportViewModel report)
        {
            if (report.File is null) return BadRequest("No File Found");

            var uploadDirectory = @"reports";
            var fileName = $"{Guid.NewGuid()}-{report.File.FileName.Split('.').First()}.{report.File.FileName.Split('.').Last()}";
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, uploadDirectory, fileName);

            report.File.CopyTo(new FileStream(filePath, FileMode.Create));

            var reportModel = new Report
            {
                Type = report.Type,
                Description = report.Description,
                PetId = report.PetId,
                File = Path.Combine(uploadDirectory, fileName)
            };

            if (ModelState.IsValid)
            {
                _context.Add(reportModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Doctor", new { id = report.PetId });
            }

            var model = new CreateReportViewModel
            {
                paramPetId = report.Id,
                selectListItems = new SelectList(_context.Pet, "Id", "Id")
            };
            return View(report);
        }

        // GET: Reports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Report == null)
            {
                return NotFound();
            }

            var report = await _context.Report.FindAsync(id);
            if (report == null)
            {
                return NotFound();
            }
            ViewData["PetId"] = new SelectList(_context.Pet, "Id", "Id", report.PetId);
            return View(report);
        }

        // POST: Reports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Description,PetId,File")] Report report)
        {
            if (id != report.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(report);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportExists(report.Id))
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
            ViewData["PetId"] = new SelectList(_context.Pet, "Id", "Id", report.PetId);
            return View(report);
        }

        // GET: Reports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Report == null)
            {
                return NotFound();
            }

            var report = await _context.Report
                .Include(r => r.Pet)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }

        // POST: Reports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Report == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Report'  is null.");
            }
            var report = await _context.Report.FindAsync(id);
            if (report != null)
            {
                _context.Report.Remove(report);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportExists(int id)
        {
            return (_context.Report?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
