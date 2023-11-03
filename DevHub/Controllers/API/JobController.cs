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
    public class JobController : ApiController
    {
        private ApplicationDbContext _context;

        public JobController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //[Authorize(Roles = "Admin,Candidate")]
        [Route("api/Job/GetJobTypes")]
        public IEnumerable<JobTypeDto> GetJobTypes()
        {
            var jobtypelist = _context.job_type.ToList().Select(Mapper.Map<JobTypeModel, JobTypeDto>);
            return jobtypelist;
        } 
        
        //[Authorize(Roles = "Admin,Candidate")]
        [Route("api/Job/GetJobCategories")]
        public IEnumerable<JobCategoryDto> GetJobCategories()
        {
            var jobcategorieslist = _context.job_category.ToList().Select(Mapper.Map<JobCategoryModel, JobCategoryDto>);
            return jobcategorieslist;
        }       
        
        //[Authorize(Roles = "Admin,Candidate")]
        [Route("api/Job/GetJobModes")]
        public IEnumerable<JobModeDto> GetJobModes()
        {
            var jobmodelist = _context.job_mode.ToList().Select(Mapper.Map<JobModeModel, JobModeDto>);
            return jobmodelist;
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
        //[Authorize(Roles = "Admin,Candidate")]
        public IHttpActionResult PostJob()
        {
            var HttpCtx = HttpContext.Current.Request;
            var identity = HttpContext.Current.User.Identity as ClaimsIdentity;
            var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            JobDto jobDto = null;
            HttpPostedFile document = null;
            foreach (string key in HttpCtx.Form.AllKeys)
            {
                string value = HttpCtx.Form[key];
                if (IsJson(value))
                {
                    // Deserialize the JSON string into your DTO object
                    JObject jsonObject = JsonConvert.DeserializeObject<JObject>(value);
                    if (jsonObject.ContainsKey("job_categoryids"))
                    {
                        jsonObject["job_categoryids"] = jsonObject["job_categoryids"].ToString();
                    }
                    if (jsonObject.ContainsKey("modeids"))
                    {
                        jsonObject["modeids"] = jsonObject["modeids"].ToString();
                    }
                    if (jsonObject.ContainsKey("skillids"))
                    {
                        jsonObject["skillids"] = jsonObject["skillids"].ToString();
                    }

                    jobDto = jsonObject.ToObject<JobDto>();
                }
            }
            if (jobDto == null)
                return BadRequest("Request is Invalid");

            var check_company_exist = _context.company.SingleOrDefault(c => c.UserId == userId);
            if (check_company_exist == null)
                return BadRequest("Company Not Found");

            int company_id = check_company_exist.id;

            var job = Mapper.Map<JobDto, JobModel>(jobDto);

            if (HttpCtx.Files.Count > 0)
            {
                foreach (string file in HttpCtx.Files)
                {
                    if (file.Equals("document"))
                        document = HttpCtx.Files[file];
                }
                string fileExtension = "";
                int documentsize = 3145728; //3 MB(int)
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png",".pdf", ".doc", ".docx" };
                if (document != null && document.ContentLength > 0)
                {
                    fileExtension = Path.GetExtension(document.FileName).ToLower();
                    if (Array.IndexOf(allowedExtensions, fileExtension) >= 0 && Array.IndexOf(allowedExtensions, fileExtension) < 3 && document.ContentLength <= documentsize)
                    {
                        // Get the file extension
                        Stream documentstream = document.InputStream;
                        BinaryReader documentbinaryReader = new BinaryReader(documentstream);
                        job.document = documentbinaryReader.ReadBytes((int)documentstream.Length);
                    }
                    else
                    {
                        return BadRequest("Dcoument should be in the format jpg/jpeg/png/pdf/doc/docx and less than 3 MB");
                    }
                }
            }

            job.created_at = DateTime.Now;
            var new_job=_context.jobs.Add(job);
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
            int job_id = new_job.id;

            var companyjobdto =new CompanyJobDto{
                companyid=company_id,
                jobid=job_id
            };

            var Companyjob = Mapper.Map<CompanyJobDto, CompanyJobMapper>(companyjobdto);

            _context.company_job.Add(Companyjob);
            _context.SaveChanges();

            return Ok("Job Added Successfully");
        }

        [HttpPut]
        //[Authorize(Roles = "Admin,Candidate")]
        public IHttpActionResult UpdateJob(int id)
        {
            var old_job = _context.jobs.SingleOrDefault(c => c.id == id);
            if (old_job == null)
                return BadRequest("Job Not Found");

            var HttpCtx = HttpContext.Current.Request;
            JobDto jobDto = null;
            HttpPostedFile document = null;
            foreach (string key in HttpCtx.Form.AllKeys)
            {
                string value = HttpCtx.Form[key];
                if (IsJson(value))
                {
                    // Deserialize the JSON string into your DTO object
                    JObject jsonObject = JsonConvert.DeserializeObject<JObject>(value);
                    if (jsonObject.ContainsKey("job_categoryids"))
                    {
                        jsonObject["job_categoryids"] = jsonObject["job_categoryids"].ToString();
                    }
                    if (jsonObject.ContainsKey("modeids"))
                    {
                        jsonObject["modeids"] = jsonObject["modeids"].ToString();
                    }
                    if (jsonObject.ContainsKey("skillids"))
                    {
                        jsonObject["skillids"] = jsonObject["skillids"].ToString();
                    }

                    jobDto = jsonObject.ToObject<JobDto>();
                }
            }

            if (jobDto == null)
                return BadRequest("Request is Invalid");

            var job = Mapper.Map(jobDto, old_job);

            if (HttpCtx.Files.Count > 0)
            {
                foreach (string file in HttpCtx.Files)
                {
                    if (file.Equals("document"))
                        document = HttpCtx.Files[file];
                }
                string fileExtension = "";
                int documentsize = 3145728; //3 MB(int)
                string[] allowedExtensions = { ".pdf", ".doc", ".docx" };
                if (document != null && document.ContentLength > 0)
                {
                    fileExtension = Path.GetExtension(document.FileName).ToLower();
                    if (Array.IndexOf(allowedExtensions, fileExtension) >= 0 && Array.IndexOf(allowedExtensions, fileExtension) < 3 && document.ContentLength <= documentsize)
                    {
                        // Get the file extension
                        Stream documentstream = document.InputStream;
                        BinaryReader documentbinaryReader = new BinaryReader(documentstream);
                        job.document = documentbinaryReader.ReadBytes((int)documentstream.Length);
                    }
                    else
                    {
                        return BadRequest("Dcoument should be in the format pdf/doc/docx and less than 3 MB");
                    }
                }
            }

            job.updated_at = DateTime.Now;
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

            return Ok("Job Updated Successfully");
        }

        //[Authorize(Roles = "Admin,Candidate")]
        public IHttpActionResult GetJob(int id)
        {
            var job = _context.jobs
            .Where(j => j.id == id)
             .AsEnumerable()
            .Join(_context.company_job,
                  j => j.id,
                  cj => cj.jobid,
                  (j, cj) => new { Job = j, CompanyJobMapper = cj })
            .Join(_context.company,
                  temp => temp.CompanyJobMapper.companyid,
                  c => c.id,
                  (temp, c) => new JobDto
                  {
                      id = temp.Job.id,
                      title = temp.Job.title,
                      min_salary = temp.Job.min_salary,
                      max_salary = temp.Job.max_salary,
                      qualification = temp.Job.qualification,
                      responsibilities = temp.Job.responsibilities,
                      experience = temp.Job.experience,
                      email = temp.Job.email,
                      phone = temp.Job.phone,
                      description = temp.Job.description,
                      job_typeid = temp.Job.job_typeid,
                      job_categoryids = temp.Job.job_categoryids,
                      modeids = temp.Job.modeids,
                      countryid = temp.Job.countryid,
                      stateid = temp.Job.stateid,
                      cityid = temp.Job.cityid,
                      skillids = temp.Job.skillids,
                      company_name = c.name,
                      company_address = c.address,
                      document = temp.Job.document != null ? Convert.ToBase64String(temp.Job.document) : null,

                  }).Select(j => Mapper.Map<JobDto>(j))
            .FirstOrDefault();

            if (job == null)
                return BadRequest("Job Not Found");

            var data = Mapper.Map<JobDto>(job);
            return Ok(data);
        }

        //[Authorize(Roles = "Admin,Company")]
        public IHttpActionResult GetJobs()
        {
            var joblist = _context.jobs.ToList().Select(Mapper.Map<JobModel, JobDto>);

            return Ok(joblist);
        }
    }
}
