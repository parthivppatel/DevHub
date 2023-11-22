using DevHub.Filters;
using DevHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
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
        public ActionResult EditCompanyDetails(string id)
        {
            if (CheckCompanyExist() == false)
            {
                ViewBag.Message = "Please Create Company First";
                return View("Add_Company");
            }

            int decodedId = 0;
            try
            {
                decodedId = Convert.ToInt32(Encoding.UTF8.GetString(Convert.FromBase64String(id)));
            }
            catch (Exception e)
            {
                return RedirectToAction("CompanyProfile", "Company");
            }
            ViewBag.Message = decodedId;

            return View();
        }

        [CustomAuthorization("Admin", "Company","Candidate")]

        public ActionResult JobDetails(int id)
        {
         
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var userIdClaim = identity.FindFirst(ClaimTypes.NameIdentifier).Value;
            var role = identity.FindFirst(ClaimTypes.Role).Value;

            if (role == "Company")
            {
                var company = _context.company.SingleOrDefault(c => c.UserId == userIdClaim);

                var check = _context.company_job.SingleOrDefault(c => c.companyid == company.id && c.jobid == id);
                if (check == null)
                {
                    return View("ManageJobs");// Redirect to unauthorized page
                }

            }

            ViewBag.message = new { id = id, showbtn = true };
            return View();
        }
        
        [CustomAuthorization("Admin", "Company","Candidate")]

        public ActionResult CandidateJobDetails(int id)
        {
         
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var userIdClaim = identity.FindFirst(ClaimTypes.NameIdentifier).Value;
            var role = identity.FindFirst(ClaimTypes.Role).Value;

            if (role == "Company")
            {
                var company = _context.company.SingleOrDefault(c => c.UserId == userIdClaim);

                var check = _context.company_job.SingleOrDefault(c => c.companyid == company.id && c.jobid == id);
                if (check == null)
                {
                    return View("ManageJobs");// Redirect to unauthorized page
                }

            }


            ViewBag.message = new { id = id, showbtn = false };
            return View("JobDetails");
        }

        [CustomAuthorization("Admin", "Company")]

        public ActionResult EditJob(string jobId)
        {
            if (CheckCompanyExist() == false)
            {
                ViewBag.Message = "Please Create Company First";
                return View("Add_Company");
            }

            int decodedId = 0;
            try
            {
                decodedId = Convert.ToInt32(Encoding.UTF8.GetString(Convert.FromBase64String(jobId)));
            }
            catch (Exception e)
            {
                return RedirectToAction("ManageJobs", "Company");
            }

            //var identity = HttpContext.User.Identity as ClaimsIdentity;
            //var userIdClaim = identity.FindFirst(ClaimTypes.NameIdentifier).Value;
            //var company = _context.company.SingleOrDefault(c => c.UserId == userIdClaim);

            //var check = _context.company_job.SingleOrDefault(c => c.companyid == company.id && c.jobid == decodedId);
            //if (check == null)
            //{
            //    return View("ManageJobs");// Redirect to unauthorized page
            //}

            ViewBag.message = decodedId;
            return View();
        }

        [CustomAuthorization("Admin", "Company","Candidate")]
        public ActionResult CompanyProfile(string id=null)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var userIdClaim = identity.FindFirst(ClaimTypes.NameIdentifier).Value;
            var role = identity.FindFirst(ClaimTypes.Role).Value;

            if (role == "Company")
            {
                var company_id = _context.company.SingleOrDefault(c => c.UserId == userIdClaim).id;
                if (CheckCompanyExist() == false)
                {
                    ViewBag.Message = "Please Create Company First";
                    return View("Add_Company");
                }

                ViewBag.Message = company_id;
            }
            else
            {
                if (id == null)
                    return RedirectToAction("Jobs", "Candidate");

                int decodedId = 0;
                try
                {
                   decodedId = Convert.ToInt32(Encoding.UTF8.GetString(Convert.FromBase64String(id)));
                }
                catch (Exception e)
                {
                    return RedirectToAction("Jobs", "Candidate");
                }
                ViewBag.Message = decodedId;
            }

            return View();
        }
    }
}