using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevHub.Models
{
    [Table(name: "company_job_mapper")]
    public class CompanyJobMapper
    {
        public int id { get; set; }

        public string status { get; set; }
        public int companyid { get; set; }
        public CompanyModel company { get; set; }

        public int jobid { get; set; }
        public JobModel job { get; set; }
    }
}