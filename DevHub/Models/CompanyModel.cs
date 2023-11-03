using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevHub.Models
{
    [Table(name: "companies")]
    public class CompanyModel
    {
        public int id { get; set; }

        [StringLength(50)]
        [Required]
        public string name { get; set; }
        public byte[] logo { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(100)]
        public string website { get; set; }

        [Required]
        public int people { get; set; }

        [StringLength(100)]
        [Required]
        public string email { get; set; }

        public long phone { get; set; } 
        public string overview { get; set; }

        [Required]
        public string services { get; set; }
        
        [Required]
        public int countryid { get; set; }
        public CountryModel country { get; set; }

        [Required]
        public int stateid { get; set; }
        public StateModel state { get; set; }

        [Required]
        public int cityid { get; set; }
        public CityModel city { get; set; }

        public string facebook { get; set; }
        public string instagram { get; set; }
        public string linkedin { get; set; }
        public string twitter { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? updated_at { get; set; }
    }
}