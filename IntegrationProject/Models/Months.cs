using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntegrationProject.Models
{
    public class Months
    {
        [Key]
        public int Id { get; set; }

        public string Month { get; set; }   
    }
}