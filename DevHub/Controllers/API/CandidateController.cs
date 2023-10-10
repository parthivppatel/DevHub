using AutoMapper;
using DevHub.Dtos;
using DevHub.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
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
                System.Diagnostics.Debug.WriteLine("failed to convert");
                return false;
            }
        }

        [HttpPost]
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
            var candidate=Mapper.Map<CandidateDto, CandidateModel>(candidateDto);
 
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

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
    }
}
