using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevHub.Models;

namespace DevHub.Dtos
{
    public class CompanyJobDto
    {
        public int id { get; set; }
        public int companyid { get; set; }
        
        public CompanyModel Company;
        public int jobid { get; set; }

        public JobModel Job;
    }
}