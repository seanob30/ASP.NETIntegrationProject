using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Ajax.Utilities;

namespace IntegrationProject.Models

{
    public class ExternalLoginConfirmationViewModel
    {
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

        public int AccountTypeId { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        

        public IEnumerable<Days> DaysList { get; set; }
        public IEnumerable<Months> MonthsList { get; set; }
        public IEnumerable<Years> YearsList { get; set; }

    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
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
   
        public int AccountTypeId { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public IEnumerable<Days> DaysList { get; set; }
        public IEnumerable<Months> MonthsList { get; set; }
        public IEnumerable<Years> YearsList { get; set; }

    }

    public class SelectInterestsViewModel
    {
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        [Display(Name = "Comedy")]
        public bool Comedy { get; set; }
        [Display(Name = "Concerts")]
        public bool Concerts { get; set; }
        [Display(Name = "Conferences")]
        public bool Conferences { get; set; }
        [Display(Name = "Education")]
        public bool Education { get; set; }
        [Display(Name = "Family")]
        public bool Family { get; set; }
        [Display(Name = "Festivals")]
        public bool Festivals { get; set; }
        [Display(Name = "Film")]
        public bool Film { get; set; }
        [Display(Name = "Food")]
        public bool Food { get; set; }
        [Display(Name = "Fundraisers")]
        public bool Fundraisers { get; set; }
        [Display(Name = "Galleries")]
        public bool Galleries { get; set; }
        [Display(Name = "Health")]
        public bool Health { get; set; }
        [Display(Name = "Holidays")]
        public bool Holidays { get; set; }
        [Display(Name = "Literary")]
        public bool Literary { get; set; }
        [Display(Name = "Musuems")]
        public bool Musuems { get; set; }
        [Display(Name = "Neighboorhood")]
        public bool Neighboorhood { get; set; }
        [Display(Name = "Night Life")]
        public bool NightLife { get; set; }
        [Display(Name = "On Campus")]
        public bool OnCampus { get; set; }
        [Display(Name = "Organizations")]
        public bool Organizations { get; set; }
        [Display(Name = "Outdoors")]
        public bool Outdoors { get; set; }
        [Display(Name = "Pets")]
        public bool Pets { get; set; }
        [Display(Name = "Performing Arts")]
        public bool PerformingArts { get; set; }
        [Display(Name = "Politics")]
        public bool Politics { get; set; }
        [Display(Name = "Sales")]
        public bool Sales { get; set; }
        [Display(Name = "Science")]
        public bool Science { get; set; }
        [Display(Name = "Spiritualality")]
        public bool Spiritualality { get; set; }
        [Display(Name = "Sports")]
        public bool Sports { get; set; }
        [Display(Name = "Technology")]
        public bool Technology { get; set; }

        public IEnumerable<string> InterestsList = new List<string>
        {
            "Comedy", "Concerts", "Conferences", "Education", "Family", "Festivals", "Film", "Food", "Fundraisers",
            "Galleries", "Health", "Holidays", "Literary", "Musuems", "Neighboorhood", "Night Life", "On Campus",
            "Organizations", "Outdoors", "Pets", "Performing Arts", "Politics", "Sales", "Science", "Spiritualality",
            "Sports", "Technology"
        };
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
