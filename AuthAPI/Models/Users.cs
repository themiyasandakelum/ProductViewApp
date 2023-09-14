using Microsoft.AspNetCore.Identity;

namespace Services.AuthAPI.Models
{
    public class Users : IdentityUser
    {
        public string Name {get; set; }
    }
}
