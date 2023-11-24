using AutoMapper;
using DevHub.Dtos;
using DevHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevHub.Controllers.API
{
    public class CityController : ApiController
    {
        private ApplicationDbContext _context;
        public CityController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public IHttpActionResult GetCities(int id)
        {
            var cities = _context.city.Where(c => c.stateid == id).ToList();

            if (cities == null)
            {
                return NotFound();
            }
            var citieslist = Mapper.Map<List<CityDto>>(cities);
            return Ok(citieslist);
        }

        [Authorize]
        public IEnumerable<CityDto> GetCityWithFilter(string letter)
        {
            var citylist = _context.city;

            var filterlist =citylist.Where(word => word.cityname.ToLower().StartsWith(letter.ToLower())).ToList().Select(Mapper.Map<CityModel, CityDto>);
            return filterlist;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
    }
}
