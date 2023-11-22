using DevHub.Filters;
using DevHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;
using System.Text;

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

        // GET: Candidate
        [CustomAuthorization("Admin", "Candidate")]
        public ActionResult AppliedJobs()
        {
            return View();
        }
        public ActionResult EditResume(string id)
        {
            int decodedId = 0;
            try
            {
                decodedId = Convert.ToInt32(Encoding.UTF8.GetString(Convert.FromBase64String(id)));
            }
            catch (Exception e)
            {
                return RedirectToAction("Resume", "Candidate");
            }
            ViewBag.Message = decodedId;
            return View();
        }

        [CustomAuthorization("Admin", "Candidate","Company")]
        public ActionResult Resume(string id=null)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var userIdClaim = identity.FindFirst(ClaimTypes.NameIdentifier).Value;
            var role = identity.FindFirst(ClaimTypes.Role).Value;

            if (role == "Candidate")
            {
                var check_candidate = _context.candidate.SingleOrDefault(c => c.UserId == userIdClaim);

                if (check_candidate == null)
                    return View("Add_Resume");

                ViewBag.Message = check_candidate.id;
            }
            else
            {
                if (id == null)
                    return RedirectToAction("ManageApplications", "Company");

                int decodedId = 0;
                try
                {
                    decodedId = Convert.ToInt32(Encoding.UTF8.GetString(Convert.FromBase64String(id)));
                }
                catch (Exception e)
                {
                    return RedirectToAction("ManageApplications", "Company");
                }
                ViewBag.Message = decodedId;
            }
            
            return View();

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
    }
}