using Microsoft.AspNetCore.Identity;

namespace WebApiCore.Entities;

public class AppRole : IdentityRole<string>
{
    public virtual ICollection<AppUserRole> UserRoles { get; set; }
}