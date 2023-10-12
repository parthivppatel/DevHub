using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevHub.Dtos
{
    public class CompanyDto
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }
        public string logo { get; set; }

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
        public int stateid { get; set; }
        public int cityid { get; set; }
        public string UserId { get; set; }
    }
}