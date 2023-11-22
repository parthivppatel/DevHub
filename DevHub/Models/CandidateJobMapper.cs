using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DevHub.Models
{
    [Table(name: "candidate_job_mapper")]
    public class CandidateJobMapper
    {
        public int id { get; set; }
        public int candidateid { get; set; }
        public CandidateModel candidate { get; set; }

        public int jobid { get; set; }
        public JobModel job { get; set; }

        [Required]
        public string stage { get; set; }

        public DateTime created_at { get; set; }
    }
}