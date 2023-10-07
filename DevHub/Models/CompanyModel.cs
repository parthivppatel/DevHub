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
        public string name { get; set; }
        public byte[] logo { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(100)]
        public string website { get; set; }

        [StringLength(100)]
        public string email { get; set; }
        public long phone { get; set; } 
        public string overview { get; set; }
        public string service { get; set; }
        public int countryid { get; set; }
        public CountryModel country { get; set; }
        public int stateid { get; set; }
        public StateModel state { get; set; }
        public int cityid { get; set; }
        public CityModel city { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}