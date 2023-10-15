using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevHub.Dtos
{
    public class JobDto
    {
        public int id { get; set; }

        [StringLength(50)]
        public string title { get; set; }
        public long min_salary { get; set; }
        public long max_salary { get; set; }
        public string qualification { get; set; }
        public string responsibilities { get; set; }
        public string experience { get; set; }

        public int company_id {get; set;}

        [StringLength(100)]
        public string email { get; set; }
        public long phone { get; set; }
        public string gender { get; set; }
        public string description { get; set; }
        public string document { get; set; }
        public int job_typeid { get; set; }
        public string job_categoryids { get; set; } //json
        public string modeids { get; set; } //json
        public int countryid { get; set; }
        public int stateid { get; set; }
        public int cityid { get; set; }
        public string skillids { get; set; } //json
    }
}