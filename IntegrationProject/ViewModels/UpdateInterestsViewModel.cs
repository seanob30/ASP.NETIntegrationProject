using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using IntegrationProject.Models;

namespace IntegrationProject.ViewModels
{
    public class UpdateInterestsViewModel
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
}