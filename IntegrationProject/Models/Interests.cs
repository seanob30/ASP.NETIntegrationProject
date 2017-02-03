using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntegrationProject.Models
{
    public class Interests
    {
        [Key]
        public int Id { get; set; }

        public ApplicationUser User { get; set; }
        public int UserId { get; set; }
    }
}