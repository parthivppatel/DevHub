using AutoMapper;
using DevHub.Dtos;
using DevHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevHub.Controllers.API
{
    public class StateController : ApiController
    {
        ApplicationDbContext _context;
        public StateController()
        {
            _context = new ApplicationDbContext();
        }
        public IHttpActionResult GetStates(int id)
        {
            var states = _context.state.Where(c => c.countryid == id).ToList();

            if (states == null)
            {
                return NotFound();
            }
            var stateslist = Mapper.Map<List<StateDto>>(states);
            return Ok(stateslist);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
    }
}
