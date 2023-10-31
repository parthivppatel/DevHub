using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevHub.Dtos
{
    public class CandidateDto
    {
        public int id { get; set; }
        public string image { get; set; }

        [Required]
        [StringLength(50)]
        public string first_name { get; set; }

        [StringLength(50)]
        public string middle_name { get; set; }

        [Required]
        [StringLength(50)]
        public string surname { get; set; }

        [Required]
        [StringLength(50)]
        public string title { get; set; }

        [Required]
        [StringLength(20)]
        public string dob { get; set; }

        [Required]
        [StringLength(1)]
        public string gender { get; set; }

        [Required]
        public int countryid { get; set; }

        [Required]
        public int stateid { get; set; }
        
        [Required]
        public int cityid { get; set; }
        public long phone { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [StringLength(100)]
        public string portfolio_website { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [Required]
        public string about_me { get; set; } // overview as template
        public string education { get; set; } //json 
        public string experience { get; set; } //json
        public string project { get; set; } //json
        public string skillids { get; set; } //json
        public string linkedin { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}