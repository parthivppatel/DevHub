using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevHub.Models
{
    [Table(name: "cities")]
    public class CityModel
    {
        public int id { get; set; }

        [StringLength(255)]
        public string cityname { get; set; }

        public int stateid { get; set; }

        public StateModel state { get; set; }
    }
}