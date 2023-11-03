using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace DevHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult UserProfile()
        {
            var roleClaim = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Role);
            var role = roleClaim.Value;

            if (role == "Candidate")
                return RedirectToAction("Resume", "Candidate");

            return RedirectToAction("CompanyProfile", "Company");

        }
    }
}