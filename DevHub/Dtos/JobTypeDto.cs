using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevHub.Dtos
{
    public class JobTypeDto
    {
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; }
    }
}