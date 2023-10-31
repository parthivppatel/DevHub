using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevHub.Models
{
    [Table(name: "candidates")]
    public class CandidateModel
    {
        public int id { get; set; }
        public byte[] image { get; set; }

        [Required]
        [StringLength(50)]
        public string first_name { get; set; }

        [StringLength(50)]
        public string middle_name { get; set; }

        [Required]
        [StringLength(50)]
        public string surname { get; set; }

        [Required]
        [StringLength(20)]
        public string dob { get; set; }

        [Required]
        [StringLength(50)]
        public string title { get; set; }

        [Required]
        [StringLength(1)]
        public string gender { get; set; }

        [Required]
        public int countryid { get; set; }
        public CountryModel country { get; set; }

        [Required]
        public int stateid { get; set; }
        public StateModel state { get; set; }

        [Required]
        public int cityid { get; set; }
        public CityModel city { get; set; }

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
        //[DataType(DataType.MultilineText)]
        public string skillids { get; set; } //json
        public string linkedin { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
 
        public DateTime created_at { get; set; }

        public DateTime? updated_at { get; set; }
    }
}