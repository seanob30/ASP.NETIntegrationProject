using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using IntegrationProject.Models;

namespace IntegrationProject.ViewModels
{
    public class DashBoardViewModels
    {
        public ApplicationUser User { get; set; }
        public Interests Interest { get; set; }
        public IEnumerable<string> SelectedInterestsList { get; set; }
    }
}