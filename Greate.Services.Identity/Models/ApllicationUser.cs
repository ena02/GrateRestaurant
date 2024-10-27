using Microsoft.AspNetCore.Identity;

namespace Greate.Services.Identity.Models
{
    public class ApllicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
