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

        [StringLength(15)]
        public string phone { get; set; } 

        [StringLength(2500)]
        public string overview { get; set; }

        [Required]
        [StringLength(2500)]
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

        [StringLength(200)]
        public string facebook { get; set; }
        [StringLength(200)]
        public string instagram { get; set; }
        [StringLength(200)]
        public string linkedin { get; set; }
        [StringLength(200)]
        public string twitter { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? updated_at { get; set; }
    }
}