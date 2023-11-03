using DevHub.Filters;
using DevHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace DevHub.Controllers
{
    public class CompanyController : Controller
    {
        private ApplicationDbContext _context;
        public CompanyController()
        {
            _context = new ApplicationDbContext();
        }

        private bool CheckCompanyExist()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var userIdClaim = identity.FindFirst(ClaimTypes.NameIdentifier).Value;
            var check_company = _context.company.SingleOrDefault(c => c.UserId == userIdClaim);

            if (check_company == null)
                return false;

            return true;
        }
        // GET: Company
        [CustomAuthorization("Admin", "Company")]
        public ActionResult PostJob()
        {
            if (CheckCompanyExist() == false)
            {
                ViewBag.Message = "Please Create Company First";
                return View("Add_Company");
            }

            return View();
        }
        [CustomAuthorization("Admin", "Company")]
        public ActionResult ManageJobs()
        {
            if (CheckCompanyExist() == false)
            {
                ViewBag.Message = "Please Create Company First";
                return View("Add_Company");
            }

            return View();
        }
        [CustomAuthorization("Admin", "Company")]
        public ActionResult ManageApplications()
        {
            if (CheckCompanyExist() == false)
            {
                ViewBag.Message = "Please Create Company First";
                return View("Add_Company");
            }

            return View();
        }
        
        [CustomAuthorization("Admin", "Company")]
        public ActionResult EditCompanyDetails()
        {
            if (CheckCompanyExist() == false)
            {
                ViewBag.Message = "Please Create Company First";
                return View("Add_Company");
            }

            return View();
        }
        
        [CustomAuthorization("Admin", "Company")]
        public ActionResult CompanyProfile()
        {
            if (CheckCompanyExist() == false)
            {
                ViewBag.Message = "Please Create Company First";
                return View("Add_Company");
            }

            return View();
        }
    }
}