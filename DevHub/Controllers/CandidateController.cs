using DevHub.Filters;
using DevHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;

namespace DevHub.Controllers
{
    public class CandidateController : Controller
    {
        private ApplicationDbContext _context;
        public CandidateController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Candidate
        [CustomAuthorization("Admin", "Candidate")]
        public ActionResult Jobs()
        {
            return View();
        }
        public ActionResult EditResume()
        {
            return View();
        }

        [CustomAuthorization("Admin", "Candidate")]
        public ActionResult Resume()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var userIdClaim = identity.FindFirst(ClaimTypes.NameIdentifier).Value;
            var check_candidate = _context.candidate.SingleOrDefault(c => c.UserId == userIdClaim);

            if (check_candidate == null)
                return View("Add_Resume");

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
    }
}