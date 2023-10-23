using DevHub.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevHub.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        [CustomAuthorization("Admin", "Company")]
        public ActionResult PostJob()
        {
            return View();
        }
        [CustomAuthorization("Admin", "Company")]
        public ActionResult ManageJobs()
        {
            return View();
        }
        [CustomAuthorization("Admin", "Company")]
        public ActionResult ManageApplications()
        {
            return View();
        }
    }
}