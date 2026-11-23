using Microsoft.AspNetCore.Identity;

namespace CompanyERP.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string? Address { get; set; }
    }
}
