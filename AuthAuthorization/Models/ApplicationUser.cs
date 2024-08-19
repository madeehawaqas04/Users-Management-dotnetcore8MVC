using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AuthAuthorization.Models
{
    public class ApplicationUser :IdentityUser
    {
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Profile Picture")]
        public byte[]? ProfilePicture { get; set; } 
        public DateTime CreatedAt { get; set; }
    }
}
