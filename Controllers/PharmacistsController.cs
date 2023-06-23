using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Data;
using Pharmacy.Repository;

namespace Pharmacy.Controllers
{
    [Authorize(Policy = "IsPharmacist")]
    public class PharmacistsController : Controller
    {
        private readonly IPets _pets;
        private readonly ApplicationDbContext _context;

        public PharmacistsController(IPets pets, ApplicationDbContext context)
        {
            _pets = pets;
            _context = context;
        }
        // GET: PharmacistsController
        public ActionResult Index(int? id, string? searchName)
        {
            var pets = _pets.GetAll(id, searchName);

            return View(pets);
        }

        // GET: PharmacistsController/Details/5
        public ActionResult Details(int id)
        {
            var pet = _pets.GetPet(id);

            if (pet is null) return NotFound();

            return View(pet);
        }

        [HttpPost, ActionName("ToggleStatus")]
        public async Task<IActionResult> ToggleStatus(int id)
        {
            if (id == null || _context.Prescription == null)
            {
                return NotFound();
            }

            var prescription = await _context.Prescription
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prescription == null)
            {
                return NotFound();
            }


            prescription.Status = !prescription.Status;

            _context.Update(prescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Details), new { id = prescription.PetId });
        }
    }
}
