using AutoMapper;
using DevHub.Dtos;
using DevHub.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace DevHub.Controllers.API
{
    public class CompanyController : ApiController
    {
        private ApplicationDbContext _context;

        public CompanyController()
        {
            _context = new ApplicationDbContext();
        }
        bool IsJson(string value)
        {
            try
            {
                JToken.Parse(value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost]
        //[Authorize(Roles = "Admin,Company")]
        public IHttpActionResult PostCompany()
        {
            var HttpCtx = HttpContext.Current.Request;
            CompanyDto companydto = null;
            HttpPostedFile logo = null;
            foreach (string key in HttpCtx.Form.AllKeys)
            {
                string value = HttpCtx.Form[key];
                if (IsJson(value))
                    companydto = JsonConvert.DeserializeObject<CompanyDto>(value);
                
            }
            if (companydto == null)
                return BadRequest("Request is Invalid");

            var company = Mapper.Map<CompanyDto, CompanyModel>(companydto);
            var check_company_exist = _context.company.SingleOrDefault(c => c.UserId.Equals(company.UserId));
            
            if (check_company_exist != null)
                return BadRequest("Company Profile Already Created");

            var checked_user_candidate = _context.candidate.SingleOrDefault(c => c.UserId.Equals(company.UserId));
            if (checked_user_candidate != null)
                return BadRequest("You are Candidate So Cannot Add Company Profile");

            if (HttpCtx.Files.Count > 0)
            {
                foreach (string file in HttpCtx.Files)
                {
                    if (file.Equals("logo"))
                        logo = HttpCtx.Files[file];
                }
                string fileExtension = "";
                int imageSize = 1048576; //1 MB(int)
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png"};
                if (logo != null && logo.ContentLength > 0)
                {
                    fileExtension = Path.GetExtension(logo.FileName).ToLower();
                    if (Array.IndexOf(allowedExtensions, fileExtension) >= 0 && Array.IndexOf(allowedExtensions, fileExtension) < 3 && logo.ContentLength <= imageSize)
                    {
                        // Get the file extension
                        Stream imagestream = logo.InputStream;
                        BinaryReader imagebinaryReader = new BinaryReader(imagestream);
                        company.logo = imagebinaryReader.ReadBytes((int)imagestream.Length);
                    }
                    else
                    {
                        return BadRequest("Logo should be in the format jpg/jpeg/png and less than 1 MB");
                    }
                }
            }

            company.created_at = DateTime.Now;
            _context.company.Add(company);
            try
            {
                _context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                       .SelectMany(entityValidationErrors => entityValidationErrors.ValidationErrors)
                       .Select(validationError => validationError.ErrorMessage);

                foreach (var errorMessage in errorMessages)
                {
                    return BadRequest($"{errorMessage}");
                }

            }

            return Ok("Company Added Successfully");
        }

        [HttpPut]
        //[Authorize(Roles = "Admin,Company")]
        public IHttpActionResult UpdateCompany(int id)
        {
            var old_company = _context.company.SingleOrDefault(c => c.id == id);
            if (old_company == null)
                return BadRequest("Company Not Found");

            var HttpCtx = HttpContext.Current.Request;
            CompanyDto companydto = null;
            HttpPostedFile logo = null;
            foreach (string key in HttpCtx.Form.AllKeys)
            {
                string value = HttpCtx.Form[key];
                if (IsJson(value))
                    companydto = JsonConvert.DeserializeObject<CompanyDto>(value);
            }

            if (companydto == null)
                return BadRequest("Request is Invalid");

            if (!old_company.UserId.Equals(companydto.UserId))
                return BadRequest("User Id Can't be Changed");

            var company = Mapper.Map(companydto, old_company);

            if (HttpCtx.Files.Count > 0)
            {
                foreach (string file in HttpCtx.Files)
                {
                    if (file.Equals("logo"))
                        logo = HttpCtx.Files[file];
                }
                string fileExtension = "";
                int imageSize = 1048576; //1 MB(int)
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png"};
                if (logo != null && logo.ContentLength > 0)
                {
                    fileExtension = Path.GetExtension(logo.FileName).ToLower();
                    if (Array.IndexOf(allowedExtensions, fileExtension) >= 0 && Array.IndexOf(allowedExtensions, fileExtension) < 3 && logo.ContentLength <= imageSize)
                    {
                        // Get the file extension
                        Stream imagestream = logo.InputStream;
                        BinaryReader imagebinaryReader = new BinaryReader(imagestream);
                        company.logo = imagebinaryReader.ReadBytes((int)imagestream.Length);
                    }
                    else
                    {
                        return BadRequest("Logo should be in the format jpg/jpeg/png and less than 1 MB");
                    }
                }
            }

            company.updated_at = DateTime.Now;
            try
            {
                _context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                       .SelectMany(entityValidationErrors => entityValidationErrors.ValidationErrors)
                       .Select(validationError => validationError.ErrorMessage);

                foreach (var errorMessage in errorMessages)
                {
                    return BadRequest($"{errorMessage}");
                }

            }

            return Ok("Company Updated Successfully");
        }

        //[Authorize(Roles = "Admin,Company")]
        public IHttpActionResult GetCompany(int id)
        {
            var company = _context.company.Where(c => c.id == id).AsEnumerable().Select(c => new CompanyDto
            {
                id=c.id,
                name=c.name,
                overview=c.overview,
                service=c.service,
                website=c.website,
                countryid = c.countryid,
                stateid = c.stateid,
                cityid = c.cityid,
                phone = c.phone,
                email = c.email,
                address = c.address,
                UserId=c.UserId,
                logo = c.logo != null ? Convert.ToBase64String(c.logo) : null,
            }).SingleOrDefault();

            if (company == null)
                return BadRequest("Company Not Found");

            var data = Mapper.Map<CompanyDto>(company);
            return Ok(data);
        }
        
        //[Authorize(Roles = "Admin")]
        public IHttpActionResult GetCompanies()
        {
            var companylist = _context.company.ToList().Select(c => new CompanyDto
            {
                id = c.id,
                name = c.name,
                overview = c.overview,
                service = c.service,
                website = c.website,
                countryid = c.countryid,
                stateid = c.stateid,
                cityid = c.cityid,
                phone = c.phone,
                email = c.email,
                address = c.address,
                UserId = c.UserId,
                logo = c.logo != null ? Convert.ToBase64String(c.logo) : null,
            });

            var data = Mapper.Map<IEnumerable<CompanyDto>>(companylist);
            return Ok(data);
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
    }
}
