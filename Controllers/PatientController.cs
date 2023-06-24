using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Areas.Identity.Data;
using Pharmacy.Data;
using Pharmacy.Repository;

namespace Pharmacy.Controllers
{
    [Authorize(Policy = "IsPatient")]
    public class PatientController : Controller
    {
        private readonly IPets _pets;
        private readonly UserManager<PharmacyUser> _userManager;
        private readonly ApplicationDbContext _context;

        private int _userId => int.Parse(_userManager.GetUserId(User));

        public PatientController(IPets pets, UserManager<PharmacyUser> userManager, ApplicationDbContext context)
        {
            _pets = pets;
            _userManager = userManager;
            _context = context;
        }

        // GET: PatientController
        public ActionResult Index(int? id, string? searchName)
        {
            var pets = _pets.GetUserPets(id, searchName, _userId);
            return View(pets);
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            var pet = _pets.GetPet(id);

            if (pet is null) return NotFound();

            return View(pet);
        }

        public ActionResult Appointments()
        {
            var patientPets = _pets.GetUserPets(null, null, _userId);

            var Ids = patientPets.Select(p => p.Id).ToList();

            var appointments = _context.Appointment.Where(a => Ids.Contains(a.Id)).ToList();

            if (appointments is null) return NotFound();

            return View(appointments);
        }
    }
}
