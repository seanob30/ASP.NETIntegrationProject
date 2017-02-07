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
            public string UserId { get; set; }
            public bool Comedy { get; set; }
            public bool Concerts { get; set; }
            public bool Conferences { get; set; }
            public bool Education { get; set; }
            public bool Family { get; set; }
            public bool Festivals { get; set; }
            public bool Film { get; set; }
            public bool Food { get; set; }
            public bool Fundraisers { get; set; }
            public bool Galleries { get; set; }
            public bool Health { get; set; }
            public bool Holidays { get; set; }
            public bool Literary { get; set; }
            public bool Musuems { get; set; }
            public bool Neighboorhood { get; set; }
            public bool NightLife { get; set; }
            public bool OnCampus { get; set; }
            public bool Organizations { get; set; }
            public bool Outdoors { get; set; }
            public bool Pets { get; set; }
            public bool PerformingArts { get; set; }
            public bool Politics { get; set; }
            public bool Sales { get; set; }
            public bool Science { get; set; }
            public bool Spiritualality { get; set; }
            public bool Sports { get; set; }
            public bool Technology { get; set; }
        }
    }