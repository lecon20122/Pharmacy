using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Areas.Identity.Data;
using Pharmacy.Repository;

namespace Pharmacy.Controllers
{
    [Authorize(Policy = "IsPatient")]
    public class PatientController : Controller
    {
        private readonly IPets _pets;
        private readonly UserManager<PharmacyUser> _userManager;

        private int _userId => int.Parse(_userManager.GetUserId(User));

        public PatientController(IPets pets, UserManager<PharmacyUser> userManager)
        {
            _pets = pets;
            _userManager = userManager;
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
            return View();
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
