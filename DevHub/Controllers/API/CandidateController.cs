using AutoMapper;
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
        //[Authorize(Roles = "Admin,Candidate")]
        public IHttpActionResult PostCandidate()
        {
            var HttpCtx = HttpContext.Current.Request;
            CandidateDto candidateDto=null;
            HttpPostedFile image = null;
            HttpPostedFile resume = null;
            foreach (string key in HttpCtx.Form.AllKeys)
            {
                string value = HttpCtx.Form[key];
                if (IsJson(value))
                {
                    // Deserialize the JSON string into your DTO object
                    JObject jsonObject = JsonConvert.DeserializeObject<JObject>(value);
                    if(jsonObject.ContainsKey("education")){
                        jsonObject["education"] = jsonObject["education"].ToString();
                    }
                    if(jsonObject.ContainsKey("experience")){
                        jsonObject["experience"] = jsonObject["experience"].ToString();
                    }
                    if(jsonObject.ContainsKey("skillids")){
                        jsonObject["skillids"] = jsonObject["skillids"].ToString();
                    }

                    candidateDto = jsonObject.ToObject<CandidateDto>();
                    //candidateDto = JsonConvert.DeserializeObject<CandidateDto>(value);
                }
            }
            if (candidateDto == null)
                return BadRequest("Request is Invalid");

            var candidate=Mapper.Map<CandidateDto, CandidateModel>(candidateDto);
            var check_candidate_exist = _context.candidate.SingleOrDefault(c => c.UserId == candidate.UserId);
            if (check_candidate_exist != null)
                return BadRequest("Candidate Profile Already Created");

            if (HttpCtx.Files.Count > 0)
            {
                foreach (string file in HttpCtx.Files)
                {
                    if (file.Equals("image"))
                        image = HttpCtx.Files[file];

                    if (file.Equals("resume"))
                        resume = HttpCtx.Files[file];
                }
                string fileExtension = "";
                int imageSize = 1048576; //1 MB(int)
                int resumesize = 3145728; //3 MB(int)
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".pdf", ".doc", ".docx" };
                if (image != null && image.ContentLength>0)
                {
                    fileExtension = Path.GetExtension(image.FileName).ToLower();
                    if(Array.IndexOf(allowedExtensions, fileExtension) >= 0 && Array.IndexOf(allowedExtensions, fileExtension) < 3 && image.ContentLength<=imageSize)
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
                if (resume != null && resume.ContentLength>0)
                {
                    fileExtension = Path.GetExtension(resume.FileName).ToLower();
                    if (Array.IndexOf(allowedExtensions, fileExtension) >= 0 && resume.ContentLength <= resumesize)
                    {
                        Stream stream = resume.InputStream;
                        BinaryReader binaryReader = new BinaryReader(stream);
                        candidate.resume = binaryReader.ReadBytes((int)stream.Length);
                    }
                    else
                    {
                        return BadRequest("resume should be in the format jpg/jpeg/png/pdf/doc/docs and less than 3 MB");
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
        //[Authorize(Roles = "Admin,Candidate")]
        public IHttpActionResult UpdateCandidate(int id)
        {
            var  old_candidate = _context.candidate.SingleOrDefault(c => c.id == id);
            if (old_candidate == null)
                return BadRequest("Candidate Not Found");

            var HttpCtx = HttpContext.Current.Request;
            CandidateDto candidateDto=null;
            HttpPostedFile image = null;
            HttpPostedFile resume = null;
            foreach (string key in HttpCtx.Form.AllKeys)
            {
                string value = HttpCtx.Form[key];
                if (IsJson(value))
                {
                    // Deserialize the JSON string into your DTO object
                    JObject jsonObject = JsonConvert.DeserializeObject<JObject>(value);
                    if(jsonObject.ContainsKey("education")){
                        jsonObject["education"] = jsonObject["education"].ToString();
                    }
                    if(jsonObject.ContainsKey("experience")){
                        jsonObject["experience"] = jsonObject["experience"].ToString();
                    }
                    if(jsonObject.ContainsKey("skillids")){
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

            var candidate=Mapper.Map(candidateDto, old_candidate);

            if (HttpCtx.Files.Count > 0)
            {
                foreach (string file in HttpCtx.Files)
                {
                    if (file.Equals("image"))
                        image = HttpCtx.Files[file];

                    if (file.Equals("resume"))
                        resume = HttpCtx.Files[file];
                }
                string fileExtension = "";
                int imageSize = 1048576; //1 MB(int)
                int resumesize = 3145728; //3 MB(int)
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".pdf", ".doc", ".docx" };
                if (image != null && image.ContentLength>0)
                {
                    fileExtension = Path.GetExtension(image.FileName).ToLower();
                    if(Array.IndexOf(allowedExtensions, fileExtension) >= 0 && Array.IndexOf(allowedExtensions, fileExtension) < 3 && image.ContentLength<=imageSize)
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
                if (resume != null && resume.ContentLength>0)
                {
                    fileExtension = Path.GetExtension(resume.FileName).ToLower();
                    if (Array.IndexOf(allowedExtensions, fileExtension) >= 0 && resume.ContentLength <= resumesize)
                    {
                        Stream stream = resume.InputStream;
                        BinaryReader binaryReader = new BinaryReader(stream);
                        candidate.resume = binaryReader.ReadBytes((int)stream.Length);
                    }
                    else
                    {
                        return BadRequest("resume should be in the format jpg/jpeg/png/pdf/doc/docs and less than 3 MB");
                    }
                }
            }
        
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

        //[Authorize(Roles = "Admin,Candidate")]
        public IHttpActionResult GetCandidate(int id)
        {
            var candidate = _context.candidate.Where(c => c.id == id).AsEnumerable().Select(c => new CandidateDto
            {   
                    id=c.id,
                    first_name = c.first_name,
                    last_name=c.last_name,
                    surname=c.surname,
                    dob=c.dob,
                    gender=c.gender,
                    countryid=c.countryid,
                    stateid=c.stateid,
                    cityid=c.cityid,
                    phone=c.phone,
                    email=c.email,
                    portfolio_website=c.portfolio_website,
                    address=c.address,
                    about_me=c.about_me,
                    education=c.education,
                    experience=c.experience,
                    skillids=c.skillids,
                    linkedin=c.linkedin,
                    facebook=c.facebook,
                    UserId=c.UserId,
                    image = c.image != null ? Convert.ToBase64String(c.image) : null,
                    resume = c.resume != null ? Convert.ToBase64String(c.resume) : null
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
                last_name = c.last_name,
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
                skillids = c.skillids,
                linkedin = c.linkedin,
                facebook = c.facebook,
                UserId = c.UserId,
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

            if (identity != null) {
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
                        candidateid =candidate_id,
                        jobid=id
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
        public IHttpActionResult CanidateJobs(int id)
        {
            var candidateJobs = _context.candidate_job
                         .Where(cj => cj.candidateid == id)
                         .SelectMany(cj => _context.jobs.Where(j => j.id == cj.jobid))
                         .ToList().Select(job => Mapper.Map<JobModel, JobDto>(job));
            return Ok(candidateJobs);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
    }
}
