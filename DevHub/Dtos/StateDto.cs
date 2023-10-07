using DevHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevHub.Dtos
{
    public class StateDto
    {
        public int id { get; set; }

        [StringLength(255)]
        public string statename { get; set; }
    }
}