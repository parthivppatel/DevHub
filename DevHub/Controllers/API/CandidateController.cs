﻿using AutoMapper;
using DevHub.Dtos;
using DevHub.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;

namespace DevHub.Controllers.API
{
    public class CandidateController : ApiController
    {
        private ApplicationDbContext _context;

        public CandidateController()
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
        [Authorize(Roles = "Admin,Candidate")]
        public IHttpActionResult PostCandidate()
        {
            var HttpCtx = HttpContext.Current.Request;
            var identity = HttpContext.Current.User.Identity as ClaimsIdentity;
            var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            CandidateDto candidateDto = null;
            HttpPostedFile image = null;
            foreach (string key in HttpCtx.Form.AllKeys)
            {
                string value = HttpCtx.Form[key];
                if (IsJson(value))
                {
                    // Deserialize the JSON string into your DTO object
                    JObject jsonObject = JsonConvert.DeserializeObject<JObject>(value);
                    if (jsonObject.ContainsKey("education"))
                    {
                        jsonObject["education"] = jsonObject["education"].ToString();
                    }
                    if (jsonObject.ContainsKey("experience"))
                    {
                        jsonObject["experience"] = jsonObject["experience"].ToString();
                    }
                    if (jsonObject.ContainsKey("project"))
                    {
                        jsonObject["project"] = jsonObject["project"].ToString();
                    }
                    if (jsonObject.ContainsKey("skillids"))
                    {
                        jsonObject["skillids"] = jsonObject["skillids"].ToString();
                    }

                    candidateDto = jsonObject.ToObject<CandidateDto>();
                    //candidateDto = JsonConvert.DeserializeObject<CandidateDto>(value);
                }
            }
            if (candidateDto == null)
                return BadRequest("Request is Invalid");

            candidateDto.UserId = userId;
            var candidate = Mapper.Map<CandidateDto, CandidateModel>(candidateDto);
            var check_candidate_exist = _context.candidate.SingleOrDefault(c => c.UserId == candidate.UserId);
            if (check_candidate_exist != null)
                return BadRequest("Candidate Profile Already Created");

            if (HttpCtx.Files.Count > 0)
            {
                foreach (string file in HttpCtx.Files)
                {
                    if (file.Equals("image"))
                        image = HttpCtx.Files[file];

                }
                string fileExtension = "";
                int imageSize = 1048576; //1 MB(int)
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png" };
                if (image != null && image.ContentLength > 0)
                {
                    fileExtension = Path.GetExtension(image.FileName).ToLower();
                    if (Array.IndexOf(allowedExtensions, fileExtension) >= 0 && Array.IndexOf(allowedExtensions, fileExtension) < 3 && image.ContentLength <= imageSize)
                    {
                        // Get the file extension
                        Stream imagestream = image.InputStream;
                        BinaryReader imagebinaryReader = new BinaryReader(imagestream);
                        candidate.image = imagebinaryReader.ReadBytes((int)imagestream.Length);
                    }
                    else
                    {
                        return BadRequest("image should be in the format jpg/jpeg/png and less than 1 MB");
                    }
                }
            }

            candidate.created_at = DateTime.Now;
            _context.candidate.Add(candidate);
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

            return Ok("Candidate Added Successfully");
        }

        [HttpPut]
        [Authorize(Roles = "Admin,Candidate")]
        public IHttpActionResult UpdateCandidate(int id)
        {
            var old_candidate = _context.candidate.SingleOrDefault(c => c.id == id);
            if (old_candidate == null)
                return BadRequest("Candidate Not Found");

            var HttpCtx = HttpContext.Current.Request;
            CandidateDto candidateDto = null;
            HttpPostedFile image = null;
            foreach (string key in HttpCtx.Form.AllKeys)
            {
                string value = HttpCtx.Form[key];
                if (IsJson(value))
                {
                    // Deserialize the JSON string into your DTO object
                    JObject jsonObject = JsonConvert.DeserializeObject<JObject>(value);
                    if (jsonObject.ContainsKey("education"))
                    {
                        jsonObject["education"] = jsonObject["education"].ToString();
                    }
                    if (jsonObject.ContainsKey("experience"))
                    {
                        jsonObject["experience"] = jsonObject["experience"].ToString();
                    }
                    if (jsonObject.ContainsKey("project"))
                    {
                        jsonObject["project"] = jsonObject["project"].ToString();
                    }
                    if (jsonObject.ContainsKey("skillids"))
                    {
                        jsonObject["skillids"] = jsonObject["skillids"].ToString();
                    }

                    candidateDto = jsonObject.ToObject<CandidateDto>();
                    //candidateDto = JsonConvert.DeserializeObject<CandidateDto>(value);
                }
            }

            if (candidateDto == null)
                return BadRequest("Request is Invalid");

            if (!old_candidate.UserId.Equals(candidateDto.UserId))
                return BadRequest("User Id Can't be Changed");

            var candidate = Mapper.Map(candidateDto, old_candidate);
            System.Diagnostics.Debug.WriteLine(candidate.image, "image field");
            if (HttpCtx.Files.Count > 0)
            {
                System.Diagnostics.Debug.WriteLine("Enter");

                foreach (string file in HttpCtx.Files)
                {
                    if (file.Equals("image"))
                        image = HttpCtx.Files[file];

                }
                string fileExtension = "";
                int imageSize = 1048576; //1 MB(int)
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png"};
                if (image != null && image.ContentLength > 0)
                {
                    fileExtension = Path.GetExtension(image.FileName).ToLower();
                    if (Array.IndexOf(allowedExtensions, fileExtension) >= 0 && Array.IndexOf(allowedExtensions, fileExtension) < 3 && image.ContentLength <= imageSize)
                    {
                        // Get the file extension
                        Stream imagestream = image.InputStream;
                        BinaryReader imagebinaryReader = new BinaryReader(imagestream);
                        candidate.image = imagebinaryReader.ReadBytes((int)imagestream.Length);
                    }
                    else
                    {
                        return BadRequest("image should be in the format jpg/jpeg/png and less than 1 MB");
                    }
                }
            }
            if(image==null)
                _context.Entry(candidate).Property(x => x.image).IsModified = false;


            candidate.updated_at = DateTime.Now;
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

            return Ok("Candidate Updated Successfully");
        }

        [Authorize(Roles = "Admin,Candidate")]
        [Route("api/Candidate/CandidateDetails")]
        public IHttpActionResult GetCandidate()
        {
            var identity = HttpContext.Current.User.Identity as ClaimsIdentity;
            var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var candidate = _context.candidate.Where(c => c.UserId == userId).AsEnumerable().Select(c => new CandidateDto
            {
                id = c.id,
                first_name = c.first_name,
                middle_name = c.middle_name,
                surname = c.surname,
                dob = c.dob,
                gender = c.gender,
                countryid = c.countryid,
                stateid = c.stateid,
                cityid = c.cityid,
                phone = c.phone,
                email = c.email,
                portfolio_website = c.portfolio_website,
                address = c.address,
                about_me = c.about_me,
                education = c.education,
                experience = c.experience,
                project=c.project,
                skillids = c.skillids,
                linkedin = c.linkedin,
                facebook = c.facebook,
                instagram=c.instagram,
                twitter=c.twitter,
                UserId = c.UserId,
                title = c.title,
                image = c.image != null ? Convert.ToBase64String(c.image) : null,
            }).SingleOrDefault();

            if (candidate == null)
                return BadRequest("Candidate Not Found");

            var data = Mapper.Map<CandidateDto>(candidate);
            return Ok(data);
        }

        //[Authorize(Roles = "Admin,Company")]
        public IHttpActionResult GetCandidates()
        {
            var candidatelist = _context.candidate.ToList().Select(c => new CandidateDto
            {
                id = c.id,
                first_name = c.first_name,
                middle_name = c.middle_name,
                surname = c.surname,
                dob = c.dob,
                gender = c.gender,
                countryid = c.countryid,
                stateid = c.stateid,
                cityid = c.cityid,
                phone = c.phone,
                email = c.email,
                portfolio_website = c.portfolio_website,
                address = c.address,
                about_me = c.about_me,
                education = c.education,
                experience = c.experience,
                project=c.project,
                skillids = c.skillids,
                linkedin = c.linkedin,
                facebook = c.facebook,
                instagram=c.instagram,
                twitter=c.twitter,
                UserId = c.UserId,
                title = c.title,
                image = c.image != null ? Convert.ToBase64String(c.image) : null,
            });
            var data = Mapper.Map<IEnumerable<CandidateDto>>(candidatelist);
            return Ok(data);
        }

        //[Authorize(Roles = "Admin,Company")]
        [Route("api/Candidate/ApplyJob")]
        public IHttpActionResult ApplyJob(int id)
        {
            var identity = HttpContext.Current.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userIdClaim = identity.FindFirst(ClaimTypes.NameIdentifier);
                if (userIdClaim != null)
                {
                    var userId = userIdClaim.Value;
                    var check_job_exist = _context.jobs.SingleOrDefault(c => c.id == id);
                    if (check_job_exist == null)
                        return BadRequest("Job Not Found");

                    var candidate_id = _context.candidate.SingleOrDefault(c => c.UserId == userId).id;
                    var check_job_same_candidate = _context.candidate_job.Where(c => c.jobid == id && c.candidateid == candidate_id).SingleOrDefault(c => c.jobid == id);
                    if (check_job_same_candidate != null)
                        return BadRequest("You are already applied for this job");

                    var candidate_job = new CandidateJobDto
                    {
                        candidateid = candidate_id,
                        jobid = id
                    };

                    var Candidatejob = Mapper.Map<CandidateJobDto, CandidateJobMapper>(candidate_job);
                    Candidatejob.created_at = DateTime.Now;
                    _context.candidate_job.Add(Candidatejob);
                    _context.SaveChanges();

                    return Ok("Job Applied Successfully");
                }
            }

            return BadRequest("You are Not Authorized, please Login!");
        }

        //[Authorize(Roles = "Admin,Company")]
        [Route("api/Candidate/GetCandidateJobs")]
        [HttpGet]
        public IHttpActionResult CanidateJobs(int start,int end)
        {
            var identity = HttpContext.Current.User.Identity as ClaimsIdentity;
            var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var query = _context.candidate_job
                    .Where(jm => jm.candidate.UserId == userId);

            var totalRecords = query.Count();

            var limitedRecords = query
                 .Join(_context.jobs,
                  cj => cj.jobid,
                  j => j.id,
                  (cj, j) => new { Job = j, CandidateJobMapper = cj })
                 .Join(_context.company_job,
                  candidate_job => candidate_job.Job.id,
                  company_job => company_job.jobid,
                  (candidate_job, company_job) => new { can_job = candidate_job, com_job = company_job })
                 .Join(_context.company,
                  mapper => mapper.com_job.companyid,
                  company => company.id,
                  (mapper, company) => new 
                  {
                    id = mapper.can_job.Job.id,
                    title = mapper.can_job.Job.title,
                    name=company.name,
                    address = _context.country.FirstOrDefault(co=> co.id== mapper.can_job.Job.country.id).name,
                    created_at = mapper.can_job.Job.created_at,
                    JobType = _context.job_type.FirstOrDefault(j => j.id == mapper.can_job.Job.job_typeid).name
                })
                .OrderByDescending(j=>j.created_at)
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
