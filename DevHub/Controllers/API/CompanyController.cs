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
using System.Security.Claims;
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
        [Authorize(Roles = "Admin,Company")]
        public IHttpActionResult PostCompany()
        {
            var HttpCtx = HttpContext.Current.Request;
            var identity = HttpContext.Current.User.Identity as ClaimsIdentity;
            var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            CompanyDto companydto = null;
            HttpPostedFile logo = null;
            foreach (string key in HttpCtx.Form.AllKeys)
            {
                string value = HttpCtx.Form[key];
                if (IsJson(value))
                {
                    companydto = JsonConvert.DeserializeObject<CompanyDto>(value);
                }
                
            }
            if (companydto == null)
                return BadRequest("Request is Invalid");

           companydto.UserId = userId;
           var company=Mapper.Map<CompanyDto, CompanyModel>(companydto);
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
        [Authorize(Roles = "Admin,Company")]
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
            if (logo == null)
                _context.Entry(company).Property(x => x.logo).IsModified = false;

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

        [Authorize(Roles = "Admin,Company,Candidate")]
        [Route("api/Company/CompanyDetails")]

        public IHttpActionResult GetCompany(int id)
        {
            //var identity = HttpContext.Current.User.Identity as ClaimsIdentity;
            //var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var company = _context.company.Where(c => c.id == id).AsEnumerable().Select(c => new CompanyDto
            {
                id=c.id,
                name=c.name,
                overview=c.overview,
                services=c.services,
                website=c.website,
                countryid = c.countryid,
                stateid = c.stateid,
                cityid = c.cityid,
                phone = c.phone,
                email = c.email,
                people=c.people,
                address = c.address,
                linkedin =c.linkedin,
                twitter =c.twitter,
                instagram =c.instagram,
                facebook =c.facebook,
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
                services = c.services,
                website = c.website,
                countryid = c.countryid,
                stateid = c.stateid,
                cityid = c.cityid,
                people=c.people,
                phone = c.phone,
                email = c.email,
                address = c.address,
                linkedin = c.linkedin,
                twitter = c.twitter,
                instagram = c.instagram,
                facebook = c.facebook,
                UserId = c.UserId,
                logo = c.logo != null ? Convert.ToBase64String(c.logo) : null,
            });

            var data = Mapper.Map<IEnumerable<CompanyDto>>(companylist);
            return Ok(data);
        }

        //[Authorize(Roles = "Admin,Company")]
        // [Route("api/Company/GetCompanies")]
        // [HttpGet]
        // public IHttpActionResult GetCompanyNames()
        // {
        //     var companylist = _context.company.ToList().Select(c => new
        //     {
        //         id = c.id,
        //         name = c.name,
        //     });

        //     return Ok(companylist);
        // }
        
        //[Authorize(Roles = "Admin,Company")]
        [Route("api/Company/GetCompanyJobs")]
        [HttpPost]
        public IHttpActionResult CompanyJobs(int start,int end, [FromBody] Dictionary<string, object> filter)
        {
            var identity = HttpContext.Current.User.Identity as ClaimsIdentity;
            var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var query = _context.company_job
                    .Where(jm => jm.company.UserId == userId);

            if (filter != null)
            {
                if (filter.ContainsKey("jobtype") && filter["jobtype"].ToString() != "")
                {
                    var jobtypeFilter = int.Parse(filter["jobtype"].ToString());
                    query = query.Where(r => r.job.job_typeid == jobtypeFilter);
                }
                if (filter.ContainsKey("title") && filter["title"].ToString() != "")
                {
                    var titleFilter = filter["title"].ToString().ToLower();
                    query = query.Where(r => r.job.title.ToLower().Contains(titleFilter));
                }
            }

            query = query.OrderByDescending(jm => jm.job.created_at);

            var totalRecords = query.Count();

            var limitedRecords = query
                .Select(jm => new
                {
                    id=jm.job.id,
                    title = jm.job.title,
                    address = jm.job.city.cityname,
                    name = jm.company.name,
                    created_at = jm.job.created_at,
                    JobType = _context.job_type.FirstOrDefault(j => j.id == jm.job.job_typeid).name,
                    logo = jm.company.logo,
                })
                .Skip(start)
                .Take(end - start)
                .ToList();


            var result = new
            {
                TotalRecords = totalRecords,
                data = limitedRecords
            };

            return Ok(result);
        }
        
        //[Authorize(Roles = "Admin,Company")]
        [Route("api/Company/GetCompanyApplications")]
        [HttpPost]
        public IHttpActionResult CompanyApplications(int start,int end, [FromBody] Dictionary<string, object> filter)
        {
            var identity = HttpContext.Current.User.Identity as ClaimsIdentity;
            var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var query = _context.company_job
                         .Join(_context.jobs,
                         com_job => com_job.jobid,
                         j => j.id,
                         (com_job, j) => new { Job = j, comjobmapper = com_job })
                         .Join(_context.candidate_job,
                         company_job => company_job.Job.id,
                         candidate_job => candidate_job.jobid,
                         (company_job, candidate_job) => new { candidate_job = candidate_job, company_job = company_job })
                    .Where(r => r.company_job.comjobmapper.company.UserId == userId); 

            if (filter != null)
            {
                if (filter.ContainsKey("stage") && filter["stage"].ToString()!="All")
                {
                    var stageFilter = filter["stage"].ToString();
                    query=query.Where(r => r.candidate_job.stage == stageFilter);
                }
                if (filter.ContainsKey("jobtype") && filter["jobtype"].ToString()!="")
                {
                    var jobtypeFilter = int.Parse(filter["jobtype"].ToString());
                    query=query.Where(r => r.candidate_job.job.job_typeid == jobtypeFilter);
                }
                if (filter.ContainsKey("title") && filter["title"].ToString()!="")
                {
                    var titleFilter = filter["title"].ToString().ToLower();
                    query=query.Where(r => r.candidate_job.job.title.ToLower().Contains(titleFilter));
                }
            }

            query = query.OrderBy(jm => jm.candidate_job.stage);

            var totalRecords = query.Count();

            var limitedRecords = query
                .Select(jm => new
                {
                    id=jm.company_job.Job.id,
                    title = jm.company_job.Job.title,
                    candidate_id=jm.candidate_job.candidate.id,
                    candidate_name = (jm.candidate_job.candidate.first_name+" "+jm.candidate_job.candidate.surname),
                    company_name = jm.company_job.comjobmapper.company.name,
                    stage = jm.candidate_job.stage,
                    created_at = jm.candidate_job.created_at,
                    JobType = _context.job_type.FirstOrDefault(j => j.id == jm.company_job.Job.job_typeid).name,
                    profile =jm.candidate_job.candidate.image,

                })
                .Skip(start)
                .Take(end - start)
                .ToList();

            var result = new
            {
                TotalRecords = totalRecords,
                data = limitedRecords
            };

            return Ok(result);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
    }
}
