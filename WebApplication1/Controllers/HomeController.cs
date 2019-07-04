using Calpion.Artemis.Business;
using Calpion.Artemis.Business.Managers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IAccountManager _accountManager;
        //private readonly object accountManager;

        public HomeController(IAccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        //public HomeController()
        //{
        //}

        //public IActionResult Index()
        //{
        //    // _menuRepository.GetAll();
        //    var menu = _accountManager.GetAll();
        //    return View(menu);
        //}

        public IActionResult Index()
        {
            //return View("Views/Login/Index.cshtml");
            return View();
            //return View("Views/Home/LandingPage.cshtml");
        }


        public IActionResult NewPatientRegistration()
        {
            return View("Views/Home/NewPatientRegistration.cshtml");
        }
        public IActionResult PatientLookUp()
        {
            return View("Views/Home/PatientLookUp.cshtml");
        }

        public IActionResult Provider()
        {
            return View("Views/Home/Provider.cshtml");
        }
        public IActionResult ProviderAddress()
        {
            return View("Views/Home/ProviderAddress.cshtml");
        }
        public IActionResult ProviderID()
        {
            return View("Views/Home/ProviderID.cshtml");
        }
        public IActionResult Facility()
        {
            return View("Views/Home/Facility.cshtml");
        }

        public IActionResult NewFacilityRegistration()
        {
            return View("Views/Home/NewFacilityRegistration.cshtml");
        }

        public IActionResult InsuranceLookUp()
        {
            return View("Views/Home/InsuranceLookUp.cshtml");
        }
        public IActionResult Guarantor()
        {
            return View("Views/Home/Guarantor.cshtml");
        }
        public IActionResult NewGuarantorRegistration()
        {
            return View("Views/Home/NewGuarantorRegistration.cshtml");
        }

        public IActionResult NewInsuranceGroupRegistration()
        {
            return View("Views/Home/NewInsuranceGroupRegistration.cshtml");
        }

        public IActionResult Attorney()
        {
            return View("Views/Home/Attorney.cshtml");
        }
        public IActionResult InsuranceGroup()
        {
            return View("Views/Home/InsuranceGroup.cshtml");
        }

        public IActionResult AttorneyNewRegistration()
        {
            return View("Views/Home/AttorneyNewRegistration.cshtml");
        }

        public IActionResult Employer_LookUp()
        {
            return View("Views/Home/Employer_LookUp.cshtml");
        }


        public IActionResult EmployerNewRegistration()
        {
            return View("Views/Home/EmployerNewRegistration.cshtml");
        }

        public IActionResult Pharmacy()
        {
            return View("Views/Home/Pharmacy.cshtml");
        }
        public IActionResult NewPharmacyRegistration()
        {
            return View("Views/Home/NewPharmacyRegistration.cshtml");
        }
        public IActionResult Insurance()
        {
            return View("Views/Home/Insurance.cshtml");
        }

        public IActionResult GetSubMenu()
        {
            //_menuRepository.GetAllSubMenu();
            _accountManager.GetAllSubMenu();
            return View();
        }

        //public PatientDetails PatientDetailsRegistration()
        //{
        //    return accountManager.PatientDetailsRegistration();

        //}

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
