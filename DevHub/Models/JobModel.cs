using System;
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
        [Required]
        public string title { get; set; }

        [Required]
        public long min_salary { get; set; }

        [Required]
        public long max_salary { get; set; }

        [Required]
        public int stype { get; set; }

        [StringLength(2500)]
        public string qualification { get; set; }

        [StringLength(2500)]
        public string responsibilities { get; set; }

        [StringLength(2500)]
        public string experience { get; set; }  

        [StringLength(100)]
        [Required]
        public string email { get; set; }

        [StringLength(15)]
        public string phone { get; set; }

        [Required]
        [StringLength(2500)]
        public string description { get; set; }

        public byte[] document { get; set; }
 
        [Required]
        public int job_typeid { get; set; }
        public JobTypeModel job_type { get; set; }

        [Required]
        public string job_categoryids { get; set; } //json

        [Required]
        public string modeids { get; set; } //json

        [Required]
        public int countryid { get; set; }
        public CountryModel country { get; set; }
        
        [Required]
        public int stateid { get; set; }
        public StateModel state { get; set; }
        
        [Required]
        public int cityid { get; set; }
        public CityModel city { get; set; }
        
        [Required]
        public string skillids { get; set; } //json

        public DateTime created_at { get; set; }
        public DateTime? updated_at { get; set; }
    }
}