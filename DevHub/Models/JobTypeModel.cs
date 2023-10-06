using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevHub.Models
{
    [Table(name: "job_type")]
    public class JobTypeModel
    {
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; }
    }
}