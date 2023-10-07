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

        [StringLength(50)]
        public string first_name { get; set; }

        [StringLength(50)]
        public string last_name { get; set; }

        [StringLength(50)]
        public string surname { get; set; }

        [StringLength(20)]
        public string dob { get; set; }

        [StringLength(1)]
        public string gender { get; set; }

        public int countryid { get; set; }
        public CountryModel country { get; set; }

        public int stateid { get; set; }
        public StateModel state { get; set; }

        public int cityid { get; set; }
        public CityModel city { get; set; }

        public long phone { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(100)]
        public string portfolio_website { get; set; }

        [StringLength(255)]
        public string address { get; set; }
        public string about_me { get; set; } // overview as template
        public string education { get; set; } //json 
        public string experience { get; set; } //json
        public string skillids { get; set; } //json
        public int proficiency { get; set; }
        public string linkedin { get; set; }
        public string facebook { get; set; }
        public byte[] resume { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }






    }
}