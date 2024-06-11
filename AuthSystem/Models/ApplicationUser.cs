using Microsoft.AspNetCore.Identity;

namespace AuthSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = "";
    }
}
