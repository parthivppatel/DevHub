using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DevHub.Models;
using DevHub.Dtos;
using System.Web.Http;
using AutoMapper;

namespace DevHub.Controllers.API
{
    public class SkillsController : ApiController
    {
        private ApplicationDbContext _context;

        public SkillsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET Skills
        [Authorize(Roles = "Admin,Candidate,Company")]
        public IEnumerable<SkillsDto> GetSkills()
        {
            var skillsList = _context.SkillsTable.ToList().Select(Mapper.Map<SkillsModel,SkillsDto>);
            return skillsList;
        }
    }
}
