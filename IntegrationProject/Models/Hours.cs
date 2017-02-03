using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntegrationProject.Models
{
    public class Hours
    {
        [Key]
        public int Id { get; set; }

        public string Hour { get; set; }

    }
}