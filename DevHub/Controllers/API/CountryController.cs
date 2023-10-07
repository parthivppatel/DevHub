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
    public class CountryController : ApiController
    {
        ApplicationDbContext _context;
        public CountryController()
        {
            _context = new ApplicationDbContext();
        }
        public IEnumerable<CountryDto> GetCountries()
        {
            var countrieslist = _context.country.ToList().Select(Mapper.Map<CountryModel, CountryDto>);
            return countrieslist;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
    }
}
