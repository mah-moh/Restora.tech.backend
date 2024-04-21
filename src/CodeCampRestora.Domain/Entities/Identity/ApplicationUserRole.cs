using Microsoft.AspNetCore.Identity;
using CodeCampRestora.Domain.Identity;

namespace CodeCampRestora.Domain.Entities.Identity;

public class ApplicationUserRole : IdentityUserRole<Guid>
{
    public virtual ApplicationUser? ApplicationUser { get; set; }
    public virtual ApplicationRole? ApplicationRole { get; set; }
}