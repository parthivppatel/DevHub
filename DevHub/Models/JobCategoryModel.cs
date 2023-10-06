using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevHub.Models
{
    [Table(name: "job_category")]
    public class JobCategoryModel
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}