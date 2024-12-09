using Microsoft.AspNetCore.Identity;

namespace CustomAuthentication.Models
{
    public class Users: IdentityUser
    {
        public string FullName { get; set; }
    }
}
