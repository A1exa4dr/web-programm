using Microsoft.AspNetCore.Identity;

namespace Lab2_web.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? LastName { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public int? GenderId { get; set; }

        public DateTime? DateBirth { get; set; }

        public string? Phone { get; set; }

        public Gender? Gender { get; set; }
    }

}
