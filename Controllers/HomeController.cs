using Microsoft.AspNetCore.Mvc;
using Pharmacy.Models;
using Pharmacy.Types;
using System.Diagnostics;

namespace Pharmacy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (User.IsInRole(UserRoles.Nurse))
            {
                return RedirectToAction("Index", "Nurse");
            }

            if (User.IsInRole(UserRoles.Pharmacist))
            {
                return RedirectToAction("Index", "Pharmacists");
            }

            if (User.IsInRole(UserRoles.Doctor))
            {
                return RedirectToAction("Index", "Doctor");
            }

            if (User.IsInRole(UserRoles.Patient))
            {
                return RedirectToAction("Index", "Patient");
            }

            return View();
        }

        public IActionResult Help()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}