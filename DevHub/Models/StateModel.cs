using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevHub.Models
{
    [Table(name: "states")]
    public class StateModel
    {
        public int id { get; set; }

        [StringLength(255)]
        public string statename { get; set; }

        public int countryid { get; set; }

        public CountryModel country { get; set; }

    }
}