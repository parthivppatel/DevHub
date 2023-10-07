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

            return BadRequest("User ID not found.");
        }
    }
}
