using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IntegrationProject.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Days Day { get; set; }
        public int DayId { get; set; }
        public Months Month { get; set; }
        public int MonthId { get; set; }
        public Years Year { get; set; }
        public int YearId { get; set; }
        public override string PhoneNumber { get; set; }
        public string ZipCode { get; set; }
        public AccountTypes AccountType { get; set; }
        public int AccountTypeId { get; set; }
        public int Rating { get; set; } 

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<AccountTypes> AccountType { get; set; }
        public DbSet<Days> Day { get; set; }
        public DbSet<Hours> Hour { get; set; }
        public DbSet<Interests> Interest { get; set; }
        public DbSet<Months> Months { get; set; }
        public DbSet<Years> Year { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}