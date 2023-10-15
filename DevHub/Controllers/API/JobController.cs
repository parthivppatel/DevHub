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

            int company_id = jobDto.company_id;
            var check_company_exist = _context.company.SingleOrDefault(c => c.id == company_id);
            if (check_company_exist == null)
                return BadRequest("Company Not Found");

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
            var job = _context.jobs.Where(c => c.id == id).AsEnumerable().Select(c => new JobDto
            {
                id = c.id,
                title=c.title,
                min_salary=c.min_salary,
                max_salary=c.max_salary,
                qualification=c.qualification,
                responsibilities=c.responsibilities,
                experience=c.experience,
                email=c.email,
                phone=c.phone,
                gender=c.gender,
                description=c.description,
                job_typeid=c.job_typeid,
                job_categoryids=c.job_categoryids,
                modeids=c.modeids,
                countryid=c.countryid,
                stateid=c.stateid,
                cityid=c.cityid,
                skillids=c.skillids,
                document = c.document != null ? Convert.ToBase64String(c.document) : null,
            }).SingleOrDefault();

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

        //[Authorize(Roles = "Admin,Company")]
        [Route("api/Job/GetCompanyJobs")]
        [HttpGet]
        public IHttpActionResult CompanyJobs(int id)
        {
            var companyJobs = _context.company_job
                         .Where(jm => jm.companyid == id)
                         .SelectMany(jm => _context.jobs.Where(j => j.id == jm.jobid))
                         .ToList().Select(job => Mapper.Map<JobModel, JobDto>(job));
            return Ok(companyJobs);
        }

    }
}
