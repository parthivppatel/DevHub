using AutoMapper;
using DevHub.Dtos;
using DevHub.Models;
using Microsoft.AspNet.Identity.Owin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
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
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png",".pdf", ".txt", ".docx" };
                if (document != null && document.ContentLength > 0)
                {
                    fileExtension = Path.GetExtension(document.FileName).ToLower();
                    if (Array.IndexOf(allowedExtensions, fileExtension) >= 0 && Array.IndexOf(allowedExtensions, fileExtension) < 6 && document.ContentLength <= documentsize)
                    {
                        // Get the file extension
                        Stream documentstream = document.InputStream;
                        BinaryReader documentbinaryReader = new BinaryReader(documentstream);
                        job.document = documentbinaryReader.ReadBytes((int)documentstream.Length);
                    }
                    else
                    {
                        return BadRequest("Dcoument should be in the format jpg/jpeg/png/pdf/txt/docx and less than 3 MB");
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
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".pdf", ".txt", ".docx" };
                if (document != null && document.ContentLength > 0)
                {
                    fileExtension = Path.GetExtension(document.FileName).ToLower();
                    if (Array.IndexOf(allowedExtensions, fileExtension) >= 0 && Array.IndexOf(allowedExtensions, fileExtension) < 6 && document.ContentLength <= documentsize)
                    {
                        // Get the file extension
                        Stream documentstream = document.InputStream;
                        BinaryReader documentbinaryReader = new BinaryReader(documentstream);
                        job.document = documentbinaryReader.ReadBytes((int)documentstream.Length);
                    }
                    else
                    {
                        return BadRequest("Dcoument should be in the format jpg/jpeg/png/pdf/txt/docx and less than 3 MB");
                    }
                }
            }

            _context.Entry(job).Property(x => x.created_at).IsModified = false;
            if (document == null)
                _context.Entry(job).Property(x => x.document).IsModified = false;

            System.Diagnostics.Debug.WriteLine(job.created_at,"created");
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
        [Route("api/Job/JobStatus")]
        public async Task<IHttpActionResult> ApproveRejectJob(int candidate_id,int job_id,string stage)
        {
            var candidate_job = _context.candidate_job;
            var temp= candidate_job.SingleOrDefault(cj => cj.jobid == job_id && cj.candidateid == candidate_id);
            temp.stage = stage;
            _context.SaveChanges();


            if (stage == "Approved")
            {

                var data = candidate_job
                .Join(_context.jobs,
                 cj => cj.jobid,
                 j => j.id,
                 (cj, j) => new { Job = j, CandidateJobMapper = cj })
                .Join(_context.company_job,
                 can_job => can_job.Job.id,
                 company_job => company_job.jobid,
                 (can_job, company_job) => new { can_job = can_job, com_job = company_job })
                .Join(_context.company,
                 mapper => mapper.com_job.companyid,
                 company => company.id,
                 (mapper, company) => new
                 {
                     title=mapper.can_job.Job.title,
                     name = company.name,
                     job_id= mapper.can_job.Job.id,
                     can_id=mapper.can_job.CandidateJobMapper.candidate.id,
                     user_id=mapper.can_job.CandidateJobMapper.candidate.UserId

                 }).Where(result => result.job_id == job_id && result.can_id == candidate_id).SingleOrDefault();

                var jobtitle = data.title;
                var userManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
                string userId = data.user_id;

                await userManager.SendEmailAsync(userId, "Job Application", "<p>Your Job Application for "+ jobtitle +" is Approved by "+ data.name +" </P>");


            }
            return Ok("Job "+ stage + " Succesfully");
        }
        
        [Authorize(Roles = "Admin,Candidate,Company")]
        [HttpGet]
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
                      stype=temp.Job.stype,
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
                      created_at=temp.Job.created_at,
                      company_logo = c.logo!=null?Convert.ToBase64String(c.logo):null,
                      document = temp.Job.document != null ? Convert.ToBase64String(temp.Job.document) : null,

                  }).Select(j => Mapper.Map<JobDto>(j))
            .FirstOrDefault();

            if (job == null)
                return BadRequest("Job Not Found");

            var city_name = _context.city.SingleOrDefault(C => C.id == job.cityid).cityname;
            job.city_name = city_name;
            var data = Mapper.Map<JobDto>(job);

            return Ok(data);
        }

        [Authorize(Roles = "Admin,Company,Candidate")]
        [HttpPost]
        [Route("api/Job/JobList")]
        public IHttpActionResult GetJobs(int start,int end, [FromBody] Dictionary<string, object> filter)
        {
            var identity = HttpContext.Current.User.Identity as ClaimsIdentity;
            var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var role = identity.FindFirst(ClaimTypes.Role).Value;

            if (role == "Candidate")
            {
                var candidate_id = _context.candidate.SingleOrDefault(c => c.UserId == userId).id;
                var query = _context.company_job
                         .Join(_context.jobs,
                         com_job => com_job.jobid,
                         j => j.id,
                         (com_job, j) => new { Job = j, comjobmapper = com_job })
                         .GroupJoin(_context.candidate_job,
                         company_job => company_job.Job.id,
                         candidate_job => candidate_job.jobid,
                         (company_job, candidate_job) => new { candidate_job = candidate_job, company_job = company_job })
                         .SelectMany(
                         x => x.candidate_job.DefaultIfEmpty(),
                         (x, candidate_job) => new { x.company_job, candidate_job })
                        .Where(r => (r.candidate_job.candidateid != candidate_id || r.candidate_job.stage == "Rejected") &&
                        r.candidate_job.stage != "Applied" && r.candidate_job.stage != "Approved");

                if (filter != null)
                {
                    if (filter.ContainsKey("jobtype") && filter["jobtype"].ToString() != "")
                    {
                        var jobtypeFilter = int.Parse(filter["jobtype"].ToString());
                        query = query.Where(r => r.company_job.comjobmapper.job.job_typeid == jobtypeFilter);
                    }
                    if (filter.ContainsKey("cityid") && filter["cityid"].ToString() != "")
                    {
                        var cityFilter = int.Parse(filter["cityid"].ToString());
                        query = query.Where(r => r.company_job.comjobmapper.job.cityid == cityFilter);
                    }
                    if (filter.ContainsKey("title") && filter["title"].ToString() != "")
                    {
                        var titleFilter = filter["title"].ToString().ToLower();
                        query = query.Where(r => r.company_job.comjobmapper.job.title.ToLower().Contains(titleFilter));
                    }
                }

                var totalRecords = query.Count();
                         
                var limitedRecords = query
                      .Join(
                         _context.city,
                         jm => jm.company_job.Job.cityid,
                         c => c.id,
                         (jm, c) => new
                         {
                             id = jm.company_job.Job.id,
                             title = jm.company_job.Job.title,
                             address = c.cityname, 
                             name = jm.company_job.comjobmapper.company.name,
                             company_id=jm.company_job.comjobmapper.company.id,
                             created_at = jm.company_job.Job.created_at,
                             JobType = _context.job_type.FirstOrDefault(j => j.id == jm.company_job.Job.job_typeid).name,
                             logo = jm.company_job.comjobmapper.company.logo 
                         }
                      )
                     .OrderByDescending(j => j.created_at)
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
            else
            {
                var query = _context.company_job.AsQueryable();
                
                if (filter != null)
                {
                    if (filter.ContainsKey("jobtype") && filter["jobtype"].ToString() != "")
                    {
                        var jobtypeFilter = int.Parse(filter["jobtype"].ToString());
                        query = query.Where(r => r.job.job_typeid == jobtypeFilter);
                    }
                    if (filter.ContainsKey("cityid") && filter["cityid"].ToString() != "")
                    {
                        var cityFilter = int.Parse(filter["cityid"].ToString());
                        query = query.Where(r => r.job.cityid == cityFilter);
                    }
                    if (filter.ContainsKey("title") && filter["title"].ToString() != "")
                    {
                        var titleFilter = filter["title"].ToString();
                        query = query.Where(r => r.job.title.Contains(titleFilter));
                    }
                }

                var totalRecords = query.Count();

                var limitedRecords = query
                      .Join(
                         _context.city,
                         jm => jm.job.cityid,
                         c => c.id,
                         (jm, c) => new
                         {
                             id = jm.job.id,
                             title = jm.job.title,
                             address = c.cityname, 
                             name = jm.company.name,
                             company_id = jm.company.id,
                             created_at = jm.job.created_at,
                             JobType = _context.job_type.FirstOrDefault(j => j.id == jm.job.job_typeid).name,
                             logo = jm.company.logo
                         }
                      )
                     .OrderByDescending(j => j.created_at)
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
        }

        [HttpDelete]
        //[Authorize(Roles = "Admin,Company")]
        public IHttpActionResult DeleteJob(int id)
        {
            var job = _context.jobs.SingleOrDefault(c=>c.id==id);
            _context.jobs.Remove(job);
            _context.SaveChanges();

            return Ok("Job Deleted Succesfully");
        }
    }
}
