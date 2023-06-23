using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Models;
using Pharmacy.Repository;

namespace Pharmacy.Controllers
{
    [Authorize(Policy = "IsDoctor")]
    public class DoctorController : Controller
    {
        private readonly IPets _pets;

        public DoctorController(IPets pets)
        {
            _pets = pets;
        }

        // GET: DoctorController
        public ActionResult<List<Pet>> Index(int? id, string? searchName)
        {
            var pets = _pets.GetAll(id, searchName);
            return View(pets);
        }

        // GET: DoctorController/Details/5
        public ActionResult<Pet?> Details(int id)
        {
            var pet = _pets.GetPet(id);
            if (pet is null)
            {
                return NotFound();
            }
            return View(pet);
        }

        // GET: DoctorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorController/Create
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

        // GET: DoctorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorController/Edit/5
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

        // GET: DoctorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoctorController/Delete/5
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
