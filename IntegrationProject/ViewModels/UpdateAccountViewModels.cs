using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using IntegrationProject.Models;

namespace IntegrationProject.ViewModels
{
    public class UpdateAccountViewModels
    {
        private ApplicationDbContext _context;

        public UpdateAccountViewModels()
        {
            _context = new ApplicationDbContext();
        }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Day")]
        public int DayId { get; set; }

        [Required]
        [Display(Name = "Month")]
        public int MonthId { get; set; }

        [Required]
        [Display(Name = "Year")]
        public int YearId { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        public IEnumerable<Days> DaysList { get; set; }
        public IEnumerable<Months> MonthsList { get; set; }
        public IEnumerable<Years> YearsList { get; set; }
    }
}