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
        [Required]
        public string title { get; set; }
        
        [Required]
        public long min_salary { get; set; }
        
        [Required]
        public long max_salary { get; set; }
        
        [Required]
        public int stype { get; set; }
        
        [StringLength(50)]
        public string qualification { get; set; }

        [StringLength(50)]
        public string responsibilities { get; set; }

        [StringLength(50)]
        public string experience { get; set; }
        
        public string company_name { get; set; }
        public string company_address { get; set; }
        public string company_logo { get; set; }
        public int company_id {get; set;}

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [StringLength(15)]
        public string phone { get; set; }
       
       [Required]
       [StringLength(50)]
        public string description { get; set; }
        public string document { get; set; }
        
        [Required]
        public int job_typeid { get; set; }
        public string job_type_name { get; set; }
        
        [Required]
        public string job_categoryids { get; set; } //json

        [Required]
        public string modeids { get; set; } //json

        [Required]
        public int countryid { get; set; }
        public string city_name { get; set; }

        [Required]
        public int stateid { get; set; }

        [Required]
        public int cityid { get; set; }

        [Required]
        public string skillids { get; set; } //json
        public DateTime created_at { get; set; }

    }
}