using DevHub.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http;

namespace DevHub.Controllers.API
{
    public class UserController : ApiController
    {
        private ApplicationDbContext _context;
        public UserController()
        {
            _context = new ApplicationDbContext();
        }

        [Route("api/userinfo")]
        [Authorize]
        public IHttpActionResult GetUserInfo()
        {
            var identity = HttpContext.Current.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userIdClaim = identity.FindFirst(ClaimTypes.NameIdentifier);
                var emailClaim = identity.FindFirst(ClaimTypes.Name);

                var roles = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().GetRoles(userIdClaim.Value);
                if (userIdClaim != null && emailClaim != null)
                {
                    var userId = userIdClaim.Value;
                    var email = emailClaim.Value;
                    // You have the current user's ID
                    return Ok(new { UserId = userId, email = email, Roles = roles });
                }
            }

            return BadRequest("User not found.");
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult DeleteAccount()
        {
            var userManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var identity = HttpContext.Current.User.Identity as ClaimsIdentity;
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication; // Get the AuthenticationManager

            if (identity != null)
            {
                var userIdClaim = identity.FindFirst(ClaimTypes.NameIdentifier);
                if (userIdClaim != null)
                {
                    var userId = userIdClaim.Value;
                    var user = userManager.FindById(userId);
                    if (user != null)
                    {
                        var result = userManager.Delete(user);
                        if (result.Succeeded)
                        {
                            authenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                            return Ok("User deleted successfully.");
                        }
                        else
                        {
                            return BadRequest("Error deleting user.");
                        }
                    }
                }

            }

            return BadRequest("User not found.");
        }

        [Route("api/summary")]
        [HttpGet]
        public IHttpActionResult Summary()
        {
            var jobs = _context.jobs.Count();
            var companies = _context.company.Count();
            var candidates = _context.candidate.Count();
            var applications = _context.candidate_job.Count();
           
            var result = new
            {
                jobs = jobs,
                companies = companies,
                resumes = candidates,
                applications = applications,
            };

            return Ok(result);

        }

        [Route("api/profile")]
        [HttpGet]
        public IHttpActionResult GetUserProfile()
        {
            Byte[] profile_photo = null;

            if (!User.Identity.IsAuthenticated)
            {

                var result = new
                {
                    profile = profile_photo,
                };

                return Ok(result);
            }
            else
            {
                var user_id = User.Identity.GetUserId();


                if (User.IsInRole("Candidate"))
                {
                    var check_candidate = _context.candidate.SingleOrDefault(c => c.UserId == user_id);
                    if (check_candidate != null)
                        profile_photo = check_candidate.image;

                }
                else if (User.IsInRole("Company"))
                {
                    var check_company = _context.company.SingleOrDefault(c => c.UserId == user_id);
                    if (check_company != null)
                        profile_photo = check_company.logo;
                }

                var result = new
                {
                    profile = profile_photo,
                };

                return Ok(result);
            }

        }


    }
}
