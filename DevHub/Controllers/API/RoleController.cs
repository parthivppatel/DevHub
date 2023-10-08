using DevHub.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace DevHub.Controllers.API
{
    public class RoleController : ApiController
    {
        private ApplicationDbContext _context;
        public RoleController()
        {
            _context = new ApplicationDbContext();
        }

        //Roles List
        [HttpGet]
        [Route("api/GetRoles")]
        public IHttpActionResult GetAllRoles()
        {
            var roleStore = new RoleStore<IdentityRole>(_context);
            var roleMngr = new RoleManager<IdentityRole>(roleStore);

            var roles = roleMngr.Roles.Select(role => new
            {
                RoleId = role.Id,
                RoleName = role.Name
            }).ToList();

            return Ok(roles);
        } 
        
        //Roles information with the respective users
        //[HttpGet]
        //[Route("api/GetRolesAndUsers")]
        //public IHttpActionResult GetRolesWithUsers()
        //{
        //    var roleStore = new RoleStore<IdentityRole>(_context);
        //    var roleMngr = new RoleManager<IdentityRole>(roleStore);

        //    var roles = roleMngr.Roles.ToList();
            
        //    return Ok(roles);
        //}

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
    }
}

