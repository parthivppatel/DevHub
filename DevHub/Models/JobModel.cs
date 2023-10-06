using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevHub.Models
{
    [Table(name: "jobs")]
    public class JobModel
    {
        public int id { get; set; }

        [StringLength(50)]
        public string title { get; set; }
        public long min_salary { get; set; }
        public long max_salary { get; set; }
        public string qualification { get; set; }
        public string responsibilities { get; set; }
        public string experience { get; set; }  

        [StringLength(100)]
        public string email { get; set; }
        public long phone { get; set; }
        public string gender { get; set; }
        public string description { get; set; }
        public string document { get; set; }
        public int job_typeid { get; set; }
        public JobTypeModel job_type { get; set; }
        public string job_categoryids { get; set; } //json
        public string modeids { get; set; } //json
        public int countryid { get; set; }
        public CountryModel country { get; set; }
        public int stateid { get; set; }
        public StateModel state { get; set; }
        public int cityid { get; set; }
        public CityModel city { get; set; }
        public string skillids { get; set; } //json
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}