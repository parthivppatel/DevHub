using DevHub.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevHub.Controllers
{
    public class CandidateController : Controller
    {
        // GET: Candidate
        [CustomAuthorization("Admin", "Candidate")]
        public ActionResult Jobs()
        {
            return View();
        }

        [CustomAuthorization("Admin", "Candidate")]
        public ActionResult Resume()
        {
            return View();
        }
    }
}