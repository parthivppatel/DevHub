﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevHub.Models
{
    [Table(name: "countries")]
    public class CountryModel
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

    }
}